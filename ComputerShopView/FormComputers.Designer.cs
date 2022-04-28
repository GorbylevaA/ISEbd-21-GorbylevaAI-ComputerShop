namespace ComputerShopView
{
    partial class FormComputers
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonEditComputer = new System.Windows.Forms.Button();
            this.buttonDeleteComputer = new System.Windows.Forms.Button();
            this.buttonRefreshComputers = new System.Windows.Forms.Button();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 18);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(700, 568);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonEditComputer
            // 
            this.buttonEditComputer.Location = new System.Drawing.Point(721, 67);
            this.buttonEditComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditComputer.Name = "buttonEditComputer";
            this.buttonEditComputer.Size = new System.Drawing.Size(180, 44);
            this.buttonEditComputer.TabIndex = 2;
            this.buttonEditComputer.Text = "Изменить";
            this.buttonEditComputer.UseVisualStyleBackColor = true;
            this.buttonEditComputer.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonDeleteComputer
            // 
            this.buttonDeleteComputer.Location = new System.Drawing.Point(722, 119);
            this.buttonDeleteComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteComputer.Name = "buttonDeleteComputer";
            this.buttonDeleteComputer.Size = new System.Drawing.Size(179, 36);
            this.buttonDeleteComputer.TabIndex = 3;
            this.buttonDeleteComputer.Text = "Удалить";
            this.buttonDeleteComputer.UseVisualStyleBackColor = true;
            this.buttonDeleteComputer.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonRefreshComputers
            // 
            this.buttonRefreshComputers.Location = new System.Drawing.Point(722, 163);
            this.buttonRefreshComputers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefreshComputers.Name = "buttonRefreshComputers";
            this.buttonRefreshComputers.Size = new System.Drawing.Size(179, 40);
            this.buttonRefreshComputers.TabIndex = 4;
            this.buttonRefreshComputers.Text = "Обновить";
            this.buttonRefreshComputers.UseVisualStyleBackColor = true;
            this.buttonRefreshComputers.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.Location = new System.Drawing.Point(721, 18);
            this.buttonAddComputer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(180, 41);
            this.buttonAddComputer.TabIndex = 5;
            this.buttonAddComputer.Text = "Добавить";
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormComputers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.buttonAddComputer);
            this.Controls.Add(this.buttonRefreshComputers);
            this.Controls.Add(this.buttonDeleteComputer);
            this.Controls.Add(this.buttonEditComputer);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComputers";
            this.Text = "Компьютеры";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.Button buttonEditComputer;

        private System.Windows.Forms.Button buttonDeleteComputer;

        private System.Windows.Forms.Button buttonRefreshComputers;

        private System.Windows.Forms.Button buttonAddComputer;
    }
}
