using bytebank;
using bytebank.Contas;
using bytebank.Titular;
using Cliente = bytebank.Titular.Cliente;

//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André " + contaDoAndre.saldo);



//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-x";
//contaDoAndre.saldo = 100;

//Console.WriteLine("Saldo da conta do André " + contaDoAndre.saldo);

//contaDoAndre = contaDoAndre2;

//Console.WriteLine(contaDoAndre==contaDoAndre2);

//ContaCorrente contaDaMaria = new ContaCorrente();

//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da maria " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do ANdré = " + contaDoAndre.saldo);
//Console.WriteLine("Conta da Maria " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular = "Pedro");
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);


//TIPAGEM POR VALOR
//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//tipagem por referencia


//Cliente cliente = new Cliente();
//cliente.nome = "andré silva";
//cliente.cpf = "123456789";
//cliente.profissao = "analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " +conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissao = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("Nº Agencia = " + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Testes";
//conta2.titular.cpf = "111111111";
//conta2.numero_agencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 12;
//conta3.Conta = "1011=H";
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);


//ContaCorrente conta4 = new ContaCorrente(18, "1010-x");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
////Console.WriteLine( conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-x");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "8888-z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(284, "83488-z");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);




