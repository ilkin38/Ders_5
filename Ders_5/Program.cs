using System.Collections;

void tapsiriq1()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Natural eded - {i}");
    }
}

void tapsiriq2()
{
    Console.Write("Natural tek ededler hara kimi yazilsin -- ");
    int a = int.Parse(Console.ReadLine());
    for (int i = 0; i < a; i++)
    {
        if (i % 2 == 1)
        {
            Console.WriteLine($"Natural tek eded -- {i}");
        }
    }
}

void tapsiriq3()
{
    int[] array1 = new int[5];
    int a = 0;
    // int number = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = int.Parse(Console.ReadLine());

        a += array1[i];



    }
    Console.WriteLine($"Yazdiginiz ededlerin cemi{a}");
    Console.WriteLine("");
    float edediOrta = (float)a / array1.Length;
    Console.WriteLine($"Yazidiginiz ededlerin ededi ortasi -- {edediOrta}");


}

void tapsiriq4(int eded)
{

    for (int i = 1; i < eded; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            int a = i * j;
            Console.Write($"{i}x{j}=" + a + ", ");

            if (j == 10)
            {
                Console.WriteLine("");
            }
            /* if (a< 10 && i < 10)
              {
                  Console.Write($" | {i}+{j}=" + a + "   | ");
              }*/
        }
    }
}

void tapsiriq5()
{
    int a = 1;
    for (int i = 1; i < 100; i++)
    {
        for (int j = 1; j <= a; j++)
        {
            Console.Write('*');

        }
        Console.WriteLine("");
        a++;
    }
}

void tapsiriq6()
{
    int g = 0, a = 1;
    for (int i = 0; i < 10; i++)
    {
        for (int j = 0; j < g; j++)
        {
            Console.Write($"{a} ,");
            a++;
        }
        g++;
        Console.WriteLine("");
    }
}

void tapsiriq7()
{
    int g = 1;
    int cavab = 0;
    int G = int.Parse(Console.ReadLine());
    string[] array1 = new string[G];
    for (int i = 0; i < G; i++)
    {
        for (int j = 0; j < g; j++)
        {
            array1[i] = array1[i] + "9";
            Console.Write("9");
        }
        if (i == G - 1)
        {
            Console.Write("=");
        }
        else
        {
            Console.Write("+");
        }
        cavab += int.Parse(array1[i]);
        g++;
    }
    Console.Write(cavab);
}

void tapsiriq8()
{

    int sadeEded;


    for (int i = 1; i <= 100; i++)
    {
        sadeEded = i + 1;
        bool _sadeEded = sadeEded % 2 != 0 && sadeEded % 3 != 0 && sadeEded % 5 != 0 && sadeEded % 7 != 0;
        bool _2357 = sadeEded == 2 || sadeEded == 3 || sadeEded == 5 || sadeEded == 7;
        if (_sadeEded || _2357)
        {

            Console.WriteLine(sadeEded);
        }



    }
}

void tapsiriq9()
{
    int eded = int.Parse(Console.ReadLine());
    for (int i = eded - 1; i < eded; i--)
    {
        for (int j = 1; j < eded; j++)
        {
            bool cavab = i + j == eded;
            if (cavab)
            {
                if (eded % 2 == 0)
                {
                    if (i == j)
                    {
                        Console.WriteLine($"{i}+{j}={eded}");
                        return;
                    }
                }
                else
                {
                    if (j == i + 1)
                    {
                        return;
                    }
                }

                Console.WriteLine($"{i}+{j}={eded}");
            }
        }

    }
}

void tapsiriq10()
{
    string _eded = Console.ReadLine();
    bool[] _ededBool = new bool[_eded.Length];
    for (int i = 0; i < _eded.Length; i++)
    {
        if (_eded[i] == _eded[_eded.Length - (i + 1)])
        {
            _ededBool[i] = true;
        }
        else
        {
            _ededBool[i] = false;
        }
    }
    if (_ededBool.Contains(false))
    {
        Console.WriteLine($"{_eded} ededi polindrom deyildir");
    }
    else
    {
        Console.WriteLine($"{_eded} ededi polindromdur");
    }
   
}
tapsiriq10();