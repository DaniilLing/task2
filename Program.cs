Console.WriteLine("введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int Mmax = 0;
if (num1 > num2) 
{
   num1 = Mmax;
}
else
{
    num2 = Mmax;
}
if (num2 >num3)
{
   num2 = Mmax;
}
else
{
   num3 = Mmax;
}
if (num3 > num1)
{
    num3 = Mmax;
}
else
{
    num1 = Mmax;
}
System.Console.WriteLine(Mmax);