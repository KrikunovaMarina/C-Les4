// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FullArray( int[] coll)
{
    int lenght = 8;
    int index = 0;
    while ( index<lenght)
    {
        coll[index]= new Random().Next(-200,100); // при изменении значений .Next() 
        index++;//программа будет  выводить рандомный массив из заданного диапазона
    }
}
void PrintArray(int[] coll )
{
    int count = coll.Length;
    int position =0;
    while(position < count)
    {
        Console.WriteLine( coll[position] );
        position++;
    }
}
int []array = new int [8];
FullArray(array);
PrintArray(array);
