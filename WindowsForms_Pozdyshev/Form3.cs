using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsForms_Alex
{
    public partial class Form3 : Form
    {
        Panel panel;
        Button btn, btn2, btn3, btn4;
        CheckBox check1, check2, check3;
        Form form;
        Label lbl1, lbl2;
        RadioButton rb1, rb2, rb3, rb4, rb5, rb6, rb7;

        

        ListBox lbox2, lbox3;
        RichTextBox rtbox;
        int i = 0;
        int ii = 0;

        public Form3()
        {
            this.Text = "Расписание";
            this.Size = new Size(425, 350);
            this.BackColor = Color.NavajoWhite;
            this.Font = new Font("Arial", 12);

            lbox2 = new ListBox();
            lbox2.Width = 100;

            lbox2.Items.Add("Понедельник");
            lbox2.Items.Add("Вторник");
            lbox2.Items.Add("Среда");
            lbox2.Items.Add("Четверг");
            lbox2.Items.Add("Пятница");
            lbox2.Items.Add("Суббота");
            lbox2.Items.Add("Воскресенье");

            lbox2.Location = new Point(5, 10);
            lbox2.Height = 160;
            lbox2.Width = 110;
            lbox2.BorderStyle = BorderStyle.Fixed3D;

            lbox3 = new ListBox();
            lbox3.Location = new Point(125, 10);
            lbox3.Height = 160;
            lbox3.Width = 160;
            lbox3.BorderStyle = BorderStyle.Fixed3D;
            lbox3.Width = 100;
            panel = new Panel();
            panel.Dock = DockStyle.Right;
            panel.BackColor = Color.Gray;
            panel.Width = 400;
            panel.Height = 400;

            rtbox = new RichTextBox();

            rtbox.WordWrap = true;
            rtbox.BorderStyle = BorderStyle.Fixed3D;

            rtbox.Size = new Size(290, 90);
            rtbox.Location = new Point(5, 170);


            Button btn5 = new Button();
            btn5.Text = "Очистить";
            btn5.Location = new Point(5, 270);
            btn5.ForeColor = Color.Navy;
            btn5.BackColor = Color.AntiqueWhite;
            btn5.Width = 100;
            btn5.Height = 30;


            Button btn6 = new Button();
            btn6.Text = "Открыть";
            btn6.Location = new Point(110, 270);
            btn6.ForeColor = Color.Navy;
            btn6.BackColor = Color.AntiqueWhite;
            btn6.Width = 80;
            btn6.Height = 30;

            Button btn7 = new Button();
            btn7.Text = "Сохранить";
            btn7.Location = new Point(195, 270);
            btn7.ForeColor = Color.Navy;
            btn7.BackColor = Color.AntiqueWhite;
            btn7.Width = 100;
            btn7.Height = 30;

            Button btn8 = new Button();
            btn8.Text = "Добавить";
            btn8.Location = new Point(305, 50);
            btn8.ForeColor = Color.Navy;
            btn8.BackColor = Color.AntiqueWhite;
            btn8.Width = 100;
            btn8.Height = 30;

            Button btn9 = new Button();
            btn9.Text = "Удалить";
            btn9.Location = new Point(305, 85);
            btn9.ForeColor = Color.Navy;
            btn9.BackColor = Color.AntiqueWhite;
            btn9.Width = 100;
            btn9.Height = 30;


            btn5.Click += Btn5_Click;
            btn7.Click += Btn7_Click;
            btn6.Click += Btn6_Click;
            btn8.Click += Btn8_Click;
            btn9.Click += Btn9_Click;

            lbox2.DoubleClick += LBox2_DoubleClick;
            lbox3.SelectedIndexChanged += Lbox3_SelectedIndexChanged;
            lbox3.DoubleClick += Lbox3_DoubleClick;
            lbox2.SelectedIndexChanged += LBox2_SelectedIndexChanged;



            Controls.Add(panel);
            panel.Controls.Add(lbox2);
            panel.Controls.Add(lbox3);
            panel.Controls.Add(rtbox);
            panel.Controls.Add(btn5);
            panel.Controls.Add(btn6);
            panel.Controls.Add(btn7);
            panel.Controls.Add(btn8);
            panel.Controls.Add(btn9);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {

            lbox3.Items.Remove(lbox3.SelectedItem.ToString());
            rtbox.Clear();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            //lbox3.Items.Add(rtbox.Text.ToString());
            if (i == 1)
            {
                lbox3.Items.Add("Эстонский");
            }
            if (ii == 1)
            {

                lbox3.Items.Add("Эстонский");
                lbox3.Items.Remove(lbox3.SelectedItem.ToString());

            }

        }

        private void Lbox3_DoubleClick(object sender, EventArgs e)
        {
            // понедельник
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 0)
            {
                i = 1;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                    " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 1)
            {
                i = 2;
                rtbox.Text = "Мультимедиа - данные, или содержание, которое одновременно передаётся в разных формах: " +
                    "звук, анимированная компьютерная графика, видеоряд. Например," +
                    " в одном объекте-контейнере может содержаться текстовая, звуковая, графическая и видеоинформация," +
                    " а также, возможно, способ интерактивного взаимодействия с ней. Это достигается использованием определённого набора аппаратных и программных средств.";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 2)
            {
                i = 3;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                    " Английский язык — важнейший международный язык," +
                    " что является следствием колониальной политики Британской империи в XIX веке " +
                    "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 3)
            {
                i = 4;
                rtbox.Text = "Физика- область естествознания: наука о простейших и вместе с тем наиболее общих законах природы, " +
                    "о материи, её структуре и движении. Законы физики лежат в основе всего естествознания";
            }

            // вторник
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 0)
            {
                i = 21;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
                    " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 1)
            {
                i = 22;
                rtbox.Text = "Биология -  наука о живых существах и их взаимодействии со средой обитания." +
                    " Изучает все аспекты жизни, в частности, структуру, функционирование, рост, происхождение, " +
                    "эволюцию и распределение живых организмов на Земле. Классифицирует и описывает живые существа," +
                    " происхождение их видов, взаимодействие между собой и с окружающей средой.";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 2)
            {
                i = 23;
                rtbox.Text = "Русский язык - один из восточнославянских языков, национальный язык русского народа." +
                    " Является одним из наиболее распространённых языков мира — " +
                    "шестым среди всех языков мира по общей численности говорящих и восьмым по численности владеющих им как родным";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 3)
            {
                i = 24;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                      " Английский язык — важнейший международный язык," +
                      " что является следствием колониальной политики Британской империи в XIX веке " +
                      "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }

            // среда
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 0)
            {
                i = 31;
                rtbox.Text = "Мультимедиа - данные, или содержание, которое одновременно передаётся в разных формах: " +
                      "звук, анимированная компьютерная графика, видеоряд. Например," +
                      " в одном объекте-контейнере может содержаться текстовая, звуковая, графическая и видеоинформация," +
                      " а также, возможно, способ интерактивного взаимодействия с ней. Это достигается использованием определённого набора аппаратных и программных средств.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 1)
            {
                i = 32;
                rtbox.Text = "Биология -  наука о живых существах и их взаимодействии со средой обитания." +
                 " Изучает все аспекты жизни, в частности, структуру, функционирование, рост, происхождение, " +
                 "эволюцию и распределение живых организмов на Земле. Классифицирует и описывает живые существа," +
                 " происхождение их видов, взаимодействие между собой и с окружающей средой.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 2)
            {
                i = 33;
                rtbox.Text = "Математика наука об отношениях между объектами, о которых ничего не известно, кроме описывающих их некоторых свойств," +
                    " — именно тех, которые в качестве аксиом положены в основание той или иной математической теории.";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 3)
            {
                i = 34;
                rtbox.Text = "Веб программирование - раздел программирования, ориентированный на разработку веб-приложений" +
                    " (программ, обеспечивающих функционирование динамических сайтов Всемирной паутины).";

            }

            // четверг
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 0)
            {
                i = 41;
                rtbox.Text = "История - область знаний, а также гуманитарная наука, занимающаяся изучением " +
                    "человека (его деятельности, состояния, мировоззрения, социальных связей, организаций и так далее) в прошлом";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 1)
            {
                i = 42;
                rtbox.Text = "Химия -одна из важнейших и обширных областей естествознания, наука о веществах, их составе и строении, их свойствах, зависящих от состава и строения," +
                    " их превращениях, ведущих к изменению состава — химических реакциях, а также о законах и закономерностях, которым эти превращения подчиняются.";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 2)
            {
                i = 43;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                              " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 3)
            {
                i = 44;
                rtbox.Text = "Английский язык - язык англо-фризской подгруппы западной группы германской ветви индоевропейской языковой семьи." +
                      " Английский язык — важнейший международный язык," +
                      " что является следствием колониальной политики Британской империи в XIX веке " +
                      "и мирового влияния США в XX—XXI веках. Существует значительное разнообразие диалектов и говоров английского языка.";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 4)
            {
                i = 45;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
                    " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }

            // пятница
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 0)
            {
                i = 51;
                rtbox.Text = "Физика- область естествознания: наука о простейших и вместе с тем наиболее общих законах природы, " +
                            "о материи, её структуре и движении. Законы физики лежат в основе всего естествознания";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 1)
            {
                i = 52;
                rtbox.Text = "Эстонский язык - язык эстонцев,  относящийся к прибалтийско-финской ветви финно-угорской семьи языков." +
                        " Официальный язык Эстонии и Европейского союза.  Письменность — на основе латинского алфавита. ";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 2)
            {
                i = 53;
                rtbox.Text = "Химия -одна из важнейших и обширных областей естествознания, наука о веществах, их составе и строении," +
                    " их свойствах, зависящих от состава и строения," +
                    " их превращениях, ведущих к изменению состава — химических реакциях, а также о законах и закономерностях, которым эти превращения подчиняются.";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 3)
            {
                i = 54;
                rtbox.Text = "История - область знаний, а также гуманитарная наука, занимающаяся изучением " +
                    "человека (его деятельности, состояния, мировоззрения, социальных связей, организаций и так далее) в прошлом";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 4)
            {
                i = 55;
                rtbox.Text = "Веб программирование - раздел программирования, ориентированный на разработку веб-приложений" +
                    " (программ, обеспечивающих функционирование динамических сайтов Всемирной паутины).";
            }

            //суббота
            if (lbox2.SelectedIndex == 5 && lbox3.SelectedIndex == 0)
            {
                i = 61;
                rtbox.Text = "О́тдых — состояние покоя, либо времяпрепровождение, целью которого является восстановление" +
                    " сил, достижение работоспособного состояния организма; время, свободное от работы. ";
            }

            //суббота
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 0)
            {
                i = 71;
                rtbox.Text = "О́тдых — состояние покоя, либо времяпрепровождение, целью которого является восстановление" +
                    " сил, достижение работоспособного состояния организма; время, свободное от работы. ";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 1)
            {
                i = 72;
                rtbox.Text = "Программирование - процесс создания компьютерных программ," +
           " Программирование основывается на использовании языков программирования, на которых записываются исходные тексты программ.";
            }
            
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            rtbox.LoadFile("..//..//images/text3.txt", RichTextBoxStreamType.PlainText);

        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            rtbox.SaveFile("..//..//images/text3.txt", RichTextBoxStreamType.PlainText);
            File.WriteAllText("..//..//images/text3.txt", rtbox.Text, Encoding.UTF8);

        }

        private void Lbox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // понедельник
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 0)
            {
                ii = 1;
                rtbox.Text = "Эстонский - 10:10-10:55";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 1)
            {
                ii = 2;
                rtbox.Text = "Мультимедиа - 11:00-12:35";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 2)
            {
                ii = 3;
                rtbox.Text = "Английский - 12:40-13:25";
            }
            if (lbox2.SelectedIndex == 0 && lbox3.SelectedIndex == 3)
            {
                ii = 4;
                rtbox.Text = "Физика - 13:30-14:15";
            }

            // вторник
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 0)
            {
                ii = 21;
                rtbox.Text = "Программирование - 8:30-11:45";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 1)
            {
                ii = 22;
                rtbox.Text = "Биология - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 2)
            {
                ii = 23;
                rtbox.Text = "Русский язык - 12:40-13:25";
            }
            if (lbox2.SelectedIndex == 1 && lbox3.SelectedIndex == 3)
            {
                ii = 24;
                rtbox.Text = "Английский язык - 14:20-15:05";
            }

            // среда
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 0)
            {
                ii = 31;
                rtbox.Text = "Мультимедиа - 10:10-11:45";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 1)
            {
                ii = 32;
                rtbox.Text = "Биология - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 2)
            {
                ii = 33;
                rtbox.Text = "Математика - 12:40-14:15";
            }
            if (lbox2.SelectedIndex == 2 && lbox3.SelectedIndex == 3)
            {
                ii = 34;
                rtbox.Text = "Веб программирование - 15:10-16:45";
            }

            // четверг
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 0)
            {
                ii = 41;
                rtbox.Text = "История - 8:30-9:15";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 1)
            {
                ii = 42;
                rtbox.Text = "Химия - 9:20-10:05";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 2)
            {
                ii = 43;
                rtbox.Text = "Эстонский язык - 11:00-11:45";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 3)
            {
                ii = 44;
                rtbox.Text = "Английский язык - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 3 && lbox3.SelectedIndex == 4)
            {
                ii = 45;
                rtbox.Text = "Программирование - 12:40-15:55";
            }

            // пятница
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 0)
            {
                ii = 51;
                rtbox.Text = "Физика - 8:30-9:15";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 1)
            {
                ii = 52;
                rtbox.Text = "Эстонский Язык - 9:20-10:05";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 2)
            {
                ii = 53;
                rtbox.Text = "Химия - 10:10-10:55";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 3)
            {
                ii = 54;
                rtbox.Text = "История - 11:50-12:35";
            }
            if (lbox2.SelectedIndex == 4 && lbox3.SelectedIndex == 4)
            {
                ii = 55;
                rtbox.Text = "Веб программирование - 12:40-15:55";
            }

            //суббота
            if (lbox2.SelectedIndex == 5 && lbox3.SelectedIndex == 0)
            {
                ii = 61;
                rtbox.Text = "Отдых - 11:00-23:00";
            }

            //суббота
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 0)
            {
                ii = 71;
                rtbox.Text = "Отдых - 11:00-15:00";
            }
            if (lbox2.SelectedIndex == 6 && lbox3.SelectedIndex == 1)
            {
                ii = 72;
                rtbox.Text = "Программирование - 19:00-23:00";
            }
            
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            rtbox.Clear();
        }

        private void LBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lbox2.SelectedItems.ToString())
            {
                case ("Понедельник"): break;
                case ("Вторник"): break;
                case ("Среда"): break;
                case ("Четверг"): break;
                case ("Пятница"): break;
                case ("Суббота"): break;
                case ("Воскресенье"): break;
            }
            if (lbox2.SelectedIndex == 0)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Мультимедиа");
                lbox3.Items.Add("Английский");
                lbox3.Items.Add("Физика");
            }
            if (lbox2.SelectedIndex == 1)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Программирование");
                lbox3.Items.Add("Биология на эстонском");
                lbox3.Items.Add("Русский и Литература");
                lbox3.Items.Add("Английский");
            }
            if (lbox2.SelectedIndex == 2)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Мультимедиа");
                lbox3.Items.Add("Биология на эстонском");
                lbox3.Items.Add("Математика");
                lbox3.Items.Add("Веб разработка");
            }
            if (lbox2.SelectedIndex == 3)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("История");
                lbox3.Items.Add("Химия");
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Английский");
                lbox3.Items.Add("Программирование");
            }
            if (lbox2.SelectedIndex == 4)
            {
                lbox3.Width = 180;
                lbox3.Items.Clear();
                lbox3.Items.Add("Физика");
                lbox3.Items.Add("Эстонский");
                lbox3.Items.Add("Химия");
                lbox3.Items.Add("История");
                lbox3.Items.Add("Веб программирование");
            }
            if (lbox2.SelectedIndex == 5)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Отдых");
            }
            if (lbox2.SelectedIndex == 6)
            {
                lbox3.Width = 160;
                lbox3.Items.Clear();
                lbox3.Items.Add("Отдых");
                lbox3.Items.Add("Программирование");
            }
        }
        private void LBox2_DoubleClick(object sender, EventArgs e)
        {
            rtbox.Clear();
            rtbox.Text = lbox2.SelectedItem.ToString() + " - " + "\n";
            for (int i = 0; i < lbox3.Items.Count; i++)
            {
                rtbox.Text = rtbox.Text + "\n" + lbox3.Items[i];
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
