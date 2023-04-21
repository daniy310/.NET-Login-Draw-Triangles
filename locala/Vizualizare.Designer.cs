
namespace locala
{
    partial class Vizualizare
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonDesenare = new System.Windows.Forms.RadioButton();
            this.radioButtonStergere = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // radioButtonDesenare
            // 
            this.radioButtonDesenare.AutoSize = true;
            this.radioButtonDesenare.Checked = true;
            this.radioButtonDesenare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonDesenare.Location = new System.Drawing.Point(822, 25);
            this.radioButtonDesenare.Name = "radioButtonDesenare";
            this.radioButtonDesenare.Size = new System.Drawing.Size(150, 35);
            this.radioButtonDesenare.TabIndex = 1;
            this.radioButtonDesenare.TabStop = true;
            this.radioButtonDesenare.Text = "Desenare";
            this.radioButtonDesenare.UseVisualStyleBackColor = true;
            // 
            // radioButtonStergere
            // 
            this.radioButtonStergere.AutoSize = true;
            this.radioButtonStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonStergere.Location = new System.Drawing.Point(822, 83);
            this.radioButtonStergere.Name = "radioButtonStergere";
            this.radioButtonStergere.Size = new System.Drawing.Size(136, 35);
            this.radioButtonStergere.TabIndex = 2;
            this.radioButtonStergere.Text = "Stergere";
            this.radioButtonStergere.UseVisualStyleBackColor = true;
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 605);
            this.Controls.Add(this.radioButtonStergere);
            this.Controls.Add(this.radioButtonDesenare);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Vizualizare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vizualizare";
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonDesenare;
        private System.Windows.Forms.RadioButton radioButtonStergere;
    }
}