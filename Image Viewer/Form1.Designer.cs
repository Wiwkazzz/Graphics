namespace Image_Viewer
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RadioButtonNormal = new System.Windows.Forms.RadioButton();
            this.RadioButtonStretch = new System.Windows.Forms.RadioButton();
            this.RadioButtonCenter = new System.Windows.Forms.RadioButton();
            this.RadioButtonZoom = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветокоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StaticColorCorect = new System.Windows.Forms.ToolStripMenuItem();
            this.линейнаяКоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectorMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.операторСобеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гауссовскоеРазмытиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Akvarel = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtunEmboss = new System.Windows.Forms.ToolStripMenuItem();
            this.BlackWhiteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PovorotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологическиеОперацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BinarImageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DilationButton = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ArrialButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioButtonPen = new System.Windows.Forms.RadioButton();
            this.RadioButtonLine = new System.Windows.Forms.RadioButton();
            this.RadioButtonRectangle = new System.Windows.Forms.RadioButton();
            this.RadioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RadioButtonText = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioButtonNormal
            // 
            this.RadioButtonNormal.AutoSize = true;
            this.RadioButtonNormal.Checked = true;
            this.RadioButtonNormal.Location = new System.Drawing.Point(3, 3);
            this.RadioButtonNormal.Name = "RadioButtonNormal";
            this.RadioButtonNormal.Size = new System.Drawing.Size(63, 17);
            this.RadioButtonNormal.TabIndex = 1;
            this.RadioButtonNormal.TabStop = true;
            this.RadioButtonNormal.Text = "Normal";
            this.RadioButtonNormal.UseVisualStyleBackColor = true;
            this.RadioButtonNormal.CheckedChanged += new System.EventHandler(this.RadioButtonNormal_CheckedChanged);
            // 
            // RadioButtonStretch
            // 
            this.RadioButtonStretch.AutoSize = true;
            this.RadioButtonStretch.Location = new System.Drawing.Point(3, 49);
            this.RadioButtonStretch.Name = "RadioButtonStretch";
            this.RadioButtonStretch.Size = new System.Drawing.Size(60, 17);
            this.RadioButtonStretch.TabIndex = 2;
            this.RadioButtonStretch.Text = "Stretch";
            this.RadioButtonStretch.UseVisualStyleBackColor = true;
            this.RadioButtonStretch.CheckedChanged += new System.EventHandler(this.RadioButtonStretch_CheckedChanged);
            // 
            // RadioButtonCenter
            // 
            this.RadioButtonCenter.AutoSize = true;
            this.RadioButtonCenter.Location = new System.Drawing.Point(3, 72);
            this.RadioButtonCenter.Name = "RadioButtonCenter";
            this.RadioButtonCenter.Size = new System.Drawing.Size(58, 17);
            this.RadioButtonCenter.TabIndex = 3;
            this.RadioButtonCenter.Text = "Center";
            this.RadioButtonCenter.UseVisualStyleBackColor = true;
            this.RadioButtonCenter.CheckedChanged += new System.EventHandler(this.RadioButtonCenter_CheckedChanged);
            // 
            // RadioButtonZoom
            // 
            this.RadioButtonZoom.AutoSize = true;
            this.RadioButtonZoom.Location = new System.Drawing.Point(3, 26);
            this.RadioButtonZoom.Name = "RadioButtonZoom";
            this.RadioButtonZoom.Size = new System.Drawing.Size(55, 17);
            this.RadioButtonZoom.TabIndex = 4;
            this.RadioButtonZoom.Text = "Zoom";
            this.RadioButtonZoom.UseVisualStyleBackColor = true;
            this.RadioButtonZoom.CheckedChanged += new System.EventHandler(this.RadioButtonZoom_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileButton,
            this.AboutButton,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1181, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileButton
            // 
            this.FileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.SaveButton,
            this.clearToolStripMenuItem,
            this.ExitButton});
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(38, 20);
            this.FileButton.Text = "File";
            // 
            // OpenButton
            // 
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(180, 22);
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(180, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "Delete all";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(180, 22);
            this.ExitButton.Text = "Exit";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUsButton});
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(53, 20);
            this.AboutButton.Text = "About";
            // 
            // AboutUsButton
            // 
            this.AboutUsButton.Name = "AboutUsButton";
            this.AboutUsButton.Size = new System.Drawing.Size(123, 22);
            this.AboutUsButton.Text = "About us";
            this.AboutUsButton.Click += new System.EventHandler(this.AboutUsButton_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цветокоррекцияToolStripMenuItem,
            this.фильтрToolStripMenuItem,
            this.PovorotToolStripMenuItem,
            this.морфологическиеОперацииToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // цветокоррекцияToolStripMenuItem
            // 
            this.цветокоррекцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StaticColorCorect,
            this.линейнаяКоррекцияToolStripMenuItem,
            this.reflectorMenuStrip});
            this.цветокоррекцияToolStripMenuItem.Name = "цветокоррекцияToolStripMenuItem";
            this.цветокоррекцияToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.цветокоррекцияToolStripMenuItem.Text = "Цветокоррекция ";
            // 
            // StaticColorCorect
            // 
            this.StaticColorCorect.Name = "StaticColorCorect";
            this.StaticColorCorect.Size = new System.Drawing.Size(269, 22);
            this.StaticColorCorect.Text = "Статистическая цветокоррекция ";
            this.StaticColorCorect.Click += new System.EventHandler(this.StaticColorCorect_Click);
            // 
            // линейнаяКоррекцияToolStripMenuItem
            // 
            this.линейнаяКоррекцияToolStripMenuItem.Name = "линейнаяКоррекцияToolStripMenuItem";
            this.линейнаяКоррекцияToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.линейнаяКоррекцияToolStripMenuItem.Text = "Линейная коррекция";
            this.линейнаяКоррекцияToolStripMenuItem.Click += new System.EventHandler(this.линейнаяКоррекцияToolStripMenuItem_Click);
            // 
            // reflectorMenuStrip
            // 
            this.reflectorMenuStrip.Name = "reflectorMenuStrip";
            this.reflectorMenuStrip.Size = new System.Drawing.Size(269, 22);
            this.reflectorMenuStrip.Text = "Идеальный отражатель";
            this.reflectorMenuStrip.Click += new System.EventHandler(this.reflectorMenuStrip_Click);
            // 
            // фильтрToolStripMenuItem
            // 
            this.фильтрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операторСобеляToolStripMenuItem,
            this.гауссовскоеРазмытиеToolStripMenuItem,
            this.Akvarel,
            this.ButtunEmboss,
            this.BlackWhiteButton});
            this.фильтрToolStripMenuItem.Name = "фильтрToolStripMenuItem";
            this.фильтрToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.фильтрToolStripMenuItem.Text = "Фильтр";
            // 
            // операторСобеляToolStripMenuItem
            // 
            this.операторСобеляToolStripMenuItem.Name = "операторСобеляToolStripMenuItem";
            this.операторСобеляToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.операторСобеляToolStripMenuItem.Text = "Оператор Собеля";
            this.операторСобеляToolStripMenuItem.Click += new System.EventHandler(this.операторСобеляToolStripMenuItem_Click);
            // 
            // гауссовскоеРазмытиеToolStripMenuItem
            // 
            this.гауссовскоеРазмытиеToolStripMenuItem.Name = "гауссовскоеРазмытиеToolStripMenuItem";
            this.гауссовскоеРазмытиеToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.гауссовскоеРазмытиеToolStripMenuItem.Text = "Гауссовское размытие";
            this.гауссовскоеРазмытиеToolStripMenuItem.Click += new System.EventHandler(this.гауссовскоеРазмытиеToolStripMenuItem_Click);
            // 
            // Akvarel
            // 
            this.Akvarel.Name = "Akvarel";
            this.Akvarel.Size = new System.Drawing.Size(205, 22);
            this.Akvarel.Text = "Эффект Акварели";
            this.Akvarel.Visible = false;
            this.Akvarel.Click += new System.EventHandler(this.Akvarel_Click);
            // 
            // ButtunEmboss
            // 
            this.ButtunEmboss.Name = "ButtunEmboss";
            this.ButtunEmboss.Size = new System.Drawing.Size(205, 22);
            this.ButtunEmboss.Text = "Emboss";
            this.ButtunEmboss.Click += new System.EventHandler(this.ButtunEmboss_Click);
            // 
            // BlackWhiteButton
            // 
            this.BlackWhiteButton.Name = "BlackWhiteButton";
            this.BlackWhiteButton.Size = new System.Drawing.Size(205, 22);
            this.BlackWhiteButton.Text = "Черно-белое";
            this.BlackWhiteButton.Click += new System.EventHandler(this.BlackWhiteButton_Click);
            // 
            // PovorotToolStripMenuItem
            // 
            this.PovorotToolStripMenuItem.Name = "PovorotToolStripMenuItem";
            this.PovorotToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.PovorotToolStripMenuItem.Text = "Поворот";
            this.PovorotToolStripMenuItem.Click += new System.EventHandler(this.PovorotToolStripMenuItem_Click);
            // 
            // морфологическиеОперацииToolStripMenuItem
            // 
            this.морфологическиеОперацииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BinarImageButton,
            this.DilationButton,
            this.erosionButton});
            this.морфологическиеОперацииToolStripMenuItem.Name = "морфологическиеОперацииToolStripMenuItem";
            this.морфологическиеОперацииToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.морфологическиеОперацииToolStripMenuItem.Text = "Морфологические Операции";
            // 
            // BinarImageButton
            // 
            this.BinarImageButton.Name = "BinarImageButton";
            this.BinarImageButton.Size = new System.Drawing.Size(241, 22);
            this.BinarImageButton.Text = "Преобразование в бинарное";
            this.BinarImageButton.Click += new System.EventHandler(this.BinarImageButton_Click);
            // 
            // DilationButton
            // 
            this.DilationButton.Name = "DilationButton";
            this.DilationButton.Size = new System.Drawing.Size(241, 22);
            this.DilationButton.Text = "Расширение(dilation)";
            this.DilationButton.Click += new System.EventHandler(this.DilationButton_Click);
            // 
            // erosionButton
            // 
            this.erosionButton.Name = "erosionButton";
            this.erosionButton.Size = new System.Drawing.Size(241, 22);
            this.erosionButton.Text = "Сужение(erosion)";
            this.erosionButton.Click += new System.EventHandler(this.erosionButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.RadioButtonNormal);
            this.flowLayoutPanel1.Controls.Add(this.RadioButtonZoom);
            this.flowLayoutPanel1.Controls.Add(this.RadioButtonStretch);
            this.flowLayoutPanel1.Controls.Add(this.RadioButtonCenter);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(83, 109);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.ColorButton);
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button3);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.ChangeColorButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(96, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(113, 109);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Red;
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(3, 3);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(30, 30);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.UseVisualStyleBackColor = false;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(39, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(75, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(39, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(75, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.Silver;
            this.ChangeColorButton.Location = new System.Drawing.Point(3, 75);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(57, 30);
            this.ChangeColorButton.TabIndex = 6;
            this.ChangeColorButton.Text = "Change";
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.trackBar1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 118);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(205, 57);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Толщина кисти";
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(3, 16);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(201, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбор кисти";
            // 
            // ArrialButton
            // 
            this.ArrialButton.Location = new System.Drawing.Point(85, 52);
            this.ArrialButton.Name = "ArrialButton";
            this.ArrialButton.Size = new System.Drawing.Size(56, 23);
            this.ArrialButton.TabIndex = 7;
            this.ArrialButton.Text = "Font";
            this.ArrialButton.UseVisualStyleBackColor = true;
            this.ArrialButton.Visible = false;
            this.ArrialButton.Click += new System.EventHandler(this.ArrialButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(968, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 764);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.label2);
            this.flowLayoutPanel4.Controls.Add(this.RadioButtonPen);
            this.flowLayoutPanel4.Controls.Add(this.RadioButtonLine);
            this.flowLayoutPanel4.Controls.Add(this.RadioButtonRectangle);
            this.flowLayoutPanel4.Controls.Add(this.RadioButtonEllipse);
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.RadioButtonText);
            this.flowLayoutPanel4.Controls.Add(this.ArrialButton);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 181);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(205, 164);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // RadioButtonPen
            // 
            this.RadioButtonPen.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonPen.BackgroundImage = global::Image_Viewer.Properties.Resources.pen1;
            this.RadioButtonPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadioButtonPen.Location = new System.Drawing.Point(3, 16);
            this.RadioButtonPen.Name = "RadioButtonPen";
            this.RadioButtonPen.Size = new System.Drawing.Size(30, 30);
            this.RadioButtonPen.TabIndex = 1;
            this.RadioButtonPen.UseVisualStyleBackColor = true;
            this.RadioButtonPen.CheckedChanged += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            this.RadioButtonPen.Click += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            // 
            // RadioButtonLine
            // 
            this.RadioButtonLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonLine.BackgroundImage = global::Image_Viewer.Properties.Resources.Line1;
            this.RadioButtonLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadioButtonLine.Location = new System.Drawing.Point(3, 52);
            this.RadioButtonLine.Name = "RadioButtonLine";
            this.RadioButtonLine.Size = new System.Drawing.Size(30, 30);
            this.RadioButtonLine.TabIndex = 4;
            this.RadioButtonLine.UseVisualStyleBackColor = true;
            this.RadioButtonLine.Click += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            // 
            // RadioButtonRectangle
            // 
            this.RadioButtonRectangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonRectangle.BackgroundImage = global::Image_Viewer.Properties.Resources.rect1;
            this.RadioButtonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadioButtonRectangle.Location = new System.Drawing.Point(3, 88);
            this.RadioButtonRectangle.Name = "RadioButtonRectangle";
            this.RadioButtonRectangle.Size = new System.Drawing.Size(30, 30);
            this.RadioButtonRectangle.TabIndex = 2;
            this.RadioButtonRectangle.UseVisualStyleBackColor = true;
            this.RadioButtonRectangle.Click += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            // 
            // RadioButtonEllipse
            // 
            this.RadioButtonEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonEllipse.BackgroundImage = global::Image_Viewer.Properties.Resources.ellipse;
            this.RadioButtonEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadioButtonEllipse.Location = new System.Drawing.Point(3, 124);
            this.RadioButtonEllipse.Name = "RadioButtonEllipse";
            this.RadioButtonEllipse.Size = new System.Drawing.Size(30, 30);
            this.RadioButtonEllipse.TabIndex = 5;
            this.RadioButtonEllipse.UseVisualStyleBackColor = true;
            this.RadioButtonEllipse.Click += new System.EventHandler(this.RadioButtonPen_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Текст";
            // 
            // RadioButtonText
            // 
            this.RadioButtonText.Appearance = System.Windows.Forms.Appearance.Button;
            this.RadioButtonText.BackgroundImage = global::Image_Viewer.Properties.Resources.text;
            this.RadioButtonText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RadioButtonText.Location = new System.Drawing.Point(85, 16);
            this.RadioButtonText.Name = "RadioButtonText";
            this.RadioButtonText.Size = new System.Drawing.Size(30, 30);
            this.RadioButtonText.TabIndex = 6;
            this.RadioButtonText.UseVisualStyleBackColor = true;
            this.RadioButtonText.CheckedChanged += new System.EventHandler(this.RadioButtonText_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(968, 764);
            this.panel2.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(863, 729);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 762);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RadioButtonNormal;
        private System.Windows.Forms.RadioButton RadioButtonCenter;
        private System.Windows.Forms.RadioButton RadioButtonZoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileButton;
        private System.Windows.Forms.ToolStripMenuItem OpenButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem AboutUsButton;
        private System.Windows.Forms.RadioButton RadioButtonStretch;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RadioButtonPen;
        private System.Windows.Forms.RadioButton RadioButtonRectangle;
        private System.Windows.Forms.RadioButton RadioButtonLine;
        private System.Windows.Forms.RadioButton RadioButtonEllipse;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RadioButton RadioButtonText;
        private System.Windows.Forms.Button ArrialButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветокоррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StaticColorCorect;
        private System.Windows.Forms.ToolStripMenuItem линейнаяКоррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гауссовскоеРазмытиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операторСобеляToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem reflectorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ButtunEmboss;
        private System.Windows.Forms.ToolStripMenuItem Akvarel;
        private System.Windows.Forms.ToolStripMenuItem PovorotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem морфологическиеОперацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DilationButton;
        private System.Windows.Forms.ToolStripMenuItem erosionButton;
        private System.Windows.Forms.ToolStripMenuItem BinarImageButton;
        private System.Windows.Forms.ToolStripMenuItem BlackWhiteButton;
    }
}

