using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Firearm AK = new Rifle("AK-47", 30, 600);
            AK.Shoot();
            AK.Reload();
            AK.Print_Info();
            AK.PrintHierarchy();

            Pistol Revolver = new Pistol("Revolver", 7);
            Revolver.Shoot();
            Revolver.Print_Info();
            Revolver.PrintHierarchy();

            Steelarm Knife = new Steelarm("Knife");
            Knife.Shoot();
            Knife.Print_Info();
            Knife.PrintHierarchy();
        }
    }
}
