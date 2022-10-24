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

        
        /// <summary>Рассчитывает среднее арифметическое значений в столбце таблицы.</summary>
        /// <param name="some_array">Int32[,] - 2D Массив</param>
        /// <param name="col">Int32 - Номер столбца массива</param>
        /// <param name="precision">int32 - точность округления</param>
        /// <returns>Double - Среднее арифметическое, с округлением .f2, по умолчанию.</returns>
        static public double ColumnSumAverage( int[,] some_array, int col, int precision=2 ) {
            double result = 0.0;
            
            for ( int i = 0; i < some_array. GetLength(0); i++ )
                result += some_array[i, col];
            
            return Math.Round( result / some_array.GetLength(0), precision );
        }
        

        private static void Main( string[] args ) {
            // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            Console.WriteLine( "\n Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.\n" );
            
            // Например, задан массив:
            // 1 4 7 2
            // 5 9 2 3
            // 8 4 2 4
            int m = ConsoleInputInt32( "Введите количество строк массива m = " );
            int n = ConsoleInputInt32( "Введите количество столбцов массива n = " );
            int[,] some_array = new int[m, n];


            // [!] Не стал выделять в отдельную функцию...
            // Не нравится не универсальность, для разных типов данных...
            {
                int min_range = -100;
                int max_range = 100;
                Random rand = new Random();
                Console.WriteLine();

                for ( int i = 0; i < m; i++ ) {

                    for ( int j = 0; j < n; j++ ) {
                        some_array[i, j] = rand.Next( min_range, max_range );
                        // Использовано форматирование вывода
                        Console.Write( $"{some_array[i, j], 6:g}" );
                    }
                    
                    Console.WriteLine();
                }
            }

            // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
            double[] colomns_average = new double[n];
            Console.WriteLine( "\nСреднее арифметическое по столбцам:\n");
            
            for ( int i = 0; i < n; i++ ) {
                colomns_average[i] = ColumnSumAverage(some_array, i, 1);
                Console.Write( $"{colomns_average[i], 6:f1}" );
            }

            // Дополнительно в одну строку...
            Console.WriteLine( $"\n\nДополнительно в одну строку...\nСреднее арифметическое по столбцам: {String.Join("; ", colomns_average)}.\n" );
        }
    }
}
