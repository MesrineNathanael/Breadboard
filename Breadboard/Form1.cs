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

namespace Breadboard
{
    public partial class Form1 : Form
    {
        List<Bread> bread = new List<Bread>();
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
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
                    Bread yabur = new Bread("yabure", "D:\\Téléchargement\\renge-yabure-kabure-original.mp3");
                    bread.Add(mimi);
                    bread.Add(yabur);*/
                    Bread test = new Bread("congratulations", "congratulations.mp3");
                    bread.Add(test);
                    MessageBox.Show("First bread init complete");
                }
            }catch(Exception a)
            {
                    
            }

            init();
            saveXml();
        }

        private void init()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < bread.Count; i++)
            {
                Button btn = new Button();
                btn.Name = "bread" + i;
                btn.Text = bread[i].getName();
                btn.Tag = i;
                btn.Height = 100;
                btn.Width = 100;
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Click += new EventHandler(Bread_Click);
                flowLayoutPanel1.Controls.Add(btn);
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
        protected void Bread_Click(object sender, EventArgs e)
        {
            string name;
            name = sender.ToString();
            name = name.Substring(35, name.Length-35);

            Bread lostBread = bread.Find(x => x.getName() == name);
            //MessageBox.Show("good bread " + lostBread.getName());

            wplayer.URL = lostBread.getPath();
            wplayer.controls.play();
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
                Bread melonPan = new Bread(file.Substring(file.Length-14, 10), file);
                bread.Add(melonPan);
                
            }
            
            saveXml();
            Application.Restart();
            Environment.Exit(0);
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
            for(int i = 0; i < 999; i++){
                try
                {
                    XmlNode nodeN = doc.DocumentElement.SelectSingleNode("name" + i);
                    string name = nodeN.InnerText;

                    XmlNode nodeP = doc.DocumentElement.SelectSingleNode("path" + i);
                    string path = nodeP.InnerText;

                    Bread baguette = new Bread(name, path);
                    //MessageBox.Show("baguette " + name);
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
    }
}
