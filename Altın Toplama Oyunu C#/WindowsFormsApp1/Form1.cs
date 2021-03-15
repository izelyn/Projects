using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public static int X, Y, mik, oy1al, oy2al, oy3al, oy4al, alan;
        public static int hr1=0, hr2=0, hr3=0, hr4=0, tp1=0, tp2=0, tp3=0, tp4=0;
        public static int kare, gizli, rast, topalt, sayac = 0, ad1=0, ad2=0, ad3=0, ad4=0;
        public static int a, b, c, i, j, k = 0, l = 0, xf, yf, q, r, alt, n, w ,v;
        public static int min = 1000, m;
        public static int[,] gizkon;
        public static int[,] toplu;
        public static int[,] oyun;
        public static int[,] hed = new int[4, 4];
        public static int[,] oyxy = new int[4, 2];
        public static Random rastgele;
        public static Button btn;
        public static double d,max=0;
        public static StreamWriter sw1, sw2, sw3, sw4;

        public Form1()
        {
            InitializeComponent();
        }


       

        public void altin()
        {
            alan = X * Y;
            oyun = new int[alan, 5];
            rastgele = new Random();
            kare = alan / 5;
            gizli = kare / 10;
            toplu = new int[kare, 3];
            gizkon = new int[gizli, 2];
            oy1al = mik;
            oy2al = mik;
            oy3al = mik;
            oy4al = mik;
            oyxy[0, 0] = 0;
            oyxy[0, 1] = 0;
            oyxy[1, 0] = 0;
            oyxy[1, 1] = Y-1;
            oyxy[2, 0] = X-1;
            oyxy[2, 1] = 0;
            oyxy[3, 0] = X-1;
            oyxy[3, 1] = Y-1;
            hed[0, 2] = 0;
            hed[1, 2] = 0;
            hed[2, 2] = 0;
            hed[3, 2] = 0;

            for (v = 0; v < X; v++)
            {
                for (w= 0; w< Y; w++)
                {
                    oyun[(v * X) + w, 0] = v;
                    oyun[(v * X) + w, 1] = w;
                    oyun[(v * X) + w, 4] = 0;

                }
            }



            for (i = 0; i < kare; i++)
            {
                alt = rastgele.Next(1, alan + 1);
                toplu[i, 0] = alt / X;
                toplu[i, 1] = alt % X;


                for (j = 0; j < i; j++)
                {
                    if (toplu[i, 0] == toplu[j, 0] && toplu[i, 1] == toplu[j, 1])
                    {
                        i--;

                    }
                    else if ((toplu[i, 0] == oyxy[0,0] && toplu[i, 1] == oyxy[0, 1]) || (toplu[i, 0] == oyxy[1, 0] && toplu[i, 1] == oyxy[1, 1]) || (toplu[i, 0] == oyxy[2, 0] && toplu[i, 1] == oyxy[2, 1]) || (toplu[i, 0] == oyxy[3, 0] && toplu[i, 1] == oyxy[3, 1]))
                    {
                        i--;
                    }


                }


            }
            for (i = 0; i < kare; i++)
            {
                rast = rastgele.Next(1, 5);
                switch (rast)
                {
                    case 1:
                        toplu[i, 2] = 5;
                        break;
                    case 2:
                        toplu[i, 2] = 10;
                        break;
                    case 3:
                        toplu[i, 2] = 15;
                        break;
                    case 4:
                        toplu[i, 2] = 20;
                        break;
                    default:
                        break;
                }
                topalt += toplu[i, 2];
            }



            for (i = 0; i < gizli; i++)
            {
                a = rastgele.Next(kare);
                gizkon[i, 0] = toplu[a, 0];
                gizkon[i, 1] = toplu[a, 1];




                for (j = 0; j < i; j++)
                {
                    if (gizkon[i, 0] == gizkon[j, 0] && gizkon[i, 1] == gizkon[j, 1])

                    {
                        i--;

                    }
                }

            }

            for (i = 0; i < alan; i++)
            {

                for (j = 0; j < kare; j++)
                {
                    if(oyun[i, 0] == toplu[j,0] && oyun[i, 1] == toplu[j, 1])
                    {
                        oyun[i, 2] = 1;
                        oyun[i, 3] = toplu[j, 2];

                    }
                }
            }
            for (i = 0; i < alan; i++)
            {

                for (j = 0; j < gizli; j++)
                {
                    if (oyun[i, 0] == gizkon[j, 0] && oyun[i, 1] == gizkon[j, 1])
                    {
                        oyun[i, 2] = 2;

                    }
                }
            }


        }










        public void ekran()

        {



            if (String.IsNullOrEmpty(textBox1.Text))
            {
                X = 20;

            }
            else
            {
                X = int.Parse(textBox1.Text);
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                Y = 20;

            }
            else
            {
                Y = int.Parse(textBox2.Text);
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                mik = 200;

            }
            else
            {
                mik = int.Parse(textBox3.Text);

            }
            if (X == 0)
            {
                X = 20;
            }
            if (Y == 0)
            {
                Y = 20;
            }
            if (mik == 0)
            {
                mik = 200;
            }
            altin();

            


        }

        public void yerles()
        {
           
           

            for (i = 0; i < X; i++)
            {
                for (j = 0; j < Y; j++)
                {
                    btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.Location = new Point(30 * (j + 1), 30 * (i + 1));
                    panel1.Controls.Add(btn);
                    
                    for (k = 0; k < alan; k++)
                    {   
                        if (i == oyun[k, 0] && j == oyun[k, 1] && oyun[k,2]==1)
                        {
                            btn.BackgroundImage = Image.FromFile("gold.jpg");
                            l++;
                        }


                        if (i == oyun[k, 0] && j == oyun[k, 1] && oyun[k, 2] == 2)
                        {
                            btn.BackgroundImage = Image.FromFile("wg.jpg");
                            l++;
                        }


                    }



                    if (i == oyxy[0,0] && j == oyxy[0,1])
                    {
                        btn.BackgroundImage = Image.FromFile("a-harfi.jpg");
                    }
                    if (i == oyxy[1, 0] && j == oyxy[1, 1])
                    {
                        btn.BackgroundImage = Image.FromFile("b.jpg");
                    }
                    if (i == oyxy[2, 0] && j == oyxy[2, 1])
                    {
                        btn.BackgroundImage = Image.FromFile("c.jpg");
                    }
                    if (i == oyxy[3, 0] && j == oyxy[3, 1])
                    {
                        btn.BackgroundImage = Image.FromFile("dd.png");
                    }

                }
               


            }



        }
        public void hedef(int harc)
        {

            switch (harc)

            {
                case 5:

                    for (i = 0; i < alan; i++)
                    {

                        l = Math.Abs(oyxy[0, 0] - oyun[i, 0]) + Math.Abs(oyxy[0, 1] - oyun[i, 1]);
                        if (l <= min && l != 0 && oyun[i, 2] == 1  )
                        {
                            if (oyun[i, 4] == 0)
                            {

                                hed[0, 0] = oyun[i, 0];
                                hed[0, 1] = oyun[i, 1];
                                hed[0, 2] = 1;
                                hed[0, 3] = oyun[i, 3];
                                a = i;
                                min = l;



                            }




                        }
                    }



                    min = 1000;


                    break;

                case 10:
                    for (i = 0; i < alan; i++)
                    {

                        l = Math.Abs(oyxy[1, 0] - oyun[i, 0]) + Math.Abs(oyxy[1, 1] - oyun[i, 1]);
                        if (oyun[i, 2] == 1 && l != 0  )
                        {
                            d = Convert.ToDouble(oyun[i, 3] / l);
                            if (d >= max)
                            {
                                if (oyun[i, 4] == 0)
                                {
                                    hed[1, 0] = oyun[i, 0];
                                    hed[1, 1] = oyun[i, 1];
                                    hed[1, 2] = 1;
                                    hed[1, 3] = oyun[i, 3];
                                    a = i;
                                    max = d;
                                }



                            }

                        }


                    }

                    max = 0;


                    break;

                case 15:


                    for (i = 0; i < alan; i++)
                    {

                        l = Math.Abs(oyxy[2, 0] - oyun[i, 0]) + Math.Abs(oyxy[2, 1] - oyun[i, 1]);
                        if (oyun[i, 2] == 2 && l != 0 && l<3)
                        {
                           
                                oyun[i, 2] = 1;
                            
                        }
                    }
                    pbl();
                    yerles();

                    for (i = 0; i < alan; i++)
                    {

                        l = Math.Abs(oyxy[2, 0] - oyun[i, 0]) + Math.Abs(oyxy[2, 1] - oyun[i, 1]);
                        if (oyun[i, 2] == 1 && l != 0  )
                        {
                            d = Convert.ToDouble(oyun[i, 3] / l);
                            if (d >= max)
                            {
                                if (oyun[i, 4] == 0)
                                {
                                    hed[2, 0] = oyun[i, 0];
                                    hed[2, 1] = oyun[i, 1];
                                    hed[2, 2] = 1;
                                    hed[2, 3] = oyun[i, 3];
                                    a = i;
                                    max = d;
                                }
                            }

                        }

                    }
                    max = 0; ;
                    break;

                case 20:

                    for (i = 0; i < alan; i++)
                    {
                        if (oyun[i, 2] == 1 && l != 0  )
                        {
                            d = Convert.ToDouble(oyun[i, 3] / l);
                            if (d >= max)
                            {

                                if (oyun[i, 4] == 0)
                                {

                                    hed[3, 0] = oyun[i, 0];
                                    hed[3, 1] = oyun[i, 1];
                                    hed[3, 2] = 1;
                                    hed[3, 3] = oyun[i, 3];
                                    a = i;
                                    max = d;

                                }


                            }
                        
                        }
                    }
                    max = 0;
                    break;

                default:
                    break;

            }

        }

        public void hamle(int numara)
        {

            switch (numara)
            {
                case 1:

                    xf = oyxy[0, 0] - hed[0, 0];
                    yf = oyxy[0, 1] - hed[0, 1];

                    if (xf != 0 && yf != 0)
                    {
                        oy1al -= 5;
                        hr1 += 5;
                        ad1++;
                        if (Math.Abs(xf) > Math.Abs(yf))
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[0, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }

                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[0, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                        }
                        else if (Math.Abs(yf) > Math.Abs(xf))
                        {
                            if (yf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[0, 1] -= 1;
                                        yf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[0, 1] += 1;
                                        yf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }

                        }

                        else
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[0, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }




                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[0, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }
                        }





                    }

                    if (xf != 0 && yf == 0)
                    {
                        oy1al -= 5;
                        hr1 += 5;
                        ad1++;
                        if (xf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[0, 0] -= 1;
                                    xf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {

                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[0, 0] += 1;
                                    xf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }






                    }
                    if (xf == 0 && yf != 0)
                    {
                        oy1al -= 5;
                        hr1 += 5;
                        ad1++;
                        if (yf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[0, 1] -= 1;
                                    yf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[0, 1] += 1;
                                    yf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[0, 0] == oyun[q, 0] && oyxy[0, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                    }






                    break;


                case 2:


                    xf = oyxy[1, 0] - hed[1, 0];
                    yf = oyxy[1, 1] - hed[1, 1];

                    if (xf != 0 && yf != 0)
                    {
                        oy2al -= 5;
                        hr2 += 5;
                        ad2++;
                        if (Math.Abs(xf) > Math.Abs(yf))
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[1, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }

                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[1, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                        }
                        else if (Math.Abs(yf) > Math.Abs(xf))
                        {
                            if (yf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[1, 1] -= 1;
                                        yf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[1, 1] += 1;
                                        yf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }

                        }

                        else
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[1, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }




                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[1, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }
                        }





                    }

                    if (xf != 0 && yf == 0)
                    {
                        oy2al -= 5;
                        hr2 += 5;
                        ad2++;
                        if (xf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[1, 0] -= 1;
                                    xf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {

                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[1, 0] += 1;
                                    xf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }






                    }
                    if (xf == 0 && yf != 0)
                    {
                        oy2al -= 5;
                        hr2 += 5;
                        ad2++;
                        if (yf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[1, 1] -= 1;
                                    yf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[1, 1] += 1;
                                    yf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[1, 0] == oyun[q, 0] && oyxy[1, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                    }





                    break;

                case 3:



                    xf = oyxy[2, 0] - hed[2, 0];
                    yf = oyxy[2, 1] - hed[2, 1];

                    if (xf != 0 && yf != 0)
                    {
                        oy3al -= 5;
                        hr3 += 5;
                        ad3++;
                        if (Math.Abs(xf) > Math.Abs(yf))
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[2, 0] -= 1;
                                        xf -= 1;

                                    }
                                    else { break; }

                                }

                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[2, 0] += 1;
                                        xf += 1;

                                    }
                                    else { break; }

                                }


                            }
                        }
                        else if (Math.Abs(yf) > Math.Abs(xf))
                        {
                            if (yf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[2, 1] -= 1;
                                        yf -= 1;

                                    }
                                    else { break; }

                                }


                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[2, 1] += 1;
                                        yf += 1;

                                    }
                                    else { break; }

                                }



                            }

                        }

                        else
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[2, 0] -= 1;
                                        xf -= 1;

                                    }
                                    else { break; }

                                }




                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[2, 0] += 1;
                                        xf += 1;

                                    }
                                    else { break; }

                                }



                            }
                        }





                    }

                    if (xf != 0 && yf == 0)
                    {
                        oy3al -= 5;
                        hr3 += 5;
                        ad3++;
                        if (xf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[2, 0] -= 1;
                                    xf -= 1;

                                }
                                else { break; }

                            }



                        }
                        else
                        {

                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[2, 0] += 1;
                                    xf += 1;

                                }
                                else { break; }

                            }



                        }






                    }
                    if (xf == 0 && yf != 0)
                    {
                        oy3al -= 5;
                        hr3 += 5;
                        ad3++;
                        if (yf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[2, 1] -= 1;
                                    yf -= 1;

                                }
                                else { break; }

                            }



                        }
                        else
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[2, 1] += 1;
                                    yf += 1;

                                }
                                else { break; }

                            }



                        }
                    }







                    break;

                case 4:



                    xf = oyxy[3, 0] - hed[3, 0];
                    yf = oyxy[3, 1] - hed[3, 1];

                    if (xf != 0 && yf != 0)
                    {
                        oy4al -= 5;
                        hr4 += 5;
                        ad4++;
                        if (Math.Abs(xf) > Math.Abs(yf))
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[3, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }

                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[3, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                        }
                        else if (Math.Abs(yf) > Math.Abs(xf))
                        {
                            if (yf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[3, 1] -= 1;
                                        yf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }


                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (yf != 0)
                                    {
                                        oyxy[3, 1] += 1;
                                        yf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }

                        }

                        else
                        {
                            if (xf > 0)
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[3, 0] -= 1;
                                        xf -= 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }




                            }
                            else
                            {
                                for (i = 0; i < 3; i++)
                                {
                                    if (xf != 0)
                                    {
                                        oyxy[3, 0] += 1;
                                        xf += 1;
                                        for (q = 0; q < alan; q++)
                                        {
                                            if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                            {

                                                oyun[q, 2] = 1;
                                            }

                                        }
                                    }
                                    else { break; }

                                }



                            }
                        }





                    }

                    if (xf != 0 && yf == 0)
                    {
                        oy4al -= 5;
                        hr4 += 5;
                        ad4++;
                        if (xf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[3, 0] -= 1;
                                    xf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {

                            for (i = 0; i < 3; i++)
                            {
                                if (xf != 0)
                                {
                                    oyxy[3, 0] += 1;
                                    xf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }






                    }
                    if (xf == 0 && yf != 0)
                    {
                        oy4al -= 5;
                        hr4 += 5;
                        ad4++;
                        if (yf > 0)
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[3, 1] -= 1;
                                    yf -= 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                        else
                        {
                            for (i = 0; i < 3; i++)
                            {
                                if (yf != 0)
                                {
                                    oyxy[3, 1] += 1;
                                    yf += 1;
                                    for (q = 0; q < alan; q++)
                                    {
                                        if (oyxy[3, 0] == oyun[q, 0] && oyxy[3, 1] == oyun[q, 1] && oyun[q, 2] == 2)
                                        {

                                            oyun[q, 2] = 1;
                                        }

                                    }
                                }
                                else { break; }

                            }



                        }
                    }






                    break;

                default: break;


            }

        }


         


       










         


        public void pbl()
        {
            Thread.Sleep(2000);

            panel1.Controls.Clear();
        }






        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac < alan / 5)
            {

                if (oy1al > 30)
                {

                    if (hed[0, 2] == 0)
                    {
                        hedef(5);
                        if (hed[0, 2] == 1)
                        {
                            oy1al -= 5;
                            hr1 += 5;
                        }
                    }
                    else
                    {
                        hamle(1);
                        sw1.Write("hamle x degeri: " + oyxy[0, 0]);
                        sw1.WriteLine("hamle y degeri: " + oyxy[0, 1]);

                        pbl();
                        yerles();
                        if (oyxy[0, 0] == hed[0, 0] && oyxy[0, 1] == hed[0, 1])
                        {
                            oyun[hed[0, 0] * X + hed[0, 1], 2] = 0;
                            sayac++;
                             





                        }


                        hed[0, 2] = 0;
                        oy1al += hed[0, 3];
                        tp1 += hed[0, 3];
                        topalt -= hed[0, 3];
                    }





                }
                else
                {
                    Form1.ActiveForm.Close();
                }

                if (oy2al > 30)
                {

                    if (hed[1, 2] == 0)
                    {
                        hedef(10);
                        if (hed[1, 2] == 1)
                        {
                            oy2al -= 10;
                            hr2 += 10;
                        }
                    }
                    else
                    {
                        hamle(2);
                        sw2.Write(" hamle x degeri: " + oyxy[1, 0]);
                        sw2.WriteLine("hamle y degeri: " + oyxy[1, 1]);
                        pbl();
                        yerles();
                        if (oyxy[1, 0] == hed[1, 0] && oyxy[1, 1] == hed[1, 1])
                        {
                            oyun[hed[1, 0] * X + hed[1, 1], 2] = 0;
                            sayac++;
                             



                        }


                        hed[1, 2] = 0;
                        oy2al += hed[1, 3];
                        tp2 += hed[1, 3];
                        topalt -= hed[1, 3];

                    }


                }
                else
                {
                    Form1.ActiveForm.Close();
                }

                if (oy3al > 30)
                {


                    if (hed[2, 2] == 0)
                    {
                        hedef(15);
                        if (hed[2, 2] == 1)
                        {
                            oy3al -= 15;
                            hr3 += 15;
                        }
                    }
                    else
                    {

                        hamle(3);
                        sw3.Write("hamle x degeri: " + oyxy[2, 0]);
                        sw3.WriteLine(" hamle y degeri: " + oyxy[2, 1]);


                        pbl();
                        yerles();
                        if (oyxy[2, 0] == hed[2, 0] && oyxy[2, 1] == hed[2, 1])
                        {
                            oyun[hed[2, 0] * X + hed[2, 1], 2] = 0;

                            sayac++;
                            


                        }


                        hed[2, 2] = 0;
                        oy3al += hed[2, 3];
                        tp3 += hed[2, 3];
                        topalt -= hed[2, 3];

                    }



                }
                else
                {
                    Form1.ActiveForm.Close();
                }

                if (oy4al >= 30)
                {
                    if (hed[3, 2] == 0)
                    {
                        hedef(20);
                        if (hed[3, 2] == 1)
                        {
                            oy4al -= 20;
                            hr4 += 20;
                        }
                    }
                    else
                    {
                        hamle(4);
                        sw4.Write("hamle x degeri: " + oyxy[3, 0]);
                        sw4.WriteLine(" hamle y degeri: " + oyxy[3, 1]);
                        pbl();
                        yerles();
                        if (oyxy[3, 0] == hed[3, 0] && oyxy[3, 1] == hed[3, 1])
                        {
                            oyun[hed[3, 0] * X + hed[3, 1], 2] = 0;

                            sayac++;
                             


                        }


                        hed[3, 2] = 0;
                        oy4al += hed[3, 3];
                        tp4 += hed[3, 3];
                        topalt -= hed[3, 3];

                    }



                    m = 0;
                }
                else
                {
                    Form1.ActiveForm.Close();
                }







            }
            else
            {
                pbl();
                Form1.ActiveForm.Close();
                sw1.Write("kasadaki altin: " + oy1al);
                sw1.Write(" harcanan altin: " + hr1);
                sw1.Write(" toplanan altin: " + tp1);
                sw1.WriteLine(" toplam adim: " + ad1);

                sw2.Write("kasadaki altin: " + oy2al);
                sw2.Write(" harcanan altin: " + hr2);
                sw2.Write(" toplanan altin: " + tp2);
                sw2.WriteLine(" toplam adim: " + ad2);

                sw3.Write("kasadaki altin: " + oy3al);
                sw3.Write(" harcanan altin: " + hr3);
                sw3.Write(" toplanan altin: " + tp3);
                sw3.WriteLine(" toplam adim: " + ad3);

                sw4.Write("kasadaki altin: " + oy4al);
                sw4.Write(" harcanan altin: " + hr4);
                sw4.Write(" toplanan altin: " + tp4);
                sw4.WriteLine(" toplam adim: " + ad4);

                sw1.Close();
                sw2.Close();
                sw3.Close();
                sw4.Close();
            }


        }


        

        private void basla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
            kayit.Enabled = false;
            basla.Enabled = false;
            

        }

        private void kayit_Click(object sender, EventArgs e)
        {
          
            sw1 = new StreamWriter("C:\\Users\\izely\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\file1.txt");
            sw2 = new StreamWriter("C:\\Users\\izely\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\file2.txt");
            sw3 = new StreamWriter("C:\\Users\\izely\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\file3.txt");
            sw4 = new StreamWriter("C:\\Users\\izely\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\file4.txt");

            ekran();
        }
       
        
    }

}