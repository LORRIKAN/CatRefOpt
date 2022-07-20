namespace Admin.View
{
    partial class StandardForm
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
            this.standardTableEditor = new Admin.View.StandardTableEditor();
            this.SuspendLayout();
            // 
            // standardTableEditor
            // 
            this.standardTableEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standardTableEditor.Location = new System.Drawing.Point(0, 0);
            this.standardTableEditor.Name = "standardTableEditor";
            this.standardTableEditor.Size = new System.Drawing.Size(800, 450);
            this.standardTableEditor.TabIndex = 0;
            // 
            // StandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.standardTableEditor);
            this.Name = "StandardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private StandardTableEditor standardTableEditor;
    }
}