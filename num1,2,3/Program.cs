 Console.WriteLine("Entet number 1:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entet number 2:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Entet number 3:");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int max = num1;
if (num2 > num1)
    max = num2;
if (num3 > max)
    max = num3;
    Console.WriteLine(max);