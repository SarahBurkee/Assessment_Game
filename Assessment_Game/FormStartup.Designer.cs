
namespace Assessment_Game
{
    partial class FormStartup
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnInstructions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Name";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(186, 261);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnInstructions
            // 
            this.BtnInstructions.Location = new System.Drawing.Point(186, 309);
            this.BtnInstructions.Name = "BtnInstructions";
            this.BtnInstructions.Size = new System.Drawing.Size(75, 23);
            this.BtnInstructions.TabIndex = 2;
            this.BtnInstructions.Text = "Instructions";
            this.BtnInstructions.UseVisualStyleBackColor = true;
            this.BtnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_Game.Properties.Resources.ice_cave;
            this.ClientSize = new System.Drawing.Size(450, 416);
            this.Controls.Add(this.BtnInstructions);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.label1);
            this.Name = "FormStartup";
            this.Text = "FormStartup";
            this.Load += new System.EventHandler(this.FormStartup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnInstructions;
    }
}