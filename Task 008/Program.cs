bool correctInput = false;
string numberAString = "";
while(!correctInput){
    Console.WriteLine("Введите число ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    numberAString = Convert.ToString(numberA);
        if(numberAString.Length!=3) {Console.WriteLine("Это не трехзначное число, введите заново, а то по лбу стукну");}    
        else {correctInput = true;
        }
}

int numberToShow = Convert.ToInt32(numberAString.Substring(0,1)+numberAString.Substring(2));
Console.WriteLine(numberToShow);