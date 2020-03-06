using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(
                new int [3, 3]{
                    {1, 3, 5},
                    {2, 4, 6},
                    {3, 5, 9}
                },
                3
            );

            matrix.PritnMatrix();
            int determinant1 = matrix.CalculateDeterminantMexicanStyle();
            Console.WriteLine (determinant1);

            int determinant2 = matrix.CalculateDeterminant(); 
            Console.WriteLine (determinant2);

        }
    }
}
