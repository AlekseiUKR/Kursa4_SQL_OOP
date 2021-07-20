namespace kursa4_Samsonova
{
    partial class MainMenu
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
            this.but_usr = new System.Windows.Forms.Button();
            this.but_cards = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_usr
            // 
            this.but_usr.Font = new System.Drawing.Font("Constantia", 20.25F);
            this.but_usr.Location = new System.Drawing.Point(12, 12);
            this.but_usr.Name = "but_usr";
            this.but_usr.Size = new System.Drawing.Size(287, 93);
            this.but_usr.TabIndex = 0;
            this.but_usr.Text = "Клиенты";
            this.but_usr.UseVisualStyleBackColor = true;
            // 
            // but_cards
            // 
            this.but_cards.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_cards.Location = new System.Drawing.Point(12, 131);
            this.but_cards.Name = "but_cards";
            this.but_cards.Size = new System.Drawing.Size(287, 93);
            this.but_cards.TabIndex = 1;
            this.but_cards.Text = "Карты";
            this.but_cards.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Загрузить в файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_cards);
            this.Controls.Add(this.but_usr);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_usr;
        private System.Windows.Forms.Button but_cards;
        private System.Windows.Forms.Button button1;
    }
}