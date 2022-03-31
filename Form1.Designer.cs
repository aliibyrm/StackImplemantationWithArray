namespace Stack
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
            this.arrayToStackbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arrayToStackbtn
            // 
            this.arrayToStackbtn.Location = new System.Drawing.Point(64, 24);
            this.arrayToStackbtn.Name = "arrayToStackbtn";
            this.arrayToStackbtn.Size = new System.Drawing.Size(120, 23);
            this.arrayToStackbtn.TabIndex = 1;
            this.arrayToStackbtn.Text = "Array To Stack";
            this.arrayToStackbtn.UseVisualStyleBackColor = true;
            this.arrayToStackbtn.Click += new System.EventHandler(this.arrayToStackbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.arrayToStackbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button arrayToStackbtn;
    }
}

