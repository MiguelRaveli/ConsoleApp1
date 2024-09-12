string dia_30 = "Este mes tem 30 dias";
string dia_28 = "Este mes tem 28 dias";
string dia_31 = "Este mes tem 31 dias";
Console.WriteLine("Digite um mês:");
string mes = Convert.ToString(Console.ReadLine().ToUpper());

switch (mes)
{
    case "FEVEREIRO":
        Console.WriteLine(dia_28);
        break;
    case "JANEIRO":
    case "MARÇO":
        Console.WriteLine(dia_31);
        break;
    case "ABRIL":
        Console.WriteLine(dia_30);
        break;
    default:
        Console.WriteLine("Mes Invalido");
        break;
}
