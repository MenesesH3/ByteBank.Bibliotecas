// See https://aka.ms/new-console-template for more information
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using Humanizer;

DateTime dataFimPagamento = new DateTime(2018, 6, 30);
DateTime dataCorrente = DateTime.Now;

TimeSpan diferenca = dataFimPagamento - dataCorrente;

string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
Console.WriteLine(mensagem);

Console.ReadLine();