namespace Utilizando_using_em_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*aqui abaixo deve ser colocado o caminho do arquivo, porém nesse caso temos um  texto que o StringReader irá ler*/
            string linhas = @"Esta é a primeira linha 
                            Esta é a segunda linha
                            Está é a penultima linha
                            Esta é a última linha";

            using (var leitor = new StringReader(linhas)) //Aqui utilizamos o using pois está instrução fornece uma abordagem melhor para destruição de arquivos
                                                          //criamos a variável leitor do tipo var que recebe a Classe StringReader derivada da classe TextReader que fará a leitura do arquivo linhas.
            {
                string item; //Criamos uma variável do tipo string com o nome de item 
                do //Estrutura de repetição Do while (Faça enquanto), irá executar se o arquivo dentro de item se for direfente de nulo.
                {
                    item = leitor.ReadLine(); //Item recebe o leitor que é o tipo var(maneira implícita ou indireta de definir os dados),
                                              //que dentro do leitor tem o arquivo linhas

                    Console.WriteLine(item); //Se tudo estiver correto será printado na tela.
                } while (item != null); //O que está dentro do do while só irá executar se o arquivo for dirente de nulo.
            }
        }
    }
}