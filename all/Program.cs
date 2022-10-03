Console.WriteLine("ENTER NUMBER");
int num = Convert.ToInt32(Console.ReadLine());
for(int i=2; i<=num; i++) {  // ЦИКЛ 
   if(i%2 == 0) { //ЭТО Я ВООБЩЕ МЕТОДОМ ПОДБОРА ВОТКНУЛ НУ ПОЛУЧАЕТСЯ I%2 = 0
    Console.Write("{0}" ,i++); // Они пишутся слитно Console.WriteLine("{0}" ,i++) можно и так 
   }
  }      
// ВООБЩЕ НЕ ПОНЯТНО ЧТОТО С ЛЕКЦИИ ВЗЯЛ ЧТОТО С ЗАДАЧИ 6 + интернет 

// Console.WriteLine("Введите длину: ");
// int n = int.Parse(Console.ReadLine());
//                                     //  ЭТО НЕ МОË ТАК ПРОСТО РЕШИЛ ПОСМОТРЕТЬ В ИНТЕРНЕТЕ 
// for (int i = 2; i <= n; i += 2)
//     Console.WriteLine(i);