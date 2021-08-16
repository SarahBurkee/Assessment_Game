
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(109, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marshmallow Roast";
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.LightBlue;
            this.BtnStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(172, 290);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(110, 26);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnInstructions
            // 
            this.BtnInstructions.BackColor = System.Drawing.Color.LightBlue;
            this.BtnInstructions.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInstructions.Location = new System.Drawing.Point(172, 335);
            this.BtnInstructions.Name = "BtnInstructions";
            this.BtnInstructions.Size = new System.Drawing.Size(110, 26);
            this.BtnInstructions.TabIndex = 2;
            this.BtnInstructions.Text = "Instructions";
            this.BtnInstructions.UseVisualStyleBackColor = false;
            this.BtnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(151, 254);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(154, 20);
            this.TxtName.TabIndex = 3;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Name (Letters Only):";
            // 
            // FormStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assessment_Game.Properties.Resources.cavefinalll;
            this.ClientSize = new System.Drawing.Size(450, 446);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
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
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
    }
}