
namespace WindowsFormsApp1
{
    partial class Edit_Societies
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
            this.societyname = new System.Windows.Forms.TextBox();
            this.Societyid = new System.Windows.Forms.TextBox();
            this.Room = new System.Windows.Forms.TextBox();
            this.mentor = new System.Windows.Forms.TextBox();
            this.Head = new System.Windows.Forms.TextBox();
            this.Members = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // societyname
            // 
            this.societyname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.societyname.Location = new System.Drawing.Point(425, 99);
            this.societyname.Name = "societyname";
            this.societyname.Size = new System.Drawing.Size(185, 26);
            this.societyname.TabIndex = 1;
            this.societyname.Text = "Enter name";
            // 
            // Societyid
            // 
            this.Societyid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Societyid.Location = new System.Drawing.Point(69, 99);
            this.Societyid.Name = "Societyid";
            this.Societyid.Size = new System.Drawing.Size(185, 26);
            this.Societyid.TabIndex = 3;
            this.Societyid.Text = "Enter id";
            // 
            // Room
            // 
            this.Room.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.Location = new System.Drawing.Point(69, 166);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(185, 26);
            this.Room.TabIndex = 4;
            this.Room.Text = "Enter Room";
            // 
            // mentor
            // 
            this.mentor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentor.Location = new System.Drawing.Point(425, 166);
            this.mentor.Name = "mentor";
            this.mentor.Size = new System.Drawing.Size(185, 26);
            this.mentor.TabIndex = 5;
            this.mentor.Text = "Enter name";
            // 
            // Head
            // 
            this.Head.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.Location = new System.Drawing.Point(69, 235);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(185, 26);
            this.Head.TabIndex = 6;
            this.Head.Text = "Enter name";
            // 
            // Members
            // 
            this.Members.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Members.Location = new System.Drawing.Point(425, 235);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(185, 26);
            this.Members.TabIndex = 7;
            this.Members.Text = "Enter No.of.Mem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "BACK";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(581, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Society Record";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Confirm!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Edit_Societies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._19;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.Head);
            this.Controls.Add(this.mentor);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Societyid);
            this.Controls.Add(this.societyname);
            this.DoubleBuffered = true;
            this.Name = "Edit_Societies";
            this.Text = "Edit_Societies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox societyname;
        private System.Windows.Forms.TextBox Societyid;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.TextBox mentor;
        private System.Windows.Forms.TextBox Head;
        private System.Windows.Forms.TextBox Members;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}