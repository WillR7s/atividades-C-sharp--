// // Exercício 1 - Crie um programa que solicite algumas 
// // informações pessoais e apresente um resumo na tela.

// Console.WriteLine("SEJA BEM VINDO(A)");
// Console.WriteLine("DIGITE SEU NOME:");
// string? nome = Console.ReadLine();
// Console.WriteLine("DIGITE SUA IDADE:");
// string? idade = Console.ReadLine();
// Console.WriteLine("DIGITE SUA CIDADE:");
// string? cidade = Console.ReadLine();

// Console.WriteLine("=====================================");
// Console.WriteLine("RESUMO DAS INFORMAÇÕES:");
// Console.WriteLine($"NOME: {nome}");
// Console.WriteLine($"IDADE: {idade}");
// Console.WriteLine($"CIDADE: {cidade}");


//EXERCÍCIO 2 - Uma papelaria deseja calcular o valor de uma compra.

// Console.WriteLine("DIGITE O NOME DO PRODUTO: ");
// string? nomeProduto = Console.ReadLine();
// Console.WriteLine("DIGITE A QUANTIDADE DE PRODUTOS: ");
// int quantidade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("DIGITE O PREÇO UNITÁRIO: ");
// decimal precoUnitario = Convert.ToDecimal(Console.ReadLine());

// decimal valorTotal = quantidade * precoUnitario;
// Console.WriteLine($"VALOR TOTAL DA COMPRA: R$ {valorTotal}");

//EXERCÍCIO 3 - Crie um programa que receba
//  o nome de um aluno e sua nota, de 0 a 10.

// Console.WriteLine("DIGITE O NOME DO ALUNO: ");
// string? nomeAluno = Console.ReadLine();
// Console.WriteLine("DIGITE A NOTA DO ALUNO (0 a 10): ");
// decimal notaAluno = Convert.ToDecimal(Console.ReadLine());

// if (notaAluno >= 7)
// {
//     Console.WriteLine($"ALUNO: {nomeAluno} - APROVADO");

// }

// else if (notaAluno >= 5)
// {
//     Console.WriteLine($"ALUNO: {nomeAluno} - RECUPERAÇÃO");
// }
// else
// {
//     Console.WriteLine($"ALUNO: {nomeAluno} - REPROVADO");
// }

//Exercício 4 - Crie um programa que solicite um número 
// inteiro e exiba sua tabuada de 1 a 10.

// Console.WriteLine("DIGITE UM NÚMERO DE 1 A 10");
// string? valor =Console.ReadLine();
// double numero= Convert.ToDouble(valor);
// //int numero = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++)
// {
//     double resultado = numero * i;
//     Console.WriteLine($"{numero} x {i} = {resultado}");
// }

//Exercício 5 - Crie um programa no qual 
// o usuário deverá descobrir um número secreto 
// definido previamente no código.

// Console.WriteLine("TENTE ADIVINHAR O NÚMERO SECRETO:");
// const int numeroSecreto = 70;   
// int tentativas = 0;
// bool acertou = false;


// while (!acertou)
// {
//     Console.WriteLine("DIGITE UM NÚMERO:");
//     string? valor= Console.ReadLine();
//     int palpite = Convert.ToInt32(valor);
//     tentativas++;

//     if (palpite == numeroSecreto)
//     {
//         acertou = true;
//         Console.WriteLine($"PARABÉNS! VOCÊ ACERTOU O NÚMERO SECRETO EM {tentativas} TENTATIVAS.");
//     }
//     else if (palpite < numeroSecreto)
//     {
//         Console.WriteLine("O NÚMERO SECRETO É MAIOR. TENTE NOVAMENTE.");

//     }
//     else
//     {
//         Console.WriteLine("O NÚMERO SECRETO É MENOR. TENTE NOVAMENTE.");
//     }
// }


// Exercício 6 - Crie um programa que realize operações
//  matemáticas utilizando métodos próprios.

// using System.Diagnostics;

// Console.WriteLine("""
// 1- Somar
// 2-Multiplicar
// """);

// Console.Write("Digite uma opção: ");
// int opcao = int.Parse(Console.ReadLine()!);

// switch(opcao)
// {
    
// case 1: 
// Console.Clear();
// Console.WriteLine("A opção somar foi selecionada");
// Console.WriteLine ("Digite o primeiro numero:");
// string? Valor1 = Console.ReadLine();
// int Soma1 = int.Parse(Valor1!);
// Console.WriteLine ("Digite o segundo numero:");
// string? Valor2 = Console.ReadLine();
// int Soma2 = int.Parse(Valor2!);
// decimal Soma = Soma1 + Soma2;
// Console.WriteLine ($"O Resultado é {Soma}");
// break;

