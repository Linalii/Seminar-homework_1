Console.WriteLine("Задай первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задай второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA == numberB*numberB){
    Console.WriteLine(numberA+" квадрат "+numberB);
}
else Console.WriteLine(numberA+" не квадрат "+numberB);
