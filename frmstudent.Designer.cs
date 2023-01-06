
namespace signupapp
{
    partial class frmstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstudent));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btngivesurvey = new System.Windows.Forms.Button();
            this.btnapplyscolarship = new System.Windows.Forms.Button();
            this.btnviewChallan = new System.Windows.Forms.Button();
            this.btncheckmarks = new System.Windows.Forms.Button();
            this.btnRegisterCourses = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Server";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btngivesurvey);
            this.panel1.Controls.Add(this.btnapplyscolarship);
            this.panel1.Controls.Add(this.btnviewChallan);
            this.panel1.Controls.Add(this.btncheckmarks);
            this.panel1.Controls.Add(this.btnRegisterCourses);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 341);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btngivesurvey
            // 
            this.btngivesurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btngivesurvey.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngivesurvey.Location = new System.Drawing.Point(11, 262);
            this.btngivesurvey.Name = "btngivesurvey";
            this.btngivesurvey.Size = new System.Drawing.Size(240, 48);
            this.btngivesurvey.TabIndex = 12;
            this.btngivesurvey.Text = "Give Survey";
            this.btngivesurvey.UseVisualStyleBackColor = false;
            this.btngivesurvey.Click += new System.EventHandler(this.btngivesurvey_Click);
            // 
            // btnapplyscolarship
            // 
            this.btnapplyscolarship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnapplyscolarship.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapplyscolarship.Location = new System.Drawing.Point(11, 209);
            this.btnapplyscolarship.Name = "btnapplyscolarship";
            this.btnapplyscolarship.Size = new System.Drawing.Size(300, 47);
            this.btnapplyscolarship.TabIndex = 11;
            this.btnapplyscolarship.Text = "Apply Scolarship";
            this.btnapplyscolarship.UseVisualStyleBackColor = false;
            this.btnapplyscolarship.Click += new System.EventHandler(this.btnapplyscolarship_Click);
            // 
            // btnviewChallan
            // 
            this.btnviewChallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnviewChallan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewChallan.Location = new System.Drawing.Point(11, 145);
            this.btnviewChallan.Name = "btnviewChallan";
            this.btnviewChallan.Size = new System.Drawing.Size(300, 59);
            this.btnviewChallan.TabIndex = 10;
            this.btnviewChallan.Text = "View Challan Form";
            this.btnviewChallan.UseVisualStyleBackColor = false;
            this.btnviewChallan.Click += new System.EventHandler(this.btnviewChallan_Click);
            // 
            // btncheckmarks
            // 
            this.btncheckmarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btncheckmarks.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckmarks.Location = new System.Drawing.Point(11, 89);
            this.btncheckmarks.Name = "btncheckmarks";
            this.btncheckmarks.Size = new System.Drawing.Size(362, 50);
            this.btncheckmarks.TabIndex = 9;
            this.btncheckmarks.Text = "Check Detailed marksheet";
            this.btncheckmarks.UseVisualStyleBackColor = false;
            this.btncheckmarks.Click += new System.EventHandler(this.btncheckmarks_Click);
            // 
            // btnRegisterCourses
            // 
            this.btnRegisterCourses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegisterCourses.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterCourses.Location = new System.Drawing.Point(11, 30);
            this.btnRegisterCourses.Name = "btnRegisterCourses";
            this.btnRegisterCourses.Size = new System.Drawing.Size(291, 53);
            this.btnRegisterCourses.TabIndex = 8;
            this.btnRegisterCourses.Text = "Register Courses";
            this.btnRegisterCourses.UseVisualStyleBackColor = false;
            this.btnRegisterCourses.Click += new System.EventHandler(this.btnRegisterCourses_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(410, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(257, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = " Exit to Main Page";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmstudent";
            this.Text = "frmstudent";
            this.Load += new System.EventHandler(this.frmstudent_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btngivesurvey;
        private System.Windows.Forms.Button btnapplyscolarship;
        private System.Windows.Forms.Button btnviewChallan;
        private System.Windows.Forms.Button btncheckmarks;
        private System.Windows.Forms.Button btnRegisterCourses;
    }
}