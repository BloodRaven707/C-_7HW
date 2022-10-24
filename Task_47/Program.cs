namespace Console_Program
{
    class Project
    {
        /// <summary>Выводит сообщение в консоль, проверяет и преобразует пользовательский ввод.</summary>
        /// <param name="message">Выводимое в консоль сообщение</param>
        /// <returns>Число типа Int32</returns>
        static public int ConsoleInputInt32( string message="Введите целое число: " ) {
            int result = 0; 

            while ( true ) {
                Console.Write( message );

                if ( int.TryParse( Console.ReadLine() ?? "", out result ) )
                    break;

                Console.WriteLine( "[!] Вы ввели не верные данные!\n" );
            }
            return result; 
        }


        private static void Main( string[] args )
        {
            Console.WriteLine( "\n Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.\n" );
            // m = 3, n = 4.

            // Заполненный случайными вещественными числами.
            // 0,5  7   -2   -0,2
            // 1   -3,3  8   -9,9
            // 8    7,8 -7,1  9

            int m = ConsoleInputInt32( "Введите количество строк массива m = " );
            int n = ConsoleInputInt32( "Введите количество столбцов массива n = " );
            double[,] some_array = new double[m, n];

            // [!] Не стал выделять в отдельную функцию...
            // Не нравится не универсальность, для разных типов данных...
            {
                double min_range = -100;
                double max_range = 100;
                Random rand = new Random();
                Console.WriteLine();

                for ( int i = 0; i < m; i++ ) {

                    for ( int j = 0; j < n; j++ ) {
                        some_array[i, j] = rand.NextDouble() * ( max_range - min_range ) + min_range;
                        // Использовано форматирование вывода
                        Console.Write( $"{some_array[i, j], 7:f1}" );
                    }
                    
                    Console.WriteLine();
                }

                Console.WriteLine();
            }
        }
    }
}
