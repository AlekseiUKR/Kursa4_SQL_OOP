namespace kursa4_Samsonova
{
    partial class DBusers
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
            this.usergrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del_user = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usergrid
            // 
            this.usergrid.AllowUserToAddRows = false;
            this.usergrid.AllowUserToDeleteRows = false;
            this.usergrid.AllowUserToOrderColumns = true;
            this.usergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usergrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.family,
            this.patronymic,
            this.btn_del_user});
            this.usergrid.Location = new System.Drawing.Point(12, 12);
            this.usergrid.Name = "usergrid";
            this.usergrid.Size = new System.Drawing.Size(490, 236);
            this.usergrid.TabIndex = 4;
            this.usergrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usergrid_CellClick_1);
            this.usergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usergrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "DebugInfo";
            // 
            // btn_addUser
            // 
            this.btn_addUser.Location = new System.Drawing.Point(427, 254);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(75, 23);
            this.btn_addUser.TabIndex = 7;
            this.btn_addUser.Text = "Добавить";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(337, 254);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 8;
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            // 
            // family
            // 
            this.family.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.family.HeaderText = "Фамилия";
            this.family.Name = "family";
            // 
            // patronymic
            // 
            this.patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            // 
            // btn_del_user
            // 
            this.btn_del_user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btn_del_user.HeaderText = "Изменить";
            this.btn_del_user.Name = "btn_del_user";
            this.btn_del_user.Text = "Изменить";
            // 
            // DBusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 284);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usergrid);
            this.Name = "DBusers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.DBusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView usergrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn family;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewButtonColumn btn_del_user;
    }
}