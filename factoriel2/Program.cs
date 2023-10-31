//shomare 5  factoriel
//amir mahdi hosein njad
string YESorNO;
do
{
    Console.WriteLine("adad mored nazar ra baray factoriel vared konid ");

    int number = Convert.ToInt32(Console.ReadLine());

    long f = number;

    if (number == 0)
        f = 1;
    for (int i = 1; i < number; i++)

    {
        f = f * i;
    }
    Console.WriteLine(f);
    Console.WriteLine("mikhay adad dige ham  test koni?y or n");
} while (Console.ReadLine() == "y");
Console.WriteLine("------payan------");
