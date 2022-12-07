using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Final
{
	public class Headgear : Gear
	{
		public Headgear()
		{
			Main = "Nothing";
			Sub1 = "Nothing";
			Sub2 = "Nothing";
			Sub3 = "Nothing";
		}

		public Headgear(string main, string sub1, string sub2, string sub3)
		{
			Main = main;
			Sub1 = sub1;
			Sub2 = sub2;
			Sub3 = sub3;
		}
	}
}
