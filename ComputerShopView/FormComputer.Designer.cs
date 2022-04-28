namespace ComputerShopView
{
    partial class FormComputer
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelComputerPrice = new System.Windows.Forms.Label();
            this.textBoxComputerName = new System.Windows.Forms.TextBox();
            this.textBoxComputerPrice = new System.Windows.Forms.TextBox();
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.buttonRefreshComponents = new System.Windows.Forms.Button();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.buttonEditComponent = new System.Windows.Forms.Button();
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveComputer = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Location = new System.Drawing.Point(14, 28);
            this.labelComputerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(80, 20);
            this.labelComputerName.TabIndex = 0;
            this.labelComputerName.Text = "Название:";
            // 
            // labelComputerPrice
            // 
            this.labelComputerPrice.AutoSize = true;
            this.labelComputerPrice.Location = new System.Drawing.Point(15, 68);
            this.labelComputerPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerPrice.Name = "labelComputerPrice";
            this.labelComputerPrice.Size = new System.Drawing.Size(48, 20);
            this.labelComputerPrice.TabIndex = 1;
            this.labelComputerPrice.Text = "Цена:";
            // 
            // textBoxComputerName
            // 
            this.textBoxComputerName.Location = new System.Drawing.Point(102, 25);
            this.textBoxComputerName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComputerName.Name = "textBoxComputerName";
            this.textBoxComputerName.Size = new System.Drawing.Size(260, 27);
            this.textBoxComputerName.TabIndex = 2;
            // 
            // textBoxComputerPrice
            // 
            this.textBoxComputerPrice.Location = new System.Drawing.Point(102, 65);
            this.textBoxComputerPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComputerPrice.Name = "textBoxComputerPrice";
            this.textBoxComputerPrice.Size = new System.Drawing.Size(109, 27);
            this.textBoxComputerPrice.TabIndex = 3;
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.buttonRefreshComponents);
            this.groupBoxComponents.Controls.Add(this.buttonDeleteComponent);
            this.groupBoxComponents.Controls.Add(this.buttonEditComponent);
            this.groupBoxComponents.Controls.Add(this.buttonAddComponent);
            this.groupBoxComponents.Controls.Add(this.dataGridView);
            this.groupBoxComponents.Location = new System.Drawing.Point(14, 113);
            this.groupBoxComponents.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxComponents.Size = new System.Drawing.Size(682, 414);
            this.groupBoxComponents.TabIndex = 4;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "Компоненты";
            // 
            // buttonRefreshComponents
            // 
            this.buttonRefreshComponents.Location = new System.Drawing.Point(490, 189);
            this.buttonRefreshComponents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshComponents.Name = "buttonRefreshComponents";
            this.buttonRefreshComponents.Size = new System.Drawing.Size(176, 39);
            this.buttonRefreshComponents.TabIndex = 4;
            this.buttonRefreshComponents.Text = "Обновить";
            this.buttonRefreshComponents.UseVisualStyleBackColor = true;
            this.buttonRefreshComponents.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.Location = new System.Drawing.Point(490, 143);
            this.buttonDeleteComponent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(176, 39);
            this.buttonDeleteComponent.TabIndex = 3;
            this.buttonDeleteComponent.Text = "Удалить";
            this.buttonDeleteComponent.UseVisualStyleBackColor = true;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonEditComponent
            // 
            this.buttonEditComponent.Location = new System.Drawing.Point(490, 96);
            this.buttonEditComponent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditComponent.Name = "buttonEditComponent";
            this.buttonEditComponent.Size = new System.Drawing.Size(176, 39);
            this.buttonEditComponent.TabIndex = 2;
            this.buttonEditComponent.Text = "Изменить";
            this.buttonEditComponent.UseVisualStyleBackColor = true;
            this.buttonEditComponent.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(490, 50);
            this.buttonAddComponent.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(176, 39);
            this.buttonAddComponent.TabIndex = 1;
            this.buttonAddComponent.Text = "Добавить";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(14, 29);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(471, 378);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Компонент";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Количество";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // buttonSaveComputer
            // 
            this.buttonSaveComputer.Location = new System.Drawing.Point(504, 19);
            this.buttonSaveComputer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveComputer.Name = "buttonSaveComputer";
            this.buttonSaveComputer.Size = new System.Drawing.Size(176, 39);
            this.buttonSaveComputer.TabIndex = 7;
            this.buttonSaveComputer.Text = "Сохранить";
            this.buttonSaveComputer.UseVisualStyleBackColor = true;
            this.buttonSaveComputer.Click += new System.EventHandler(this.buttonSaveComputer_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(504, 68);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(176, 39);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // FormComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 584);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveComputer);
            this.Controls.Add(this.groupBoxComponents);
            this.Controls.Add(this.textBoxComputerPrice);
            this.Controls.Add(this.textBoxComputerName);
            this.Controls.Add(this.labelComputerPrice);
            this.Controls.Add(this.labelComputerName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormComputer";
            this.Text = "Компьютер";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.groupBoxComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelComputerName;

        private System.Windows.Forms.Label labelComputerPrice;

        private System.Windows.Forms.TextBox textBoxComputerName;

        private System.Windows.Forms.TextBox textBoxComputerPrice;

        private System.Windows.Forms.GroupBox groupBoxComponents;

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Button buttonRefreshComponents;

        private System.Windows.Forms.Button buttonDeleteComponent;

        private System.Windows.Forms.Button buttonEditComponent;

        private System.Windows.Forms.Button buttonAddComponent;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button buttonSaveComputer;
        private System.Windows.Forms.Button buttonCancel;
    }
}
