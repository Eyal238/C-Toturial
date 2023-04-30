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
             int[,] table = { { 3, 5, 7, 9 }, { 11, 13, 15, 17 }, { 19, 21, 23, 25 },{ 26, 28, 30, 32 } };
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
// 3.  כתוב פונקציה המקבלת מטריצה 2 על 5 מסוג מחרוזת. הפונקציה בודקת האם השם "יוסי"(באנגלית אותיות קטנות) נמצא במטריצה. אם כן תחזיר חיובי ואם לא תחזיר שלילי

using System;
namespace chapter
{
    class chapter1
    {
        static bool searchName(string[,] names)
        {
            int i, j;
            for(i=0;i<names.GetLength(0);i++)
            {
                for(j=0;j<names.GetLength(1);j++)
                {
                    if (names[i, j] =="moshe")
                        return true;
                }
            }
            return false;
        }
        static void Main( string[] args)
        {
            bool ans;
            string[,] names = { { "Adi", "Dany", "Rani", "Eli", "Beny" },{"Elbert","moshe","Sigal","Noam","Yoni"}};
            Console.WriteLine(ans=searchName(names));
        }
    }
}
