//1 számjegyek cseréje úgy, hogy az eredeti számhoz adva 9-et kapjunk (pl. 1->8; 5->4; 0->9...)

string f1 = "Alma4fa7dolog987";

M1(f1);

static void M1(string s)
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
}

Console.WriteLine("-----");

//2 ó, ió, ció, áció

//3 minden magánhangzó megduplázása

//4 magánhangzók cseréje *karakterre

//5 tetszőleges szövegrészlet kivágása (X.helytől Y hosszon) saját eljárással, hibás x és y esetén hibaüzenettel

//6 szöveg titkosítása: minden karakterhez hozzá adunk ASCII szerint X értéket (X=1 - nél a helyett b, b helyett c stb.)
string f6 = "TitkosABC";

M6(f6, 3);

static void M6(string s, int eltolas)
{
    for (int i = 0; i < s.Length; i++)
    {
        Console.Write((char)(s[i] + eltolas));
    }
}


//7 minden 2.és 3.betű új szövegbe

//8 szóközök kicserélés _ jelre

//9 minden karakter megkettőzése: abc->aabbcc

//10 minden 3.és 5.betű cseréje * -ra

Console.WriteLine("----");

string f10 = "abcabcabcabcdefabcdef";

M10(f10);

static void M10(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if ((i+1) % 3 == 0  || (i + 1) % 5 == 0) // i + 1 % 3 ?
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(s[i]);
        }
    }
}

//11 kisbetűből nagybetű és nagybetűből kisbetű(pl.AbC->aBc)

//12 hullámos szöveg(pl.alma -> AlMa)

Console.WriteLine("---");

string f12 = "ezlegyenabemenet";

M12(f12);
Console.WriteLine();
M12(f10);

static void M12(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (i%2==0)
        {            
            Console.Write(char.ToUpper(s[i]));
        }
        else
        {
            Console.Write(s[i]);
        }
    }
}


//13 páros és páratlan betűk cseréje(abcd->badc)

//14 minden számjegy megduplázása

//15 magánhangzók cseréje nagybetűsre(pl.abcde->AbcdE)

//16 Ékezettelenítő(á->a ö, ő->o)

//17 számok cseréje betűre 1->a, 2->b stb.

//18 magánhangzók megszámlálása(angol abc)

//19 szöveg visszafelé

Console.WriteLine("-----");
string f19 = "alma";

M19(f19);

static void M19(string s)
{
    for (int i = s.Length - 1; i >= 0; i--)
    {
        Console.Write(s[i]);
    }
}

//20 minden mássalhangzó megduplázása

//21 számok kiválogatása szövegből(pl.a1b2c3-> 123)