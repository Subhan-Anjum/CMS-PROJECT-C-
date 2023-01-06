
namespace signupapp
{
    partial class frmAddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStudent));
            this.lblAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddst = new System.Windows.Forms.TextBox();
            this.txtmmarks = new System.Windows.Forms.TextBox();
            this.txtcnic = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnaddintolist = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(267, 19);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(249, 45);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add Students";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cnic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Matric Marks";
            // 
            // txtaddst
            // 
            this.txtaddst.BackColor = System.Drawing.Color.White;
            this.txtaddst.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddst.Location = new System.Drawing.Point(228, 146);
            this.txtaddst.Name = "txtaddst";
            this.txtaddst.Size = new System.Drawing.Size(226, 34);
            this.txtaddst.TabIndex = 6;
            this.txtaddst.TextChanged += new System.EventHandler(this.txtaddst_TextChanged);
            // 
            // txtmmarks
            // 
            this.txtmmarks.BackColor = System.Drawing.Color.White;
            this.txtmmarks.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmmarks.Location = new System.Drawing.Point(228, 198);
            this.txtmmarks.Name = "txtmmarks";
            this.txtmmarks.Size = new System.Drawing.Size(226, 34);
            this.txtmmarks.TabIndex = 7;
            this.txtmmarks.TextChanged += new System.EventHandler(this.txtmmarks_TextChanged);
            // 
            // txtcnic
            // 
            this.txtcnic.BackColor = System.Drawing.Color.White;
            this.txtcnic.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnic.Location = new System.Drawing.Point(228, 245);
            this.txtcnic.Name = "txtcnic";
            this.txtcnic.Size = new System.Drawing.Size(226, 34);
            this.txtcnic.TabIndex = 8;
            this.txtcnic.TextChanged += new System.EventHandler(this.txtcnic_TextChanged);
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.White;
            this.txtage.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(228, 290);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(226, 34);
            this.txtage.TabIndex = 9;
            this.txtage.TextChanged += new System.EventHandler(this.txtage_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FSc Pre Engg",
            "FSc Pre Med",
            "Ics",
            "Icom",
            "Bcom",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(228, 344);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 34);
            this.comboBox1.TabIndex = 10;
            // 
            // btnaddintolist
            // 
            this.btnaddintolist.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnaddintolist.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddintolist.Location = new System.Drawing.Point(535, 379);
            this.btnaddintolist.Name = "btnaddintolist";
            this.btnaddintolist.Size = new System.Drawing.Size(98, 47);
            this.btnaddintolist.TabIndex = 11;
            this.btnaddintolist.Text = "Add";
            this.btnaddintolist.UseVisualStyleBackColor = false;
            this.btnaddintolist.Click += new System.EventHandler(this.btnaddintolist_Click);
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
            this.btnexit.Location = new System.Drawing.Point(127, 391);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(300, 47);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Exit to Previous page";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnaddintolist);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtcnic);
            this.Controls.Add(this.txtmmarks);
            this.Controls.Add(this.txtaddst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.Name = "frmAddStudent";
            this.Text = "frmAddStudent";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddst;
        private System.Windows.Forms.TextBox txtmmarks;
        private System.Windows.Forms.TextBox txtcnic;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnaddintolist;
        private System.Windows.Forms.Button btnexit;
    }
}