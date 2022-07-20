namespace Admin.View.CustomForms
{
    partial class MatlabFuncForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.exportButt = new System.Windows.Forms.Button();
            this.importButt = new System.Windows.Forms.Button();
            this.standardTableEditor = new Admin.View.StandardTableEditor();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.standardTableEditor, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.exportButt, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.importButt, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 44);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // exportButt
            // 
            this.exportButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exportButt.Enabled = false;
            this.exportButt.Location = new System.Drawing.Point(400, 3);
            this.exportButt.Name = "exportButt";
            this.exportButt.Size = new System.Drawing.Size(391, 38);
            this.exportButt.TabIndex = 1;
            this.exportButt.Text = "Экспортировать функцию MATLAB";
            this.exportButt.UseVisualStyleBackColor = true;
            // 
            // importButt
            // 
            this.importButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButt.Location = new System.Drawing.Point(3, 3);
            this.importButt.Name = "importButt";
            this.importButt.Size = new System.Drawing.Size(391, 38);
            this.importButt.TabIndex = 0;
            this.importButt.Text = "Импортировать функцию MATLAB";
            this.importButt.UseVisualStyleBackColor = true;
            // 
            // standardTableEditor
            // 
            this.standardTableEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardTableEditor.Location = new System.Drawing.Point(3, 53);
            this.standardTableEditor.Name = "standardTableEditor";
            this.standardTableEditor.Size = new System.Drawing.Size(794, 394);
            this.standardTableEditor.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Файлы Matlab|*.m";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Matlab|*.m";
            // 
            // MatlabFuncForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MatlabFuncForm";
            this.Text = "MatlabFuncForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button exportButt;
        private Button importButt;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private StandardTableEditor standardTableEditor;
    }
}