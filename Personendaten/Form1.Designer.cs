namespace Personendaten
{
    partial class Form1
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblBirthYear = new System.Windows.Forms.Label();
            this.numBirthyear = new System.Windows.Forms.NumericUpDown();
            this.gboGender = new System.Windows.Forms.GroupBox();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmdResult = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numBirthyear)).BeginInit();
            this.gboGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(485, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(522, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Anzeige Personaldaten";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(98, 283);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(233, 55);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Vorname:";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLastname.Location = new System.Drawing.Point(60, 373);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(271, 55);
            this.lblLastname.TabIndex = 2;
            this.lblLastname.Text = "Nachname:";
            this.lblLastname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFirstName.Location = new System.Drawing.Point(361, 283);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(307, 62);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtLastname.Location = new System.Drawing.Point(361, 373);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(307, 62);
            this.txtLastname.TabIndex = 4;
            // 
            // lblBirthYear
            // 
            this.lblBirthYear.AutoSize = true;
            this.lblBirthYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBirthYear.Location = new System.Drawing.Point(43, 464);
            this.lblBirthYear.Name = "lblBirthYear";
            this.lblBirthYear.Size = new System.Drawing.Size(288, 55);
            this.lblBirthYear.TabIndex = 5;
            this.lblBirthYear.Text = "Geburtsjahr:";
            // 
            // numBirthyear
            // 
            this.numBirthyear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.numBirthyear.Location = new System.Drawing.Point(361, 464);
            this.numBirthyear.Maximum = new decimal(new int[] {
            2019,
            0,
            0,
            0});
            this.numBirthyear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numBirthyear.Name = "numBirthyear";
            this.numBirthyear.Size = new System.Drawing.Size(185, 62);
            this.numBirthyear.TabIndex = 6;
            this.numBirthyear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // gboGender
            // 
            this.gboGender.Controls.Add(this.rdoFemale);
            this.gboGender.Controls.Add(this.rdoMale);
            this.gboGender.Location = new System.Drawing.Point(1008, 283);
            this.gboGender.Name = "gboGender";
            this.gboGender.Size = new System.Drawing.Size(306, 187);
            this.gboGender.TabIndex = 7;
            this.gboGender.TabStop = false;
            this.gboGender.Text = "Geschlecht";
            this.gboGender.Enter += new System.EventHandler(this.gboGender_Enter);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(43, 122);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(225, 59);
            this.rdoFemale.TabIndex = 1;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "weiblich";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(43, 62);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(247, 59);
            this.rdoMale.TabIndex = 0;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "männlich";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblResult.Location = new System.Drawing.Point(260, 723);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 55);
            this.lblResult.TabIndex = 8;
            // 
            // cmdResult
            // 
            this.cmdResult.Location = new System.Drawing.Point(1008, 564);
            this.cmdResult.Name = "cmdResult";
            this.cmdResult.Size = new System.Drawing.Size(268, 86);
            this.cmdResult.TabIndex = 9;
            this.cmdResult.Text = "Bestätigen";
            this.cmdResult.UseVisualStyleBackColor = true;
            this.cmdResult.Click += new System.EventHandler(this.cmdResult_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1008, 748);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(268, 86);
            this.cmdClose.TabIndex = 10;
            this.cmdClose.Text = "Beenden";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdReset
            // 
            this.cmdReset.Location = new System.Drawing.Point(1008, 656);
            this.cmdReset.Name = "cmdReset";
            this.cmdReset.Size = new System.Drawing.Size(268, 86);
            this.cmdReset.TabIndex = 11;
            this.cmdReset.Text = "Reset";
            this.cmdReset.UseVisualStyleBackColor = true;
            this.cmdReset.Click += new System.EventHandler(this.cmdReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1596, 974);
            this.Controls.Add(this.cmdReset);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gboGender);
            this.Controls.Add(this.numBirthyear);
            this.Controls.Add(this.lblBirthYear);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Personaldaten";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numBirthyear)).EndInit();
            this.gboGender.ResumeLayout(false);
            this.gboGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblBirthYear;
        private System.Windows.Forms.NumericUpDown numBirthyear;
        private System.Windows.Forms.GroupBox gboGender;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button cmdResult;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdReset;
    }
}

