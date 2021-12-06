class Conta
{
    static void Main(string[] args)
    {
       ContaCorrente conta1 = new ContaCorrente();

        conta1.titular = "paulo";
        conta1.agencia = 123;
        conta1.numero = 456;
        conta1.saldo = 500;
        
        Console.WriteLine("saldo: " + conta1.saldo);    

        Console.WriteLine("agencia: " + conta1.agencia);

        Console.WriteLine("numero: " + conta1.numero);

        Console.WriteLine("titular: " + conta1.titular);

        conta1.saldo += 200;
        Console.WriteLine(conta1.saldo);

    }
}
