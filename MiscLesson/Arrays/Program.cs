int[] numbers = new int[5] { 1, 2, 3, 4, 5};
//initialise an array and declares its size and what data type, and assings at initialisation^
Console.WriteLine("Element at index 0 is: " + numbers[0]);
Console.WriteLine("Element at index 1 is: " + numbers[1]);
Console.WriteLine("Element at index 2 is: " + numbers[2]);
//shows the default data is 0 for int^

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;
//assigns the data at each individual index^

Console.WriteLine("Element at index 0 is: " + numbers[0]);
Console.WriteLine("Element at index 1 is: " + numbers[1]);
Console.WriteLine("Element at index 2 is: " + numbers[2]);

Console.WriteLine("Second last is: " + numbers[numbers.Length -2]);
Console.WriteLine("Third     last is: " + numbers[^3]);
//alternate ways of accessing the end of the array, the second way is better

Console.ReadKey();