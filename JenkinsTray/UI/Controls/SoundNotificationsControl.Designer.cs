namespace JenkinsTray.UI.Controls
{
    partial class SoundNotificationsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.soundSettingsControl1 = new JenkinsTray.UI.Controls.SoundSettingsControl();
            this.soundSettingsControl2 = new JenkinsTray.UI.Controls.SoundSettingsControl();
            this.soundSettingsControl3 = new JenkinsTray.UI.Controls.SoundSettingsControl();
            this.soundSettingsControl4 = new JenkinsTray.UI.Controls.SoundSettingsControl();
            this.enableSoundCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.treatUnstableAsFailedCheckBox = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enableSoundCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatUnstableAsFailedCheckBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.soundSettingsControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.soundSettingsControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.soundSettingsControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.soundSettingsControl4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.enableSoundCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.treatUnstableAsFailedCheckBox, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(473, 234);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // soundSettingsControl1
            // 
            this.soundSettingsControl1.AutoSize = true;
            this.soundSettingsControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soundSettingsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSettingsControl1.Location = new System.Drawing.Point(3, 29);
            this.soundSettingsControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundSettingsControl1.Name = "soundSettingsControl1";
            this.soundSettingsControl1.Size = new System.Drawing.Size(467, 29);
            this.soundSettingsControl1.SoundPath = "";
            this.soundSettingsControl1.Status = "Failed";
            this.soundSettingsControl1.TabIndex = 1;
            // 
            // soundSettingsControl2
            // 
            this.soundSettingsControl2.AutoSize = true;
            this.soundSettingsControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soundSettingsControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSettingsControl2.Location = new System.Drawing.Point(3, 66);
            this.soundSettingsControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundSettingsControl2.Name = "soundSettingsControl2";
            this.soundSettingsControl2.Size = new System.Drawing.Size(467, 29);
            this.soundSettingsControl2.SoundPath = "";
            this.soundSettingsControl2.Status = "Fixed";
            this.soundSettingsControl2.TabIndex = 2;
            // 
            // soundSettingsControl3
            // 
            this.soundSettingsControl3.AutoSize = true;
            this.soundSettingsControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soundSettingsControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSettingsControl3.Location = new System.Drawing.Point(3, 103);
            this.soundSettingsControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundSettingsControl3.Name = "soundSettingsControl3";
            this.soundSettingsControl3.Size = new System.Drawing.Size(467, 29);
            this.soundSettingsControl3.SoundPath = "";
            this.soundSettingsControl3.Status = "StillFailing";
            this.soundSettingsControl3.TabIndex = 3;
            // 
            // soundSettingsControl4
            // 
            this.soundSettingsControl4.AutoSize = true;
            this.soundSettingsControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.soundSettingsControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundSettingsControl4.Location = new System.Drawing.Point(3, 140);
            this.soundSettingsControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.soundSettingsControl4.Name = "soundSettingsControl4";
            this.soundSettingsControl4.Size = new System.Drawing.Size(467, 29);
            this.soundSettingsControl4.SoundPath = "";
            this.soundSettingsControl4.Status = "Succeeded";
            this.soundSettingsControl4.TabIndex = 3;
            // 
            // enableSoundCheckBox
            // 
            this.enableSoundCheckBox.Location = new System.Drawing.Point(3, 3);
            this.enableSoundCheckBox.Name = "enableSoundCheckBox";
            this.enableSoundCheckBox.Properties.Caption = "&Enable sound notifications";
            this.enableSoundCheckBox.Size = new System.Drawing.Size(150, 19);
            this.enableSoundCheckBox.TabIndex = 0;
            this.enableSoundCheckBox.CheckedChanged += new System.EventHandler(this.enableSoundCheckBox_CheckedChanged);
            // 
            // treatUnstableAsFailedCheckBox
            // 
            this.treatUnstableAsFailedCheckBox.Location = new System.Drawing.Point(3, 176);
            this.treatUnstableAsFailedCheckBox.Name = "treatUnstableAsFailedCheckBox";
            this.treatUnstableAsFailedCheckBox.Properties.Caption = "&Treat unstable as failed";
            this.treatUnstableAsFailedCheckBox.Size = new System.Drawing.Size(139, 19);
            this.treatUnstableAsFailedCheckBox.TabIndex = 9;
            this.treatUnstableAsFailedCheckBox.CheckedChanged += new System.EventHandler(this.treatUnstableAsFailedCheckBox_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 258);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Configure sound notifications";
            // 
            // SoundNotificationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "SoundNotificationsControl";
            this.Size = new System.Drawing.Size(477, 258);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enableSoundCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatUnstableAsFailedCheckBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SoundSettingsControl soundSettingsControl1;
        private SoundSettingsControl soundSettingsControl2;
        private SoundSettingsControl soundSettingsControl3;
        private SoundSettingsControl soundSettingsControl4;
        private DevExpress.XtraEditors.CheckEdit enableSoundCheckBox;
        private DevExpress.XtraEditors.CheckEdit treatUnstableAsFailedCheckBox;
        private DevExpress.XtraEditors.GroupControl groupControl1;


    }
}
