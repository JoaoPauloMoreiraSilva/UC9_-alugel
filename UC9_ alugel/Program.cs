int adultos, criancas, animais;
double valoralugel, valorfinal;

valoralugel = 0;
valorfinal = 0;
adultos = 0;    
animais = 0;    
criancas = 0;

Console.WriteLine("qual o valor do alugel?");
valoralugel = double.Parse(Console.ReadLine());

Console.WriteLine("quantidade de adultos");
adultos = int.Parse(Console.ReadLine());

Console.WriteLine("quantidade de criancas");
criancas = int.Parse(Console.ReadLine());

Console.WriteLine("quantidade de animais");
animais = int.Parse(Console.ReadLine());

valorfinal = valoralugel - (adultos * (valoralugel * 0.0125)) - (criancas * (valoralugel * 0.0107)) + (animais * (valoralugel * 0.02));

Console.WriteLine("o valor final é: " + valorfinal);








