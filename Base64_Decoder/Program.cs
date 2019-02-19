using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64_Decoder
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Payload to crack:");
                var payload = Console.ReadLine();
                byte[] data = Convert.FromBase64String(payload);
                string decodedPayload = Encoding.UTF8.GetString(data);
                Console.WriteLine($"\nDecoded from Base64: {decodedPayload} \n");
                Console.WriteLine(@"Payload cracked press any button to continue and enjoy your day.");
                writeSignature();
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Bad data read. The payload provided was not Base64!");
                Console.WriteLine(@"Press any button to continue and have a great day.");
                throw;
            }

            Console.ReadLine();
        }

        static void writeSignature()
        {
            Console.WriteLine($"\n{signature.F_DEMON_SIGNATURE}");
        }
    }
}
