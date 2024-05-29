namespace Youtube_Versão_2
{
    partial class frYoutubeV2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frYoutubeV2));
            txtUrl = new TextBox();
            BtnMostrar = new Button();
            rdMp3 = new RadioButton();
            rdMp4 = new RadioButton();
            CmbQualidade = new ComboBox();
            txtCaminho = new TextBox();
            BtnGuardar = new Button();
            BtnPrevisualizar = new Button();
            BtnDownload = new Button();
            BtnLimpar = new Button();
            BtnSair = new Button();
            Avanco = new ProgressBar();
            BtnSobre = new Button();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUrl.Location = new Point(8, 16);
            txtUrl.Multiline = true;
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(720, 39);
            txtUrl.TabIndex = 0;
            // 
            // BtnMostrar
            // 
            BtnMostrar.BackColor = Color.FromArgb(255, 128, 0);
            BtnMostrar.FlatStyle = FlatStyle.Popup;
            BtnMostrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMostrar.Location = new Point(733, 15);
            BtnMostrar.Name = "BtnMostrar";
            BtnMostrar.Size = new Size(151, 40);
            BtnMostrar.TabIndex = 1;
            BtnMostrar.Text = "Mostrar";
            BtnMostrar.UseVisualStyleBackColor = false;
            BtnMostrar.Click += BtnMostrar_Click;
            // 
            // rdMp3
            // 
            rdMp3.AutoSize = true;
            rdMp3.Location = new Point(12, 69);
            rdMp3.Name = "rdMp3";
            rdMp3.Size = new Size(120, 24);
            rdMp3.TabIndex = 2;
            rdMp3.TabStop = true;
            rdMp3.Text = "Formato Mp3";
            rdMp3.UseVisualStyleBackColor = true;
            rdMp3.CheckedChanged += rdMp3_CheckedChanged;
            // 
            // rdMp4
            // 
            rdMp4.AutoSize = true;
            rdMp4.Location = new Point(161, 71);
            rdMp4.Name = "rdMp4";
            rdMp4.Size = new Size(120, 24);
            rdMp4.TabIndex = 3;
            rdMp4.TabStop = true;
            rdMp4.Text = "Formato Mp4";
            rdMp4.UseVisualStyleBackColor = true;
            rdMp4.CheckedChanged += rdMp4_CheckedChanged;
            // 
            // CmbQualidade
            // 
            CmbQualidade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            CmbQualidade.FormattingEnabled = true;
            CmbQualidade.Location = new Point(294, 63);
            CmbQualidade.Name = "CmbQualidade";
            CmbQualidade.Size = new Size(278, 39);
            CmbQualidade.TabIndex = 4;
            // 
            // txtCaminho
            // 
            txtCaminho.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtCaminho.Location = new Point(6, 108);
            txtCaminho.Multiline = true;
            txtCaminho.Name = "txtCaminho";
            txtCaminho.ReadOnly = true;
            txtCaminho.Size = new Size(722, 44);
            txtCaminho.TabIndex = 5;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(255, 128, 0);
            BtnGuardar.FlatStyle = FlatStyle.Popup;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGuardar.Location = new Point(733, 106);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(151, 46);
            BtnGuardar.TabIndex = 6;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnPrevisualizar
            // 
            BtnPrevisualizar.BackColor = Color.FromArgb(255, 128, 0);
            BtnPrevisualizar.FlatStyle = FlatStyle.Popup;
            BtnPrevisualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPrevisualizar.Location = new Point(6, 169);
            BtnPrevisualizar.Name = "BtnPrevisualizar";
            BtnPrevisualizar.Size = new Size(138, 45);
            BtnPrevisualizar.TabIndex = 7;
            BtnPrevisualizar.Text = "Previsualizar";
            BtnPrevisualizar.UseVisualStyleBackColor = false;
            BtnPrevisualizar.Click += BtnPrevisualizar_Click;
            // 
            // BtnDownload
            // 
            BtnDownload.BackColor = Color.FromArgb(255, 128, 0);
            BtnDownload.FlatStyle = FlatStyle.Popup;
            BtnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDownload.Location = new Point(150, 169);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Size = new Size(138, 45);
            BtnDownload.TabIndex = 8;
            BtnDownload.Text = "Download";
            BtnDownload.UseVisualStyleBackColor = false;
            BtnDownload.Click += BtnDownload_ClickAsync;
            // 
            // BtnLimpar
            // 
            BtnLimpar.BackColor = Color.FromArgb(255, 128, 0);
            BtnLimpar.FlatStyle = FlatStyle.Popup;
            BtnLimpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLimpar.Location = new Point(294, 169);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(138, 45);
            BtnLimpar.TabIndex = 9;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = false;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.FromArgb(255, 128, 0);
            BtnSair.FlatStyle = FlatStyle.Popup;
            BtnSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSair.Location = new Point(590, 169);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(138, 45);
            BtnSair.TabIndex = 10;
            BtnSair.Text = "Sair";
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // Avanco
            // 
            Avanco.Location = new Point(8, 223);
            Avanco.Name = "Avanco";
            Avanco.Size = new Size(876, 44);
            Avanco.TabIndex = 11;
            // 
            // BtnSobre
            // 
            BtnSobre.BackColor = Color.FromArgb(255, 128, 0);
            BtnSobre.FlatStyle = FlatStyle.Popup;
            BtnSobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSobre.Location = new Point(438, 169);
            BtnSobre.Name = "BtnSobre";
            BtnSobre.Size = new Size(146, 45);
            BtnSobre.TabIndex = 12;
            BtnSobre.Text = "Sobre";
            BtnSobre.UseVisualStyleBackColor = false;
            BtnSobre.Click += BtnSobre_Click;
            // 
            // frYoutubeV2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 278);
            Controls.Add(BtnSobre);
            Controls.Add(Avanco);
            Controls.Add(BtnSair);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnDownload);
            Controls.Add(BtnPrevisualizar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtCaminho);
            Controls.Add(CmbQualidade);
            Controls.Add(rdMp4);
            Controls.Add(rdMp3);
            Controls.Add(BtnMostrar);
            Controls.Add(txtUrl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frYoutubeV2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YoutubeV2 DevJoel 2024 © Portugal  Net6.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrl;
        private Button BtnMostrar;
        private RadioButton rdMp3;
        private RadioButton rdMp4;
        private ComboBox CmbQualidade;
        private TextBox txtCaminho;
        private Button BtnGuardar;
        private Button BtnPrevisualizar;
        private Button BtnDownload;
        private Button BtnLimpar;
        private Button BtnSair;
        private ProgressBar Avanco;
        private Button BtnSobre;
    }
}
