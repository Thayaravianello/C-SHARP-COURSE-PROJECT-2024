﻿using Projeto15;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Uml
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p1 = new Produto(); //LEMBRE-SE QUE AQUI SE COLOCA O NOME DA CLASSE, O NOME QUE DESEJA = NEW E NOME DA CLASSE();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.WriteLine("Digite o nome do produto: ");
            p1.Nome= Console.ReadLine(); // AQUI CHAMAMOS A VARIAVEL CRIADA ACIMA MAIS O TIPO CRIADO EM CLASSE = READ LINE PARA ARMAZENAR

            Console.WriteLine("Digite o preço do produto :");
            p1.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;

            Console.WriteLine("Digite a quantidade de produtos em estoque: ");
            p1.Quantidade = int.Parse(Console.ReadLine());// LEMBRE-SE QUE PARA INTEIROS OU FLOAT COMO DOUBLE TEMOS QUE TRANSFORMAR O READLINE

            //VALOR TOTAL EM ESTOQUE. QUANTIDADE * PREÇO

            Console.WriteLine();

            Console.WriteLine( "Os dados do produto são: " + p1 ); // USANDO TO STRING E OBJETO 

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()) ;

            Console.WriteLine() ;

            p1.AdicionarProdutos(qte); // AQUI FIZEMOS A CHAMADO DO P1 QUE FOI CRIADO AQUI PARA CHAMAR A CLASSE PRODUTO. MAIS O ADICONAR PRODUTO + O PRODUTO A MAIS ADD QTE
            Console.WriteLine("Dados atualizados :" + p1);

            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());

            p1.RemoverProdutos(remover); // AQUI FIZEMOS A CHAMADO DO P1 QUE FOI CRIADO AQUI PARA CHAMAR A CLASSE PRODUTO. MAIS O ADICONAR PRODUTO + O PRODUTO A MAIS ADD QTE
            Console.WriteLine("Dados atualizados :" + p1);

        }

    }
}