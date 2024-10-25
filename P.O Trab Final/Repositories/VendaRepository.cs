using System.Collections.Generic;
using System.Linq;
using PeixariaProject.Data;
using PeixariaProject.Models;

namespace PeixariaProject.Repositories
{
    // Essa classe é responsável por gerenciar as vendas no banco de dados.
    public class VendaRepository : IRepository<Venda>
    {
        private readonly ApplicationDbContext _context; // Aqui estamos guardando o contexto do banco de dados que vamos usar.

        // O construtor é chamado quando criamos um novo VendaRepository.
        // Ele recebe o contexto do banco de dados como parâmetro.
        public VendaRepository(ApplicationDbContext context)
        {
            _context = context; // Guardamos o contexto recebido na variável _context.
        }

        // Esse método adiciona uma nova venda ao banco de dados.
        public void Add(Venda venda)
        {
            _context.Vendas.Add(venda); // Adiciona a venda à lista de vendas no contexto.
            _context.SaveChanges(); // Salva as mudanças no banco de dados.
        }

        // Esse método busca uma venda pelo ID.
        public Venda GetById(int id)
        {
            // Retorna a primeira venda que tem o ID igual ao que passamos, ou null se não encontrar.
            return _context.Vendas.FirstOrDefault(v => v.Id == id);
        }

        // Esse método retorna todas as vendas do banco de dados.
        public IEnumerable<Venda> GetAll()
        {
            // Converte a lista de vendas em uma lista comum e a retorna.
            return _context.Vendas.ToList();
        }

        // Esse método atualiza uma venda existente no banco de dados.
        public void Update(Venda venda)
        {
            _context.Vendas.Update(venda); // Atualiza a venda no contexto.
            _context.SaveChanges(); // Salva as mudanças no banco de dados.
        }

        // Esse método deleta uma venda pelo ID.
        public void Delete(int id)
        {
            var venda = GetById(id); // Busca a venda pelo ID.
            if (venda != null) // Se a venda foi encontrada...
            {
                _context.Vendas.Remove(venda); // Remove a venda do contexto.
                _context.SaveChanges(); // Salva as mudanças no banco de dados.
            }
        }
    }
}