namespace RepairService.UI.Forms
{
    partial class AddOrdersForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.comboBoxBrokenType = new System.Windows.Forms.ComboBox();
            this.comboBoxRequipment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownPrioritet = new System.Windows.Forms.NumericUpDown();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrioritet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(22, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Оборудование";
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.textBoxDesc.Location = new System.Drawing.Point(28, 188);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(687, 161);
            this.textBoxDesc.TabIndex = 11;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // comboBoxBrokenType
            // 
            this.comboBoxBrokenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrokenType.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.comboBoxBrokenType.FormattingEnabled = true;
            this.comboBoxBrokenType.Location = new System.Drawing.Point(286, 117);
            this.comboBoxBrokenType.Name = "comboBoxBrokenType";
            this.comboBoxBrokenType.Size = new System.Drawing.Size(294, 43);
            this.comboBoxBrokenType.TabIndex = 14;
            this.comboBoxBrokenType.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrokenType_SelectedIndexChanged);
            // 
            // comboBoxRequipment
            // 
            this.comboBoxRequipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRequipment.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.comboBoxRequipment.FormattingEnabled = true;
            this.comboBoxRequipment.Location = new System.Drawing.Point(286, 47);
            this.comboBoxRequipment.Name = "comboBoxRequipment";
            this.comboBoxRequipment.Size = new System.Drawing.Size(294, 43);
            this.comboBoxRequipment.TabIndex = 13;
            this.comboBoxRequipment.SelectedIndexChanged += new System.EventHandler(this.comboBoxRequipment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Неисправность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(33, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Приоритет";
            // 
            // numericUpDownPrioritet
            // 
            this.numericUpDownPrioritet.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.numericUpDownPrioritet.Location = new System.Drawing.Point(239, 365);
            this.numericUpDownPrioritet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPrioritet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrioritet.Name = "numericUpDownPrioritet";
            this.numericUpDownPrioritet.Size = new System.Drawing.Size(476, 42);
            this.numericUpDownPrioritet.TabIndex = 17;
            this.numericUpDownPrioritet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPrioritet.ValueChanged += new System.EventHandler(this.numericUpDownPrioritet_ValueChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnter.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.buttonEnter.Location = new System.Drawing.Point(39, 431);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(277, 76);
            this.buttonEnter.TabIndex = 18;
            this.buttonEnter.Text = "Добавить";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F);
            this.buttonCancel.Location = new System.Drawing.Point(438, 431);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(277, 76);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 519);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.numericUpDownPrioritet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBrokenType);
            this.Controls.Add(this.comboBoxRequipment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDesc);
            this.Name = "AddOrdersForm";
            this.Text = "AddOrdersForm";
            this.Load += new System.EventHandler(this.AddOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrioritet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.ComboBox comboBoxBrokenType;
        private System.Windows.Forms.ComboBox comboBoxRequipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownPrioritet;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonCancel;
    }
}