namespace Lab1_ConnectedMode2.GUI
{
    partial class FormTest
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
            this.writeData = new System.Windows.Forms.Button();
            this.readData = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Button();
            this.openDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeData
            // 
            this.writeData.Location = new System.Drawing.Point(347, 97);
            this.writeData.Margin = new System.Windows.Forms.Padding(2);
            this.writeData.Name = "writeData";
            this.writeData.Size = new System.Drawing.Size(151, 45);
            this.writeData.TabIndex = 0;
            this.writeData.Text = "Write Data";
            this.writeData.UseVisualStyleBackColor = true;
            this.writeData.Click += new System.EventHandler(this.writeData_Click);
            // 
            // readData
            // 
            this.readData.Location = new System.Drawing.Point(347, 153);
            this.readData.Margin = new System.Windows.Forms.Padding(2);
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(151, 45);
            this.readData.TabIndex = 1;
            this.readData.Text = "Read Data";
            this.readData.UseVisualStyleBackColor = true;
            this.readData.Click += new System.EventHandler(this.readData_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(347, 208);
            this.validate.Margin = new System.Windows.Forms.Padding(2);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(151, 45);
            this.validate.TabIndex = 2;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(347, 265);
            this.create.Margin = new System.Windows.Forms.Padding(2);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(151, 45);
            this.create.TabIndex = 3;
            this.create.Text = "Create Employee List";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(347, 322);
            this.display.Margin = new System.Windows.Forms.Padding(2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(151, 45);
            this.display.TabIndex = 4;
            this.display.Text = "Display Employee List";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // openDB
            // 
            this.openDB.Location = new System.Drawing.Point(347, 380);
            this.openDB.Margin = new System.Windows.Forms.Padding(2);
            this.openDB.Name = "openDB";
            this.openDB.Size = new System.Drawing.Size(151, 45);
            this.openDB.TabIndex = 5;
            this.openDB.Text = "Open DB";
            this.openDB.UseVisualStyleBackColor = true;
            this.openDB.Click += new System.EventHandler(this.openDB_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 566);
            this.Controls.Add(this.openDB);
            this.Controls.Add(this.display);
            this.Controls.Add(this.create);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readData);
            this.Controls.Add(this.writeData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeData;
        private System.Windows.Forms.Button readData;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button openDB;
    }
}