namespace departmental_store
{
    partial class add_category
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
            this.category = new System.Windows.Forms.TextBox();
            this.category_name = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(243, 65);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(132, 20);
            this.category.TabIndex = 4;
            // 
            // category_name
            // 
            this.category_name.AutoSize = true;
            this.category_name.Location = new System.Drawing.Point(43, 72);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(49, 13);
            this.category_name.TabIndex = 5;
            this.category_name.Text = "Category";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(300, 177);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 232);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // add_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 404);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.category);
            this.Name = "add_category";
            this.Text = "add_category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label category_name;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}