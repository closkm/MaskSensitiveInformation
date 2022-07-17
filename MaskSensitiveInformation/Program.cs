using System.Text;

namespace MaskSensitiveInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a secret");

            string secret = Console.ReadLine();

            if(secret.Length <= 4)
            {
                Console.WriteLine("choose a longer secret next time");
                StringBuilder newSecret = new StringBuilder();
                for (int i = 0; i < secret.Length; i++)
                {
                    newSecret.Append(secret[i]);
                }
                Console.WriteLine(newSecret);
            }else
            {
                StringBuilder newSecret = new StringBuilder();
                for (int i = 0; i < secret.Length; i++)
                {
                    if(i < secret.Length - 4)
                    {
                    newSecret.Append("*");
                    }
                    else
                    {
                        newSecret.Append(secret[i]);
                    }
                }
                Console.WriteLine(newSecret);
            }
        }
    }
}