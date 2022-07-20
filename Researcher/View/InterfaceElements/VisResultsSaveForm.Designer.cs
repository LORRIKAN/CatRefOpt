namespace Researcher.View.InterfaceElements
{
    partial class VisResultsSaveForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.essentialElems = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optionalElems = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.okButt = new System.Windows.Forms.Button();
            this.abortButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.61111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.essentialElems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обязательные элементы";
            // 
            // essentialElems
            // 
            this.essentialElems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.essentialElems.Enabled = false;
            this.essentialElems.FormattingEnabled = true;
            this.essentialElems.Items.AddRange(new object[] {
            "Установка, реакторы, сырьё, катализатор",
            "Их характеристики",
            "Характеристики процесса",
            "Имя математической модели, функции для визуализации"});
            this.essentialElems.Location = new System.Drawing.Point(3, 27);
            this.essentialElems.Name = "essentialElems";
            this.essentialElems.Size = new System.Drawing.Size(542, 153);
            this.essentialElems.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optionalElems);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 150);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Необязательные элементы";
            // 
            // optionalElems
            // 
            this.optionalElems.CheckOnClick = true;
            this.optionalElems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionalElems.FormattingEnabled = true;
            this.optionalElems.Items.AddRange(new object[] {
            "Описание математической модели"});
            this.optionalElems.Location = new System.Drawing.Point(3, 27);
            this.optionalElems.Name = "optionalElems";
            this.optionalElems.Size = new System.Drawing.Size(542, 120);
            this.optionalElems.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.84431F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.15569F));
            this.tableLayoutPanel5.Controls.Add(this.okButt, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.abortButt, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 348);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(548, 74);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // okButt
            // 
            this.okButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButt.Location = new System.Drawing.Point(3, 3);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(146, 68);
            this.okButt.TabIndex = 0;
            this.okButt.Text = "ОК";
            this.okButt.UseVisualStyleBackColor = true;
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // abortButt
            // 
            this.abortButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abortButt.Location = new System.Drawing.Point(155, 3);
            this.abortButt.Name = "abortButt";
            this.abortButt.Size = new System.Drawing.Size(390, 68);
            this.abortButt.TabIndex = 1;
            this.abortButt.Text = "Отмена";
            this.abortButt.UseVisualStyleBackColor = true;
            this.abortButt.Click += new System.EventHandler(this.abortButt_Click);
            // 
            // VisResultsSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisResultsSaveForm";
            this.Text = "Выберите то, что хотите сохранить";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckedListBox optionalElems;
        private TableLayoutPanel tableLayoutPanel5;
        private Button okButt;
        private Button abortButt;
        private CheckedListBox essentialElems;
    }
}