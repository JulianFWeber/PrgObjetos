using System.Collections.Generic;

namespace PeixariaProject.Repositories
{
    // Essa interface é um modelo para nossos repositórios.


    public interface IRepository<T>
    {
        // Método para adicionar um novo item (ou entidade) ao nosso "banco de dados".
        // Por exemplo, quando queremos adicionar um novo peixe.
        void Add(T entity);

        // Método para buscar um item específico pelo seu ID.
        // Isso é útil quando queremos ver os detalhes de um peixe específico.
        T GetById(int id);

        // Método para pegar todos os itens que temos.
        // Por exemplo, se quisermos listar todos os peixes disponíveis.
        IEnumerable<T> GetAll();

        // Método para atualizar um item que já existe.
        // Por exemplo, se quisermos mudar as informações de um peixe que já temos.
        void Update(T entity);

        // Método para deletar um item pelo seu ID.
        // Isso é usado quando queremos remover um peixe do nosso sistema.
        void Delete(int id);
    }
}