using System.Text;

namespace Assignment_Session_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Q1
            Console.WriteLine("--------------------- [1] --------------------------");

            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine($"Before Calling ToUpper(): {title}");
            Console.WriteLine($" After Calling ToUpper(): {upperTitle}");

            Console.WriteLine();
            #endregion

            #region Q2
            Console.WriteLine("--------------------- [2] --------------------------");

            string word01 = "Clean Code", word02 = "Clean Code";
            bool ok = ReferenceEquals(word01, word02);

            Console.WriteLine(ok ? "Equals" : "Not Equals");

            Console.WriteLine();
            #endregion

            #region Q5
            Console.WriteLine("--------------------- [5] --------------------------");

            string Title05 = "Clean Code";
            int Pages = 464;

            Console.WriteLine("Book: " + Title05 + "\n" + "Pages: " + Pages);

            Console.WriteLine();
            #endregion

            #region Q6
            Console.WriteLine("--------------------- [6] --------------------------");

            Console.WriteLine($"Book: {Title05}\npPages: {Pages}");

            Console.WriteLine();
            #endregion

            #region Q8
            Console.WriteLine("--------------------- [8] --------------------------");

            int Pages08 = 464;
            if(Pages08 > 300)
                Console.WriteLine("Long Page");
            else
                Console.WriteLine("Short Page");

            Console.WriteLine();
            #endregion

            #region Q9
            Console.WriteLine("--------------------- [9] --------------------------");

            int Pages09 = 464;
            bool isAvailable = true;
            if(Pages09 > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");


            Console.WriteLine();
            #endregion

            #region Q10
            Console.WriteLine("--------------------- [10] --------------------------");

            string title10 = "Refactoring";
            switch (title10)
            {
                case "Clean Code":
                    Console.WriteLine("Great Choice");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;

                default:
                    Console.WriteLine("Never Heard");
                    break;

            }

            Console.WriteLine();
            #endregion

            #region Q11
            Console.WriteLine("--------------------- [11] --------------------------");

            int Pages11 = 464;
            string sizeLabel = Pages11 > 300 ? "Long Page" : "Short Page";
            Console.WriteLine(sizeLabel);

            Console.WriteLine();
            #endregion

            #region Q12
            Console.WriteLine("--------------------- [12] --------------------------");

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + books[i]);
            }

            Console.WriteLine();
            #endregion

            #region Q13
            Console.WriteLine("--------------------- [13] --------------------------");

            int it = 0;
            while(it < books.Length)
            {
                Console.WriteLine(books[it]);
                it++;
            }

            Console.WriteLine();
            #endregion

            #region Q14
            Console.WriteLine("--------------------- [14] --------------------------");

            int j = 0;
            do
            {
                Console.WriteLine("Checking book...");
                j++;
            } while (j < 3);

            Console.WriteLine();
            #endregion

            #region Q15
            Console.WriteLine("--------------------- [15] --------------------------");

            foreach(string book in books)
                Console.WriteLine(book);

            Console.WriteLine();
            #endregion

            #region Q16
            Console.WriteLine("--------------------- [16] --------------------------");

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] == "Refactoring") break;
                Console.WriteLine(books[i]);
            }

            Console.WriteLine();
            #endregion

            #region Q17
            Console.WriteLine("--------------------- [17] --------------------------");

            for(int i = 0; i < books.Length; i++)
            {
                if (books[i] == "The Pragmatic Programmer") continue;
                Console.WriteLine(books[i]);
            }

            Console.WriteLine();
            #endregion

            #region Q18
            Console.WriteLine("--------------------- [18] --------------------------");

            PrintFirstBook(books);

            Console.WriteLine();
            #endregion

        }
        #region Method Of Q18
        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0) return;
            Console.WriteLine(books[0]);
        } 
        #endregion
    }
}
