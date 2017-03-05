using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_LeituraArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 1
            Console.WriteLine("EXERCÍCIO 1");
            Console.ReadKey();
            Console.WriteLine();

            TextReader reader = new StreamReader("nomes_telefones.txt");
            //TextReader tr = new StreamReader(@"C:\Users\...\Desktop\Test.txt"); 
            String linha = reader.ReadLine();
            while (linha != null)
            {
                var pos = linha.IndexOf('(');
                var linhaNova = linha.Substring(pos+1);
                linhaNova = linhaNova.Replace(")","").Replace("-", "");
                Console.WriteLine(linhaNova);
                linha = reader.ReadLine();
            }

            Console.ReadKey();

            //EXERCÍCIO 2
            Console.Clear();
            Console.WriteLine("EXERCÍCIO 2");
            Console.ReadKey();
            Console.WriteLine();

            reader = null;
            reader = new StreamReader("nomes_telefones.txt");
            linha = null;
            linha = reader.ReadLine();
            while (linha != null)
            {
                var pos = linha.IndexOf('(');
                var nome = linha.Substring(0, pos - 1);
                if(nome.Length > 12)
                {
                    nome = nome.ToUpper();
                    Console.WriteLine(nome);
                }
                linha = reader.ReadLine();
            }

            Console.ReadKey();

            //EXERCÍCIO 3
            Console.Clear();
            Console.WriteLine("EXERCÍCIO 3");
            Console.ReadKey();
            Console.WriteLine();

            reader = null;
            reader = new StreamReader("datas.txt");
            linha = null;
            linha = reader.ReadLine();
            while (linha != null)
            {
                var data = DateTime.Parse(linha);
                var ano = data.Year;
                Console.WriteLine(ano);
                linha = reader.ReadLine();
            }

            Console.ReadKey();

            //EXERCÍCIO 4
            Console.Clear();
            Console.WriteLine("EXERCÍCIO 4");
            Console.ReadKey();
            Console.WriteLine();

            reader = null;
            reader = new StreamReader("marcas_carros.txt");
            linha = null;
            linha = reader.ReadLine();
            while (linha != null)
            {
                linha = linha.Trim();
                var pos = linha.IndexOf('@');
                var marca = linha.Substring(0, pos);
                Console.WriteLine(marca);
                linha = reader.ReadLine();
            }

            Console.ReadKey();

            //EXERCÍCIO 5
            Console.Clear();
            Console.WriteLine("EXERCÍCIO 5");
            Console.ReadKey();
            Console.WriteLine();

            reader = null;
            reader = new StreamReader("produtos_estoque.txt");
            linha = null;
            linha = reader.ReadLine();
            while (linha != null)
            {
                linha = linha.Trim();
                var pos = linha.IndexOf('$');
                var pos2 = linha.IndexOf('|');
                var produto = linha.Substring(0, pos);
                var vlunitario = linha.Substring(pos+1, (pos2-pos)-1);
                var qtdestoque = linha.Substring(pos2+1);
                CultureInfo USACulture = new CultureInfo("en-US");
                var vltotal = string.Format(USACulture, "{0:C}", (decimal.Parse(qtdestoque) * decimal.Parse(vlunitario)));
                Console.WriteLine(produto + " " + qtdestoque + "\t" + vltotal);
                linha = reader.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
