bool isWork = true;

while (isWork)
{
	Console.Write("Введите номер задания :");

int.TryParse(Console.ReadLine(), out int w);
	{
		switch (w)
		{
			case 1:
			{
                    int[] array = GetRandomArray(6, 100, 999);
                    int count = GetCount(array);
                    System.Console.WriteLine();
                    System.Console.WriteLine(string.Join(",", array));
                    System.Console.WriteLine($"Количество четных чисел в массиве равно - {count}!");
                    int[] GetRandomArray(int lenght, int min, int max)
                    {
                        int[] array = new int[lenght];
                        Random numb = new Random();

                        for (int count = 0; count < lenght; count++)
                        {
                            array[count] = numb.Next(min, max + 1);
                        }
                        return array;
                    }
                    int GetCount(int[] array)
                    {
                        int lenght = array.Length;
                        int count = 0;

                        for (int i = 0; i < lenght; i++)
                        {
                            if (array[i] % 2 == 0) count++;

                        }
                        return count;
                    }
			break;
			}
			case 2:
			{
                    int[] array = GetRandomArray(6, 1, 20);
                    int count = GetCount(array);
                    System.Console.WriteLine(string.Join(",", array));
                    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {count}!");
                    int[] GetRandomArray(int lenght, int min, int max)
                    {
                        int[] array = new int[lenght];
                        Random numb = new Random();

                        for (int count = 0; count < lenght; count++)
                        {
                            array[count] = numb.Next(min, max + 1);
                        }
                        return array;
                    }
                    int GetCount(int[] array)
                    {
                        int lenght = array.Length;
                        int count = 0;
                        System.Console.WriteLine($"Поскольку 0 % 2 = {0 % 2}, считаем 0 как четное число!");
                        for (int i = 1; i < lenght; i = i + 2)
                        {
                            count = array[i] + count;
                        }
                        return count;
                    }

                    break;         
			}
				
            case 3:
			{
                    double[] array = GetRandomArray(10, 100, 999);
                    double maxPosition = GetCount(array);
                    double minPosition = GetCount(array);
                    System.Console.WriteLine();
                    System.Console.WriteLine(string.Join("  ", array));
                    System.Console.WriteLine();
                    System.Console.WriteLine($"Максимальная позиция - {maxPosition}");
                    double[] GetRandomArray(int lenght, int min, int max)
                    {
                        double[] array = new double[lenght];
                        Random numb = new Random();

                        for (int count = 0; count < lenght; count++)
                        {
                            array[count] = Math.Round(numb.Next(min, max + 1) * 0.1, 1);
                        }
                        return array;
                    }
                    double GetCount(double[] array)
                    {
                        int lenght = array.Length;
                        double maxPosition = 0;

                        for (int i = 0; i < lenght; i++)
                        {
                            if (array[i] >= maxPosition) maxPosition = array[i];
                        }
                        return maxPosition;
                    }

                    void SelectionSort(double[] array)
                    {
                        int lenght = array.Length;
                        for (int i = 1; i < lenght; i++)
                        {
                            int Position = 1;
                            for (int j = 0; j < lenght; j++)
                            {
                                if (array[j] < array[Position])
                                {
                                    Position = j;
                                    minPosition = array[Position];
                                }
                            }
                        }
                        System.Console.WriteLine($"Минимальная позиция - {minPosition}");
                        System.Console.WriteLine($"Разница между максимальным и минимальным элементом - {maxPosition - minPosition}");
                        System.Console.WriteLine();
                    }
                    SelectionSort(array);
                    
            break;
            }
            
			case -1: isWork = false; break;
		}

	}
}

