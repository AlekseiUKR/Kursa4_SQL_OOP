using System;

namespace kursa4_Samsonova
{
    partial class FormCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.textBox_money = new System.Windows.Forms.TextBox();
            this.textBox_history = new System.Windows.Forms.TextBox();
            this.textBox_balance_change = new System.Windows.Forms.TextBox();
            this.change_balance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::kursa4_Samsonova.Properties.Resources.card_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label_id";
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(332, 12);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(183, 20);
            this.textBox_number.TabIndex = 2;
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(280, 205);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(235, 48);
            this.but_save.TabIndex = 3;
            this.but_save.Text = "Сохрание";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 56);
            this.listBox1.TabIndex = 6;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Family:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Patronic:";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(284, 142);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(42, 13);
            this.money.TabIndex = 9;
            this.money.Text = "Money:";
            // 
            // textBox_money
            // 
            this.textBox_money.Location = new System.Drawing.Point(341, 139);
            this.textBox_money.Name = "textBox_money";
            this.textBox_money.Size = new System.Drawing.Size(99, 20);
            this.textBox_money.TabIndex = 10;
            // 
            // textBox_history
            // 
            this.textBox_history.Location = new System.Drawing.Point(550, 75);
            this.textBox_history.Multiline = true;
            this.textBox_history.Name = "textBox_history";
            this.textBox_history.Size = new System.Drawing.Size(270, 179);
            this.textBox_history.TabIndex = 11;
            // 
            // textBox_balance_change
            // 
            this.textBox_balance_change.Location = new System.Drawing.Point(550, 12);
            this.textBox_balance_change.Multiline = true;
            this.textBox_balance_change.Name = "textBox_balance_change";
            this.textBox_balance_change.Size = new System.Drawing.Size(119, 23);
            this.textBox_balance_change.TabIndex = 12;
            // 
            // change_balance
            // 
            this.change_balance.Location = new System.Drawing.Point(702, 12);
            this.change_balance.Name = "change_balance";
            this.change_balance.Size = new System.Drawing.Size(118, 23);
            this.change_balance.TabIndex = 13;
            this.change_balance.Text = "Изменить баланс";
            this.change_balance.UseVisualStyleBackColor = true;
            this.change_balance.Click += new System.EventHandler(this.change_balance_Click);
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 269);
            this.Controls.Add(this.change_balance);
            this.Controls.Add(this.textBox_balance_change);
            this.Controls.Add(this.textBox_history);
            this.Controls.Add(this.textBox_money);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCard";
            this.Text = "Card";
            this.Load += new System.EventHandler(this.FormCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox textBox_money;
        private System.Windows.Forms.TextBox textBox_history;
        private System.Windows.Forms.TextBox textBox_balance_change;
        private System.Windows.Forms.Button change_balance;
    }
}