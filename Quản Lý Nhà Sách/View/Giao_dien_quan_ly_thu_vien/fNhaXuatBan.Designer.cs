
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmNhaXuatBan
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
            dgvNhaXuatBan = new System.Windows.Forms.ListView();
            panel1 = new System.Windows.Forms.Panel();
            txbMaNXB = new System.Windows.Forms.TextBox();
            lblThemNXB = new System.Windows.Forms.Label();
            btnThemNXB = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            cboXoaNXB = new System.Windows.Forms.ComboBox();
            lblXoaNXB = new System.Windows.Forms.Label();
            btnXoaNXB = new System.Windows.Forms.Button();
            txbTenNXB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhaXuatBan
            // 
            dgvNhaXuatBan.HideSelection = false;
            dgvNhaXuatBan.Location = new System.Drawing.Point(11, 12);
            dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            dgvNhaXuatBan.Size = new System.Drawing.Size(640, 219);
            dgvNhaXuatBan.TabIndex = 17;
            dgvNhaXuatBan.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txbTenNXB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbMaNXB);
            panel1.Controls.Add(lblThemNXB);
            panel1.Controls.Add(btnThemNXB);
            panel1.Location = new System.Drawing.Point(11, 237);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(639, 95);
            panel1.TabIndex = 18;
            // 
            // txbMaNXB
            // 
            txbMaNXB.Location = new System.Drawing.Point(153, 11);
            txbMaNXB.Name = "txbMaNXB";
            txbMaNXB.Size = new System.Drawing.Size(323, 27);
            txbMaNXB.TabIndex = 1;
            // 
            // lblThemNXB
            // 
            lblThemNXB.AutoSize = true;
            lblThemNXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblThemNXB.Location = new System.Drawing.Point(3, 11);
            lblThemNXB.Name = "lblThemNXB";
            lblThemNXB.Size = new System.Drawing.Size(90, 28);
            lblThemNXB.TabIndex = 0;
            lblThemNXB.Text = "MÃ NXB:";
            // 
            // btnThemNXB
            // 
            btnThemNXB.Location = new System.Drawing.Point(498, 9);
            btnThemNXB.Name = "btnThemNXB";
            btnThemNXB.Size = new System.Drawing.Size(121, 29);
            btnThemNXB.TabIndex = 13;
            btnThemNXB.Text = "THÊM";
            btnThemNXB.UseVisualStyleBackColor = true;
            btnThemNXB.Click += bThemNXB_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cboXoaNXB);
            panel2.Controls.Add(lblXoaNXB);
            panel2.Controls.Add(btnXoaNXB);
            panel2.Location = new System.Drawing.Point(11, 338);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(639, 43);
            panel2.TabIndex = 19;
            // 
            // cboXoaNXB
            // 
            cboXoaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboXoaNXB.FormattingEnabled = true;
            cboXoaNXB.Location = new System.Drawing.Point(153, 10);
            cboXoaNXB.Name = "cboXoaNXB";
            cboXoaNXB.Size = new System.Drawing.Size(323, 28);
            cboXoaNXB.TabIndex = 15;
            // 
            // lblXoaNXB
            // 
            lblXoaNXB.AutoSize = true;
            lblXoaNXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblXoaNXB.Location = new System.Drawing.Point(3, 10);
            lblXoaNXB.Name = "lblXoaNXB";
            lblXoaNXB.Size = new System.Drawing.Size(99, 28);
            lblXoaNXB.TabIndex = 0;
            lblXoaNXB.Text = "XÓA NXB:";
            // 
            // btnXoaNXB
            // 
            btnXoaNXB.Location = new System.Drawing.Point(499, 9);
            btnXoaNXB.Name = "btnXoaNXB";
            btnXoaNXB.Size = new System.Drawing.Size(121, 29);
            btnXoaNXB.TabIndex = 14;
            btnXoaNXB.Text = "XÓA";
            btnXoaNXB.UseVisualStyleBackColor = true;
            btnXoaNXB.Click += bXoaNXB_Click;
            // 
            // txbTenNXB
            // 
            txbTenNXB.Location = new System.Drawing.Point(153, 55);
            txbTenNXB.Name = "txbTenNXB";
            txbTenNXB.Size = new System.Drawing.Size(323, 27);
            txbTenNXB.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(3, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 28);
            label1.TabIndex = 14;
            label1.Text = "TÊN NXB:";
            // 
            // frmNhaXuatBan
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(663, 390);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvNhaXuatBan);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Name = "frmNhaXuatBan";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NHÀ XUẤT BẢN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView dgvNhaXuatBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbMaNXB;
        private System.Windows.Forms.Label lblThemNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaNXB;
        private System.Windows.Forms.Label lblXoaNXB;
        private System.Windows.Forms.Button btnXoaNXB;
        private System.Windows.Forms.TextBox txbTenNXB;
        private System.Windows.Forms.Label label1;
    }
}