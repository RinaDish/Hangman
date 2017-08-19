using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        #region hangmanArray
        static string[] hangmanArray = { @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
                          $$$$$$$       
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                       $$$$$$$$$$$$$      
                     $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
                          $$$$$$$      
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$      
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                       $$$$$$$$$$$$$      
                     $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
   $ZZZZZ$                $$$$$$$      
   $$$$$$$                $$$$$$$      
    $$$$$                 $$$$$$$       
    $$$$$                 $$$$$$$      
    $$$$$                 $$$$$$$       
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                       $$$$$$$$$$$$$      
                     $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
   $ZZZZZ$                $$$$$$$      
  $$$$$$$$                $$$$$$$      
  $ $$$$$                 $$$$$$$       
  $ $$$$$                 $$$$$$$      
  $ $$$$$                 $$$$$$$       
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                       $$$$$$$$$$$$$      
                     $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
   $ZZZZZ$                $$$$$$$      
  $$$$$$$$$               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
  $ $$$$$ $               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
                          $$$$$$$       
                          $$$$$$$       
                          $$$$$$$      
                       $$$$$$$$$$$$$      
                     $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"
   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
   $ZZZZZ$                $$$$$$$      
  $$$$$$$$$               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
  $ $$$$$ $               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
    $$                    $$$$$$$       
   $$                     $$$$$$$       
   $$                     $$$$$$$      
   $$                  $$$$$$$$$$$$$      
   $$                $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ ",
        @"

   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$    
      Z                   $$$$$$$       
      Z                   $$$$$$$      
      Z                   $$$$$$$       
     $$$                  $$$$$$$      
    $$$$$                 $$$$$$$       
     $$$                  $$$$$$$       
   $ZZZZZ$                $$$$$$$      
  $$$$$$$$$               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
  $ $$$$$ $               $$$$$$$      
  $ $$$$$ $               $$$$$$$       
    $$ $$                 $$$$$$$       
   $$   $$                $$$$$$$       
   $$   $$                $$$$$$$      
   $$   $$             $$$$$$$$$$$$$      
   $$   $$           $$$$$$$$$$$$$$$$$  
                    $$$$$$$$$$$$$$$$$$$  
                   $$$$$$$$$$$$$$$$$$$$$ 
                   $$$$$$$$$$$$$$$$$$$$$ "};
        #endregion
        static int gameStatus = 0;
        static string[] wordsArray = { "коллайдер",
            "программирование",
            "профессор",
            "энциклопедия",
            "габарит",
            "каллиграфия",
            "компилятор",
            "набалдашник",
            "надбавка",
            "мавзолей",
            "министерство",
            "магистратура",
            "посторонний",
            "накопитель",
            "рогалик",
            "пряник",
            "фурнитура",
            "экономика",
            "гравитация",
            "материя",
            "звездолёт",
            "кондиционер",
            "проигрыатель",
            "матрица",
            "система",
            "троллейбус",
            "парадигма"
        };
        static char[] targetWord;
        static char[] showenWord;
        static Random random = new Random();
        static int idWord;
        static char[] move;
        static bool rightMove = false;
        static int countRightMove = 0;
        static void Main(string[] args)
        {

            WordToChar();

            DrawHangman();
            ShownWordArray();
            //   Console.WriteLine(targetWord);
            MakeMove();

            Console.ReadKey();
        }

        static void DrawHangman()
        {
            Console.WriteLine(hangmanArray[gameStatus]);
            Console.WriteLine();
        }

        static void WordToChar()
        {
            idWord = random.Next(10);
            targetWord = wordsArray[idWord].ToCharArray();
        }

        static void ShownWordArray()
        {
            showenWord = new char[targetWord.Length];
            showenWord[0] = targetWord[0];
            showenWord[targetWord.Length - 1] = targetWord[targetWord.Length - 1];
            for (int i = 1; i < showenWord.Length - 1; i++)
            {
                showenWord[i] = '_';
            }
            ShowField();
        }

        static void ShowField()
        {
            Console.Write(showenWord);
            Console.WriteLine();
        }

        static void MakeMove()
        {
            rightMove = false;
            countRightMove = 0;
            if (gameStatus == 6)
            {
                Console.WriteLine("Ты проиграл!");
                return;
            }

            for (int i = 0; i < showenWord.Length; i++)
            {
                if (showenWord[i] != '_')
                {
                    countRightMove++;

                }
                else
                {
                    break;
                }
            }

            if (countRightMove == showenWord.Length)
            {
                Console.WriteLine("Победа!");
                return;
            }

            Console.WriteLine("Введите букву: ");
            move = Console.ReadLine().ToCharArray();
            Testmove();


        }

        static void Testmove()
        {
            for (int i = 1; i < targetWord.Length - 1; i++)
            {

                if (move[0] == targetWord[i])
                {
                    rightMove = true;
                    showenWord[i] = move[0];

                }

            }
            Reaction();
        }

        static void Reaction()
        {
            if (rightMove == true)
            {

                Console.Clear();
                DrawHangman();
                ShowField();
                MakeMove();
            }
            else
            {
                gameStatus++;
                Console.Clear();
                DrawHangman();
                ShowField();
                MakeMove();
            }
        }
    }
}
