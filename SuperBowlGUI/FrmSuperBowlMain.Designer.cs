namespace SuperBowlGUI
{
    partial class FrmSuperBowlMain
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
            this.btnNyil = new System.Windows.Forms.Button();
            this.tbxRomai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtvalt = new System.Windows.Forms.Button();
            this.tbxArab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Római szám [I-X]:";
            // 
            // btnNyil
            // 
            this.btnNyil.Location = new System.Drawing.Point(224, 28);
            this.btnNyil.Name = "btnNyil";
            this.btnNyil.Size = new System.Drawing.Size(97, 42);
            this.btnNyil.TabIndex = 1;
            this.btnNyil.Text = "--->";
            this.btnNyil.UseVisualStyleBackColor = true;
            // 
            // tbxRomai
            // 
            this.tbxRomai.Location = new System.Drawing.Point(26, 105);
            this.tbxRomai.Name = "tbxRomai";
            this.tbxRomai.Size = new System.Drawing.Size(153, 29);
            this.tbxRomai.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arab szám [1-10]:";
            // 
            // btnAtvalt
            // 
            this.btnAtvalt.Location = new System.Drawing.Point(224, 99);
            this.btnAtvalt.Name = "btnAtvalt";
            this.btnAtvalt.Size = new System.Drawing.Size(97, 42);
            this.btnAtvalt.TabIndex = 1;
            this.btnAtvalt.Text = "Átvált";
            this.btnAtvalt.UseVisualStyleBackColor = true;
            // 
            // tbxArab
            // 
            this.tbxArab.Enabled = false;
            this.tbxArab.Location = new System.Drawing.Point(370, 105);
            this.tbxArab.Name = "tbxArab";
            this.tbxArab.Size = new System.Drawing.Size(151, 29);
            this.tbxArab.TabIndex = 2;
            // 
            // FrmSuperBowlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 169);
            this.Controls.Add(this.tbxArab);
            this.Controls.Add(this.tbxRomai);
            this.Controls.Add(this.btnAtvalt);
            this.Controls.Add(this.btnNyil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSuperBowlMain";
            this.Text = "Átváltó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNyil;
        private System.Windows.Forms.TextBox tbxRomai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtvalt;
        private System.Windows.Forms.TextBox tbxArab;
    }
}

