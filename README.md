Usei o banco de dados MySql por não ter tido experiencia com o sql server e utilizei o padrao code first,
então é só ir no Package Manager Console e usar o comando: Update-Database.
Pois utilizei o pacote Pomelo.EntityFrameworkCore.MySql mas coloquei o codigo sql junto ao projeto. 
Além disso tem que ser feita a troca das informações de conexão em appsettings.json
"server=localhost;userid=root;password=senha;database=dbprovacrudfiap"

Utilizei o .net core 5 por nao saber se os devs já estão utilizando o visual studio 22 onde é por padrão o 6 e o 7,
então possa ser que antes de executar o projeto tenha que ser baixado o .net core 5.

Fiz o front utilizando um template bootstrap (https://startbootstrap.com/theme/agency) e fui editando a favor dos requisitos do teste, justamente porque foquei no Crud.
Deixei tudo em ingles por conta da redundancia do portugues
e mantive os textos em latim que ja vem com o template justamente para mostrar aonde teria texto pois pela falta de tempo, 
nao daria para fazer textos para colocar no mesmo.

No site tem a area de serviços, produtos, que, é onde eu pensei que seria o preços, pois no video do chicão não da para entender muito bem o que seria esse "preços"

Coloquei uns topicos falando sobre o publico alvo e "criação" da ponto frio

E por fim

O cadastro esta no final do site, aonde o usuario pode fazer o cadastro para receber promoções. 
ao efetuar o cadastro é redirecionado para adm, aonde da para ver a lista de cadastro, editar, ver detetalhes e excluir 
da para voltar para a home clicando na logotipo na navbar.

O back está fazendo todas as validações antes de cadatrar ou alterar para nao ter cadastro nulo.

caso eu consiga a vaga, irei me esforçar muito para aprender o que deixei passar nesse teste!
