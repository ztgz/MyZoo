using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyZoo.UI;
using Menu = MyZoo.UI.Menu;

namespace MyZoo
{
    public static class Program
    {
        //Constants for form choises
        public const int RUNMENU = 0;
        public const int RUNZOO = 1;
        public const int RUNVETERINARY = 2;

        //Keeps track on which windows will run in the application
        public static int activeForm; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Start the menu
            RunMenu();
        }

        static void RunMenu()
        {
            activeForm = RUNMENU;

            Application.Run(new Menu());

            //If veterinary or zoo should be run
            if (activeForm == RUNVETERINARY)
            {
                RunVeterinary();
            }
            else if (activeForm == RUNZOO)
            {
                RunZoo();
            }

            //If none of the above will run, the program exits
        }

        static void RunZoo()
        {
            Application.Run(new Zoo());

            //Run menu every time zoo window is closed
            RunMenu();
        }

        static void RunVeterinary()
        {
            Application.Run(new Booking());

            //Run menu every time zoo window is closed
            RunMenu();
        }
    }
}
