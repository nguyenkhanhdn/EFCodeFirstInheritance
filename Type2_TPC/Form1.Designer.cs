namespace Type2_TPC
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
            this.btnOffllineCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnlineCourse
            // 
            this.btnOnlineCourse.Location = new System.Drawing.Point(214, 43);
            this.btnOnlineCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOnlineCourse.Name = "btnOnlineCourse";
            this.btnOnlineCourse.Size = new System.Drawing.Size(184, 35);
            this.btnOnlineCourse.TabIndex = 0;
            this.btnOnlineCourse.Text = "Online Course";
            this.btnOnlineCourse.UseVisualStyleBackColor = true;
            this.btnOnlineCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOffllineCourse
            // 
            this.btnOffllineCourse.Location = new System.Drawing.Point(214, 112);
            this.btnOffllineCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOffllineCourse.Name = "btnOffllineCourse";
            this.btnOffllineCourse.Size = new System.Drawing.Size(184, 35);
            this.btnOffllineCourse.TabIndex = 1;
            this.btnOffllineCourse.Text = "Offline Course";
            this.btnOffllineCourse.UseVisualStyleBackColor = true;
            this.btnOffllineCourse.Click += new System.EventHandler(this.btnOffllineCourse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnOffllineCourse);
            this.Controls.Add(this.btnOnlineCourse);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnlineCourse;
        private System.Windows.Forms.Button btnOffllineCourse;
    }
}

