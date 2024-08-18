// • Создать двумерный массив с размерами
// 3 x 5, состоящий из целых чисел
// • Вывести его элементы на экран

int[,] matrix = CreateMatrix (4, 5);
ShowMatrix (matrix);



int[,] CreateMatrix (int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount,columsCount]; //выделение памяти для двумерного массива

    // Заполнение массива
    Random rnd = new Random(); //выделение памяти для создания рандомного эл. массива//вынесено за цикл для меньшей ресурсоёмкости
    for (int i = 0; i < matrix.GetLength(0); i++ ) // GetLength(0) запрос к нулевому измерению - кол-ва строк в двумерном массиве   
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) запрос к первому измерению - кол-во столбцов в двумерном массиве
            {
                matrix[i,j] = rnd.Next(1,11);
            }
        }
    return matrix;
}

void ShowMatrix (int[,] matrix)
{
    // Вывод массива на экран
    for (int i = 0; i < matrix.GetLength(0); i++ ) 
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                Console.Write($"{matrix[i,j]} "); // Интерполяция строк
            }
            Console.WriteLine(); // перенос для вывода в виде таблицы
        }
}