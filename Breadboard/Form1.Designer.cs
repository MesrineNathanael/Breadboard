
namespace Breadboard
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mac = new System.Windows.Forms.Timer(this.components);
            this.boxMacro = new System.Windows.Forms.GroupBox();
            this.labelMacro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCloseMacro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboKey2 = new System.Windows.Forms.ComboBox();
            this.comboKey1 = new System.Windows.Forms.ComboBox();
            this.btnSaveMacro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.boxSettings = new System.Windows.Forms.GroupBox();
            this.labPause2 = new System.Windows.Forms.Label();
            this.labPause1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboKeySettings2 = new System.Windows.Forms.ComboBox();
            this.comboKeySettings1 = new System.Windows.Forms.ComboBox();
            this.btnCloseSettings = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.boxRename = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxRename = new System.Windows.Forms.TextBox();
            this.btnCloseRename = new System.Windows.Forms.Button();
            this.btnSaveRename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.boxMacro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.boxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.boxRename.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(557, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(663, 603);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bread board";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Settings";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Exit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(54)))));
            this.pictureBox5.Image = global::Breadboard.Properties.Resources._1621318;
            this.pictureBox5.Location = new System.Drawing.Point(1129, 533);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 64);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Breadboard.Properties.Resources.téléchargement;
            this.pictureBox4.Location = new System.Drawing.Point(10, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(163, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.Image = global::Breadboard.Properties.Resources._6163208;
            this.pictureBox3.Location = new System.Drawing.Point(10, 556);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Breadboard.Properties.Resources._6163187;
            this.pictureBox2.Location = new System.Drawing.Point(10, 166);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Breadboard.Properties.Resources._6285098;
            this.pictureBox1.Location = new System.Drawing.Point(10, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mac
            // 
            this.mac.Tick += new System.EventHandler(this.mac_Tick);
            // 
            // boxMacro
            // 
            this.boxMacro.Controls.Add(this.labelMacro);
            this.boxMacro.Controls.Add(this.label6);
            this.boxMacro.Controls.Add(this.btnCloseMacro);
            this.boxMacro.Controls.Add(this.label4);
            this.boxMacro.Controls.Add(this.comboKey2);
            this.boxMacro.Controls.Add(this.comboKey1);
            this.boxMacro.Controls.Add(this.btnSaveMacro);
            this.boxMacro.ForeColor = System.Drawing.Color.White;
            this.boxMacro.Location = new System.Drawing.Point(194, 12);
            this.boxMacro.Name = "boxMacro";
            this.boxMacro.Size = new System.Drawing.Size(163, 279);
            this.boxMacro.TabIndex = 0;
            this.boxMacro.TabStop = false;
            this.boxMacro.Text = "Change macro";
            this.boxMacro.VisibleChanged += new System.EventHandler(this.boxMacro_VisibleChanged);
            // 
            // labelMacro
            // 
            this.labelMacro.AutoSize = true;
            this.labelMacro.Location = new System.Drawing.Point(59, 89);
            this.labelMacro.Name = "labelMacro";
            this.labelMacro.Size = new System.Drawing.Size(44, 13);
            this.labelMacro.TabIndex = 6;
            this.labelMacro.Text = "Nothing";
            this.labelMacro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Changing macro of : ";
            // 
            // btnCloseMacro
            // 
            this.btnCloseMacro.ForeColor = System.Drawing.Color.Black;
            this.btnCloseMacro.Location = new System.Drawing.Point(30, 248);
            this.btnCloseMacro.Name = "btnCloseMacro";
            this.btnCloseMacro.Size = new System.Drawing.Size(106, 23);
            this.btnCloseMacro.TabIndex = 4;
            this.btnCloseMacro.Text = "Close";
            this.btnCloseMacro.UseVisualStyleBackColor = true;
            this.btnCloseMacro.Click += new System.EventHandler(this.btnCloseMacro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select the sound where you\r\nwant to change his macro\r\nby selecting him.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboKey2
            // 
            this.comboKey2.FormattingEnabled = true;
            this.comboKey2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboKey2.Location = new System.Drawing.Point(30, 177);
            this.comboKey2.Name = "comboKey2";
            this.comboKey2.Size = new System.Drawing.Size(106, 21);
            this.comboKey2.TabIndex = 2;
            this.comboKey2.SelectedIndexChanged += new System.EventHandler(this.comboKey2_SelectedIndexChanged);
            // 
            // comboKey1
            // 
            this.comboKey1.FormattingEnabled = true;
            this.comboKey1.Items.AddRange(new object[] {
            "LeftAlt",
            "LeftCtrl",
            "LeftShift",
            "RightAlt",
            "RightCtrl",
            "RightShift"});
            this.comboKey1.Location = new System.Drawing.Point(30, 129);
            this.comboKey1.Name = "comboKey1";
            this.comboKey1.Size = new System.Drawing.Size(106, 21);
            this.comboKey1.TabIndex = 1;
            this.comboKey1.SelectedIndexChanged += new System.EventHandler(this.comboKey1_SelectedIndexChanged);
            // 
            // btnSaveMacro
            // 
            this.btnSaveMacro.ForeColor = System.Drawing.Color.Black;
            this.btnSaveMacro.Location = new System.Drawing.Point(30, 219);
            this.btnSaveMacro.Name = "btnSaveMacro";
            this.btnSaveMacro.Size = new System.Drawing.Size(106, 23);
            this.btnSaveMacro.TabIndex = 0;
            this.btnSaveMacro.Text = "Save";
            this.btnSaveMacro.UseVisualStyleBackColor = true;
            this.btnSaveMacro.Click += new System.EventHandler(this.btnSaveMacro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Macro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Breadboard.Properties.Resources._6163187;
            this.pictureBox6.Location = new System.Drawing.Point(10, 215);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // boxSettings
            // 
            this.boxSettings.Controls.Add(this.labPause2);
            this.boxSettings.Controls.Add(this.labPause1);
            this.boxSettings.Controls.Add(this.label8);
            this.boxSettings.Controls.Add(this.btnSaveSettings);
            this.boxSettings.Controls.Add(this.label7);
            this.boxSettings.Controls.Add(this.comboKeySettings2);
            this.boxSettings.Controls.Add(this.comboKeySettings1);
            this.boxSettings.Controls.Add(this.btnCloseSettings);
            this.boxSettings.ForeColor = System.Drawing.Color.White;
            this.boxSettings.Location = new System.Drawing.Point(371, 12);
            this.boxSettings.Name = "boxSettings";
            this.boxSettings.Size = new System.Drawing.Size(163, 279);
            this.boxSettings.TabIndex = 10;
            this.boxSettings.TabStop = false;
            this.boxSettings.Text = "Settings";
            this.boxSettings.Enter += new System.EventHandler(this.boxSettings_Enter);
            // 
            // labPause2
            // 
            this.labPause2.AutoSize = true;
            this.labPause2.Location = new System.Drawing.Point(105, 32);
            this.labPause2.Name = "labPause2";
            this.labPause2.Size = new System.Drawing.Size(49, 13);
            this.labPause2.TabIndex = 10;
            this.labPause2.Text = "lablablab";
            // 
            // labPause1
            // 
            this.labPause1.AutoSize = true;
            this.labPause1.Location = new System.Drawing.Point(51, 32);
            this.labPause1.Name = "labPause1";
            this.labPause1.Size = new System.Drawing.Size(49, 13);
            this.labPause1.TabIndex = 9;
            this.labPause1.Text = "lablablab";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "actual :";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSettings.Location = new System.Drawing.Point(30, 219);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(106, 23);
            this.btnSaveSettings.TabIndex = 7;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pause macro keys :";
            // 
            // comboKeySettings2
            // 
            this.comboKeySettings2.FormattingEnabled = true;
            this.comboKeySettings2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "D1",
            "D2",
            "D3",
            "D4",
            "D5",
            "D6",
            "D7",
            "D8",
            "D9",
            "D0",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.comboKeySettings2.Location = new System.Drawing.Point(29, 75);
            this.comboKeySettings2.Name = "comboKeySettings2";
            this.comboKeySettings2.Size = new System.Drawing.Size(106, 21);
            this.comboKeySettings2.TabIndex = 7;
            // 
            // comboKeySettings1
            // 
            this.comboKeySettings1.FormattingEnabled = true;
            this.comboKeySettings1.Items.AddRange(new object[] {
            "LeftAlt",
            "LeftCtrl",
            "LeftShift",
            "RightAlt",
            "RightCtrl",
            "RightShift"});
            this.comboKeySettings1.Location = new System.Drawing.Point(29, 48);
            this.comboKeySettings1.Name = "comboKeySettings1";
            this.comboKeySettings1.Size = new System.Drawing.Size(106, 21);
            this.comboKeySettings1.TabIndex = 7;
            // 
            // btnCloseSettings
            // 
            this.btnCloseSettings.ForeColor = System.Drawing.Color.Black;
            this.btnCloseSettings.Location = new System.Drawing.Point(30, 248);
            this.btnCloseSettings.Name = "btnCloseSettings";
            this.btnCloseSettings.Size = new System.Drawing.Size(106, 23);
            this.btnCloseSettings.TabIndex = 7;
            this.btnCloseSettings.Text = "Close";
            this.btnCloseSettings.UseVisualStyleBackColor = true;
            this.btnCloseSettings.Click += new System.EventHandler(this.btnCloseSettings_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Meiryo UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(48, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Rename";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Breadboard.Properties.Resources._6163187;
            this.pictureBox7.Location = new System.Drawing.Point(10, 262);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // boxRename
            // 
            this.boxRename.Controls.Add(this.btnCloseRename);
            this.boxRename.Controls.Add(this.txtBoxRename);
            this.boxRename.Controls.Add(this.btnSaveRename);
            this.boxRename.Controls.Add(this.label10);
            this.boxRename.ForeColor = System.Drawing.Color.White;
            this.boxRename.Location = new System.Drawing.Point(194, 298);
            this.boxRename.Name = "boxRename";
            this.boxRename.Size = new System.Drawing.Size(163, 279);
            this.boxRename.TabIndex = 13;
            this.boxRename.TabStop = false;
            this.boxRename.Text = "Rename";
            this.boxRename.Enter += new System.EventHandler(this.boxRename_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 39);
            this.label10.TabIndex = 4;
            this.label10.Text = "Select the sound you\r\nwant to rename\r\nby selecting him.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxRename
            // 
            this.txtBoxRename.Location = new System.Drawing.Point(16, 78);
            this.txtBoxRename.Name = "txtBoxRename";
            this.txtBoxRename.Size = new System.Drawing.Size(136, 20);
            this.txtBoxRename.TabIndex = 9;
            // 
            // btnCloseRename
            // 
            this.btnCloseRename.ForeColor = System.Drawing.Color.Black;
            this.btnCloseRename.Location = new System.Drawing.Point(30, 250);
            this.btnCloseRename.Name = "btnCloseRename";
            this.btnCloseRename.Size = new System.Drawing.Size(106, 23);
            this.btnCloseRename.TabIndex = 8;
            this.btnCloseRename.Text = "Close";
            this.btnCloseRename.UseVisualStyleBackColor = true;
            this.btnCloseRename.Click += new System.EventHandler(this.btnCloseRename_Click);
            // 
            // btnSaveRename
            // 
            this.btnSaveRename.ForeColor = System.Drawing.Color.Black;
            this.btnSaveRename.Location = new System.Drawing.Point(30, 221);
            this.btnSaveRename.Name = "btnSaveRename";
            this.btnSaveRename.Size = new System.Drawing.Size(106, 23);
            this.btnSaveRename.TabIndex = 7;
            this.btnSaveRename.Text = "Save";
            this.btnSaveRename.UseVisualStyleBackColor = true;
            this.btnSaveRename.Click += new System.EventHandler(this.btnSaveRename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(1220, 603);
            this.Controls.Add(this.boxRename);
            this.Controls.Add(this.boxSettings);
            this.Controls.Add(this.boxMacro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bread board";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.boxMacro.ResumeLayout(false);
            this.boxMacro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.boxSettings.ResumeLayout(false);
            this.boxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.boxRename.ResumeLayout(false);
            this.boxRename.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer mac;
        private System.Windows.Forms.GroupBox boxMacro;
        private System.Windows.Forms.ComboBox comboKey2;
        private System.Windows.Forms.ComboBox comboKey1;
        private System.Windows.Forms.Button btnSaveMacro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnCloseMacro;
        private System.Windows.Forms.Label labelMacro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox boxSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboKeySettings2;
        private System.Windows.Forms.ComboBox comboKeySettings1;
        private System.Windows.Forms.Button btnCloseSettings;
        private System.Windows.Forms.Label labPause2;
        private System.Windows.Forms.Label labPause1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.GroupBox boxRename;
        private System.Windows.Forms.Button btnCloseRename;
        private System.Windows.Forms.TextBox txtBoxRename;
        private System.Windows.Forms.Button btnSaveRename;
        private System.Windows.Forms.Label label10;
    }
}

