namespace RadSaViseFormiGabrielMatosevic27092021
{
    partial class Studenti
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
            this.DodajNovogStudentaButton = new System.Windows.Forms.Button();
            this.ObrisiStudentaButton = new System.Windows.Forms.Button();
            this.ObrisiSveStudenteButton = new System.Windows.Forms.Button();
            this.StudentiListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DodajNovogStudentaButton
            // 
            this.DodajNovogStudentaButton.Location = new System.Drawing.Point(99, 79);
            this.DodajNovogStudentaButton.Name = "DodajNovogStudentaButton";
            this.DodajNovogStudentaButton.Size = new System.Drawing.Size(130, 23);
            this.DodajNovogStudentaButton.TabIndex = 0;
            this.DodajNovogStudentaButton.Text = "Dodaj novog studenta";
            this.DodajNovogStudentaButton.UseVisualStyleBackColor = true;
            this.DodajNovogStudentaButton.Click += new System.EventHandler(this.DodajNovogStudentaButton_Click);
            // 
            // ObrisiStudentaButton
            // 
            this.ObrisiStudentaButton.Location = new System.Drawing.Point(453, 217);
            this.ObrisiStudentaButton.Name = "ObrisiStudentaButton";
            this.ObrisiStudentaButton.Size = new System.Drawing.Size(100, 23);
            this.ObrisiStudentaButton.TabIndex = 1;
            this.ObrisiStudentaButton.Text = "Obrisi  studenta";
            this.ObrisiStudentaButton.UseVisualStyleBackColor = true;
            // 
            // ObrisiSveStudenteButton
            // 
            this.ObrisiSveStudenteButton.Location = new System.Drawing.Point(99, 352);
            this.ObrisiSveStudenteButton.Name = "ObrisiSveStudenteButton";
            this.ObrisiSveStudenteButton.Size = new System.Drawing.Size(130, 23);
            this.ObrisiSveStudenteButton.TabIndex = 2;
            this.ObrisiSveStudenteButton.Text = "Obrisi sve studente";
            this.ObrisiSveStudenteButton.UseVisualStyleBackColor = true;
            this.ObrisiSveStudenteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentiListBox
            // 
            this.StudentiListBox.FormattingEnabled = true;
            this.StudentiListBox.Location = new System.Drawing.Point(99, 108);
            this.StudentiListBox.Name = "StudentiListBox";
            this.StudentiListBox.Size = new System.Drawing.Size(348, 238);
            this.StudentiListBox.TabIndex = 3;
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StudentiListBox);
            this.Controls.Add(this.ObrisiSveStudenteButton);
            this.Controls.Add(this.ObrisiStudentaButton);
            this.Controls.Add(this.DodajNovogStudentaButton);
            this.Name = "Studenti";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DodajNovogStudentaButton;
        private System.Windows.Forms.Button ObrisiStudentaButton;
        private System.Windows.Forms.Button ObrisiSveStudenteButton;
        private System.Windows.Forms.ListBox StudentiListBox;
    }
}

