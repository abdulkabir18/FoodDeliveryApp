Console.WriteLine("Enter first input");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second input");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Enter third input");
int c = int.Parse(Console.ReadLine());


int result = GetSumOfthreenum(a , b , c);
Console.WriteLine(result);

static int GetSumOfthreenum(int a, int b, int c)
{
   return a + b + c;
}