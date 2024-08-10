using System;

namespace Projeto
{
    class Program{
        static void Main(string[] args) {
            float val_pag;
            Console.WriteLine("Nome:");
            string var_name = Console.ReadLine();
            Console.WriteLine("End.:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("P(F) ou P(J):");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f"){
                PessoaFisica pf = new PessoaFisica(); 
                pf.nome = var_name;
                pf.endereco = var_endereco;
                Console.WriteLine("CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Valor:");
                val_pag = float.Parse(Console.ReadLine());
                Console.WriteLine("PF");
                Console.WriteLine("Nome:" + pf.nome);
                Console.WriteLine("Endereco" + pf.endereco);
                Console.WriteLine("CPF" + pf.cpf);
                Console.WriteLine("RG" + pf.rg);
                Console.WriteLine("Valor" +pf.valor.ToString("C"));
                Console.WriteLine("Imposto" +pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total" +pf.total.ToString("C"));
            }if(var_tipo == "j"){
                PessoaJuridica pj = new PessoaJuridica(); 
                pj.nome = var_name;
                pj.endereco = var_endereco;
                Console.WriteLine("CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Valor:");
                val_pag = float.Parse(Console.ReadLine());
                Console.WriteLine("PJ");
                Console.WriteLine("Nome:" + pj.nome);
                Console.WriteLine("Endereco" + pj.endereco);
                Console.WriteLine("CNPJ" + pj.cnpj);
                Console.WriteLine("IE" + pj.ie);
                Console.WriteLine("Valor" +pj.valor.ToString("C"));
                Console.WriteLine("Imposto" +pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total" +pj.total.ToString("C"));
            }
        }
    }
}