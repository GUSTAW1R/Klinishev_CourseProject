namespace Klinishev_CourseProject_View
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonPriceList = new System.Windows.Forms.Button();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.buttonCompetitor = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(12, 96);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(219, 59);
            this.buttonRequest.TabIndex = 0;
            this.buttonRequest.Text = "Работа с заявками";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // buttonPriceList
            // 
            this.buttonPriceList.Location = new System.Drawing.Point(12, 223);
            this.buttonPriceList.Name = "buttonPriceList";
            this.buttonPriceList.Size = new System.Drawing.Size(219, 59);
            this.buttonPriceList.TabIndex = 1;
            this.buttonPriceList.Text = "Работа с прайс-листом";
            this.buttonPriceList.UseVisualStyleBackColor = true;
            this.buttonPriceList.Click += new System.EventHandler(this.buttonPriceList_Click);
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(549, 96);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(219, 59);
            this.buttonDeal.TabIndex = 2;
            this.buttonDeal.Text = "Работа с договорами";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.Location = new System.Drawing.Point(281, 96);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(219, 59);
            this.buttonCustomer.TabIndex = 3;
            this.buttonCustomer.Text = "Работа с заказчиками";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.buttonCustomer_Click);
            // 
            // buttonCompetitor
            // 
            this.buttonCompetitor.Location = new System.Drawing.Point(281, 223);
            this.buttonCompetitor.Name = "buttonCompetitor";
            this.buttonCompetitor.Size = new System.Drawing.Size(219, 59);
            this.buttonCompetitor.TabIndex = 4;
            this.buttonCompetitor.Text = "Работа с прайс-листами конкурентов";
            this.buttonCompetitor.UseVisualStyleBackColor = true;
            this.buttonCompetitor.Click += new System.EventHandler(this.buttonCompetitor_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(549, 223);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(219, 59);
            this.buttonReport.TabIndex = 5;
            this.buttonReport.Text = "Работа с отчётностью";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(507, 365);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "О программе";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(646, 365);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 13);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Автор";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonCompetitor);
            this.Controls.Add(this.buttonCustomer);
            this.Controls.Add(this.buttonDeal);
            this.Controls.Add(this.buttonPriceList);
            this.Controls.Add(this.buttonRequest);
            this.Name = "FormMain";
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonPriceList;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Button buttonCompetitor;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

