
namespace signupapp
{
    partial class frmsurvey
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
            this.lblSur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtns = new System.Windows.Forms.TextBox();
            this.txtsurvey = new System.Windows.Forms.TextBox();
            this.btnsur = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.BackColor = System.Drawing.Color.Turquoise;
            this.lblSur.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSur.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.lblSur.Location = new System.Drawing.Point(258, 39);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(244, 45);
            this.lblSur.TabIndex = 0;
            this.lblSur.Text = "Survey Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Survey";
            // 
            // txtns
            // 
            this.txtns.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtns.Location = new System.Drawing.Point(187, 146);
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(155, 34);
            this.txtns.TabIndex = 4;
            this.txtns.TextChanged += new System.EventHandler(this.txtns_TextChanged);
            // 
            // txtsurvey
            // 
            this.txtsurvey.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsurvey.Location = new System.Drawing.Point(187, 219);
            this.txtsurvey.Name = "txtsurvey";
            this.txtsurvey.Size = new System.Drawing.Size(581, 34);
            this.txtsurvey.TabIndex = 5;
            // 
            // btnsur
            // 
            this.btnsur.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnsur.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsur.Location = new System.Drawing.Point(456, 335);
            this.btnsur.Name = "btnsur";
            this.btnsur.Size = new System.Drawing.Size(176, 55);
            this.btnsur.TabIndex = 6;
            this.btnsur.Text = "Add Survey";
            this.btnsur.UseVisualStyleBackColor = false;
            this.btnsur.Click += new System.EventHandler(this.btnsur_Click);
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
            this.btnexit.Location = new System.Drawing.Point(42, 381);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(300, 47);
            this.btnexit.TabIndex = 47;
            this.btnexit.Text = "Exit to Previous page";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // frmsurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsur);
            this.Controls.Add(this.txtsurvey);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSur);
            this.Name = "frmsurvey";
            this.Text = "frmsurvey";
            this.Load += new System.EventHandler(this.frmsurvey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtns;
        private System.Windows.Forms.TextBox txtsurvey;
        private System.Windows.Forms.Button btnsur;
        private System.Windows.Forms.Button btnexit;
    }
}