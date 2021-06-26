using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using WMPLib;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Input;

namespace Breadboard
{
    public partial class Form1 : Form
    {
        List<Bread> bread = new List<Bread>();
        Debug debug = new Debug(true);
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
        bool macroChanging = false;
        Bread selectedBread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (readXml() == false)
                {
                    /*Bread mimi = new Bread("miyeon", "D:\\Téléchargement\\MiyeonPIPOU.mp3");
                    Bread yabur = new Bread("yabur", "D:\\Téléchargement\\renge-yabure-kabure-original.mp3");
                    bread.Add(mimi);
                    bread.Add(yabur);*/
                    Bread pause = new Bread("pause", "", Key.RightCtrl, Key.P);
                    Bread test = new Bread("congratulations", "congratulations.mp3", Key.LeftShift, Key.Q);
                    bread.Add(pause);
                    bread.Add(test);
                    debug.msgbox("First bread init complete");
                }
            }catch(Exception a)
            {
                    
            }

            init();
            saveXml();
            macroInit();
        }
        private void macroInit()
        {
            mac.Interval = 200;
            mac.Start();
        }
        private void restart()
        {
            Application.Restart();
            Environment.Exit(0);
        }
        private void init()
        {
            macroChanging = false;
            boxSettings.Visible = false;
            boxMacro.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            int i = 0;
            foreach (Bread croissant in bread)
            {
                if(croissant.getName() != "pause")
                {
                    Button btn = new Button();

                    ContextMenu cm = new ContextMenu();

                    cm.MenuItems.Add("Change macro");

                    btn.Name = "bread" + i;
                    //btn.Text = bread[i].getName() + "     " + bread[i].getMacro().getKey1() + " + " + bread[i].getMacro().getKey2();
                    btn.Text = croissant.getName();
                    btn.Tag = i;
                    btn.Height = 100;
                    btn.Width = 100;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = Color.White;
                    btn.ContextMenu = cm;
                    cm.MenuItems[0].Click += new EventHandler(ChangeMacro_Click);
                    btn.Click += new EventHandler(Bread_Click);

                    btn.Paint += new PaintEventHandler((sender, e) =>
                    {
                        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        e.Graphics.DrawString(croissant.getMacro().getKey1() + " + " + croissant.getMacro().getKey2(), Font, Brushes.White, 3, 5);
                    });

                    flowLayoutPanel1.Controls.Add(btn);
                    i++;
                }
            }
            Button btnAdd = new Button();
            btnAdd.Name = "breadAdd";
            btnAdd.Text = "Add Sound";
            btnAdd.Tag = bread.Count() + 1;
            btnAdd.Height = 100;
            btnAdd.Width = 100;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Click += new EventHandler(BreadAdd_Click);
            flowLayoutPanel1.Controls.Add(btnAdd);


        }

        private void ChangeMacro_Click(object sender, EventArgs e)
        {
            macroChanging = true;
            boxMacro.Visible = true;
            comboKey1.Enabled = false;
            comboKey2.Enabled = false;
            btnSaveMacro.Enabled = false;
        }

        protected void Bread_Click(object sender, EventArgs e)
        {
            string name;
            name = sender.ToString();
            name = name.Substring(35, name.Length-35);

            Bread lostBread = bread.Find(x => x.getName() == name);

            if (macroChanging)
            {
                debug.println("macro Changing");
                boxMacro.Visible = false;
                selectedBread = lostBread;
                debug.println(selectedBread.getName());
                boxMacro.Visible = true;
            }
            else
            {
                wplayer.URL = lostBread.getPath();
                wplayer.controls.play();
            }
        }
        protected void BreadAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.DefaultExt = "mp3";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            openFileDialog1.Title = "Choose your bread music file";
            this.openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            foreach (String file in openFileDialog1.FileNames)
            {
                if(file.Substring(file.Length - 14, 10) != "penFileDia")
                {
                    Bread melonPan = new Bread(file.Substring(file.Length - 14, 10), file, Key.LeftShift, Key.Q);
                    bread.Add(melonPan);
                }

            }
            
            saveXml();
            restart();
        }
        private void saveXml()
        {
            if (!File.Exists("saved.xml"))
            {
                File.Create("saved.xml");
                Application.Restart();
                Environment.Exit(0);
            }
            File.SetAttributes("saved.xml", FileAttributes.Normal);
            using (FileStream fs = new FileStream("saved.xml", FileMode.Create))
            {
                using (XmlWriter w = XmlWriter.Create(fs))
                {
                    int i = 0;
                    w.WriteStartElement("bread");
                    foreach (Bread mmh in bread)
                    {
                        
                        w.WriteElementString("name"+i, mmh.getName());
                        w.WriteElementString("path"+i, mmh.getPath());
                        w.WriteElementString("key1-" + i, mmh.getMacro().getKey1().ToString());
                        w.WriteElementString("key2-" + i, mmh.getMacro().getKey2().ToString());
                        i++;
                    }
                    w.WriteEndElement();
                    w.Flush();
                }
            }
        }
        private bool readXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("saved.xml");
            bool ex = false;
            Key ky1, ky2;
            for(int i = 0; i < 999; i++){
                try
                {
                    XmlNode nodeN = doc.DocumentElement.SelectSingleNode("name" + i);
                    string name = nodeN.InnerText;

                    XmlNode nodeP = doc.DocumentElement.SelectSingleNode("path" + i);
                    string path = nodeP.InnerText;

                    XmlNode nodeK1 = doc.DocumentElement.SelectSingleNode("key1-" + i);
                    string key1 = nodeK1.InnerText;

                    XmlNode nodeK2 = doc.DocumentElement.SelectSingleNode("key2-" + i);
                    string key2 = nodeK2.InnerText;
                    Enum.TryParse(key1, out ky1);
                    Enum.TryParse(key2, out ky2);
                    Bread baguette = new Bread(name, path, ky1, ky2);

                    bread.Add(baguette);
                }
                catch(Exception e)
                {
                    break;
                }
                ex = true;
            }
            return ex;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mac_Tick(object sender, EventArgs e)
        {
            foreach (Bread chocolatine in bread) {
                if (Keyboard.IsKeyDown(chocolatine.getMacro().getKey1()) && Keyboard.IsKeyDown(chocolatine.getMacro().getKey2()))
                {
                    if(chocolatine.getName() == "pause")
                    {
                        wplayer.controls.pause();
                    }
                    else
                    {
                        wplayer.URL = chocolatine.getPath();
                        wplayer.controls.play();
                    }

                }
            }
        }
        private void btnSaveMacro_Click(object sender, EventArgs e)
        {
            Key kay1, kay2;
            Enum.TryParse(comboKey1.Text, out kay1);
            Enum.TryParse(comboKey2.Text, out kay2);
            selectedBread.getMacro().setKey1(kay1);
            selectedBread.getMacro().setKey2(kay2);
            saveXml();
            restart();
        }

        private void comboKey2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboKey1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            macroChanging = true;
            boxMacro.Visible = true;
            comboKey1.Enabled = false;
            comboKey2.Enabled = false;
            btnSaveMacro.Enabled = false;
        }

        private void btnCloseMacro_Click(object sender, EventArgs e)
        {
            macroChanging = false;
            boxMacro.Visible = false;
        }

        private void boxMacro_VisibleChanged(object sender, EventArgs e)
        {
            if(selectedBread != null)
            {
                comboKey1.Enabled = true;
                comboKey2.Enabled = true;
                btnSaveMacro.Enabled = true;
                debug.println("slBread != null == " + selectedBread.getName());
                labelMacro.Text = selectedBread.getName();
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Key kay1, kay2;
            Enum.TryParse(comboKeySettings1.Text, out kay1);
            Enum.TryParse(comboKeySettings2.Text, out kay2);
            bread[0].getMacro().setKey1(kay1);
            bread[0].getMacro().setKey2(kay2);
            saveXml();
            restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            labPause1.Text = bread[0].getMacro().getKey1().ToString() + " +";
            labPause2.Text = bread[0].getMacro().getKey2().ToString();
            boxSettings.Visible = true;
        }

        private void btnCloseSettings_Click(object sender, EventArgs e)
        {
            boxSettings.Visible = false;
        }

        private void boxSettings_Enter(object sender, EventArgs e)
        {

        }
    }
}
