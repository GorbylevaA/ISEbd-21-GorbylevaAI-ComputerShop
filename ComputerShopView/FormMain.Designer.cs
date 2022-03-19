
namespace ComputerShopView
{
    partial class FormMain
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
            this.ButtonCreateOrder = new System.Windows.Forms.Button();
            this.ButtonTakeOrderInWork = new System.Windows.Forms.Button();
            this.ButtonOrderReady = new System.Windows.Forms.Button();
            this.ButtonIssuedOrder = new System.Windows.Forms.Button();
            this.ButtonRef = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изделияToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCreateOrder
            // 
            this.ButtonCreateOrder.Location = new System.Drawing.Point(1289, 90);
            this.ButtonCreateOrder.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonCreateOrder.Name = "ButtonCreateOrder";
            this.ButtonCreateOrder.Size = new System.Drawing.Size(275, 83);
            this.ButtonCreateOrder.TabIndex = 0;
            this.ButtonCreateOrder.Text = "Создать заказ";
            this.ButtonCreateOrder.UseVisualStyleBackColor = true;
            this.ButtonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // ButtonTakeOrderInWork
            // 
            this.ButtonTakeOrderInWork.Location = new System.Drawing.Point(1289, 186);
            this.ButtonTakeOrderInWork.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonTakeOrderInWork.Name = "ButtonTakeOrderInWork";
            this.ButtonTakeOrderInWork.Size = new System.Drawing.Size(275, 83);
            this.ButtonTakeOrderInWork.TabIndex = 1;
            this.ButtonTakeOrderInWork.Text = "Отдать на выполнение";
            this.ButtonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.ButtonTakeOrderInWork.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
            // 
            // ButtonOrderReady
            // 
            this.ButtonOrderReady.Location = new System.Drawing.Point(1289, 282);
            this.ButtonOrderReady.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonOrderReady.Name = "ButtonOrderReady";
            this.ButtonOrderReady.Size = new System.Drawing.Size(275, 83);
            this.ButtonOrderReady.TabIndex = 2;
            this.ButtonOrderReady.Text = "Заказ готов";
            this.ButtonOrderReady.UseVisualStyleBackColor = true;
            this.ButtonOrderReady.Click += new System.EventHandler(this.ButtonOrderReady_Click);
            // 
            // ButtonIssuedOrder
            // 
            this.ButtonIssuedOrder.Location = new System.Drawing.Point(1289, 378);
            this.ButtonIssuedOrder.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonIssuedOrder.Name = "ButtonIssuedOrder";
            this.ButtonIssuedOrder.Size = new System.Drawing.Size(275, 83);
            this.ButtonIssuedOrder.TabIndex = 3;
            this.ButtonIssuedOrder.Text = "Заказ выдан";
            this.ButtonIssuedOrder.UseVisualStyleBackColor = true;
            this.ButtonIssuedOrder.Click += new System.EventHandler(this.ButtonIssuedOrder_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.Location = new System.Drawing.Point(1289, 474);
            this.ButtonRef.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonRef.Name = "ButtonRef";
            this.ButtonRef.Size = new System.Drawing.Size(275, 132);
            this.ButtonRef.TabIndex = 4;
            this.ButtonRef.Text = "Обновить список";
            this.ButtonRef.UseVisualStyleBackColor = true;
            this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 90);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1254, 979);
            this.dataGridView.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1586, 44);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 36);
            this.toolStripMenuItem1.Text = "Справочники";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // компонентыToolStripMenuItem
            // 
            this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
            this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(286, 44);
            this.компонентыToolStripMenuItem.Text = "компоненты";
            this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
            // 
            // изделияToolStripMenuItem2
            // 
            this.изделияToolStripMenuItem2.Name = "изделияToolStripMenuItem2";
            this.изделияToolStripMenuItem2.Size = new System.Drawing.Size(286, 44);
            this.изделияToolStripMenuItem2.Text = "изделия";
            this.изделияToolStripMenuItem2.Click += new System.EventHandler(this.изделияToolStripMenuItem2_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 1094);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonRef);
            this.Controls.Add(this.ButtonIssuedOrder);
            this.Controls.Add(this.ButtonOrderReady);
            this.Controls.Add(this.ButtonTakeOrderInWork);
            this.Controls.Add(this.ButtonCreateOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "Магазин компьютеров";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateOrder;
        private System.Windows.Forms.Button ButtonTakeOrderInWork;
        private System.Windows.Forms.Button ButtonOrderReady;
        private System.Windows.Forms.Button ButtonIssuedOrder;
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem2;
    }
}