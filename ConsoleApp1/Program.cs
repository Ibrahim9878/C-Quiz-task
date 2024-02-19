Console.WriteLine("Hello, World!");

string[] questions = new string[10]
    {
        "1.> What is the capital of France?",
        "2.> In which year did World War II end?",
        "3.> What is the largest planet in our solar system?",
        "4.> What is the square root of 64?",
        "5.> Which programming language is this code written in?",
        "6.> Who is known as the 'Father of Computer Science'?",
        "7.> What is the chemical symbol for gold?",
        "8.> How many continents are there?",
        "9.> What is the tallest mountain in the world?",
        "10.> What is the capital of Japan?"
    };
string[,] answers = new string[10, 4]
    {
        {"1.Paris","2.Bordeaux","3.Nice","1.Paris"},
        {"1.1944","2.1945","3.1947","2.1945"},
        {"1.Venus","2.Jupiter","3.Mars","2.Jupiter"},
        {"1.2","2.3","3.8","3.8"},
        {"1.C","2.Pyhton","3.C#","3.C#"},
        {"1.CavidAtamoglanov","2.AlanTuring","3.BraddPitt","1.CavidAtamoglanov"},
        {"1.Au","2.Ua","3.Ia","1.Au"},
        {"1.5","2.6","3.7","3.7"},
        {"1.Everest","2.Talis","3.Himalay","1.Everest"},
        {"1.China","2.Tokyo","3.Baku","3.Tokyo"}
    };
int Score = 0;
int DuzSay = 0;
int SehvSay = 0;
int j = 0;

Console.WriteLine("Enter Your Name: ");
string name = Console.ReadLine();
foreach (string i in questions)
{
    int select = 0;

    for (; j < answers.Length; j++)
    {
        do
        {
            Console.Clear();
            Console.WriteLine(i);
            int k = 0;
            for (; k < 3; k++)
            {
                bool ischeck = false;
                if (k == select)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(answers[j, k]);
                    Console.ForegroundColor = ConsoleColor.White;
                    ischeck = true;
                }
                if (!ischeck)
                    Console.WriteLine(answers[j, k]);
            }

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.UpArrow)
            {
                if (select == 0) select = 2;
                else select--;
            }
            else if (info.Key == ConsoleKey.DownArrow)
            {
                if (select == 2) select = 0;
                else select++;
            }
            else if (info.Key == ConsoleKey.Enter)
            {
                if (answers[j, select] == answers[j, 3])
                {
                    Score += 10;
                    DuzSay++;
                }
                else
                {
                    if (Score != 0)
                        Score -= 10;
                    SehvSay++;
                }
                j++;
                break;

            }

        } while (true);
        break;
    }

}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Congrats {name} You succesfully done this Quiz");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"You Have {DuzSay} Right answers and {SehvSay} Wrong answers ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"And Your Score is {Score}");
Console.ForegroundColor = ConsoleColor.White;