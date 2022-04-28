namespace ComputerShopView
{
    partial class FormComponent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxComponentName = new System.Windows.Forms.TextBox();
            this.buttonSaveComponent = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelComponentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxComponentName
            // 
            this.textBoxComponentName.Location = new System.Drawing.Point(100, 17);
            this.textBoxComponentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComponentName.Name = "textBoxComponentName";
            this.textBoxComponentName.Size = new System.Drawing.Size(257, 27);
            this.textBoxComponentName.TabIndex = 0;
            this.textBoxComponentName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonSaveComponent
            // 
            this.buttonSaveComponent.Location = new System.Drawing.Point(12, 57);
            this.buttonSaveComponent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveComponent.Name = "buttonSaveComponent";
            this.buttonSaveComponent.Size = new System.Drawing.Size(114, 31);
            this.buttonSaveComponent.TabIndex = 1;
            this.buttonSaveComponent.Text = "Сохранить";
            this.buttonSaveComponent.UseVisualStyleBackColor = true;
            this.buttonSaveComponent.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(239, 57);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 31);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelComponentName
            // 
            this.labelComponentName.AutoSize = true;
            this.labelComponentName.Location = new System.Drawing.Point(14, 21);
            this.labelComponentName.Name = "labelComponentName";
            this.labelComponentName.Size = new System.Drawing.Size(80, 20);
            this.labelComponentName.TabIndex = 3;
            this.labelComponentName.Text = "Название:";
            // 
            // FormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 101);
            this.Controls.Add(this.labelComponentName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSaveComponent);
            this.Controls.Add(this.textBoxComponentName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormComponent";
            this.Text = "Компонент";
            this.Load += new System.EventHandler(this.FormComponent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxComponentName;

        private System.Windows.Forms.Button buttonSaveComponent;

        private System.Windows.Forms.Button buttonCancel;

        private System.Windows.Forms.Label labelComponentName;
    }
}
