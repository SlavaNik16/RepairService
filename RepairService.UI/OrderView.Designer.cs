namespace RepairService.UI
{
    partial class OrderView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPrioritet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelBrokenType = new System.Windows.Forms.Label();
            this.labelEqipmentsType = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEquippmentsTitle = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьСостоянияРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(283, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelId.Location = new System.Drawing.Point(406, 43);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 35);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Приоритет";
            // 
            // labelPrioritet
            // 
            this.labelPrioritet.AutoSize = true;
            this.labelPrioritet.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelPrioritet.Location = new System.Drawing.Point(76, 43);
            this.labelPrioritet.Name = "labelPrioritet";
            this.labelPrioritet.Size = new System.Drawing.Size(33, 35);
            this.labelPrioritet.TabIndex = 3;
            this.labelPrioritet.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(603, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Статус";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelStatus.Location = new System.Drawing.Point(647, 43);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(33, 35);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(9, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(810, 103);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Тип неисправности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(512, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип оборудования";
            // 
            // labelBrokenType
            // 
            this.labelBrokenType.AutoSize = true;
            this.labelBrokenType.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelBrokenType.Location = new System.Drawing.Point(6, 323);
            this.labelBrokenType.Name = "labelBrokenType";
            this.labelBrokenType.Size = new System.Drawing.Size(68, 35);
            this.labelBrokenType.TabIndex = 9;
            this.labelBrokenType.Text = "Тип";
            // 
            // labelEqipmentsType
            // 
            this.labelEqipmentsType.AutoSize = true;
            this.labelEqipmentsType.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelEqipmentsType.Location = new System.Drawing.Point(512, 323);
            this.labelEqipmentsType.Name = "labelEqipmentsType";
            this.labelEqipmentsType.Size = new System.Drawing.Size(68, 35);
            this.labelEqipmentsType.TabIndex = 10;
            this.labelEqipmentsType.Text = "Тип";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F);
            this.buttonEdit.Location = new System.Drawing.Point(10, 385);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(269, 64);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(550, 385);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(269, 64);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(3, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 35);
            this.label6.TabIndex = 13;
            this.label6.Text = "Названия оборудования";
            // 
            // labelEquippmentsTitle
            // 
            this.labelEquippmentsTitle.AutoSize = true;
            this.labelEquippmentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.labelEquippmentsTitle.Location = new System.Drawing.Point(380, 95);
            this.labelEquippmentsTitle.Name = "labelEquippmentsTitle";
            this.labelEquippmentsTitle.Size = new System.Drawing.Size(371, 35);
            this.labelEquippmentsTitle.TabIndex = 14;
            this.labelEquippmentsTitle.Text = "Названия оборудования";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьСостоянияРаботыToolStripMenuItem,
            this.добавитьВОтчетToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(266, 68);
            // 
            // изменитьСостоянияРаботыToolStripMenuItem
            // 
            this.изменитьСостоянияРаботыToolStripMenuItem.Name = "изменитьСостоянияРаботыToolStripMenuItem";
            this.изменитьСостоянияРаботыToolStripMenuItem.Size = new System.Drawing.Size(265, 32);
            this.изменитьСостоянияРаботыToolStripMenuItem.Text = "Добавить работников";
            this.изменитьСостоянияРаботыToolStripMenuItem.Click += new System.EventHandler(this.изменитьСостоянияРаботыToolStripMenuItem_Click);
            // 
            // добавитьВОтчетToolStripMenuItem
            // 
            this.добавитьВОтчетToolStripMenuItem.Name = "добавитьВОтчетToolStripMenuItem";
            this.добавитьВОтчетToolStripMenuItem.Size = new System.Drawing.Size(265, 32);
            this.добавитьВОтчетToolStripMenuItem.Text = "Добавить в отчет";
            this.добавитьВОтчетToolStripMenuItem.Click += new System.EventHandler(this.добавитьВОтчетToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.labelEquippmentsTitle);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.labelPrioritet);
            this.panel1.Controls.Add(this.labelEqipmentsType);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelBrokenType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(25, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 454);
            this.panel1.TabIndex = 15;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(923, 499);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPrioritet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelBrokenType;
        private System.Windows.Forms.Label labelEqipmentsType;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelEquippmentsTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьСостоянияРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВОтчетToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
