using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxwellAparnnaVaish_FinalProject
{
    static class DiffuseBombProgram
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Maxwell_McLaughlin_G12FP_puzzle23.frmPuzzle23());
        }
    }
}
