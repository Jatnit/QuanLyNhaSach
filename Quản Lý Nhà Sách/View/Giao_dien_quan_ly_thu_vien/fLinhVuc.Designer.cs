
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmLinhVuc
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
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            dgvLinhVuc = new System.Windows.Forms.ListView();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            cboXoaLinhVuc = new System.Windows.Forms.ComboBox();
            lblThemLinhVuc = new System.Windows.Forms.Label();
            lblTenLinhVuc = new System.Windows.Forms.Label();
            txbMaLinhVuc = new System.Windows.Forms.TextBox();
            txbTenLinhVuc = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(498, 9);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(121, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "THÊM";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += bThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(499, 9);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(121, 29);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "XÓA";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += bXoa_Click;
            // 
            // dgvLinhVuc
            // 
            dgvLinhVuc.HideSelection = false;
            dgvLinhVuc.Location = new System.Drawing.Point(11, 12);
            dgvLinhVuc.Name = "dgvLinhVuc";
            dgvLinhVuc.Size = new System.Drawing.Size(640, 221);
            dgvLinhVuc.TabIndex = 15;
            dgvLinhVuc.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTenLinhVuc);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbMaLinhVuc);
            panel1.Controls.Add(lblTenLinhVuc);
            panel1.Controls.Add(btnThem);
            panel1.Location = new System.Drawing.Point(11, 239);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(639, 91);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboXoaLinhVuc);
            panel2.Controls.Add(lblThemLinhVuc);
            panel2.Controls.Add(btnXoa);
            panel2.Location = new System.Drawing.Point(10, 336);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(639, 47);
            panel2.TabIndex = 17;
            // 
            // cboXoaLinhVuc
            // 
            cboXoaLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboXoaLinhVuc.FormattingEnabled = true;
            cboXoaLinhVuc.Location = new System.Drawing.Point(169, 10);
            cboXoaLinhVuc.Name = "cboXoaLinhVuc";
            cboXoaLinhVuc.Size = new System.Drawing.Size(308, 28);
            cboXoaLinhVuc.TabIndex = 15;
            // 
            // lblThemLinhVuc
            // 
            lblThemLinhVuc.AutoSize = true;
            lblThemLinhVuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblThemLinhVuc.Location = new System.Drawing.Point(4, 9);
            lblThemLinhVuc.Name = "lblThemLinhVuc";
            lblThemLinhVuc.Size = new System.Drawing.Size(147, 28);
            lblThemLinhVuc.TabIndex = 0;
            lblThemLinhVuc.Text = "XÓA LĨNH VỰC:";
            // 
            // lblTenLinhVuc
            // 
            lblTenLinhVuc.AutoSize = true;
            lblTenLinhVuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTenLinhVuc.Location = new System.Drawing.Point(3, 10);
            lblTenLinhVuc.Name = "lblTenLinhVuc";
            lblTenLinhVuc.Size = new System.Drawing.Size(138, 28);
            lblTenLinhVuc.TabIndex = 0;
            lblTenLinhVuc.Text = "MÃ LĨNH VỰC:";
            // 
            // txbMaLinhVuc
            // 
            txbMaLinhVuc.Location = new System.Drawing.Point(167, 11);
            txbMaLinhVuc.Name = "txbMaLinhVuc";
            txbMaLinhVuc.Size = new System.Drawing.Size(309, 27);
            txbMaLinhVuc.TabIndex = 1;
            // 
            // txbTenLinhVuc
            // 
            txbTenLinhVuc.Location = new System.Drawing.Point(168, 51);
            txbTenLinhVuc.Name = "txbTenLinhVuc";
            txbTenLinhVuc.Size = new System.Drawing.Size(309, 27);
            txbTenLinhVuc.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(142, 28);
            label1.TabIndex = 14;
            label1.Text = "TÊN LĨNH VỰC:";
            // 
            // frmLinhVuc
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(663, 391);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvLinhVuc);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmLinhVuc";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LĨNH VỰC";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView dgvLinhVuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaLinhVuc;
        private System.Windows.Forms.Label lblThemLinhVuc;
        private System.Windows.Forms.TextBox txbTenLinhVuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaLinhVuc;
        private System.Windows.Forms.Label lblTenLinhVuc;
    }
}