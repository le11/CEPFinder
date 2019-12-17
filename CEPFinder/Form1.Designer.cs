namespace CEPFinder
{
    partial class ConsultaCEP
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.consultaButton = new MetroFramework.Controls.MetroButton();
            this.lblEnd = new MetroFramework.Controls.MetroLabel();
            this.lblComple = new MetroFramework.Controls.MetroLabel();
            this.lblCidade = new MetroFramework.Controls.MetroLabel();
            this.lblBairro = new MetroFramework.Controls.MetroLabel();
            this.lblUF = new MetroFramework.Controls.MetroLabel();
            this.txtEnd = new MetroFramework.Controls.MetroTextBox();
            this.txtComp = new MetroFramework.Controls.MetroTextBox();
            this.txtCidade = new MetroFramework.Controls.MetroTextBox();
            this.txtBairro = new MetroFramework.Controls.MetroTextBox();
            this.txtUF = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCep1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroLabel1.Location = new System.Drawing.Point(101, 93);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 23);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Informe o CEP:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseMnemonic = false;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // consultaButton
            // 
            this.consultaButton.BackColor = System.Drawing.Color.Transparent;
            this.consultaButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.consultaButton.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.consultaButton.ForeColor = System.Drawing.Color.Black;
            this.consultaButton.Highlight = true;
            this.consultaButton.Location = new System.Drawing.Point(335, 93);
            this.consultaButton.Name = "consultaButton";
            this.consultaButton.Size = new System.Drawing.Size(111, 23);
            this.consultaButton.TabIndex = 4;
            this.consultaButton.Text = "&Consultar";
            this.consultaButton.UseSelectable = true;
            this.consultaButton.Click += new System.EventHandler(this.consultaButton_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.SystemColors.Menu;
            this.lblEnd.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEnd.Location = new System.Drawing.Point(32, 187);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(71, 19);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "Endereço";
            this.lblEnd.UseCustomBackColor = true;
            // 
            // lblComple
            // 
            this.lblComple.AutoSize = true;
            this.lblComple.BackColor = System.Drawing.SystemColors.Menu;
            this.lblComple.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblComple.Location = new System.Drawing.Point(32, 238);
            this.lblComple.Name = "lblComple";
            this.lblComple.Size = new System.Drawing.Size(104, 19);
            this.lblComple.TabIndex = 6;
            this.lblComple.Text = "Complemento";
            this.lblComple.UseCustomBackColor = true;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.SystemColors.Menu;
            this.lblCidade.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCidade.Location = new System.Drawing.Point(32, 292);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(56, 19);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            this.lblCidade.UseCustomBackColor = true;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.SystemColors.Menu;
            this.lblBairro.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBairro.Location = new System.Drawing.Point(32, 346);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 19);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.UseCustomBackColor = true;
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.BackColor = System.Drawing.SystemColors.Menu;
            this.lblUF.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUF.Location = new System.Drawing.Point(32, 400);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(26, 19);
            this.lblUF.TabIndex = 9;
            this.lblUF.Text = "UF";
            this.lblUF.UseCustomBackColor = true;
            // 
            // txtEnd
            // 
            // 
            // 
            // 
            this.txtEnd.CustomButton.Image = null;
            this.txtEnd.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtEnd.CustomButton.Name = "";
            this.txtEnd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEnd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEnd.CustomButton.TabIndex = 1;
            this.txtEnd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEnd.CustomButton.UseSelectable = true;
            this.txtEnd.CustomButton.Visible = false;
            this.txtEnd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEnd.Lines = new string[0];
            this.txtEnd.Location = new System.Drawing.Point(187, 187);
            this.txtEnd.MaxLength = 32767;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.PasswordChar = '\0';
            this.txtEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEnd.SelectedText = "";
            this.txtEnd.SelectionLength = 0;
            this.txtEnd.SelectionStart = 0;
            this.txtEnd.ShortcutsEnabled = true;
            this.txtEnd.Size = new System.Drawing.Size(321, 23);
            this.txtEnd.TabIndex = 10;
            this.txtEnd.UseSelectable = true;
            this.txtEnd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEnd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtComp
            // 
            // 
            // 
            // 
            this.txtComp.CustomButton.Image = null;
            this.txtComp.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtComp.CustomButton.Name = "";
            this.txtComp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtComp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtComp.CustomButton.TabIndex = 1;
            this.txtComp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtComp.CustomButton.UseSelectable = true;
            this.txtComp.CustomButton.Visible = false;
            this.txtComp.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtComp.Lines = new string[0];
            this.txtComp.Location = new System.Drawing.Point(187, 240);
            this.txtComp.MaxLength = 32767;
            this.txtComp.Name = "txtComp";
            this.txtComp.PasswordChar = '\0';
            this.txtComp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComp.SelectedText = "";
            this.txtComp.SelectionLength = 0;
            this.txtComp.SelectionStart = 0;
            this.txtComp.ShortcutsEnabled = true;
            this.txtComp.Size = new System.Drawing.Size(321, 23);
            this.txtComp.TabIndex = 11;
            this.txtComp.UseSelectable = true;
            this.txtComp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtComp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCidade
            // 
            // 
            // 
            // 
            this.txtCidade.CustomButton.Image = null;
            this.txtCidade.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtCidade.CustomButton.Name = "";
            this.txtCidade.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCidade.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCidade.CustomButton.TabIndex = 1;
            this.txtCidade.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCidade.CustomButton.UseSelectable = true;
            this.txtCidade.CustomButton.Visible = false;
            this.txtCidade.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCidade.Lines = new string[0];
            this.txtCidade.Location = new System.Drawing.Point(187, 294);
            this.txtCidade.MaxLength = 32767;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PasswordChar = '\0';
            this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCidade.SelectedText = "";
            this.txtCidade.SelectionLength = 0;
            this.txtCidade.SelectionStart = 0;
            this.txtCidade.ShortcutsEnabled = true;
            this.txtCidade.Size = new System.Drawing.Size(321, 23);
            this.txtCidade.TabIndex = 12;
            this.txtCidade.UseSelectable = true;
            this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBairro
            // 
            // 
            // 
            // 
            this.txtBairro.CustomButton.Image = null;
            this.txtBairro.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtBairro.CustomButton.Name = "";
            this.txtBairro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBairro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBairro.CustomButton.TabIndex = 1;
            this.txtBairro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBairro.CustomButton.UseSelectable = true;
            this.txtBairro.CustomButton.Visible = false;
            this.txtBairro.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBairro.Lines = new string[0];
            this.txtBairro.Location = new System.Drawing.Point(187, 348);
            this.txtBairro.MaxLength = 32767;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PasswordChar = '\0';
            this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBairro.SelectedText = "";
            this.txtBairro.SelectionLength = 0;
            this.txtBairro.SelectionStart = 0;
            this.txtBairro.ShortcutsEnabled = true;
            this.txtBairro.Size = new System.Drawing.Size(321, 23);
            this.txtBairro.TabIndex = 13;
            this.txtBairro.UseSelectable = true;
            this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUF
            // 
            // 
            // 
            // 
            this.txtUF.CustomButton.Image = null;
            this.txtUF.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.txtUF.CustomButton.Name = "";
            this.txtUF.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUF.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUF.CustomButton.TabIndex = 1;
            this.txtUF.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUF.CustomButton.UseSelectable = true;
            this.txtUF.CustomButton.Visible = false;
            this.txtUF.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUF.Lines = new string[0];
            this.txtUF.Location = new System.Drawing.Point(187, 402);
            this.txtUF.MaxLength = 32767;
            this.txtUF.Name = "txtUF";
            this.txtUF.PasswordChar = '\0';
            this.txtUF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUF.SelectedText = "";
            this.txtUF.SelectionLength = 0;
            this.txtUF.SelectionStart = 0;
            this.txtUF.ShortcutsEnabled = true;
            this.txtUF.Size = new System.Drawing.Size(321, 23);
            this.txtUF.TabIndex = 14;
            this.txtUF.UseSelectable = true;
            this.txtUF.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUF.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(11, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 279);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // txtCep1
            // 
            this.txtCep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep1.Location = new System.Drawing.Point(215, 93);
            this.txtCep1.Mask = "00000-000";
            this.txtCep1.Name = "txtCep1";
            this.txtCep1.Size = new System.Drawing.Size(114, 23);
            this.txtCep1.TabIndex = 17;
            this.txtCep1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 34);
            this.label2.TabIndex = 18;
            this.label2.Text = "CONSULTA CEP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConsultaCEP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCep1);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblComple);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.consultaButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(559, 516);
            this.MinimumSize = new System.Drawing.Size(559, 516);
            this.Name = "ConsultaCEP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta CEP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton consultaButton;
        private MetroFramework.Controls.MetroLabel lblEnd;
        private MetroFramework.Controls.MetroLabel lblComple;
        private MetroFramework.Controls.MetroLabel lblCidade;
        private MetroFramework.Controls.MetroLabel lblBairro;
        private MetroFramework.Controls.MetroLabel lblUF;
        private MetroFramework.Controls.MetroTextBox txtEnd;
        private MetroFramework.Controls.MetroTextBox txtComp;
        private MetroFramework.Controls.MetroTextBox txtCidade;
        private MetroFramework.Controls.MetroTextBox txtBairro;
        private MetroFramework.Controls.MetroTextBox txtUF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtCep1;
        private System.Windows.Forms.Label label2;
    }
}

