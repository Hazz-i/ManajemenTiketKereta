namespace TicketTrainManagemnet.View
{
    partial class HalamanUtama
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLaporan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnRute = new Guna.UI2.WinForms.Guna2Button();
            this.btnKereta = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pannelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btnLaporan);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btnExit);
            this.guna2Panel1.Controls.Add(this.btnRute);
            this.guna2Panel1.Controls.Add(this.btnKereta);
            this.guna2Panel1.Controls.Add(this.btnLogin);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(178, 608);
            this.guna2Panel1.TabIndex = 10;
            // 
            // btnLaporan
            // 
            this.btnLaporan.BorderColor = System.Drawing.Color.Empty;
            this.btnLaporan.BorderRadius = 10;
            this.btnLaporan.Checked = true;
            this.btnLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLaporan.FillColor = System.Drawing.Color.Transparent;
            this.btnLaporan.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_report_50;
            this.btnLaporan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLaporan.ImageOffset = new System.Drawing.Point(5, -1);
            this.btnLaporan.Location = new System.Drawing.Point(22, 372);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(135, 39);
            this.btnLaporan.TabIndex = 21;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLaporan.TextOffset = new System.Drawing.Point(12, 0);
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(53, 52);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(88, 20);
            this.guna2HtmlLabel2.TabIndex = 20;
            this.guna2HtmlLabel2.Text = "Tiket Kereta";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(53, 38);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(74, 18);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Manajemen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_train_502;
            this.pictureBox1.Location = new System.Drawing.Point(7, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.BorderRadius = 10;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnExit.Location = new System.Drawing.Point(22, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 39);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Keluar";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRute
            // 
            this.btnRute.BorderRadius = 10;
            this.btnRute.Checked = true;
            this.btnRute.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRute.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRute.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRute.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRute.FillColor = System.Drawing.Color.Transparent;
            this.btnRute.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRute.ForeColor = System.Drawing.Color.White;
            this.btnRute.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_map_50__1_;
            this.btnRute.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRute.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnRute.Location = new System.Drawing.Point(22, 308);
            this.btnRute.Name = "btnRute";
            this.btnRute.Size = new System.Drawing.Size(135, 39);
            this.btnRute.TabIndex = 14;
            this.btnRute.Text = "Rute";
            this.btnRute.CheckedChanged += new System.EventHandler(this.btnLogin_CheckedChanged);
            this.btnRute.Click += new System.EventHandler(this.btnRute_Click);
            // 
            // btnKereta
            // 
            this.btnKereta.BorderRadius = 10;
            this.btnKereta.Checked = true;
            this.btnKereta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKereta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKereta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKereta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKereta.FillColor = System.Drawing.Color.Transparent;
            this.btnKereta.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnKereta.ForeColor = System.Drawing.Color.White;
            this.btnKereta.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_train_64;
            this.btnKereta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKereta.ImageOffset = new System.Drawing.Point(5, 0);
            this.btnKereta.Location = new System.Drawing.Point(22, 244);
            this.btnKereta.Name = "btnKereta";
            this.btnKereta.Size = new System.Drawing.Size(135, 39);
            this.btnKereta.TabIndex = 13;
            this.btnKereta.Text = "Kereta";
            this.btnKereta.CheckedChanged += new System.EventHandler(this.btnLogin_CheckedChanged);
            this.btnKereta.Click += new System.EventHandler(this.btnKereta_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.Empty;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.Checked = true;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_ticket_64;
            this.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.ImageOffset = new System.Drawing.Point(5, -1);
            this.btnLogin.Location = new System.Drawing.Point(22, 180);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 39);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Tiket";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogin.TextOffset = new System.Drawing.Point(12, 0);
            this.btnLogin.CheckedChanged += new System.EventHandler(this.btnLogin_CheckedChanged);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pannelContainer
            // 
            this.pannelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelContainer.Location = new System.Drawing.Point(178, 0);
            this.pannelContainer.Name = "pannelContainer";
            this.pannelContainer.Size = new System.Drawing.Size(849, 608);
            this.pannelContainer.TabIndex = 11;
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1027, 608);
            this.Controls.Add(this.pannelContainer);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HalamanUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HalamanUtama";
            this.Load += new System.EventHandler(this.HalamanUtama_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnKereta;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pannelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnRute;
        private Guna.UI2.WinForms.Guna2Button btnLaporan;
    }
}