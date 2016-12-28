using System.Threading.Tasks;
using DM.MovieApi.ApiRequest;
using DM.MovieApi.ApiResponse;

namespace DM.MovieApi.MovieDb.Configuration
{
    internal class ApiConfigurationRequest : ApiRequestBase, IApiConfigurationRequest
    {
        public ApiConfigurationRequest( IMovieDbSettings settings )
            : base( settings )
        { }

        public async Task<ApiQueryResponse<ApiConfiguration>> GetAsync()
        {
            ApiQueryResponse<ApiConfiguration> response = await base.QueryAsync<ApiConfiguration>( "configuration" );

            return response;
        }
    }
}
