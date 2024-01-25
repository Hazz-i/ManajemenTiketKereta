namespace TicketTrainManagemnet.View
{
    partial class lblTiket
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblTambbahTiket = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dte = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNamaPengguna = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbRute = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtKursi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.btnKembali = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbKereta = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblTambbahTiket
            // 
            this.lblTambbahTiket.BackColor = System.Drawing.Color.Transparent;
            this.lblTambbahTiket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblTambbahTiket.ForeColor = System.Drawing.Color.White;
            this.lblTambbahTiket.Location = new System.Drawing.Point(133, 25);
            this.lblTambbahTiket.Name = "lblTambbahTiket";
            this.lblTambbahTiket.Size = new System.Drawing.Size(107, 21);
            this.lblTambbahTiket.TabIndex = 28;
            this.lblTambbahTiket.Text = "Tambah Tiket";
            // 
            // dte
            // 
            this.dte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dte.BorderRadius = 10;
            this.dte.Checked = true;
            this.dte.FillColor = System.Drawing.Color.White;
            this.dte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dte.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dte.Location = new System.Drawing.Point(45, 96);
            this.dte.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dte.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dte.Name = "dte";
            this.dte.Size = new System.Drawing.Size(304, 36);
            this.dte.TabIndex = 53;
            this.dte.Value = new System.DateTime(2023, 12, 15, 18, 28, 11, 202);
            this.dte.ValueChanged += new System.EventHandler(this.dte_ValueChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(45, 70);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(76, 19);
            this.guna2HtmlLabel3.TabIndex = 52;
            this.guna2HtmlLabel3.Text = "Pilih tanggal";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 139);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(113, 19);
            this.guna2HtmlLabel2.TabIndex = 54;
            this.guna2HtmlLabel2.Text = "Nama Penumpang";
            // 
            // txtNamaPengguna
            // 
            this.txtNamaPengguna.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtNamaPengguna.BorderRadius = 10;
            this.txtNamaPengguna.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNamaPengguna.DefaultText = "";
            this.txtNamaPengguna.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNamaPengguna.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNamaPengguna.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPengguna.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNamaPengguna.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPengguna.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtNamaPengguna.ForeColor = System.Drawing.Color.Black;
            this.txtNamaPengguna.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNamaPengguna.Location = new System.Drawing.Point(45, 165);
            this.txtNamaPengguna.Name = "txtNamaPengguna";
            this.txtNamaPengguna.PasswordChar = '\0';
            this.txtNamaPengguna.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtNamaPengguna.PlaceholderText = "";
            this.txtNamaPengguna.SelectedText = "";
            this.txtNamaPengguna.Size = new System.Drawing.Size(304, 37);
            this.txtNamaPengguna.TabIndex = 55;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(45, 209);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(30, 19);
            this.guna2HtmlLabel7.TabIndex = 63;
            this.guna2HtmlLabel7.Text = "Rute";
            // 
            // cmbRute
            // 
            this.cmbRute.BackColor = System.Drawing.Color.Transparent;
            this.cmbRute.BorderRadius = 10;
            this.cmbRute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRute.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRute.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRute.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbRute.ItemHeight = 30;
            this.cmbRute.Location = new System.Drawing.Point(45, 235);
            this.cmbRute.Name = "cmbRute";
            this.cmbRute.Size = new System.Drawing.Size(304, 36);
            this.cmbRute.TabIndex = 62;
            this.cmbRute.SelectedIndexChanged += new System.EventHandler(this.cmbRute_SelectedIndexChanged);
            // 
            // txtKursi
            // 
            this.txtKursi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtKursi.BorderRadius = 10;
            this.txtKursi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKursi.DefaultText = "";
            this.txtKursi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKursi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKursi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKursi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKursi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKursi.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtKursi.ForeColor = System.Drawing.Color.Black;
            this.txtKursi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKursi.Location = new System.Drawing.Point(45, 378);
            this.txtKursi.Name = "txtKursi";
            this.txtKursi.PasswordChar = '\0';
            this.txtKursi.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtKursi.PlaceholderText = "";
            this.txtKursi.SelectedText = "";
            this.txtKursi.Size = new System.Drawing.Size(113, 37);
            this.txtKursi.TabIndex = 65;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(45, 350);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 19);
            this.guna2HtmlLabel4.TabIndex = 64;
            this.guna2HtmlLabel4.Text = "Nomor Kursi";
            // 
            // txtHarga
            // 
            this.txtHarga.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtHarga.BorderRadius = 10;
            this.txtHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHarga.DefaultText = "";
            this.txtHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtHarga.ForeColor = System.Drawing.Color.Black;
            this.txtHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHarga.Location = new System.Drawing.Point(164, 378);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.PasswordChar = '\0';
            this.txtHarga.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtHarga.PlaceholderText = "";
            this.txtHarga.SelectedText = "";
            this.txtHarga.Size = new System.Drawing.Size(185, 37);
            this.txtHarga.TabIndex = 69;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(164, 350);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(39, 19);
            this.guna2HtmlLabel8.TabIndex = 68;
            this.guna2HtmlLabel8.Text = "Harga";
            // 
            // btnSimpan
            // 
            this.btnSimpan.BorderRadius = 10;
            this.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSimpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnSimpan.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.Location = new System.Drawing.Point(198, 466);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 37);
            this.btnSimpan.TabIndex = 71;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnKembali
            // 
            this.btnKembali.BorderColor = System.Drawing.Color.White;
            this.btnKembali.BorderRadius = 10;
            this.btnKembali.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKembali.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKembali.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKembali.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnKembali.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(80, 466);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(110, 37);
            this.btnKembali.TabIndex = 70;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click_1);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(45, 278);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(84, 19);
            this.guna2HtmlLabel5.TabIndex = 73;
            this.guna2HtmlLabel5.Text = "Kereta - Kelas";
            // 
            // cmbKereta
            // 
            this.cmbKereta.BackColor = System.Drawing.Color.Transparent;
            this.cmbKereta.BorderRadius = 10;
            this.cmbKereta.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKereta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKereta.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKereta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbKereta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbKereta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbKereta.ItemHeight = 30;
            this.cmbKereta.Location = new System.Drawing.Point(45, 304);
            this.cmbKereta.Name = "cmbKereta";
            this.cmbKereta.Size = new System.Drawing.Size(304, 36);
            this.cmbKereta.TabIndex = 72;
            this.cmbKereta.SelectedIndexChanged += new System.EventHandler(this.cmbKereta_SelectedIndexChanged);
            // 
            // lblTiket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(399, 537);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cmbKereta);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtKursi);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.cmbRute);
            this.Controls.Add(this.txtNamaPengguna);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dte);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.lblTambbahTiket);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "lblTiket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TambahTiket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTambbahTiket;
        private Guna.UI2.WinForms.Guna2DateTimePicker dte;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKursi;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRute;
        private Guna.UI2.WinForms.Guna2TextBox txtNamaPengguna;
        private Guna.UI2.WinForms.Guna2TextBox txtHarga;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2Button btnKembali;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbKereta;
    }
}