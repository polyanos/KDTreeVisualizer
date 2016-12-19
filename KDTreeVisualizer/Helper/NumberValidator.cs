using KDTreeVisualizer.Helper.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class NumberValidator : Validator
    {
        public Tuple<bool, string> validate(string input)
        {
            Tuple<bool, string> result;
            try
            {
                int.Parse(input);
                result = new Tuple<bool, string>(true, "");
            }
            catch (FormatException)
            {
                result = new Tuple<bool, string>(false, "The input is not a valid interger.");
            }
            catch (OverflowException)
            {
                result = new Tuple<bool, string>(false, "The cannot be higher than 2147483647");
            }

            return result;
        }
    }
}
