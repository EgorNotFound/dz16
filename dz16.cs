//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double [] array = GetArray (12 ,-100 , 100);
double difference =0;
double min = 0;
double max = 0;
Console.WriteLine(String.Join(" ", array.Select(n=>$"{n:F2}")));
double [] GetArray (int size, int minValue, int maxValue)
{
    double[] res = new double [size];
    for (int i =0; i< size;i++ )
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
for (int i = 0; i< array.Length;i++){
   if(array[i]<min){
    min = array[i];
}
if(array[i]>max){
    max = array[i];
}
}
difference = max - min;
if(difference<0){
    difference = difference*(-1);
}

Console.WriteLine("Минимальный элемент: " + min  + " Максимальный элемент: " + max +  " Разница между минимальным и максимальным элементом: " + difference );

