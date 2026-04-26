# (c) 2026 Guillermo Roger Hernandez Chandia - ADS
# Sentinel Guardian System 🛡️

Sistema de monitoramento e registro de eventos (logs) desenvolvido como projeto acadêmico para o curso de Análise e Desenvolvimento de Sistemas (ADS). O foco do projeto é aplicar conceitos de Backend, Persistência de Dados e Arquitetura de APIs.

## 🚀 Tecnologias Utilizadas
* **C# / .NET 8.0**: Linguagem principal e framework de desenvolvimento.
* **ASP.NET Core Web API**: Criação dos endpoints REST.
* **Entity Framework Core**: Mapeamento Objeto-Relacional (ORM).
* **SQLite**: Banco de Dados leve e eficiente para persistência local.
* **Swagger/OpenAPI**: Documentação interativa e testes de API.

## 🧠 Lógica de Implementação (Bolinhas e Caixas)
O sistema funciona através de um fluxo de dados estruturado:
1. **Models (Moldes):** Definem como a "Bolinha" (Dado) deve ser.
2. **Controller (Porteiro):** Recebe a requisição e aplica filtros de inteligência (como busca por prioridade).
3. **Data (Cano):** O Entity Framework leva a bolinha do código até a gaveta certa na **Caixa (Banco de Dados SQLite)**.

## 🛠️ Como rodar o projeto
1. Clone o repositório: `git clone https://github.com/SEU_USUARIO/GuardianSystem.git`
2. Entre na pasta: `cd GuardianSystem`
3. Execute o motor: `dotnet run`
4. Acesse o Swagger no navegador: `http://localhost:5218/swagger`

## 🛡️ Funcionalidades
- [x] Registro de logs via POST (JSON).
- [x] Filtro inteligente por prioridade via Query String.
- [x] Ordenação cronológica automática.
- [x] Persistência real em banco de dados.

---
**Status:** Em desenvolvimento (Projeto Acadêmico - Uninter)
# GuardianSystem-Radar
