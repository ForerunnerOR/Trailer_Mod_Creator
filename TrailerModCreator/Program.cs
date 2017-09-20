using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrailerModCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    //Classes definition

    public class defTrailer
    {
        public string filePath { get; set; }
        public string unitName { get; set; }
    }

    public class defChassisCargo
    {
        public string filePath { get; set; }
        public string displayName { get; set; }
    }
    
}
