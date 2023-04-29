// 2. כתוב פונקציה המגדירה מטריצה 4 על 5 מסוג מספרים שלמים. הפונקציה תבדוק ותדפיס כמה מספרים זוגיים קיימים במטריצה 
using System;
namespace chapter
{
    class chapter1
    {
        static void manyDouble()
        {
            int i, j;
            int count = 0;
            int[,] table = { { 2, 5, 7, 9 }, { 11, 13, 15, 17 }, { 19, 21, 23, 25 } };
            for(i=0;i<table.GetLength(0);i++)
            {
                for (j = 0; j < table.GetLength(1);j++)
                {
                    if (table[i, j] % 2 == 0)
                        count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            manyDouble();
        }
    }
}
