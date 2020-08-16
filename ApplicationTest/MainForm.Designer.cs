namespace ApplicationTest
{
    partial class MainForm
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.buttonOpen2ndForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(328, 266);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(169, 81);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(328, 37);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(169, 75);
            this.buttonShowMessage.TabIndex = 1;
            this.buttonShowMessage.Text = "Show Message";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // buttonOpen2ndForm
            // 
            this.buttonOpen2ndForm.Location = new System.Drawing.Point(328, 144);
            this.buttonOpen2ndForm.Name = "buttonOpen2ndForm";
            this.buttonOpen2ndForm.Size = new System.Drawing.Size(169, 88);
            this.buttonOpen2ndForm.TabIndex = 2;
            this.buttonOpen2ndForm.Text = "Open 2nd Form";
            this.buttonOpen2ndForm.UseVisualStyleBackColor = true;
            this.buttonOpen2ndForm.Click += new System.EventHandler(this.buttonOpen2ndForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOpen2ndForm);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.buttonExit);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Button buttonOpen2ndForm;
    }
}

