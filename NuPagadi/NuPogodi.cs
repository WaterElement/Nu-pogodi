using System;
using System.Collections.Generic;
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
    //
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
    //
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
        //Orlin Sunday morning edits

        int gameFildWidth = 76;
        int gameFieldHeight = 31;
        char[,] gameField = new char[gameFieldHeight, gameFildWidth];

        Console.SetWindowSize(gameFildWidth+1, gameFieldHeight+1); //set console window size
        Console.SetBufferSize(gameFildWidth+1, gameFieldHeight+1); //removes the scroll bars if equal to window size
        Console.CursorVisible = false;
        ResetEnvironment(gameField);
        AddWolfRight(gameField);



        //End Orlin Sunday morning edits


        


        //Console.BufferHeight = 100;
        //Console.BufferWidth = 200;

        //Console.WindowHeight = Console.BufferHeight;      // tuk mi dava greshka ne iska da gi priravni, moje i v moq komp da e!!
        //Console.WindowWidth = Console.BufferWidth;

        int basketUpLevel = 19;         // this depends on pressed key up ot down
        int basketDownLevel = 24;         // this depends on pressed key up ot down       
        string basketPosition = "down right"; // this depends on pressed key left ot rignht
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
            int scoreCatchedEgg = 0;
            PrintScore(scoreCatchedEgg);

            //Orlin
            //Orlin
            double sleepTime = 500; // eggs moving slower then faster --> stella
            sleepTime -= 0.05;
            Thread.Sleep((int)sleepTime);
            Console.Clear();

            bool eggSmashLeft = false;
            bool eggSmashRight = false;
            //End Orlin

           

            // GAME START SCREEN
            //Draw the field - from txt file

            


          



            //Draw the eggs
            for (int i = 0; i < 2; i++)
            {
                Egg newEgg = new Egg();
                int chance = randomGenerator.Next(0, 100);
                if (chance < 80)
                {
                //if (chance < 80)
                //{

                //}
                if (chance < 20)
                {
                    int eggLine = randomGenerator.Next(1, 5);
                    switch (eggLine)                            // slojil sum 4 case-a za vsqka liniq po edin
                    {
                        case 1:
                            newEgg.x = 6;
                            newEgg.y = 10;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsUpLeft.Add(newEgg);
                            break;
                        case 2:
                            newEgg.x = 6;
                            newEgg.y = 15;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsDownLeft.Add(newEgg);
                            break;
                        case 3:
                            newEgg.x = 69;
                            newEgg.y = 10;
                            newEgg.z = "0";
                            newEgg.color = ConsoleColor.Gray;
                            eggsUpRight.Add(newEgg);
                            break;
                        case 4:
                            newEgg.x = 69;
                            newEgg.y = 15;
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
                if (eggsUpLeft[i].y < basketUpLevel - 1)
                {
                    eggsUpLeft[i].x++;
                    eggsUpLeft[i].y++;
                }
                // Check for impact
                else if (eggsUpLeft[i].y <= basketUpLevel)
                {
                    if (basketPosition == "up left")
                    {
                        score++;
                        eggsUpLeft.Remove(eggsUpLeft[i]);
                    }
                    else
                    {
                        eggSmashLeft = true;
                        lives--;
                        eggsUpLeft.Remove(eggsUpLeft[i]);
                    }

                }
            }
            for (int i = 0; i < eggsDownLeft.Count; i++)
            {
                if (eggsDownLeft[i].y < basketDownLevel - 1)
                {
                    eggsDownLeft[i].x++;
                    eggsDownLeft[i].y++;
                }
                else if (eggsDownLeft[i].y <= basketDownLevel)
                {
                    if (basketPosition == "down left")
                    {
                        score++;
                        eggsDownLeft.Remove(eggsDownLeft[i]);
                    }
                    else
                    {
                        eggSmashLeft = true;
                        lives--;
                        eggsDownLeft.Remove(eggsDownLeft[i]);
                    }
                }
            }
            for (int i = 0; i < eggsUpRight.Count; i++)
            {
                if (eggsUpRight[i].y < basketUpLevel - 1)
                {
                    eggsUpRight[i].x--;
                    eggsUpRight[i].y++;
                }
                else if (eggsUpRight[i].y <= basketUpLevel)
                {
                    if (basketPosition == "up right")
                    {
                        score++;
                        eggsUpRight.Remove(eggsUpRight[i]);
                    }
                    else
                    {
                        eggSmashRight = true;
                        lives--;
                        eggsUpRight.Remove(eggsUpRight[i]);
                    }
                }
            }
            for (int i = 0; i < eggsDownRight.Count; i++)
            {
                if (eggsDownRight[i].y < basketDownLevel - 1)
                {
                    eggsDownRight[i].x--;
                    eggsDownRight[i].y++;
                }
                else if (eggsDownRight[i].y <= basketDownLevel)
                {
                    if (basketPosition == "down right")
                    {
                        score++;
                        eggsDownRight.Remove(eggsDownRight[i]);
                    }
                    else
                    {
                        eggSmashRight = true;
                        lives--;
                        eggsDownRight.Remove(eggsDownRight[i]);
                    }
                }
            }



            


            //Clear the console
            //Console.Clear();
            //Redraw playfield

            //Move the wolf
            //Scoring system
            //Slow down program

            //Thread.Sleep((int)(400 - speed));
            //if (score % 20 == 0 && score != 0)
            //{
            //    speed += 10;
            //    if (speed > maxSpeed)
            //    {
            //        speed = maxSpeed;
            //    }
            //}

            //Orlin Sunday Morning


            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
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

            if (eggSmashLeft || eggSmashRight)
            {
                if (eggSmashLeft)
                {
                    PrintOnPosition(13, gameFieldHeight - 2, "(0)", ConsoleColor.DarkRed);
                }
                if (eggSmashRight)
                {
                    PrintOnPosition(60, gameFieldHeight - 2, "(0)", ConsoleColor.DarkRed);
                }

                eggsUpLeft.Clear();
                eggsDownLeft.Clear();
                eggsUpRight.Clear();
                eggsDownRight.Clear();
            }
            else
            {
                PrintEggs(eggsUpLeft);
                PrintEggs(eggsDownLeft);
                PrintEggs(eggsUpRight);
                PrintEggs(eggsDownRight);
            }


            Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Gray;

           
        }


        


        //proba stella

        //test Orlin
    }

    private static void PrintEggs(List<Egg> eggsList)
    {
        foreach (var egg in eggsList)
        {
            PrintOnPosition(egg.x, egg.y, egg.z, egg.color);
        }
    }

    static void PrintScore(int score)
    {
        Console.SetCursorPosition(Console.WindowWidth / 2+20, 0);
        Console.WriteLine("score: "+score);

    }

    
}