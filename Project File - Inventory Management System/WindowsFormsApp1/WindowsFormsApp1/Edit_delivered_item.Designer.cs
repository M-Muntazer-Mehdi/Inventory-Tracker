
namespace WindowsFormsApp1
{
    partial class Edit_delivered_item
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
            this.itemname = new System.Windows.Forms.TextBox();
            this.societyname = new System.Windows.Forms.TextBox();
            this.noof = new System.Windows.Forms.TextBox();
            this.itemid = new System.Windows.Forms.TextBox();
            this.Societycode = new System.Windows.Forms.TextBox();
            this.dgv7 = new System.Windows.Forms.DataGridView();
            this.dgv8 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).BeginInit();
            this.SuspendLayout();
            // 
            // itemname
            // 
            this.itemname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(63, 39);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(185, 26);
            this.itemname.TabIndex = 1;
            this.itemname.Text = "Enter name";
            // 
            // societyname
            // 
            this.societyname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.societyname.Location = new System.Drawing.Point(63, 88);
            this.societyname.Name = "societyname";
            this.societyname.Size = new System.Drawing.Size(185, 26);
            this.societyname.TabIndex = 2;
            this.societyname.Text = "Enter name";
            // 
            // noof
            // 
            this.noof.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noof.Location = new System.Drawing.Point(63, 141);
            this.noof.Name = "noof";
            this.noof.Size = new System.Drawing.Size(185, 26);
            this.noof.TabIndex = 5;
            this.noof.Text = "Enter No";
            // 
            // itemid
            // 
            this.itemid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemid.Location = new System.Drawing.Point(63, 197);
            this.itemid.Name = "itemid";
            this.itemid.Size = new System.Drawing.Size(185, 26);
            this.itemid.TabIndex = 6;
            this.itemid.Text = "Enter id";
            // 
            // Societycode
            // 
            this.Societycode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Societycode.Location = new System.Drawing.Point(63, 247);
            this.Societycode.Name = "Societycode";
            this.Societycode.Size = new System.Drawing.Size(185, 26);
            this.Societycode.TabIndex = 7;
            this.Societycode.Text = "Enter code";
            // 
            // dgv7
            // 
            this.dgv7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv7.Location = new System.Drawing.Point(306, 39);
            this.dgv7.Name = "dgv7";
            this.dgv7.Size = new System.Drawing.Size(374, 119);
            this.dgv7.TabIndex = 14;
            this.dgv7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv7_CellContentClick);
            // 
            // dgv8
            // 
            this.dgv8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv8.Location = new System.Drawing.Point(306, 164);
            this.dgv8.Name = "dgv8";
            this.dgv8.Size = new System.Drawing.Size(374, 119);
            this.dgv8.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Confirm!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 20;
            this.label9.Text = "BACK";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(591, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Deliver Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Edit_delivered_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._18;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv8);
            this.Controls.Add(this.dgv7);
            this.Controls.Add(this.Societycode);
            this.Controls.Add(this.itemid);
            this.Controls.Add(this.noof);
            this.Controls.Add(this.societyname);
            this.Controls.Add(this.itemname);
            this.DoubleBuffered = true;
            this.Name = "Edit_delivered_item";
            this.Text = "Edit_delivered_item";
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.TextBox societyname;
        private System.Windows.Forms.TextBox noof;
        private System.Windows.Forms.TextBox itemid;
        private System.Windows.Forms.TextBox Societycode;
        private System.Windows.Forms.DataGridView dgv7;
        private System.Windows.Forms.DataGridView dgv8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
    }
}