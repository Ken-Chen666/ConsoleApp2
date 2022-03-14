using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j,i;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int innum = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 3; i++)
            {
                Console.WriteLine(innum+"*"+i+"="+innum*i);
            }
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    Console.Write(i + "*" + j + "=" + i * j+" ");
                }
                Console.WriteLine();
            }
            int[] studentNo = { 1, 2, 3, 4, 5 };
            string[] studentName = {"Jack","Mary","Tom","Grace","Alice" };
            int[] computerScore = { 80, 65, 100, 98, 83 };
            int[] progarmScore = { 75, 67, 93, 25, 82 };
            int[] animationScore = { 60, 62, 91, 50, 87 };
            while (true)
            {
                Console.WriteLine("輸入座號(1-5)");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayIndex = Array.IndexOf(studentNo, inputStudentNo);
                if (arrayIndex > -1)
                {
                    Console.WriteLine("姓名"+studentName[arrayIndex]);
                    Console.WriteLine("電腦概論" +computerScore[arrayIndex]);
                    Console.WriteLine("程式設計" +progarmScore[arrayIndex]);
                    Console.WriteLine("動畫設計" +animationScore[arrayIndex]);
                }
                else
                {
                    Console.WriteLine("沒有這個座號");
                }
            }

        }
    }
}
