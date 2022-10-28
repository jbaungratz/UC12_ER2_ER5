// See https://aka.ms/new-console-template for more information


using UC12_ER2_ER5.Classes;


Console.WriteLine(@$"
==============================================================================
|                   Bem vindo ao sistema de cadastro de                      |
|                      Pessoas Físicas e Jurídicas                           |
==============================================================================
");
/*
Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow;

Console.Write("Carregando");


for (var contador = 0; contador < 20; contador++)
{
    Console.Write(". ");
    Thread.Sleep(200);
}

Console.ResetColor();
*/

BarraCarregamento("Carregando", 100);

string? escolha;

do
{

Console.Clear();
Console.WriteLine(@$"

==============================================================================
|                      Escolha uma das opções a seguir                       |
|____________________________________________________________________________|
|                                                                            |
|                           1 - Pessoa Físicas                               |
|                           2 - Pessoa Jurídica                              |
|                                                                            |
|                           0 - Sair                                         |
==============================================================================
");



    escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEnd = new Endereco();
            PessoaFisica metodoPf = new PessoaFisica();

            novaPf.nome = "José";
            novaPf.dataNascimento = "14/11/2014";
            novaPf.cpf = "01234567890";
            novaPf.rendimento = 8000.5f;
            novoEnd.logradouro = "Rua Cel Sarmento";
            novoEnd.numero = 1459;
            novoEnd.complemento = "apto 201";
            novoEnd.endComercial = true;

            novaPf.endereco = novoEnd;
            Console.WriteLine(@$"
            Nome: {novaPf.nome}
            Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
            Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim": "Não")}
            Taxa de Imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")} 
            ");
            Console.WriteLine($"Aperte 'Enter' para continuar");
            
            Console.ReadLine();

            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.nome = "NomePj";
            //novaPj.cnpj = "01.001.001/0001-01";
            novaPj.cnpj = "01001001000101";
            novaPj.razaoSocial = "Razão Social Pj";
            novaPj.rendimento = 8000.5f;

            novoEndPj.logradouro = "Rua Cel Sarmento";
            novoEndPj.numero = 1459;
            novoEndPj.complemento = "apto 201";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj}
            CNPJ é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim": "Não")}
            Taxa de Imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            ");

            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();

            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por você utilizar nosso sistema");
            /*
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Finalizando");
            for (var contador = 0; contador < 20; contador++)
                {
                    Console.Write(". ");
                    Thread.Sleep(100);
                }
            Console.ResetColor();
            */
            BarraCarregamento("Finalizando", 300);
            break;
        default:

            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opçao.");
            Thread.Sleep(3000);
            Console.Clear();
            break;
    }

} while (escolha != "0");


static void BarraCarregamento(string texto, int tempo) {
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"{texto}");        
            for (var contador = 0; contador < 20; contador++)
                {
                    Console.Write(". ");
                    Thread.Sleep(tempo);
                }
            Console.ResetColor();
}




