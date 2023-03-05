int anoInicial, anoFinal, qtdDias = 0;

Console.WriteLine("Informe o ano inicial: ");
anoInicial = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o ano final: ");
anoFinal = int.Parse(Console.ReadLine());

for (int ano = anoInicial; ano < anoFinal; ano++)
    if (ano % 400 == 0 || ((ano % 4 == 0) && (ano % 100 != 0)))
        qtdDias += 1;

qtdDias += (anoFinal - anoInicial) * 365;

Console.WriteLine("Tiveram " + qtdDias + " dias.");
