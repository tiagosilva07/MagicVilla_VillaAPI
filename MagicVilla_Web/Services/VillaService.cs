using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dtos;
using MagicVilla_Web.Services.IServices;
using static MagicVilla_Web.Models.APIUtility;

namespace MagicVilla_Web.Services
{
    public class VillaService : BaseService, IVillaService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string APIUrl;

        public VillaService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            APIUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }


        public Task<T> CreateAsync<T>(VillaCreateDTO createDTO,string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.POST,
                Data= createDTO,
                Url= $"{APIUrl}/{APIv1Version}/VillaAPI",
                Token = token

            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.DELETE,
                Url = $"{APIUrl}/{APIv1Version}/VillaAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{APIUrl}/{APIv1Version}/VillaAPI",
                Token = token

            });
        }

        public Task<T> GetAsync<T>(int id,string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{APIUrl}/{APIv1Version}/VillaAPI/{id}",
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaUpdateDTO updateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = updateDTO,
                Url = $"{APIUrl}/{APIv1Version}/VillaAPI/{updateDTO.Id}",
                Token = token
            });
        }
    }
}
