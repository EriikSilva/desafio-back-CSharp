# DesafioBackIndt

# 💾 Instalação
- Necessario DOTNET 7.0 (ASP.NET API)  Visual Studio Community 2022 e SQL Server Management Studio ou Postgresql


  🚀 PARA CLONAR O PROJETO NO VISUAL STUDIO COMMUNITY SIGA AS INTRUÇÕES DO LINK ABAIXO 
  ## 🎨 TUTORIAL => https://www.youtube.com/watch?v=NsxJL49WrWU


### 🧗‍♂️ MIGRATION TUTORIAL (Feito para esse projeto especifico)
- Após instaladas as dependencias e etc, você pode optar por dois tipos de Migration (SQLSERVER ou POSTGRESQL)
- Caso opte por SQLSERVER comente o service do POSTGRESQL como mostra na imagem abaixo e siga as instruções do video que esta no link abaixo tambem
- <img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/4ccf3f0c-fb3d-49e5-ad6a-7dea409891c9">

###  👨‍💻 SQL Server Migration Tutorial => https://www.youtube.com/watch?v=lWQBQac1_dM

- Caso opte por POSTGRESQL comente o service do SQLSERVER e siga as instruções do video que esta no link abaixo
###  👨‍💻 POSTGRES Server Migration Tutorial => https://www.youtube.com/watch?v=9fiKmd9mGzc&feature=youtu.be

### OBS: Não se esqueça de trocar as connectionsStrings como nos videos acima

- endpoint https://localhost:7145/api/Usuario
- endpont Swagger https://localhost:7145/swagger/index.html


# 🐱‍👤 ROTAS
- USUARIO
  - POST => /api/Usuario
  - PUT => /api/Usuario
  - POST => /api/Usuario
  - GET => /api/Usuario
  - GET => /api/Usuario/{id}
 
- Login
  - /api/Usuario/login
<hr>
<br>

  ### CASO OPTE PELO VISUAL STUDIO CODE
- Clonar o projeto git clone https://github.com/EriikSilva/desafio-back-indt.git
- Entrar na Pasta desafio-back-indt via terminal
- Rode o comando ```dotnet restore``` para instalar as dependências


# Comando para instalar o EntityFramework:
```dotnet add package Microsoft.EntityFrameworkCore.Tools --version 6.0.0```

# Comando para criar o migration que cria o schema do banco:
```dotnet ef migrations add primeira_migracao```

# Comando para criar o schema no banco
```dotnet ef database update```

  
