namespace Rotate_a_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = {{5, 1, 9, 11},{2, 4, 8, 10},{13, 3, 6, 7},{15, 14, 12, 16} };

            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int m = matrix.GetLength(0);
            int n = matrix.GetLength(1);
            Console.WriteLine($"Rows: {m} , Cols : {n}");
            bool[,] visited = new bool[m,n];
            for (int i = 0; i < m; i++)
            {

                for (int j = 1; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        var t = matrix[i, j];
                        matrix[i, j] = matrix[j, i];
                        matrix[j, i] = t;
                        visited[i, j] = true;
                        visited[j, i] = true;
                    }
                }
                int start = 0;
                int end = n - 1;
                while(start < end)
                {
                    
                    var tmp = matrix[i, start];
                    matrix[i, start] = matrix[i, end];
                    matrix[i,end] = tmp;

                    start++; 
                    end-- ;
                }
                 Console.WriteLine();
            }

            for(int i=0; i<m ; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            



           
            
        }
    }
}

//int[,] res = new int[rows,cols];


//for(int r  = 0; r < rows;r++)
//{

//    for(int c = cols-1;c >=0; c--)
//    {
//        res[r,c] = matrix[c,r];
//        Console.Write(matrix[c,r] + " ");
//    }
//    Console.WriteLine();
//}