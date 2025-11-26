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
		string betöltendő_pálya = "palya14.txt";
		void TANÁR_ROBOTJAI()
		{
			Robot karesz = new Robot("Karesz", 0, 0, 0, 0, 0, 20, 15, 1, false, false);
			Betölt(betöltendő_pálya);
			Frissít();

			//Robot lilesz = new Robot("Lilesz", 1000, 1000, 1000, 1000, 0, 10, 22, 0);
			//lilesz.Feladat = delegate()
			//{
			//	lilesz.Lépj();
			//  lilesz.Lépj();
			//};
		}
	}
}