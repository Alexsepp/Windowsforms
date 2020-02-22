using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Vytas
{
    public partial class Form2 : Form
    {
        Label lbl;
        Button btn;
        Panel panel;
        TreeView treeView;
        TreeNode treeNode;
        CheckBox checkBox1, checkBox2, checkBox3;
        RadioButton rb1,rb2,rb3;
        ListBox lbox;
        RichTextBox rtbox;
        
        public int m = 10;

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            //InitializeComponent();
            this.Text = "Форма с разными элементами управления";
            this.Size = new Size { Height = 800, Width = 800 };

            treeView = new TreeView();
            treeView.BackColor = Color.Chocolate;
            treeView.Dock = DockStyle.Left;
            treeView.Width = 150;
            treeView.Font = new Font("Comic SANS", 10);
            treeNode = new TreeNode("Элемент управления");
            treeNode.Expand();
            treeNode.Nodes.Add(new TreeNode("Label"));
            treeNode.Nodes.Add(new TreeNode("Button"));
            treeNode.Nodes.Add(new TreeNode("CheckBox Флажок"));
            treeNode.Nodes.Add(new TreeNode("RadioButton-переключатель"));
            treeNode.Nodes.Add(new TreeNode("TabControl"));
            treeNode.Nodes.Add(new TreeNode("Listbox-spisok"));
            treeNode.Nodes.Add(new TreeNode("RichTextBox-SmartText"));
            treeNode.Nodes.Add(new TreeNode("Clear Очистить"));

            treeView.Nodes.Add(treeNode);
            treeView.AfterSelect += TreeView_AfterSelect;
            Controls.Add(treeView);

            panel = new Panel();
            panel.Dock = DockStyle.Right;
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Width = this.Width - treeView.Width;
            panel.Height = this.Height;
            panel.BackColor = Color.BurlyWood;
            Controls.Add(panel);

            lbl = new Label
            {
                Text = "Это метка.\nВторая строка метки",
                ForeColor = Color.Black,
            };

            btn = new Button
            {
                Text = "LB To RTB",
                ForeColor = Color.Black,
                BackColor = Color.Chocolate,
                FlatStyle = FlatStyle.Flat,
                Width = 100
            };
            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += (sender, e) => 
            {
            };

            checkBox1 = new CheckBox
            {
                Text = "red",
            };
            checkBox2 = new CheckBox
            {
                Text = "blue",
            };
            checkBox3 = new CheckBox
            {
                Text = "green",
            };
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Label")
            {
                lbl.Width = lbl.Text.Length * 10;
                lbl.Height = 20 * 5;
                lbl.Font = new Font("Arial", 20);

                lbl.Location = new Point(panel.Width / 2 - lbl.Text.Length * 5, m);
                panel.Controls.Add(lbl);
            }
            else if (e.Node.Text == "Button")
            {
                btn.Location = new Point(200,250);
                panel.Controls.Add(btn);
            }
            else if (e.Node.Text == "CheckBox Флажок")
            {

                checkBox1.Location = new Point(15,m*2+83);
                checkBox2.Location = new Point(15,m*2+103);
                checkBox3.Height = 100;
                checkBox3.Image = global::WindowsForms_Vytas.Properties.Resources.sad;
                checkBox3.Location = new Point(15,m*2+123);
                panel.Controls.Add(checkBox1);
                panel.Controls.Add(checkBox2);
                panel.Controls.Add(checkBox3);
                checkBox3.Click += CheckBox3_Click;

            }
            else if(e.Node.Text== "RadioButton-переключатель")
            {
                rb1 = new RadioButton();
                rb1.Text = "1";
                rb1.Location = new Point(15, m * 2 + 223);
                rb2 = new RadioButton();
                rb2.Text = "2";
                rb2.Location = new Point(15, m * 2 + 243);
                rb3 = new RadioButton();
                rb3.Text = "3";
                rb3.Location = new Point(15, m * 2 + 263);

                panel.Controls.Add(rb1);
                panel.Controls.Add(rb2);
                panel.Controls.Add(rb3);
                //rb1.Click += Rb1_Click;
                rb2.Click += Rb2_Click;
                rb3.Click += Rb3_Click;

            }
            else if (e.Node.Text == "TabControl")
            {
                TabControl tc = new TabControl();
                tc.Size = new Size(500, 400);
                tc.Location = new Point(20,300);
                TabPage tp1 = new TabPage("Dog");
                PictureBox pbox1 = new PictureBox();
                pbox1.Image = new Bitmap("..//..//images//dog.jpg");
                pbox1.Size = new Size(400, 300);
                pbox1.SizeMode = PictureBoxSizeMode.StretchImage;
                TabPage tp2 = new TabPage("Dog house");
                PictureBox pbox2 = new PictureBox();
                pbox2.Image = new Bitmap("..//..//images//dog_house.jpg");
                pbox2.Size = new Size(400, 300);
                pbox2.SizeMode = PictureBoxSizeMode.StretchImage;
                
                tp1.Controls.Add(pbox1);
                tp2.Controls.Add(pbox2);
                tc.TabPages.Add(tp1);
                tc.TabPages.Add(tp2);
                panel.Controls.Add(tc);
            }
            else if(e.Node.Text== "Listbox-spisok")
            {
                lbox= new ListBox();
                lbox.Items.Add("Green");
                lbox.Items.Add("Yellow");
                lbox.Items.Add("Cyan");
                lbox.Items.Add("Red");
                lbox.Location = new Point(200,150);
                lbox.Height = 80;
                panel.Controls.Add(lbox);

                lbox.SelectedIndexChanged += new EventHandler(lbox_SelectedIndexChanged);
            }
            else if(e.Node.Text== "RichTextBox-SmartText")
            {
                rtbox = new RichTextBox();
                rtbox.LoadFile("..//..//images//TextFile1.txt", RichTextBoxStreamType.PlainText); 
                rtbox.WordWrap = true;
                rtbox.BorderStyle = BorderStyle.Fixed3D;
                rtbox.Size = new Size(100, 100);
                rtbox.Location = new Point(200, 300);
                panel.Controls.Add(rtbox);
                
                
            }
            else
            {
                panel.Controls.Clear();
            }
        }
        private void Rtbox_DoubleClick(object sender,EventArgs e)
        {
            //rtbox.SaveFile("..//..//images//TextFile1.txt", RichTextBoxStreamType.PlainText);
            //FileDialog.WriteAllText(@"C:\Users\opilane\source\repos\WindowsForms_Vytas\WindowsForms_Vytas\images\TextFile1.txt", rtbox.Text, Encoding.UTF8);
        }
        private void lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox.SelectedIndex)
            {
                case (0):treeView.BackColor = Color.Green;break;
                case (1):treeView.BackColor = Color.Yellow;break;
                case (2):treeView.BackColor = Color.Cyan;break;
                case (3):treeView.BackColor = Color.Red;break;
            }
        }

        private void CheckBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void Rb3_Click(object sender, EventArgs e)
        {
            treeView.Visible = true;
        }

        private void Rb2_Click(object sender, EventArgs e)
        {
            treeView.Visible=false ;
        }
    }
}
