### Aula 3 - Livraria
## Nome: Wellington Cardoso da Silva

1.	Todas as rotas foram expostas em forma de recursos.
2.	As rotas mantem um padrão de nomenclatura e a base de seus recursos está no plural.
3.	A api não é anêmica, pois apesar de a implementação das regras estar em uma camada diferente do domínio, é o próprio domínio quem define o contrato dos métodos que devem ser implementados sobre ele, através de interfaces.
4.	Todas as rotas são simples e não extrapola a regra de coleção/item/coleção.
5.	Os métodos mais críticos, como o de realizar pagamento, utilizam verbos http idempotentes para evitar que a operação seja realizada de forma duplicada em uma mesma transação.
6.	Foi utilizado o DateTimeOffset para definir datas, assim como sugere o padrão ISO 8601.
7.	Foi utilizado a ferramenta Swagger para ajudar a documentar a api.
8.	A Api está configurada para utilizar o https.
9.	Os métodos utilizam versionamento para facilitar futuras alterações sem prejudicar os consumidores das rotas já definidas.
10.	Não possui paginação.
11.	Todos os códigos HTTP foram utilizados de acordo com o que a operação realizava.