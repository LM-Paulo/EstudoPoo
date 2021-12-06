ContaCorrente contaPaulo = new ContaCorrente();

contaPaulo.titular = "paulo";
contaPaulo.saldo = 500;
Console.WriteLine("saldo antes do saque: " + contaPaulo.saldo);
contaPaulo.Sacar (50);


Console.WriteLine ("saldo depois do saque: " + contaPaulo.saldo);

Console.WriteLine("---------------------------------------------------------");

contaPaulo.Depositar (1000);
Console.WriteLine("valor depois do deposito: " + contaPaulo.saldo);


Console.WriteLine("-----------------------------------------------------------");

ContaCorrente contaAgiota = new ContaCorrente();

contaAgiota.titular = "Roberto";
Console.WriteLine("O saldo do agiota é: " + contaAgiota.saldo);
contaPaulo.Transferir (450,contaAgiota);

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("o saldo do paulo é: " + contaPaulo.saldo);

Console.WriteLine("o saldo do Agiota é: " + contaAgiota.saldo);








Console.ReadLine ();


