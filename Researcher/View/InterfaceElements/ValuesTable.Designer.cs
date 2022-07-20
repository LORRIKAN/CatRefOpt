namespace Researcher.View.InterfaceElements
{
    partial class ValuesTable
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.xLbl = new System.Windows.Forms.Label();
            this.yLbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.XMultInput = new Researcher.View.InterfaceElements.ParamsIO.ParameterInput();
            this.YMultInput = new Researcher.View.InterfaceElements.ParamsIO.ParameterInput();
            this.buildTableButt = new Researcher.View.InterfaceElements.DependentButt();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tableName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dataGridView, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(795, 425);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(789, 150);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.xLbl, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.yLbl, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 110);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(781, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xLbl.Location = new System.Drawing.Point(394, 1);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(383, 34);
            this.xLbl.TabIndex = 1;
            this.xLbl.Text = "Подпись по горизонтали";
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yLbl.Location = new System.Drawing.Point(4, 1);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(383, 34);
            this.yLbl.TabIndex = 0;
            this.yLbl.Text = "Подпись по вертикали";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.XMultInput, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.YMultInput, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.buildTableButt, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(781, 99);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // XMultInput
            // 
            this.XMultInput.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.XMultInput.CausesValidation = false;
            this.XMultInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XMultInput.Location = new System.Drawing.Point(265, 5);
            this.XMultInput.Margin = new System.Windows.Forms.Padding(4);
            this.XMultInput.MeasureUnit = "";
            this.XMultInput.Name = "XMultInput";
            this.XMultInput.ParameterName = "";
            this.XMultInput.Size = new System.Drawing.Size(251, 89);
            this.XMultInput.TabIndex = 8;
            this.XMultInput.Value = "";
            // 
            // YMultInput
            // 
            this.YMultInput.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.YMultInput.CausesValidation = false;
            this.YMultInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YMultInput.Location = new System.Drawing.Point(5, 5);
            this.YMultInput.Margin = new System.Windows.Forms.Padding(4);
            this.YMultInput.MeasureUnit = "";
            this.YMultInput.Name = "YMultInput";
            this.YMultInput.ParameterName = "";
            this.YMultInput.Size = new System.Drawing.Size(251, 89);
            this.YMultInput.TabIndex = 6;
            this.YMultInput.Value = "";
            // 
            // buildTableButt
            // 
            this.buildTableButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildTableButt.Location = new System.Drawing.Point(524, 4);
            this.buildTableButt.Name = "buildTableButt";
            this.buildTableButt.Size = new System.Drawing.Size(253, 91);
            this.buildTableButt.TabIndex = 9;
            this.buildTableButt.Text = "Построить таблицу";
            this.buildTableButt.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ColumnHeadersHeight = 46;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 159);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(789, 263);
            this.dataGridView.TabIndex = 1;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableName.Location = new System.Drawing.Point(3, 0);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(795, 25);
            this.tableName.TabIndex = 0;
            this.tableName.Text = "Таблица значений";
            // 
            // ValuesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ValuesTable";
            this.Size = new System.Drawing.Size(801, 456);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label tableName;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label xLbl;
        private Label yLbl;
        private TableLayoutPanel tableLayoutPanel5;
        private ParamsIO.ParameterInput XMultInput;
        private ParamsIO.ParameterInput YMultInput;
        private DependentButt buildTableButt;
        private DataGridView dataGridView;
    }
}
