using Researcher.View.InterfaceElements.Panels;

namespace Researcher.View
{
    partial class ResearcherForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOptimResultsButt = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVisResultsButt = new System.Windows.Forms.ToolStripMenuItem();
            this.reloginButt = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButt = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButt = new System.Windows.Forms.ToolStripMenuItem();
            this.allocatedMemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.optimPage = new System.Windows.Forms.TabPage();
            this.optimPageTab = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plantOptim = new Researcher.View.InterfaceElements.MasterComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reactorOptim = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reactorParamsOptim = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialOptim = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.materialParamsOptim = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.catalystOptim = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.catalystParamsOptim = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.targetFuncChoosePanel = new Researcher.View.InterfaceElements.Panels.TargetFuncChoosePanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.variableParamsOptim = new Researcher.View.InterfaceElements.Panels.VariableParamsChoosePanel();
            this.variableParamsOptimGroupBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.startingPointOptim = new Researcher.View.InterfaceElements.Panels.StartingPointPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.build2DPathButt = new Researcher.View.InterfaceElements.DependentButt();
            this.startOptimButt = new Researcher.View.InterfaceElements.DependentButt();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.build3DPathButt = new Researcher.View.InterfaceElements.DependentButt();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.optimMethod = new Researcher.View.InterfaceElements.MasterComboBox();
            this.helpButtOnOptimMethod = new Researcher.View.InterfaceElements.DependentButt();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.optimParams = new Researcher.View.InterfaceElements.Panels.OptimParamsPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.optimResultsPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.tableOfPath = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.optimResultsPanel = new Researcher.View.InterfaceElements.Panels.TopDownFlowLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.optimMetricsPanel = new Researcher.View.InterfaceElements.Panels.TopDownFlowLayoutPanel();
            this.visPage = new System.Windows.Forms.TabPage();
            this.visPageTab = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.plantVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.reactorVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.reactorParamsVis = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.materialVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.materialParamsVis = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.catalystVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.catalystParamsVis = new Researcher.View.InterfaceElements.Panels.InputParamsPanel();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.targetFuncVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.valuesTableSizeN = new Researcher.View.InterfaceElements.ParamsIO.ParameterInput();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.helpButtOnMathModelVis = new Researcher.View.InterfaceElements.DependentButt();
            this.mathModelVis = new Researcher.View.InterfaceElements.MasterComboBox();
            this.valuesTableSizeM = new Researcher.View.InterfaceElements.ParamsIO.ParameterInput();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.variableParamsVis = new Researcher.View.InterfaceElements.Panels.VariableParamsChoosePanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.buildValuesTableButt = new Researcher.View.InterfaceElements.DependentButt();
            this.build3DPlotButt = new Researcher.View.InterfaceElements.DependentButt();
            this.build2DPlotButt = new Researcher.View.InterfaceElements.DependentButt();
            this.valuesTablePage = new System.Windows.Forms.TabPage();
            this.valuesTable = new Researcher.View.InterfaceElements.ValuesTable();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.optimPage.SuspendLayout();
            this.optimPageTab.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.optimResultsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableOfPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.visPage.SuspendLayout();
            this.visPageTab.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.valuesTablePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.aboutButt,
            this.allocatedMemShow,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveOptimResultsButt,
            this.saveVisResultsButt,
            this.reloginButt,
            this.exitButt});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveOptimResultsButt
            // 
            this.saveOptimResultsButt.Enabled = false;
            this.saveOptimResultsButt.Name = "saveOptimResultsButt";
            this.saveOptimResultsButt.Size = new System.Drawing.Size(426, 34);
            this.saveOptimResultsButt.Text = "Сохранить результаты оптимизации...";
            this.saveOptimResultsButt.Click += new System.EventHandler(this.saveOptimResultsButt_Click);
            // 
            // saveVisResultsButt
            // 
            this.saveVisResultsButt.Name = "saveVisResultsButt";
            this.saveVisResultsButt.Size = new System.Drawing.Size(426, 34);
            this.saveVisResultsButt.Text = "Сохранить результаты визуализации...";
            this.saveVisResultsButt.Click += new System.EventHandler(this.saveVisResultsButt_Click);
            // 
            // reloginButt
            // 
            this.reloginButt.Name = "reloginButt";
            this.reloginButt.Size = new System.Drawing.Size(426, 34);
            this.reloginButt.Text = "Сменить учётную запись...";
            // 
            // exitButt
            // 
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(426, 34);
            this.exitButt.Text = "Выход";
            // 
            // aboutButt
            // 
            this.aboutButt.Name = "aboutButt";
            this.aboutButt.Size = new System.Drawing.Size(141, 29);
            this.aboutButt.Text = "О программе";
            this.aboutButt.Click += new System.EventHandler(this.aboutButt_Click);
            // 
            // allocatedMemShow
            // 
            this.allocatedMemShow.Name = "allocatedMemShow";
            this.allocatedMemShow.Size = new System.Drawing.Size(328, 29);
            this.allocatedMemShow.Text = "Потребляемая оперативная память: ";
            this.allocatedMemShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(246, 29);
            this.toolStripMenuItem1.Text = "* - Обязательно для ввода";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.optimPage);
            this.tabControl1.Controls.Add(this.visPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 669);
            this.tabControl1.TabIndex = 1;
            // 
            // optimPage
            // 
            this.optimPage.Controls.Add(this.optimPageTab);
            this.optimPage.Location = new System.Drawing.Point(4, 34);
            this.optimPage.Name = "optimPage";
            this.optimPage.Padding = new System.Windows.Forms.Padding(3);
            this.optimPage.Size = new System.Drawing.Size(937, 631);
            this.optimPage.TabIndex = 1;
            this.optimPage.Text = "Оптимизация";
            this.optimPage.UseVisualStyleBackColor = true;
            // 
            // optimPageTab
            // 
            this.optimPageTab.Controls.Add(this.tabPage5);
            this.optimPageTab.Controls.Add(this.tabPage6);
            this.optimPageTab.Controls.Add(this.optimResultsPage);
            this.optimPageTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimPageTab.Location = new System.Drawing.Point(3, 3);
            this.optimPageTab.Name = "optimPageTab";
            this.optimPageTab.SelectedIndex = 0;
            this.optimPageTab.Size = new System.Drawing.Size(931, 625);
            this.optimPageTab.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel1);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(923, 587);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Выбор оборудования, сырья и катализатора";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 581);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plantOptim);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите установку";
            // 
            // plantOptim
            // 
            this.plantOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantOptim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantOptim.FormattingEnabled = true;
            this.plantOptim.InvalidateIfNoItems = true;
            this.plantOptim.Location = new System.Drawing.Point(3, 27);
            this.plantOptim.Name = "plantOptim";
            this.plantOptim.Size = new System.Drawing.Size(293, 33);
            this.plantOptim.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 495);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reactorOptim);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Просмотреть реактор";
            // 
            // reactorOptim
            // 
            this.reactorOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactorOptim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reactorOptim.FormattingEnabled = true;
            this.reactorOptim.InvalidateIfNoItems = true;
            this.reactorOptim.Location = new System.Drawing.Point(3, 27);
            this.reactorOptim.Name = "reactorOptim";
            this.reactorOptim.Size = new System.Drawing.Size(287, 33);
            this.reactorOptim.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reactorParamsOptim);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 409);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Характеристики реактора";
            // 
            // reactorParamsOptim
            // 
            this.reactorParamsOptim.AutoScroll = true;
            this.reactorParamsOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactorParamsOptim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.reactorParamsOptim.Location = new System.Drawing.Point(3, 27);
            this.reactorParamsOptim.Name = "reactorParamsOptim";
            this.reactorParamsOptim.Size = new System.Drawing.Size(287, 379);
            this.reactorParamsOptim.TabIndex = 0;
            this.reactorParamsOptim.WrapContents = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.materialOptim);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(308, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(299, 74);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите сырьё";
            // 
            // materialOptim
            // 
            this.materialOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialOptim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialOptim.FormattingEnabled = true;
            this.materialOptim.InvalidateIfNoItems = true;
            this.materialOptim.Location = new System.Drawing.Point(3, 27);
            this.materialOptim.Name = "materialOptim";
            this.materialOptim.Size = new System.Drawing.Size(293, 33);
            this.materialOptim.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.materialParamsOptim);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(308, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(299, 495);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Характеристики сырья";
            // 
            // materialParamsOptim
            // 
            this.materialParamsOptim.AutoScroll = true;
            this.materialParamsOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialParamsOptim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.materialParamsOptim.Location = new System.Drawing.Point(3, 27);
            this.materialParamsOptim.Name = "materialParamsOptim";
            this.materialParamsOptim.Size = new System.Drawing.Size(293, 465);
            this.materialParamsOptim.TabIndex = 1;
            this.materialParamsOptim.WrapContents = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.catalystOptim);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(613, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(301, 74);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Выберите катализатор";
            // 
            // catalystOptim
            // 
            this.catalystOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalystOptim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catalystOptim.FormattingEnabled = true;
            this.catalystOptim.InvalidateIfNoItems = true;
            this.catalystOptim.Location = new System.Drawing.Point(3, 27);
            this.catalystOptim.Name = "catalystOptim";
            this.catalystOptim.Size = new System.Drawing.Size(295, 33);
            this.catalystOptim.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.catalystParamsOptim);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(613, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 495);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Характеристики катализатора";
            // 
            // catalystParamsOptim
            // 
            this.catalystParamsOptim.AutoScroll = true;
            this.catalystParamsOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalystParamsOptim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.catalystParamsOptim.Location = new System.Drawing.Point(3, 27);
            this.catalystParamsOptim.Name = "catalystParamsOptim";
            this.catalystParamsOptim.Size = new System.Drawing.Size(295, 465);
            this.catalystParamsOptim.TabIndex = 1;
            this.catalystParamsOptim.WrapContents = false;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel3);
            this.tabPage6.Location = new System.Drawing.Point(4, 34);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(923, 587);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Настройка и запуск процесса оптимизации";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.12214F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.87786F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel14, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(917, 581);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.targetFuncChoosePanel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(582, 575);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // targetFuncChoosePanel
            // 
            this.targetFuncChoosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetFuncChoosePanel.Location = new System.Drawing.Point(3, 3);
            this.targetFuncChoosePanel.Name = "targetFuncChoosePanel";
            this.targetFuncChoosePanel.Size = new System.Drawing.Size(576, 159);
            this.targetFuncChoosePanel.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(576, 304);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.variableParamsOptim, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.variableParamsOptimGroupBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(280, 296);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // variableParamsOptim
            // 
            this.variableParamsOptim.AutoScroll = true;
            this.variableParamsOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableParamsOptim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.variableParamsOptim.Location = new System.Drawing.Point(3, 28);
            this.variableParamsOptim.MaxVariableParams = ((long)(9223372036854775807));
            this.variableParamsOptim.Name = "variableParamsOptim";
            this.variableParamsOptim.Size = new System.Drawing.Size(274, 265);
            this.variableParamsOptim.TabIndex = 1;
            this.variableParamsOptim.WrapContents = false;
            // 
            // variableParamsOptimGroupBox
            // 
            this.variableParamsOptimGroupBox.AutoSize = true;
            this.variableParamsOptimGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableParamsOptimGroupBox.Location = new System.Drawing.Point(3, 0);
            this.variableParamsOptimGroupBox.Name = "variableParamsOptimGroupBox";
            this.variableParamsOptimGroupBox.Size = new System.Drawing.Size(274, 25);
            this.variableParamsOptimGroupBox.TabIndex = 0;
            this.variableParamsOptimGroupBox.Text = "Варьируемые параметры";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.startingPointOptim, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(291, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(281, 296);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // startingPointOptim
            // 
            this.startingPointOptim.AutoScroll = true;
            this.startingPointOptim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingPointOptim.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.startingPointOptim.Location = new System.Drawing.Point(3, 28);
            this.startingPointOptim.Name = "startingPointOptim";
            this.startingPointOptim.Size = new System.Drawing.Size(275, 265);
            this.startingPointOptim.TabIndex = 2;
            this.startingPointOptim.WrapContents = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Стартовая точка";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel13.ColumnCount = 2;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.06678F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.93322F));
            this.tableLayoutPanel13.Controls.Add(this.build2DPathButt, 1, 0);
            this.tableLayoutPanel13.Controls.Add(this.startOptimButt, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 478);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(576, 94);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // build2DPathButt
            // 
            this.build2DPathButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.build2DPathButt.Enabled = false;
            this.build2DPathButt.Location = new System.Drawing.Point(234, 4);
            this.build2DPathButt.Name = "build2DPathButt";
            this.build2DPathButt.Size = new System.Drawing.Size(338, 86);
            this.build2DPathButt.TabIndex = 2;
            this.build2DPathButt.Text = "Построить путь решения последнего процесса оптимизации на линиях равных значений";
            this.build2DPathButt.UseVisualStyleBackColor = true;
            this.build2DPathButt.Click += new System.EventHandler(this.build2DPathButt_Click);
            // 
            // startOptimButt
            // 
            this.startOptimButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startOptimButt.Enabled = false;
            this.startOptimButt.Location = new System.Drawing.Point(4, 4);
            this.startOptimButt.Name = "startOptimButt";
            this.startOptimButt.Size = new System.Drawing.Size(223, 86);
            this.startOptimButt.TabIndex = 1;
            this.startOptimButt.Text = "Запустить процесс оптимизации";
            this.startOptimButt.UseVisualStyleBackColor = true;
            this.startOptimButt.Click += new System.EventHandler(this.startOptimButt_Click);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.build3DPathButt, 0, 2);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel15, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(591, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(323, 575);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // build3DPathButt
            // 
            this.build3DPathButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.build3DPathButt.Enabled = false;
            this.build3DPathButt.Location = new System.Drawing.Point(4, 476);
            this.build3DPathButt.Name = "build3DPathButt";
            this.build3DPathButt.Size = new System.Drawing.Size(315, 95);
            this.build3DPathButt.TabIndex = 3;
            this.build3DPathButt.Text = "Построить путь решения последнего процесса оптимизации на поверхности отклика";
            this.build3DPathButt.UseVisualStyleBackColor = true;
            this.build3DPathButt.Click += new System.EventHandler(this.build3DPathButt_Click);
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.tableLayoutPanel16, 0, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(315, 73);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Метод нелинейного программирования";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel16.Controls.Add(this.optimMethod, 0, 0);
            this.tableLayoutPanel16.Controls.Add(this.helpButtOnOptimMethod, 1, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 1;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(309, 17);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // optimMethod
            // 
            this.optimMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optimMethod.FormattingEnabled = true;
            this.optimMethod.InvalidateIfNoItems = true;
            this.optimMethod.Location = new System.Drawing.Point(3, 3);
            this.optimMethod.Name = "optimMethod";
            this.optimMethod.Size = new System.Drawing.Size(263, 33);
            this.optimMethod.TabIndex = 1;
            // 
            // helpButtOnOptimMethod
            // 
            this.helpButtOnOptimMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpButtOnOptimMethod.Enabled = false;
            this.helpButtOnOptimMethod.Image = global::Researcher.Properties.Resources.helpIcon;
            this.helpButtOnOptimMethod.Location = new System.Drawing.Point(272, 3);
            this.helpButtOnOptimMethod.Name = "helpButtOnOptimMethod";
            this.helpButtOnOptimMethod.Size = new System.Drawing.Size(34, 11);
            this.helpButtOnOptimMethod.TabIndex = 0;
            this.helpButtOnOptimMethod.UseVisualStyleBackColor = true;
            this.helpButtOnOptimMethod.Click += new System.EventHandler(this.helpButtOnOptimMethod_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.optimParams, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(4, 84);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(315, 385);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // optimParams
            // 
            this.optimParams.AutoScroll = true;
            this.optimParams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimParams.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optimParams.Location = new System.Drawing.Point(3, 53);
            this.optimParams.Name = "optimParams";
            this.optimParams.Size = new System.Drawing.Size(309, 329);
            this.optimParams.TabIndex = 1;
            this.optimParams.WrapContents = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Параметры метода нелинейного программирования";
            // 
            // optimResultsPage
            // 
            this.optimResultsPage.Controls.Add(this.splitContainer1);
            this.optimResultsPage.Location = new System.Drawing.Point(4, 34);
            this.optimResultsPage.Name = "optimResultsPage";
            this.optimResultsPage.Padding = new System.Windows.Forms.Padding(3);
            this.optimResultsPage.Size = new System.Drawing.Size(923, 587);
            this.optimResultsPage.TabIndex = 3;
            this.optimResultsPage.Text = "Результаты";
            this.optimResultsPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox10);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(917, 581);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.tableOfPath);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(913, 264);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Путь решения в табличном виде";
            // 
            // tableOfPath
            // 
            this.tableOfPath.AllowUserToAddRows = false;
            this.tableOfPath.AllowUserToDeleteRows = false;
            this.tableOfPath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableOfPath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableOfPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOfPath.Location = new System.Drawing.Point(3, 27);
            this.tableOfPath.Name = "tableOfPath";
            this.tableOfPath.ReadOnly = true;
            this.tableOfPath.RowHeadersWidth = 62;
            this.tableOfPath.RowTemplate.Height = 33;
            this.tableOfPath.Size = new System.Drawing.Size(907, 234);
            this.tableOfPath.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel9);
            this.splitContainer2.Size = new System.Drawing.Size(913, 305);
            this.splitContainer2.SplitterDistance = 466;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.optimResultsPanel, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(466, 305);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Решение задачи оптимизации";
            // 
            // optimResultsPanel
            // 
            this.optimResultsPanel.AutoScroll = true;
            this.optimResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimResultsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optimResultsPanel.Location = new System.Drawing.Point(4, 30);
            this.optimResultsPanel.Name = "optimResultsPanel";
            this.optimResultsPanel.Size = new System.Drawing.Size(458, 271);
            this.optimResultsPanel.TabIndex = 1;
            this.optimResultsPanel.WrapContents = false;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.optimMetricsPanel, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(443, 305);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(435, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Показатели метода нелинейного программирования";
            // 
            // optimMetricsPanel
            // 
            this.optimMetricsPanel.AutoScroll = true;
            this.optimMetricsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optimMetricsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.optimMetricsPanel.Location = new System.Drawing.Point(4, 55);
            this.optimMetricsPanel.Name = "optimMetricsPanel";
            this.optimMetricsPanel.Size = new System.Drawing.Size(435, 246);
            this.optimMetricsPanel.TabIndex = 1;
            this.optimMetricsPanel.WrapContents = false;
            // 
            // visPage
            // 
            this.visPage.Controls.Add(this.visPageTab);
            this.visPage.Location = new System.Drawing.Point(4, 34);
            this.visPage.Name = "visPage";
            this.visPage.Padding = new System.Windows.Forms.Padding(3);
            this.visPage.Size = new System.Drawing.Size(937, 631);
            this.visPage.TabIndex = 2;
            this.visPage.Text = "Визуализация";
            this.visPage.UseVisualStyleBackColor = true;
            // 
            // visPageTab
            // 
            this.visPageTab.Controls.Add(this.tabPage7);
            this.visPageTab.Controls.Add(this.tabPage8);
            this.visPageTab.Controls.Add(this.valuesTablePage);
            this.visPageTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visPageTab.Location = new System.Drawing.Point(3, 3);
            this.visPageTab.Name = "visPageTab";
            this.visPageTab.SelectedIndex = 0;
            this.visPageTab.Size = new System.Drawing.Size(931, 625);
            this.visPageTab.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tableLayoutPanel22);
            this.tabPage7.Location = new System.Drawing.Point(4, 34);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(923, 587);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Выбор оборудования, сырья и катализатора";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.ColumnCount = 3;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel22.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel22.Controls.Add(this.tableLayoutPanel23, 0, 1);
            this.tableLayoutPanel22.Controls.Add(this.groupBox13, 1, 0);
            this.tableLayoutPanel22.Controls.Add(this.groupBox14, 1, 1);
            this.tableLayoutPanel22.Controls.Add(this.groupBox15, 2, 0);
            this.tableLayoutPanel22.Controls.Add(this.groupBox16, 2, 1);
            this.tableLayoutPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel22.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 2;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(917, 581);
            this.tableLayoutPanel22.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.plantVis);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(299, 74);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Выберите установку";
            // 
            // plantVis
            // 
            this.plantVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plantVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plantVis.FormattingEnabled = true;
            this.plantVis.InvalidateIfNoItems = true;
            this.plantVis.Location = new System.Drawing.Point(3, 27);
            this.plantVis.Name = "plantVis";
            this.plantVis.Size = new System.Drawing.Size(293, 33);
            this.plantVis.TabIndex = 0;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.ColumnCount = 1;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel23.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel23.Controls.Add(this.groupBox12, 0, 1);
            this.tableLayoutPanel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel23.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 2;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(299, 495);
            this.tableLayoutPanel23.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.reactorVis);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(293, 74);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Просмотреть реактор";
            // 
            // reactorVis
            // 
            this.reactorVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactorVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reactorVis.FormattingEnabled = true;
            this.reactorVis.InvalidateIfNoItems = true;
            this.reactorVis.Location = new System.Drawing.Point(3, 27);
            this.reactorVis.Name = "reactorVis";
            this.reactorVis.Size = new System.Drawing.Size(287, 33);
            this.reactorVis.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.reactorParamsVis);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(3, 83);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(293, 409);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Характеристики реактора";
            // 
            // reactorParamsVis
            // 
            this.reactorParamsVis.AutoScroll = true;
            this.reactorParamsVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reactorParamsVis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.reactorParamsVis.Location = new System.Drawing.Point(3, 27);
            this.reactorParamsVis.Name = "reactorParamsVis";
            this.reactorParamsVis.Size = new System.Drawing.Size(287, 379);
            this.reactorParamsVis.TabIndex = 0;
            this.reactorParamsVis.WrapContents = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.materialVis);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox13.Location = new System.Drawing.Point(308, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(299, 74);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Выберите сырьё";
            // 
            // materialVis
            // 
            this.materialVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialVis.FormattingEnabled = true;
            this.materialVis.InvalidateIfNoItems = true;
            this.materialVis.Location = new System.Drawing.Point(3, 27);
            this.materialVis.Name = "materialVis";
            this.materialVis.Size = new System.Drawing.Size(293, 33);
            this.materialVis.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.materialParamsVis);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.Location = new System.Drawing.Point(308, 83);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(299, 495);
            this.groupBox14.TabIndex = 3;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Характеристики сырья";
            // 
            // materialParamsVis
            // 
            this.materialParamsVis.AutoScroll = true;
            this.materialParamsVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialParamsVis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.materialParamsVis.Location = new System.Drawing.Point(3, 27);
            this.materialParamsVis.Name = "materialParamsVis";
            this.materialParamsVis.Size = new System.Drawing.Size(293, 465);
            this.materialParamsVis.TabIndex = 1;
            this.materialParamsVis.WrapContents = false;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.catalystVis);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.Location = new System.Drawing.Point(613, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(301, 74);
            this.groupBox15.TabIndex = 4;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Выберите катализатор";
            // 
            // catalystVis
            // 
            this.catalystVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalystVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catalystVis.FormattingEnabled = true;
            this.catalystVis.InvalidateIfNoItems = true;
            this.catalystVis.Location = new System.Drawing.Point(3, 27);
            this.catalystVis.Name = "catalystVis";
            this.catalystVis.Size = new System.Drawing.Size(295, 33);
            this.catalystVis.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.catalystParamsVis);
            this.groupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox16.Location = new System.Drawing.Point(613, 83);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(301, 495);
            this.groupBox16.TabIndex = 5;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Характеристики катализатора";
            // 
            // catalystParamsVis
            // 
            this.catalystParamsVis.AutoScroll = true;
            this.catalystParamsVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catalystParamsVis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.catalystParamsVis.Location = new System.Drawing.Point(3, 27);
            this.catalystParamsVis.Name = "catalystParamsVis";
            this.catalystParamsVis.Size = new System.Drawing.Size(295, 465);
            this.catalystParamsVis.TabIndex = 1;
            this.catalystParamsVis.WrapContents = false;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tableLayoutPanel10);
            this.tabPage8.Location = new System.Drawing.Point(4, 34);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(923, 587);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Настройка и запуск процесса визулизации";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.groupBox11, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(917, 581);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel20, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.valuesTableSizeN, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel18, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.valuesTableSizeM, 3, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(909, 79);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.tableLayoutPanel21, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(231, 4);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(220, 71);
            this.tableLayoutPanel20.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Целевая функция";
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel21.Controls.Add(this.targetFuncVis, 0, 0);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(214, 40);
            this.tableLayoutPanel21.TabIndex = 1;
            // 
            // targetFuncVis
            // 
            this.targetFuncVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetFuncVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetFuncVis.FormattingEnabled = true;
            this.targetFuncVis.InvalidateIfNoItems = true;
            this.targetFuncVis.Location = new System.Drawing.Point(3, 3);
            this.targetFuncVis.Name = "targetFuncVis";
            this.targetFuncVis.Size = new System.Drawing.Size(208, 33);
            this.targetFuncVis.TabIndex = 1;
            // 
            // valuesTableSizeN
            // 
            this.valuesTableSizeN.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.valuesTableSizeN.CausesValidation = false;
            this.valuesTableSizeN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesTableSizeN.Location = new System.Drawing.Point(458, 4);
            this.valuesTableSizeN.MeasureUnit = "";
            this.valuesTableSizeN.Name = "valuesTableSizeN";
            this.valuesTableSizeN.ParameterName = "";
            this.valuesTableSizeN.Size = new System.Drawing.Size(220, 71);
            this.valuesTableSizeN.TabIndex = 2;
            this.valuesTableSizeN.Value = "";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.tableLayoutPanel19, 0, 1);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 2;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(220, 71);
            this.tableLayoutPanel18.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Математическая модель";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel19.Controls.Add(this.helpButtOnMathModelVis, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.mathModelVis, 0, 0);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(214, 40);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // helpButtOnMathModelVis
            // 
            this.helpButtOnMathModelVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpButtOnMathModelVis.Enabled = false;
            this.helpButtOnMathModelVis.Image = global::Researcher.Properties.Resources.helpIcon;
            this.helpButtOnMathModelVis.Location = new System.Drawing.Point(177, 3);
            this.helpButtOnMathModelVis.Name = "helpButtOnMathModelVis";
            this.helpButtOnMathModelVis.Size = new System.Drawing.Size(34, 34);
            this.helpButtOnMathModelVis.TabIndex = 0;
            this.helpButtOnMathModelVis.UseVisualStyleBackColor = true;
            this.helpButtOnMathModelVis.Click += new System.EventHandler(this.helpButtOnMathModelVis_Click);
            // 
            // mathModelVis
            // 
            this.mathModelVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mathModelVis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mathModelVis.FormattingEnabled = true;
            this.mathModelVis.InvalidateIfNoItems = true;
            this.mathModelVis.Location = new System.Drawing.Point(3, 3);
            this.mathModelVis.Name = "mathModelVis";
            this.mathModelVis.Size = new System.Drawing.Size(168, 33);
            this.mathModelVis.TabIndex = 1;
            // 
            // valuesTableSizeM
            // 
            this.valuesTableSizeM.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.valuesTableSizeM.CausesValidation = false;
            this.valuesTableSizeM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesTableSizeM.Location = new System.Drawing.Point(685, 4);
            this.valuesTableSizeM.MeasureUnit = "";
            this.valuesTableSizeM.Name = "valuesTableSizeM";
            this.valuesTableSizeM.ParameterName = "";
            this.valuesTableSizeM.Size = new System.Drawing.Size(220, 71);
            this.valuesTableSizeM.TabIndex = 7;
            this.valuesTableSizeM.Value = "";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.variableParamsVis);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(4, 90);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(909, 395);
            this.groupBox11.TabIndex = 0;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Выберите варьируемые параметры";
            // 
            // variableParamsVis
            // 
            this.variableParamsVis.AutoScroll = true;
            this.variableParamsVis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.variableParamsVis.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.variableParamsVis.Location = new System.Drawing.Point(3, 27);
            this.variableParamsVis.MaxVariableParams = ((long)(2));
            this.variableParamsVis.Name = "variableParamsVis";
            this.variableParamsVis.Size = new System.Drawing.Size(903, 365);
            this.variableParamsVis.TabIndex = 0;
            this.variableParamsVis.WrapContents = false;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel12.Controls.Add(this.buildValuesTableButt, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.build3DPlotButt, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.build2DPlotButt, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(4, 492);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(909, 85);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // buildValuesTableButt
            // 
            this.buildValuesTableButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildValuesTableButt.Enabled = false;
            this.buildValuesTableButt.Location = new System.Drawing.Point(609, 3);
            this.buildValuesTableButt.Name = "buildValuesTableButt";
            this.buildValuesTableButt.Size = new System.Drawing.Size(297, 79);
            this.buildValuesTableButt.TabIndex = 2;
            this.buildValuesTableButt.Text = "Построить таблицу значений";
            this.buildValuesTableButt.UseVisualStyleBackColor = true;
            this.buildValuesTableButt.Click += new System.EventHandler(this.buildValuesTableButt_Click);
            // 
            // build3DPlotButt
            // 
            this.build3DPlotButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.build3DPlotButt.Enabled = false;
            this.build3DPlotButt.Location = new System.Drawing.Point(306, 3);
            this.build3DPlotButt.Name = "build3DPlotButt";
            this.build3DPlotButt.Size = new System.Drawing.Size(297, 79);
            this.build3DPlotButt.TabIndex = 1;
            this.build3DPlotButt.Text = "Построить график поверхности отклика";
            this.build3DPlotButt.UseVisualStyleBackColor = true;
            this.build3DPlotButt.Click += new System.EventHandler(this.build3DPlotButt_Click);
            // 
            // build2DPlotButt
            // 
            this.build2DPlotButt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.build2DPlotButt.Enabled = false;
            this.build2DPlotButt.Location = new System.Drawing.Point(3, 3);
            this.build2DPlotButt.Name = "build2DPlotButt";
            this.build2DPlotButt.Size = new System.Drawing.Size(297, 79);
            this.build2DPlotButt.TabIndex = 0;
            this.build2DPlotButt.Text = "Построить график линий равных значений";
            this.build2DPlotButt.UseVisualStyleBackColor = true;
            this.build2DPlotButt.Click += new System.EventHandler(this.build2DPlotButt_Click);
            // 
            // valuesTablePage
            // 
            this.valuesTablePage.Controls.Add(this.valuesTable);
            this.valuesTablePage.Location = new System.Drawing.Point(4, 34);
            this.valuesTablePage.Name = "valuesTablePage";
            this.valuesTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.valuesTablePage.Size = new System.Drawing.Size(923, 587);
            this.valuesTablePage.TabIndex = 2;
            this.valuesTablePage.Text = "Таблица значений";
            this.valuesTablePage.UseVisualStyleBackColor = true;
            // 
            // valuesTable
            // 
            this.valuesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valuesTable.Location = new System.Drawing.Point(3, 3);
            this.valuesTable.Name = "valuesTable";
            this.valuesTable.Size = new System.Drawing.Size(917, 581);
            this.valuesTable.TabIndex = 1;
            this.valuesTable.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Файлы Excel|*.xlsx";
            // 
            // ResearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(945, 702);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ResearcherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследователь: УИК по оптимизации процесса каталитического риформинга с использов" +
    "анием методов нелинейного программирования";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.optimPage.ResumeLayout(false);
            this.optimPageTab.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.optimResultsPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableOfPath)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.visPage.ResumeLayout(false);
            this.visPageTab.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel23.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.valuesTablePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem saveOptimResultsButt;
        private ToolStripMenuItem saveVisResultsButt;
        private ToolStripMenuItem reloginButt;
        private ToolStripMenuItem exitButt;
        private ToolStripMenuItem aboutButt;
        private ToolStripMenuItem allocatedMemShow;
        private TabControl tabControl1;
        private TabPage optimPage;
        private TabPage visPage;
        private TabControl optimPageTab;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabControl visPageTab;
        private TabPage tabPage7;
        private ToolStripMenuItem toolStripMenuItem1;
        private SaveFileDialog saveFileDialog;
        private TabPage tabPage8;
        private TabPage optimResultsPage;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private InterfaceElements.MasterComboBox plantOptim;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private InterfaceElements.MasterComboBox reactorOptim;
        private GroupBox groupBox3;
        private InputParamsPanel reactorParamsOptim;
        private GroupBox groupBox4;
        private InterfaceElements.MasterComboBox materialOptim;
        private GroupBox groupBox5;
        private InputParamsPanel materialParamsOptim;
        private GroupBox groupBox6;
        private InterfaceElements.MasterComboBox catalystOptim;
        private GroupBox groupBox7;
        private InputParamsPanel catalystParamsOptim;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TargetFuncChoosePanel targetFuncChoosePanel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private VariableParamsChoosePanel variableParamsOptim;
        private Label variableParamsOptimGroupBox;
        private TableLayoutPanel tableLayoutPanel7;
        private StartingPointPanel startingPointOptim;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel13;
        private InterfaceElements.DependentButt build2DPathButt;
        private InterfaceElements.DependentButt startOptimButt;
        private TableLayoutPanel tableLayoutPanel14;
        private InterfaceElements.DependentButt build3DPathButt;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel16;
        private InterfaceElements.MasterComboBox optimMethod;
        private InterfaceElements.DependentButt helpButtOnOptimMethod;
        private TableLayoutPanel tableLayoutPanel17;
        private OptimParamsPanel optimParams;
        private Label label5;
        private SplitContainer splitContainer1;
        private GroupBox groupBox10;
        private DataGridView tableOfPath;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label1;
        private TopDownFlowLayoutPanel optimResultsPanel;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label2;
        private TopDownFlowLayoutPanel optimMetricsPanel;
        private TabPage valuesTablePage;
        private InterfaceElements.ValuesTable valuesTable;
        private TableLayoutPanel tableLayoutPanel22;
        private GroupBox groupBox8;
        private InterfaceElements.MasterComboBox plantVis;
        private TableLayoutPanel tableLayoutPanel23;
        private GroupBox groupBox9;
        private InterfaceElements.MasterComboBox reactorVis;
        private GroupBox groupBox12;
        private InputParamsPanel reactorParamsVis;
        private GroupBox groupBox13;
        private InterfaceElements.MasterComboBox materialVis;
        private GroupBox groupBox14;
        private InputParamsPanel materialParamsVis;
        private GroupBox groupBox15;
        private InterfaceElements.MasterComboBox catalystVis;
        private GroupBox groupBox16;
        private InputParamsPanel catalystParamsVis;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel20;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel21;
        private InterfaceElements.MasterComboBox targetFuncVis;
        private InterfaceElements.ParamsIO.ParameterInput valuesTableSizeN;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel19;
        private InterfaceElements.DependentButt helpButtOnMathModelVis;
        private InterfaceElements.MasterComboBox mathModelVis;
        private InterfaceElements.ParamsIO.ParameterInput valuesTableSizeM;
        private GroupBox groupBox11;
        private VariableParamsChoosePanel variableParamsVis;
        private TableLayoutPanel tableLayoutPanel12;
        private InterfaceElements.DependentButt buildValuesTableButt;
        private InterfaceElements.DependentButt build3DPlotButt;
        private InterfaceElements.DependentButt build2DPlotButt;
    }
}