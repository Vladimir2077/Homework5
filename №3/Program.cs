Console.WriteLine("Введите количество чисел массива ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size]; 
FillArrayRandomNumbers(numbers); 
Console.WriteLine("Массив: ");
PrintArray(numbers); 
double min = Int32.MaxValue;
double max = Int32.MinValue; 
for (int a = 0; a < numbers.Length; a++) 
{     
    if (numbers[a] > max)        
        { 
        max = numbers[a];        
        }     
        if (numbers[a] < min)        
        {
            min = numbers[a];
        } 
}
Console.WriteLine($"количество элементов {numbers.Length} , Максимальное число = {max} , Минимальное число = {min} ");
Console.WriteLine($" разница между максимальным и минимальным числом = {max - min}"); 
void FillArrayRandomNumbers(double[] numbers)
    {
        for(int i = 0; i < numbers.Length; i++)       
            {
                numbers[i] = Convert.ToDouble(new Random().Next(-1000,1000)) / 100; 
            } 
    } 
    void PrintArray(double[] numbers)
    {
        Console.Write(" ");  
        for(int i = 0; i < numbers.Length; i++)    
            {
            Console.Write(numbers[i] + " ");     
            }
            Console.Write(" ");
            Console.WriteLine(); 
    }