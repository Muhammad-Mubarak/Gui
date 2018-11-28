namespace departmental_store
{
    partial class Subcategory
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.savebutton = new System.Windows.Forms.Button();
            this.category_name = new System.Windows.Forms.Label();
            this.categorysub = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(334, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(314, 194);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 10;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // category_name
            // 
            this.category_name.AutoSize = true;
            this.category_name.Location = new System.Drawing.Point(57, 89);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(74, 13);
            this.category_name.TabIndex = 9;
            this.category_name.Text = "Sub_Category";
            // 
            // categorysub
            // 
            this.categorysub.Location = new System.Drawing.Point(257, 82);
            this.categorysub.Name = "categorysub";
            this.categorysub.Size = new System.Drawing.Size(132, 20);
            this.categorysub.TabIndex = 8;
            // 
            // Subcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 329);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.categorysub);
            this.Name = "Subcategory";
            this.Text = "Subcategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label category_name;
        private System.Windows.Forms.TextBox categorysub;
    }
}