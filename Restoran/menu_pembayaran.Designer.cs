namespace Restoran
{
    partial class menu_pembayaran
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.no_meja_txt = new System.Windows.Forms.TextBox();
            this.subtotal_txt = new System.Windows.Forms.TextBox();
            this.total_bayar_txt = new System.Windows.Forms.TextBox();
            this.kembali_txt = new System.Windows.Forms.TextBox();
            this.btn_bayar = new System.Windows.Forms.Button();
            this.btn_biling = new System.Windows.Forms.Button();
            this.btn_pembayaan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 31);
            this.panel3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(257, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sense";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(617, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(601, 209);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "No Meja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kembali";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Bayar";
            // 
            // no_meja_txt
            // 
            this.no_meja_txt.Location = new System.Drawing.Point(356, 52);
            this.no_meja_txt.Name = "no_meja_txt";
            this.no_meja_txt.Size = new System.Drawing.Size(71, 32);
            this.no_meja_txt.TabIndex = 13;
            // 
            // subtotal_txt
            // 
            this.subtotal_txt.Location = new System.Drawing.Point(356, 97);
            this.subtotal_txt.Name = "subtotal_txt";
            this.subtotal_txt.Size = new System.Drawing.Size(167, 32);
            this.subtotal_txt.TabIndex = 14;
            // 
            // total_bayar_txt
            // 
            this.total_bayar_txt.Location = new System.Drawing.Point(357, 139);
            this.total_bayar_txt.Name = "total_bayar_txt";
            this.total_bayar_txt.Size = new System.Drawing.Size(167, 32);
            this.total_bayar_txt.TabIndex = 15;
            this.total_bayar_txt.TextChanged += new System.EventHandler(this.total_bayar_txt_TextChanged);
            // 
            // kembali_txt
            // 
            this.kembali_txt.Location = new System.Drawing.Point(357, 184);
            this.kembali_txt.Name = "kembali_txt";
            this.kembali_txt.Size = new System.Drawing.Size(167, 32);
            this.kembali_txt.TabIndex = 16;
            // 
            // btn_bayar
            // 
            this.btn_bayar.Font = new System.Drawing.Font("Courier New", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bayar.Location = new System.Drawing.Point(273, 237);
            this.btn_bayar.Name = "btn_bayar";
            this.btn_bayar.Size = new System.Drawing.Size(144, 35);
            this.btn_bayar.TabIndex = 17;
            this.btn_bayar.Text = "Proses Pembayaran";
            this.btn_bayar.UseVisualStyleBackColor = true;
            this.btn_bayar.Click += new System.EventHandler(this.btn_bayar_Click);
            // 
            // btn_biling
            // 
            this.btn_biling.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_biling.Location = new System.Drawing.Point(447, 237);
            this.btn_biling.Name = "btn_biling";
            this.btn_biling.Size = new System.Drawing.Size(132, 35);
            this.btn_biling.TabIndex = 18;
            this.btn_biling.Text = "Cetak Billing/Struk";
            this.btn_biling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_biling.UseVisualStyleBackColor = true;
            this.btn_biling.Click += new System.EventHandler(this.btn_biling_Click);
            // 
            // btn_pembayaan
            // 
            this.btn_pembayaan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pembayaan.FlatAppearance.BorderSize = 0;
            this.btn_pembayaan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pembayaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pembayaan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pembayaan.ForeColor = System.Drawing.Color.White;
            this.btn_pembayaan.Image = global::Restoran.Properties.Resources.pay;
            this.btn_pembayaan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pembayaan.Location = new System.Drawing.Point(0, 176);
            this.btn_pembayaan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_pembayaan.Name = "btn_pembayaan";
            this.btn_pembayaan.Size = new System.Drawing.Size(228, 64);
            this.btn_pembayaan.TabIndex = 4;
            this.btn_pembayaan.Text = "Pembayaran";
            this.btn_pembayaan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sense";
            // 
            // btn_kembali
            // 
            this.btn_kembali.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.Color.White;
            this.btn_kembali.Image = global::Restoran.Properties.Resources.undo;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(9, 6);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(76, 41);
            this.btn_kembali.TabIndex = 5;
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.btn_kembali);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_pembayaan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 300);
            this.panel2.TabIndex = 6;
            // 
            // menu_pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 300);
            this.Controls.Add(this.btn_biling);
            this.Controls.Add(this.btn_bayar);
            this.Controls.Add(this.kembali_txt);
            this.Controls.Add(this.total_bayar_txt);
            this.Controls.Add(this.subtotal_txt);
            this.Controls.Add(this.no_meja_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "menu_pembayaran";
            this.Text = "Menu Pembayaran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menu_pembayaran_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox no_meja_txt;
        private System.Windows.Forms.TextBox subtotal_txt;
        private System.Windows.Forms.TextBox total_bayar_txt;
        private System.Windows.Forms.TextBox kembali_txt;
        private System.Windows.Forms.Button btn_bayar;
        private System.Windows.Forms.Button btn_biling;
        private System.Windows.Forms.Button btn_pembayaan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Panel panel2;
    }
}