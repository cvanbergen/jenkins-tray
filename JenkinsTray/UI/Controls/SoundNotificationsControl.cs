using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JenkinsTray.BusinessComponents;
using Spring.Context.Support;

namespace JenkinsTray.UI.Controls
{
    public partial class SoundNotificationsControl : DevExpress.XtraEditors.XtraUserControl
    {
        ConfigurationService configurationService;

        public SoundNotificationsControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // designer mode
            if (DesignMode)
                return;

            configurationService = (ConfigurationService)ContextRegistry.GetContext().GetObject("ConfigurationService");
            treatUnstableAsFailedCheckBox.Checked = configurationService.IsTreadUnstableAsFailed();
            enableSoundCheckBox.Checked = configurationService.IsSoundNotificationsEnabled();
            enableSoundCheckBox_CheckedChanged(null, null);
        }

        public void InitializeValues()
        {
            soundSettingsControl1.Initialize();
            soundSettingsControl2.Initialize();
            soundSettingsControl3.Initialize();
            soundSettingsControl4.Initialize();
        }

        public bool SoundNotificationsEnabled()
        {
            return enableSoundCheckBox.Checked;
        }

        private void enableSoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            soundSettingsControl1.Enabled =
                soundSettingsControl2.Enabled =
                soundSettingsControl3.Enabled =
                soundSettingsControl4.Enabled =
                treatUnstableAsFailedCheckBox.Enabled =
                enableSoundCheckBox.Checked;
            configurationService.SetSoundNotifications(enableSoundCheckBox.Checked);
        }

        public bool TreadUnstableAsFailed()
        {
            return treatUnstableAsFailedCheckBox.Checked;
        }

        public void InvalidateData()
        {
            soundSettingsControl1.InvalidateData();
            soundSettingsControl2.InvalidateData();
            soundSettingsControl3.InvalidateData();
            soundSettingsControl4.InvalidateData();
        }

        private void treatUnstableAsFailedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            configurationService.SetTreadUnstableAsFailed(treatUnstableAsFailedCheckBox.Checked);
        }
    }
}
