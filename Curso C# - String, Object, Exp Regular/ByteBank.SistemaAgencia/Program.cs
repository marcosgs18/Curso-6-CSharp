using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;


namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Mundo!");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            object conta = new ContaCorrente(456, 45677);
            object desenvolvedor = new Desenvolvedor("498485");

            string contaToString = conta.ToString();

            Console.WriteLine($"Resultado {contaToString}");
            Console.WriteLine(conta);

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            if (carlos_1.Equals(carlos_2))
            {
                Console.WriteLine("São iguais!");
            }
            else
            {
                Console.WriteLine("Não são iguais!");
            }
            Console.ReadLine();
        }

        static void TestaString()
        {
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "Meu nome é Guilherme, me ligue 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
            Console.ReadLine();


            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("ByteBank"));


            Console.ReadLine();

            // pargina?argumentos
            /* string url = "pagina?moedaOrigem=real&moedaDestino=dolar";

             int indiceInterrogacao = url.IndexOf('?');

             Console.WriteLine(indiceInterrogacao);

             Console.WriteLine(url);
             string argumentos = url.Substring(indiceInterrogacao + 1);
             Console.WriteLine(argumentos);*/

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentoURL extratorDeValores = new ExtratorValorDeArgumentoURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moeda destino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moeda origem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();


            //Testando ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(termoBusca.ToUpper());
            Console.WriteLine(mensagemOrigem.ToLower());


            //Testando Replace
            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();





            // Testando o método Remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));
            Console.ReadLine();



            // <nome>=<valor>
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino=";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length);

            Console.WriteLine(palavra);
            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length));

            Console.ReadLine();
        }
    }
}
