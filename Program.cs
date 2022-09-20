// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

public class Program
{
	
	static void pairMultiply(int[] array)
	{
		int size = array.Length; 
		int count = 0; 
		for(int i = 0, j = size - 1; i < size / 2; i++, j--) 
		{
			int pairMult = array[i] * array[j]; 
			Console.WriteLine($"multiplys pair {++count} = {pairMult}");
		}
	}


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