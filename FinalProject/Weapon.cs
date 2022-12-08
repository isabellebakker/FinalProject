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
        private int subPercent;

		public string MainWeapon { get; set; }

		public string SubWeapon { get; set; }

		public int SpecialPoints { get; set; }

        public int SubPercent { get; set; }

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

        public void getSubPercent()
        {
            switch (SubWeapon)
            {
                case "Splat Bomb":
                    SubPercent = 70;
                    break;
                case "Suction Bomb":
                    SubPercent = 70;
                    break;
                case "Burst Bomb":
                    SubPercent = 40;
                    break;
                case "Curling Bomb":
                    SubPercent = 70;
                    break;
                case "Autobomb":
                    SubPercent = 55;
                    break;
                case "Ink Mine":
                    SubPercent = 60;
                    break;
                case "Toxic Mist":
                    SubPercent = 60;
                    break;
                case "Point Sensor":
                    SubPercent = 45;
                    break;
                case "Splash Wall":
                    SubPercent = 60;
                    break;
                case "Sprinkler":
                    SubPercent = 60;
                    break;
                case "Squid Beakon":
                    SubPercent = 75;
                    break;
                case "Fizzy Bomb":
                    SubPercent = 60;
                    break;
                case "Torpedo":
                    SubPercent = 65;
                    break;
                case "Angle Shooter":
                    SubPercent = 40;
                    break;
                default:
                    SubPercent = 10;
                    break;


            }
        }
    }
}
