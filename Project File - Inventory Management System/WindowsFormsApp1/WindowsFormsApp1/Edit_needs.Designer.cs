
namespace WindowsFormsApp1
{
    partial class Edit_needs
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
            this.Societyid = new System.Windows.Forms.TextBox();
            this.noofitems = new System.Windows.Forms.TextBox();
            this.eventid = new System.Windows.Forms.TextBox();
            this.itemname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv8 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv7
            // 
            this.dgv7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv7.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv7.Location = new System.Drawing.Point(297, 12);
            this.dgv7.Name = "dgv7";
            this.dgv7.Size = new System.Drawing.Size(374, 141);
            this.dgv7.TabIndex = 14;
            this.dgv7.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv7_CellContentClick);
            // 
            // Societyid
            // 
            this.Societyid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Societyid.Location = new System.Drawing.Point(59, 94);
            this.Societyid.Name = "Societyid";
            this.Societyid.Size = new System.Drawing.Size(163, 25);
            this.Societyid.TabIndex = 15;
            this.Societyid.Text = "Enter id";
            // 
            // noofitems
            // 
            this.noofitems.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofitems.Location = new System.Drawing.Point(59, 146);
            this.noofitems.Name = "noofitems";
            this.noofitems.Size = new System.Drawing.Size(163, 25);
            this.noofitems.TabIndex = 16;
            this.noofitems.Text = "Enter No";
            // 
            // eventid
            // 
            this.eventid.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventid.Location = new System.Drawing.Point(59, 196);
            this.eventid.Name = "eventid";
            this.eventid.Size = new System.Drawing.Size(163, 25);
            this.eventid.TabIndex = 17;
            this.eventid.Text = "Enter id";
            // 
            // itemname
            // 
            this.itemname.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemname.Location = new System.Drawing.Point(59, 247);
            this.itemname.Name = "itemname";
            this.itemname.Size = new System.Drawing.Size(163, 25);
            this.itemname.TabIndex = 18;
            this.itemname.Text = "Enter Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "BACK";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dgv8
            // 
            this.dgv8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv8.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv8.Location = new System.Drawing.Point(297, 159);
            this.dgv8.Name = "dgv8";
            this.dgv8.Size = new System.Drawing.Size(374, 141);
            this.dgv8.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(589, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Society needs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 22;
            this.label2.Text = "Confirm!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Edit_needs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._211;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemname);
            this.Controls.Add(this.eventid);
            this.Controls.Add(this.noofitems);
            this.Controls.Add(this.Societyid);
            this.Controls.Add(this.dgv7);
            this.DoubleBuffered = true;
            this.Name = "Edit_needs";
            this.Text = "Edit_needs";
            ((System.ComponentModel.ISupportInitialize)(this.dgv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv7;
        private System.Windows.Forms.TextBox Societyid;
        private System.Windows.Forms.TextBox noofitems;
        private System.Windows.Forms.TextBox eventid;
        private System.Windows.Forms.TextBox itemname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}