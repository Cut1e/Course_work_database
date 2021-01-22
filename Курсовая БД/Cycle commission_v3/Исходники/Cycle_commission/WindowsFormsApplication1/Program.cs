using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
   
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string writePath = @"put.dat";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(writePath))
            {
                using (StreamReader sr = new StreamReader(writePath))
                    Application.Run(new Cycle_selection());                        
            }
            else
              Application.Run(new Base_selection());
        }
    }
}
