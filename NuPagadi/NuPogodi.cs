using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

public class Autoplay
{
    static void drawClockSimbols(int rows, int x)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        var numbers = new StreamReader("numbers.txt");

        int y = 0;
        using (numbers)
        {
            string number = numbers.ReadLine();

            for (int row = 0; row <= 49; row++)
            {

                if (row >= rows && row <= rows + 4)
                {
                    Console.SetCursorPosition(x, (y + 3));
                    Console.WriteLine(number);
                    y++;
                }
                number = numbers.ReadLine();
            }
        }
    }
    static void drawBasket(int rows, int x, int y)
    {
        Console.ForegroundColor = ConsoleColor.Black;

        var baskets = new StreamReader("numbers.txt");
        using (baskets)
        {
            string number = baskets.ReadLine();

            for (int row = 0; row <= 118; row++)
            {

                if (row >= rows && row <= rows + 16)
                {
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine(number);
                    y++;
                }
                number = baskets.ReadLine();
            }
        }
    }
    protected static void WriteAt(char s, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(s);

    }
    public static void Autoplaya()
    {
        char charEgg00 = ' ';
        char charEgg01 = ' ';
        char charEgg02 = ' ';
        char charEgg03 = ' ';
        char charEgg04 = ' ';
        char charEgg10 = ' ';
        char charEgg11 = ' ';
        char charEgg12 = ' ';
        char charEgg13 = ' ';
        char charEgg14 = ' ';
        char charEgg20 = ' ';
        char charEgg21 = ' ';
        char charEgg22 = ' ';
        char charEgg23 = ' ';
        char charEgg24 = ' ';
        char charEgg30 = ' ';
        char charEgg31 = ' ';
        char charEgg32 = ' ';
        char charEgg33 = ' ';
        char charEgg34 = ' ';
        int tempTime = 800;
        int tempState = 10;
        bool autoplay = true;

        Console.CursorVisible = false;

        Console.BackgroundColor = ConsoleColor.White;


        var environment = new StreamReader("environmentauto.txt");
        string text = environment.ReadToEnd();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(text);
        Console.BackgroundColor = ConsoleColor.White;

        environment.Close();

        while (autoplay)
        {
            if (tempTime == 800)
            {
                //get sistem time
                string time = DateTime.Now.ToString("HH:mm");
                char[] timeArray = time.ToCharArray();

                for (int i = 0; i <= 6; i++)
                {
                    if (i == 0)
                    {
                        if (timeArray[i] == '1')
                        {
                            drawClockSimbols(0, 45);
                        }
                        if (timeArray[i] == '2')
                        {
                            drawClockSimbols(5, 45);
                        }
                        if (timeArray[i] == '0')
                        {
                            drawClockSimbols(10, 45);
                        }
                    }
                    if (i == 1)
                    {
                        if (timeArray[i] == '1')
                        {
                            drawClockSimbols(0, 51);
                        }
                        if (timeArray[i] == '2')
                        {
                            drawClockSimbols(5, 51);
                        }
                        if (timeArray[i] == '3')
                        {
                            drawClockSimbols(10, 51);
                        }
                        if (timeArray[i] == '4')
                        {
                            drawClockSimbols(15, 51);
                        }
                        if (timeArray[i] == '5')
                        {
                            drawClockSimbols(20, 51);
                        }
                        if (timeArray[i] == '6')
                        {
                            drawClockSimbols(25, 51);
                        }
                        if (timeArray[i] == '7')
                        {
                            drawClockSimbols(30, 51);
                        }
                        if (timeArray[i] == '8')
                        {
                            drawClockSimbols(35, 51);
                        }
                        if (timeArray[i] == '9')
                        {
                            drawClockSimbols(40, 51);
                        }
                        if (timeArray[i] == '0')
                        {
                            drawClockSimbols(45, 51);
                        }
                    }

                    WriteAt('#', 57, 4);
                    WriteAt('#', 57, 6);

                    //set minutes
                    if (i == 3)
                    {
                        if (timeArray[i] == '1')
                        {
                            drawClockSimbols(0, 60);
                        }
                        if (timeArray[i] == '2')
                        {
                            drawClockSimbols(5, 60);
                        }
                        if (timeArray[i] == '3')
                        {
                            drawClockSimbols(10, 60);
                        }
                        if (timeArray[i] == '4')
                        {
                            drawClockSimbols(15, 60);
                        }
                        if (timeArray[i] == '5')
                        {
                            drawClockSimbols(20, 60);
                        }
                        if (timeArray[i] == '6')
                        {
                            drawClockSimbols(24, 60);
                        }
                        if (timeArray[i] == '7')
                        {
                            drawClockSimbols(30, 60);
                        }
                        if (timeArray[i] == '8')
                        {
                            drawClockSimbols(35, 60);
                        }
                        if (timeArray[i] == '9')
                        {
                            drawClockSimbols(40, 60);
                        }
                        if (timeArray[i] == '0')
                        {
                            drawClockSimbols(45, 60);
                        }
                    }
                    if (i == 4)
                    {
                        if (timeArray[i] == '1')
                        {
                            drawClockSimbols(0, 66);
                        }
                        if (timeArray[i] == '2')
                        {
                            drawClockSimbols(5, 66);
                        }
                        if (timeArray[i] == '3')
                        {
                            drawClockSimbols(10, 66);
                        }
                        if (timeArray[i] == '4')
                        {
                            drawClockSimbols(15, 66);
                        }
                        if (timeArray[i] == '5')
                        {
                            drawClockSimbols(20, 66);
                        }
                        if (timeArray[i] == '6')
                        {
                            drawClockSimbols(25, 66);
                        }
                        if (timeArray[i] == '7')
                        {
                            drawClockSimbols(30, 66);
                        }
                        if (timeArray[i] == '8')
                        {
                            drawClockSimbols(35, 66);
                        }
                        if (timeArray[i] == '9')
                        {
                            drawClockSimbols(40, 66);
                        }
                        if (timeArray[i] == '0')
                        {
                            drawClockSimbols(45, 66);
                        }
                    }
                }

                Random random = new Random();
                int randomNumber = random.Next(0, 6);
                Random wolfRandom = new Random();
                int wolfRandomNumber = wolfRandom.Next(0, 4);

                charEgg04 = charEgg03; //5
                charEgg03 = charEgg02; //4
                charEgg02 = charEgg01; //3
                charEgg01 = charEgg00; //2
                charEgg00 = ' ';
                charEgg14 = charEgg13; //5
                charEgg13 = charEgg12; //4
                charEgg12 = charEgg11; //3
                charEgg11 = charEgg10; //2
                charEgg10 = ' ';
                charEgg24 = charEgg23; //5
                charEgg23 = charEgg22; //4
                charEgg22 = charEgg21; //3
                charEgg21 = charEgg20; //2
                charEgg20 = ' ';
                charEgg34 = charEgg33; //5
                charEgg33 = charEgg32; //4
                charEgg32 = charEgg31; //3
                charEgg31 = charEgg30; //2
                charEgg00 = ' ';
                char upLeft = (randomNumber == 0) ? charEgg00 = 'O' : charEgg00 = ' ';
                char upRigth = (randomNumber == 1) ? charEgg10 = 'O' : charEgg10 = ' ';
                char downLeft = (randomNumber == 2) ? charEgg20 = 'O' : charEgg20 = ' ';
                char downRigth = (randomNumber == 3) ? charEgg30 = 'O' : charEgg30 = ' ';

                WriteAt(charEgg00, 8, 13);
                WriteAt(charEgg01, 9, 14);
                WriteAt(charEgg02, 10, 15);
                WriteAt(charEgg03, 11, 16);
                WriteAt(charEgg04, 12, 17);

                WriteAt(charEgg10, 66, 14);
                WriteAt(charEgg11, 65, 15);
                WriteAt(charEgg12, 64, 16);
                WriteAt(charEgg13, 63, 17);
                WriteAt(charEgg14, 62, 18);

                WriteAt(charEgg20, 8, 19);
                WriteAt(charEgg21, 9, 20);
                WriteAt(charEgg22, 10, 21);
                WriteAt(charEgg23, 11, 22);
                WriteAt(charEgg24, 12, 23);

                WriteAt(charEgg30, 66, 20);
                WriteAt(charEgg31, 65, 21);
                WriteAt(charEgg32, 64, 22);
                WriteAt(charEgg33, 63, 23);
                WriteAt(charEgg34, 62, 24);

                Console.ForegroundColor = ConsoleColor.Black;

                //bsket up left
                if (wolfRandomNumber == 0)
                {
                    if (tempState != 0)
                    {
                        drawBasket(50, 12, 13);
                        tempState = 0;
                    }
                }

                //basket down left
                if (wolfRandomNumber == 1)
                {
                    if (tempState != 1)
                    {
                        drawBasket(67, 12, 13);
                        tempState = 1;
                    }
                }
                if (wolfRandomNumber > 1)
                {
                    for (int i = 13; i < 30; i++)
                    {
                        for (int j = 12; j < 36; j++)
                        {
                            WriteAt(' ', j, i);
                        }
                    }
                }

                //basket up right
                if (wolfRandomNumber == 2)
                {
                    if (tempState != 2)
                    {
                        drawBasket(84, 36, 13);
                        tempState = 2;
                    }
                }

                //basket down right
                if (wolfRandomNumber == 3)
                {
                    if (tempState != 3)
                    {
                        drawBasket(101, 36, 13);
                        tempState = 3;
                    }
                }
                if (wolfRandomNumber < 2)
                {
                    for (int i = 13; i < 30; i++)
                    {
                        for (int j = 38; j < 64; j++)
                        {
                            WriteAt(' ', j, i);
                        }
                    }
                }
                tempTime = 0;
            }
            Thread.Sleep(10);
            tempTime += 10;
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.Enter)
                {
                    autoplay = false;
                }
            }
        }
    }

}
class Egg
{
    public int x;
    public int y;
    public string z;
    public ConsoleColor color;
}
class NuPagadi
{
    static void drawClockSimbols(int rows, int x)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        var numbers = new StreamReader("numbers.txt");

