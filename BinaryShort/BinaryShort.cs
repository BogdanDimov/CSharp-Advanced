using System;

namespace BinaryShort
{
    class BinaryShort
    {
        static string ShortToBin(short n)
        {
            string bin = string.Empty;
            bool numberIsNegative = false;

            if (n < 0)
            {
                //if (n == short.MinValue)
                //{
                //    return "1000000000000000";
                //}

                numberIsNegative = true;
                n *= -1;
            }
            //else if (n == 0)
            //{
            //    return "0000000000000000";
            //}

            while (n > 0)
            {
                bin = n % 2 + bin;
                n /= 2;
            }

            
            for (int i = 0; i < bin.Length % 16; i++) //add missing zeros
            {
                bin = "0" + bin;
            }

            if (numberIsNegative)
            {
                char[] bin_c = new char[16]; // create char to store negated values
                bin_c[0] = '1'; // MSB is always 1 in negative numbers.

                for (int i = 1; i < bin.Length; i++)
                {
                    if (bin[i] == '1')
                    {
                        bin_c[i] = '0';
                    }
                    else
                    {
                        bin_c[i] = '1';
                    }
                }

                // 3rd step -- add 1
                bool carry = false;
                if (bin_c[bin_c.Length - 1] == '1')
                {
                    carry = true;
                    bin_c[bin_c.Length - 1] = '0';
                }
                else
                {
                    bin_c[bin_c.Length - 1] = '1';
                }

                for (int i = bin_c.Length - 2; i >= 0; i--)
                {
                    if (carry == true)
                    {
                        if (bin_c[i] == '0')
                        {
                            bin_c[i] = '1';
                            carry = false;
                        }
                        else
                        {
                            bin_c[i] = '0';
                        }
                    }
                }

                return new string(bin_c);
            }

            return bin;
        }

        static void Main()
        {
            short n = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortToBin(n));
        }
    }
}
