//Zad 1. na 2
Console.WriteLine("Zadanie 1. \n");
for(int i = 0; i < 4; i++)
{
    for(int j = 0; j < 7; j++)
    {
        if (i == 0)
        {
            Console.Write('*');
        }
        else if (i == 1)
        {
            if(j==0 || j == 6)
            {
                Console.Write(" ");
            }
            else
            {
                Console.Write("*");
            }
        }
        else if (i == 2)
        {
            if(j==2 || j == 3 || j==4)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else
        {
            if (j == 3)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    Console.WriteLine();
}

//Zad 2. na 3
Console.WriteLine("\nZadanie 2. \n");

for(int i=0;i<3; i++)
{
    for(int j = 0; j < 6; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Zad 3. na 4
Console.WriteLine("\nZadanie 3. \n");

for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 5; j++)
    {
        if (i == 0 || i==4)
        {
            if (j == 2)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else if(i == 1 || i==3)
        {
            if(j==1|| j == 2 || j==3)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}

//Zad 4. na 5
Console.WriteLine("\nZadanie 4. \n");

for(int i=0; i < 5; i++)
{
    for(int j = 0; j < 9; j++)
    {
        if (i == 0 || i == 4)
        {
            if (j == 0 || j == 8)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else if(i == 1 || i == 3)
        {
            if(j ==0 || j== 2 || j ==6 || j == 8)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
        else
        {
            if (j % 2 == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    Console.WriteLine();
}