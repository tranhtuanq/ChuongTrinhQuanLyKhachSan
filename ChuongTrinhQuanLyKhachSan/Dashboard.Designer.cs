﻿namespace ChuongTrinhQuanLyKhachSan
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAddRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerRes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCustomerDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRoom,
            this.btnCustomerRes,
            this.btnCheckOut,
            this.btnCustomerDetail,
            this.btnEmployee});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 66);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(214, 62);
            this.btnAddRoom.Text = "Thêm Phòng";
            // 
            // btnCustomerRes
            // 
            this.btnCustomerRes.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRes.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRes.Image")));
            this.btnCustomerRes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomerRes.Name = "btnCustomerRes";
            this.btnCustomerRes.Size = new System.Drawing.Size(283, 62);
            this.btnCustomerRes.Text = "Đăng Ký Khách Hàng";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(202, 62);
            this.btnCheckOut.Text = "Thanh Toán";
            // 
            // btnCustomerDetail
            // 
            this.btnCustomerDetail.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetail.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetail.Image")));
            this.btnCustomerDetail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCustomerDetail.Name = "btnCustomerDetail";
            this.btnCustomerDetail.Size = new System.Drawing.Size(276, 62);
            this.btnCustomerDetail.Text = "Chi Tiết Khách Hàng";
            // 
            // btnEmployee
            // 
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(188, 62);
            this.btnEmployee.Text = "Nhân Viên";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1299, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAddRoom;
        private System.Windows.Forms.ToolStripMenuItem btnCustomerRes;
        private System.Windows.Forms.ToolStripMenuItem btnCheckOut;
        private System.Windows.Forms.ToolStripMenuItem btnCustomerDetail;
        private System.Windows.Forms.ToolStripMenuItem btnEmployee;
    }
}