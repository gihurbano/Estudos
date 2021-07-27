using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente();
            gabriela.nome = "Gabriela";
            gabriela.profissao = "Desenvolvedora";
            gabriela.cpf = "4564654.454.64.6";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = gabriela;
            conta.saldo = 500;
            conta.numero = 12312;
            conta.agencia = 45454;

            Console.WriteLine("Titular: " + gabriela.nome);
            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();


            /*
                        ContaCorrente contaDoBruno = new ContaCorrente();
                        contaDoBruno.titular = "Bruno";
                        bool resultadoDoSaque = contaDoBruno.Sacar(50);

                        Console.WriteLine("O saldo do bruno é: " + resultadoDoSaque);
                        contaDoBruno.Depositar(500);
                        Console.WriteLine("Saldo novo: " + contaDoBruno.saldo);

                        ContaCorrente contaGabriela = new ContaCorrente();
                        contaGabriela.titular = "Gabriela";
                        contaDoBruno.Transferir(200, contaGabriela);
                        Console.WriteLine("Saldo do bruno : " + contaDoBruno.saldo);
                        Console.WriteLine("saldo da gabriela: " + contaGabriela.saldo);



                        Console.ReadLine();



                        ContaCorrente contaGisele = new ContaCorrente();
                        contaGisele.titular = "Gisele";
                        contaGisele.agencia = 0233;
                        contaGisele.numero = 05696;
                        contaGisele.saldo = 37.566;




                        Console.WriteLine("Titular: "+ contaGisele.titular);
                        Console.WriteLine("Agência: " + contaGisele.agencia);
                        Console.WriteLine("Número: " + contaGisele.numero);
                        Console.WriteLine("Saldo :" + contaGisele.saldo);

                        contaGisele.saldo += 2000;
                        Console.ReadLine();
                     */
        }
    }
}
