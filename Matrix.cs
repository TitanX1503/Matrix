using System;

namespace Matrix
{
    class Matrix
    {
        private int[,] grid = new int [3,3];

        private int gridSize;

            public Matrix(int [,] gridValues, int gridSize)
            {
                this.grid = gridValues;
                this.gridSize = gridSize;
            }

            public void PritnMatrix()
            {
                //iterar filas
                for(int y = 0; y < this.gridSize; y++)
                {
                    for (int x = 0; x < this.gridSize; x++)
                    {   //imprimir
                        Console.Write(grid[y, x]);
                    }

                    Console.WriteLine();
                }
            }

            public  int CalculateDeterminantMexicanStyle()
            {
                return this.grid[0, 0] * this.grid[1, 1] * this.grid[2, 2]
                + this.grid[0, 1] * this.grid[1, 2] * this.grid[2, 0]
                + this.grid[0, 2] * this.grid[1, 0] * this.grid[2, 1]
                - this.grid[0, 2] * this.grid[1, 1] * this.grid[2, 0]
                - this.grid[0, 0] * this.grid[1, 2] * this.grid[2, 1]
                - this.grid[0, 1] * this.grid[1, 0] * this.grid[2, 2];
            }

            public int CalculateDeterminant()
            {
                int result = 0;
                //literar primeras (3) diagonales
                for (int i = 0; i < this.gridSize; i++)
                {
                    
                    int diagonalResult = 1;
                    
                         //calcular valor de y que siempre es 0, luego 1, luego 2
                    for (int y = 0; y < this.gridSize; y++)
                    {
                        //calcular x
                        //la x es 0, luego 1 y luego 2 pero dependiendo
                        //del # de la literacion, se le suma un numero
                        
                        int x = y + i;

                        if(x >= this.gridSize)
                        {
                            x = x - this.gridSize;
                        }
                        diagonalResult = diagonalResult * this.grid[y, x];

                    }
                         result += diagonalResult;
                }

                for (int i = 0; i < this.gridSize; i++)
                {
                    int diagonalResult = 1;
                  for (int y = 0; y < this.gridSize; y++)
                    {
                        int x = 2 - y;

                        x-= i * 2;

                        while (x < 0)
                        {
                            x += 3;
                        }

                        diagonalResult *= this.grid[y, x];
                    }

                    result -= diagonalResult;  
                }
                
                
                return result;
            }
    }
}
