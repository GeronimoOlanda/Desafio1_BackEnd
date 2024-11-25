# GerenciadorTarefas.API

Bem-vindo ao repositório **GerenciadorTarefas.API**! Este é o backend de um sistema para gerenciamento de tarefas, desenvolvido em .NET Core 6.

---

## 🚀 **Configurações para Iniciar o Projeto**

### 1. **Configurar a String de Conexão**
- Abra o arquivo `appsettings.json` na raiz do projeto.
- Localize a seção `ConnectionStrings` e configure a chave `DefaultConnection` com a string de conexão local. Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=GERONIMO-OLANDA\\SQLEXPRESS;Database=gerenciamentoTarefas;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
### 2. Criar o Banco de Dados
No SQL Server, execute a seguinte query para criar o banco de dados
```json
"CREATE DATABASE" gerenciamentoTarefas;
```

📂 Estrutura do Projeto
Controllers: Controladores para gerenciar as requisições HTTP.
Models: Modelos das entidades e DTOs.
Services: Serviços que encapsulam regras de negócio.
Repositories: Classes para acesso ao banco de dados.
Configurations: Configurações como injeção de dependências e mapeamentos.

💡 Próximos Passos
Execute as migrations (caso estejam habilitadas) para criar as tabelas no banco de dados.
Configure o Swagger (caso habilitado) para testar as APIs diretamente pelo navegador.
🔧 Ferramentas Necessárias
.NET 6 SDK
SQL Server
Visual Studio ou Visual Studio Code

📜 Licença
Este projeto é de uso pessoal e educacional. Caso deseje utilizá-lo para outros fins, entre em contato.
