namespace fraction
{
    partial class Fraction
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainTab = new System.Windows.Forms.TabPage();
            this._10digitradioButton = new System.Windows.Forms.RadioButton();
            this._5digitradioButton = new System.Windows.Forms.RadioButton();
            this._3digitradioButton1 = new System.Windows.Forms.RadioButton();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.DisplayvaluecheckBox = new System.Windows.Forms.CheckBox();
            this.MsgLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DenomLabel = new System.Windows.Forms.Label();
            this.NumerLabel = new System.Windows.Forms.Label();
            this.CopyDenom = new System.Windows.Forms.Button();
            this.CopyNumer = new System.Windows.Forms.Button();
            this.DenortextBox = new System.Windows.Forms.TextBox();
            this.NumertextBox = new System.Windows.Forms.TextBox();
            this.denominatorlabel = new System.Windows.Forms.Label();
            this.numeratorlabel = new System.Windows.Forms.Label();
            this.WebPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.MainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainTab);
            this.tabControl1.Controls.Add(this.WebPage);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this._10digitradioButton);
            this.MainTab.Controls.Add(this._5digitradioButton);
            this.MainTab.Controls.Add(this._3digitradioButton1);
            this.MainTab.Controls.Add(this.ValueLabel);
            this.MainTab.Controls.Add(this.DisplayvaluecheckBox);
            this.MainTab.Controls.Add(this.MsgLabel);
            this.MainTab.Controls.Add(this.panel1);
            this.MainTab.Controls.Add(this.DenomLabel);
            this.MainTab.Controls.Add(this.NumerLabel);
            this.MainTab.Controls.Add(this.CopyDenom);
            this.MainTab.Controls.Add(this.CopyNumer);
            this.MainTab.Controls.Add(this.DenortextBox);
            this.MainTab.Controls.Add(this.NumertextBox);
            this.MainTab.Controls.Add(this.denominatorlabel);
            this.MainTab.Controls.Add(this.numeratorlabel);
            this.MainTab.Location = new System.Drawing.Point(4, 22);
            this.MainTab.Name = "MainTab";
            this.MainTab.Padding = new System.Windows.Forms.Padding(3);
            this.MainTab.Size = new System.Drawing.Size(792, 422);
            this.MainTab.TabIndex = 0;
            this.MainTab.Text = "System View";
            this.MainTab.UseVisualStyleBackColor = true;
            // 
            // _10digitradioButton
            // 
            this._10digitradioButton.AutoSize = true;
            this._10digitradioButton.Location = new System.Drawing.Point(494, 288);
            this._10digitradioButton.Name = "_10digitradioButton";
            this._10digitradioButton.Size = new System.Drawing.Size(105, 17);
            this._10digitradioButton.TabIndex = 14;
            this._10digitradioButton.TabStop = true;
            this._10digitradioButton.Text = "10 Decimal Point";
            this._10digitradioButton.UseVisualStyleBackColor = true;
            // 
            // _5digitradioButton
            // 
            this._5digitradioButton.AutoSize = true;
            this._5digitradioButton.Location = new System.Drawing.Point(389, 288);
            this._5digitradioButton.Name = "_5digitradioButton";
            this._5digitradioButton.Size = new System.Drawing.Size(99, 17);
            this._5digitradioButton.TabIndex = 13;
            this._5digitradioButton.TabStop = true;
            this._5digitradioButton.Text = "5 Decimal Point";
            this._5digitradioButton.UseVisualStyleBackColor = true;
            // 
            // _3digitradioButton1
            // 
            this._3digitradioButton1.AutoSize = true;
            this._3digitradioButton1.Location = new System.Drawing.Point(284, 288);
            this._3digitradioButton1.Name = "_3digitradioButton1";
            this._3digitradioButton1.Size = new System.Drawing.Size(99, 17);
            this._3digitradioButton1.TabIndex = 12;
            this._3digitradioButton1.TabStop = true;
            this._3digitradioButton1.Text = "3 Decimal Point";
            this._3digitradioButton1.UseVisualStyleBackColor = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(381, 244);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(0, 13);
            this.ValueLabel.TabIndex = 11;
            // 
            // DisplayvaluecheckBox
            // 
            this.DisplayvaluecheckBox.AutoSize = true;
            this.DisplayvaluecheckBox.Location = new System.Drawing.Point(284, 244);
            this.DisplayvaluecheckBox.Name = "DisplayvaluecheckBox";
            this.DisplayvaluecheckBox.Size = new System.Drawing.Size(90, 17);
            this.DisplayvaluecheckBox.TabIndex = 10;
            this.DisplayvaluecheckBox.Text = "Display Value";
            this.DisplayvaluecheckBox.UseVisualStyleBackColor = true;
            this.DisplayvaluecheckBox.CheckedChanged += new System.EventHandler(this.DisplayvaluecheckBox_CheckedChanged);
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(284, 216);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(53, 13);
            this.MsgLabel.TabIndex = 9;
            this.MsgLabel.Text = "Massage:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(531, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 5);
            this.panel1.TabIndex = 8;
            // 
            // DenomLabel
            // 
            this.DenomLabel.AutoSize = true;
            this.DenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenomLabel.Location = new System.Drawing.Point(559, 134);
            this.DenomLabel.Name = "DenomLabel";
            this.DenomLabel.Size = new System.Drawing.Size(42, 46);
            this.DenomLabel.TabIndex = 7;
            this.DenomLabel.Text = "1";
            // 
            // NumerLabel
            // 
            this.NumerLabel.AutoSize = true;
            this.NumerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumerLabel.Location = new System.Drawing.Point(559, 74);
            this.NumerLabel.Name = "NumerLabel";
            this.NumerLabel.Size = new System.Drawing.Size(42, 46);
            this.NumerLabel.TabIndex = 6;
            this.NumerLabel.Text = "0";
            // 
            // CopyDenom
            // 
            this.CopyDenom.Location = new System.Drawing.Point(461, 144);
            this.CopyDenom.Name = "CopyDenom";
            this.CopyDenom.Size = new System.Drawing.Size(75, 23);
            this.CopyDenom.TabIndex = 5;
            this.CopyDenom.Text = ">>>";
            this.CopyDenom.UseVisualStyleBackColor = true;
            this.CopyDenom.Click += new System.EventHandler(this.CopyDenom_Click);
            // 
            // CopyNumer
            // 
            this.CopyNumer.Location = new System.Drawing.Point(461, 86);
            this.CopyNumer.Name = "CopyNumer";
            this.CopyNumer.Size = new System.Drawing.Size(75, 23);
            this.CopyNumer.TabIndex = 4;
            this.CopyNumer.Text = ">>>";
            this.CopyNumer.UseVisualStyleBackColor = true;
            this.CopyNumer.Click += new System.EventHandler(this.CopyNumer_Click);
            // 
            // DenortextBox
            // 
            this.DenortextBox.Location = new System.Drawing.Point(354, 144);
            this.DenortextBox.Name = "DenortextBox";
            this.DenortextBox.Size = new System.Drawing.Size(100, 20);
            this.DenortextBox.TabIndex = 3;
            // 
            // NumertextBox
            // 
            this.NumertextBox.Location = new System.Drawing.Point(354, 86);
            this.NumertextBox.Name = "NumertextBox";
            this.NumertextBox.Size = new System.Drawing.Size(100, 20);
            this.NumertextBox.TabIndex = 2;
            // 
            // denominatorlabel
            // 
            this.denominatorlabel.AutoSize = true;
            this.denominatorlabel.Location = new System.Drawing.Point(281, 147);
            this.denominatorlabel.Name = "denominatorlabel";
            this.denominatorlabel.Size = new System.Drawing.Size(67, 13);
            this.denominatorlabel.TabIndex = 1;
            this.denominatorlabel.Text = "Denominator";
            // 
            // numeratorlabel
            // 
            this.numeratorlabel.AutoSize = true;
            this.numeratorlabel.Location = new System.Drawing.Point(291, 86);
            this.numeratorlabel.Name = "numeratorlabel";
            this.numeratorlabel.Size = new System.Drawing.Size(56, 13);
            this.numeratorlabel.TabIndex = 0;
            this.numeratorlabel.Text = "Numerator";
            // 
            // WebPage
            // 
            this.WebPage.Location = new System.Drawing.Point(4, 22);
            this.WebPage.Name = "WebPage";
            this.WebPage.Padding = new System.Windows.Forms.Padding(3);
            this.WebPage.Size = new System.Drawing.Size(792, 422);
            this.WebPage.TabIndex = 1;
            this.WebPage.Text = "Web View";
            this.WebPage.UseVisualStyleBackColor = true;
            // 
            // Fraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Fraction";
            this.Text = "Fraction";
            this.tabControl1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            this.MainTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainTab;
        private System.Windows.Forms.TabPage WebPage;
        private System.Windows.Forms.TextBox DenortextBox;
        private System.Windows.Forms.TextBox NumertextBox;
        private System.Windows.Forms.Label denominatorlabel;
        private System.Windows.Forms.Label numeratorlabel;
        private System.Windows.Forms.Label NumerLabel;
        private System.Windows.Forms.Button CopyDenom;
        private System.Windows.Forms.Button CopyNumer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DenomLabel;
        private System.Windows.Forms.Label MsgLabel;
        private System.Windows.Forms.CheckBox DisplayvaluecheckBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.RadioButton _10digitradioButton;
        private System.Windows.Forms.RadioButton _5digitradioButton;
        private System.Windows.Forms.RadioButton _3digitradioButton1;
    }
}

