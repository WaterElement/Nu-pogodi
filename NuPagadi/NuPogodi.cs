using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
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
    private static void DrawField(char[,] gameField)
    {

        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            StringBuilder field = new StringBuilder();

            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                //Console.Write(gameField[i, j]);
                field.Append(gameField[i, j]);
            }
            Console.Write(field);
            Console.WriteLine();
        }
    }

    private static void ResetEnvironment(char[,] gameField)
    {
        StreamReader reader = new StreamReader("environment.txt");

        char[,] environment = new char[31, 76];
        //string[] env = new string[31];

        using (reader)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                string line = reader.ReadLine();
                //char[] charArr = line.ToCharArray();
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = line[j];
                }
            }

            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = reader.ReadLine();
            //}
        }
    }

    static void AddWolfRight(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 36;

        PlaceWolf(env, positionX, positionY, "right");
    }

    static void AddWolfLeft(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 13;

        PlaceWolf(env, positionX, positionY, "left");
    }

    static void AddWolfLeftUp(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 13;

        PlaceWolf(env, positionX, positionY, "leftup");
    }

    static void AddWolfRightUp(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 36;

        PlaceWolf(env, positionX, positionY, "rightup");
    }

    private static void PlaceWolf(char[,] env, int positionX, int positionY, string wolfPosition)
    {
        string fileName = String.Empty;

        switch (wolfPosition)
        {
            case "left":
                fileName = "wolfleft.txt";
                break;
            case "right":
                fileName = "wolfright.txt";
                break;
            case "leftup":
                fileName = "wolfleftup.txt";
                break;
            case "rightup":
                fileName = "wolfrightup.txt";
                break;
        }

        StreamReader reader = new StreamReader(fileName);
        int verticalLinesCounter = 0;

        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                for (int i = 0; i < line.Length; i++)
                {
                    env[positionY + verticalLinesCounter, positionX + i] = line[i];
                }

                verticalLinesCounter++;
            }
        }
    }

    private static void PlaceRabbit(char[,] env, int positionX, int positionY)
    {
        string fileName = "Rabbit.txt";

        StreamReader reader = new StreamReader(fileName);
        int verticalLinesCounter = 0;
        using (reader)
        {
            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                for (int i = 0; i < line.Length; i++)
                {
                    env[positionY + verticalLinesCounter, positionX + i] = line[i];
                }

                verticalLinesCounter++;
            }
        }
    }

    static void AddRabbit(char[,] env)
    {
        const int positionX = 16;
        const int positionY = 4;
        PlaceRabbit(env, positionX, positionY);
    }
    
    static void GameSpeed(int score, double sleepTime, double speed, double maxSpeed)
    {
        if (score % 20 == 0 && score != 0)
        {
            speed += 10;
            if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
        }

        Thread.Sleep((int)(sleepTime - speed));
    }

    private static void LivesCheck(int livesCount)
    {
        if (livesCount <= 0)
        {
            //Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            //Console.WriteLine("GAME OVER");

            PrintOnPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2, "GAME OVER", ConsoleColor.DarkRed);

            Console.ReadKey();

            Environment.Exit(0);
        }

    }

    private static void PrintEggs(List<Egg> eggsList)
    {
        foreach (var egg in eggsList)
        {
            PrintOnPosition(egg.x, egg.y, egg.z, egg.color);
        }
    }

    static void PrintScore(int score) // insteed of this we can use PrintOnPosition
    {
        Console.SetCursorPosition(Console.WindowWidth / 2 + 20, 0);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("score: " + score);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static void PrintLives(List<char> lives) // insteed of this we can use PrintOnPosition
    {
        Console.SetCursorPosition(Console.WindowWidth / 2, 0);
        Console.ForegroundColor = ConsoleColor.Magenta;

        //PrintOnPosition(Console.WindowWidth / 2, 0, string.Join("", lives), ConsoleColor.Magenta);
        //Console.WriteLine(string.Join("", lives));

        for (int i = 0; i < lives.Count; i++)
        {
            Console.Write(lives[i]);
        }
    }

    static void PrintOnPosition(int x, int y, string c, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void ClearEggs()
    {
        eggsDownLeft.Clear();
        eggsDownRight.Clear();
        eggsUpLeft.Clear();
        eggsUpRight.Clear();
    }

    static void UpdateSpeed()
    {
        if (score < 15)
        {
            maxTicks = 3;
        }
        else if (score >= 15 && score < 30)
        {
            maxTicks = 2;
        }
        else if (score >= 30 && score < 45)
        {
            maxTicks = 1;
        }
        else //(score >= 45)
        {
            maxTicks = 0;
        }
    }

    static int score = 0;
    static Random randomGenerator = new Random();
    static List<Egg> eggsUpLeft = new List<Egg>();
    static List<Egg> eggsDownLeft = new List<Egg>();
    static List<Egg> eggsUpRight = new List<Egg>();
    static List<Egg> eggsDownRight = new List<Egg>();

    static int ticks = 0;
    static int maxTicks = 3;




    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        //Orlin Sunday morning edits

        Console.Title = "Nu Pogodi";//Teodora

        int gameFildWidth = 76;
        int gameFieldHeight = 31;
        char[,] gameField = new char[gameFieldHeight, gameFildWidth];

        Console.SetWindowSize(gameFildWidth + 1, gameFieldHeight + 1); //set console window size
        Console.SetBufferSize(gameFildWidth + 1, gameFieldHeight + 1); //removes the scroll bars if equal to window size
        Console.CursorVisible = false;
        ResetEnvironment(gameField);
        AddWolfRight(gameField);

        int basketUpLevel = 19;         // this far the egg can roll before crashing for upper lines
        int basketDownLevel = 24;         // this far the egg can roll before crashing for lower lines    
        string basketPosition = "down right"; // this depends on pressed key for basket position
        List<char> lives = new List<char> { '\u2665', '\u2665', '\u2665', '\u2665', '\u2665' };
        int livesCount = lives.Count;
        double speed = 0;
        double maxSpeed = 400;


        Console.BackgroundColor = ConsoleColor.White;

        PrintOnPosition(Console.WindowWidth / 2 - 10,
               Console.WindowHeight / 2 - 5, "Press enter to start!", ConsoleColor.DarkBlue);
        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        UpdateSpeed();

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            while (true)
            {
                UpdateSpeed();

                if (ticks < maxTicks)
                {
                    ticks++;
                }
                else
                {
                    ticks = 0;
                }

                PrintScore(score);
                PrintLives(lives);
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                //Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.ForegroundColor = ConsoleColor.Black;


                //Orlin
                //Orlin
                double sleepTime = 1000; // eggs moving slower then faster --> stella
                //sleepTime -= 0.05;
                //Thread.Sleep((int)sleepTime);
                Thread.Sleep(200);

                //GameSpeed(score, sleepTime, speed, maxSpeed);  // Plamen


                Console.Clear();

                bool eggSmashLeft = false;
                bool eggSmashRight = false;
                bool goldEgg = false;
                //End Orlin

                //Milko
                //Draw the eggs

                if (ticks == maxTicks)
                {

                    Egg newEgg = new Egg();
                    int chance = randomGenerator.Next(0, 100);
                    if (chance < 5)                                 //Golden Eggs - life++ ; score +9;
                    {
                        int eggLine = randomGenerator.Next(1, 5);
                        switch (eggLine)                            // slojil sum 4 case-a za vsqka liniq po edin
                        {
                            case 1:
                                newEgg.x = 6;
                                newEgg.y = 10;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsUpLeft.Add(newEgg);
                                break;
                            case 2:
                                newEgg.x = 6;
                                newEgg.y = 15;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsDownLeft.Add(newEgg);
                                break;
                            case 3:
                                newEgg.x = 69;
                                newEgg.y = 10;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsUpRight.Add(newEgg);
                                break;
                            case 4:
                                newEgg.x = 69;
                                newEgg.y = 15;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsDownRight.Add(newEgg);
                                break;
                        }
                    }
                    else if (chance < 20)
                    {
                        int eggLine = randomGenerator.Next(1, 5);
                        switch (eggLine)                            // slojil sum 4 case-a za vsqka liniq po edin
                        {
                            case 1:
                                newEgg.x = 6;
                                newEgg.y = 10;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsUpLeft.Add(newEgg);
                                break;
                            case 2:
                                newEgg.x = 6;
                                newEgg.y = 15;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsDownLeft.Add(newEgg);
                                break;
                            case 3:
                                newEgg.x = 69;
                                newEgg.y = 10;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsUpRight.Add(newEgg);
                                break;
                            case 4:
                                newEgg.x = 69;
                                newEgg.y = 15;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsDownRight.Add(newEgg);
                                break;
                        }
                    }
                }

                //Move the eggs
                if (ticks == maxTicks)
                {
                    for (int j = 0; j < eggsUpLeft.Count; j++)
                    {
                        if (eggsUpLeft[j].y < basketUpLevel - 1)
                        {
                            eggsUpLeft[j].x++;
                            eggsUpLeft[j].y++;
                        }
                        // Check for impact
                        else if (eggsUpLeft[j].y <= basketUpLevel)
                        {
                            if (basketPosition == "up left")
                            {
                                if (eggsUpLeft[j].color == ConsoleColor.DarkYellow && livesCount < 5)
                                {
                                    goldEgg = true;
                                    //livesCount++;
                                    //lives.Add('\u2665');
                                    //score += 9;
                                }
                                score++;
                                eggsUpLeft.Remove(eggsUpLeft[j]);
                            }
                            else
                            {
                                eggSmashLeft = true;
                                //livesCount--;
                                //LivesCheck(livesCount); //aded metod for lives check if Stella is OK :)
                                ////Console.Beep();
                                //lives.RemoveAt(livesCount - 1);
                                //eggsUpLeft.Clear();
                                ClearEggs();
                            }

                        }
                    }
                    for (int k = 0; k < eggsDownLeft.Count; k++)
                    {
                        if (eggsDownLeft[k].y < basketDownLevel - 1)
                        {
                            eggsDownLeft[k].x++;
                            eggsDownLeft[k].y++;
                        }
                        else if (eggsDownLeft[k].y <= basketDownLevel)
                        {
                            if (basketPosition == "down left")
                            {
                                if (eggsDownLeft[k].color == ConsoleColor.DarkYellow && livesCount < 5)
                                {
                                    goldEgg = true;
                                    //livesCount++;
                                    //lives.Add('\u2665');
                                    //score += 9;
                                }
                                score++;
                                eggsDownLeft.Remove(eggsDownLeft[k]);
                            }
                            else
                            {
                                eggSmashLeft = true;
                                // livesCount--;
                                // LivesCheck(livesCount); //aded metod for lives check if Stella is OK :)
                                //// Console.Beep();
                                // lives.RemoveAt(livesCount - 1);
                                //eggsDownLeft.Clear();
                                ClearEggs();
                            }
                        }
                    }
                    for (int l = 0; l < eggsUpRight.Count; l++)
                    {
                        if (eggsUpRight[l].y < basketUpLevel - 1)
                        {
                            eggsUpRight[l].x--;
                            eggsUpRight[l].y++;
                        }
                        else if (eggsUpRight[l].y <= basketUpLevel)
                        {
                            if (basketPosition == "up right")
                            {
                                if (eggsUpRight[l].color == ConsoleColor.DarkYellow && livesCount < 5)
                                {
                                    goldEgg = true;
                                    //livesCount++;
                                    //lives.Add('\u2665');
                                    //score += 9;
                                }
                                score++;
                                eggsUpRight.Remove(eggsUpRight[l]);
                            }
                            else
                            {
                                eggSmashRight = true;
                                // livesCount--;
                                // LivesCheck(livesCount); //aded metod for lives check if Stella is OK :)
                                //// Console.Beep();
                                // lives.RemoveAt(livesCount - 1);
                                //eggsUpRight.Clear();
                                ClearEggs();
                            }
                        }
                    }
                    for (int m = 0; m < eggsDownRight.Count; m++)
                    {
                        if (eggsDownRight[m].y < basketDownLevel - 1)
                        {
                            eggsDownRight[m].x--;
                            eggsDownRight[m].y++;
                        }
                        else if (eggsDownRight[m].y <= basketDownLevel)
                        {
                            if (basketPosition == "down right")
                            {
                                if (eggsDownRight[m].color == ConsoleColor.DarkYellow && livesCount < 5)
                                {
                                    goldEgg = true;
                                    //livesCount++;
                                    //lives.Add('\u2665');
                                    //score += 9;
                                }
                                score++;
                                eggsDownRight.Remove(eggsDownRight[m]);
                            }
                            else
                            {
                                eggSmashRight = true;
                                //livesCount--;
                                //LivesCheck(livesCount); //aded metod for lives check if Stella is OK :)
                                ////Console.Beep();
                                //lives.RemoveAt(livesCount - 1);
                                //eggsDownRight.Clear();
                                ClearEggs();
                            }
                        }
                    }
                }

                //End Milko

                //Orlin Sunday Morning

                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.Spacebar)
                    {
                        DrawField(gameField);
                        PrintEggs(eggsUpLeft);
                        PrintEggs(eggsDownLeft);
                        PrintEggs(eggsUpRight);
                        PrintEggs(eggsDownRight);
                        PrintLives(lives);
                        PrintScore(score);
                        pressedKey = Console.ReadKey(true);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad4)
                    {
                        basketPosition = "down left";
                        ResetEnvironment(gameField);
                        AddWolfLeft(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad7)
                    {
                        basketPosition = "up left";
                        ResetEnvironment(gameField);
                        AddWolfLeftUp(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad6)
                    {
                        basketPosition = "down right";
                        ResetEnvironment(gameField);
                        AddWolfRight(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad9)
                    {
                        basketPosition = "up right";
                        ResetEnvironment(gameField);
                        AddWolfRightUp(gameField);
                    }
                }
                //End Orlin Sunday Morning

                DrawField(gameField);

                //Milko
                if (eggSmashLeft || eggSmashRight)
                {
                    if (eggSmashLeft)
                    {
                        PrintOnPosition(13, gameFieldHeight - 2, "(O)", ConsoleColor.DarkRed);
                    }
                    if (eggSmashRight)
                    {
                        PrintOnPosition(60, gameFieldHeight - 2, "(O)", ConsoleColor.DarkRed);
                    }

                    livesCount--;
                    LivesCheck(livesCount); //aded metod for lives check if Stella is OK :)
                    Console.Beep();
                    lives.RemoveAt(livesCount - 1);
                    AddRabbit(gameField);
                }

                if (goldEgg)
                {
                    livesCount++;
                    lives.Add('\u2665');
                    score += 9;
                }
                PrintEggs(eggsUpLeft);
                PrintEggs(eggsDownLeft);
                PrintEggs(eggsUpRight);
                PrintEggs(eggsDownRight);
                //End Milko


            }
        }
    }
}