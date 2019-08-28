using System;
using System.Collections.Generic;

namespace nnguyen1_MovieinCsharp
{
    public class ConsoleUI
    {
        private static ConsoleUI UI = new ConsoleUI();
        private ConsoleUI() { }

        public ConsoleUI getUI()
        {
            return UI;
        }

        public void outputMovies(List<Movie> m)
        {
            for (int i = 0; i < m.Count; i++)
            {
                Console.WriteLine(i + ":" + m[i]);
            }
        }

        public Choices getChoice()
        {
            bool moreChoices = true;
            string input = null;
            do
            {
                Console.Write("'1' List Movies\n" +
                    "'2' Select Rating\n" +
                    "'3' Select Genre\n" +
                    "'4' Delete\n" +
                    "'5' Exit\n" +
                    "Please enter choice: ");
                input = Console.ReadLine();
                switch (input.Trim())
                {
                    case "1": return Choices.LIST;
                    case "2": return Choices.BYRATING;
                    case "3": return Choices.BYGENRE;
                    case "4": return Choices.DELETE;
                    case "5":
                        moreChoices = false;
                        return Choices.EXIT;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5.");
                        break;
                }
            } while (moreChoices);
            return null;
        }

        public int getMovieToDelete(List<Movie> m)
        {
            bool notANumber = true;
            string input = null;
            int currentNumber = 0;
            outputMovies(m);

            do
            {
                Console.WriteLine("Please enter number to Delete: ");
                input = Console.ReadLine();
                try
                {
                    if (input != null && input.Trim().Length > 0)
                    {
                        currentNumber = Convert.ToInt32(input);
                        notANumber = false;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Not a valid number");
                }
            } while (notANumber);
            return currentNumber;
        }

        public Rating getRating()
        {
            string input = null;
            do
            {
                Console.Write("'1' G\n'2' PG\n'3' PG-13\n'4' R\n'5' NR\nPlease enter rating: ");
                input = Console.ReadLine();
                switch (input.Trim())
                {
                    case "1": return Rating.G;
                    case "2": return Rating.PG;
                    case "3": return Rating.PG13;
                    case "4": return Rating.R;
                    case "5": return Rating.NR;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 5.");
                        break;
                }
            } while (true);
        }

        public Genre getGenre()
        {
            string input = null;
            do
            {
                Console.Write("'1' Action\n'2' Child's Cartoon\n'3' Comedy\n'4' Drama\n'5' Epics\n'6' Horror\n'7' Musicals\n'8' Romance\n'9' SciFi\n'10' War\nPlease enter Genre : ");
                input = Console.ReadLine();

                switch (input.Trim())
                {
                    case "1": return Genre.ACTION;
                    case "2": return Genre.CHILDCARTOON;
                    case "3": return Genre.COMEDY;
                    case "4": return Genre.DRAMA;
                    case "5": return Genre.EPICS;
                    case "6": return Genre.HORROR;
                    case "7": return Genre.MUSICALS;
                    case "8": return Genre.ROMANCE;
                    case "9": return Genre.SCIFI;
                    case "10": return Genre.WAR;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 10.");
                        break;
                }
            } while (true);
        }
    }
}
