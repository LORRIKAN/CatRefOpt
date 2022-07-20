namespace Admin.View.CustomForms
{
    partial class MathModelForm
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
            this.standardTableEditor = new Admin.View.StandardTableEditor();
            this.setDescriptionButt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.standardTableEditor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.setDescriptionButt, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // standardTableEditor
            // 
            this.standardTableEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardTableEditor.Location = new System.Drawing.Point(3, 53);
            this.standardTableEditor.Name = "standardTableEditor";
            this.standardTableEditor.Size = new System.Drawing.Size(794, 394);
            this.standardTableEditor.TabIndex = 0;
            // 
            // setDescriptionButt
            // 
            this.setDescriptionButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setDescriptionButt.Location = new System.Drawing.Point(3, 3);
            this.setDescriptionButt.Name = "setDescriptionButt";
            this.setDescriptionButt.Size = new System.Drawing.Size(794, 44);
            this.setDescriptionButt.TabIndex = 1;
            this.setDescriptionButt.Text = "Изменить описание";
            this.setDescriptionButt.UseVisualStyleBackColor = true;
            this.setDescriptionButt.Click += new System.EventHandler(this.setDescriptionButt_Click);
            // 
            // MathModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MathModelForm";
            this.Text = "MathModelForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private StandardTableEditor standardTableEditor;
        private Button setDescriptionButt;
    }
}