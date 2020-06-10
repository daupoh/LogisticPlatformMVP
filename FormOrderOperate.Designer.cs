namespace LogisticPlatformMVP
{
    partial class FormOrderOperate
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCityPanel = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.gbxOrdersPanel = new System.Windows.Forms.GroupBox();
            this.btnFindRoute = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.clbxOrders = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxCityPanel.SuspendLayout();
            this.gbxOrdersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCityPanel
            // 
            this.gbxCityPanel.Controls.Add(this.btnChange);
            this.gbxCityPanel.Controls.Add(this.tbxCity);
            this.gbxCityPanel.Location = new System.Drawing.Point(12, 12);
            this.gbxCityPanel.Name = "gbxCityPanel";
            this.gbxCityPanel.Size = new System.Drawing.Size(441, 56);
            this.gbxCityPanel.TabIndex = 0;
            this.gbxCityPanel.TabStop = false;
            this.gbxCityPanel.Text = "Выбор города";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(344, 19);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(91, 27);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Изменить";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(6, 19);
            this.tbxCity.Multiline = true;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.ReadOnly = true;
            this.tbxCity.Size = new System.Drawing.Size(313, 27);
            this.tbxCity.TabIndex = 0;
            this.tbxCity.Text = "Белгород Белгородская обл.\r\n";
            // 
            // gbxOrdersPanel
            // 
            this.gbxOrdersPanel.Controls.Add(this.btnFindRoute);
            this.gbxOrdersPanel.Controls.Add(this.btnDelete);
            this.gbxOrdersPanel.Controls.Add(this.btnEdit);
            this.gbxOrdersPanel.Controls.Add(this.clbxOrders);
            this.gbxOrdersPanel.Controls.Add(this.btnAdd);
            this.gbxOrdersPanel.Location = new System.Drawing.Point(12, 74);
            this.gbxOrdersPanel.Name = "gbxOrdersPanel";
            this.gbxOrdersPanel.Size = new System.Drawing.Size(441, 257);
            this.gbxOrdersPanel.TabIndex = 2;
            this.gbxOrdersPanel.TabStop = false;
            this.gbxOrdersPanel.Text = "Заказы";
            // 
            // btnFindRoute
            // 
            this.btnFindRoute.Location = new System.Drawing.Point(6, 209);
            this.btnFindRoute.Name = "btnFindRoute";
            this.btnFindRoute.Size = new System.Drawing.Size(161, 42);
            this.btnFindRoute.TabIndex = 6;
            this.btnFindRoute.Text = "Поиск оптимального маршрута";
            this.btnFindRoute.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(344, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(344, 52);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 27);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // clbxOrders
            // 
            this.clbxOrders.FormattingEnabled = true;
            this.clbxOrders.Items.AddRange(new object[] {
            "Олимпийская улица, 8, Белгородская область",
            "ул. Костюкова, 46, Белгородская обл.",
            "ул. Королева, 2а, 2, Белгородская обл.",
            "ул. Победы, 85, Белгородская обл.",
            "ул. Попова, 12, Белгород",
            "Театральный пр-д, 1, Белгородская обл.",
            "Богдана Хмельницкого просп., 137T, Белгородская обл."});
            this.clbxOrders.Location = new System.Drawing.Point(6, 19);
            this.clbxOrders.Name = "clbxOrders";
            this.clbxOrders.Size = new System.Drawing.Size(313, 184);
            this.clbxOrders.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(344, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FormOrderOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 344);
            this.Controls.Add(this.gbxOrdersPanel);
            this.Controls.Add(this.gbxCityPanel);
            this.Name = "FormOrderOperate";
            this.Text = "Оперирование заказами";
            this.gbxCityPanel.ResumeLayout(false);
            this.gbxCityPanel.PerformLayout();
            this.gbxOrdersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCityPanel;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.GroupBox gbxOrdersPanel;
        private System.Windows.Forms.Button btnFindRoute;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.CheckedListBox clbxOrders;
        private System.Windows.Forms.Button btnAdd;
    }
}

