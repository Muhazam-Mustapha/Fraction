namespace Fraction
{
    partial class MainForm
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
            this.MainTab = new System.Windows.Forms.TabControl();
            this.SysTab = new System.Windows.Forms.TabPage();
            this._10DigRadioButton = new System.Windows.Forms.RadioButton();
            this._5DigRadioButton = new System.Windows.Forms.RadioButton();
            this._3DigRadioButton = new System.Windows.Forms.RadioButton();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.DisplayValueCheckBox = new System.Windows.Forms.CheckBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.BarPanel = new System.Windows.Forms.Panel();
            this.DenomLabel = new System.Windows.Forms.Label();
            this.NumerLabel = new System.Windows.Forms.Label();
            this.DenomCopyButton = new System.Windows.Forms.Button();
            this.CopyNumerButton = new System.Windows.Forms.Button();
            this.DenomTextBox = new System.Windows.Forms.TextBox();
            this.NumerTextBox = new System.Windows.Forms.TextBox();
            this.DenominatorLabel = new System.Windows.Forms.Label();
            this.NumeratorLabel = new System.Windows.Forms.Label();
            this.WebPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.MainTab.SuspendLayout();
            this.SysTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.SysTab);
            this.MainTab.Controls.Add(this.WebPage);
            this.MainTab.Location = new System.Drawing.Point(2, 2);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(796, 440);
            this.MainTab.TabIndex = 0;
            // 
            // SysTab
            // 
            this.SysTab.Controls.Add(this.button1);
            this.SysTab.Controls.Add(this._10DigRadioButton);
            this.SysTab.Controls.Add(this._5DigRadioButton);
            this.SysTab.Controls.Add(this._3DigRadioButton);
            this.SysTab.Controls.Add(this.ValueLabel);
            this.SysTab.Controls.Add(this.DisplayValueCheckBox);
            this.SysTab.Controls.Add(this.MsgLabel);
            this.SysTab.Controls.Add(this.BarPanel);
            this.SysTab.Controls.Add(this.DenomLabel);
            this.SysTab.Controls.Add(this.NumerLabel);
            this.SysTab.Controls.Add(this.DenomCopyButton);
            this.SysTab.Controls.Add(this.CopyNumerButton);
            this.SysTab.Controls.Add(this.DenomTextBox);
            this.SysTab.Controls.Add(this.NumerTextBox);
            this.SysTab.Controls.Add(this.DenominatorLabel);
            this.SysTab.Controls.Add(this.NumeratorLabel);
            this.SysTab.Location = new System.Drawing.Point(4, 22);
            this.SysTab.Name = "SysTab";
            this.SysTab.Padding = new System.Windows.Forms.Padding(3);
            this.SysTab.Size = new System.Drawing.Size(788, 414);
            this.SysTab.TabIndex = 0;
            this.SysTab.Text = "System View";
            this.SysTab.UseVisualStyleBackColor = true;
            // 
            // _10DigRadioButton
            // 
            this._10DigRadioButton.AutoSize = true;
            this._10DigRadioButton.Location = new System.Drawing.Point(270, 296);
            this._10DigRadioButton.Name = "_10DigRadioButton";
            this._10DigRadioButton.Size = new System.Drawing.Size(105, 17);
            this._10DigRadioButton.TabIndex = 14;
            this._10DigRadioButton.TabStop = true;
            this._10DigRadioButton.Text = "10 Decimal Point";
            this._10DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // _5DigRadioButton
            // 
            this._5DigRadioButton.AutoSize = true;
            this._5DigRadioButton.Location = new System.Drawing.Point(153, 296);
            this._5DigRadioButton.Name = "_5DigRadioButton";
            this._5DigRadioButton.Size = new System.Drawing.Size(99, 17);
            this._5DigRadioButton.TabIndex = 13;
            this._5DigRadioButton.TabStop = true;
            this._5DigRadioButton.Text = "5 Decimal Point";
            this._5DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // _3DigRadioButton
            // 
            this._3DigRadioButton.AutoSize = true;
            this._3DigRadioButton.Checked = true;
            this._3DigRadioButton.Location = new System.Drawing.Point(35, 296);
            this._3DigRadioButton.Name = "_3DigRadioButton";
            this._3DigRadioButton.Size = new System.Drawing.Size(99, 17);
            this._3DigRadioButton.TabIndex = 12;
            this._3DigRadioButton.TabStop = true;
            this._3DigRadioButton.Text = "3 Decimal Point";
            this._3DigRadioButton.UseVisualStyleBackColor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(150, 244);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(13, 13);
            this.ValueLabel.TabIndex = 11;
            this.ValueLabel.Text = "--";
            // 
            // DisplayValueCheckBox
            // 
            this.DisplayValueCheckBox.AutoSize = true;
            this.DisplayValueCheckBox.Location = new System.Drawing.Point(35, 244);
            this.DisplayValueCheckBox.Name = "DisplayValueCheckBox";
            this.DisplayValueCheckBox.Size = new System.Drawing.Size(90, 17);
            this.DisplayValueCheckBox.TabIndex = 10;
            this.DisplayValueCheckBox.Text = "Display Value";
            this.DisplayValueCheckBox.UseVisualStyleBackColor = true;
            this.DisplayValueCheckBox.CheckedChanged += new System.EventHandler(this.DisplayValuaCheckBox_CheckedChanged);
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(46, 195);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(56, 13);
            this.MsgLabel.TabIndex = 9;
            this.MsgLabel.Text = "Message: ";
            // 
            // BarPanel
            // 
            this.BarPanel.BackColor = System.Drawing.Color.Black;
            this.BarPanel.Location = new System.Drawing.Point(406, 92);
            this.BarPanel.Name = "BarPanel";
            this.BarPanel.Size = new System.Drawing.Size(100, 5);
            this.BarPanel.TabIndex = 8;
            // 
            // DenomLabel
            // 
            this.DenomLabel.AutoSize = true;
            this.DenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenomLabel.Location = new System.Drawing.Point(430, 106);
            this.DenomLabel.Name = "DenomLabel";
            this.DenomLabel.Size = new System.Drawing.Size(57, 63);
            this.DenomLabel.TabIndex = 7;
            this.DenomLabel.Text = "1";
            // 
            // NumerLabel
            // 
            this.NumerLabel.AutoSize = true;
            this.NumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumerLabel.Location = new System.Drawing.Point(430, 23);
            this.NumerLabel.Name = "NumerLabel";
            this.NumerLabel.Size = new System.Drawing.Size(57, 63);
            this.NumerLabel.TabIndex = 6;
            this.NumerLabel.Text = "0";
            // 
            // DenomCopyButton
            // 
            this.DenomCopyButton.Location = new System.Drawing.Point(270, 127);
            this.DenomCopyButton.Name = "DenomCopyButton";
            this.DenomCopyButton.Size = new System.Drawing.Size(75, 23);
            this.DenomCopyButton.TabIndex = 5;
            this.DenomCopyButton.Text = ">>>";
            this.DenomCopyButton.UseVisualStyleBackColor = true;
            this.DenomCopyButton.Click += new System.EventHandler(this.DenomCopyButton_Click);
            // 
            // CopyNumerButton
            // 
            this.CopyNumerButton.Location = new System.Drawing.Point(270, 39);
            this.CopyNumerButton.Name = "CopyNumerButton";
            this.CopyNumerButton.Size = new System.Drawing.Size(75, 23);
            this.CopyNumerButton.TabIndex = 4;
            this.CopyNumerButton.Text = ">>>";
            this.CopyNumerButton.UseVisualStyleBackColor = true;
            this.CopyNumerButton.Click += new System.EventHandler(this.CopyNumerButton_Click);
            // 
            // DenomTextBox
            // 
            this.DenomTextBox.Location = new System.Drawing.Point(108, 127);
            this.DenomTextBox.Name = "DenomTextBox";
            this.DenomTextBox.Size = new System.Drawing.Size(129, 20);
            this.DenomTextBox.TabIndex = 3;
            // 
            // NumerTextBox
            // 
            this.NumerTextBox.Location = new System.Drawing.Point(108, 43);
            this.NumerTextBox.Name = "NumerTextBox";
            this.NumerTextBox.Size = new System.Drawing.Size(129, 20);
            this.NumerTextBox.TabIndex = 2;
            // 
            // DenominatorLabel
            // 
            this.DenominatorLabel.AutoSize = true;
            this.DenominatorLabel.Location = new System.Drawing.Point(32, 129);
            this.DenominatorLabel.Name = "DenominatorLabel";
            this.DenominatorLabel.Size = new System.Drawing.Size(70, 13);
            this.DenominatorLabel.TabIndex = 1;
            this.DenominatorLabel.Text = "Denominator:";
            // 
            // NumeratorLabel
            // 
            this.NumeratorLabel.AutoSize = true;
            this.NumeratorLabel.Location = new System.Drawing.Point(43, 45);
            this.NumeratorLabel.Name = "NumeratorLabel";
            this.NumeratorLabel.Size = new System.Drawing.Size(59, 13);
            this.NumeratorLabel.TabIndex = 0;
            this.NumeratorLabel.Text = "Numerator:";
            // 
            // WebPage
            // 
            this.WebPage.Location = new System.Drawing.Point(4, 22);
            this.WebPage.Name = "WebPage";
            this.WebPage.Padding = new System.Windows.Forms.Padding(3);
            this.WebPage.Size = new System.Drawing.Size(788, 414);
            this.WebPage.TabIndex = 1;
            this.WebPage.Text = "Web View";
            this.WebPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Fraction";
            this.MainTab.ResumeLayout(false);
            this.SysTab.ResumeLayout(false);
            this.SysTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage SysTab;
        private System.Windows.Forms.TabPage WebPage;
        private System.Windows.Forms.TextBox DenomTextBox;
        private System.Windows.Forms.TextBox NumerTextBox;
        private System.Windows.Forms.Label DenominatorLabel;
        private System.Windows.Forms.Label NumeratorLabel;
        private System.Windows.Forms.Button DenomCopyButton;
        private System.Windows.Forms.Button CopyNumerButton;
        private System.Windows.Forms.Panel BarPanel;
        private System.Windows.Forms.Label DenomLabel;
        private System.Windows.Forms.Label NumerLabel;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.CheckBox DisplayValueCheckBox;
        private System.Windows.Forms.RadioButton _10DigRadioButton;
        private System.Windows.Forms.RadioButton _5DigRadioButton;
        private System.Windows.Forms.RadioButton _3DigRadioButton;
        private System.Windows.Forms.Button button1;
    }
}

