Random rnd = new Random();
int numberA = rnd.Next(10,100);
double numberAremainder;
Console.WriteLine("Число для проверки: "+numberA);
Console.Write("Введите число для проверки на кратность: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA%numberB==0){
    Console.WriteLine(numberA+" кратно "+numberB);
}
else {
    numberAremainder = numberA%numberB;
    Console.WriteLine("Остаток от деления: "+numberAremainder);}
