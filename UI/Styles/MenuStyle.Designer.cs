
namespace UI.Styles
{
    partial class MenuStyle
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
            this.btnType = new UI.Styles.RoundBorderButtonStyle();
            this.pnlDrinks = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.btnType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(76)))), ((int)(((byte)(91)))));
            this.btnType.BorderColor = System.Drawing.Color.Black;
            this.btnType.BorderRadius = 10;
            this.btnType.BorderSize = 2;
            this.btnType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.ForeColor = System.Drawing.Color.White;
            this.btnType.Location = new System.Drawing.Point(0, 0);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(500, 35);
            this.btnType.TabIndex = 0;
            this.btnType.TextColor = System.Drawing.Color.White;
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // pnlDrinks
            // 
            this.pnlDrinks.AutoSize = true;
            this.pnlDrinks.BackColor = System.Drawing.Color.Transparent;
            this.pnlDrinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrinks.Location = new System.Drawing.Point(0, 35);
            this.pnlDrinks.Name = "pnlDrinks";
            this.pnlDrinks.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDrinks.Size = new System.Drawing.Size(500, 10);
            this.pnlDrinks.TabIndex = 2;
            this.pnlDrinks.Visible = false;
            // 
            // MenuStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlDrinks);
            this.Controls.Add(this.btnType);
            this.Name = "MenuStyle";
            this.Size = new System.Drawing.Size(500, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public RoundBorderButtonStyle btnType;
        public System.Windows.Forms.Panel pnlDrinks;
    }
}
