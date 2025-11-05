using System;

namespace PasswordStrengthProgram;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("Input Password: ");
      string password = Console.ReadLine();
      
      Console.WriteLine("Password length: " + password.Length);

      if (password.Length < 8)
        {
            Console.WriteLine("Password is too short -- it should be atleast 8 characters.");
        }
      else if (password.Length < 12)
        {
            Console.WriteLine("Password is medium strength.");
        }
      else
        {
            Console.WriteLine("Password length is okay!");
        }
    }
}