        int y = 0;
        using (numbers)
        {
            string number = numbers.ReadLine();

            for (int row = 0; row <= 49; row++)
            {

                if (row >= rows && row <= rows + 4)
                {
                    Console.SetCursorPosition(x, (y + 3));
                    Console.WriteLine(number);
                    y++;
                }
                number = numbers.ReadLine();
            }
        }
    }

    private static void DrawField(char[,] gameField)
    {

        for (int i = 0; i < gameField.GetLength(0); i++)
        {
            StringBuilder field = new StringBuilder();

            for (int j = 0; j < gameField.GetLength(1); j++)
            {
                field.Append(gameField[i, j]);
            }

            Console.Write(field);
            Console.WriteLine();
        }
    }

    private static void ResetEnvironment(char[,] gameField)
    {
        if (!File.Exists("environment.txt"))
        {
            throw new FileNotFoundException("Environment file not found!");
        }

        StreamReader reader = new StreamReader("environment.txt");

        using (reader)
        {
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                string line = reader.ReadLine();
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = line[j];
                }
            }
        }
    }

    static void AddWolfRight(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 36;

        try
        {
            PlaceWolf(env, positionX, positionY, "right");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void AddWolfLeft(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 13;

        try
        {
            PlaceWolf(env, positionX, positionY, "left");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void AddWolfLeftUp(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 13;

        try
        {
            PlaceWolf(env, positionX, positionY, "leftup");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void AddWolfRightUp(char[,] env)
    {
        const int positionY = 13;
        const int positionX = 36;

        try
        {
            PlaceWolf(env, positionX, positionY, "rightup");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
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

        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException("Wolf position file not found");
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

    private static void LivesCheck(int livesCount)
    {
        if (livesCount <= 0)
        {
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
        if (score < 10)
        {
            if (score == 1)
            {
                drawClockSimbols(0, 61);
            }
            if (score == 2)
            {
                drawClockSimbols(5, 61);
            }
            if (score == 3)
            {
                drawClockSimbols(10, 61);
            }
            if (score == 4)
            {
                drawClockSimbols(15, 61);
            }
            if (score == 5)
            {
                drawClockSimbols(20, 61);
            }
            if (score == 6)
            {
                drawClockSimbols(25, 61);
            }
            if (score == 7)
            {
                drawClockSimbols(30, 61);
            }
            if (score == 8)
            {
                drawClockSimbols(35, 61);
            }
            if (score == 9)
            {
                drawClockSimbols(40, 61);
            }
            if (score == 0)
            {
                drawClockSimbols(45, 61);
            }
        }
        else
        {
            int tempOne = score / 10;
            int tempDecimal = score % 10;

            if (tempOne == 1)
            {
                drawClockSimbols(0, 55);
            }
            if (tempOne == 2)
            {
                drawClockSimbols(5, 55);
            }
            if (tempOne == 3)
            {
                drawClockSimbols(10, 55);
            }
            if (tempOne == 4)
            {
                drawClockSimbols(15, 55);
            }
            if (tempOne == 5)
            {
                drawClockSimbols(20, 55);
            }
            if (tempOne == 6)
            {
                drawClockSimbols(25, 55);
            }
            if (tempOne == 7)
            {
                drawClockSimbols(30, 55);
            }
            if (tempOne == 8)
            {
                drawClockSimbols(35, 55);
            }
            if (tempOne == 9)
            {
                drawClockSimbols(40, 55);
            }
            if (tempOne == 0)
            {
                drawClockSimbols(45, 55);
            }
            if (tempDecimal == 1)
            {
                drawClockSimbols(0, 61);
            }
            if (tempDecimal == 2)
            {
                drawClockSimbols(5, 61);
            }
            if (tempDecimal == 3)
            {
                drawClockSimbols(10, 61);
            }
            if (tempDecimal == 4)
            {
                drawClockSimbols(15, 61);
            }
            if (tempDecimal == 5)
            {
                drawClockSimbols(20, 61);
            }
            if (tempDecimal == 6)
            {
                drawClockSimbols(25, 61);
            }
            if (tempDecimal == 7)
            {
                drawClockSimbols(30, 61);
            }
            if (tempDecimal == 8)
            {
                drawClockSimbols(35, 61);
            }
            if (tempDecimal == 9)
            {
                drawClockSimbols(40, 61);
            }
            if (tempDecimal == 0)
            {
                drawClockSimbols(45, 61);
            }
        }
    }

    static void PrintLives(List<char> lives) // insteed of this we can use PrintOnPosition
    {
        Console.SetCursorPosition(Console.WindowWidth / 2, 2);
        Console.ForegroundColor = ConsoleColor.Magenta;

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
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException("Score must be positive!");
        }
        if (score < 10)
        {
            maxTicks = 3;
        }
        else if (score >= 10 && score < 20)
        {
            maxTicks = 2;
        }
        else if (score >= 20 && score < 30)
        {
            maxTicks = 1;
        }
        else //(score >= 30)
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
    #region Autoplay

    #endregion



    static void Main()
    {
        Autoplay.Autoplaya();

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.Unicode;

        Console.Title = "Nu Pogodi";//Teodora

        int gameFildWidth = 76;
        int gameFieldHeight = 31;
        char[,] gameField = new char[gameFieldHeight, gameFildWidth];

        Console.SetWindowSize(gameFildWidth + 1, gameFieldHeight + 1); //set console window size
        Console.SetBufferSize(gameFildWidth + 1, gameFieldHeight + 1); //removes the scroll bars if equal to window size
        Console.CursorVisible = false;
        
        try
        {
            ResetEnvironment(gameField);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        AddWolfRight(gameField);

        int basketUpLevel = 19;         // this far the egg can roll before crashing for upper lines
        int basketDownLevel = 24;         // this far the egg can roll before crashing for lower lines    
        string basketPosition = "down right"; // this depends on pressed key for basket position
        List<char> lives = new List<char> { '\u2665', '\u2665', '\u2665', '\u2665', '\u2665' };
        int livesCount = lives.Count;

        Console.BackgroundColor = ConsoleColor.White;

        UpdateSpeed();

        if (true)
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
                Console.ForegroundColor = ConsoleColor.Black;
                double sleepTime = 1000; // eggs moving slower then faster --> stella
                Thread.Sleep(200);
                Console.Clear();
                bool eggSmashLeft = false;
                bool eggSmashRight = false;
                bool goldEgg = false;

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
                                newEgg.y = 11;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsUpLeft.Add(newEgg);
                                break;
                            case 2:
                                newEgg.x = 6;
                                newEgg.y = 17;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsDownLeft.Add(newEgg);
                                break;
                            case 3:
                                newEgg.x = 69;
                                newEgg.y = 11;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsUpRight.Add(newEgg);
                                break;
                            case 4:
                                newEgg.x = 69;
                                newEgg.y = 17;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkYellow;
                                eggsDownRight.Add(newEgg);
                                break;
                        }
                    }
                    else if (chance < 20)
                    {
                        int eggLine = randomGenerator.Next(1, 5);
                        switch (eggLine)
                        {
                            case 1:
                                newEgg.x = 6;
                                newEgg.y = 11;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsUpLeft.Add(newEgg);
                                break;
                            case 2:
                                newEgg.x = 6;
                                newEgg.y = 17;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsDownLeft.Add(newEgg);
                                break;
                            case 3:
                                newEgg.x = 69;
                                newEgg.y = 11;
                                newEgg.z = "O";
                                newEgg.color = ConsoleColor.DarkGray;
                                eggsUpRight.Add(newEgg);
                                break;
                            case 4:
                                newEgg.x = 69;
                                newEgg.y = 17;
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
                                }
                                score++;
                                eggsUpLeft.Remove(eggsUpLeft[j]);
                            }
                            else
                            {
                                eggSmashLeft = true;
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
                                }
                                score++;
                                eggsDownLeft.Remove(eggsDownLeft[k]);
                            }
                            else
                            {
                                eggSmashLeft = true;
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
                                }

                                score++;
                                eggsUpRight.Remove(eggsUpRight[l]);
                            }
                            else
                            {
                                eggSmashRight = true;
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
                                }
                                score++;
                                eggsDownRight.Remove(eggsDownRight[m]);
                            }
                            else
                            {
                                eggSmashRight = true;
                                ClearEggs();
                            }
                        }
                    }
                }

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
                        try
                        {
                            ResetEnvironment(gameField);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        AddWolfLeft(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad7)
                    {
                        basketPosition = "up left";
                        try
                        {
                            ResetEnvironment(gameField);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        AddWolfLeftUp(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad6)
                    {
                        basketPosition = "down right";
                        try
                        {
                            ResetEnvironment(gameField);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        AddWolfRight(gameField);
                    }
                    if (pressedKey.Key == ConsoleKey.NumPad9)
                    {
                        basketPosition = "up right";
                        try
                        {
                            ResetEnvironment(gameField);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        AddWolfRightUp(gameField);
                    }
                }
                
                DrawField(gameField);

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
                    LivesCheck(livesCount);
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
            }
        }
    }
}