using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using agenda_contatos.Models;

namespace agenda_contatos.DataAccess.Services
{
    public interface IContatoService
    {
        Task<List<Contato>> ListarTodosContatos();
        Task<Contato> ListarContatoPorId(Expression<Func<Contato,bool>> filter);
        Task AdicionarContato(Contato contato);
        Task AtualizarContato(Contato contato);
        Task ExcluirContato(Contato contato);
    }
}
