Se chegou at� aqui j� come�ou bem porque achou o projeto certo no git

Instru��es dessa bomba --


Post Peixe

*1 = "Rio ou Aquicultura ou Lago ou Mar"	// qualquer coisa al�m darra erro na trata��o das exce��es
*2 = Congelado ou Fresco					// qualquer coisa al�m darra erro na trata��o das exce��es
"quantidade": 1,						// 0 ou negativo � proibido
"preco": 50								// 0 ou negativo � proibido
{
  "nome": "Qualquer",
  "localCaptura": "string",
  "tipoCriacao": "*1", 
  "conservacao": "*2",
  "quantidade": 1,
  "preco": 50
}


Response body vem com ID: 0 
Mas ele tem ID 


Get, get by id e Delete n�o tem segredo

Put Peixe
1. Mesmas valida��es do post
2. O json inteiro substituir� o peixe salvo, se informar somente o nome, o resto passar� a ser NULL
{
  "nome": "Qualquer",
  "localCaptura": "string",
  "tipoCriacao": "string", 
  "conservacao": "sting",
  "quantidade": 0,
  "preco": 0
}

POST VENDA --

{
  "peixeId": 1,
  "quantidadeVendida": 1
}

Somente informa o ID do peixe a ser vendido e a quantidade que ser� vendida

1. Id n�o encontrato cair� na valida��o
2. Quantidade 0 ou negativa cair� em valida��o
3. Quantidade maior que a quantidade em estoque cair� em valida��o

Response body vem com ID de venda: 0 
Mas ele tem ID 


Tutorial finalizado, considera��es finais


Usei o pc aqui de casa pra terminar esse projeto tive altos problema no git, em meio ao commit rolou um merge bolado e
meu projeto virou uma mescla��o do projeto anterior com o novo bugou uma caraiada de coisa mas acho que no fim o *B�SICO* funcionou mais o menos
(q derota)


ao menos acredito que acertei na estrutura��o mas talvez esteja errado em acreditar em mim
implementa��es extras ao m�nimo = errei fui mlk

n�s vemos sexta antes do exame, durante o exame, e depois do exame na aabb 