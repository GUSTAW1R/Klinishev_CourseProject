namespace Klinishev_CourseProject_View
{
    partial class FormPriceList
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
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRef = new System.Windows.Forms.Button();
            this.maskedTextBoxPriceRef = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTypeRef = new System.Windows.Forms.TextBox();
            this.buttonAddRef = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(17, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(312, 332);
            this.dataGridView.TabIndex = 0;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(6, 34);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(171, 20);
            this.textBoxType.TabIndex = 1;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(8, 84);
            this.maskedTextBoxPrice.Mask = "0000";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxPrice.TabIndex = 2;
            this.maskedTextBoxPrice.ValidatingType = typeof(int);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(101, 73);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRef
            // 
            this.buttonRef.Location = new System.Drawing.Point(99, 71);
            this.buttonRef.Name = "buttonRef";
            this.buttonRef.Size = new System.Drawing.Size(75, 30);
            this.buttonRef.TabIndex = 6;
            this.buttonRef.Text = "Изменить";
            this.buttonRef.UseVisualStyleBackColor = true;
            this.buttonRef.Click += new System.EventHandler(this.buttonRef_Click);
            // 
            // maskedTextBoxPriceRef
            // 
            this.maskedTextBoxPriceRef.Location = new System.Drawing.Point(6, 82);
            this.maskedTextBoxPriceRef.Mask = "0000";
            this.maskedTextBoxPriceRef.Name = "maskedTextBoxPriceRef";
            this.maskedTextBoxPriceRef.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxPriceRef.TabIndex = 5;
            this.maskedTextBoxPriceRef.ValidatingType = typeof(int);
            // 
            // textBoxTypeRef
            // 
            this.textBoxTypeRef.Location = new System.Drawing.Point(6, 32);
            this.textBoxTypeRef.Name = "textBoxTypeRef";
            this.textBoxTypeRef.Size = new System.Drawing.Size(169, 20);
            this.textBoxTypeRef.TabIndex = 4;
            // 
            // buttonAddRef
            // 
            this.buttonAddRef.Location = new System.Drawing.Point(8, 112);
            this.buttonAddRef.Name = "buttonAddRef";
            this.buttonAddRef.Size = new System.Drawing.Size(164, 27);
            this.buttonAddRef.TabIndex = 7;
            this.buttonAddRef.Text = "Применить изменения";
            this.buttonAddRef.UseVisualStyleBackColor = true;
            this.buttonAddRef.Click += new System.EventHandler(this.buttonAddRef_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(363, 306);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(165, 38);
            this.buttonDel.TabIndex = 8;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Название продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Цена";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.maskedTextBoxPrice);
            this.groupBox1.Controls.Add(this.textBoxType);
            this.groupBox1.Location = new System.Drawing.Point(355, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 113);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление продукта";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonAddRef);
            this.groupBox2.Controls.Add(this.buttonRef);
            this.groupBox2.Controls.Add(this.maskedTextBoxPriceRef);
            this.groupBox2.Controls.Add(this.textBoxTypeRef);
            this.groupBox2.Location = new System.Drawing.Point(355, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 150);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Изменение продукта";
            // 
            // FormPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormPriceList";
            this.Text = "Работа с прайс-листом";
            this.Load += new System.EventHandler(this.FormPriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRef;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPriceRef;
        private System.Windows.Forms.TextBox textBoxTypeRef;
        private System.Windows.Forms.Button buttonAddRef;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}