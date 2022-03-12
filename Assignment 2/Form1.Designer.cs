
namespace Assignment_2
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
            this.txtbx1 = new System.Windows.Forms.TextBox();
            this.first = new System.Windows.Forms.Button();
            this.last = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbx1
            // 
            this.txtbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx1.Location = new System.Drawing.Point(107, 12);
            this.txtbx1.Multiline = true;
            this.txtbx1.Name = "txtbx1";
            this.txtbx1.Size = new System.Drawing.Size(622, 339);
            this.txtbx1.TabIndex = 0;
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.Location = new System.Drawing.Point(183, 387);
            this.first.Name = "first";
            this.first.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.first.Size = new System.Drawing.Size(172, 104);
            this.first.TabIndex = 1;
            this.first.Text = "print first 5 lines";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.button1_Click);
            // 
            // last
            // 
            this.last.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last.Location = new System.Drawing.Point(439, 387);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(176, 104);
            this.last.TabIndex = 2;
            this.last.Text = "print last 5 lines";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 579);
            this.Controls.Add(this.last);
            this.Controls.Add(this.first);
            this.Controls.Add(this.txtbx1);
            this.Name = "Form1";
            this.Text = ".";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx1;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button last;
    }
}

