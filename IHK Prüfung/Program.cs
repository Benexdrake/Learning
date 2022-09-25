using IHK_Prüfung;

namespace IHK_Prüfung
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Ob dies nun per commandline funktioniert weiss ich nicht, aber so stelle ich mir den Zugriff vor.
            // über args ein command.
            if(args != null || args.Length == 0)
            {
                Console.WriteLine("Bitte wählen Sie zwischen:");
                Console.WriteLine("1. GA1_AE");
                Console.WriteLine("2. GA1_SI");
                Console.WriteLine("3. GA2");
                Console.WriteLine("4. AP1");
                Console.WriteLine("Bitte eine Nummer von 1-3 eingeben!");
        
                string choice = Console.ReadLine();
        
                bool isNumber = int.TryParse(choice, out int number);
                if (isNumber)
                {
                    Randomizer randoms = new();
                    Helper.Exam exam = new Helper.Exam();
                    switch (number)
                    {
                        case 1:
                            exam = Helper.Exam.GA1_AE;
                            break;
                        case 2:
                            exam = Helper.Exam.GA1_SI;
                            break;
                        case 3:
                            exam = Helper.Exam.GA2;
                            break;
                        case 4:
                            exam = Helper.Exam.AP1;
                            break;
                        default:
                            Console.WriteLine("Falsches Commando, bitte zwischen 1. GA1_AE, 2. GA1_SI, 3. GA2 und 4. AP1 wählen!");
                            Console.WriteLine("Bitte eine Nummer von 1-4 eingeben!");
                            break;
                    }
                            randoms.Start(exam);
                }
            }
            else
            {
                Helper.Exam exam = new Helper.Exam();
                switch (args[0])
                {
                    case "GA1_AE":
                        exam = Helper.Exam.GA1_AE;
                        break;
                    case "GA1_SI":
                        exam = Helper.Exam.GA1_SI;
                        break;
                    case "GA2":
                        exam= Helper.Exam.GA2;
                        break;
                    case "AP1":
                        exam = Helper.Exam.AP1;
                        break;
                    default:
                        Console.WriteLine("Falsches Commando, bitte zwischen GA1_AE, GA1_SI, GA2 und AP1 wählen!");
                        break;
                }
                Randomizer randoms = new();
                randoms.Start(exam);
            }
        
        }
    }
}
