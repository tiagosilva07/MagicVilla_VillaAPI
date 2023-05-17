using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dtos;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using static MagicVilla_Web.Models.APIUtility;

namespace MagicVilla_Web.Services
{
    public class VillaNumberService : BaseService, IVillaNumberService
    {
        private readonly IHttpClientFactory _clientFactory;
        private string APIUrl;

        public VillaNumberService(IHttpClientFactory clientFactory, IConfiguration configuration) : base(clientFactory)
        {
            _clientFactory = clientFactory;
            APIUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }


        public Task<T> CreateAsync<T>(VillaNumberCreateDTO createDTO, string token)   
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.POST,
                Data= createDTO,
                Url= $"{APIUrl}/{APIv1Version}/VillaNumberAPI",
                Token = token

            });
        }

        public Task<T> DeleteAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.DELETE,
                Url = $"{APIUrl}/{APIv1Version}/VillaNumberAPI/{id}",
                Token = token
            });
        }

        public Task<T> GetAllAsync<T>(string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{APIUrl}/{APIv1Version}/VillaNumberAPI",
                Token = token
            });
        }

        public Task<T> GetAsync<T>(int id, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.GET,
                Url = $"{APIUrl}/{APIv1Version}/VillaNumberAPI/{id}",
                Token = token
            });
        }

        public Task<T> UpdateAsync<T>(VillaNumberUpdateDTO updateDTO, string token)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.PUT,
                Data = updateDTO,
                Url = $"{APIUrl}/{APIv1Version}/VillaNumberAPI/{updateDTO.VillaNo}",
                Token = token
            });
        }
    }
}
