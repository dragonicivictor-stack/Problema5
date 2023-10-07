using System.Xml.Schema;

namespace Problema5
{
    internal class Program
    {
        public enum Severity   // nivele de severitate
        {
            High,
            Warning,
            Info,
            Debug
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduceti nivelul de importanta (High, Warning, Info, Debug) : ");
            string severityInput = Console.ReadLine();

            // eliminam cazul in care nu primim nivelul de importanta corect

            if (!Enum.TryParse<Severity>(severityInput, true, out Severity severity)) 
            {
                Console.WriteLine("Nivel de importanta invalid");
                Console.ReadLine(); //doar ca sa ramana deschis terminalul
                return;
            }
            Console.WriteLine("Introduceti mesajul: ");
            string message = Console.ReadLine();

            WriteMessage(severity, message);
        }

        private static void WriteMessage(Severity severity, string? message)
        {
            switch (severity)  // selectarea culorii in functie de severitate
            {
                case Severity.High:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Severity.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;  //aici nu am gasit portocaliu
                    break;
                case Severity.Info:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Severity.Debug:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                default:
                    throw new Exception("A aparut o eroare");
            }
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine(); //doar ca sa ramana deschis terminalul
        }

    }

}