namespace Klinishev_CourseProject_View
{
    partial class FormAddRequest
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCount = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(84, 14);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(176, 21);
            this.comboBoxCustomer.TabIndex = 2;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(84, 54);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(177, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // maskedTextBoxCount
            // 
            this.maskedTextBoxCount.Location = new System.Drawing.Point(88, 99);
            this.maskedTextBoxCount.Mask = "000";
            this.maskedTextBoxCount.Name = "maskedTextBoxCount";
            this.maskedTextBoxCount.Size = new System.Drawing.Size(171, 20);
            this.maskedTextBoxCount.TabIndex = 4;
            this.maskedTextBoxCount.ValidatingType = typeof(int);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(26, 183);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 34);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormAddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.maskedTextBoxCount);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FormAddRequest";
            this.Text = "Добавление заявки";
            this.Load += new System.EventHandler(this.FormAddRequest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCount;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
    }
}