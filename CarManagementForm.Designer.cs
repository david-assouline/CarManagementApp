
namespace CarManagementApp
{
    partial class CarManagementForm
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
            this.addCarButton = new System.Windows.Forms.Button();
            this.viewCarsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addCarButton
            // 
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(360, 250);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(448, 162);
            this.addCarButton.TabIndex = 0;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // viewCarsButton
            // 
            this.viewCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCarsButton.Location = new System.Drawing.Point(360, 500);
            this.viewCarsButton.Name = "viewCarsButton";
            this.viewCarsButton.Size = new System.Drawing.Size(448, 162);
            this.viewCarsButton.TabIndex = 1;
            this.viewCarsButton.Text = "View Cars";
            this.viewCarsButton.UseVisualStyleBackColor = true;
            this.viewCarsButton.Click += new System.EventHandler(this.viewCarsButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(360, 750);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(448, 162);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 1215);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.viewCarsButton);
            this.Controls.Add(this.addCarButton);
            this.Name = "Form1";
            this.Text = "Car Management";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.Button viewCarsButton;
        private System.Windows.Forms.Button saveButton;
    }
}

