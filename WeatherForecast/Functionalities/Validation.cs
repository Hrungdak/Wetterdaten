using System;

namespace Functionalities
{
    public class Validation
    {
        public bool IsInteger(string value)
        {
            return int.TryParse(value, out int convertedInputToInt);
        }

        public int ConvertStringToInt(string value)
        {
            if (IsInteger(value))
                return int.Parse(value);

            throw new ArgumentException();
        }
    }
}