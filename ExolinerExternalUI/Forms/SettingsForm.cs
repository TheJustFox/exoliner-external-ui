using ExolinerExternalUI.Classes;
using System;
using System.Windows.Forms;

namespace ExolinerExternalUI.Forms {
    public partial class SettingsForm : Form {
        public SettingsForm() {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e) {
            this.scriptRefreshNum.Value = FileManager.CurrentSettings.FolderRescanTime;
            this.autoexecCheck.Checked = FileManager.CurrentSettings.AutoExec;
            this.customPayload.Checked = FileManager.CurrentSettings.ExtraPayload;
            this.soundEffectsCheck.Checked = FileManager.CurrentSettings.SoundEffects;
            this.customPayloadNote.Visible = this.customPayload.Checked;
        }

        private void applyButton_Click(object sender, EventArgs e) {
            FileManager.CurrentSettings.FolderRescanTime = Convert.ToInt32(this.scriptRefreshNum.Value);
            FileManager.CurrentSettings.AutoExec = this.autoexecCheck.Checked;
            FileManager.CurrentSettings.ExtraPayload = this.customPayload.Checked;
            FileManager.CurrentSettings.SoundEffects = this.soundEffectsCheck.Checked;
            FileManager.SaveSettings();
            MessageBox.Show("Done!");
        }

        private void customPayload_CheckedChanged(object sender, EventArgs e) {
            this.customPayloadNote.Visible = ( sender as CheckBox ).Checked;
        }
    }
}
