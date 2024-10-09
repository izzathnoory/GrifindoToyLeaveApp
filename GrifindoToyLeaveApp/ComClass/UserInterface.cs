using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace GrifindoToyLeaveApp.ComClass
{
    internal class UserInterface
    {

        private static Button PreviousButton = null;
        //Form panel changing code
        public static void LoadPanelForm(Form Form_Name , Panel Panel_Name) 
        { 
            Panel_Name.Controls.Clear();

            Form_Name.TopLevel = false;
            Form_Name.AutoScroll = true;
            Panel_Name.Controls.Add(Form_Name);
            Form_Name.FormBorderStyle = FormBorderStyle.None;
            Form_Name.Dock = DockStyle.Fill;
            Form_Name.Show();
        }
        //Application close button code
        public static void CloseApplication()
        {
            Application.Exit();
        }

        //Form Close Button Code
        public static void CloseForm(Form form)
        {
            form.Close();
        }

        //Application Minimise button code
        public static void MinimizeApplication(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        //Open New Form Without Closing the current form code
        public static void OpenNewFormWithoutCloseCurrentForm(Form NewForm)
        {
            NewForm.Show();
        }

        public static void ChangeButtonColor(Button CurrentButton)
        {
            if (CurrentButton == null) return;
            if (PreviousButton != null)
            {
                PreviousButton.BackColor = Color.FromArgb(13, 27, 42);
                PreviousButton.ForeColor = Color.White;
            }
            CurrentButton.BackColor = Color.LightGray;
            CurrentButton.ForeColor = Color.Black;
            PreviousButton = CurrentButton;
        }
    }
}
