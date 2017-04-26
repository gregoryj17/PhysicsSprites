using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment05
{
    class Program : Engine
    {

        public Program() : base()
        {

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.canvas.add(new Elephant(0, 0));
            Application.Run(new Program());
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program program = new Program();
            program.Canvas.add(new Elephant(0, 0));
            Application.Run(new Program());*/
        }
    }
}
