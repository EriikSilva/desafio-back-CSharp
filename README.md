# DesafioBackIndt
## 📌 Índice
[Sobre](#-sobre) <br>
[Instação](#-instalação) <br>
ㅤ[Migration Tutorial](#-migration-tutorial-feito-para-esse-projeto) <br>
ㅤ[Seed Tutorial](#-seed-tutorial) <br>
[Rotas](#-rotas) <br>
[Instação no Visual Studio Code](#caso-opte-pelo-visual-studio-code) <br>
[Autor](#autor)

## 📰 Sobre
Este projeto, denominado DesafioBackIndt, é uma implementação que utiliza o padrão Repository  Pattern, delegando a responsabilidade das requisições para o service. Trata-se de uma aplicação que envolve um CRUD de usuários e sistema de login.

O sistema utiliza o ASP.NET API com o DOTNET 7.0 e é desenvolvido no Visual Studio 2022. A gestão de dados é realizada através do SQL Server Management Studio ou do PostgreSQL, proporcionando flexibilidade na escolha do banco de dados.

O processo de inicialização do projeto é facilitado pelo tutorial disponibilizado pelo autor, permitindo a rápida clonagem e configuração no Visual Studio Community. Além disso, o projeto inclui instruções detalhadas para migração e seeding de dados, garantindo uma configuração completa e funcional do ambiente.

Em resumo, o DesafioBackIndt oferece uma estrutura robusta para a gestão de usuários, com endpoints claros para operações de CRUD, tornando-se uma base sólida para o desenvolvimento de sistemas que envolvam a manipulação de dados de usuários.



## 💾 Instalação
- Necessário DOTNET 7.0 (ASP.NET API)
- Visual Studio 2022 
- SQL Server Management Studio ou Postgresql
- Para clonar o projeto no Visual Studio Community siga o tutorial gravado pelo autor [Tutorial para clonar o projeto](https://www.youtube.com/watch?v=NsxJL49WrWU)


### 🔄 Migration Tutorial (Feito para esse projeto)
Após instalar as dependências, escolha entre SQLSERVER ou POSTGRESQL para a migração. Comente o serviço não escolhido. Abaixo, um exemplo para SQLSERVER:
<img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/4ccf3f0c-fb3d-49e5-ad6a-7dea409891c9">

Siga as instruções conforme o tipo de migração escolhido nos links abaixo:
<table>
  <th>
    <a href="https://www.youtube.com/watch?v=lWQBQac1_dM">SQL Server Migration Tutorial</a>
  </th>
  <th>
    <a href="https://www.youtube.com/watch?v=9fiKmd9mGzc&feature=youtu.be">POSTGRES Server Migration Tutorial</a>
  </th>
  <tr>
    <td><img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/6982689c-7b09-4d3e-ae1c-1e2f019bd772"></td>
    <td><img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/6e7f52f5-66de-4f73-bb45-bbd00082babc"></td>
  </tr>
</table>
⚠️ OBS: Não esqueça de trocar as connectionsStrings como nos videos acima

### 🌱 Seed Tutorial
- Abra o cmd
- Entre na pasta desafio-back-indt
- Digite o comando ```dotnet run seeddata```

**Usuários do Seed**:
<table>
        <tr>
            <th>Nome</th>
            <th>Sobrenome</th>
            <th>Email</th>
            <th>Senha</th>
            <th>Nível de Acesso</th>
        </tr>
        <tr>
            <td>admin</td>
            <td>administrador</td>
            <td>admin@admin.com</td>
            <td>admin123</td>
            <td>Admin</td>
        </tr>
        <tr>
            <td>admin2</td>
            <td>administrador2</td>
            <td>admin2@admin2.com</td>
            <td>admin321</td>
            <td>Admin</td>
        </tr>
        <tr>
            <td>John</td>
            <td>Doe</td>
            <td>johndoe@jonhdoe.com</td>
            <td>john123</td>
            <td>Usuário Comum</td>
        </tr>
    </table>

Caso precise de ajuda, siga o tutorial abaixo feito pelo autor do projeto para o projeto em questão:
<table>
  <th>
    <a href="https://www.youtube.com/watch?v=46sxtqjtDHA">Como aplicar o Seed</a>
  </th>
  <tr>
    <td><img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/77ffbcc6-00c3-4d87-bd9b-fefc42454d8d" width=500></td>
  </tr>
</table>

⚠️ Só rode o Seed após ter feito as migrations.

- endpoint: https://localhost:7145/api/Usuario
- endpont Swagger: https://localhost:7145/swagger/index.html

## 🐱‍👤 ROTAS
- Usuário
  - POST => /api/Usuario
  - PUT => /api/Usuario
  - POST => /api/Usuario
  - GET => /api/Usuario
  - GET => /api/Usuario/{id}
- Login
  - /api/Usuario/login

## Caso opte pelo Visual Studio Code
- Clonar o projeto ```git clone https://github.com/EriikSilva/desafio-back-indt.git```
- Entrar na Pasta desafio-back-indt via terminal
- Rode o comando ```dotnet restore``` para instalar as dependências
- Rode o comando ```dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0``` para instalar o EntityFramework
- Rode o comando ```dotnet ef migrations add primeira_migracao``` para criar o migration que cria o schema do banco.
- Rode o comando ```dotnet ef database update``` para atualizar o schema do banco.

# Autor
<table border="0", align="center">
    <tr>
        <td>
          <img src="https://github.com/andreinaoliveira/RestAPITest/assets/51168329/209eddcc-5963-4e55-9ccb-5e79182085a0" width=600><br>
          <a href="https://github.com/EriikSilva">Erik Felipe</a>
          <p></p>
        </td>
        <td>
          <p>Erik Felipe é um Desenvolvedor Fullstack altamente qualificado, destacando-se em uma variedade de tecnologias front-end, incluindo Angular, Vue e React, bem como em linguagens como JavaScript e TypeScript. Sua expertise abrange o desenvolvimento back-end, utilizando Node.js, Prisma, Nest.js, .NET e C#. Além disso, Erik possui profundo conhecimento em bancos de dados, tanto relacionais (MySQL, Oracle, PostgreSQL) quanto NoSQL (MongoDB). Sua versatilidade e amplitude de habilidades o capacitam a enfrentar desafios complexos de desenvolvimento de software, oferecendo soluções eficientes em todas as camadas de uma aplicação Fullstack.</p>
        </td>
    </tr>
</table>

  
