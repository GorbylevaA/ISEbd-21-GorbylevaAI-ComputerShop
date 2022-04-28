namespace ComputerShopView
{
    partial class FormCreateOrder
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
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(195, 131);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(558, 40);
            this.comboBoxProduct.TabIndex = 0;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(195, 221);
            this.textBoxCount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(558, 39);
            this.textBoxCount.TabIndex = 1;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged_1);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(195, 317);
            this.textBoxSum.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(558, 39);
            this.textBoxSum.TabIndex = 2;
            this.textBoxSum.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Компьютер:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сумма:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(422, 379);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(161, 50);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(595, 379);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(161, 50);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(20, 53);
            this.labelClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(97, 32);
            this.labelClient.TabIndex = 9;
            this.labelClient.Text = "Клиент:";
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(195, 46);
            this.comboBoxClient.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(558, 40);
            this.comboBoxClient.TabIndex = 8;
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBoxProduct);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormCreateOrder";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxProduct;

        private System.Windows.Forms.TextBox textBoxCount;

        private System.Windows.Forms.TextBox textBoxSum;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button ButtonSave;

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBoxClient;
    }
}
