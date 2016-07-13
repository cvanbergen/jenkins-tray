using System;
using System.Windows.Forms;
using JenkinsTray.BusinessComponents;
using Spring.Context.Support;

namespace JenkinsTray.UI
{
    public partial class MainSettingsForm : Form
    {
        private ApplicationUpdateService applicationUpdateService;

        public MainSettingsForm()
        {
            InitializeComponent();
        }

        public static MainSettingsForm Instance
        {
            get
            {
                var instance = (MainSettingsForm) ContextRegistry.GetContext().GetObject("SettingsForm");
                return instance;
            }
        }

        public ConfigurationService ConfigurationService { get; set; }
        public JenkinsService JenkinsService { get; set; }

        public static void ShowDialogOrFocus()
        {
            if (Instance.Visible)
                Instance.Focus();
            else
                Instance.ShowDialog();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            tabControl.SelectedTabPageIndex = 0;
        }

        private void checkForUpdatesCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (applicationUpdateService == null)
            {
                applicationUpdateService =
                    (ApplicationUpdateService) ContextRegistry.GetContext().GetObject("ApplicationUpdateService");
            }
            applicationUpdateService.EnableTimer(checkForUpdatesCheckEdit.Checked);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var refreshInterval = int.Parse(refreshSpinEdit.Text);
            ConfigurationService.SetRefreshIntervalInSeconds(refreshInterval);
            ConfigurationService.SetUpdateMainWindowIcon(updateMainWindowIconCheckEdit.Checked);
            ConfigurationService.SetIntegrateWithClaimPlugin(integrateWithClaimPluginCheckEdit.Checked);
            ConfigurationService.SetCheckForUpdates(checkForUpdatesCheckEdit.Checked);
            ConfigurationService.SetTreadUnstableAsFailed(notificationsSettingsControl.TreadUnstableAsFailed());
            ConfigurationService.SetSoundNotifications(notificationsSettingsControl.SoundNotificationsEnabled());
            notificationsSettingsControl.InvalidateData();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            refreshSpinEdit.Text = ConfigurationService.GeneralSettings.RefreshIntervalInSeconds.ToString();
            updateMainWindowIconCheckEdit.Checked = ConfigurationService.GeneralSettings.UpdateMainWindowIcon;
            integrateWithClaimPluginCheckEdit.Checked = ConfigurationService.GeneralSettings.IntegrateWithClaimPlugin;
            checkForUpdatesCheckEdit.Checked = ConfigurationService.GeneralSettings.CheckForUpdates;
            notificationsSettingsControl.InitializeValues();
        }
    }
}