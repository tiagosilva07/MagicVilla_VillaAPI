using MagicVilla_Web.Models;
using MagicVilla_Web.Models.Dtos;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using static MagicVilla_Web.Models.APIUtility;

namespace MagicVilla_Web.Services
{
    public class AuthService : BaseService, IAuthService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private string APIUrl;
        public AuthService(IHttpClientFactory httpClient, IConfiguration configuration):base(httpClient)
        {
            _httpClientFactory = httpClient;
            APIUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");
        }

        public Task<T> LoginAsync<T>(LoginRequestDTO login)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.POST,
                Data = login,
                Url = $"{APIUrl}/{APIv1Version}/UsersAuth/login"
            });
        }

        public Task<T> RegisterAsync<T>(RegistrationRequestDTO registration)
        {
            return SendAsync<T>(new APIRequest()
            {
                ApiType = ApiType.POST,
                Data = registration,
                Url = $"{APIUrl}/{APIv1Version}/UsersAuth/register"
            });
        }
    }
}
