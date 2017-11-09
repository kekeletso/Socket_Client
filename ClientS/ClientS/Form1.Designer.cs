namespace ClientS
{
    partial class Form1
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
            this.txtuserip = new System.Windows.Forms.TextBox();
            this.btnaddress = new System.Windows.Forms.Button();
            this.txtresponse = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
           
            this.SuspendLayout();
            // 
            // txtuserip
            // 
            this.txtuserip.Location = new System.Drawing.Point(127, 27);
            this.txtuserip.Name = "txtuserip";
            this.txtuserip.Size = new System.Drawing.Size(115, 20);
            this.txtuserip.TabIndex = 0;
            // 
            // btnaddress
            // 
            this.btnaddress.Location = new System.Drawing.Point(127, 94);
            this.btnaddress.Name = "btnaddress";
            this.btnaddress.Size = new System.Drawing.Size(115, 23);
            this.btnaddress.TabIndex = 1;
            this.btnaddress.Text = "click to ping address";
            this.btnaddress.UseVisualStyleBackColor = true;
            this.btnaddress.Click += new System.EventHandler(this.btnaddress_Click);
            // 
            // txtresponse
            // 
            this.txtresponse.Location = new System.Drawing.Point(127, 160);
            this.txtresponse.Name = "txtresponse";
            this.txtresponse.Size = new System.Drawing.Size(115, 20);
            this.txtresponse.TabIndex = 2;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(330, 199);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 13);
            this.lblmsg.TabIndex = 3;
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(29, 34);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(85, 13);
            this.lblip.TabIndex = 4;
            this.lblip.Text = "Enter IP address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server Response";
            // 
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 263);
            
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblip);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtresponse);
            this.Controls.Add(this.btnaddress);
            this.Controls.Add(this.txtuserip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtuserip;
        private System.Windows.Forms.Button btnaddress;
        private System.Windows.Forms.TextBox txtresponse;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label label1;
     
    }
}

