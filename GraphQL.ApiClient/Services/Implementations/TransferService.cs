using GraphQL.ApiClient.DataAccess;
using GraphQL.ApiClient.Models;
using GraphQL.ApiClient.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.ApiClient.Services.Implementations
{
    public class TransferService : GraphqlClientBase, ITransferService
    {
        public async Task<Data> GetTransfers()
        {
            var query = @"
                            {
                                courses{
                                    name,
                                    id
                                }
                            }
                        ";


            var request = new GraphQLRequest(query);


            var response = await _graphQLHttpClient.SendQueryAsync<Data>(request);
            if (response.Errors != null && response.Errors.Any())
            {
                throw new Exception(string.Join(", ", response.Errors.Select(s => s.Message).ToList()));
            }

            return response.Data;
        }
    }
 
}
