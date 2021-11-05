namespace Draw_Figures
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btPenColor = new System.Windows.Forms.Button();
            this.CDpen = new System.Windows.Forms.ColorDialog();
            this.udx = new System.Windows.Forms.NumericUpDown();
            this.udy = new System.Windows.Forms.NumericUpDown();
            this.udW = new System.Windows.Forms.NumericUpDown();
            this.udH = new System.Windows.Forms.NumericUpDown();
            this.cbFigure = new System.Windows.Forms.ComboBox();
            this.Lx = new System.Windows.Forms.Label();
            this.Ly = new System.Windows.Forms.Label();
            this.Lw = new System.Windows.Forms.Label();
            this.Lh = new System.Windows.Forms.Label();
            this.btBrushColor = new System.Windows.Forms.Button();
            this.CDbrush = new System.Windows.Forms.ColorDialog();
            this.Lthikness = new System.Windows.Forms.Label();
            this.udT = new System.Windows.Forms.NumericUpDown();
            this.chPen = new System.Windows.Forms.CheckBox();
            this.chBrush = new System.Windows.Forms.CheckBox();
            this.p2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.p1 = new System.Windows.Forms.Panel();
            this.tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.p4 = new System.Windows.Forms.Panel();
            this.btClearTb = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btUndo = new System.Windows.Forms.Button();
            this.p_coord = new System.Windows.Forms.Panel();
            this.btClear = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Panel();
            this.btDraw = new System.Windows.Forms.Button();
            this.sfdPoints = new System.Windows.Forms.SaveFileDialog();
            this.ofdPoints = new System.Windows.Forms.OpenFileDialog();
            this.SS = new System.Windows.Forms.StatusStrip();
            this.tSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS = new System.Windows.Forms.ToolStrip();
            this.tsddbtC = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbtPic = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSaveP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddbtXml = new System.Windows.Forms.ToolStripDropDownButton();
            this.btSaveXml = new System.Windows.Forms.ToolStripMenuItem();
            this.btLoadXml = new System.Windows.Forms.ToolStripMenuItem();
            this.PB = new System.Windows.Forms.PictureBox();
            this.ofdXML = new System.Windows.Forms.OpenFileDialog();
            this.sfdXML = new System.Windows.Forms.SaveFileDialog();
            this.sfdPic = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.udx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udT)).BeginInit();
            this.p1.SuspendLayout();
            this.p4.SuspendLayout();
            this.p_coord.SuspendLayout();
            this.p3.SuspendLayout();
            this.SS.SuspendLayout();
            this.TS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // btPenColor
            // 
            this.btPenColor.Image = global::Draw_Figures.Properties.Resources.color_wheel;
            this.btPenColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btPenColor.Location = new System.Drawing.Point(3, 99);
            this.btPenColor.Name = "btPenColor";
            this.btPenColor.Size = new System.Drawing.Size(98, 37);
            this.btPenColor.TabIndex = 5;
            this.btPenColor.Text = "Цвет пера";
            this.btPenColor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btPenColor.UseVisualStyleBackColor = true;
            this.btPenColor.Click += new System.EventHandler(this.btPenColor_Click);
            // 
            // udx
            // 
            this.udx.Location = new System.Drawing.Point(63, 2);
            this.udx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udx.Name = "udx";
            this.udx.Size = new System.Drawing.Size(40, 20);
            this.udx.TabIndex = 7;
            this.udx.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // udy
            // 
            this.udy.Location = new System.Drawing.Point(62, 31);
            this.udy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udy.Name = "udy";
            this.udy.Size = new System.Drawing.Size(40, 20);
            this.udy.TabIndex = 8;
            this.udy.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // udW
            // 
            this.udW.Location = new System.Drawing.Point(62, 82);
            this.udW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udW.Name = "udW";
            this.udW.Size = new System.Drawing.Size(40, 20);
            this.udW.TabIndex = 9;
            this.udW.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // udH
            // 
            this.udH.Location = new System.Drawing.Point(62, 108);
            this.udH.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udH.Name = "udH";
            this.udH.Size = new System.Drawing.Size(40, 20);
            this.udH.TabIndex = 10;
            this.udH.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cbFigure
            // 
            this.cbFigure.DisplayMember = "0";
            this.cbFigure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFigure.FormattingEnabled = true;
            this.cbFigure.Location = new System.Drawing.Point(28, 34);
            this.cbFigure.Name = "cbFigure";
            this.cbFigure.Size = new System.Drawing.Size(103, 21);
            this.cbFigure.TabIndex = 11;
            this.cbFigure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Lx
            // 
            this.Lx.AutoSize = true;
            this.Lx.BackColor = System.Drawing.Color.White;
            this.Lx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lx.Location = new System.Drawing.Point(19, 4);
            this.Lx.Name = "Lx";
            this.Lx.Size = new System.Drawing.Size(16, 15);
            this.Lx.TabIndex = 12;
            this.Lx.Text = "X";
            // 
            // Ly
            // 
            this.Ly.AutoSize = true;
            this.Ly.BackColor = System.Drawing.Color.White;
            this.Ly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ly.Location = new System.Drawing.Point(19, 32);
            this.Ly.Name = "Ly";
            this.Ly.Size = new System.Drawing.Size(16, 15);
            this.Ly.TabIndex = 13;
            this.Ly.Text = "Y";
            // 
            // Lw
            // 
            this.Lw.AutoSize = true;
            this.Lw.BackColor = System.Drawing.Color.White;
            this.Lw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lw.Location = new System.Drawing.Point(2, 110);
            this.Lw.Name = "Lw";
            this.Lw.Size = new System.Drawing.Size(47, 15);
            this.Lw.TabIndex = 14;
            this.Lw.Text = "Высота";
            // 
            // Lh
            // 
            this.Lh.AutoSize = true;
            this.Lh.BackColor = System.Drawing.Color.White;
            this.Lh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lh.Location = new System.Drawing.Point(2, 84);
            this.Lh.Name = "Lh";
            this.Lh.Size = new System.Drawing.Size(48, 15);
            this.Lh.TabIndex = 15;
            this.Lh.Text = "Ширина";
            // 
            // btBrushColor
            // 
            this.btBrushColor.Image = global::Draw_Figures.Properties.Resources.color_wheel;
            this.btBrushColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btBrushColor.Location = new System.Drawing.Point(3, 142);
            this.btBrushColor.Name = "btBrushColor";
            this.btBrushColor.Size = new System.Drawing.Size(98, 37);
            this.btBrushColor.TabIndex = 16;
            this.btBrushColor.Text = "Цвет заливки";
            this.btBrushColor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btBrushColor.UseVisualStyleBackColor = true;
            this.btBrushColor.Click += new System.EventHandler(this.btBrushColor_Click);
            // 
            // Lthikness
            // 
            this.Lthikness.AutoSize = true;
            this.Lthikness.BackColor = System.Drawing.Color.White;
            this.Lthikness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lthikness.Location = new System.Drawing.Point(14, 188);
            this.Lthikness.Name = "Lthikness";
            this.Lthikness.Size = new System.Drawing.Size(84, 15);
            this.Lthikness.TabIndex = 17;
            this.Lthikness.Text = "Ширина линии:";
            // 
            // udT
            // 
            this.udT.Location = new System.Drawing.Point(110, 186);
            this.udT.Name = "udT";
            this.udT.Size = new System.Drawing.Size(41, 20);
            this.udT.TabIndex = 18;
            this.udT.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // chPen
            // 
            this.chPen.AutoSize = true;
            this.chPen.Location = new System.Drawing.Point(104, 110);
            this.chPen.Name = "chPen";
            this.chPen.Size = new System.Drawing.Size(76, 17);
            this.chPen.TabIndex = 20;
            this.chPen.Text = "без цвета";
            this.chPen.UseVisualStyleBackColor = true;
            // 
            // chBrush
            // 
            this.chBrush.AutoSize = true;
            this.chBrush.Checked = true;
            this.chBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBrush.Location = new System.Drawing.Point(104, 152);
            this.chBrush.Name = "chBrush";
            this.chBrush.Size = new System.Drawing.Size(76, 17);
            this.chBrush.TabIndex = 21;
            this.chBrush.Text = "без цвета";
            this.chBrush.UseVisualStyleBackColor = true;
            // 
            // p2
            // 
            this.p2.BackColor = System.Drawing.Color.White;
            this.p2.Enabled = false;
            this.p2.Location = new System.Drawing.Point(6, 165);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(92, 11);
            this.p2.TabIndex = 25;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(22, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "без цвета";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.Black;
            this.p1.Controls.Add(this.checkBox1);
            this.p1.Enabled = false;
            this.p1.Location = new System.Drawing.Point(6, 123);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(92, 11);
            this.p1.TabIndex = 25;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(37, 12);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(103, 131);
            this.tb.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(42, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Изображение";
            // 
            // p4
            // 
            this.p4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p4.Controls.Add(this.btClearTb);
            this.p4.Controls.Add(this.btRefresh);
            this.p4.Controls.Add(this.btUndo);
            this.p4.Controls.Add(this.p_coord);
            this.p4.Controls.Add(this.tb);
            this.p4.Controls.Add(this.btClear);
            this.p4.Location = new System.Drawing.Point(524, 26);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(175, 316);
            this.p4.TabIndex = 28;
            // 
            // btClearTb
            // 
            this.btClearTb.Location = new System.Drawing.Point(37, 120);
            this.btClearTb.Name = "btClearTb";
            this.btClearTb.Size = new System.Drawing.Size(103, 23);
            this.btClearTb.TabIndex = 30;
            this.btClearTb.Text = "Очистить список";
            this.btClearTb.UseVisualStyleBackColor = true;
            this.btClearTb.Visible = false;
            this.btClearTb.Click += new System.EventHandler(this.btClearTb_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Image = global::Draw_Figures.Properties.Resources.arrow_refresh;
            this.btRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRefresh.Location = new System.Drawing.Point(90, 188);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(80, 35);
            this.btRefresh.TabIndex = 29;
            this.btRefresh.Text = "Обновить";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btUndo
            // 
            this.btUndo.Image = global::Draw_Figures.Properties.Resources.arrow_redo;
            this.btUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUndo.Location = new System.Drawing.Point(7, 188);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(80, 35);
            this.btUndo.TabIndex = 28;
            this.btUndo.Text = "Отменить";
            this.btUndo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUndo.UseVisualStyleBackColor = true;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // p_coord
            // 
            this.p_coord.Controls.Add(this.Lh);
            this.p_coord.Controls.Add(this.Lw);
            this.p_coord.Controls.Add(this.Ly);
            this.p_coord.Controls.Add(this.Lx);
            this.p_coord.Controls.Add(this.udH);
            this.p_coord.Controls.Add(this.udW);
            this.p_coord.Controls.Add(this.udy);
            this.p_coord.Controls.Add(this.udx);
            this.p_coord.Location = new System.Drawing.Point(37, 12);
            this.p_coord.Name = "p_coord";
            this.p_coord.Size = new System.Drawing.Size(103, 131);
            this.p_coord.TabIndex = 26;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btClear.Font = new System.Drawing.Font("Jokerman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Image = global::Draw_Figures.Properties.Resources.bin_empty;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btClear.Location = new System.Drawing.Point(37, 232);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(103, 63);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Очистить все";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // p3
            // 
            this.p3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Controls.Add(this.chBrush);
            this.p3.Controls.Add(this.label1);
            this.p3.Controls.Add(this.p1);
            this.p3.Controls.Add(this.p2);
            this.p3.Controls.Add(this.cbFigure);
            this.p3.Controls.Add(this.chPen);
            this.p3.Controls.Add(this.btDraw);
            this.p3.Controls.Add(this.udT);
            this.p3.Controls.Add(this.Lthikness);
            this.p3.Controls.Add(this.btBrushColor);
            this.p3.Controls.Add(this.btPenColor);
            this.p3.Location = new System.Drawing.Point(0, 26);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(175, 316);
            this.p3.TabIndex = 29;
            // 
            // btDraw
            // 
            this.btDraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btDraw.Image = global::Draw_Figures.Properties.Resources.pencil;
            this.btDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDraw.Location = new System.Drawing.Point(28, 247);
            this.btDraw.Name = "btDraw";
            this.btDraw.Size = new System.Drawing.Size(102, 30);
            this.btDraw.TabIndex = 6;
            this.btDraw.Text = "Рисовать";
            this.btDraw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // sfdPoints
            // 
            this.sfdPoints.DefaultExt = "txt";
            this.sfdPoints.FileName = "Points";
            this.sfdPoints.Filter = "Текстовый файл | *.txt | Все файлы | *.*";
            // 
            // ofdPoints
            // 
            this.ofdPoints.DefaultExt = "txt";
            this.ofdPoints.Filter = "Текстовый файл|*.txt|Все файлы|*.*";
            this.ofdPoints.Title = "Выберите файл с координатами";
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL});
            this.SS.Location = new System.Drawing.Point(0, 342);
            this.SS.Name = "SS";
            this.SS.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.SS.Size = new System.Drawing.Size(699, 22);
            this.SS.TabIndex = 30;
            this.SS.Text = "statusStrip1";
            this.SS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tSSL
            // 
            this.tSSL.Name = "tSSL";
            this.tSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // TS
            // 
            this.TS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbtC,
            this.toolStripSeparator1,
            this.tsddbtPic,
            this.toolStripSeparator2,
            this.tsddbtXml});
            this.TS.Location = new System.Drawing.Point(0, 0);
            this.TS.Name = "TS";
            this.TS.Size = new System.Drawing.Size(699, 25);
            this.TS.TabIndex = 31;
            this.TS.Text = "toolStrip1";
            this.TS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TS_ItemClicked);
            // 
            // tsddbtC
            // 
            this.tsddbtC.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave,
            this.btLoad});
            this.tsddbtC.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtC.Image")));
            this.tsddbtC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtC.Name = "tsddbtC";
            this.tsddbtC.Size = new System.Drawing.Size(104, 22);
            this.tsddbtC.Text = "Координаты";
            // 
            // btSave
            // 
            this.btSave.Image = global::Draw_Figures.Properties.Resources.arrow_down;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(133, 22);
            this.btSave.Text = "Сохранить";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Image = global::Draw_Figures.Properties.Resources.arrow_up;
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(133, 22);
            this.btLoad.Text = "Загрузить";
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbtPic
            // 
            this.tsddbtPic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSaveP});
            this.tsddbtPic.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtPic.Image")));
            this.tsddbtPic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtPic.Name = "tsddbtPic";
            this.tsddbtPic.Size = new System.Drawing.Size(112, 22);
            this.tsddbtPic.Text = "Изображение";
            // 
            // btSaveP
            // 
            this.btSaveP.Image = global::Draw_Figures.Properties.Resources.arrow_down;
            this.btSaveP.Name = "btSaveP";
            this.btSaveP.Size = new System.Drawing.Size(180, 22);
            this.btSaveP.Text = "Сохранить";
            this.btSaveP.Click += new System.EventHandler(this.btSaveP_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsddbtXml
            // 
            this.tsddbtXml.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSaveXml,
            this.btLoadXml});
            this.tsddbtXml.Image = ((System.Drawing.Image)(resources.GetObject("tsddbtXml.Image")));
            this.tsddbtXml.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbtXml.Name = "tsddbtXml";
            this.tsddbtXml.Size = new System.Drawing.Size(57, 22);
            this.tsddbtXml.Text = "Xml";
            // 
            // btSaveXml
            // 
            this.btSaveXml.Image = global::Draw_Figures.Properties.Resources.arrow_down;
            this.btSaveXml.Name = "btSaveXml";
            this.btSaveXml.Size = new System.Drawing.Size(133, 22);
            this.btSaveXml.Text = "Сохранить";
            this.btSaveXml.Click += new System.EventHandler(this.btSaveXml_Click_1);
            // 
            // btLoadXml
            // 
            this.btLoadXml.Image = global::Draw_Figures.Properties.Resources.arrow_up;
            this.btLoadXml.Name = "btLoadXml";
            this.btLoadXml.Size = new System.Drawing.Size(133, 22);
            this.btLoadXml.Text = "Загрузить";
            this.btLoadXml.Click += new System.EventHandler(this.btLoadXml_Click);
            // 
            // PB
            // 
            this.PB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PB.BackColor = System.Drawing.Color.White;
            this.PB.Location = new System.Drawing.Point(174, 26);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(351, 316);
            this.PB.TabIndex = 0;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            this.PB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PB_MouseClick);
            this.PB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MouseMove);
            // 
            // ofdXML
            // 
            this.ofdXML.DefaultExt = "xml";
            this.ofdXML.Filter = "xml файл|*.xml|Все файлы|*.*";
            // 
            // sfdXML
            // 
            this.sfdXML.DefaultExt = "xml";
            this.sfdXML.FileName = "xml_file";
            this.sfdXML.Filter = "xml файл|*.xml|Все файлы|*.*";
            // 
            // sfdPic
            // 
            this.sfdPic.DefaultExt = "png";
            this.sfdPic.FileName = "pic";
            this.sfdPic.Filter = "png файл|*.png|Все файлы|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(699, 364);
            this.Controls.Add(this.TS);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.PB);
            this.Name = "MainForm";
            this.Text = "Фигуры";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.udx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udT)).EndInit();
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            this.p4.ResumeLayout(false);
            this.p4.PerformLayout();
            this.p_coord.ResumeLayout(false);
            this.p_coord.PerformLayout();
            this.p3.ResumeLayout(false);
            this.p3.PerformLayout();
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.TS.ResumeLayout(false);
            this.TS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button btPenColor;
        private System.Windows.Forms.ColorDialog CDpen;
        private System.Windows.Forms.Button btDraw;
        private System.Windows.Forms.NumericUpDown udx;
        private System.Windows.Forms.NumericUpDown udW;
        private System.Windows.Forms.NumericUpDown udH;
        private System.Windows.Forms.ComboBox cbFigure;
        private System.Windows.Forms.NumericUpDown udy;
        private System.Windows.Forms.Label Lx;
        private System.Windows.Forms.Label Ly;
        private System.Windows.Forms.Label Lw;
        private System.Windows.Forms.Label Lh;
        private System.Windows.Forms.Button btBrushColor;
        private System.Windows.Forms.ColorDialog CDbrush;
        private System.Windows.Forms.Label Lthikness;
        private System.Windows.Forms.NumericUpDown udT;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.CheckBox chPen;
        private System.Windows.Forms.CheckBox chBrush;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p4;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p_coord;
        private System.Windows.Forms.SaveFileDialog sfdPoints;
        private System.Windows.Forms.OpenFileDialog ofdPoints;
        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStrip TS;
        private System.Windows.Forms.ToolStripStatusLabel tSSL;
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtC;
        private System.Windows.Forms.ToolStripMenuItem btSave;
        private System.Windows.Forms.ToolStripMenuItem btLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtPic;
        private System.Windows.Forms.ToolStripMenuItem btSaveP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog ofdXML;
        private System.Windows.Forms.SaveFileDialog sfdXML;
        private System.Windows.Forms.ToolStripDropDownButton tsddbtXml;
        private System.Windows.Forms.ToolStripMenuItem btSaveXml;
        private System.Windows.Forms.ToolStripMenuItem btLoadXml;
        private System.Windows.Forms.Button btClearTb;
        private System.Windows.Forms.SaveFileDialog sfdPic;
    }
}

