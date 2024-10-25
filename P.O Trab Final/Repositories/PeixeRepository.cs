using System;
using System.Collections.Generic;
using System.Linq;
using PeixariaProject.Data;
using PeixariaProject.Models;

namespace PeixariaProject.Repositories
{
    // Essa classe é responsável por gerenciar as operações com os peixes no banco de dados.
    // Ela implementa a interface IRepository<Peixe>, que define métodos que vamos usar.
    public class PeixeRepository : IRepository<Peixe>
    {
        // Aqui estamos criando uma variável privada que vai guardar o contexto do banco de dados.
        // O ApplicationDbContext é o que nos permite interagir com o banco.
        private readonly ApplicationDbContext _context;

        // Esse é o construtor da classe. Ele recebe o contexto do banco e o armazena na variável _context.
        // Isso é importante para que possamos usar esse contexto nas operações abaixo.
        public PeixeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para adicionar um novo peixe ao banco de dados.
        public void Add(Peixe peixe)
        {
            // Aqui, estamos dizendo para o contexto que queremos adicionar um peixe novo.
            _context.Peixes.Add(peixe);
            // Depois, salvamos as mudanças no banco para que o peixe realmente seja adicionado.
            _context.SaveChanges();
        }

        // Método para buscar um peixe pelo seu ID.
        public Peixe GetById(int id)
        {
            // Usamos FirstOrDefault para pegar o primeiro peixe que tem o ID que passamos.
            // Se não encontrar, ele retorna null.
            return _context.Peixes.FirstOrDefault(p => p.Id == id);
        }

        // Método para pegar todos os peixes do banco de dados.
        public IEnumerable<Peixe> GetAll()
        {
            // ToList() converte a lista de peixes para uma lista em memória.
            return _context.Peixes.ToList();
        }

        // Método para atualizar as informações de um peixe que já existe.
        public void Update(Peixe peixe)
        {
            // Aqui, estamos dizendo ao contexto que queremos atualizar o peixe.
            _context.Peixes.Update(peixe);
            // E novamente, salvamos as mudanças para que a atualização aconteça de verdade.
            _context.SaveChanges();
        }

        // Método para deletar um peixe do banco de dados usando o ID.
        public void Delete(int id)
        {
            // Primeiro, buscamos o peixe pelo ID.
            var peixe = GetById(id);
            // Se encontramos o peixe, removemos ele do contexto.
            if (peixe != null)
            {
                _context.Peixes.Remove(peixe);
                // E salvamos as mudanças para que a remoção aconteça.
                _context.SaveChanges();
            }
        }
    }
}