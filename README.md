# programConsoleBank
Aplicação do tipo Console usando a versão .NET 6.0 e linguagem de programação C#, aplicando os conceitos de orientação a objetos, herança, interface e exceção personalizada.

<img src="https://img.shields.io/static/v1?label=dotnet&message=framework&color=blue&style=for-the-badge&logo=DOTNET"/>

### Status do Projeto: ✔️ (concluido)

## Descrição
Aplicação do tipo Console usando a versão .NET 6.0 e linguagem de programação C#, aplicando os conceitos de orientação a objetos, herança, implementação de interfaces, 
abstração de classes e encapsulamento. Com a aplicação é possível instanciar Contas e Titulares da Conta, instanciar Funcionarios e seus tipos (herdeiros) sendo que a classe funcionário
é abstrata portanto cada tipo consegue usar sua própria regra para receber bonificação e aumento de salário. Para a bonificação foi necessário ter uma classe Util que gerenciador de Bonificação.
Na aplicação, somente os funcionários do tipo Diretor e Gerente da Conta podem realizar autenticação no sistema, portanto existe a implementação de interface utilizando
uma nova classe responsável por ser herdeira da classe pai funcionário e ao mesmo tempo ter o contrato com a interface IAutenticavel, pois uma classe não pode ter múltiplas heranças. Também existe o tratamento de exceções com uma classe representando exceção personalizada, tratando inclusive a manipulação de um arquivo.

## Objetivo do Projeto
O projeto tem como objetivo reforçar conceitos fundamentas de qualquer linguagem de programação, em especial C# com .NET (que faz parte da minha rotina e pode fazer
parte da rotina de muitas pessoas), portanto reforçando conceitos e aplicando de maneira básica é possível escalar o conhecimento e o aprendizado de novas ferramentas.
Espero que o projeto possa ajudar pessoas com as mais diversas dificuldades, principalmente no paradigma de programar orientado a objetos.


✔️ Técnicas e tecnologias utilizadas
- ``.NET 6.0``
- ``Application Console``
- ``Orientação a Objetos`` 
- ``Herança``
- ``Abstração de Classes``
- ``Implementação de Interfaces``


# :hammer: Funcionalidades do projeto

- `Funcionalidade 1`: instância de tipos de funcionarios que herdam a classe abstrata Funcionario
- `Funcionalidade 2`: instância do objeto pessoa titular da conta, a partir da classe Conta
- `Funcionalidade 3`: bonificação dos funcionários (utilizando gerenciador de bonificação como um Util)
- `Funcionalidade 4`: aumento de salário dos funcionários
- `Funcionalidade 5`: autenticação de senha, com validação e uso de interface (somente funcionários do tipo diretor, gerente de conta e parceiro comercial podem autenticar)
- `Funcionalidade 6`: Tratamendo de exceção para abrir conta, para sacar e para manipular um arquivo. Foi criado exceção personalizada.




