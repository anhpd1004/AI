namespace AIBigExercise
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phạmDuyAnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.họTênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.trịnhTrườngGiangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyễnĐăngHàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.trầnQuýNgọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoatGame = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnPlayerVsComputer = new System.Windows.Forms.Button();
            this.btnPlayerVsPlayer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChuChay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picRedo = new System.Windows.Forms.PictureBox();
            this.picUndo = new System.Windows.Forms.PictureBox();
            this.panelBoard = new System.Windows.Forms.Panel();
            this.timerChuChay = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.picBay = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBay)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.memberToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.playerVsComToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newGameToolStripMenuItem.Text = "&New game";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "&Player vs Player        Ctrl + N + P";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.PvsP);
            // 
            // playerVsComToolStripMenuItem
            // 
            this.playerVsComToolStripMenuItem.Name = "playerVsComToolStripMenuItem";
            this.playerVsComToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.playerVsComToolStripMenuItem.Text = "&Player vs Com          Ctrl + N + C";
            this.playerVsComToolStripMenuItem.Click += new System.EventHandler(this.PvsC);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "&Exit                Ctrl + Q";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.levelToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.undoToolStripMenuItem.Text = "&Undo        Ctrl + Z";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.redoToolStripMenuItem.Text = "&Redo        Ctrl + Y";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.difficultToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.levelToolStripMenuItem.Text = "&Level";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // difficultToolStripMenuItem
            // 
            this.difficultToolStripMenuItem.Name = "difficultToolStripMenuItem";
            this.difficultToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.difficultToolStripMenuItem.Text = "Difficult";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.tutorialToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tutorialToolStripMenuItem.Text = "&Tutorial";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phạmDuyAnhToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5,
            this.toolStripMenuItem7});
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.memberToolStripMenuItem.Text = "&Member";
            // 
            // phạmDuyAnhToolStripMenuItem
            // 
            this.phạmDuyAnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênToolStripMenuItem,
            this.toolStripMenuItem2});
            this.phạmDuyAnhToolStripMenuItem.Name = "phạmDuyAnhToolStripMenuItem";
            this.phạmDuyAnhToolStripMenuItem.Size = new System.Drawing.Size(80, 22);
            this.phạmDuyAnhToolStripMenuItem.Text = "1";
            // 
            // họTênToolStripMenuItem
            // 
            this.họTênToolStripMenuItem.Name = "họTênToolStripMenuItem";
            this.họTênToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.họTênToolStripMenuItem.Text = "Phạm Duy Anh";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "20155076";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trịnhTrườngGiangToolStripMenuItem,
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            // 
            // trịnhTrườngGiangToolStripMenuItem
            // 
            this.trịnhTrườngGiangToolStripMenuItem.Name = "trịnhTrườngGiangToolStripMenuItem";
            this.trịnhTrườngGiangToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.trịnhTrườngGiangToolStripMenuItem.Text = "Trịnh Trường Giang";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(176, 22);
            this.toolStripMenuItem4.Text = "20155076";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnĐăngHàoToolStripMenuItem,
            this.toolStripMenuItem6});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "3";
            // 
            // nguyễnĐăngHàoToolStripMenuItem
            // 
            this.nguyễnĐăngHàoToolStripMenuItem.Name = "nguyễnĐăngHàoToolStripMenuItem";
            this.nguyễnĐăngHàoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nguyễnĐăngHàoToolStripMenuItem.Text = "Nguyễn Đăng Hào";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(172, 22);
            this.toolStripMenuItem6.Text = "20155076";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trầnQuýNgọcToolStripMenuItem,
            this.toolStripMenuItem8});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "4";
            // 
            // trầnQuýNgọcToolStripMenuItem
            // 
            this.trầnQuýNgọcToolStripMenuItem.Name = "trầnQuýNgọcToolStripMenuItem";
            this.trầnQuýNgọcToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.trầnQuýNgọcToolStripMenuItem.Text = "Trần Quý Ngọc";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem8.Text = "20155076";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AIBigExercise.Properties.Resources.hinhnenCaro;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnThoatGame);
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnPlayerVsComputer);
            this.panel1.Controls.Add(this.btnPlayerVsPlayer);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 490);
            this.panel1.TabIndex = 1;
            // 
            // btnThoatGame
            // 
            this.btnThoatGame.BackColor = System.Drawing.Color.Blue;
            this.btnThoatGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoatGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatGame.ForeColor = System.Drawing.Color.White;
            this.btnThoatGame.Location = new System.Drawing.Point(125, 445);
            this.btnThoatGame.Name = "btnThoatGame";
            this.btnThoatGame.Size = new System.Drawing.Size(75, 35);
            this.btnThoatGame.TabIndex = 5;
            this.btnThoatGame.Text = "Exit";
            this.btnThoatGame.UseVisualStyleBackColor = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Blue;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(40, 445);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 35);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnPlayerVsComputer
            // 
            this.btnPlayerVsComputer.BackColor = System.Drawing.Color.Blue;
            this.btnPlayerVsComputer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerVsComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerVsComputer.ForeColor = System.Drawing.Color.White;
            this.btnPlayerVsComputer.Location = new System.Drawing.Point(40, 403);
            this.btnPlayerVsComputer.Name = "btnPlayerVsComputer";
            this.btnPlayerVsComputer.Size = new System.Drawing.Size(160, 35);
            this.btnPlayerVsComputer.TabIndex = 3;
            this.btnPlayerVsComputer.Text = "Player vs Com";
            this.btnPlayerVsComputer.UseVisualStyleBackColor = false;
            // 
            // btnPlayerVsPlayer
            // 
            this.btnPlayerVsPlayer.BackColor = System.Drawing.Color.Blue;
            this.btnPlayerVsPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlayerVsPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayerVsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayerVsPlayer.ForeColor = System.Drawing.Color.White;
            this.btnPlayerVsPlayer.Location = new System.Drawing.Point(40, 356);
            this.btnPlayerVsPlayer.Name = "btnPlayerVsPlayer";
            this.btnPlayerVsPlayer.Size = new System.Drawing.Size(160, 35);
            this.btnPlayerVsPlayer.TabIndex = 2;
            this.btnPlayerVsPlayer.Text = "Player vs Player";
            this.btnPlayerVsPlayer.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.labelChuChay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luật chơi";
            this.groupBox1.MouseHover += new System.EventHandler(this.groupBox1_MouseHover);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 16);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luật chơi";
            // 
            // labelChuChay
            // 
            this.labelChuChay.AutoSize = true;
            this.labelChuChay.Location = new System.Drawing.Point(12, 155);
            this.labelChuChay.Name = "labelChuChay";
            this.labelChuChay.Size = new System.Drawing.Size(41, 13);
            this.labelChuChay.TabIndex = 0;
            this.labelChuChay.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AIBigExercise.Properties.Resources.hinhnenCaro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.picBay);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.picRedo);
            this.panel2.Controls.Add(this.picUndo);
            this.panel2.Controls.Add(this.panelBoard);
            this.panel2.Location = new System.Drawing.Point(262, 21);
            this.panel2.Margin = new System.Windows.Forms.Padding(12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 490);
            this.panel2.TabIndex = 2;
            // 
            // picRedo
            // 
            this.picRedo.BackColor = System.Drawing.Color.Black;
            this.picRedo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRedo.BackgroundImage")));
            this.picRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRedo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRedo.Location = new System.Drawing.Point(518, 446);
            this.picRedo.Name = "picRedo";
            this.picRedo.Size = new System.Drawing.Size(30, 30);
            this.picRedo.TabIndex = 2;
            this.picRedo.TabStop = false;
            this.picRedo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picRedo_MouseClick);
            // 
            // picUndo
            // 
            this.picUndo.BackColor = System.Drawing.SystemColors.InfoText;
            this.picUndo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUndo.BackgroundImage")));
            this.picUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUndo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUndo.Location = new System.Drawing.Point(12, 446);
            this.picUndo.Name = "picUndo";
            this.picUndo.Size = new System.Drawing.Size(30, 30);
            this.picUndo.TabIndex = 1;
            this.picUndo.TabStop = false;
            this.picUndo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picUndo_MouseClick);
            // 
            // panelBoard
            // 
            this.panelBoard.BackColor = System.Drawing.Color.White;
            this.panelBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBoard.Location = new System.Drawing.Point(80, 45);
            this.panelBoard.Name = "panelBoard";
            this.panelBoard.Size = new System.Drawing.Size(401, 401);
            this.panelBoard.TabIndex = 0;
            this.panelBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoard_Paint);
            this.panelBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBoard_MouseClick);
            // 
            // timerChuChay
            // 
            this.timerChuChay.Interval = 30;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(48, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "bay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBay
            // 
            this.picBay.BackgroundImage = global::AIBigExercise.Properties.Resources.yasuo;
            this.picBay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBay.Location = new System.Drawing.Point(3, 388);
            this.picBay.Name = "picBay";
            this.picBay.Size = new System.Drawing.Size(38, 50);
            this.picBay.TabIndex = 8;
            this.picBay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AIBigExercise.Properties.Resources.hinhnenCaro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThoatGame;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnPlayerVsComputer;
        private System.Windows.Forms.Button btnPlayerVsPlayer;
        private System.Windows.Forms.Panel panelBoard;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phạmDuyAnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem họTênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem trịnhTrườngGiangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem nguyễnĐăngHàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem trầnQuýNgọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem difficultToolStripMenuItem;
        private System.Windows.Forms.Label labelChuChay;
        private System.Windows.Forms.Timer timerChuChay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picRedo;
        private System.Windows.Forms.PictureBox picUndo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBay;
    }
}

