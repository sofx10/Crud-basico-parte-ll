
namespace Crud1
{
    partial class FmrTest
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
            this.Test = new System.Windows.Forms.Button();
            this.btnTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(361, 194);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(10, 10);
            this.Test.TabIndex = 0;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(128, 71);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(120, 40);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test";
            this.btnTest.UseSelectable = true;
            this.btnTest.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // FmrTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 205);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.Test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmrTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Test;
        private MetroFramework.Controls.MetroButton btnTest;
    }
}