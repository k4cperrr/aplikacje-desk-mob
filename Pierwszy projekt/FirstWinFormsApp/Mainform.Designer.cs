
namespace FirstWinFormsApp
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonfirst = new System.Windows.Forms.Button();
            this.buttonHello = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonHelloName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonfirst
            // 
            this.buttonfirst.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.buttonfirst.Location = new System.Drawing.Point(654, 287);
            this.buttonfirst.Name = "buttonfirst";
            this.buttonfirst.Size = new System.Drawing.Size(179, 103);
            this.buttonfirst.TabIndex = 0;
            this.buttonfirst.Text = "przycisk";
            this.buttonfirst.UseVisualStyleBackColor = true;
            this.buttonfirst.Click += new System.EventHandler(this.buttonfirst_Click);
            // 
            // buttonHello
            // 
            this.buttonHello.Font = new System.Drawing.Font("Source Serif Pro", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonHello.Location = new System.Drawing.Point(106, 291);
            this.buttonHello.Name = "buttonHello";
            this.buttonHello.Size = new System.Drawing.Size(179, 103);
            this.buttonHello.TabIndex = 1;
            this.buttonHello.Text = "hello";
            this.buttonHello.UseVisualStyleBackColor = true;
            this.buttonHello.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.DarkGray;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelName.Location = new System.Drawing.Point(106, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(207, 50);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Podaj imie";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonHelloName
            // 
            this.buttonHelloName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonHelloName.Location = new System.Drawing.Point(106, 133);
            this.buttonHelloName.Name = "buttonHelloName";
            this.buttonHelloName.Size = new System.Drawing.Size(225, 76);
            this.buttonHelloName.TabIndex = 4;
            this.buttonHelloName.Text = "Przywitaj sie";
            this.buttonHelloName.UseVisualStyleBackColor = true;
            this.buttonHelloName.Click += new System.EventHandler(this.buttonHelloName_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.buttonHelloName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonHello);
            this.Controls.Add(this.buttonfirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mainform";
            this.Text = "Pierwszy program okienkowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonfirst;
        private System.Windows.Forms.Button buttonHello;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonHelloName;
    }
}

