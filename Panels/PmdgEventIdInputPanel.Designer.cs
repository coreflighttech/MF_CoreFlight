﻿namespace MobiFlight.Panels
{
    partial class PmdgEventIdInputPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PmdgEventIdInputPanel));
            this.fsuipcPresetComboBox = new System.Windows.Forms.ComboBox();
            this.fsuipcLoadPresetGroupBox = new System.Windows.Forms.GroupBox();
            this.fsuipcPresetUseButton = new System.Windows.Forms.Button();
            this.eventIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventIdLabel = new System.Windows.Forms.Label();
            this.paramLabel = new System.Windows.Forms.Label();
            this.MouseEventComboBox = new System.Windows.Forms.ComboBox();
            this.fsuipcLoadPresetGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fsuipcPresetComboBox
            // 
            resources.ApplyResources(this.fsuipcPresetComboBox, "fsuipcPresetComboBox");
            this.fsuipcPresetComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.fsuipcPresetComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fsuipcPresetComboBox.FormattingEnabled = true;
            this.fsuipcPresetComboBox.Name = "fsuipcPresetComboBox";
            // 
            // fsuipcLoadPresetGroupBox
            // 
            this.fsuipcLoadPresetGroupBox.Controls.Add(this.fsuipcPresetUseButton);
            this.fsuipcLoadPresetGroupBox.Controls.Add(this.fsuipcPresetComboBox);
            resources.ApplyResources(this.fsuipcLoadPresetGroupBox, "fsuipcLoadPresetGroupBox");
            this.fsuipcLoadPresetGroupBox.Name = "fsuipcLoadPresetGroupBox";
            this.fsuipcLoadPresetGroupBox.TabStop = false;
            // 
            // fsuipcPresetUseButton
            // 
            resources.ApplyResources(this.fsuipcPresetUseButton, "fsuipcPresetUseButton");
            this.fsuipcPresetUseButton.Name = "fsuipcPresetUseButton";
            this.fsuipcPresetUseButton.UseVisualStyleBackColor = true;
            this.fsuipcPresetUseButton.Click += new System.EventHandler(this.fsuipcPresetUseButton_Click);
            // 
            // eventIdTextBox
            // 
            resources.ApplyResources(this.eventIdTextBox, "eventIdTextBox");
            this.eventIdTextBox.Name = "eventIdTextBox";
            this.eventIdTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.eventIdTextBox_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MouseEventComboBox);
            this.groupBox1.Controls.Add(this.eventIdTextBox);
            this.groupBox1.Controls.Add(this.EventIdLabel);
            this.groupBox1.Controls.Add(this.paramLabel);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // EventIdLabel
            // 
            resources.ApplyResources(this.EventIdLabel, "EventIdLabel");
            this.EventIdLabel.Name = "EventIdLabel";
            // 
            // paramLabel
            // 
            resources.ApplyResources(this.paramLabel, "paramLabel");
            this.paramLabel.Name = "paramLabel";
            // 
            // MouseEventComboBox
            // 
            this.MouseEventComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.MouseEventComboBox, "MouseEventComboBox");
            this.MouseEventComboBox.Name = "MouseEventComboBox";
            // 
            // PmdgEventIdInputPanel
            // 
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fsuipcLoadPresetGroupBox);
            this.Name = "PmdgEventIdInputPanel";
            resources.ApplyResources(this, "$this");
            this.Load += new System.EventHandler(this.EventIdInputPanel_Load);
            this.fsuipcLoadPresetGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox fsuipcPresetComboBox;
        private System.Windows.Forms.GroupBox fsuipcLoadPresetGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paramLabel;
        private System.Windows.Forms.Label EventIdLabel;
        private System.Windows.Forms.TextBox eventIdTextBox;
        private System.Windows.Forms.Button fsuipcPresetUseButton;
        private System.Windows.Forms.ComboBox MouseEventComboBox;
    }
}