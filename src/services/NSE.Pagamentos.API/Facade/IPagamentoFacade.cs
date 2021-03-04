using System.Threading.Tasks;
using NSE.Pagamentos.API.Models;

namespace NSE.Pagamentos.API.Facade
{
    public interface IPagamentoFacade
    {
        Task<Transacao> AutorizarPagamento(Pagamento pagamento);
    }
}