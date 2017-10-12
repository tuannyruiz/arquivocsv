using System;
using System.IO;

namespace arquivocsv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, email;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu e-mail: ");
            email = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            idade = Int16.Parse(Console.ReadLine());
            
            FileInfo fi = new FileInfo("dados_cabecalho.csv");
            StreamWriter arquivo;

            //Se o arquivo já existir, apenas adicione a nova linha no arquivo
            if(fi.Exists)
            {
                // O 'true' serve para as novas informações serem adicionadas e não sobrescreverem o documento.
                arquivo = new StreamWriter("dados_cabecalho.csv", true);
                arquivo.WriteLine(nome + ";" + email + ";" + idade + ";" + DateTime.Now.ToShortDateString());
            } 
            //Se o arquivo não existe ainda, adicione um cabeçalho e então, adicione a linha com as informações
            else 
            {                
                arquivo = new StreamWriter("dados_cabecalho.csv", true);
                arquivo.WriteLine("Nome" + ";" + "E-mail" + ";" + "Idade" + ";" + "Data de Cadastro");
                arquivo.WriteLine(nome + ";" + email + ";" + idade + ";" + DateTime.Now.ToShortDateString());
            }

            arquivo.Close();
        }
    }
}
