bool correctInput = false;
while(!correctInput){
    Console.WriteLine("Введите число ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    string numberAString = Convert.ToString(numberA);
        if(numberAString.Length!=3) {Console.WriteLine("Это не трехзначное число, введите заново, а то по лбу стукну");}    
        else {correctInput = true;
        Console.WriteLine(numberAString.Substring(1,1));}
}



