
namespace Researcher.View.InterfaceElements.ParamsIO
{
    partial class ParameterInput
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.paramNameLbl = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.errorLbl = new System.Windows.Forms.Label();
            this.measureUnitLbl = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.paramNameLbl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // paramNameLbl
            // 
            this.paramNameLbl.Controls.Add(this.tableLayoutPanel2);
            this.paramNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramNameLbl.Location = new System.Drawing.Point(0, 0);
            this.paramNameLbl.Name = "paramNameLbl";
            this.paramNameLbl.Size = new System.Drawing.Size(251, 75);
            this.paramNameLbl.TabIndex = 1;
            this.paramNameLbl.TabStop = false;
            this.paramNameLbl.Text = "Имя параметра";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.errorLbl, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.measureUnitLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 45);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.errorLbl.Location = new System.Drawing.Point(198, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 45);
            this.errorLbl.TabIndex = 3;
            // 
            // measureUnitLbl
            // 
            this.measureUnitLbl.AutoSize = true;
            this.measureUnitLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.measureUnitLbl.Location = new System.Drawing.Point(117, 0);
            this.measureUnitLbl.Name = "measureUnitLbl";
            this.measureUnitLbl.Size = new System.Drawing.Size(75, 45);
            this.measureUnitLbl.TabIndex = 0;
            this.measureUnitLbl.Text = "Ед. изм.";
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(3, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(108, 31);
            this.textBox.TabIndex = 1;
            // 
            // ParameterInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CausesValidation = false;
            this.Controls.Add(this.paramNameLbl);
            this.Name = "ParameterInput";
            this.Size = new System.Drawing.Size(251, 75);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.paramNameLbl.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ErrorProvider errorProvider;
        private GroupBox paramNameLbl;
        private TableLayoutPanel tableLayoutPanel2;
        private Label errorLbl;
        private Label measureUnitLbl;
        protected TextBox textBox;
    }
}
