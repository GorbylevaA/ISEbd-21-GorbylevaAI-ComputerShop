namespace ComputerShopView
{
    partial class FormComponents
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
            this.buttonAddComponent = new System.Windows.Forms.Button();
            this.buttonEditComponent = new System.Windows.Forms.Button();
            this.buttonDeleteComponent = new System.Windows.Forms.Button();
            this.buttonRefreshComponent = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddComponent
            // 
            this.buttonAddComponent.Location = new System.Drawing.Point(516, 16);
            this.buttonAddComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddComponent.Name = "buttonAddComponent";
            this.buttonAddComponent.Size = new System.Drawing.Size(155, 40);
            this.buttonAddComponent.TabIndex = 0;
            this.buttonAddComponent.Text = "Добавить";
            this.buttonAddComponent.UseVisualStyleBackColor = true;
            this.buttonAddComponent.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonEditComponent
            // 
            this.buttonEditComponent.Location = new System.Drawing.Point(516, 64);
            this.buttonEditComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditComponent.Name = "buttonEditComponent";
            this.buttonEditComponent.Size = new System.Drawing.Size(155, 41);
            this.buttonEditComponent.TabIndex = 1;
            this.buttonEditComponent.Text = "Изменить";
            this.buttonEditComponent.UseVisualStyleBackColor = true;
            this.buttonEditComponent.Click += new System.EventHandler(this.ButtonUpd_Click);
            // 
            // buttonDeleteComponent
            // 
            this.buttonDeleteComponent.Location = new System.Drawing.Point(516, 113);
            this.buttonDeleteComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteComponent.Name = "buttonDeleteComponent";
            this.buttonDeleteComponent.Size = new System.Drawing.Size(155, 43);
            this.buttonDeleteComponent.TabIndex = 2;
            this.buttonDeleteComponent.Text = "Удалить";
            this.buttonDeleteComponent.UseVisualStyleBackColor = true;
            this.buttonDeleteComponent.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // buttonRefreshComponent
            // 
            this.buttonRefreshComponent.Location = new System.Drawing.Point(516, 164);
            this.buttonRefreshComponent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefreshComponent.Name = "buttonRefreshComponent";
            this.buttonRefreshComponent.Size = new System.Drawing.Size(155, 39);
            this.buttonRefreshComponent.TabIndex = 3;
            this.buttonRefreshComponent.Text = "Обновить";
            this.buttonRefreshComponent.UseVisualStyleBackColor = true;
            this.buttonRefreshComponent.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(14, 16);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(494, 469);
            this.dataGridView.TabIndex = 4;
            // 
            // FormComponents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 493);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonRefreshComponent);
            this.Controls.Add(this.buttonDeleteComponent);
            this.Controls.Add(this.buttonEditComponent);
            this.Controls.Add(this.buttonAddComponent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComponents";
            this.Text = "Компоненты";
            this.Load += new System.EventHandler(this.FormComponents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button buttonAddComponent;

        private System.Windows.Forms.Button buttonEditComponent;

        private System.Windows.Forms.Button buttonDeleteComponent;

        private System.Windows.Forms.Button buttonRefreshComponent;

        private System.Windows.Forms.DataGridView dataGridView;
    }
}
