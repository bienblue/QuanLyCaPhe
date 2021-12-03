
namespace UI.Views
{
    partial class PayView
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
            this.pnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblSum = new System.Windows.Forms.Label();
            this.btnPay = new UI.Styles.RoundBorderButtonStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClosePay = new UI.Styles.EllipseButtonStyle();
            this.pnlPay.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTables
            // 
            this.pnlTables.AutoScroll = true;
            this.pnlTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(199)))));
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTables.Size = new System.Drawing.Size(430, 570);
            this.pnlTables.TabIndex = 3;
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pnlPay.Controls.Add(this.panel3);
            this.pnlPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPay.Location = new System.Drawing.Point(430, 0);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPay.Size = new System.Drawing.Size(520, 570);
            this.pnlPay.TabIndex = 2;
            this.pnlPay.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(157)))));
            this.panel3.Controls.Add(this.pnlBill);
            this.panel3.Controls.Add(this.lblSum);
            this.panel3.Controls.Add(this.btnPay);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(500, 550);
            this.panel3.TabIndex = 0;
            // 
            // pnlBill
            // 
            this.pnlBill.AutoScroll = true;
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBill.Location = new System.Drawing.Point(10, 40);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Padding = new System.Windows.Forms.Padding(15);
            this.pnlBill.Size = new System.Drawing.Size(480, 420);
            this.pnlBill.TabIndex = 4;
            // 
            // lblSum
            // 
            this.lblSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSum.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSum.Location = new System.Drawing.Point(10, 460);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(480, 40);
            this.lblSum.TabIndex = 1;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(157)))));
            this.btnPay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(157)))));
            this.btnPay.BackgroundImage = global::UI.Properties.Resources.icons8_pay_100;
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.BorderColor = System.Drawing.Color.Black;
            this.btnPay.BorderRadius = 20;
            this.btnPay.BorderSize = 3;
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPay.FlatAppearance.BorderSize = 2;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPay.Location = new System.Drawing.Point(10, 500);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(480, 40);
            this.btnPay.TabIndex = 0;
            this.btnPay.TextColor = System.Drawing.Color.Black;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTable);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 30);
            this.panel5.TabIndex = 0;
            // 
            // lblTable
            // 
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(0, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(450, 30);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Bàn";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClosePay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 0;
            // 
            // btnClosePay
            // 
            this.btnClosePay.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePay.BackgroundImage = global::UI.Properties.Resources.icons8_cancel_64;
            this.btnClosePay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClosePay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClosePay.FlatAppearance.BorderSize = 0;
            this.btnClosePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePay.Location = new System.Drawing.Point(0, 0);
            this.btnClosePay.Name = "btnClosePay";
            this.btnClosePay.Size = new System.Drawing.Size(30, 30);
            this.btnClosePay.TabIndex = 0;
            this.btnClosePay.UseVisualStyleBackColor = false;
            this.btnClosePay.Click += new System.EventHandler(this.btnClosePay_Click);
            // 
            // PayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.pnlPay);
            this.Name = "PayView";
            this.Size = new System.Drawing.Size(950, 570);
            this.Load += new System.EventHandler(this.PayView_Load);
            this.pnlPay.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTables;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Panel panel1;
        private Styles.EllipseButtonStyle btnClosePay;
        private Styles.RoundBorderButtonStyle btnPay;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label lblSum;
    }
}
