/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] CreateArray(int size, int min, int max){
    int []array=new int[size];
    for(int i=0; i<size; i++){
        array[i]= new Random().Next(min, max);
}
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int EvenNumb(int [] array){
    int evens=0;
    for (int i=0; i<array.Length; i++){
        if (array[i]%2==0)
            evens++;
    }
    return evens;
}
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =100;
int max=1000;  
int [] array = CreateArray(size, min, max);

ShowArray(array);

Console.WriteLine($"Число четных чисел в массиве равно: {EvenNumb(array)}");

/* Задача 36: Задайте одномерный массив,
 заполненный случайными числами. Найдите сумму элементов,
 стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int [] CreateArray(int size, int min, int max){
    int []array=new int[size];
    for(int i=0; i<size; i++){
        array[i]= new Random().Next(min, max);
}
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int Summ(int [] array){
    int summ=0;
    for (int i=0; i<array.Length; i++){
        if (i%2>0) //по нечетным индексам
           summ+= array[i];
    }
    return summ;
}
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =-100;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);
Console.WriteLine($"Сумма чисел на нечётных позициях в массиве равно: {Summ(array)}");

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int [] CreateArray(int size, int min, int max){
    int []array=new int[size];
    for(int i=0; i<size; i++){
        array[i]= new Random().Next(min, max);
}
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int Dec(int [] array){
    int dec=0;
    int min = array[0];
    int max=array[0];
    for (int i=1; i<array.Length; i++){
        if (min>array[i])
           min= array[i];
        if (max<array[i])
            max=array[i];
    }
        dec=max-min;    
    return dec;
}
Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min =-100;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);
Console.WriteLine($"Разница макс и мин элементов массива равна: {Dec(array)}");

/*Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123:
[5,18,123,6, 21 -> 1
[1,2,3, 6, 2] -> 0
[10,11,12,13,14] -> 5
*/

int [] CreateArray(int size, int min, int max){
    int []array=new int[size];
    for(int i=0; i<size; i++){
        array[i]= new Random().Next(min, max);
}
    return array;
}

void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

int Levels(int [] array){
    int res=0;
    int minlevel = 10;
    int maxlevel = 99;
    for (int i=0; i<array.Length; i++){
        if (array[i]>=minlevel && array[i]<=maxlevel)
        res++;   
    }
    return res;
   }
int size = 123;
int min =0;
int max=100;  
int [] array = CreateArray(size, min, max);

ShowArray(array);
Console.WriteLine($"Число элементов массива в интервале значений 10-99 равно: {Levels(array)}");

/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1,2 3 4 5] -> 5 8 3 [6 7 3 6]->36 21
*/
int [] CreateRNDArray(int size, int min, int max){
    int []array1=new int[size];
    for(int i=0; i<size; i++){
        array1[i]= new Random().Next(min, max);
}
    return array1;
}
int [] CreateArrayOfMilti(int size){
    int []array2=new int[size];
    return array2;
}
void ShowArray(int [] array){
    for (int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
        Console.WriteLine();
}

void Multip(int [] array1, int [] array2){
    if (array1.Length%2==0)
        for (int i=0; i<array2.Length; i++){
            array2[i]=array1[i]*array1[array1.Length-1-i];   
    }
        else {
            for (int i=0; i<array2.Length-1; i++){
            array2[i]=array1[i]*array1[array1.Length-1-i];
            }
        array2[array2.Length-1]=array1[array1.Length/2];
        }
}
l1: Console.WriteLine("Введите длину массива: ");
int size1 = Convert.ToInt32(Console.ReadLine());
if (size1<=2) {
    Console.WriteLine($"Длина массива должна быть больше 2");
    goto l1;
}
int size2=0;
if (size1%2==0)
    size2=size1/2;
    else
        size2=size1/2+1;
int min =0;
int max=10;  
int [] array1 = CreateRNDArray(size1, min, max);
int [] array2 = CreateArrayOfMilti(size2);

ShowArray(array1);
Multip(array1, array2);
ShowArray(array2);
