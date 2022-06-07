
namespace ComputerShopView
{
    partial class FormImplementers
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAddImplementer = new System.Windows.Forms.Button();
            this.buttonEditImplementer = new System.Windows.Forms.Button();
            this.buttonDeleteImplementer = new System.Windows.Forms.Button();
            this.buttonUpdateImplementer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(604, 308);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonAddImplementer
            // 
            this.buttonAddImplementer.Location = new System.Drawing.Point(622, 12);
            this.buttonAddImplementer.Name = "buttonAddImplementer";
            this.buttonAddImplementer.Size = new System.Drawing.Size(134, 45);
            this.buttonAddImplementer.TabIndex = 1;
            this.buttonAddImplementer.Text = "Добавить";
            this.buttonAddImplementer.UseVisualStyleBackColor = true;
            this.buttonAddImplementer.Click += new System.EventHandler(this.buttonAddImplementer_Click);
            // 
            // buttonEditImplementer
            // 
            this.buttonEditImplementer.Location = new System.Drawing.Point(622, 63);
            this.buttonEditImplementer.Name = "buttonEditImplementer";
            this.buttonEditImplementer.Size = new System.Drawing.Size(134, 45);
            this.buttonEditImplementer.TabIndex = 2;
            this.buttonEditImplementer.Text = "Изменить";
            this.buttonEditImplementer.UseVisualStyleBackColor = true;
            this.buttonEditImplementer.Click += new System.EventHandler(this.buttonEditImplementer_Click);
            // 
            // buttonDeleteImplementer
            // 
            this.buttonDeleteImplementer.Location = new System.Drawing.Point(622, 114);
            this.buttonDeleteImplementer.Name = "buttonDeleteImplementer";
            this.buttonDeleteImplementer.Size = new System.Drawing.Size(134, 45);
            this.buttonDeleteImplementer.TabIndex = 3;
            this.buttonDeleteImplementer.Text = "Удалить";
            this.buttonDeleteImplementer.UseVisualStyleBackColor = true;
            this.buttonDeleteImplementer.Click += new System.EventHandler(this.buttonDeleteImplementer_Click);
            // 
            // buttonUpdateImplementer
            // 
            this.buttonUpdateImplementer.Location = new System.Drawing.Point(622, 165);
            this.buttonUpdateImplementer.Name = "buttonUpdateImplementer";
            this.buttonUpdateImplementer.Size = new System.Drawing.Size(134, 45);
            this.buttonUpdateImplementer.TabIndex = 4;
            this.buttonUpdateImplementer.Text = "Обновить";
            this.buttonUpdateImplementer.UseVisualStyleBackColor = true;
            this.buttonUpdateImplementer.Click += new System.EventHandler(this.buttonUpdateImplementer_Click);
            // 
            // FormImplementers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 338);
            this.Controls.Add(this.buttonUpdateImplementer);
            this.Controls.Add(this.buttonDeleteImplementer);
            this.Controls.Add(this.buttonEditImplementer);
            this.Controls.Add(this.buttonAddImplementer);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormImplementers";
            this.Text = "Исполнители";
            this.Load += new System.EventHandler(this.FormImplementers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAddImplementer;
        private System.Windows.Forms.Button buttonEditImplementer;
        private System.Windows.Forms.Button buttonDeleteImplementer;
        private System.Windows.Forms.Button buttonUpdateImplementer;
    }
}