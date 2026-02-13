using ExolinerExternalUI.Classes;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExolinerExternalUI {
    public partial class LoginForm : Form {
        private string defaultLoginButtonText = "";
        private string errorMessage = "";
        public LoginForm() {
            InitializeComponent();
            this.rememberCheck.Checked = FileManager.CurrentSettings.AutoLogin;
            this.passwordBox.Text = FileManager.CurrentSettings.JWT;
            defaultLoginButtonText = this.loginButton.Text;
        }

        private void processLogin_DoWork(object sender, DoWorkEventArgs e) {
            if (this.rememberCheck.Checked) {
                FileManager.CurrentSettings.JWT = this.passwordBox.Text;
            }
            FileManager.CurrentSettings.AutoLogin = this.rememberCheck.Checked;

            ExolinerApiWrapper.JSONWebToken = this.passwordBox.Text;
            Task<ExolinerApiWrapper.ExolinerUser> request = ExolinerApiWrapper.GetInfo();
            request.Wait();
            ExolinerApiWrapper.ExolinerUser result = request.Result;
            Thread.Sleep(500);
            errorMessage = result.success ? "" : result.message;
        }
        private void processLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.errorLabel.Text = errorMessage;
            this.loginButton.Text = defaultLoginButtonText;
            this.loginButton.Enabled = true;
            if (errorMessage == "") {
                // No error, we can continue
                Task.Run(() => {
                    this.Invoke((MethodInvoker)delegate { this.Hide(); });
                });
                Form editorForm = new ExecutorForm();
                editorForm.Owner = this;
                editorForm.ShowDialog();
                this.Close();
            }
        }

        private void loginButton_Click(object sender, System.EventArgs e) {
            if (processLogin.IsBusy) return; // Already trying to login
            processLogin.RunWorkerAsync();
            errorMessage = "";
            this.errorLabel.Text = "";
            this.loginButton.Enabled = false;
            this.loginButton.Text = "...";
        }

        private void LoginForm_Load(object sender, System.EventArgs e) {
            this.errorLabel.Text = "";
            WinExternals.AnimateWindow(this.Handle, 500, WinExternals.AnimateWindowFlags.AW_BLEND);
        }
    }
}
