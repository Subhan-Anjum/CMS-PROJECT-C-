
namespace signupapp
{
    partial class scolarshipdata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddstf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgpa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfather = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.btnaddsco = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(225, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScholarShip Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtaddstf
            // 
            this.txtaddstf.BackColor = System.Drawing.Color.White;
            this.txtaddstf.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddstf.Location = new System.Drawing.Point(220, 160);
            this.txtaddstf.Name = "txtaddstf";
            this.txtaddstf.Size = new System.Drawing.Size(226, 34);
            this.txtaddstf.TabIndex = 7;
            this.txtaddstf.TextChanged += new System.EventHandler(this.txtaddstf_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gpa";
            // 
            // txtgpa
            // 
            this.txtgpa.BackColor = System.Drawing.Color.White;
            this.txtgpa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgpa.Location = new System.Drawing.Point(220, 234);
            this.txtgpa.Name = "txtgpa";
            this.txtgpa.Size = new System.Drawing.Size(226, 34);
            this.txtgpa.TabIndex = 9;
            this.txtgpa.TextChanged += new System.EventHandler(this.txtgpa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Father Status";
            // 
            // txtfather
            // 
            this.txtfather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtfather.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfather.FormattingEnabled = true;
            this.txtfather.Items.AddRange(new object[] {
            "Deceased",
            "Alive"});
            this.txtfather.Location = new System.Drawing.Point(220, 311);
            this.txtfather.Name = "txtfather";
            this.txtfather.Size = new System.Drawing.Size(226, 34);
            this.txtfather.TabIndex = 11;
            this.txtfather.SelectedIndexChanged += new System.EventHandler(this.txtfather_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Type";
            // 
            // txttype
            // 
            this.txttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttype.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "HEC",
            "EHSAAS",
            "FA&CS"});
            this.txttype.Location = new System.Drawing.Point(220, 398);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(226, 34);
            this.txttype.TabIndex = 13;
            this.txttype.SelectedIndexChanged += new System.EventHandler(this.txttype_SelectedIndexChanged);
            // 
            // btnaddsco
            // 
            this.btnaddsco.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsco.Location = new System.Drawing.Point(575, 313);
            this.btnaddsco.Name = "btnaddsco";
            this.btnaddsco.Size = new System.Drawing.Size(108, 48);
            this.btnaddsco.TabIndex = 14;
            this.btnaddsco.Text = "Add";
            this.btnaddsco.UseVisualStyleBackColor = true;
            this.btnaddsco.Click += new System.EventHandler(this.btnaddsco_Click);
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
            this.btnexit.Location = new System.Drawing.Point(480, 385);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(324, 47);
            this.btnexit.TabIndex = 49;
            this.btnexit.Text = "Exit to Previous page";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // scolarshipdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnaddsco);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfather);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgpa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtaddstf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "scolarshipdata";
            this.Text = "scolarshipdata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddstf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgpa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtfather;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txttype;
        private System.Windows.Forms.Button btnaddsco;
        private System.Windows.Forms.Button btnexit;
    }
}