using System;
using System.Text;

namespace DecodeAndDecrypt
{

    class DecodeAndDecrypt
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder lengthOfCypherSB = new StringBuilder();
            int lengthOfCypher = 0;

            #region find out length of cypher
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (char.IsNumber(input[i]))
                {
                    lengthOfCypherSB.Append(input[i]);
                }
                else
                {
                    break;
                }
            }

            lengthOfCypher = Convert.ToInt32(lengthOfCypherSB.ToString());
            #endregion

            #region Get encoded message
            StringBuilder encodedMessage = new StringBuilder();
            encodedMessage.Append(input[0]);
            for (int i = 1; i < input.Length - lengthOfCypherSB.Length; i++)
            {
                if (char.IsNumber(input[i]))
                {
                    int repeatTimes = input[i] - '0' - 1;
                    for (int j = 0; j < repeatTimes; j++)
                    {
                        encodedMessage.Append(input[i + 1]); //append n - 1 times the same character
                    }
                }
                else
                {
                    encodedMessage.Append(input[i]);
                }
            }
            #endregion

            //tuka trqbwa da razviq slu4aq kogato 6ifara e po-golqm

            var message = new StringBuilder(encodedMessage.ToString().Substring(0, encodedMessage.Length - lengthOfCypher));
            var cypher = new StringBuilder(encodedMessage.ToString().Substring(message.Length, lengthOfCypher));
            if (message.Length > cypher.Length)
            {
                cypher.Append(cypher.ToString().Substring(0, message.Length - cypher.Length));
            }

            var decryptedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                int neshto = (message[i] - 'A') ^ (cypher[i] - 'A');
                decryptedMessage.Append((char)(neshto + 'A'));
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}