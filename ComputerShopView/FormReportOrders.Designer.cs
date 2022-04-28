
namespace ComputerShopView
{
    partial class FormReportOrders
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.buttonForm = new System.Windows.Forms.Button();
            this.buttonFormPdf = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(41, 12);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(203, 27);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(17, 14);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(18, 20);
            this.labelFrom.TabIndex = 1;
            this.labelFrom.Text = "С";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(250, 14);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(27, 20);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "по";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(283, 12);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(203, 27);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // buttonForm
            // 
            this.buttonForm.Location = new System.Drawing.Point(501, 11);
            this.buttonForm.Name = "buttonForm";
            this.buttonForm.Size = new System.Drawing.Size(130, 33);
            this.buttonForm.TabIndex = 4;
            this.buttonForm.Text = "Сформировать";
            this.buttonForm.UseVisualStyleBackColor = true;
            this.buttonForm.Click += new System.EventHandler(this.buttonForm_Click);
            // 
            // buttonFormPdf
            // 
            this.buttonFormPdf.Location = new System.Drawing.Point(646, 12);
            this.buttonFormPdf.Name = "buttonFormPdf";
            this.buttonFormPdf.Size = new System.Drawing.Size(130, 33);
            this.buttonFormPdf.TabIndex = 5;
            this.buttonFormPdf.Text = "В PDF";
            this.buttonFormPdf.UseVisualStyleBackColor = true;
            this.buttonFormPdf.Click += new System.EventHandler(this.buttonFormPdf_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonFormPdf);
            this.panel.Controls.Add(this.dateTimePickerFrom);
            this.panel.Controls.Add(this.buttonForm);
            this.panel.Controls.Add(this.labelFrom);
            this.panel.Controls.Add(this.dateTimePickerTo);
            this.panel.Controls.Add(this.labelTo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(788, 50);
            this.panel.TabIndex = 6;
            // 
            // FormReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.panel);
            this.Name = "FormReportOrders";
            this.Text = "Заказы";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Button buttonForm;
        private System.Windows.Forms.Button buttonFormPdf;
        private System.Windows.Forms.Panel panel;
    }
}