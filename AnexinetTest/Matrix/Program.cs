using System;

namespace Matrix
{
    /****
     * Write a function that receives a matrix and returns its transposed one.
    ****/
    static class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter columns of the matrix: ");
            var columnsStr = Console.ReadLine();
            int.TryParse(columnsStr, out int columns);
            if (columns == 0)
            {
                Console.WriteLine("Enter a valid number: ");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Enter rows of the matrix: ");
            var rowsStr = Console.ReadLine();
            int.TryParse(rowsStr, out int rows);

            if (rows == 0)
            {
                Console.WriteLine("Enter a valid number: ");
                Console.ReadKey();
                return;
            }
            var matrix = SetNewMatrix(columns, rows);
            var transposedMatrix = TrasposeMatrix(matrix, columns, rows);
            PrintTransposedMatrix(transposedMatrix, columns, rows);
            Console.ReadKey();
        }


        /// <summary>
        /// Gets transposed matrix by given matrix
        /// </summary>
        /// <param name="matrix">The matrix</param>
        /// <param name="columns">The columns size of the matrix</param>
        /// <param name="rows">The rows size of the matrix</param>
        /// <returns>A transposed matrix</returns>
        static int[,] TrasposeMatrix(int[,] matrix, int columns, int rows)
        {
            Console.Write("\n\n   Transposing Matrix....\n\n ");

            var arrResult = new int[columns,rows];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    arrResult[j,i] = matrix[i,j];
                }
            }

            return arrResult;
        }


        /// <summary>
        /// Prints the transposed matrix in console
        /// </summary>
        /// <param name="matrix">The transposed matrix</param>
        /// <param name="columns">The columns size of the matrix</param>
        /// <param name="rows">The rows size of the matrix</param>
        static void PrintTransposedMatrix(int[,] matrix, int columns, int rows)
        {
            Console.Write("\n\n  *** Matrix Transposed complated ***\n\n ");

            for (int i = 0; i < columns; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < rows; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
            }
        }


        /// <summary>
        /// Returns a new matrix based on given column and row values
        /// </summary>
        /// <param name="columns">The columns size</param>
        /// <param name="rows">The rows size</param>
        /// <returns>A matrix that contains elements</returns>
        static int[,] SetNewMatrix(int columns, int rows)
        {
            Console.Write("Setting random elements in the matrix...\n");
            var numberArr = new int[columns, rows];
            var randow = new Random();
            for (int i = 0; i < columns; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < rows; j++)
                {
                    var newNumber = randow.Next(1, 20);
                    Console.Write("{0}\t", newNumber);
                    numberArr[i, j] = newNumber;
                }
            }

            return numberArr;
        }
    }
}

