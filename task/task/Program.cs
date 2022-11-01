//1ci task
int input = 56;
int givennum = 2;
int answ = 1;
while (input > givennum)
{
    givennum *= 2;
    answ++;
}

int close = input - givennum / 2;
int far = givennum - input;
if (far <= close)
{
    Console.WriteLine(--answ);
}
else
{
    Console.WriteLine(answ);
}


//task2
int num = 643;
    int sum = 0;
    int value = 0;
    while (num > 0)
    {
        value = num % 10;
        num /= 10;
        sum += value;

    }
    Console.WriteLine(sum);





    //3cu task
    int numb = 50;
    int count = 0;
    for (int i = 1; i <= numb; i++)
    {
        if (numb % i == 0)
        {

            count++;
        }
    }
    if (count > 2)
    {
        Console.WriteLine("murekkebdir");
    }
    else if (count == 1)
    {
        Console.WriteLine("ne sadedir ne murekkeb");
    }
    else
    {
        Console.WriteLine("sadedir");
    }






//1.Verilmiş ədədin 2 -in neçənci qüvvəti(və ya neçənci qüvvətinə yaxın) olduğunu tapın
//2. Ədədin rəqəmləri cəmini tapın
//3. Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın
