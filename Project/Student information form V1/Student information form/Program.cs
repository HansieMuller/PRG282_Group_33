using System;
using System.Windows.Forms;

namespace Student_information_form
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enables visual styles and sets default text rendering to be compatible with older Windows versions
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the application with Form1
            Application.Run(new Form1());
        }
    }
}
