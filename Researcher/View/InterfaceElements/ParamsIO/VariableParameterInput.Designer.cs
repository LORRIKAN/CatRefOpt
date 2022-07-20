namespace Researcher.View.InterfaceElements.ParamsIO
{
    partial class VariableParameterInput
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.parameterInput = new Researcher.View.InterfaceElements.ParamsIO.ParameterInput();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.upperBoundLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lowerBoundLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.parameterInput, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 146);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // parameterInput
            // 
            this.parameterInput.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.parameterInput.CausesValidation = false;
            this.parameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameterInput.Location = new System.Drawing.Point(3, 3);
            this.parameterInput.MeasureUnit = "";
            this.parameterInput.Name = "parameterInput";
            this.parameterInput.ParameterName = "";
            this.parameterInput.Size = new System.Drawing.Size(251, 72);
            this.parameterInput.TabIndex = 0;
            this.parameterInput.Value = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.upperBoundLbl, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lowerBoundLbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(251, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // upperBoundLbl
            // 
            this.upperBoundLbl.AutoSize = true;
            this.upperBoundLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperBoundLbl.Location = new System.Drawing.Point(163, 25);
            this.upperBoundLbl.Name = "upperBoundLbl";
            this.upperBoundLbl.Size = new System.Drawing.Size(85, 37);
            this.upperBoundLbl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Верхняя граница:";
            // 
            // lowerBoundLbl
            // 
            this.lowerBoundLbl.AutoSize = true;
            this.lowerBoundLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerBoundLbl.Location = new System.Drawing.Point(163, 0);
            this.lowerBoundLbl.Name = "lowerBoundLbl";
            this.lowerBoundLbl.Size = new System.Drawing.Size(85, 25);
            this.lowerBoundLbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижняя граница:";
            // 
            // VariableParameterInput
            // 
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VariableParameterInput";
            this.Size = new System.Drawing.Size(257, 146);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorProvider errorProvider;
        private TableLayoutPanel tableLayoutPanel1;
        private ParameterInput parameterInput;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label upperBoundLbl;
        private Label label2;
        private Label lowerBoundLbl;
    }
}
