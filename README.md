# Exemplo API em C#
Exemplo de uma Api em C#

Este projeto foi criado no dotNetCore intencionalmente, para que a mesma aplicação possa rodar num **Server Linux** com **apache**
ou em um **Server Windows** com **IIS**, sem a necessidade de adaptação de código.

## Criação do Projeto 
*New Project > ASP.NET Core Web Application > Name: "NomeDoProjeto" > Wev API*

## Dependencias
Pesquisar no **Nuget package** a segunte dependencia do Postgres: "*Npgsql.EntityFrameworkCore.PostgreSQL*"

## Criando Pastas
Em *Controllers* Botão direito do mouse *Add > New Scaffolded Item... > Full Dependencies*

Neste momento será criado as pastas **Data**, **Models** e **Views**.

### Data
Cria-se as Classes de *Context* que reflete as tabelas que tem no banco

### Models
Cria-se as Classes que correspondem as tabelas do banco

### Views
Para este tipo de aplicação, não é nescessário implementar nada

## Configurando arquivos

### *appsettings.json*
Este arquivo serve para configurar a conecção com a instancia do banco de dados (*neste caso o postgres*).
Deve-se adcionar no script:

    "DbContextSettings": {    
      "ConnectionString": "User ID=postgres;Password=2788502;Host=localhost;Port=5432;Database=dbTeste;Pooling=true;"    
     }    

### *Startup.cs*
Esta classe é a primeira a ser executada no programa seria algo parecido com a "*Main*"
Deve-se inserir e substituir nesta página os códigos de acordo com o descrito abaixo (Não se esqueça de baixar as bibliotecas nescessárias):

    
     public class Startup    
     {
       public Startup(IConfiguration configuration)
       {
           Configuration = configuration;
      }

       public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration["dbContextSettings:ConnectionString"];
            services.AddDbContext<Context>(opts => opts.UseNpgsql(connectionString)
            );
            // Add framework services.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
     }
## Rodando a API

No **Visual Studio** existe o botão *IIS Express* clique no mesmo para executar a aplicação.
Quando a aplicação rodar a mesma irá abrir se navegador padão com uma *URL* por defalt bem parecida com esta [http://localhost:27002/api/values](http://localhost:27002/api/values) .
Para fazer um *GET* nesta aplicação, na tabela de **produto** basta colocar a seguinte *URL* [http://localhost:27002/api/produto](http://localhost:27002/api/produto).

Recomenda-se utilizar a ferramenta [POSTMAN](https://www.getpostman.com/), para testar todas as requisições *HTTP* (*GET*, *POST*, *PUT*, *DELETE*), que você achar necessário.
Para baixá-la, basta clicar no link no meio da acima.

## Considerações Finais
* Apenas Ressaltando que todas as instruções dadas acima estão baseadas no projeto implementado deste repositório.
