#DesafioBackIndt

# 💾 Instalação
- Necessario DOTNET 7.0 e Sql Managemente Studio
- Clonar o projeto ```git clone https://github.com/EriikSilva/desafio-back-indt.git```
- Entrar na Pasta desafio-back-indt via terminal
- Rode o comando ```dotnet restore``` para instalar as dependências
- Para esse projeto optei pelo MySQl
- Em appsetting.json mude a variável Data Source para a sua máquina ```"Data source=NOME DO SERVIDOR AQUI; database=banco-desafio-erik-indt;Trusted_connection=true;Encrypt=false;TrustServerCertificate=true"```
- Copie o Nome do Servidor do SQL SERVER e deixe a autenticação em autenticação do windows como mostra a imagem abaixo
<img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/7d153158-1af2-4d55-b683-6b2923bb90a8"/>
<br>
- Após isso rode o comando ```dotnet ef database update```
  
- Se estiver usando o visual studio aperte o play como mostra a imagem abaixo
<img src="https://github.com/EriikSilva/desafio-back-indt/assets/61124602/a31b7ca1-0592-4709-98c1-ebec58a34fb9"/>
<br>
- Se estiver usando o visual studio code use o comando ```dotnet run```

- endpoint https://localhost:7145/api/Usuario
- endpont Swagger https://localhost:7145/swagger/index.html
