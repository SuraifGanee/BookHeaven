using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven.CommonCoding
{
    internal class common_Class
    {

        public static void appsCloseBtnFun()
        {
            Application.Exit();
        }

        public static void formCloseBtnFun(Form formName)
        {
            formName.Close();
        }


        public static void appsMinBtnFun(Form formName)
        {
            formName.WindowState = FormWindowState.Minimized;
        }


        public static void appsNewFormOpenBtnWithoutCurrentFormClose(Form formName)
        {
            formName.Show();
        }


        public static void appsNewFormOpenBtnWithCurrentFormClose(Form formName,
            Form currentFom)
        {
            formName.Show();
            currentFom.Hide();
        }


        public static void appsFormLoadInsidePanel(Form formName, Panel panelName)
        {
            panelName.Controls.Clear();

            formName.TopLevel = false;
            formName.AutoScroll = true;
            panelName.Controls.Add(formName);
            formName.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formName.Dock = DockStyle.Fill;
            formName.Show();

        }

        public static bool isEmptyValidation(List<validation_Class> textBoxes)
        {
            bool myInputStatus = true;

            foreach (validation_Class combo in textBoxes)
            {
                if (combo.myInputTextBox.Text != "")
                {
                    combo.myValidationText.Visible = false;
                }
                else
                {
                    combo.myValidationText.Visible = true;
                    myInputStatus = false;
                }
            }

            return myInputStatus;
        }



        public static void clearInputs(List<Control> myInputs)
        {
            foreach (Control control in myInputs)
            {

                control.Text = "";

            }
        }
    }
}

