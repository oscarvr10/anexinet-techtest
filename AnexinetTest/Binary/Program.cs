using System;

namespace Binary
{
    /****
     * Given a number between 0 and 1 (e.g. 0.15), print its binary representation. If the number cannot be
       represented accurately in binary with at most 32 characters, just print "Error".
    ****/
    static class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to convert: ");
            var num = Console.ReadLine();
            GetBinaryRepresentation(num);
        }

        /// <summary>
        /// Given a number, gets its binary representation
        /// </summary>
        /// <param name="strNum">The number</param>
        public static void GetBinaryRepresentation(string strNum)
        {
            string binaryRep = string.Empty;
            decimal.TryParse(strNum, out decimal num);
            if(num < 0 || num > 1)
            {
                Console.WriteLine("Number must be between 0 and 1");
                Console.ReadKey();
                return;
            }

            if (num == 0 || num == 1)
            {
                Console.WriteLine("The binary representation of '" + num + "' is: " + num);
                Console.ReadKey();
                return;
            }

            try
            {
                //Get the int part from number
                var intPart = (int)num;

                //Get the decimal part from number
                var decimalPart = num - intPart;

                //Get the binary representation of int part
                var intBinary = Convert.ToString(intPart, 2);

                //Add it to representation
                binaryRep += intBinary;
                binaryRep += '.';

                //Get the binary representation of decimal part
                for (int i = 0; i < 32; i++)
                {
                    decimalPart *= 2;
                    var intFract = (int)decimalPart;

                    if (intFract == 1)
                        decimalPart -= intFract;

                    binaryRep += Convert.ToString(intFract, 2);

                    if (decimalPart == 0)
                        break;
                }

                Console.WriteLine("The binary representation of '" + num + "' is: " + binaryRep);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
