# Simulador de Sistema Bancário - ByteBank

Este repositório contém o código-fonte de um simulador de sistema bancário desenvolvido em **C#** durante as aulas da **Alura**. O projeto foi dividido em diferentes módulos e diretórios que encapsulam funcionalidades como gerenciamento de contas, autenticação, comparadores e manipulação de streams.

## 🏦 Estrutura do Repositório

### 📂 ByteBank.Modelos

Esta pasta contém as principais classes que modelam as entidades e comportamentos do sistema bancário. Algumas das classes e interfaces presentes são:

- **Cliente**: Representa os dados de um cliente do banco.
- **ContaCorrente**: Responsável pelas operações bancárias das contas correntes.
- **GerenciadorBonificacao**: Gerencia o sistema de bonificações para os funcionários.
- **ParceiroComercial**: Modela parceiros comerciais do banco.
- **AutenticacaoHelper**: Classe auxiliar para gerenciamento de autenticação.
- **Funcionario**: Classe base para os funcionários do banco.
- **Auxiliar**, **Desenvolvedor**, **Designer**, **GerenteDeConta**, **FuncionarioAutenticavel**: Classes derivadas que herdam de **Funcionario**, representando diferentes tipos de funcionários.
- **IAutenticavel**: Interface para implementação de autenticação.
- **OperacaoFinanceiraException**, **SaldoInsuficienteException**: Exceções customizadas para tratar erros de operações financeiras.

### 📂 ByteBank.SistemaAgencia

Nesta pasta, o foco foi trabalhar com:
- **Comparadores**: Implementação de comparações customizadas para ordenação de listas.
- **Extensões**: Métodos de extensão aplicados a tipos do sistema.
- **Listas**: Manipulação de coleções e listas de dados bancários.

### 📂 ByteBank.SistemaInterno

Este diretório contém o sistema de execução do banco, incluindo os **executáveis** e **dlls** necessários para rodar a aplicação internamente.

### 📂 ByteBankImportacaoExportacao

Este módulo foi utilizado para **testes com streams**, como importação e exportação de dados, leitura e escrita em arquivos, e manipulação de streams de dados.

### 📂 ByteBank2 e ByteBank3

Esses diretórios contêm **arquivos atualizados** do sistema, com melhorias e novas funcionalidades implementadas ao longo do desenvolvimento.
   
## 📚 Aprendizados

Durante o desenvolvimento deste projeto, foram abordados conceitos e práticas importantes, como:
- **Modelagem de classes e entidades** no contexto bancário.
- **Autenticação e autorização** de usuários e funcionários.
- Manipulação de **exceções customizadas**.
- **Streams** para importação/exportação de dados.
- Trabalho com **listas**, **comparadores** e **métodos de extensão**.

---

Sinta-se à vontade para explorar o código, sugerir melhorias ou discutir sobre sistemas bancários com C#!

---

[![LinkedIn](https://img.shields.io/badge/-LinkedIn-blue?style=flat&logo=Linkedin&logoColor=white)](https://github.com/ThalesOliveira100)
[![Email](https://img.shields.io/badge/-Email-c14438?style=flat&logo=Gmail&logoColor=white)](mailto:toliveiradev@outlook.com)
