char sinal;
double oper1, oper2, resultado=0;

// obtencao da entrada
Console.WriteLine("Operadorea");
Console.WriteLine("+ - * / ");
Console.Write("digite o operador");
sinal = Console.ReadLine()[0];
while (sinal != '-' && sinal != '+' && sinal != '*' && sinal != '/')
{
    Console.WriteLine("\noperador invalido. Digite novamente!");
    Console.Write("digite o operador");
    sinal = Console.ReadLine()[0];
}

Console.Write("digite o operando 1: ");
oper1 = Convert.ToDouble(Console.ReadLine());
Console.Write("digite o operando 2: ");
oper2 = Convert.ToDouble(Console.ReadLine());
while (sinal == '/' && oper2 == 0)
{
    Console.WriteLine("impossible hahahaha");
    Console.Write("digite o operando 2: ");
    oper2 = Convert.ToDouble(Console.ReadLine());
}
switch (sinal)
{
    case '+':
        resultado = oper1 + oper2;
        break;
    case '-':
        resultado = oper1 - oper2;
        break;
    case '*':
        resultado = oper1 * oper2;
        break;
    case '/':
        resultado = oper1 / oper2;
        break;
}

//display

Console.WriteLine("\n"+oper1+" "+sinal+" "+oper2+" = "+resultado);

