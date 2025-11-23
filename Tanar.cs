using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
	public partial class Form1 : Form
	{
		static Random r = new Random();
		string betöltendő_pálya = "palya01.txt";
		void TANÁR_ROBOTJAI()
		{
			Robot karesz = new Robot("Karesz", 1000, 1000, 1000, 1000, 0, 20, 15, r.Next(4));
			Betölt(betöltendő_pálya);
			Vektor[] kijáratok = new Vektor[]
			{
				new Vektor(0, 15),
				new Vektor(40, 15),
				new Vektor(20, 0),
				new Vektor(20, 30),
			};
			Vektor kijárat = kijáratok[r.Next(4)];
			pálya[kijárat] = 0;
			Frissít();

			//Mondd(kijárat.ToString());
			//Mondd(pálya[kijárat].ToString());

			//Robot lilesz = new Robot("Lilesz", 1000, 1000, 1000, 1000, 0, 10, 22, 0);
			//lilesz.Feladat = delegate()
			//{
			//lilesz.Lépj();
			//    lilesz.Lépj();
			//};
		}
	}
}