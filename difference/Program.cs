 Console.WriteLine("Entet number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entet number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
 
            if(num1 > num2)
            Console.WriteLine(num1);

            else if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine("num1=num2");
            }