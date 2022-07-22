using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System;
using System.Net.Http;

namespace GraphQL.ApiClient.DataAccess
{
    public abstract class GraphqlClientBase
    {
        public readonly GraphQLHttpClient _graphQLHttpClient;
        public GraphqlClientBase()
        {
            if (_graphQLHttpClient == null)
            {
                _graphQLHttpClient = GetGraphQlApiClient();
            }
        }

        public GraphQLHttpClient GetGraphQlApiClient()
        {
            var endpoint = "https://localhost:8325/graphql";

            var httpClientOption = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(endpoint)
            };

            return new GraphQLHttpClient(httpClientOption, new NewtonsoftJsonSerializer(), new HttpClient());
        }
    }
}
