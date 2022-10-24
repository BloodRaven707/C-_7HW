namespace Console_Program
{
    class Project
    {
        private static void Main( string[] args ) {
            Console.WriteLine( "\nЗадача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает " +
                               "значение этого элемента или же указание, что такого элемента нет.\n");

            // Например, задан массив:
            int[,] some_array = { {1, 4, 7, 2},
                                  {5, 9, 2, 3},
                                  {8, 4, 2, 4} };

            Console.WriteLine("Заданный массив:");
            for ( int i = 0; i < some_array.GetLength(0); i++ ) {
                for ( int j = 0; j < some_array.GetLength(1); j++ )
                    Console.Write( $"{some_array[i, j], 3:g}" );
                Console.WriteLine();
            }

            // 17 -> такого числа в массиве нет
            Console.WriteLine( "\n                   номер строки --↓↓-- номер столбца" );
            Console.Write    ( "Введите позицию элемента массива (mn): " );
            string position = Console.ReadLine() ?? "";
            string result = $"mn = {position} -> элемента в указанной поpзиции нет\n";

            if ( position.Length == 2 ) {
                int row = int.Parse( $"{position[0]}" ) - 1;
                int col = int.Parse( $"{position[1]}" ) - 1;

                if ( row < some_array.GetLength(0) && col < some_array.GetLength(1) )
                    result = $"Элемент в позиции { position } -> { some_array[row, col] }\n";
            }

            Console.WriteLine( result );
        }
    }
}
