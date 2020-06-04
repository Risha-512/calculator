using System;
using System.Globalization;

namespace ClassLibrary
{
    public static class Converter
    {
        private const double EPS = 1e-15;
        public static CultureInfo cultInfo = CultureInfo.InvariantCulture;
        
        public static string Convert(string data, int origNumBase, int resNumBase = 10)
        {
            if (origNumBase == resNumBase)
                return data;

            var sign = "";
            if (data[0] == '-')
            {
                data = data.Remove(0, 1);
                sign = "-";
            }

            var numSplit = data.Split('.');

            ulong numDec = 0;
            var fractNumDec = 0.0d;

            if (numSplit[0] != "0")
            {
                numDec = origNumBase != 10
                    ? ConvertOtherBaseToDec(numSplit[0], origNumBase)
                    : ulong.Parse(numSplit[0]);
            }

            if (numSplit.Length == 2)
            {
                fractNumDec = origNumBase != 10
                    ? ConvertFractionalToDec(numSplit[1], origNumBase)
                    : double.Parse("0." + numSplit[1], cultInfo);
            }

            return sign + 
                (numDec == 0
                    ? "0"
                    : ConvertDecToOtherBase(numDec, resNumBase))
                + (Math.Abs(fractNumDec) <= EPS
                    ? ""
                    : $".{ConvertFractionalToOtherBase(fractNumDec, resNumBase)}");
        }

        private static ulong ConvertOtherBaseToDec(string numString, int numBase)
        {
            int n = numString.Length;
            ulong decimalNumber = 0;

            for (int i = 0; i < n; i++)
                decimalNumber += (ulong)((
                    numString[i] < 'A'
                        ? numString[i] - '0'
                        : numString[i] - 'A' + 10
                    ) * Math.Pow(numBase, n - i - 1));

            return decimalNumber;
        }

        private static string ConvertDecToOtherBase(ulong num, int numBase)
        {
            var resultString = "";
            ulong result = num, remainder;

            while (result != 0)
            {
                remainder = result % (ulong)numBase;

                resultString = resultString.Insert(0, remainder < 10
                    ? remainder.ToString()
                    : ((char)(remainder + 55)).ToString());

                result /= (ulong)numBase;
            }

            return resultString;
        }

        private static double ConvertFractionalToDec(string numString, int numBase)
        {
            var n = numString.Length;
            var fractionalDecNum = 0.0d;

            for (int i = 0; i < n; i++)
            {
                fractionalDecNum += (numString[i] < 'A'
                        ? numString[i] - '0'
                        : numString[i] - 'A' + 10
                    ) * Math.Pow(numBase, -i - 1);
            }

            return fractionalDecNum;
        }

        private static string ConvertFractionalToOtherBase(double num, int numBase)
        {
            var resultString = "";

            for (int i = 0; i < 15 && Math.Abs(num) >= EPS; i++)
            {
                num *= numBase;
                var intPart = Math.Truncate(num);

                resultString += (char)(intPart < 10
                    ? intPart + '0'
                    : intPart + 'A' - 10);

                num -= intPart;
            }

            return resultString;
        }
    }
}
