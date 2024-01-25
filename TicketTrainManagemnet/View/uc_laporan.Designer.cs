namespace TicketTrainManagemnet.View
{
    partial class uc_laporan
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtCari = new Guna.UI2.WinForms.Guna2TextBox();
            this.lvwTIcket = new System.Windows.Forms.ListView();
            this.dte = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCari = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtCari
            // 
            this.txtCari.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.txtCari.BorderRadius = 10;
            this.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCari.DefaultText = "";
            this.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtCari.ForeColor = System.Drawing.Color.Black;
            this.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCari.Location = new System.Drawing.Point(566, 104);
            this.txtCari.Margin = new System.Windows.Forms.Padding(4);
            this.txtCari.Name = "txtCari";
            this.txtCari.PasswordChar = '\0';
            this.txtCari.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCari.PlaceholderText = "Masukan Nama";
            this.txtCari.SelectedText = "";
            this.txtCari.Size = new System.Drawing.Size(216, 38);
            this.txtCari.TabIndex = 30;
            // 
            // lvwTIcket
            // 
            this.lvwTIcket.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvwTIcket.HideSelection = false;
            this.lvwTIcket.Location = new System.Drawing.Point(21, 166);
            this.lvwTIcket.Margin = new System.Windows.Forms.Padding(4);
            this.lvwTIcket.Name = "lvwTIcket";
            this.lvwTIcket.Size = new System.Drawing.Size(805, 359);
            this.lvwTIcket.TabIndex = 29;
            this.lvwTIcket.UseCompatibleStateImageBehavior = false;
            // 
            // dte
            // 
            this.dte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.dte.BorderRadius = 10;
            this.dte.Checked = true;
            this.dte.FillColor = System.Drawing.Color.White;
            this.dte.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dte.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dte.Location = new System.Drawing.Point(341, 104);
            this.dte.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dte.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dte.Name = "dte";
            this.dte.Size = new System.Drawing.Size(218, 36);
            this.dte.TabIndex = 55;
            this.dte.Value = new System.DateTime(2023, 12, 15, 18, 28, 11, 202);
            this.dte.ValueChanged += new System.EventHandler(this.dte_ValueChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(341, 79);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(67, 19);
            this.guna2HtmlLabel3.TabIndex = 54;
            this.guna2HtmlLabel3.Text = "Pilih Bulan : ";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(76, 63);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(162, 49);
            this.guna2HtmlLabel1.TabIndex = 56;
            this.guna2HtmlLabel1.Text = "Laporan";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(615, 543);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(99, 19);
            this.guna2HtmlLabel2.TabIndex = 58;
            this.guna2HtmlLabel2.Text = "Total Penjualan : ";
            // 
            // txtJumlah
            // 
            this.txtJumlah.BorderColor = System.Drawing.Color.White;
            this.txtJumlah.BorderRadius = 10;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = "";
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtJumlah.ForeColor = System.Drawing.Color.Black;
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.Location = new System.Drawing.Point(718, 532);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtJumlah.PlaceholderText = "";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.Size = new System.Drawing.Size(96, 38);
            this.txtJumlah.TabIndex = 59;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_report_50__1_;
            this.pictureBox2.Location = new System.Drawing.Point(21, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(68, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // btnCari
            // 
            this.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Image = global::TicketTrainManagemnet.Properties.Resources.icons8_search_64;
            this.btnCari.Location = new System.Drawing.Point(787, 103);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCari.Size = new System.Drawing.Size(38, 37);
            this.btnCari.TabIndex = 31;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(143, 104);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(82, 25);
            this.guna2HtmlLabel5.TabIndex = 62;
            this.guna2HtmlLabel5.Text = "Bulanan";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 135);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(213, 19);
            this.guna2HtmlLabel4.TabIndex = 63;
            this.guna2HtmlLabel4.Text = "Berisi total penjualan tiket perbulan";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(21, 525);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(308, 19);
            this.guna2HtmlLabel6.TabIndex = 64;
            this.guna2HtmlLabel6.Text = "*Pastikan yang di ganti adalah bulan bukan tanggal";
            // 
            // uc_laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dte);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.lvwTIcket);
            this.Controls.Add(this.pictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uc_laporan";
            this.Size = new System.Drawing.Size(849, 608);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCari;
        private Guna.UI2.WinForms.Guna2TextBox txtCari;
        private System.Windows.Forms.ListView lvwTIcket;
        private Guna.UI2.WinForms.Guna2DateTimePicker dte;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}
