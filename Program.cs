using System;

namespace TinhTongDuongCheoChinh
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kích thước 
            Console.Write("Enter row: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter col: ");
            int cols = int.Parse(Console.ReadLine());

            // Ktra
            if (rows != cols)
            {
                Console.WriteLine("Error: Matrix is not square!!!");
                return;
            }

            // Khởi tạo 
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("Enter element [{0}, {1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Tính đường chéo?
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine("Sum of elements on the main diagonal: {0}", sum);
        }
    }
}
