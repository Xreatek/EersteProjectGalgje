using System;
using System.Windows;

namespace First_Project_C_Sharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly string[] WordList = {"abandoned","aberdeen","abilities","ability"};
        public int WordListLength;
        public string ChosenWord;
        public string[] AlreadyGuessedArray;

        public MainWindow()
        {
            InitializeComponent();
            WordListLength = WordList.Length;
            ChosenWord = WordList[Random(0, WordListLength)];
        }

        private void TryLetterClick(object sender, RoutedEventArgs e)
        {
            if (ChosenWord == null)
            {
                return;
            }

            int WordChars = ChosenWord.Length;

            string LetterTry = sender.ToString().Replace("System.Windows.Controls.Button: ", string.Empty);
            Console.WriteLine("The word is " + ChosenWord);
            Console.WriteLine("Trying - " + LetterTry);


            var SplitWordArray = ChosenWord.ToCharArray();
            Console.WriteLine(SplitWordArray[0]);

            for (int i = 0; i < WordChars; i++)
            {
                string istring = SplitWordArray[i].ToString();
                Console.WriteLine("Is " + LetterTry + " the same as " + istring + "? #" + i);
                if (LetterTry == istring)
                {
                    Console.WriteLine("Passed check 1");
                    int AmtGuesed = AlreadyGuessedArray.Length;

                    string Result = Array.Find(AlreadyGuessedArray, element => element == LetterTry);

                    if (Result == LetterTry)
                        {
                            Console.WriteLine("Letter guessed already.");
                        }
                        else
                        {
                           Console.WriteLine("Yes!, New letter guessed!");
                        }   
                }
                else
                {
                    Console.WriteLine("No, Wrong guess.");
                }

            }

        }

        private void Restart(object sender, RoutedEventArgs e)
        {

        }

        private void Start(object sender, RoutedEventArgs e)
        {

        }


    }
}
