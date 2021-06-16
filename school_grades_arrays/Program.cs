using System;

namespace school_grades_arrays
{
    class Program
    {
        static void Main(string[] args)

        {
            #region format 1
            //var studentGrade = new int[10];

            //studentGrade[0] = 10;
            //studentGrade[1] = 20;
            //studentGrade[2] = 30;
            //studentGrade[3] = 40;
            //studentGrade[4] = 50;
            //studentGrade[5] = 60;
            //studentGrade[6] = 80;
            //studentGrade[7] = 90;
            //studentGrade[8] = 100;
            //studentGrade[9] = 110;
            //Console.WriteLine(studentGrade[4]);
            #endregion

            var studentGrades = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110 };

            foreach (var studentGrade in studentGrades)
            {
            Console.WriteLine(studentGrade);

            }

        }
    }
}
