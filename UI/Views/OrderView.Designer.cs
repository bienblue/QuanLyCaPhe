
namespace UI.Views
{
    partial class OrderView
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrder = new UI.Styles.RoundBorderButtonStyle();
            this.btnCloseOrder = new UI.Styles.EllipseButtonStyle();
            this.pnlOrder.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.pnlOrder.Controls.Add(this.pnlMenu);
            this.pnlOrder.Controls.Add(this.btnOrder);
            this.pnlOrder.Controls.Add(this.panel3);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(230, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOrder.Size = new System.Drawing.Size(520, 545);
            this.pnlOrder.TabIndex = 0;
            this.pnlOrder.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(199)))));
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(10, 44);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMenu.Size = new System.Drawing.Size(500, 451);
            this.pnlMenu.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(157)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 34);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTable);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 30);
            this.panel5.TabIndex = 0;
            // 
            // lblTable
            // 
            this.lblTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(0, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(470, 30);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Bàn";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(470, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 30);
            this.panel1.TabIndex = 0;
            // 
            // pnlTables
            // 
            this.pnlTables.AutoScroll = true;
            this.pnlTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(199)))));
            this.pnlTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTables.Location = new System.Drawing.Point(0, 0);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Padding = new System.Windows.Forms.Padding(20);
            this.pnlTables.Size = new System.Drawing.Size(230, 545);
            this.pnlTables.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrder.BorderColor = System.Drawing.Color.Black;
            this.btnOrder.BorderRadius = 20;
            this.btnOrder.BorderSize = 3;
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Image = global::UI.Properties.Resources.icons8_plus___100;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.Location = new System.Drawing.Point(10, 495);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(500, 40);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = " Order";
            this.btnOrder.TextColor = System.Drawing.Color.Black;
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCloseOrder
            // 
            this.btnCloseOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseOrder.BackgroundImage = global::UI.Properties.Resources.icons8_cancel_64;
            this.btnCloseOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseOrder.FlatAppearance.BorderSize = 0;
            this.btnCloseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseOrder.Location = new System.Drawing.Point(0, 0);
            this.btnCloseOrder.Name = "btnCloseOrder";
            this.btnCloseOrder.Size = new System.Drawing.Size(30, 30);
            this.btnCloseOrder.TabIndex = 0;
            this.btnCloseOrder.UseVisualStyleBackColor = false;
            this.btnCloseOrder.Click += new System.EventHandler(this.btnCloseOrder_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTables);
            this.Controls.Add(this.pnlOrder);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(750, 545);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.pnlOrder.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel pnlTables;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Panel panel1;
        private Styles.EllipseButtonStyle btnCloseOrder;
        private System.Windows.Forms.Panel pnlMenu;
        private Styles.RoundBorderButtonStyle btnOrder;
    }
}
