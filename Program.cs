{

double M, A, IMC;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("|-----------------------------|");
Console.Write("|");
Console.WriteLine("CALCULADORA IMC              |");
Console.WriteLine("|-----------------------------|");
Console.ResetColor();


Console.WriteLine("MASSA (KG): ");
M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("ALTURA (M): ");
A = Convert.ToDouble (Console.ReadLine());
IMC = M / Math.Pow(A, 2);
Console.WriteLine($"\nIMC: {IMC:N2} ");
if (IMC < 17)
{
    Console.WriteLine("Muito abaixo do peso");

}
    else if(IMC >=17 && IMC < 18.5)
    {
        Console.WriteLine("Abaixo so Peso");
    

    }
        else if (IMC >= 18.5 && IMC < 25)
        {
            Console.WriteLine("Peso ideal!");


        }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("Sobrepeso");



            }
                else if (IMC >= 30 && IMC < 35)
                {
                    Console.WriteLine("Sobrepeso!");



                }
                    else if (IMC >= 35 && IMC < 40)
                    {
                        Console.WriteLine("Obesidade Severa, procure um hospital");


                    }
                        else
                        {
                            Console.WriteLine("Obesidade morbida, vá agora no medico. Por favor!");


                        }
}
  