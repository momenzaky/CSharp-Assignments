using System;

namespace Assignmnt_1
{
    internal class Program
    {
        class Book
        {
            public string Title = "";
            public int Pages;

            public override string ToString()
            {
                return $"Title: {Title}, Pages: {Pages}";
            }
        }

        static void Main(string[] args)
        {
            #region Book

            Book b1 = new Book();

            b1.Title = "CCTV";
            b1.Pages = 300;

            object obj = b1;

            Console.WriteLine(obj);

            #endregion

            #region ToString()

            Console.WriteLine(b1.ToString());

            #endregion

            #region Equals()

            Console.WriteLine(b1.Equals(b1));

            #endregion

            #region GetHashCode()

            Console.WriteLine(b1.GetHashCode());

            #endregion

            #region GetType()

            Console.WriteLine(b1.GetType());

            #endregion

            #region Parse()

            int pages = int.Parse("464");
            Console.WriteLine(pages);

            #endregion

            #region Errors

            try
            {
                int x = 10;
                int y = 0;

                int result = x / y;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            #endregion

            #region Implicit Casting

            int Pages = 300;
            double d = Pages;

            Console.WriteLine(d);

            #endregion

            #region Explicit Casting

            double Price = 49.99;
            int intPrice = (int)Price;

            Console.WriteLine(intPrice);

            #endregion

            #region Convert

            string PagesText = "464";
            int intPages = Convert.ToInt32(PagesText);

            Console.WriteLine(intPages);

            #endregion

            #region Parse() & TryParse()

            string yearText = "2023";
            int year = int.Parse(yearText);

            Console.WriteLine(year);

            string badText = "abc";

            bool isValid = int.TryParse(badText, out int parsedText);

            int Text = isValid ? parsedText : 0;

            Console.WriteLine(Text);

            if (Text == 0)
            {
                Console.WriteLine("Invalid number.");
            }
            else
            {
                Console.WriteLine($"Parsed value: {Text}");
            }

            #endregion

            #region ToString() & GetType()

            int page = 464;

            string pagesString = page.ToString();

            Console.WriteLine(pagesString);
            Console.WriteLine(pagesString.GetType());

            #endregion

            #region Box & UnBox

            int copies = 100;

            object obj2 = copies;         

            int newcopies = (int)obj2;    

            Console.WriteLine(copies);
            Console.WriteLine(newcopies);

            #endregion

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }
    }
}