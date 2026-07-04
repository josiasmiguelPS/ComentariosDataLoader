using ComentarioDataLoader.Data.Base;
using ComentarioDataLoader.Data.Models;

namespace ComentarioDataLoader.Data.Interfaces
{
    public interface IDaoCliente
    {
        Task<OperactionResult> LoadClienteAsync(LoadClienteModel loadCliente);
    }
}
