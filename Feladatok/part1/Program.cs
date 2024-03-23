using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string f1 = "alma4fa7dolog987";
            string f2 = "vakáció";
            string f3 = "TitkosABCTitkosABC";
            string f4 = "You can swallow my seed";
            string f5 = "terminatorpredatoralien";
            string f6 = "űrkápszúláőűíóé";

            Console.WriteLine("-----M1_1");           
            M1_1(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M1_2");
            M1_2(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M1_3");
            M1_3(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M2");
            M2(f2);
            Console.WriteLine("");
            Console.WriteLine("-----M3");
            M3(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M4");
            M4(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M5");
            M5(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M6");
            M6(f3, 3);
            Console.WriteLine("");
            Console.WriteLine("-----M7");
            M7(f3);
            Console.WriteLine("");
            Console.WriteLine("-----M8");
            M8(f4);
            Console.WriteLine("");
            Console.WriteLine("-----M9");
            M9(f4);
            Console.WriteLine("");
            Console.WriteLine("-----M10");
            M10(f3);
            Console.WriteLine("");
            Console.WriteLine("-----M11");
            M11(f3);
            Console.WriteLine("");
            Console.WriteLine("-----M12");
            M12(f5);
            Console.WriteLine("");
            Console.WriteLine("-----M13");
            M13(f5);
            Console.WriteLine("");
            Console.WriteLine("-----M14");
            M14(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M15");
            M15(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M16");
            M16(f6);
            Console.WriteLine("");
            Console.WriteLine("-----M17");
            M17(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M18");
            M18(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M19");
            M19(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M20");
            M20(f1);
            Console.WriteLine("");
            Console.WriteLine("-----M21");
            M21(f1);

            static void M1_1(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '0': // ASCII 48
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                            Console.Write((char)57 - s[i]);
                            break;
                        default:
                            Console.Write(s[i]);
                            break;
                    }
                }
            }//1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1->8; 5->4; 0->9...)
            static void M1_2(string s)
            {
                foreach (var item in s)
                {

                    if (item == '9')
                    {
                        Console.Write('0');
                    }
                    else if (item == '8')
                    {
                        Console.Write('1');
                    }
                    else if (item == '7')
                    {
                        Console.Write('2');
                    }
                    else if (item == '6')
                    {
                        Console.Write('3');
                    }
                    else if (item == '5')
                    {
                        Console.Write('4');
                    }
                    else if (item == '4')
                    {
                        Console.Write('5');
                    }
                    else if (item == '3')
                    {
                        Console.Write('6');
                    }
                    else if (item == '2')
                    {
                        Console.Write('7');
                    }
                    else if (item == '1')
                    {
                        Console.Write('8');
                    }
                    else if (item == '0')
                    {
                        Console.Write('9');
                    }
                    else if (item != '0')
                    {
                        Console.Write(item);
                    }



                }
            }//1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1->8; 5->4; 0->9...)
            static void M1_3(string s)
            {
                foreach (var item in s)
                {
                    Console.Write(item);
                }
            }//1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1->8; 5->4; 0->9...)
            static void M2(string s)
            {
                string result = "";
                foreach (var item in s)
                {
                    result = result + item;
                    Console.WriteLine(result);
                }
                //Console.WriteLine(result);
            }//2 ó, ió, ció, áció
            static void M3(string s)
            {
                string result = "";
                string vowels = "aeiou";
                for (int i = 0; i < s.Length; i++)
                {
                    if ((char)s[i] == (char)vowels[0] || (char)s[i] == (char)vowels[1] || (char)s[i] == (char)vowels[2] || (char)s[i] == (char)vowels[3] || (char)s[i] == (char)vowels[4])
                    {
                        result = result + (char)s[i] + (char)s[i];
                    }
                    else
                    {
                        result = result + (char)s[i];
                    }
                }
                Console.WriteLine(result);
            }//3 minden magánhangzó megduplázása
            static void M4(string s)
            {
                string result = "";
                string vowels = "aeiou";
                for (int i = 0; i < s.Length; i++)
                {
                    if ((char)s[i] == (char)vowels[0] || (char)s[i] == (char)vowels[1] || (char)s[i] == (char)vowels[2] || (char)s[i] == (char)vowels[3] || (char)s[i] == (char)vowels[4])
                    {
                        result = result + '*';
                    }
                    else
                    {
                        result = result + (char)s[i];
                    }
                }
                Console.WriteLine(result);
            }//4 magánhangzók cseréje *karakterre
            static void M5(string s)
            {
                int i = 0;
                string result = "";
                while (i < 5)
                {
                    try
                    {
                        result = s.Substring(0, i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);

                    }
                    Console.WriteLine(result);

                    i++;
                }


            }//5 tetszőleges szövegrészlet kivágása (X.helytől Y hosszon) saját eljárással, hibás x és y esetén hibaüzenettel
            static void M6(string s, int eltolas)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.Write((char)(s[i] + eltolas));
                }
            }//6 szöveg titkosítása: minden karakterhez hozzá adunk ASCII szerint X értéket (X=1 - nél a helyett b, b helyett c stb.)
            static void M7(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 3 == 1 || i % 3 == 2)
                    {
                        Console.Write(s[i]);
                    }
                    else
                    {
                        Console.WriteLine("");
                        ; }
                }
            }//7 minden 2.és 3.betű új szövegbe
            static void M8(string s)
            {
                string withoutSpaces = s.Replace(" ", "");
                Console.WriteLine(withoutSpaces);

            }//8 szóközök kicserélés _ jelre
            static void M9(string s)
            {
                foreach (var item in s)
                {
                    string result = item.ToString() + item.ToString();
                    Console.Write(result);
                }
            }//9 minden karakter megkettőzése: abc->aabbcc
            static void M10(string s)
            {
                string astrix = "*";
                for (int i = 2; i < s.Length; i += 3)
                {

                    s = s.Remove(i, 1).Insert(i, astrix.ToString());
                }

                for (int i = 4; i < s.Length; i += 5)
                {

                    s = s.Remove(i, 1).Insert(i, astrix.ToString());
                }
                Console.WriteLine(s);
            }//10 minden 3.és 5.betű cseréje * -ra
            static void M11(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (Char.IsUpper(s[i]))
                    {
                        Console.Write(s[i].ToString().ToLower());
                    }
                    else 
                    {
                        Console.Write(s[i].ToString().ToUpper()); 
                    }
                }

            }//11 kisbetűből nagybetű és nagybetűből kisbetű(pl.AbC->aBc)
            static void M12(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(s[i].ToString().ToUpper()); //or char.ToUpper(s[i])
                    }
                    else 
                    {
                        Console.Write(s[i]); 
                    }
                   
                }
                
            }//12 hullámos szöveg(pl.alma -> AlMa)
            static void M13(string s)
            {
                string result = "";
                try
                {                  
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            // Páros indexű karakterek
                            result += s[i + 1];
                        } 
                        else
                        {
                            // Páratlan indexű karakterek
                            result += s[i - 1];
                        }
                    }                  
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.ToString());                   
                }
                Console.WriteLine(result);
            }//13 páros és páratlan betűk cseréje(abcd->badc)
            static void M14(string s)
            {
                string result = "";
                foreach(var c in s)
                {
                    if (Char.IsDigit(c))
                    {
                        Console.Write(c.ToString() + c.ToString());
                        result += c.ToString() + c.ToString();
                    }
                    else
                    {
                        Console.Write(c.ToString());                       
                        result += c.ToString();
                    }
                }
                Console.WriteLine(result);
            }//14 minden számjegy megduplázása
            static void M15(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].Equals('a') || s[i].Equals('e') || s[i].Equals('i') || s[i].Equals('o') || s[i].Equals('u'))
                    {
                        Console.Write(s[i].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write(s[i].ToString());
                    }
                }
            }//15 magánhangzók cseréje nagybetűsre(pl.abcde->AbcdE)
            static void M16(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case 'á': // ASCII 48
                            Console.Write('a');
                            break;
                        case 'é':
                            Console.Write('e');
                            break;
                        case 'í':
                            Console.Write('i');
                            break;
                        case 'ó':
                            Console.Write('o');
                            break;
                        case 'ő':
                            Console.Write('ö');
                            break;
                        case 'ú':
                            Console.Write('u');
                            break;
                        case 'ű':
                            Console.Write('ü');
                            break;                      
                        default:
                            Console.Write(s[i]);
                            break;
                    }
                }
            }//16 Ékezettelenítő(á->a ö, ő->o)
            static void M17(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    switch (s[i])
                    {
                        case '0': // ASCII 48
                            Console.Write('a');
                            break;
                        case '1':
                            Console.Write('b');
                            break;
                        case '2':
                            Console.Write('c');
                            break;
                        case '3':
                            Console.Write('d');
                            break;
                        case '4':
                            Console.Write('e');
                            break;
                        case '5':
                            Console.Write('f');
                            break;
                        case '6':
                            Console.Write('g');
                            break;
                        case '7':
                            Console.Write('h');
                            break;
                        case '8':
                            Console.Write('i');
                            break;
                        case '9':
                            Console.Write('j');
                            break;
                        default:
                            Console.Write(s[i]);
                            break;
                    }
                }
            }//17 számok cseréje betűre 1->a, 2->b stb.
            static void M18(string s)
            {
                int count = 0;
                int counter = 0;
                while (count < s.Length) 
                { 
                   if (s[count] == ('a') || s[count].Equals('e') || s[count].Equals('i') || s[count].Equals('o') || s[count].Equals('u'))
                    {                       
                        counter++;
                        //Console.Write(count + "\n");
                    }                  
                    count++;                   
                }
                Console.WriteLine(counter);
            }//18 magánhangzók megszámlálása(angol abc)
            static void M19(string s)
            {
                for(int i = s.Length-1; i >= 0; i--)
                {
                    Console.Write(s[i]);
                    
                }
            }//19 szöveg visszafelé
            static void M20(string s)
            {
                
                List<string> number = new List<string>() { "a", "e", "i", "o", "u", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
                for(int i = 0; i < s.Length; i++)
                {
                    if (number.Contains(s[i].ToString()))
                    {
                        Console.Write(s[i]);
                       
                    }
                    else
                    {
                        Console.Write($"{s[i]}{s[i]}");
                        //Console.Write(s[i].ToString() + s[i].ToString());
                    }
                }
            }//20 minden mássalhangzó megduplázása
            static void M21(string s)
            {
                string result = "";
                char[] numbers = new char[] {};
                var numsList = numbers.ToList();
                foreach (var c in s)
                {
                    if (Char.IsDigit(c))
                    {
                      numsList.Add(c);
                    }
                    else
                    {
                        continue;
                    }
                }
                foreach (var item in numsList)
                {
                    Console.Write(item);
                }
            }//21 számok kiválogatása szövegből(pl.a1b2c3-> 123)

        }
    }
}



