
namespace WindowsFormsApp1
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
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.ProcessFileButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(280, 98);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(100, 22);
            this.FilePathTextBox.TabIndex = 0;
            // 
            // ProcessFileButton
            // 
            this.ProcessFileButton.Location = new System.Drawing.Point(158, 96);
            this.ProcessFileButton.Name = "ProcessFileButton";
            this.ProcessFileButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessFileButton.TabIndex = 1;
            this.ProcessFileButton.Text = "Process";
            this.ProcessFileButton.UseVisualStyleBackColor = true;
            this.ProcessFileButton.Click += new System.EventHandler(this.ProcessFileButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(296, 200);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(48, 17);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Result";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(280, 148);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(100, 22);
            this.OutputTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ProcessFileButton);
            this.Controls.Add(this.FilePathTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.Button ProcessFileButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

