namespace Messages
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string text = string.Empty;
            for (int i = 1; i <= num; i++)
            {
                int code = int.Parse(Console.ReadLine());

                switch (code)
                {
                    case 2:
                        text += "a"; break;
                    case 22:
                        text += "b"; break;
                    case 222:
                        text += "c"; break;
                    case 3:
                        text += "d"; break;
                    case 33:
                        text += "e"; break;
                    case 333:
                        text += "f"; break;
                    case 4:
                        text += "g"; break;
                    case 44:
                        text += "h"; break;
                    case 444:
                        text += "i"; break;
                    case 5:
                        text += "j"; break;
                    case 55:
                        text += "k"; break;
                    case 555:
                        text += "l"; break;
                    case 6:
                        text += "m"; break;
                    case 66:
                        text += "n"; break;
                    case 666:
                        text += "o"; break;
                    case 7:
                        text += "p"; break;
                    case 77:
                        text += "q"; break;
                    case 777:
                        text += "r"; break;
                    case 7777:
                        text += "s"; break;
                    case 8:
                        text += "t"; break;
                    case 88:
                        text += "u"; break;
                    case 888:
                        text += "v"; break;
                    case 9:
                        text += "w"; break;
                    case 99:
                        text += "x"; break;
                    case 999:
                        text += "y"; break;
                    case 9999:
                        text += "z"; break;
                    case 0:
                        text += " "; break;
                }
            }
            Console.WriteLine(text);
        }
    }
}

/*
  int letterCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= letterCount; i++)
            {
                 string line = Console.ReadLine();
                int clickCount = line.Length;
                char digitChar = line[0];
                string smsText = "";
                switch (digitChar)
                {
                    case '2':
                         smsText +=(char)(96 + clickCount);
                        break;
                   
                    case 3:
                          smsText +=(char)(99 + clickCount); break;
                    
                    case 4:
                          smsText +=(char)(102 + clickCount); break;
                    
                    case 5:
                         smsText +=(char)(105 + clickCount); break;
                 
                    case 6:
                         smsText +=(char)(108 + clickCount); break;
                    
                    case 7:
                         smsText +=(char)(111 + clickCount); break;
                    
                    case 8:
                        smsText +=(char)(115 + clickCount); break;
                   
                    case 9:
                          smsText +=(char)(118 + clickCount); break;
                
                    case 0:
                        smsText += " "; break;
                }
            }
            Console.WriteLine(smsText);
 */