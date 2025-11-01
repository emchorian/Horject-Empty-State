namespace Horian_Project_Collector
{
    partial class _2
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
            this.systemPreviousForm = new System.Windows.Forms.Button();
            this.systemNextForm = new System.Windows.Forms.Button();
            this.systemExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // systemPreviousForm
            // 
            this.systemPreviousForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemPreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.systemPreviousForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.systemPreviousForm.Location = new System.Drawing.Point(493, 285);
            this.systemPreviousForm.Name = "systemPreviousForm";
            this.systemPreviousForm.Size = new System.Drawing.Size(37, 32);
            this.systemPreviousForm.TabIndex = 97;
            this.systemPreviousForm.Text = "<-";
            this.systemPreviousForm.UseVisualStyleBackColor = true;
            this.systemPreviousForm.Click += new System.EventHandler(this.systemPreviousForm_Click);
            // 
            // systemNextForm
            // 
            this.systemNextForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemNextForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.systemNextForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.systemNextForm.Location = new System.Drawing.Point(574, 285);
            this.systemNextForm.Name = "systemNextForm";
            this.systemNextForm.Size = new System.Drawing.Size(37, 32);
            this.systemNextForm.TabIndex = 99;
            this.systemNextForm.Text = "->";
            this.systemNextForm.UseVisualStyleBackColor = true;
            this.systemNextForm.Click += new System.EventHandler(this.systemNextForm_Click);
            // 
            // systemExitButton
            // 
            this.systemExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.systemExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.systemExitButton.ForeColor = System.Drawing.Color.Red;
            this.systemExitButton.Location = new System.Drawing.Point(536, 285);
            this.systemExitButton.Name = "systemExitButton";
            this.systemExitButton.Size = new System.Drawing.Size(32, 32);
            this.systemExitButton.TabIndex = 98;
            this.systemExitButton.Text = "2";
            this.systemExitButton.UseVisualStyleBackColor = true;
            this.systemExitButton.Click += new System.EventHandler(this.systemExitButton_Click);
            // 
            // _2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 329);
            this.Controls.Add(this.systemPreviousForm);
            this.Controls.Add(this.systemNextForm);
            this.Controls.Add(this.systemExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.Load += new System.EventHandler(this._2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button systemPreviousForm;
        private System.Windows.Forms.Button systemNextForm;
        private System.Windows.Forms.Button systemExitButton;
    }
}