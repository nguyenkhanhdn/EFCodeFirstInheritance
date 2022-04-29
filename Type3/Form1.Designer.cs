namespace Type3
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
            this.btnTablePerType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTablePerType
            // 
            this.btnTablePerType.Location = new System.Drawing.Point(94, 75);
            this.btnTablePerType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTablePerType.Name = "btnTablePerType";
            this.btnTablePerType.Size = new System.Drawing.Size(182, 35);
            this.btnTablePerType.TabIndex = 0;
            this.btnTablePerType.Text = "Table Per Type";
            this.btnTablePerType.UseVisualStyleBackColor = true;
            this.btnTablePerType.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.btnTablePerType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTablePerType;
    }
}

