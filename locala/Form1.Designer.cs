
namespace locala
{
    partial class Autentificare
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxParola = new System.Windows.Forms.TextBox();
            this.butonLogare = new System.Windows.Forms.Button();
            this.butonInregistrare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ai venit !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(33, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(52, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parola";
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textboxUsername.Location = new System.Drawing.Point(189, 201);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(201, 38);
            this.textboxUsername.TabIndex = 3;
            // 
            // textboxParola
            // 
            this.textboxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textboxParola.Location = new System.Drawing.Point(189, 275);
            this.textboxParola.Name = "textboxParola";
            this.textboxParola.PasswordChar = '*';
            this.textboxParola.Size = new System.Drawing.Size(201, 38);
            this.textboxParola.TabIndex = 4;
            // 
            // butonLogare
            // 
            this.butonLogare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butonLogare.Location = new System.Drawing.Point(229, 376);
            this.butonLogare.Name = "butonLogare";
            this.butonLogare.Size = new System.Drawing.Size(138, 40);
            this.butonLogare.TabIndex = 5;
            this.butonLogare.Text = "Logare";
            this.butonLogare.UseVisualStyleBackColor = true;
            this.butonLogare.Click += new System.EventHandler(this.butonLogare_Click);
            // 
            // butonInregistrare
            // 
            this.butonInregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butonInregistrare.Location = new System.Drawing.Point(54, 376);
            this.butonInregistrare.Name = "butonInregistrare";
            this.butonInregistrare.Size = new System.Drawing.Size(133, 40);
            this.butonInregistrare.TabIndex = 6;
            this.butonInregistrare.Text = "Cont nou";
            this.butonInregistrare.UseVisualStyleBackColor = true;
            this.butonInregistrare.Click += new System.EventHandler(this.butonInregistrare_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 459);
            this.Controls.Add(this.butonInregistrare);
            this.Controls.Add(this.butonLogare);
            this.Controls.Add(this.textboxParola);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autentificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxParola;
        private System.Windows.Forms.Button butonLogare;
        private System.Windows.Forms.Button butonInregistrare;
    }
}

