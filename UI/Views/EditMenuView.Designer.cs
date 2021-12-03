
namespace UI.Views
{
    partial class EditMenuView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDrink = new UI.Styles.RoundBorderButtonStyle();
            this.btnSave = new UI.Styles.RoundBorderButtonStyle();
            this.btnCloseEdit = new UI.Styles.EllipseButtonStyle();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(232)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.pnlDrinks);
            this.panel1.Controls.Add(this.btnAddDrink);
            this.panel1.Controls.Add(this.pnlEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(750, 545);
            this.panel1.TabIndex = 1;
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrinks.Location = new System.Drawing.Point(20, 20);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Size = new System.Drawing.Size(376, 444);
            this.pnlDrinks.TabIndex = 6;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(186)))), ((int)(((byte)(157)))));
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.btnCloseEdit);
            this.pnlEdit.Controls.Add(this.cbbType);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Controls.Add(this.txbPrice);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txbCount);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.txbName);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.txbId);
            this.pnlEdit.Controls.Add(this.label1);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEdit.Location = new System.Drawing.Point(396, 20);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(334, 505);
            this.pnlEdit.TabIndex = 0;
            this.pnlEdit.Visible = false;
            // 
            // cbbType
            // 
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(138, 259);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(164, 38);
            this.cbbType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.label5.Location = new System.Drawing.Point(18, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbPrice
            // 
            this.txbPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrice.Location = new System.Drawing.Point(138, 211);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(164, 35);
            this.txbPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(18, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbCount
            // 
            this.txbCount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCount.Location = new System.Drawing.Point(138, 163);
            this.txbCount.Name = "txbCount";
            this.txbCount.Size = new System.Drawing.Size(164, 35);
            this.txbCount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(18, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(138, 114);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(164, 35);
            this.txbName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(18, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbId
            // 
            this.txbId.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId.Location = new System.Drawing.Point(138, 66);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(164, 35);
            this.txbId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(18, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDrink.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddDrink.BackgroundImage = global::UI.Properties.Resources.icons8_plus___100;
            this.btnAddDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDrink.BorderColor = System.Drawing.Color.Black;
            this.btnAddDrink.BorderRadius = 20;
            this.btnAddDrink.BorderSize = 3;
            this.btnAddDrink.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrink.ForeColor = System.Drawing.Color.Black;
            this.btnAddDrink.Location = new System.Drawing.Point(20, 464);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(376, 61);
            this.btnAddDrink.TabIndex = 5;
            this.btnAddDrink.TextColor = System.Drawing.Color.Black;
            this.btnAddDrink.UseVisualStyleBackColor = false;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 3;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(212, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextColor = System.Drawing.Color.Black;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseEdit.BackgroundImage = global::UI.Properties.Resources.icons8_cancel_64;
            this.btnCloseEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseEdit.FlatAppearance.BorderSize = 0;
            this.btnCloseEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseEdit.Location = new System.Drawing.Point(301, 3);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(30, 30);
            this.btnCloseEdit.TabIndex = 12;
            this.btnCloseEdit.UseVisualStyleBackColor = false;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // EditMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EditMenuView";
            this.Size = new System.Drawing.Size(750, 545);
            this.Load += new System.EventHandler(this.EditMenuView_Load);
            this.panel1.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlDrinks;
        private Styles.RoundBorderButtonStyle btnAddDrink;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbId;
        private Styles.EllipseButtonStyle btnCloseEdit;
        private Styles.RoundBorderButtonStyle btnSave;
    }
}
