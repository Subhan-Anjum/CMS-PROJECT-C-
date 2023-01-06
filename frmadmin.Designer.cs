
namespace signupapp
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnviewsurvey = new System.Windows.Forms.Button();
            this.btnviewforms = new System.Windows.Forms.Button();
            this.btngeneratefeechallan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnaddstudent = new System.Windows.Forms.Button();
            this.btnrmst = new System.Windows.Forms.Button();
            this.btnaddfaculty = new System.Windows.Forms.Button();
            this.btnUpdatestinfo = new System.Windows.Forms.Button();
            this.btnrmfct = new System.Windows.Forms.Button();
            this.btnsorting = new System.Windows.Forms.Button();
            this.btndispst = new System.Windows.Forms.Button();
            this.dispfct = new System.Windows.Forms.Button();
            this.btnviewregisterd = new System.Windows.Forms.Button();
            this.btndmc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Server";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnviewsurvey);
            this.panel1.Controls.Add(this.btnviewforms);
            this.panel1.Controls.Add(this.btngeneratefeechallan);
            this.panel1.Location = new System.Drawing.Point(551, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 555);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnexit.Location = new System.Drawing.Point(102, 471);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(270, 47);
            this.btnexit.TabIndex = 20;
            this.btnexit.Text = "Exit to Main page";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // btnviewsurvey
            // 
            this.btnviewsurvey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnviewsurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnviewsurvey.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewsurvey.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnviewsurvey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnviewsurvey.Location = new System.Drawing.Point(52, 138);
            this.btnviewsurvey.Name = "btnviewsurvey";
            this.btnviewsurvey.Size = new System.Drawing.Size(237, 43);
            this.btnviewsurvey.TabIndex = 17;
            this.btnviewsurvey.Text = "View Survey";
            this.btnviewsurvey.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnviewsurvey.UseVisualStyleBackColor = false;
            this.btnviewsurvey.Click += new System.EventHandler(this.btnviewsurvey_Click_1);
            // 
            // btnviewforms
            // 
            this.btnviewforms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnviewforms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnviewforms.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewforms.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnviewforms.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnviewforms.Location = new System.Drawing.Point(52, 85);
            this.btnviewforms.Name = "btnviewforms";
            this.btnviewforms.Size = new System.Drawing.Size(338, 47);
            this.btnviewforms.TabIndex = 18;
            this.btnviewforms.Text = "View Scolarship forms";
            this.btnviewforms.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnviewforms.UseVisualStyleBackColor = false;
            this.btnviewforms.Click += new System.EventHandler(this.btnviewforms_Click_1);
            // 
            // btngeneratefeechallan
            // 
            this.btngeneratefeechallan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btngeneratefeechallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btngeneratefeechallan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratefeechallan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btngeneratefeechallan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btngeneratefeechallan.Location = new System.Drawing.Point(52, 28);
            this.btngeneratefeechallan.Name = "btngeneratefeechallan";
            this.btngeneratefeechallan.Size = new System.Drawing.Size(300, 48);
            this.btngeneratefeechallan.TabIndex = 16;
            this.btngeneratefeechallan.Text = "Generate fee challan";
            this.btngeneratefeechallan.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btngeneratefeechallan.UseVisualStyleBackColor = false;
            this.btngeneratefeechallan.Click += new System.EventHandler(this.btngeneratefeechallan_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnaddstudent);
            this.panel2.Controls.Add(this.btnrmst);
            this.panel2.Controls.Add(this.btnaddfaculty);
            this.panel2.Controls.Add(this.btnUpdatestinfo);
            this.panel2.Controls.Add(this.btnrmfct);
            this.panel2.Controls.Add(this.btnsorting);
            this.panel2.Controls.Add(this.btndispst);
            this.panel2.Controls.Add(this.dispfct);
            this.panel2.Controls.Add(this.btnviewregisterd);
            this.panel2.Controls.Add(this.btndmc);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 554);
            this.panel2.TabIndex = 17;
            // 
            // btnaddstudent
            // 
            this.btnaddstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnaddstudent.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddstudent.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnaddstudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddstudent.Location = new System.Drawing.Point(48, 32);
            this.btnaddstudent.Name = "btnaddstudent";
            this.btnaddstudent.Size = new System.Drawing.Size(270, 44);
            this.btnaddstudent.TabIndex = 24;
            this.btnaddstudent.Text = "Add Student";
            this.btnaddstudent.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnaddstudent.UseVisualStyleBackColor = false;
            this.btnaddstudent.Click += new System.EventHandler(this.btnaddstudent_Click_2);
            // 
            // btnrmst
            // 
            this.btnrmst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrmst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrmst.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmst.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnrmst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrmst.Location = new System.Drawing.Point(48, 82);
            this.btnrmst.Name = "btnrmst";
            this.btnrmst.Size = new System.Drawing.Size(286, 50);
            this.btnrmst.TabIndex = 25;
            this.btnrmst.Text = "Remove Student";
            this.btnrmst.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnrmst.UseVisualStyleBackColor = false;
            this.btnrmst.Click += new System.EventHandler(this.btnrmst_Click_2);
            // 
            // btnaddfaculty
            // 
            this.btnaddfaculty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaddfaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnaddfaculty.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddfaculty.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnaddfaculty.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaddfaculty.Location = new System.Drawing.Point(48, 134);
            this.btnaddfaculty.Name = "btnaddfaculty";
            this.btnaddfaculty.Size = new System.Drawing.Size(258, 47);
            this.btnaddfaculty.TabIndex = 26;
            this.btnaddfaculty.Text = "Add Faculty";
            this.btnaddfaculty.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnaddfaculty.UseVisualStyleBackColor = false;
            this.btnaddfaculty.Click += new System.EventHandler(this.btnaddfaculty_Click_2);
            // 
            // btnUpdatestinfo
            // 
            this.btnUpdatestinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdatestinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdatestinfo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatestinfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnUpdatestinfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdatestinfo.Location = new System.Drawing.Point(48, 428);
            this.btnUpdatestinfo.Name = "btnUpdatestinfo";
            this.btnUpdatestinfo.Size = new System.Drawing.Size(373, 44);
            this.btnUpdatestinfo.TabIndex = 33;
            this.btnUpdatestinfo.Text = "Update student info\r\n";
            this.btnUpdatestinfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdatestinfo.UseVisualStyleBackColor = false;
            this.btnUpdatestinfo.Click += new System.EventHandler(this.btnUpdatestinfo_Click_2);
            // 
            // btnrmfct
            // 
            this.btnrmfct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrmfct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnrmfct.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrmfct.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnrmfct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnrmfct.Location = new System.Drawing.Point(48, 183);
            this.btnrmfct.Name = "btnrmfct";
            this.btnrmfct.Size = new System.Drawing.Size(282, 47);
            this.btnrmfct.TabIndex = 27;
            this.btnrmfct.Text = "Remove Faculty";
            this.btnrmfct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnrmfct.UseVisualStyleBackColor = false;
            this.btnrmfct.Click += new System.EventHandler(this.btnrmfct_Click_2);
            // 
            // btnsorting
            // 
            this.btnsorting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnsorting.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsorting.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnsorting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsorting.Location = new System.Drawing.Point(48, 474);
            this.btnsorting.Name = "btnsorting";
            this.btnsorting.Size = new System.Drawing.Size(253, 44);
            this.btnsorting.TabIndex = 32;
            this.btnsorting.Text = "Sort Students";
            this.btnsorting.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsorting.UseVisualStyleBackColor = false;
            this.btnsorting.Click += new System.EventHandler(this.btnsorting_Click_2);
            // 
            // btndispst
            // 
            this.btndispst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndispst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btndispst.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndispst.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btndispst.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndispst.Location = new System.Drawing.Point(48, 232);
            this.btndispst.Name = "btndispst";
            this.btndispst.Size = new System.Drawing.Size(295, 44);
            this.btndispst.TabIndex = 30;
            this.btndispst.Text = "Display Student";
            this.btndispst.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndispst.UseVisualStyleBackColor = false;
            this.btndispst.Click += new System.EventHandler(this.btndispst_Click_2);
            // 
            // dispfct
            // 
            this.dispfct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dispfct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dispfct.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispfct.ForeColor = System.Drawing.SystemColors.MenuText;
            this.dispfct.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dispfct.Location = new System.Drawing.Point(48, 278);
            this.dispfct.Name = "dispfct";
            this.dispfct.Size = new System.Drawing.Size(282, 44);
            this.dispfct.TabIndex = 31;
            this.dispfct.Text = "Display Faculty";
            this.dispfct.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dispfct.UseVisualStyleBackColor = false;
            this.dispfct.Click += new System.EventHandler(this.dispfct_Click_2);
            // 
            // btnviewregisterd
            // 
            this.btnviewregisterd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnviewregisterd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnviewregisterd.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewregisterd.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnviewregisterd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnviewregisterd.Location = new System.Drawing.Point(48, 328);
            this.btnviewregisterd.Name = "btnviewregisterd";
            this.btnviewregisterd.Size = new System.Drawing.Size(340, 48);
            this.btnviewregisterd.TabIndex = 28;
            this.btnviewregisterd.Text = "View registered courses ";
            this.btnviewregisterd.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnviewregisterd.UseVisualStyleBackColor = false;
            this.btnviewregisterd.Click += new System.EventHandler(this.btnviewregisterd_Click_2);
            // 
            // btndmc
            // 
            this.btndmc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btndmc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btndmc.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndmc.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btndmc.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndmc.Location = new System.Drawing.Point(48, 378);
            this.btndmc.Name = "btndmc";
            this.btndmc.Size = new System.Drawing.Size(373, 48);
            this.btndmc.TabIndex = 29;
            this.btndmc.Text = "Generate MarkSheet";
            this.btndmc.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndmc.UseVisualStyleBackColor = false;
            this.btndmc.Click += new System.EventHandler(this.btndmc_Click_2);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmadmin";
            this.Text = "frmadmin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnviewsurvey;
        private System.Windows.Forms.Button btnviewforms;
        private System.Windows.Forms.Button btngeneratefeechallan;
        private System.Windows.Forms.Button btnaddstudent;
        private System.Windows.Forms.Button btnrmst;
        private System.Windows.Forms.Button btnaddfaculty;
        private System.Windows.Forms.Button btnUpdatestinfo;
        private System.Windows.Forms.Button btnrmfct;
        private System.Windows.Forms.Button btnsorting;
        private System.Windows.Forms.Button btndispst;
        private System.Windows.Forms.Button dispfct;
        private System.Windows.Forms.Button btnviewregisterd;
        private System.Windows.Forms.Button btndmc;
    }
}