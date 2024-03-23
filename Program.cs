<<<<<<< HEAD
﻿/*  Instituto Federal de Educação, Ciência e Tecnologia de Rondônia- IFRO
 *  C.S.T. em Análise e Desenvolvimento de Sistemas
 *  Disciplina de Algoritmo e Lógica de Programação II
 *  Professor e Clayton Ferraz de Andrade
 *  
 *  Acadêmico Vinicius de Oliveira Pinheiro
 *  Aula do dia 21-08-2023
 *  - Vetores multidimensionais
 */
/*  
        
    -> X clientes;
    -> cada cliente compra 'x' produtos;
    -> cada produto possui 'x' valores e 'x' quantidade;
*/

string[] clientName;
int[] productAmount;
double[][] productPrice;
// também pode já deixar instanciada; ex.:
// double [][] productPrice = new double [x][]
string[][] productName;

Console.WriteLine("Quantos clientes deseja cadastrar?");
int amount = Convert.ToInt32(Console.ReadLine());

clientName = new string[amount];
productAmount = new int[amount];
productPrice = new double[amount][];
productName = new string[amount][];

for(int i = 0; i < amount; i++)

{
    Console.Write("Digite o nome do cliente: ");
    clientName[i] = Console.ReadLine()!;
    Console.Write("Digite quantos produtos esse cliente quer comprar: ");
    productAmount[i] = Convert.ToInt32(Console.ReadLine());
    productPrice[i] = new double[productAmount[i]];
    productName[i] = new string[productAmount[i]];
    for (int j = 0; j < productAmount[i]; j++) 
    // 'i' para os clientes, e 'j' para percorrer os produtos;
    // o 'i' é como se fosse a coluna 
    {
        Console.WriteLine("Digite o nome do Produto do Cliente" + clientName[i]);
        productPrice[i][j] = Convert.ToInt32(Console.ReadLine());
        // para cada vez do 'i', faz-se 'n' vezes do 'j';
    }
}

=======
﻿/*  Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 *  C.S.T. em Análise e Desenvolvimento de Sistemas
 *  Disciplina de Algoritmo e Lógica de Programação II
 *  Professor Clayton Ferraz de Andrade
 * 
 *  Acadêmico Vinícius de Oliveira Pinheiro
 *  Aula do dia 14-08-2023 
 *  - Introdução de Arrays / Vetores
*/

#region Brief Explanation
/* 
-> Array: uma variável que suporta múltiplos valores;
-> Vetores: são um tipo de array;

declarando uma variável comum:
    string variable;
declarando uma variável vetor:
    string[] newVariable;
criando um vetor e inserindo valores inicias
    string[] gakuseiNoNamae = { "Toru", "Akio", "Yoko", "Sora" };
criando um vetor e determinando a extensão dele
    string[] nomDeLeleve = new string[10];
comprimento da variável; o  usuário vai escolher a extensão do array;
    int cumprimento[10]; 
*/ #endregion


Console.Write("\n\n\n\n    Você quer saber a nota de quantos alunos? ");
int length = Convert.ToInt32(Console.ReadLine());

string[] studentName = new string[length];
double[] firstGrade = new double[length];
double[] secondGrade = new double[length];
double[] average = new double[length];


for (int i = 0; i < studentName.Length; i++)
{
    Console.Clear();
    Console.Write($"\n\n\n\n    Digite o nome do {i + 1}º aluno: ");
    studentName[i] = Console.ReadLine()!;
    Console.Write($"    Digite a 1ª nota de {studentName[i]}: ");
    firstGrade[i] = Convert.ToDouble(Console.ReadLine());
    Console.Write($"    Digite a 2ª nota de {studentName[i]}: ");
    secondGrade[i] = Convert.ToDouble(Console.ReadLine());
    average[i] = (firstGrade[i] + secondGrade[i]) / 2;
}
Console.Clear();
for (int i = 0; i < studentName.Length; i++)
{
    Console.Write("\n\n\n\n    Calculando notas");
    for (int j = 0; j < 10; j++)
    {
        System.Threading.Thread.Sleep(100);
        Console.Write(".");
    }
    Console.Clear();
    Console.WriteLine("\n    --------------------------------");
    Console.WriteLine("    As nota dos aluno " + studentName[i] + " são: ");
    Console.WriteLine("    A 1ª nota do aluno: " + firstGrade[i] + ".");
    Console.WriteLine("    A 2ª nota do aluno: " + secondGrade[i] + ".");
    Console.WriteLine("    A média deste aluno é: " + average[i] + ".");
    if (average[i] >= 60)
    {
        Console.Write("\n    Este aluno está "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("aprovado!"); Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        Console.Write("\n    Este aluno está "); Console.ForegroundColor = ConsoleColor.Red; Console.Write("reprovado!"); Console.ForegroundColor = ConsoleColor.White;
    }
    Console.WriteLine("\n    --------------------------------");
}
>>>>>>> 845d215fcd697a775b3412c1ebdf2a1681445de0
