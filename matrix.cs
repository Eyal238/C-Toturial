// 1. כתוב פונקציה הקולטת מהמקלדת מטריצה בגודל 3 על 3 מסוג מספרים שלמים. הפונקציה תדפיס כמה ערכים במטריצה גדולים מ-10 וקטנים מ-100

using System;
namespace matrix
{
    class Program
    {
        static void f1(int[,] num)
        {
            int i, j;
            int count = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (num[i, j] > 10 && num[i, j] < 100)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
  }
        static void Main(string[] args)
        {
            int[,] num = { {12,31,50},{30,42,41},{89,32,16}};
            f1(num);
        }
    }
}
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
// 4. כתוב פונקציה המקבלת מטריצה בגודל 5 על 5 מסוג מספרים שלמים המחזירה תשובה בוליאנית. הפונקציה תבדוק האם סכום האלכסון הראשי שווה 100. תחזיר חיובי או שלילי 
using System;

namespace matrix
{
    class Program
    {
        static bool diagonalHundred(int[,] matrix1)
        {
            int i, j=0;
            int sum = 0;
            for (i = 0; i < matrix1.GetLength(0); i++)
            {
                sum = sum + matrix1[i,j];
                j++;
            }
            if(sum==100)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            bool ans;
            int[,] matrix1 = { { 20, 31, 50, 20, 11 }, { 30, 20, 41, 43, 2 }, { 89, 32, 20, 4, 6 }, { 21, 34, 23, 20, 6 }, { 1, 2, 3, 4, 20 } };
            Console.WriteLine(ans=diagonalHundred(matrix1));
        }
    }
}
