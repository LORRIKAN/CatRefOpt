namespace Admin.View
{
    partial class StandardTableEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardTableEditor));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addButt = new System.Windows.Forms.ToolStripButton();
            this.deleteButt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveButt = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(0, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(523, 284);
            this.dataGridView.TabIndex = 7;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView_DataError);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addButt,
            this.deleteButt,
            this.toolStripSeparator2,
            this.saveButt});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(523, 50);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addButt
            // 
            this.addButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addButt.Enabled = false;
            this.addButt.Image = ((System.Drawing.Image)(resources.GetObject("addButt.Image")));
            this.addButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(44, 45);
            this.addButt.Text = "toolStripButton1";
            this.addButt.ToolTipText = "Добавить запись";
            this.addButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // deleteButt
            // 
            this.deleteButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteButt.Enabled = false;
            this.deleteButt.Image = ((System.Drawing.Image)(resources.GetObject("deleteButt.Image")));
            this.deleteButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(44, 45);
            this.deleteButt.Text = "toolStripButton1";
            this.deleteButt.ToolTipText = "Удалить запись";
            this.deleteButt.Click += new System.EventHandler(this.DeleteButt_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // saveButt
            // 
            this.saveButt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveButt.Enabled = false;
            this.saveButt.Image = ((System.Drawing.Image)(resources.GetObject("saveButt.Image")));
            this.saveButt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(44, 45);
            this.saveButt.Text = "toolStripButton1";
            this.saveButt.ToolTipText = "Сохранить изменения";
            this.saveButt.Click += new System.EventHandler(this.SaveButt_Click);
            // 
            // StandardTableEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip);
            this.Name = "StandardTableEditor";
            this.Size = new System.Drawing.Size(523, 334);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ToolStrip toolStrip;
        private ToolStripSeparator toolStripSeparator2;
        public DataGridView dataGridView;
        public ToolStripButton addButt;
        public ToolStripButton deleteButt;
        public ToolStripButton saveButt;
    }
}
