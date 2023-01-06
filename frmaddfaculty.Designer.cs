
namespace signupapp
{
    partial class frmaddfaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddfaculty));
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtaddfct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.btnaddintolist = new System.Windows.Forms.Button();
            this.btnAgefct = new System.Windows.Forms.Label();
            this.txtagefct = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAdd.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(259, 25);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(230, 45);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "Add Faculty";
            // 
            // txtaddfct
            // 
            this.txtaddfct.BackColor = System.Drawing.Color.White;
            this.txtaddfct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddfct.Location = new System.Drawing.Point(228, 164);
            this.txtaddfct.Name = "txtaddfct";
            this.txtaddfct.Size = new System.Drawing.Size(226, 34);
            this.txtaddfct.TabIndex = 8;
            this.txtaddfct.TextChanged += new System.EventHandler(this.txtaddfct_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Qualification";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtqual
            // 
            this.txtqual.BackColor = System.Drawing.Color.White;
            this.txtqual.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqual.Location = new System.Drawing.Point(228, 230);
            this.txtqual.Name = "txtqual";
            this.txtqual.Size = new System.Drawing.Size(226, 34);
            this.txtqual.TabIndex = 10;
            this.txtqual.TextChanged += new System.EventHandler(this.txtqual_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subject";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtsubject
            // 
            this.txtsubject.BackColor = System.Drawing.Color.White;
            this.txtsubject.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.Location = new System.Drawing.Point(228, 309);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(226, 34);
            this.txtsubject.TabIndex = 12;
            this.txtsubject.TextChanged += new System.EventHandler(this.txtsubject_TextChanged);
            // 
            // btnaddintolist
            // 
            this.btnaddintolist.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnaddintolist.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddintolist.Location = new System.Drawing.Point(484, 375);
            this.btnaddintolist.Name = "btnaddintolist";
            this.btnaddintolist.Size = new System.Drawing.Size(92, 39);
            this.btnaddintolist.TabIndex = 13;
            this.btnaddintolist.Text = "Add";
            this.btnaddintolist.UseVisualStyleBackColor = false;
            this.btnaddintolist.Click += new System.EventHandler(this.btnaddintolist_Click);
            // 
            // btnAgefct
            // 
            this.btnAgefct.AutoSize = true;
            this.btnAgefct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgefct.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgefct.Location = new System.Drawing.Point(12, 375);
            this.btnAgefct.Name = "btnAgefct";
            this.btnAgefct.Size = new System.Drawing.Size(61, 32);
            this.btnAgefct.TabIndex = 14;
            this.btnAgefct.Text = "Age";
            this.btnAgefct.Click += new System.EventHandler(this.btnAgefct_Click);
            // 
            // txtagefct
            // 
            this.txtagefct.BackColor = System.Drawing.Color.White;
            this.txtagefct.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagefct.Location = new System.Drawing.Point(228, 373);
            this.txtagefct.Name = "txtagefct";
            this.txtagefct.Size = new System.Drawing.Size(226, 34);
            this.txtagefct.TabIndex = 15;
            this.txtagefct.TextChanged += new System.EventHandler(this.txtagefct_TextChanged);
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
            this.btnexit.Location = new System.Drawing.Point(593, 375);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(195, 47);
            this.btnexit.TabIndex = 25;
            this.btnexit.Text = "Exit to Main";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmaddfaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtagefct);
            this.Controls.Add(this.btnAgefct);
            this.Controls.Add(this.btnaddintolist);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtqual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaddfct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdd);
            this.DoubleBuffered = true;
            this.Name = "frmaddfaculty";
            this.Text = "frmaddfaculty";
            this.Load += new System.EventHandler(this.frmaddfaculty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtaddfct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Button btnaddintolist;
        private System.Windows.Forms.Label btnAgefct;
        private System.Windows.Forms.TextBox txtagefct;
        private System.Windows.Forms.Button btnexit;
    }
}