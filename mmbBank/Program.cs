using mmbBank.Contas;
using mmbBank.Funcionarios;
using mmbBank.ParceriaComercial;
using mmbBank.Pessoa;
using mmbBank.SistemaInterno;
using mmbBank.Util;

#region conta corrente
//ContaCorrente conta = new ContaCorrente();
//conta.numero_agencia = 0001;
//conta.conta = "AG01";
//conta.titular = "Babi";
//conta.saldo = 100;

//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.numero_agencia}");

////conta.Depositar(100);

//Console.WriteLine($"Saldo em R$ após depositar {String.Format("{0:0.00}", conta.saldo)}");

////if(conta.Sacar(300) == true)
////{
////    Console.WriteLine($"Saldo em R$ após sacar {String.Format("{0:0.00}", conta.saldo)}");
////}
////else
////{
////    Console.WriteLine("Não fez o processo de saque. Saldo insuficiente");
////}


//ContaCorrente contaDestino = new ContaCorrente();
//contaDestino.numero_agencia = 0001;
//contaDestino.conta = "AG02";
//contaDestino.titular = "Gaia";
//contaDestino.saldo = 150;

//conta.Transferir(70, contaDestino);
//Console.WriteLine("Saldo da conta 1: " + conta.saldo);
//Console.WriteLine("Saldo da conta 2: " + contaDestino.saldo);

//Console.ReadKey();

//quando comparar (==) dois objetos se são iguais, vai retornar false
//    pois o endereçamento na memória é diferente, de dois objetos instanciados
//já é diferente se atribuir uma conta a outra (conta1=conta2) ai sim vai retornar true

//PessoaTitular cliente = new PessoaTitular();
//cliente.pessoaNome = "teste";
//cliente.pessoaCpf = "00000";
//cliente.pessoaProfissao = "analista";

//ContaCorrente contaPessoa = new ContaCorrente(283, "aaa", cliente);

//Console.WriteLine("teste static incremento: " + ContaCorrente.TotalDeContasCriadas);

//ContaCorrente contaPessoa2 = new ContaCorrente(284, "aaa", cliente);
//Console.WriteLine("teste static incremento: " + ContaCorrente.TotalDeContasCriadas);
#endregion conta corrente

#region funcionario salario
//Funcionario funcUm = new Funcionario("475546745", 5900);
//funcUm.Nome = "um";


//Diretor dirUm = new Diretor("4444");
//dirUm.Nome = "teste dir um";


//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(funcUm);
//gerenciador.Registrar(dirUm);


//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

//Console.WriteLine("Total de funcionarios: " + Funcionario.TotalDeFuncionarios);


//dirUm.AumentarSalario();
//Console.WriteLine("novo salario diretor: " + dirUm.Salario);
#endregion funcionario salario

//CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ferinha = new Designer("626262");
    ferinha.Nome = "ferinha do designer";

    Diretor diretoria = new Diretor("1111");
    diretoria.Nome = "diretoria braba";

    Auxiliar aux = new Auxiliar("2222");
    aux.Nome = "auxiliando";

    GerenteDaConta gerente = new GerenteDaConta("777");
    gerente.Nome = "gerenciando";

    gerenciador.Registrar(ferinha);
    gerenciador.Registrar(diretoria);
    gerenciador.Registrar(aux);
    gerenciador.Registrar(gerente);

    Console.WriteLine("total de bonificação: " + gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor brabo = new Diretor("823483");
    brabo.Nome = "nome diretor";
    brabo.Senha = "123456";

    GerenteDaConta gerente = new GerenteDaConta("283454");
    gerente.Nome = "nome gerente";
    gerente.Senha = "890761";

    sistema.Logar(brabo, "84754");
    sistema.Logar(gerente, "890761");

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "1234";
    sistema.Logar(parceiro, "1234");
}