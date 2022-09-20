// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

public class Program
{
	/*
	pairMultiply() на вход принимает массив, ни чего не возвращает
	*/
	static void pairMultiply(int[] array)
	{
		int size = array.Length; //для удобства объявим переменную размер массива
		int count = 0; //счётчик пар

		for(int i = 0, j = size - 1; i < size / 2; i++, j--) //переменная i обходит массив с начала, переменная j с конца.
		{
			int pairMult = array[i] * array[j]; //вычисляем произведение пары чисел
			Console.WriteLine($"multiplys pair {++count} = {pairMult}");
		}
	}

	/*
	метод для создания массива рандомных чисел
	int first значение первого рандомного значения
	int last значение последнего рандомного значения
	int capacity размер массива
	*/
	static int[] IntRandomArrayMaker(int first, int last, int capacity)
	{
		int[] array = new int[capacity];

		for(int i = 0; i < array.Length; i++)
		{
			array[i] = new Random().Next(first, last + 1);

			Console.Write(array[i] + " ");
		}
		return array;
	}
    static public void Main ()
    {

		int[] targetArray = IntRandomArrayMaker(0, 20, 10);
		Console.WriteLine();
		pairMultiply(targetArray);


    }
}