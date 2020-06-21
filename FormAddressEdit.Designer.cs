namespace LogisticPlatformMVP
{
    partial class FormAddressEdit
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
            this.gbxSearchPanel = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.gbxFindedPanel = new System.Windows.Forms.GroupBox();
            this.lbxFinded = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbxSearchPanel.SuspendLayout();
            this.gbxFindedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearchPanel
            // 
            this.gbxSearchPanel.Controls.Add(this.btnSearch);
            this.gbxSearchPanel.Controls.Add(this.btnClear);
            this.gbxSearchPanel.Controls.Add(this.btnCancel);
            this.gbxSearchPanel.Controls.Add(this.tbxCity);
            this.gbxSearchPanel.Location = new System.Drawing.Point(12, 12);
            this.gbxSearchPanel.Name = "gbxSearchPanel";
            this.gbxSearchPanel.Size = new System.Drawing.Size(444, 99);
            this.gbxSearchPanel.TabIndex = 1;
            this.gbxSearchPanel.TabStop = false;
            this.gbxSearchPanel.Text = "Поиск";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 39);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 27);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 52);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Вернуться к оперированию";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(6, 19);
            this.tbxCity.Multiline = true;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(313, 27);
            this.tbxCity.TabIndex = 0;
            this.tbxCity.Text = "БГТУ";
            // 
            // gbxFindedPanel
            // 
            this.gbxFindedPanel.Controls.Add(this.lbxFinded);
            this.gbxFindedPanel.Controls.Add(this.btnSubmit);
            this.gbxFindedPanel.Location = new System.Drawing.Point(12, 117);
            this.gbxFindedPanel.Name = "gbxFindedPanel";
            this.gbxFindedPanel.Size = new System.Drawing.Size(444, 216);
            this.gbxFindedPanel.TabIndex = 3;
            this.gbxFindedPanel.TabStop = false;
            this.gbxFindedPanel.Text = "Найденные совпадения";
            // 
            // lbxFinded
            // 
            this.lbxFinded.FormattingEnabled = true;
            this.lbxFinded.Items.AddRange(new object[] {
            "ул. Костюкова, 44, Белгородская обл.",
            "ул. Костюкова, 46, Белгородская обл.",
            "ул. Губкина, 53, Белгородская обл.",
            "ул. Костюкова, 46к2, Белгородская обл.",
            "ул. Некрасова, 7, Белгородская обл."});
            this.lbxFinded.Location = new System.Drawing.Point(6, 19);
            this.lbxFinded.Name = "lbxFinded";
            this.lbxFinded.Size = new System.Drawing.Size(313, 186);
            this.lbxFinded.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(325, 178);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 27);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Выбрать";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // FormAddressEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 344);
            this.Controls.Add(this.gbxFindedPanel);
            this.Controls.Add(this.gbxSearchPanel);
            this.Name = "FormAddressEdit";
            this.Text = "Изменение адреса";
            this.gbxSearchPanel.ResumeLayout(false);
            this.gbxSearchPanel.PerformLayout();
            this.gbxFindedPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearchPanel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbxFindedPanel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ListBox lbxFinded;
    }
}