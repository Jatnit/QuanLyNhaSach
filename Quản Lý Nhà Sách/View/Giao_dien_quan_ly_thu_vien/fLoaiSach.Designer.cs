
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmLoaiSach
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
            dgvLoaiSach = new System.Windows.Forms.ListView();
            panel1 = new System.Windows.Forms.Panel();
            txbMaLoaiSach = new System.Windows.Forms.TextBox();
            lblThemLoaiSach = new System.Windows.Forms.Label();
            btnThemLoaiSach = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            cboXoaLoaiSach = new System.Windows.Forms.ComboBox();
            lblXoaLoaiSach = new System.Windows.Forms.Label();
            btnXoaLoaiSach = new System.Windows.Forms.Button();
            txbTenLoaiSach = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLoaiSach
            // 
            dgvLoaiSach.HideSelection = false;
            dgvLoaiSach.Location = new System.Drawing.Point(11, 12);
            dgvLoaiSach.Name = "dgvLoaiSach";
            dgvLoaiSach.Size = new System.Drawing.Size(640, 218);
            dgvLoaiSach.TabIndex = 16;
            dgvLoaiSach.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTenLoaiSach);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbMaLoaiSach);
            panel1.Controls.Add(lblThemLoaiSach);
            panel1.Controls.Add(btnThemLoaiSach);
            panel1.Location = new System.Drawing.Point(11, 236);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(639, 93);
            panel1.TabIndex = 17;
            // 
            // txbMaLoaiSach
            // 
            txbMaLoaiSach.Location = new System.Drawing.Point(181, 11);
            txbMaLoaiSach.Name = "txbMaLoaiSach";
            txbMaLoaiSach.Size = new System.Drawing.Size(295, 27);
            txbMaLoaiSach.TabIndex = 1;
            // 
            // lblThemLoaiSach
            // 
            lblThemLoaiSach.AutoSize = true;
            lblThemLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblThemLoaiSach.Location = new System.Drawing.Point(3, 11);
            lblThemLoaiSach.Name = "lblThemLoaiSach";
            lblThemLoaiSach.Size = new System.Drawing.Size(148, 28);
            lblThemLoaiSach.TabIndex = 0;
            lblThemLoaiSach.Text = "MÃ LOẠI SÁCH:";
            // 
            // btnThemLoaiSach
            // 
            btnThemLoaiSach.Location = new System.Drawing.Point(498, 9);
            btnThemLoaiSach.Name = "btnThemLoaiSach";
            btnThemLoaiSach.Size = new System.Drawing.Size(121, 29);
            btnThemLoaiSach.TabIndex = 13;
            btnThemLoaiSach.Text = "THÊM";
            btnThemLoaiSach.UseVisualStyleBackColor = true;
            btnThemLoaiSach.Click += bThemSach_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboXoaLoaiSach);
            panel2.Controls.Add(lblXoaLoaiSach);
            panel2.Controls.Add(btnXoaLoaiSach);
            panel2.Location = new System.Drawing.Point(11, 335);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(639, 45);
            panel2.TabIndex = 18;
            // 
            // cboXoaLoaiSach
            // 
            cboXoaLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboXoaLoaiSach.FormattingEnabled = true;
            cboXoaLoaiSach.Location = new System.Drawing.Point(181, 10);
            cboXoaLoaiSach.Name = "cboXoaLoaiSach";
            cboXoaLoaiSach.Size = new System.Drawing.Size(296, 28);
            cboXoaLoaiSach.TabIndex = 15;
            // 
            // lblXoaLoaiSach
            // 
            lblXoaLoaiSach.AutoSize = true;
            lblXoaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblXoaLoaiSach.Location = new System.Drawing.Point(3, 9);
            lblXoaLoaiSach.Name = "lblXoaLoaiSach";
            lblXoaLoaiSach.Size = new System.Drawing.Size(157, 28);
            lblXoaLoaiSach.TabIndex = 0;
            lblXoaLoaiSach.Text = "XÓA LOẠI SÁCH:";
            // 
            // btnXoaLoaiSach
            // 
            btnXoaLoaiSach.Location = new System.Drawing.Point(499, 9);
            btnXoaLoaiSach.Name = "btnXoaLoaiSach";
            btnXoaLoaiSach.Size = new System.Drawing.Size(121, 29);
            btnXoaLoaiSach.TabIndex = 14;
            btnXoaLoaiSach.Text = "XÓA";
            btnXoaLoaiSach.UseVisualStyleBackColor = true;
            btnXoaLoaiSach.Click += bXoaSach_Click;
            // 
            // txbTenLoaiSach
            // 
            txbTenLoaiSach.Location = new System.Drawing.Point(181, 54);
            txbTenLoaiSach.Name = "txbTenLoaiSach";
            txbTenLoaiSach.Size = new System.Drawing.Size(295, 27);
            txbTenLoaiSach.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(152, 28);
            label1.TabIndex = 14;
            label1.Text = "TÊN LOẠI SÁCH:";
            // 
            // frmLoaiSach
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(663, 392);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvLoaiSach);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmLoaiSach";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LOẠI SÁCH";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView dgvLoaiSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMaLoaiSach;
        private System.Windows.Forms.Label lblThemLoaiSach;
        private System.Windows.Forms.Button btnThemLoaiSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaLoaiSach;
        private System.Windows.Forms.Label lblXoaLoaiSach;
        private System.Windows.Forms.Button btnXoaLoaiSach;
        private System.Windows.Forms.TextBox txbTenLoaiSach;
        private System.Windows.Forms.Label label1;
    }
}