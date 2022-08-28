Random rnd = new Random();
int numberA = rnd.Next(10,100);
int firstDigit = numberA/10;
int secondDigit = numberA%10;
Console.WriteLine("Получили "+numberA);
Console.Write("Наиболшая цифра - ");
if(firstDigit > secondDigit){
    Console.WriteLine(firstDigit);
}
else Console.WriteLine(secondDigit);