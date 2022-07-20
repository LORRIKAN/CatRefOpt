
using WinFormsShared;

namespace Admin.View
{
    partial class MainForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dbChooseGroupBox = new System.Windows.Forms.GroupBox();
            this.dbChooseComboBox = new System.Windows.Forms.ComboBox();
            this.tableChooseGroupBox = new System.Windows.Forms.GroupBox();
            this.tableChooseComboBox = new System.Windows.Forms.ComboBox();
            this.openTableButt = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileButt = new System.Windows.Forms.ToolStripMenuItem();
            this.reloginButt = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButt = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButt = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel.SuspendLayout();
            this.dbChooseGroupBox.SuspendLayout();
            this.tableChooseGroupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dbChooseGroupBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableChooseGroupBox, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.openTableButt, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(940, 248);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // dbChooseGroupBox
            // 
            this.dbChooseGroupBox.Controls.Add(this.dbChooseComboBox);
            this.dbChooseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbChooseGroupBox.Location = new System.Drawing.Point(3, 3);
            this.dbChooseGroupBox.Name = "dbChooseGroupBox";
            this.dbChooseGroupBox.Size = new System.Drawing.Size(934, 74);
            this.dbChooseGroupBox.TabIndex = 0;
            this.dbChooseGroupBox.TabStop = false;
            this.dbChooseGroupBox.Text = "Выберите базу данных/библиотеку:";
            // 
            // dbChooseComboBox
            // 
            this.dbChooseComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbChooseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbChooseComboBox.FormattingEnabled = true;
            this.dbChooseComboBox.Location = new System.Drawing.Point(3, 27);
            this.dbChooseComboBox.Name = "dbChooseComboBox";
            this.dbChooseComboBox.Size = new System.Drawing.Size(928, 33);
            this.dbChooseComboBox.TabIndex = 0;
            this.dbChooseComboBox.SelectedValueChanged += new System.EventHandler(this.DbChooseComboBox_SelectedValueChanged);
            // 
            // tableChooseGroupBox
            // 
            this.tableChooseGroupBox.Controls.Add(this.tableChooseComboBox);
            this.tableChooseGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableChooseGroupBox.Location = new System.Drawing.Point(3, 83);
            this.tableChooseGroupBox.Name = "tableChooseGroupBox";
            this.tableChooseGroupBox.Size = new System.Drawing.Size(934, 74);
            this.tableChooseGroupBox.TabIndex = 1;
            this.tableChooseGroupBox.TabStop = false;
            this.tableChooseGroupBox.Text = "Выберите таблицу:";
            // 
            // tableChooseComboBox
            // 
            this.tableChooseComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableChooseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableChooseComboBox.FormattingEnabled = true;
            this.tableChooseComboBox.Location = new System.Drawing.Point(3, 27);
            this.tableChooseComboBox.Name = "tableChooseComboBox";
            this.tableChooseComboBox.Size = new System.Drawing.Size(928, 33);
            this.tableChooseComboBox.TabIndex = 0;
            // 
            // openTableButt
            // 
            this.openTableButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openTableButt.Location = new System.Drawing.Point(3, 163);
            this.openTableButt.Name = "openTableButt";
            this.openTableButt.Size = new System.Drawing.Size(934, 82);
            this.openTableButt.TabIndex = 2;
            this.openTableButt.Text = "Открыть таблицу";
            this.openTableButt.UseVisualStyleBackColor = true;
            this.openTableButt.Click += new System.EventHandler(this.openTableButt_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButt,
            this.aboutButt});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(940, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileButt
            // 
            this.fileButt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloginButt,
            this.exitButt});
            this.fileButt.Name = "fileButt";
            this.fileButt.Size = new System.Drawing.Size(69, 29);
            this.fileButt.Text = "Файл";
            // 
            // reloginButt
            // 
            this.reloginButt.Name = "reloginButt";
            this.reloginButt.Size = new System.Drawing.Size(316, 34);
            this.reloginButt.Text = "Сменить учётную запись";
            // 
            // exitButt
            // 
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(316, 34);
            this.exitButt.Text = "Выход";
            // 
            // aboutButt
            // 
            this.aboutButt.Name = "aboutButt";
            this.aboutButt.Size = new System.Drawing.Size(141, 29);
            this.aboutButt.Text = "О программе";
            this.aboutButt.Click += new System.EventHandler(this.aboutButt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 281);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор: УИК по оптимизации процесса каталитического риформинга с использов" +
    "анием методов нелинейного программирования";
            this.tableLayoutPanel.ResumeLayout(false);
            this.dbChooseGroupBox.ResumeLayout(false);
            this.tableChooseGroupBox.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.GroupBox dbChooseGroupBox;
        private System.Windows.Forms.GroupBox tableChooseGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem reloginButt;
        private System.Windows.Forms.ComboBox dbChooseComboBox;
        private System.Windows.Forms.ComboBox tableChooseComboBox;
        private System.Windows.Forms.ToolStripMenuItem fileButt;
        private System.Windows.Forms.ToolStripMenuItem exitButt;
        private System.Windows.Forms.ToolStripMenuItem aboutButt;
        private Button openTableButt;
    }
}