// case 2:
// Console.Clear();
// Console.WriteLine("A opção Multiplicar foi selecionada");
// Console.WriteLine ("Digite o primeiro numero:");
// string? Valor3 = Console.ReadLine();
// int Multi1 = int.Parse(Valor3!);
// Console.WriteLine ("Digite o segundo numero:");
// string? Valor4 = Console.ReadLine();
// int Multi2 = int.Parse(Valor4!);

// decimal multiplicacao = Multi1 * Multi2;

// Console.WriteLine ($"O Resultado é {multiplicacao}");
// break;
// }

//Exercício 7- Crie um programa que armazene 3 notas de um aluno em um array.




// Console.WriteLine("Digite a primeira nota:");
// string? valor1 = Console.ReadLine();
// decimal Nota1 = decimal.Parse(valor1!);

// Console.WriteLine("Digite a segunda nota:");
// string? valor2 = Console.ReadLine();
// decimal Nota2 = decimal.Parse(valor2!);

// Console.WriteLine("Digite a terceira nota:");
// string? valor3 = Console.ReadLine();
// decimal Nota3 = decimal.Parse(valor3!);



// decimal[] Notas = {Nota1, Nota2, Nota3};
// decimal Media = ((Nota1 + Nota2 + Nota3)/3);

// for (int i = 0; i < Notas.Length; i++)
// {
//   Console.WriteLine(Notas[i]);
// }

// decimal somaNotas = 0;

// foreach (decimal nota in Notas)
// {
//     somaNotas += nota; 
    
// }

// decimal mediaCalculada = somaNotas / Notas.Length;

// Console.WriteLine($"Média: {mediaCalculada:F2}");



//Exercício 8 -Crie um programa que receba cinco números inteiros
//  e armazene-os em um array.

// Console.WriteLine("Digite Cinco Numeros Inteiros para armazena-los.");
// Console.WriteLine("Digite o Primeiro Numero:");
// string? Valor1 = Console.ReadLine();
// int Numero1 = int.Parse(Valor1!);

// Console.WriteLine("Digite o Segundo Numero:");
// string? Valor2 = Console.ReadLine();
// int Numero2 = int.Parse(Valor2!);

// Console.WriteLine("Digite o Terceiro Numero:");
// string? Valor3 = Console.ReadLine();
// int Numero3 = int.Parse(Valor3!);

// Console.WriteLine("Digite o Quarto Numero:");
// string? Valor4 = Console.ReadLine();
// int Numero4 = int.Parse(Valor4!);

// Console.WriteLine("Digite o Quinto Numero:");
// string? Valor5 = Console.ReadLine();
// int Numero5 = int.Parse(Valor5!);

// int[] Numeros = {Numero1,Numero2,Numero3,Numero4,Numero5};

// // Exibindo todos os números digitados
// Console.WriteLine("\nNumeros digitados:");
// foreach (var n in Numeros)
// {
//     Console.WriteLine(n);
// }

// // Contagem de pares e identificação do maior número
// int pares = 0;
// int maiorNumero = Numeros[0];

// foreach (var n in Numeros)
// {
//     // Verifica cada número individualmente dentro do loop
//     if (n % 2 == 0)
//     {
//         pares++;
//     }

//     if (n > maiorNumero)
//     {
//         maiorNumero = n;
//     }
// }

// // Exibição dos resultados finais fora do loop
// if (pares > 0)
// {
//     Console.WriteLine($"Quantidade de numeros pares: {pares}");
// }
// else
// {
//     Console.WriteLine("\nNenhum Numero par foi encontrado.");
// }

// Console.WriteLine($"Maior numero informado: {maiorNumero}");

//Exercício 9 - Crie um programa que permita cadastrar nomes de produtos em uma lista
//utilizando List<string> .

List<string> produtos = new List<string>();

//CADASTRANDO PRODUTOS

Console.WriteLine("Digite o nome do Produto:");
string? Produto1 = Console.ReadLine();
produtos.Add(Produto1!);
Console.WriteLine($"Produto {Produto1} Cadastrado");

Console.WriteLine("Digite o nome do Produto:");
string? Produto2 = Console.ReadLine();
produtos.Add(Produto2!);
Console.WriteLine($"Produto {Produto2} Cadastrado");

Console.WriteLine("Digite o nome do Produto:");
string? Produto3 = Console.ReadLine();
produtos.Add(Produto3!);
Console.WriteLine($"Produto {Produto3} Cadastrado");

Console.WriteLine("Produtos Cadastrados:");
foreach (string item in produtos)
   {
                  
  Console.WriteLine($"- {item}");
   }
            
// ENCONTRANDO PRODUTOS
Console.WriteLine("Digite o Nome Do Produto Que Deseja Buscar:");
string? busca = Console.ReadLine();

if (produtos.Contains(busca!))
{
Console.WriteLine ($"Produto {busca} Encontrado.");
}
else
{
  Console.WriteLine ($"Produto {busca} Não Encontrado.");
}

//Excluindo produtos

Console.WriteLine("Digite o nome do produto que deseja excluir:");

