namespace Type1TPH
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
            this.btnOnlineCourse = new System.Windows.Forms.Button();
            this.btnOfflineCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnlineCourse
            // 
            this.btnOnlineCourse.Location = new System.Drawing.Point(191, 49);
            this.btnOnlineCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOnlineCourse.Name = "btnOnlineCourse";
            this.btnOnlineCourse.Size = new System.Drawing.Size(164, 35);
            this.btnOnlineCourse.TabIndex = 0;
            this.btnOnlineCourse.Text = "Online Course";
            this.btnOnlineCourse.UseVisualStyleBackColor = true;
            this.btnOnlineCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOfflineCourse
            // 
            this.btnOfflineCourse.Location = new System.Drawing.Point(191, 123);
            this.btnOfflineCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOfflineCourse.Name = "btnOfflineCourse";
            this.btnOfflineCourse.Size = new System.Drawing.Size(164, 35);
            this.btnOfflineCourse.TabIndex = 1;
            this.btnOfflineCourse.Text = "Offline Course";
            this.btnOfflineCourse.UseVisualStyleBackColor = true;
            this.btnOfflineCourse.Click += new System.EventHandler(this.btnOfflineCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnOfflineCourse);
            this.Controls.Add(this.btnOnlineCourse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnlineCourse;
        private System.Windows.Forms.Button btnOfflineCourse;
    }
}

