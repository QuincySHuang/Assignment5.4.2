
//time complexity O(n^2) due to the nested for loops


namespace Assignment5._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of matrix?: ");
            int size = Convert.ToInt32(Console.ReadLine());


            int[,] matrix = new int[size, size];

            Console.WriteLine("Elements of matrix?: ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Element at position [{i}, {j}]");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matrix is: ");
            for(int i = 0;i < size; i++)
            {
                for(int j = 0;j < size; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();

            }
            int rightDiagonal = 0;
            for(int i = 0; i < size; i++)
            {
                rightDiagonal = rightDiagonal + matrix[i, size - 1 -  i];
            }

            Console.WriteLine($"Sum of right diagnoal is: {rightDiagonal}");

        }
    }
}
