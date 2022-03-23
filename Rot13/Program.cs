using System.Text;

namespace Rot13
{
    public class Program
    {
        private static void Main()
        {
            Rot13Encoder rot13Encoder = new();
            Rot13Decoder rot13Decoder = new();

            string value = rot13Encoder.Convert(new StringBuilder("хуй соси губой тряси"));
            Console.WriteLine(value);

            string value2 = rot13Decoder.Convert(new StringBuilder(value));
            Console.WriteLine(value2);
        }
    }
}