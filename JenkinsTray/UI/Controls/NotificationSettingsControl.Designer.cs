namespace JenkinsTray.UI.Controls
{
    partial class NotificationSettingsControl
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
            this.pathEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel = new DevExpress.XtraEditors.LabelControl();
            this.testSoundButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pathEdit.Properties)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathEdit
            // 
            this.pathEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pathEdit.Location = new System.Drawing.Point(93, 3);
            this.pathEdit.Name = "pathEdit";
            this.pathEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)});
            this.pathEdit.Size = new System.Drawing.Size(100, 21);
            this.pathEdit.TabIndex = 1;
            this.pathEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.pathEdit_ButtonClick);
            this.pathEdit.EditValueChanged += new System.EventHandler(this.pathEdit_EditValueChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.pathEdit, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.testSoundButton, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.statusLabel, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(277, 29);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.statusLabel.Location = new System.Drawing.Point(3, 8);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(30, 13);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Sound";
            // 
            // testSoundButton
            // 
            this.testSoundButton.Location = new System.Drawing.Point(199, 3);
            this.testSoundButton.Name = "testSoundButton";
            this.testSoundButton.Size = new System.Drawing.Size(75, 23);
            this.testSoundButton.TabIndex = 3;
            this.testSoundButton.Text = "Test";
            this.testSoundButton.Click += new System.EventHandler(this.testSoundButton_Click);
            // 
            // NotificationSettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "NotificationSettingsControl";
            this.Size = new System.Drawing.Size(277, 29);
            ((System.ComponentModel.ISupportInitialize)(this.pathEdit.Properties)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit pathEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DevExpress.XtraEditors.LabelControl statusLabel;
        private DevExpress.XtraEditors.SimpleButton testSoundButton;
    }
}
