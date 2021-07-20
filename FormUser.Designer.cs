namespace kursa4_Samsonova
{
    partial class FormUser
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
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.textBox_family = new System.Windows.Forms.TextBox();
            this.cardgrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::kursa4_Samsonova.Properties.Resources.prof_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(148, 9);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 13);
            this.label_id.TabIndex = 1;
            this.label_id.Text = "ID: ";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(148, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Location = new System.Drawing.Point(149, 68);
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(100, 20);
            this.textBox_patronymic.TabIndex = 2;
            // 
            // textBox_family
            // 
            this.textBox_family.Location = new System.Drawing.Point(149, 111);
            this.textBox_family.Name = "textBox_family";
            this.textBox_family.Size = new System.Drawing.Size(100, 20);
            this.textBox_family.TabIndex = 2;
            // 
            // cardgrid
            // 
            this.cardgrid.AllowUserToAddRows = false;
            this.cardgrid.AllowUserToDeleteRows = false;
            this.cardgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.number,
            this.money});
            this.cardgrid.Location = new System.Drawing.Point(12, 148);
            this.cardgrid.Name = "cardgrid";
            this.cardgrid.Size = new System.Drawing.Size(443, 145);
            this.cardgrid.TabIndex = 3;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.HeaderText = "number";
            this.number.Name = "number";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(349, 101);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 38);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(386, 10);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(66, 38);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Visible = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // money
            // 
            this.money.HeaderText = "Деньги";
            this.money.Name = "money";
            // 
            // FormUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(464, 301);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cardgrid);
            this.Controls.Add(this.textBox_family);
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormUser";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.TextBox textBox_family;
        private System.Windows.Forms.DataGridView cardgrid;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
    }
}