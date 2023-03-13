using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flatRubik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool _DESIGNMODEONLY = false;
        public bool _DEBUGMODEONLY = false;


        public Graphics g;
        public Font font0;
        public Font fontmin;
        public Pen pen0 = new Pen(Color.Black);
        public Pen pen2 = new Pen(Color.Silver, 1);

        public Brush brush0 = new SolidBrush(Color.DimGray);

        public static int posx = 20;
        public static int posy = 20;
        public int xwidth = 100;
        public int yheight = 100;
        public double rad = (180 / Math.PI);
        public int cx = posx + 50;
        public int cy = posy + 50;
        public double sint = Math.Sin((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double scos = Math.Cos((1) / (180 / Math.PI)) * (100 / 2) + 70;
        public double prevx;
        public double prevy;

        public List<ball> l1 = new List<ball>();
       

        public int currentMousePositionX = 0;
        public int currentMousePositionY = 0;

        public List<Point> mousePressedDown = new List<Point>(); 

        public List<Color> colors = new List<Color>();


        //not real colors just a list
        public void loadColors() { 
            colors.Add(new Color());
            colors[0] = Color.White;
            colors.Add(new Color());
            colors[1] = Color.Black;
            colors.Add(new Color());
            colors[2] = Color.Red;
            colors.Add(new Color());
            colors[3] = Color.Blue;
            colors.Add(new Color());
            colors[4] = Color.Yellow;
            colors.Add(new Color());
            colors[5] = Color.Green;
            colors.Add(new Color());
          

        }



        public void clear()
        {
            g.Clear(BackColor);
        }

        public void drawcircle()
        {

            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                g.DrawLine(pen0, Convert.ToInt16(scos), 100 + Convert.ToInt16(sint), Convert.ToInt16(prevx), 100 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawcircle2()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 200 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 200 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawcircle3()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 400 + Convert.ToInt16(scos), 200 + Convert.ToInt16(sint), 400 + Convert.ToInt16(prevx), 200 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }


        public void drawcircle4()
        {

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (400 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (400 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }

            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (350 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (350 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
            for (int i = -10; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (300 / 2) + cx;
                double scos = Math.Cos((i) / rad) * (300 / 2) + cy;
                g.DrawLine(pen0, 300 + Convert.ToInt16(scos), 400 + Convert.ToInt16(sint), 300 + Convert.ToInt16(prevx), 400 + Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 170);

                prevx = scos;
                prevy = sint;

            }
        }

        public void drawsin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(sint), i, 270);
                //g.DrawLine(pen0, i, Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcos()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosplussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos) + Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }
        public void drawcosminussin()
        {
            for (int i = 0; i < 360; i += 10)
            {
                double sint = Math.Sin((i) / rad) * (xwidth / 2) + cx;
                double scos = Math.Cos((i) / rad) * (yheight / 2) + cy;
                //g.DrawLine(pen0, Convert.ToInt16(scos), Convert.ToInt16(sint), Convert.ToInt16(prevx), Convert.ToInt16(prevy));
                //g.DrawLine(pen0, i, Convert.ToInt16(sint), i, 170);
                g.DrawLine(pen0, i, 100 + Convert.ToInt16(scos) - Convert.ToInt16(sint), i, 270);

                prevx = scos;
                prevy = sint;

            }
        }

        public void loadPositionsIntoBalls()
        {
            if (_DESIGNMODEONLY == true) { 
                if (listofpositionsXY.Length != 108) { Text = "eroare lista " + listofpositionsXY.Length.ToString(); }
                else if (listofpositionsXY.Length == 108) { Text = " lista OK " + listofpositionsXY.Length.ToString(); }
            }
            int j = 0;
            for (int i = 0; i < 108; i += 2)
            {

                this.l1[j].Left = this.listofpositionsXY[i];
                this.l1[j].Top = this.listofpositionsXY[i + 1];

                if (_DEBUGMODEONLY == true)
                {
                    string s = i.ToString() + ":" + this.l1[j].Left.ToString() + ";" + this.l1[j].Top.ToString();
                     s += "; " +j.ToString() + ";" +this.l1[j].BackColor.ToString() + "\r\n";
                    this.textBox1.Text += s;
                    g.DrawString(s,font0,brush0,new Point(this.l1[j].Left, this.l1[j].Top));
                }
                    j++;
            }
           


        }

        public int[] listofpositionsXY = {
            221,
            462,
            225,
            437,
            230,
            415,
            285,
            344,
            307,
            335,
            329,
            325,
            410,
            325,
            433,
            334,
            457,
            347,
            510,
            414,
            513,
            436,
            519,
            463,
            195,
            456,
            198,
            431,
            207,
            407,
            279,
            320,
            300,
            307,
            323,
            301,
            417,
            299,
            439,
            309,
            460,
            317,
            532,
            407,
            536,
            427,
            543,
            456,
            172,
            444,
            177,
            420,
            185,
            393,
            275,
            294,
            297,
            284,
            319,
            279,
            418,
            275,
            445,
            283,
            469,
            295,
            553,
            391,
            563,
            420,
            567,
            443,
            323,
            407,
            343,
            395,
            366,
            382,
            366,
            161,
            348,
            148,
            326,
            133,
            343,
            426,
            367,
            416,
            387,
            396,
            389,
            147,
            368,
            128,
            345,
            115,
            371,
            446,
            395,
            429,
            413,
            408,
            414,
            132,
            398,
            114,
            371,
            97
        };

        public void addAllBalsToForm() {
            int indexculoare = 0;
            if (_DEBUGMODEONLY) {
                if (this.l1.Count != 54) {
                    Text = "error list not egal cu 54";
                }
            }
            for (int i = 0; i < this.l1.Count; i++)
            {
                this.Controls.Add(l1[i]);
                this.l1[i].Visible = true;
                this.l1[i].setColor(colors[indexculoare]);
                if (i == 9 || i == 18 || i == 27 || i == 36 || i == 45) { indexculoare++; }   
            }
            
        }
        public void addBallsInLists()
        {
            for (int i = 0; i < 54; i++)
            {
                this.l1.Add(new ball());

            }
           

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //font0 = Font;
            font0 = new Font("Tahoma", 8);
            fontmin = new Font("Tahoma", 2);
            g = CreateGraphics();


           

            prevx = scos;
            prevy = sint;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            drawcircle2();
            drawcircle3();
            drawcircle4();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            currentMousePositionX = e.X;
            currentMousePositionY = e.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_DESIGNMODEONLY == true)
            {
                mousePressedDown.Add(new Point(e.X, e.Y));
                this.textBox1.Text += e.X.ToString();
                this.textBox1.Text += "\r\n";
                this.textBox1.Text += e.Y.ToString();
                this.textBox1.Text += "\r\n";
            }
        }

        public void drawwallballs()
        {
            if (_DESIGNMODEONLY == false)
            {
                this.textBox1.Visible = false;
                this.button2.Visible = false;
            }
            if (_DEBUGMODEONLY == true)
            {
                this.textBox1.Visible = true;
            }
            loadColors();
            addBallsInLists();
            addAllBalsToForm();
            loadPositionsIntoBalls();
            //add indexes
            addBallsIndexesIntoC11();
            addBallsIndexesIntoC12();
            addBallsIndexesIntoC13();

            addBallsIndexesIntoC21();
            addBallsIndexesIntoC22();
            addBallsIndexesIntoC23();

            addBallsIndexesIntoC31();
            addBallsIndexesIntoC32();
            addBallsIndexesIntoC33();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            drawwallballs();
        }




        public List<int> indexListC11 = new List<int>();
        
        public void addBallsIndexesIntoC11() { 
            indexListC11.Add(0);
            indexListC11.Add(1);
            indexListC11.Add(2);
            indexListC11.Add(3);
            indexListC11.Add(4);
            indexListC11.Add(5);
            indexListC11.Add(6);
            indexListC11.Add(7);
            indexListC11.Add(8);
            indexListC11.Add(9);
            indexListC11.Add(10);
            indexListC11.Add(11);


        }
        public List<int> indexListC12 = new List<int>();
        public void addBallsIndexesIntoC12()
        {
            indexListC12.Add(12);
            indexListC12.Add(13);
            indexListC12.Add(14);
            indexListC12.Add(15);
            indexListC12.Add(16);
            indexListC12.Add(17);
            indexListC12.Add(18);
            indexListC12.Add(19);
            indexListC12.Add(20);
            indexListC12.Add(21);
            indexListC12.Add(22);
            indexListC12.Add(23);


        }
        public List<int> indexListC13 = new List<int>();
        public void addBallsIndexesIntoC13()
        {
            indexListC13.Add(24);
            indexListC13.Add(25);
            indexListC13.Add(26);
            indexListC13.Add(27);
            indexListC13.Add(28);
            indexListC13.Add(29);
            indexListC13.Add(30);
            indexListC13.Add(31);
            indexListC13.Add(32);
            indexListC13.Add(33);
            indexListC13.Add(34);
            indexListC13.Add(35);


        }

        public List<int> indexListC21 = new List<int>();
        public void addBallsIndexesIntoC21()
        {
            indexListC21.Add(26);
            indexListC21.Add(14);
            indexListC21.Add(2);
            indexListC21.Add(36);
            indexListC21.Add(37);
            indexListC21.Add(38);
            indexListC21.Add(6);
            indexListC21.Add(18);
            indexListC21.Add(30);
            indexListC21.Add(39);
            indexListC21.Add(40);
            indexListC21.Add(41);


        }
        public List<int> indexListC22 = new List<int>();
        public void addBallsIndexesIntoC22()
        {
            indexListC22.Add(25);
            indexListC22.Add(13);
            indexListC22.Add(1);
            indexListC22.Add(42);
            indexListC22.Add(43);
            indexListC22.Add(44);
            indexListC22.Add(7);
            indexListC22.Add(19);
            indexListC22.Add(31);
            indexListC22.Add(45);
            indexListC22.Add(46);
            indexListC22.Add(47);


        }
        public List<int> indexListC23 = new List<int>();
        public void addBallsIndexesIntoC23()
        {
            indexListC23.Add(24);
            indexListC23.Add(12);
            indexListC23.Add(0);
            indexListC23.Add(48);
            indexListC23.Add(49);
            indexListC23.Add(50);
            indexListC23.Add(8);
            indexListC23.Add(20);
            indexListC23.Add(32);
            indexListC23.Add(51);
            indexListC23.Add(52);
            indexListC23.Add(53);
            

        }

        public List<int> indexListC31 = new List<int>();
        public void addBallsIndexesIntoC31()
        {
            indexListC31.Add(51);
            indexListC31.Add(45);
            indexListC31.Add(39);
            indexListC31.Add(29);
            indexListC31.Add(17);
            indexListC31.Add(5);
            indexListC31.Add(38);
            indexListC31.Add(44);
            indexListC31.Add(50);
            indexListC31.Add(9);
            indexListC31.Add(21);
            indexListC31.Add(33);
            


        }
        public List<int> indexListC32 = new List<int>();
        public void addBallsIndexesIntoC32()
        {
            indexListC32.Add(52);
            indexListC32.Add(46);
            indexListC32.Add(40);
            indexListC32.Add(28);
            indexListC32.Add(16);
            indexListC32.Add(4);
            indexListC32.Add(37);
            indexListC32.Add(43);
            indexListC32.Add(49);
            indexListC32.Add(10);
            indexListC32.Add(22);
            indexListC32.Add(34);


        }
        public List<int> indexListC33 = new List<int>();
        public void addBallsIndexesIntoC33()
        {
            indexListC33.Add(53);
            indexListC33.Add(47);
            indexListC33.Add(41);
            indexListC33.Add(27);
            indexListC33.Add(15);
            indexListC33.Add(3);
            indexListC33.Add(36);
            indexListC33.Add(42);
            indexListC33.Add(48);
            indexListC33.Add(11);
            indexListC33.Add(23);
            indexListC33.Add(35);


        }


        public List<int> groupA = new List<int>();
        public List<int> groupB = new List<int>();
        public List<int> groupC = new List<int>();
        public List<int> groupD = new List<int>();
        public List<int> groupE = new List<int>();



        //muta in stanga cu 0 pozitie culorile nu pozitiile care vor fi fixe
        //0 1 2 3 4 5 6 7 8 9 10 11 
        //1 2 3 4 5 6 7 8 9 10 11 0

        public void rotateToLeft(ref List<int> pi, ref List<ball> pl)
        {
            Color aux;
             
            aux = pl[pi[0]].BackColor;



            for (int i = 0; i < pi.Count - 1; i++)
            {
                pl[pi[i]].BackColor = pl[pi[i + 1]].BackColor;

            }
            pl[pi[pi.Count - 1]].BackColor = aux;


        }

        //0 1 2 3 4 5 6 7 8 9 10 11 
        //11 0 1 2 3 4 5 6 7 8 9 10

        //trebuie sa folosesc indecsii din indexListC11 nu ball's din l1

        //muta in dreapta cu 0 pozitie culorile nu pozitiile care vor fi fixe
        public void rotateToRight(ref List<int> pi ,ref List<ball> pl)
        {

            //do not work
            Color aux;

            aux = pl[pi[pi.Count - 1]].BackColor;

            for (int i = pi.Count - 1; i>0; i--)
            {
                pl[pi[i]].BackColor = pl[pi[i-1]].BackColor;

            }
            pl[pi[0]].BackColor = aux;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //tostanga c11
            //trebuie sa strimit o lista cu ball nu cu int pe care nu o am o sublista a
            //lui l1 lista tuturor ball's creata dupa lista indexListC11 cu indecsi
            rotateToLeft(ref indexListC11, ref l1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //todreapta c11
            //trebuie sa strimit o lista cu ball nu cu int pe care nu o am o sublista a
            //lui l1 lista tuturor ball's creata dupa lista indexListC11 cu indecsi
            rotateToRight(ref indexListC11, ref l1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            this.button3.Visible = false;
            this.button6.Visible = false;
            drawcircle2();
            drawcircle3();
            drawcircle4();
            drawwallballs();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC12, ref l1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC13, ref l1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC23, ref l1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC21, ref l1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC22, ref l1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC31, ref l1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC32, ref l1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC33, ref l1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC12, ref l1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC13, ref l1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC21, ref l1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC22, ref l1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC23, ref l1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC31, ref l1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC32, ref l1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC33, ref l1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC11, ref l1);
            rotateToLeft(ref indexListC11, ref l1);
            rotateToLeft(ref indexListC11, ref l1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC11, ref l1);
            rotateToRight(ref indexListC11, ref l1);
            rotateToRight(ref indexListC11, ref l1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC12, ref l1);
            rotateToLeft(ref indexListC12, ref l1);
            rotateToLeft(ref indexListC12, ref l1);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC12, ref l1);
            rotateToRight(ref indexListC12, ref l1);
            rotateToRight(ref indexListC12, ref l1);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC13, ref l1);
            rotateToLeft(ref indexListC13, ref l1);
            rotateToLeft(ref indexListC13, ref l1);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC13, ref l1);
            rotateToRight(ref indexListC13, ref l1);
            rotateToRight(ref indexListC13, ref l1);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC21, ref l1);
            rotateToLeft(ref indexListC21, ref l1);
            rotateToLeft(ref indexListC21, ref l1);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC22, ref l1);
            rotateToLeft(ref indexListC22, ref l1);
            rotateToLeft(ref indexListC22, ref l1);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC23, ref l1);
            rotateToLeft(ref indexListC23, ref l1);
            rotateToLeft(ref indexListC23, ref l1);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC23, ref l1);
            rotateToRight(ref indexListC23, ref l1);
            rotateToRight(ref indexListC23, ref l1);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC22, ref l1);
            rotateToRight(ref indexListC22, ref l1);
            rotateToRight(ref indexListC22, ref l1);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC21, ref l1);
            rotateToRight(ref indexListC21, ref l1);
            rotateToRight(ref indexListC21, ref l1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC31, ref l1);
            rotateToLeft(ref indexListC31, ref l1);
            rotateToLeft(ref indexListC31, ref l1);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC32, ref l1);
            rotateToLeft(ref indexListC32, ref l1);
            rotateToLeft(ref indexListC32, ref l1);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            rotateToLeft(ref indexListC33, ref l1);
            rotateToLeft(ref indexListC33, ref l1);
            rotateToLeft(ref indexListC33, ref l1);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC31, ref l1);
            rotateToRight(ref indexListC31, ref l1);
            rotateToRight(ref indexListC31, ref l1);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC32, ref l1);
            rotateToRight(ref indexListC32, ref l1);
            rotateToRight(ref indexListC32, ref l1);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            rotateToRight(ref indexListC33, ref l1);
            rotateToRight(ref indexListC33, ref l1);
            rotateToRight(ref indexListC33, ref l1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
