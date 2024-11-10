using System;
using System.Windows.Forms;

namespace StudentInformationForm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form (Form1)
            Application.Run(new Form1());
        }
    }
}
