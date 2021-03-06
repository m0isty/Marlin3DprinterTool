﻿namespace MarlinEditor
{
    partial class FrmFirmware
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFirmware));
            this.grpBxOldFirmware = new System.Windows.Forms.GroupBox();
            this.fctbCurrentFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.lblFeatureValue = new System.Windows.Forms.Label();
            this.lblFeature = new System.Windows.Forms.Label();
            this.txtBxCurrentFirmwareValue = new System.Windows.Forms.TextBox();
            this.btnPassValue = new System.Windows.Forms.Button();
            this.cmbBxFirmwareFeatures = new System.Windows.Forms.ComboBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnUpdateExtruderInFirmware = new System.Windows.Forms.Button();
            this.btnOpenArduinoIde = new System.Windows.Forms.Button();
            this.grpBxNewFirmware = new System.Windows.Forms.GroupBox();
            this.fctbNewFirmware = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpBxOldFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).BeginInit();
            this.grpBxNewFirmware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBxOldFirmware
            // 
            this.grpBxOldFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBxOldFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxOldFirmware.Controls.Add(this.fctbCurrentFirmware);
            this.grpBxOldFirmware.Controls.Add(this.lblFeatureValue);
            this.grpBxOldFirmware.Controls.Add(this.lblFeature);
            this.grpBxOldFirmware.Controls.Add(this.txtBxCurrentFirmwareValue);
            this.grpBxOldFirmware.Controls.Add(this.btnPassValue);
            this.grpBxOldFirmware.Controls.Add(this.cmbBxFirmwareFeatures);
            this.grpBxOldFirmware.Location = new System.Drawing.Point(3, 3);
            this.grpBxOldFirmware.Name = "grpBxOldFirmware";
            this.grpBxOldFirmware.Size = new System.Drawing.Size(495, 456);
            this.grpBxOldFirmware.TabIndex = 28;
            this.grpBxOldFirmware.TabStop = false;
            this.grpBxOldFirmware.Text = "Current Firmware (configuration.h)";
            // 
            // fctbCurrentFirmware
            // 
            this.fctbCurrentFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbCurrentFirmware.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbCurrentFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbCurrentFirmware.BackBrush = null;
            this.fctbCurrentFirmware.BookmarkColor = System.Drawing.Color.Magenta;
            this.fctbCurrentFirmware.CharHeight = 14;
            this.fctbCurrentFirmware.CharWidth = 8;
            this.fctbCurrentFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbCurrentFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbCurrentFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbCurrentFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbCurrentFirmware.IsReplaceMode = false;
            this.fctbCurrentFirmware.Location = new System.Drawing.Point(0, 19);
            this.fctbCurrentFirmware.Name = "fctbCurrentFirmware";
            this.fctbCurrentFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbCurrentFirmware.ReadOnly = true;
            this.fctbCurrentFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbCurrentFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbCurrentFirmware.ServiceColors")));
            this.fctbCurrentFirmware.ShowFoldingLines = true;
            this.fctbCurrentFirmware.Size = new System.Drawing.Size(489, 369);
            this.fctbCurrentFirmware.TabIndex = 48;
            this.fctbCurrentFirmware.Zoom = 100;
            this.fctbCurrentFirmware.SelectionChanged += new System.EventHandler(this.fctbCurrentFirmware_SelectionChanged);
            this.fctbCurrentFirmware.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbCurrentFirmware_TextChangedDelayed);
            // 
            // lblFeatureValue
            // 
            this.lblFeatureValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFeatureValue.AutoSize = true;
            this.lblFeatureValue.Location = new System.Drawing.Point(261, 406);
            this.lblFeatureValue.Name = "lblFeatureValue";
            this.lblFeatureValue.Size = new System.Drawing.Size(73, 13);
            this.lblFeatureValue.TabIndex = 47;
            this.lblFeatureValue.Text = "Feature Value";
            // 
            // lblFeature
            // 
            this.lblFeature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFeature.AutoSize = true;
            this.lblFeature.Location = new System.Drawing.Point(7, 406);
            this.lblFeature.Name = "lblFeature";
            this.lblFeature.Size = new System.Drawing.Size(43, 13);
            this.lblFeature.TabIndex = 46;
            this.lblFeature.Text = "Feature";
            // 
            // txtBxCurrentFirmwareValue
            // 
            this.txtBxCurrentFirmwareValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxCurrentFirmwareValue.Location = new System.Drawing.Point(264, 430);
            this.txtBxCurrentFirmwareValue.Name = "txtBxCurrentFirmwareValue";
            this.txtBxCurrentFirmwareValue.Size = new System.Drawing.Size(225, 20);
            this.txtBxCurrentFirmwareValue.TabIndex = 45;
            // 
            // btnPassValue
            // 
            this.btnPassValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassValue.Location = new System.Drawing.Point(377, 401);
            this.btnPassValue.Name = "btnPassValue";
            this.btnPassValue.Size = new System.Drawing.Size(112, 23);
            this.btnPassValue.TabIndex = 44;
            this.btnPassValue.Text = "Transfer Value -->";
            this.btnPassValue.UseVisualStyleBackColor = true;
            this.btnPassValue.Click += new System.EventHandler(this.btnPassValue_Click);
            // 
            // cmbBxFirmwareFeatures
            // 
            this.cmbBxFirmwareFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBxFirmwareFeatures.FormattingEnabled = true;
            this.cmbBxFirmwareFeatures.Location = new System.Drawing.Point(6, 430);
            this.cmbBxFirmwareFeatures.Name = "cmbBxFirmwareFeatures";
            this.cmbBxFirmwareFeatures.Size = new System.Drawing.Size(252, 21);
            this.cmbBxFirmwareFeatures.TabIndex = 42;
            this.cmbBxFirmwareFeatures.SelectedIndexChanged += new System.EventHandler(this.cmbBxFirmwareFeatures_SelectedIndexChanged);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(6, 397);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(98, 25);
            this.btnCopyToClipboard.TabIndex = 34;
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnExtruderFirmwareCopyToClipboard_Click);
            // 
            // btnUpdateExtruderInFirmware
            // 
            this.btnUpdateExtruderInFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateExtruderInFirmware.Location = new System.Drawing.Point(110, 397);
            this.btnUpdateExtruderInFirmware.Name = "btnUpdateExtruderInFirmware";
            this.btnUpdateExtruderInFirmware.Size = new System.Drawing.Size(238, 23);
            this.btnUpdateExtruderInFirmware.TabIndex = 35;
            this.btnUpdateExtruderInFirmware.Text = "Update and Save Firmware (configuration.h)";
            this.btnUpdateExtruderInFirmware.UseVisualStyleBackColor = true;
            this.btnUpdateExtruderInFirmware.Click += new System.EventHandler(this.btnUpdateExtruderInFirmware_Click);
            // 
            // btnOpenArduinoIde
            // 
            this.btnOpenArduinoIde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenArduinoIde.Location = new System.Drawing.Point(6, 427);
            this.btnOpenArduinoIde.Name = "btnOpenArduinoIde";
            this.btnOpenArduinoIde.Size = new System.Drawing.Size(475, 23);
            this.btnOpenArduinoIde.TabIndex = 22;
            this.btnOpenArduinoIde.Text = "Open Arduino IDE with Marlin.ino";
            this.btnOpenArduinoIde.UseVisualStyleBackColor = true;
            this.btnOpenArduinoIde.Click += new System.EventHandler(this.btnOpenArduinoIde_Click);
            // 
            // grpBxNewFirmware
            // 
            this.grpBxNewFirmware.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpBxNewFirmware.Controls.Add(this.fctbNewFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnOpenArduinoIde);
            this.grpBxNewFirmware.Controls.Add(this.btnUpdateExtruderInFirmware);
            this.grpBxNewFirmware.Controls.Add(this.btnCopyToClipboard);
            this.grpBxNewFirmware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBxNewFirmware.Location = new System.Drawing.Point(0, 0);
            this.grpBxNewFirmware.Name = "grpBxNewFirmware";
            this.grpBxNewFirmware.Size = new System.Drawing.Size(497, 459);
            this.grpBxNewFirmware.TabIndex = 29;
            this.grpBxNewFirmware.TabStop = false;
            this.grpBxNewFirmware.Text = "New Firmware  (configuration.h)";
            // 
            // fctbNewFirmware
            // 
            this.fctbNewFirmware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fctbNewFirmware.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctbNewFirmware.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fctbNewFirmware.BackBrush = null;
            this.fctbNewFirmware.CharHeight = 14;
            this.fctbNewFirmware.CharWidth = 8;
            this.fctbNewFirmware.CurrentLineColor = System.Drawing.Color.Turquoise;
            this.fctbNewFirmware.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctbNewFirmware.DescriptionFile = "C:\\Users\\Johnnyboy\\Documents\\GitHub\\Marlin3DprinterTool\\Marlin3DprinterTool\\Marli" +
    "nComunicationHelper\\ArduinoSyntax.xml";
            this.fctbNewFirmware.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctbNewFirmware.IsReplaceMode = false;
            this.fctbNewFirmware.Location = new System.Drawing.Point(5, 22);
            this.fctbNewFirmware.Name = "fctbNewFirmware";
            this.fctbNewFirmware.Paddings = new System.Windows.Forms.Padding(0);
            this.fctbNewFirmware.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctbNewFirmware.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbNewFirmware.ServiceColors")));
            this.fctbNewFirmware.ShowFoldingLines = true;
            this.fctbNewFirmware.Size = new System.Drawing.Size(489, 369);
            this.fctbNewFirmware.TabIndex = 49;
            this.fctbNewFirmware.Zoom = 100;
            this.fctbNewFirmware.SelectionChanged += new System.EventHandler(this.fctbBoxNewFirmware_SelectionChanged);
            this.fctbNewFirmware.TextChangedDelayed += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fctbNewFirmware_TextChangedDelayed);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpBxOldFirmware);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpBxNewFirmware);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 459);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 30;
            // 
            // FrmFirmware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FrmFirmware";
            this.Text = "Marlin Firmware";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFirmware_FormClosed);
            this.Load += new System.EventHandler(this.FrmFirmware_Load);
            this.grpBxOldFirmware.ResumeLayout(false);
            this.grpBxOldFirmware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctbCurrentFirmware)).EndInit();
            this.grpBxNewFirmware.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctbNewFirmware)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxOldFirmware;
        private System.Windows.Forms.Label lblFeatureValue;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.TextBox txtBxCurrentFirmwareValue;
        private System.Windows.Forms.Button btnPassValue;
        private System.Windows.Forms.ComboBox cmbBxFirmwareFeatures;
        private FastColoredTextBoxNS.FastColoredTextBox fctbCurrentFirmware;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnUpdateExtruderInFirmware;
        private System.Windows.Forms.Button btnOpenArduinoIde;
        private System.Windows.Forms.GroupBox grpBxNewFirmware;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private FastColoredTextBoxNS.FastColoredTextBox fctbNewFirmware;
    }
}