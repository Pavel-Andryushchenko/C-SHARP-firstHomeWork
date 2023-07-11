Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//int number;
//while (!int.TryParse(Console.ReadLine(), out number)) ;
string stringNumber = Console.ReadLine();                              // вводим с клавиатуры переменную stringNumber строкового типа
int a;                                                                 // вспомогательная переменная целочисленного типа 
bool chislo = int.TryParse(stringNumber, out a);                       // проверяем являются ли введенные данные числовыми 
         if (chislo)                                                 
         {
            int intNumber = int.Parse(stringNumber);                   // преобразуем переменную из строкового типа в целочисленный
            if (intNumber % 2 == 0)                                    // проверяем является ли чило четным
            {
                Console.WriteLine("Число четное!");
            }    
            else 
            {   
                Console.WriteLine("Число нечетное!");
            }
         }
         else
         {
            Console.WriteLine("Введено недопустимое значение!");
         }

