using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHeaven.CommonCoding
{
    internal class validation_Class
    {
        public Control myInputTextBox { get; set; }
        public Label myValidationText { get; set; }


        public validation_Class(Control _myInputTextBox, Label _myValidationText)
        {
            myInputTextBox = _myInputTextBox;
            myValidationText = _myValidationText;
        }
    }
}
