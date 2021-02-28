using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarGrafikleriKisaSinav2
{
    public partial class Form1 : Form
    {
        //Grafik çizmek için grafik nesnesi oluşturduk
        //System.Drawing.Graphics Cizgi; olarakda tanımlayabilirdik.
        Graphics Cizgi;
        //Çizmek için kalem nesnesi oluşturduk
        Pen klm = new Pen(Color.Blue, 4);

        Double[,] XcisimNokta = new Double[10, 4] { { 0, 0,0,1},//a
                                                    { 1, 0,0,1},//b
                                                    { 1, 0,1,1},//c
                                                    { 0, 0,1,1},//d
                                                    { 0, 1,0,1},//e
                                                    { 1, 1,0,1},//f
                                                    { 1, 1,0.5,1},//g
                                                    { 1, 0.5,1,1},//k
                                                    { 0.5, 1,1,1},//l
                                                   { 0, 1,1,1} };//m
        Double[,] Xüssü = new Double[10, 4];

        Double[,] Tizometrik = new Double[4, 4] { { 0.707, -0.400, 0, 0},
                                                  { 0,      0.816, 0, 0 },
                                                  {-0.707, -0.400, 0, 0 },
                                                  { 0,      0,     0, 0 }};

        Double[,] TOtele = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] Tyansit = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] Tolcekle = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] TXDondur = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] TYDondur = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] TZDondur = new Double[4, 4] { { 1, 0, 0, 0},
                                              { 0, 1, 0, 0 },
                                              { 0, 0, 1, 0 },
                                              { 0, 0, 0, 1 }};

        Double[,] eksen3BX = new Double[2, 4] {{ 0, 0, 0, 1}, { 2.5, 0, 0, 1}};
        Double[,] eksen3BY = new Double[2, 4] {{ 0, 0, 0, 1}, { 0, 2.5, 0, 1}};

        int i, j, k;
        public Form1()
        {
            InitializeComponent();
        }

        //Form Ekranında çizim yapmak için boş bırakılan alana hesaplayıp çizmek için metotlar oluşturduk
        //Bunlar KordinatHesaplaX ve KordinatHesaplaY'dir
        private int KordinatHesaplaX(Double geciciX)
        {
            return Convert.ToInt32(300 + 250 + (100 * geciciX));
        }
        private int KordinatHesaplaY(Double geciciY)
        {
            return Convert.ToInt32(100 + 250 - (100 * geciciY));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += XcisimNokta[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.Green;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
           // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));

            Cizgi.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double txotele = Convert.ToDouble(xotele.Text);
            Double tyotele = Convert.ToDouble(yotele.Text);
            Double tzotele = Convert.ToDouble(zotele.Text);
            TOtele[3, 0] = txotele;
            TOtele[3, 1] = tyotele;
            TOtele[3, 2] = tzotele;
            Double[,] Gecici = new Double[10, 4];
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XcisimNokta[i, k] * TOtele[k, j];
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.Pink;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Double[,] GeciciX = new Double[10, 4];
            Double[,] GeciciY = new Double[10, 4];
            Double[,] GeciciZ = new Double[10, 4];

            Double XacıDondur = Convert.ToDouble(xacıdon.Text);
            Double YacıDondur = Convert.ToDouble(yacıdon.Text);
            Double Zacıdondur = Convert.ToDouble(zacıdon.Text);

            Double xteta = XacıDondur;
            Double yteta = YacıDondur;
            Double zteta = Zacıdondur;

            TXDondur[1, 1] = Math.Cos(Math.PI * xteta / 180.0);
            TXDondur[2, 2] = TXDondur[1, 1];
            TXDondur[1, 2] = Math.Sin(Math.PI * xteta / 180.0);
            TXDondur[2, 1] = (-1) * TXDondur[1, 2];

            TYDondur[0, 0] = Math.Cos(Math.PI * yteta / 180.0);
            TYDondur[2, 2] = TYDondur[0, 0];
            TYDondur[0, 2] = Math.Sin(Math.PI * yteta / 180.0);
            TYDondur[2, 0] = (-1) * TYDondur[0, 2];

            TZDondur[0, 0] = Math.Cos(Math.PI * zteta / 180.0);
            TZDondur[1, 1] = TZDondur[0, 0];
            TZDondur[1, 0] = (-1)*Math.Sin(Math.PI * zteta / 180.0);
            TZDondur[0, 1] = (-1) * TZDondur[1, 0];

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciX[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciX[i, j] += XcisimNokta[i, k] * TXDondur[k, j];
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += GeciciX[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.Yellow;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciY[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciY[i, j] += XcisimNokta[i, k] * TYDondur[k, j];
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += GeciciY[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.LightBlue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    GeciciZ[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        GeciciZ[i, j] += XcisimNokta[i, k] * TZDondur[k, j];
                    }
                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += GeciciZ[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.Brown;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double[,] Gecici = new Double[10, 4];
            if (xy.Checked)
            {
                Tyansit[2, 2] = -1;
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Gecici[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Gecici[i, j] += XcisimNokta[i, k] * Tyansit[k, j];
                        }

                    }
                }
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Xüssü[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Xüssü[i, j] += Gecici[i, k] * Tizometrik[k, j];
                        }
                    }
                }
                Tyansit[2, 2] = 1;
            }
            else if (xz.Checked)
            {
                Tyansit[1,1] = -1;
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Gecici[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Gecici[i, j] += XcisimNokta[i, k] * Tyansit[k, j];
                        }

                    }
                }
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Xüssü[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Xüssü[i, j] += Gecici[i, k] * Tizometrik[k, j];
                        }
                    }
                }
                Tyansit[1,1] = 1;
            }
            else if (yz.Checked)
            {
                Tyansit[0,0] = -1;
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Gecici[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Gecici[i, j] += XcisimNokta[i, k] * Tyansit[k, j];
                        }

                    }
                }
                for (i = 0; i < 10; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Xüssü[i, j] = 0;
                        for (k = 0; k < 4; k++)
                        {
                            Xüssü[i, j] += Gecici[i, k] * Tizometrik[k, j];
                        }
                    }
                }
                Tyansit[0,0] = 1;
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.LightGreen;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double Xolcekle = Convert.ToDouble(olceklex.Text);
            Double Yolcekle = Convert.ToDouble(olcekley.Text);
            Double Zolcekle = Convert.ToDouble(olceklez.Text);

            Double[,] Gecici = new Double[10, 4];

            Tolcekle[0, 0] = Xolcekle;
            Tolcekle[1, 1] = Yolcekle;
            Tolcekle[2, 2] = Zolcekle;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici[i, j] += XcisimNokta[i, k] * Tolcekle[k, j];
                    }

                }
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Xüssü[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Xüssü[i, j] += Gecici[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Tolcekle[0, 0] = 1;
            Tolcekle[1, 1] = 1;
            Tolcekle[2, 2] = 1;

            Cizgi = this.CreateGraphics();
            klm.Color = Color.LightSalmon;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]));
            //klm.Color = Color.Blue;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]), KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[6, 0]), KordinatHesaplaY(Xüssü[6, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[8, 0]), KordinatHesaplaY(Xüssü[8, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            // klm.Color = Color.Black;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[0, 0]), KordinatHesaplaY(Xüssü[0, 1]), KordinatHesaplaX(Xüssü[4, 0]), KordinatHesaplaY(Xüssü[4, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[1, 0]), KordinatHesaplaY(Xüssü[1, 1]), KordinatHesaplaX(Xüssü[5, 0]), KordinatHesaplaY(Xüssü[5, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[2, 0]), KordinatHesaplaY(Xüssü[2, 1]), KordinatHesaplaX(Xüssü[7, 0]), KordinatHesaplaY(Xüssü[7, 1]));
            Cizgi.DrawLine(klm, KordinatHesaplaX(Xüssü[3, 0]), KordinatHesaplaY(Xüssü[3, 1]), KordinatHesaplaX(Xüssü[9, 0]), KordinatHesaplaY(Xüssü[9, 1]));
            Cizgi.Dispose();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double[,] Gecici3BX = new Double[2, 4];
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Gecici3BX[i, j] = 0;
                    for (k = 0; k < 4; k++)
                    {
                        Gecici3BX[i,j]+= eksen3BX[i, k] * Tizometrik[k, j];
                    }
                }
            }
            Cizgi = this.CreateGraphics();
            klm.Color = Color.Red;
            Cizgi.DrawLine(klm, KordinatHesaplaX(Gecici3BX[0, 0]), KordinatHesaplaY(Gecici3BX[0, 1]), KordinatHesaplaX(Gecici3BX[1, 0]), KordinatHesaplaY(Gecici3BX[1, 1]));//X ekseni için
            Cizgi.DrawLine(klm, KordinatHesaplaX(Gecici3BX[0, 0]), KordinatHesaplaY(Gecici3BX[0, 1]), KordinatHesaplaX(Gecici3BX[1, 0]*-1), KordinatHesaplaY(Gecici3BX[1, 1]));//Z ekseni için
            Cizgi.DrawLine(klm, KordinatHesaplaX(eksen3BY[0, 0]), KordinatHesaplaY(eksen3BY[0, 1]), KordinatHesaplaX(eksen3BY[1, 0]), KordinatHesaplaY(eksen3BY[1, 1]));//Y ekseni için
            Cizgi.Dispose();
        }
    }
}
