Se chegou até aqui já começou bem porque achou o projeto certo no git

Instruções dessa bomba --


Post Peixe

*1 = "Rio ou Aquicultura ou Lago ou Mar"	// qualquer coisa além darra erro na tratação das exceções
*2 = Congelado ou Fresco					// qualquer coisa além darra erro na tratação das exceções
"quantidade": 1,						// 0 ou negativo é proibido
"preco": 50								// 0 ou negativo é proibido
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


Get, get by id e Delete não tem segredo

Put Peixe
1. Mesmas validações do post
2. O json inteiro substituirá o peixe salvo, se informar somente o nome, o resto passará a ser NULL
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

Somente informa o ID do peixe a ser vendido e a quantidade que será vendida

1. Id não encontrato cairá na validação
2. Quantidade 0 ou negativa cairá em validação
3. Quantidade maior que a quantidade em estoque cairá em validação

Response body vem com ID de venda: 0 
Mas ele tem ID 


Tutorial finalizado, considerações finais


Usei o pc aqui de casa pra terminar esse projeto tive altos problema no git, em meio ao commit rolou um merge bolado e
meu projeto virou uma mesclação do projeto anterior com o novo bugou uma caraiada de coisa mas acho que no fim o *BÁSICO* funcionou mais o menos
(q derota)


ao menos acredito que acertei na estruturação mas talvez esteja errado em acreditar em mim
implementações extras ao mínimo = errei fui mlk

nós vemos sexta antes do exame, durante o exame, e depois do exame na aabb 