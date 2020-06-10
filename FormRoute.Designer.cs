namespace LogisticPlatformMVP
{
    partial class FormRoute
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
            this.gbxRoute = new System.Windows.Forms.GroupBox();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntervalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNext = new System.Windows.Forms.Button();
            this.gbxQuickRoutePanel = new System.Windows.Forms.GroupBox();
            this.dgvQuickRoute = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.gbxQuickRoutePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuickRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxRoute
            // 
            this.gbxRoute.Controls.Add(this.dgvRoute);
            this.gbxRoute.Location = new System.Drawing.Point(12, 12);
            this.gbxRoute.Name = "gbxRoute";
            this.gbxRoute.Size = new System.Drawing.Size(625, 259);
            this.gbxRoute.TabIndex = 0;
            this.gbxRoute.TabStop = false;
            this.gbxRoute.Text = "Маршрут с выбором эффективного пути";
            // 
            // dgvRoute
            // 
            this.dgvRoute.AllowUserToAddRows = false;
            this.dgvRoute.AllowUserToDeleteRows = false;
            this.dgvRoute.AllowUserToResizeColumns = false;
            this.dgvRoute.AllowUserToResizeRows = false;
            this.dgvRoute.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRoute.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvRoute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.IntervalTime,
            this.TotalTime,
            this.ExpectedTime});
            this.dgvRoute.Location = new System.Drawing.Point(6, 19);
            this.dgvRoute.MultiSelect = false;
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.ReadOnly = true;
            this.dgvRoute.RowHeadersVisible = false;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.Size = new System.Drawing.Size(601, 226);
            this.dgvRoute.TabIndex = 0;
            this.dgvRoute.TabStop = false;
            this.dgvRoute.SelectionChanged += new System.EventHandler(this.DgvRoute_SelectionChanged);
            // 
            // Address
            // 
            this.Address.Frozen = true;
            this.Address.HeaderText = "Адрес заказа";
            this.Address.MinimumWidth = 25;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Address.Width = 150;
            // 
            // IntervalTime
            // 
            this.IntervalTime.Frozen = true;
            this.IntervalTime.HeaderText = "Время пути с предыдущей точки до текущей";
            this.IntervalTime.Name = "IntervalTime";
            this.IntervalTime.ReadOnly = true;
            this.IntervalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IntervalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IntervalTime.Width = 150;
            // 
            // TotalTime
            // 
            this.TotalTime.Frozen = true;
            this.TotalTime.HeaderText = "Общее время маршрута";
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.ReadOnly = true;
            this.TotalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TotalTime.Width = 150;
            // 
            // ExpectedTime
            // 
            this.ExpectedTime.Frozen = true;
            this.ExpectedTime.HeaderText = "Ожидаемое время до доставки";
            this.ExpectedTime.Name = "ExpectedTime";
            this.ExpectedTime.ReadOnly = true;
            this.ExpectedTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpectedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExpectedTime.Width = 150;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(497, 193);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 32);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Прибыл!";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // gbxQuickRoutePanel
            // 
            this.gbxQuickRoutePanel.Controls.Add(this.btnNext);
            this.gbxQuickRoutePanel.Controls.Add(this.dgvQuickRoute);
            this.gbxQuickRoutePanel.Location = new System.Drawing.Point(12, 277);
            this.gbxQuickRoutePanel.Name = "gbxQuickRoutePanel";
            this.gbxQuickRoutePanel.Size = new System.Drawing.Size(625, 259);
            this.gbxQuickRoutePanel.TabIndex = 3;
            this.gbxQuickRoutePanel.TabStop = false;
            this.gbxQuickRoutePanel.Text = "Маршрут с выбором кратчайшего пути";
            // 
            // dgvQuickRoute
            // 
            this.dgvQuickRoute.AllowUserToAddRows = false;
            this.dgvQuickRoute.AllowUserToDeleteRows = false;
            this.dgvQuickRoute.AllowUserToResizeColumns = false;
            this.dgvQuickRoute.AllowUserToResizeRows = false;
            this.dgvQuickRoute.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvQuickRoute.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvQuickRoute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvQuickRoute.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvQuickRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuickRoute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvQuickRoute.Location = new System.Drawing.Point(6, 19);
            this.dgvQuickRoute.MultiSelect = false;
            this.dgvQuickRoute.Name = "dgvQuickRoute";
            this.dgvQuickRoute.ReadOnly = true;
            this.dgvQuickRoute.RowHeadersVisible = false;
            this.dgvQuickRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuickRoute.Size = new System.Drawing.Size(601, 226);
            this.dgvQuickRoute.TabIndex = 0;
            this.dgvQuickRoute.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Адрес заказа";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 25;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Время пути с предыдущей точки до текущей";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Общее время маршрута";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ожидаемое время до доставки";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 546);
            this.Controls.Add(this.gbxQuickRoutePanel);
            this.Controls.Add(this.gbxRoute);
            this.Name = "FormRoute";
            this.Text = "Маршрут";
            this.gbxRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.gbxQuickRoutePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuickRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRoute;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedTime;
        private System.Windows.Forms.GroupBox gbxQuickRoutePanel;
        private System.Windows.Forms.DataGridView dgvQuickRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}