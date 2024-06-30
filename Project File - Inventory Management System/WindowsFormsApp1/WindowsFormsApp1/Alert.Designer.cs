
namespace WindowsFormsApp1
{
    partial class Alert
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
            this.dgv7 = new System.Windows.Forms.DataGridView();
            this.Alert1 = new System.Windows.Forms.Label();
            this.dgv8 = new System.Windows.Forms.DataGridView();
            this.Alert2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv7
            // 
            this.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv7.Location = new System.Drawing.Point(470, 63);
            this.dgv7.Name = "dgv7";
            this.dgv7.Size = new System.Drawing.Size(246, 296);
            this.dgv7.TabIndex = 13;
            this.dgv7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv7_CellContentClick);
            // 
            // Alert1
            // 
            this.Alert1.AutoSize = true;
            this.Alert1.BackColor = System.Drawing.Color.Transparent;
            this.Alert1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert1.ForeColor = System.Drawing.Color.SpringGreen;
            this.Alert1.Location = new System.Drawing.Point(205, 86);
            this.Alert1.Name = "Alert1";
            this.Alert1.Size = new System.Drawing.Size(25, 24);
            this.Alert1.TabIndex = 14;
            this.Alert1.Text = "...";
            this.Alert1.Click += new System.EventHandler(this.Alert1_Click);
            // 
            // dgv8
            // 
            this.dgv8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv8.Location = new System.Drawing.Point(200, 167);
            this.dgv8.Name = "dgv8";
            this.dgv8.Size = new System.Drawing.Size(246, 192);
            this.dgv8.TabIndex = 15;
            this.dgv8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv8_CellContentClick);
            // 
            // Alert2
            // 
            this.Alert2.AutoSize = true;
            this.Alert2.BackColor = System.Drawing.Color.Transparent;
            this.Alert2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert2.ForeColor = System.Drawing.Color.SpringGreen;
            this.Alert2.Location = new System.Drawing.Point(205, 118);
            this.Alert2.Name = "Alert2";
            this.Alert2.Size = new System.Drawing.Size(21, 19);
            this.Alert2.TabIndex = 16;
            this.Alert2.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 27);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Record";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(52, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "BACK";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "....";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alert2);
            this.Controls.Add(this.dgv8);
            this.Controls.Add(this.Alert1);
            this.Controls.Add(this.dgv7);
            this.DoubleBuffered = true;
            this.Name = "Alert";
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv7;
        private System.Windows.Forms.Label Alert1;
        private System.Windows.Forms.DataGridView dgv8;
        private System.Windows.Forms.Label Alert2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}