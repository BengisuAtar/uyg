using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uyg5
{
    internal static class Program

    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Araclar araba1=new Araclar();
            Console.WriteLine("defaults");
            araba1.renk = "mavi";
            Console.WriteLine(araba1.renk);
            Console.WriteLine(araba1.model);
            Console.WriteLine(araba1.tekersayisi);
            Console.WriteLine(araba1.yas);
            int yilkac=Convert.ToInt16(Console.ReadLine());
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Console.ReadKey();
        }
    }
}
