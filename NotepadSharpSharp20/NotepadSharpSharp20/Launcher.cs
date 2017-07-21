using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadSharpSharp20
{
    //Configures application to launch appropriate forms on startup (either one form or all of them) and tells the application to exit
    //only after all forms in the list below are closed.
    public class Launcher : ApplicationContext
    {
        //Declared public since this will be used in other classes.
        public static List<Form> forms = new List<Form>()
        {
            new Options(),
            new MainWindow()
        };
        private void onFormClosed(object sender, EventArgs e)
        {
            // If no forms are open or MainWindow form is open, close application.
            if (Application.OpenForms.Count == 0 || !forms[1].Visible)
            {
                ExitThread();
            }
        }

        public Launcher()
        {
            //If WinForms exposed a global event that fires whenever a new Form is created,
            //we could use that event to register for the form's `FormClosed` event.
            //Without such a global event, we have to register each Form when it is created
            //This means that any forms created outside of the ApplicationContext will not prevent the 
            //application close.

            foreach(var form in forms)
            {
                form.FormClosed += onFormClosed;
            }

            //to show all the forms on start
            //can be included in the previous foreach
            //foreach (var form in forms)
            //{
            //    form.Show();
            //}

            //to show only the first form on start
            forms[0].Show();
            INIParser.checkINI();
        }
    }
}
