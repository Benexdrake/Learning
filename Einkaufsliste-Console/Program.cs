namespace Einkaufsliste_Console
{
    static class Program
    {

        static void Main()
        {
            SqlDB sql = new SqlDB();
            Items items = new Items();

            ConsoleKeyInfo key;

            bool again = true;
            bool isZahl;



            Console.WriteLine("Willkommen in der Einkaufsliste");
            while (true)
            {
                Console.WriteLine("Bitte wählen sie zwischen 1-Liste anzeigen, 2-neuer Eintrag oder 3-Liste löschen, zum beenden ESC drücken");
                // Console.ReadKey() liest die eingabe, z.B ob man 1,2,3 oder ESC gedrückt hat.
                key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.Clear();
                            // Zeigt alle Einträge aus der Table Liste an
                            sql.readtSql(@"select * from Liste;");
                            Console.WriteLine("\n\nWollen sie zum Anfang der Menüs? J/N");

                            key = Console.ReadKey();

                            switch (key.Key)
                            {
                                case ConsoleKey.J:
                                    again = true;
                                    Console.Clear();
                                    break;

                                case ConsoleKey.N:
                                    again = false;
                                    break;
                            }
                            break;
                        }

                    // Wenn 2 gedrückt wurde
                    case ConsoleKey.D2:
                        {
                            while (true)
                            {
                                Console.WriteLine("Für die Einkaufsliste brauchen wir den Produktnamen, die Anzahl und den Ort");
                                Console.Write("Bitte geben Sie den Produktnamen an: ");
                                items.ProduktName = Console.ReadLine();

                                Console.Write("Bitte geben Sie die Anzahl des Produktes an: ");
                                do
                                {
                                    // Überprüft ob die Eingabe eine Ganzzahl war, da string nur ein int werden kann wenn es nur aus Ganzzahlen besteht
                                    isZahl = int.TryParse(Console.ReadLine(), out int zahl);
                                    if (isZahl == true)
                                    {
                                        // War die Eingabe eine Zahl, wird diese in dem Objekt items und deren Variable Anzahl gespeichert
                                        items.Anzahl = zahl;

                                    }
                                    else
                                    {
                                        // Die Eingabe war keine Ganzzahl, so wird eine neue Eingabe getätigt
                                        Console.WriteLine("Bitte geben Sie eine Ganzzahl ein: ");
                                    }
                                }
                                while (isZahl == false);

                                Console.Write("Bitte geben sie den Ort an: ");
                                items.LadenName = Console.ReadLine();
                                Console.WriteLine("\n\n");

                                Console.WriteLine("Ihre Eingabe war:\nProduktname: " + items.ProduktName + "\nAnzahl: " + items.Anzahl + "\nOrt: " + items.LadenName);

                                Console.WriteLine("Sind sie mit der EIngabe zufrieden? J/N");
                                key = Console.ReadKey();

                                if (key.Key == ConsoleKey.N)
                                {
                                    // Wenn man mit der Eingabe unzufrieden war, kann man diese neu eingeben
                                    continue;
                                }
                                else if (key.Key == ConsoleKey.J)
                                {
                                    // Wenn man mit der Eingabe zufrieden war, wird eine Query an SQL geschickt
                                    items.Person = "Ben";
                                    sql.writeSql("insert into Liste(PersonName, ProduktName, ProduktAnzahl, Ladenname)" +
                                                 "values( " + "'" + items.Person + "'" + "," + "'" + items.ProduktName + "'" + "," + items.Anzahl + "," + "'" + items.LadenName + "'" + ");");
                                    // Console.Clear() leert die Konsole
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            break;
                        }
                    case ConsoleKey.D3:
                        // truncate löscht die Einträge, löscht die Einkaufsliste
                        sql.deleteList("truncate Liste;");
                        Console.Clear();
                        break;

                    case ConsoleKey.Escape:
                        {
                            // Escape wurde gedrückt und somit wird das Programm beendet.
                            again = false;
                            break;
                        }
                    default:
                        Console.Clear();
                        break;
                }
                // Fragt am Ende, ob man nochmal möchte, wenn again auf false steht, wird mit einem break die Schleife beendet.
                if (again == false)
                {
                    break;
                }

            }




        }
    }
}