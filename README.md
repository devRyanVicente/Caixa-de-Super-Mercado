# Programa de Super-Mercado com Windows Forms
# Oque o Programa faz?
ele é praticamente um CRUD, porem com funções para caixas de super-mercado

no programa temos 2 principais areas, Caixista é o Admin.

 no Admin você pode:
- Criar Novos Funcionarios (Criar/Editar/Remover)
- Criar Novos Produtos (Criar/Editar/Remover)
- Ver Os Recibos existentes (Editar/Remover)

no Caixa você pode:
 - Adicionar os Produtos a uma Lista, logo depois enviar o Recibo
 - Criar Novos Recibos


**Tenha em Mente que o Front-END não é meu forte.**

# oque é necessario para executar o programa?

**XAMPP
MySQL Connector
**

# Comandos para criar o SQL
Criando o SQL (ponha o nome da Database de "central"):
~~~~
CREATE TABLE Produtos (
    UniqueID INT PRIMARY KEY,
    IDProdutos INT,
    NomeProduto VARCHAR(255),
    CategoriaProduto VARCHAR(32),
    ValorProduto decimal(20,2),
    DataCriadoProduto DATETIME
);
~~~~


~~~~
CREATE TABLE Recibos (
    UniqueID INT PRIMARY KEY,
    ValorVendaTotal decimal(20,2),
    IDFuncionarioRecibo INT,
    DataCriadoRecibo DATETIME,
    DataUtilizadoRecibo DATETIME
);
~~~~


~~~~
CREATE TABLE Funcionarios (
    UniqueID INT PRIMARY KEY,
    IDFuncionario INT NOT NULL,
    NomeFuncionario VARCHAR(255) NOT NULL,
    SenhaFuncionario VARCHAR(32) NOT NULL,
    CargoFuncionario VARCHAR(32),
    DataUltimoLogin DATETIME,
    DataFuncionarioCriado DATETIME
);
~~~~


~~~~
CREATE TABLE CategoriaProdutos (
    UniqueID INT PRIMARY KEY,
    CategoriaProdutos VARCHAR(64) NOT NULL,
    DataCategoriaCriada DATETIME
);
~~~~
