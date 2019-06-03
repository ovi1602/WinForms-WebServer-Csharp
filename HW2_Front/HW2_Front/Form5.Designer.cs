namespace HW2_Front
{
    partial class Form5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.butonDelete = new System.Windows.Forms.Button();
            this.buttonMakeAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "User to make admin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Title to delete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(386, 209);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 12;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(386, 172);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 11;
            // 
            // butonDelete
            // 
            this.butonDelete.Location = new System.Drawing.Point(527, 170);
            this.butonDelete.Name = "butonDelete";
            this.butonDelete.Size = new System.Drawing.Size(75, 23);
            this.butonDelete.TabIndex = 10;
            this.butonDelete.Text = "Delete";
            this.butonDelete.UseVisualStyleBackColor = true;
            this.butonDelete.Click += new System.EventHandler(this.butonDelete_Click);
            // 
            // buttonMakeAdmin
            // 
            this.buttonMakeAdmin.Location = new System.Drawing.Point(527, 209);
            this.buttonMakeAdmin.Name = "buttonMakeAdmin";
            this.buttonMakeAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeAdmin.TabIndex = 15;
            this.buttonMakeAdmin.Text = "Make Admin";
            this.buttonMakeAdmin.UseVisualStyleBackColor = true;
            this.buttonMakeAdmin.Click += new System.EventHandler(this.buttonMakeAdmin_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMakeAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.butonDelete);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button butonDelete;
        private System.Windows.Forms.Button buttonMakeAdmin;
    }
}