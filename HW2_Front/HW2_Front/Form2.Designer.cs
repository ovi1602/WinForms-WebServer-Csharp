namespace HW2_Front
{
    partial class Form2
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
            this.listBoxTitle = new System.Windows.Forms.ListBox();
            this.listBoxContent = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPostedBy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTitle
            // 
            this.listBoxTitle.FormattingEnabled = true;
            this.listBoxTitle.Location = new System.Drawing.Point(81, 68);
            this.listBoxTitle.Name = "listBoxTitle";
            this.listBoxTitle.Size = new System.Drawing.Size(251, 212);
            this.listBoxTitle.TabIndex = 0;
            this.listBoxTitle.SelectedIndexChanged += new System.EventHandler(this.listBoxTitle_SelectedIndexChanged);
            // 
            // listBoxContent
            // 
            this.listBoxContent.FormattingEnabled = true;
            this.listBoxContent.Location = new System.Drawing.Point(455, 68);
            this.listBoxContent.Name = "listBoxContent";
            this.listBoxContent.Size = new System.Drawing.Size(251, 212);
            this.listBoxContent.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(354, 333);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add a post";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Post";
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(354, 362);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 23);
            this.buttonR.TabIndex = 5;
            this.buttonR.Text = "Refresh";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posted by";
            // 
            // textBoxPostedBy
            // 
            this.textBoxPostedBy.Enabled = false;
            this.textBoxPostedBy.Location = new System.Drawing.Point(542, 298);
            this.textBoxPostedBy.Name = "textBoxPostedBy";
            this.textBoxPostedBy.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostedBy.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPostedBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxContent);
            this.Controls.Add(this.listBoxTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTitle;
        private System.Windows.Forms.ListBox listBoxContent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPostedBy;
    }
}