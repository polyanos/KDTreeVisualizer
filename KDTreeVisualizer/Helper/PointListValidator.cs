using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KDTreeVisualizer.Helper
{
    class PointListValidator : Validator<string>
    {
        private static string regexString = @"^(?:\d+,\d+;)+$";
        private int xMax;
        private int yMax;
        private Regex regex;

        public PointListValidator(int xMax, int yMax)
        {
            this.xMax = xMax;
            this.yMax = yMax;
            this.regex = new Regex(regexString);
        }

        public Tuple<bool, string> validate(string input)
        {
            Tuple<bool, string> result = null;
            int dimension = 0;

            if (regex.IsMatch(input))
            {
                foreach (string coordinate in input.Split(';'))
                {
                    dimension = 0;
                    foreach (string number in coordinate.Split(','))
                    {
                        int integer = 0;
                        try
                        {
                            integer = int.Parse(number);
                        }
                        catch (FormatException)
                        {
                            result = new Tuple<bool, string>(false, "The x/y values can only be valid integers.");
                            break;
                        }

                        if (dimension % 2 == 0)
                        {
                            if (integer > xMax)
                            {
                                result = new Tuple<bool, string>(false, "The x values cannot be higher than " + xMax + ".");
                                break;
                            }
                        }
                        else
                        {
                            if (integer > yMax)
                            {
                                result = new Tuple<bool, string>(false, "The y values cannot be higher than " + yMax + ".");
                                break;
                            }
                        }
                        dimension++;
                    }
                    if(result != null)
                    {
                        break;
                    }
                }
            }
            else
            {
                result = new Tuple<bool, string>(false, "The input string is not valid, check if you end each coordinate with ; and seperate the x and y values with ,");
            }

            return result;
        }
    }
}
