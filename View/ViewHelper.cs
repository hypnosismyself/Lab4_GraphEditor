using System.Linq;
using System.Windows.Forms;

namespace Lab4_GraphEditor.View
{
    internal class ViewHelper
    {
        private const string StepTextBox = "StepTextBox";

        // Метод проверки минуса в строке
        public bool HasMinus(string text)
        {
            // arg: text - текст

            return text.StartsWith("-");
        }

        // Метод проверки возможности ввода минуса
        public bool CanInputMinus(string text, string controlName)
        {
            if (controlName == StepTextBox)
            {
                return false;
            }
            else if (text.Length > 0 && !HasMinus(text))
            {
                return false;
            }
            else if (text.Length > 1 && HasMinus(text))
            {
                return false;
            }

            return true;
        }

        // Метод проверки возможности ввода
        public bool CanInput(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                    && e.KeyChar != ','
                    && !char.IsControl(e.KeyChar))
                return true;

            return false;
        }

        public bool HasComma(string text)
        {
            return text.Contains(",");
        }
    }
}
