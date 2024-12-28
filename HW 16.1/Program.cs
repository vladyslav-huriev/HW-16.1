using System;
using System.IO;
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Please, enter the way to the doc: ");
            string sourcePath = Console.ReadLine();
            Console.Write("Please, enter the way to the doc where you want to copy the doc: ");
            string destinationPath = Console.ReadLine();
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("The doc does not exist. CHech the way and enter it again");
                return;
            }
            File.Copy(sourcePath, destinationPath, overwrite: true);
            Console.WriteLine("The doc was copied");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error has ocured: {ex.Message}");
        }
    }
}
