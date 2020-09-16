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
            this.SuspendLayout();
            // 
            // writeData
            // 
            this.writeData.Location = new System.Drawing.Point(520, 150);
            this.writeData.Name = "writeData";
            this.writeData.Size = new System.Drawing.Size(226, 69);
            this.writeData.TabIndex = 0;
            this.writeData.Text = "Write Data";
            this.writeData.UseVisualStyleBackColor = true;
            this.writeData.Click += new System.EventHandler(this.writeData_Click);
            // 
            // readData
            // 
            this.readData.Location = new System.Drawing.Point(520, 235);
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(226, 69);
            this.readData.TabIndex = 1;
            this.readData.Text = "Read Data";
            this.readData.UseVisualStyleBackColor = true;
            this.readData.Click += new System.EventHandler(this.readData_Click);
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(520, 320);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(226, 69);
            this.validate.TabIndex = 2;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(520, 408);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(226, 69);
            this.create.TabIndex = 3;
            this.create.Text = "Create Employee List";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(520, 496);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(226, 69);
            this.display.TabIndex = 4;
            this.display.Text = "Display Employee List";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 695);
            this.Controls.Add(this.display);
            this.Controls.Add(this.create);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.readData);
            this.Controls.Add(this.writeData);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeData;
        private System.Windows.Forms.Button readData;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button display;
    }
}