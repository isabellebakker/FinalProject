using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Final
{
	public class Weapon
	{
		private string mainWeapon;
		private string subWeapon;
		private int specialPoints;

		public string MainWeapon { get; set; }

		public string SubWeapon { get; set; }

		public int SpecialPoints { get; set; }

        public Weapon()
        {
            MainWeapon = "Unspecified";
            SubWeapon = "Unspecified";
            SpecialPoints = 200;
        }

        public Weapon(string mainWeapon, string subWeapon, int specialPoints)
        {
            MainWeapon = mainWeapon;
            SubWeapon = subWeapon;
            SpecialPoints = specialPoints;
        }
    }
}
