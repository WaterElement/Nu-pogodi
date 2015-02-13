using System;
using System.Collections.Generic;
using System.Threading;



class Egg
{
    public int x;
    public int y;
    public string z;
    public ConsoleColor color;
}
class NuPagadi
{
    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }
    static void Main()
    {
        Console.BufferHeight =  100;
        Console.BufferWidth =  200;
        //Console.WindowHeight = Console.BufferHeight;      // tuk mi dava greshka ne iska da gi priravni, moje i v moq komp da e!!
        //Console.WindowWidth = Console.BufferWidth;

        int basketUpLevel = 10;         // this depends on pressed key up ot down
        int basketDownLevel = 15;         // this depends on pressed key up ot down       
        string basketPosition = "left"; // this depends on pressed key left ot rignht
        int lives = 5;
        double speed = 0;
        double maxSpeed = 400;
        int score = 0;

        Random randomGenerator = new Random();

        List<Egg> eggsUpLeft = new List<Egg>();
        List<Egg> eggsDownLeft = new List<Egg>();
        List<Egg> eggsUpRight = new List<Egg>();
        List<Egg> eggsDownRight = new List<Egg>();


        while (true)
        {
            // GAME START SCREEN
            //Draw the field - from txt file


            //Draw the eggs
            for (int i = 0; i <2 ; i++)
            {
                Egg newEgg = new Egg();
                int chance = randomGenerator.Next(0,100);
                if (chance<60)
                {
                    
                }
                else
                {
                    int eggLine = randomGenerator.Next(1, 5);
                    switch (eggLine)                            // slojil sum 4 case-a za vsqka liniq po edin
                    {
                        case 1:
                            newEgg.x = 20;
                            newEgg.y = 5;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsUpLeft.Add(newEgg);
                            break;
                        case 2:
                            newEgg.x = 20;
                            newEgg.y = 10;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsDownLeft.Add(newEgg);
                            break;
                        case 3:
                            newEgg.x = 60;
                            newEgg.y = 5;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsUpRight.Add(newEgg);
                            break;
                        case 4:
                            newEgg.x = 60;
                            newEgg.y = 10;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsDownRight.Add(newEgg);
                            break;
                    }
                }
               
            }

            //Move the eggs
            for (int i = 0; i < eggsUpLeft.Count; i++)
            {
                eggsUpLeft[i].x++;
                eggsUpLeft[i].y++;
                // Check for impact
                if (eggsUpLeft[i].y > basketUpLevel)
                {
                    PrintStringOnPosition(8, 5, "GAME OVER!", ConsoleColor.DarkRed);
                    Console.WriteLine();
                    Environment.Exit(0);
                    //lives--;
                    ////eggSmash = true;
                    //if (lives <= 0)
                    //{
                    //    PrintStringOnPosition(8, 5, "GAME OVER!", ConsoleColor.DarkRed);
                    //    //PrintStringOnPosition(8, 10, "Pres any key!", ConsoleColor.DarkRed);
                    //    //Console.ReadLine();
                    //    Console.WriteLine();
                    //    Environment.Exit(0);
                    //}
                }
            }
            for (int i = 0; i < eggsDownLeft.Count; i++)
            {
                eggsDownLeft[i].x++;
                eggsDownLeft[i].y++;
                if ( eggsDownLeft[i].y>basketDownLevel)
                {
                    PrintStringOnPosition(8, 5, "GAME OVER!", ConsoleColor.DarkRed);
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < eggsUpRight.Count; i++)
            {
                eggsUpRight[i].x--;
                eggsUpRight[i].y++;
                if (eggsUpRight[i].y > basketUpLevel)
                {
                    PrintStringOnPosition(8, 5, "GAME OVER!", ConsoleColor.DarkRed);
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < eggsDownRight.Count; i++)
            {
                eggsDownRight[i].x--;
                eggsDownRight[i].y++;
                if (eggsDownRight[i].y > basketDownLevel)
                {
                    PrintStringOnPosition(8, 5, "GAME OVER!", ConsoleColor.DarkRed);
                    Console.WriteLine();
                    Environment.Exit(0);
                }
            }
            //Clear the console
            Console.Clear();
            //Redraw playfield
            foreach (var egg in eggsUpLeft)
            {
                PrintOnPosition(egg.x,egg.y,egg.z,egg.color);
            }
            foreach (var egg in eggsDownLeft)
            {
                PrintOnPosition(egg.x, egg.y, egg.z, egg.color);
            }
            foreach (var egg in eggsUpRight)
            {
                PrintOnPosition(egg.x, egg.y, egg.z, egg.color);
            }
            foreach (var egg in eggsDownRight)
            {
                PrintOnPosition(egg.x, egg.y, egg.z, egg.color);
            }
            //Move the wolf
            //Scoring system
            //Slow down program
            Thread.Sleep((int)(400 - speed));
            if (score % 20 == 0 && score != 0)
            {
                speed += 10;
                if (speed > maxSpeed)
                {
                    speed = maxSpeed;
                }
            }
        }


        //proba stella

        //test Orlin
    }
}