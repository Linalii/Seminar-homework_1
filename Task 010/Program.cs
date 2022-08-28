string numberAString = "";
Console.WriteLine("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberAString = Convert.ToString(numberA);
if(numberAString.Length<3) {Console.WriteLine("Третьей цифры нет");}    
 else { 
    Console.WriteLine("Третья цифра: "+numberAString.Substring(2,1));
    }

