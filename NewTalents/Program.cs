using NewTalents;

Calculadora calc = new Calculadora();

calc.Soma(2,2);
calc.Multiplicacao(2,2);
calc.Soma(3,2);
calc.Multiplicacao(3,2);

foreach (var item in calc.Historico())
{
    Console.WriteLine(item);
}