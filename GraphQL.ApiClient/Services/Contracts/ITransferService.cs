using GraphQL.ApiClient.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraphQL.ApiClient.Services.Contracts
{
    public interface ITransferService
    {
        Task<Data> GetTransfers();
    }
}
