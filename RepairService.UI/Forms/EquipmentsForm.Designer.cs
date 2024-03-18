namespace RepairService.UI.Forms
{
    partial class EquipmentsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBrokenType = new System.Windows.Forms.ComboBox();
            this.comboBoxequipmentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxBrokenType);
            this.panel1.Controls.Add(this.comboBoxequipmentType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1607, 213);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поиск по оборудованию";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.textBoxSearch.Location = new System.Drawing.Point(388, 148);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(667, 42);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(701, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "и";
            // 
            // comboBoxBrokenType
            // 
            this.comboBoxBrokenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrokenType.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.comboBoxBrokenType.FormattingEnabled = true;
            this.comboBoxBrokenType.Location = new System.Drawing.Point(761, 81);
            this.comboBoxBrokenType.Name = "comboBoxBrokenType";
            this.comboBoxBrokenType.Size = new System.Drawing.Size(294, 43);
            this.comboBoxBrokenType.TabIndex = 7;
            this.comboBoxBrokenType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrokenType_SelectedIndexChanged);
            // 
            // comboBoxequipmentType
            // 
            this.comboBoxequipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxequipmentType.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.comboBoxequipmentType.FormattingEnabled = true;
            this.comboBoxequipmentType.Location = new System.Drawing.Point(388, 81);
            this.comboBoxequipmentType.Name = "comboBoxequipmentType";
            this.comboBoxequipmentType.Size = new System.Drawing.Size(294, 43);
            this.comboBoxequipmentType.TabIndex = 6;
            this.comboBoxequipmentType.SelectedIndexChanged += new System.EventHandler(this.comboBoxequipmentType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фильтрация";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.checkBox1.Location = new System.Drawing.Point(12, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(407, 39);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Сортировка по созданию";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.buttonEnter.Location = new System.Drawing.Point(1302, 107);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(277, 76);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Добавить";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1607, 810);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // EquipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1607, 1023);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "EquipmentsForm";
            this.Text = "EquipmentsForm";
            this.Load += new System.EventHandler(this.EquipmentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBrokenType;
        private System.Windows.Forms.ComboBox comboBoxequipmentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}