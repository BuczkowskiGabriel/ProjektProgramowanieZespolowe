
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewUserLabel = new System.Windows.Forms.Label();
            this.NewUserBox = new System.Windows.Forms.TextBox();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogsTextBox = new System.Windows.Forms.TextBox();
            this.ClearTextButton = new System.Windows.Forms.Button();
            this.LoadTextButton = new System.Windows.Forms.Button();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewUserLabel
            // 
            this.NewUserLabel.AutoSize = true;
            this.NewUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewUserLabel.Location = new System.Drawing.Point(12, 23);
            this.NewUserLabel.Name = "NewUserLabel";
            this.NewUserLabel.Size = new System.Drawing.Size(301, 26);
            this.NewUserLabel.TabIndex = 0;
            this.NewUserLabel.Text = "Dodaj Nowego Uprawnionego";
            this.NewUserLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewUserBox
            // 
            this.NewUserBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NewUserBox.Location = new System.Drawing.Point(17, 67);
            this.NewUserBox.Name = "NewUserBox";
            this.NewUserBox.Size = new System.Drawing.Size(142, 26);
            this.NewUserBox.TabIndex = 1;
            this.NewUserBox.TextChanged += new System.EventHandler(this.NewUserBox_TextChanged);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(179, 67);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(134, 23);
            this.NewUserButton.TabIndex = 2;
            this.NewUserButton.Text = "Dodaj";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(525, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logowania";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogsTextBox
            // 
            this.LogsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogsTextBox.Location = new System.Drawing.Point(378, 69);
            this.LogsTextBox.Multiline = true;
            this.LogsTextBox.Name = "LogsTextBox";
            this.LogsTextBox.ReadOnly = true;
            this.LogsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTextBox.Size = new System.Drawing.Size(410, 291);
            this.LogsTextBox.TabIndex = 4;
            this.LogsTextBox.TextChanged += new System.EventHandler(this.LogsTextBox_TextChanged);
            // 
            // ClearTextButton
            // 
            this.ClearTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearTextButton.Location = new System.Drawing.Point(583, 366);
            this.ClearTextButton.Name = "ClearTextButton";
            this.ClearTextButton.Size = new System.Drawing.Size(205, 49);
            this.ClearTextButton.TabIndex = 5;
            this.ClearTextButton.Text = "Wyczyść okno";
            this.ClearTextButton.UseVisualStyleBackColor = true;
            this.ClearTextButton.Click += new System.EventHandler(this.ClearTextButton_Click);
            // 
            // LoadTextButton
            // 
            this.LoadTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoadTextButton.Location = new System.Drawing.Point(378, 367);
            this.LoadTextButton.Name = "LoadTextButton";
            this.LoadTextButton.Size = new System.Drawing.Size(199, 48);
            this.LoadTextButton.TabIndex = 6;
            this.LoadTextButton.Text = "Załaduj Dane";
            this.LoadTextButton.UseVisualStyleBackColor = true;
            this.LoadTextButton.Click += new System.EventHandler(this.LoadTextButton_Click);
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTextBox.Location = new System.Drawing.Point(195, 375);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(164, 30);
            this.DateTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(221, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Podaj Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.LoadTextButton);
            this.Controls.Add(this.ClearTextButton);
            this.Controls.Add(this.LogsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.NewUserBox);
            this.Controls.Add(this.NewUserLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewUserLabel;
        private System.Windows.Forms.TextBox NewUserBox;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogsTextBox;
        private System.Windows.Forms.Button ClearTextButton;
        private System.Windows.Forms.Button LoadTextButton;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Label label2;
    }
}

