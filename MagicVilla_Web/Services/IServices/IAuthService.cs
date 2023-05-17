﻿using MagicVilla_Web.Models.Dtos;

namespace MagicVilla_Web.Services.IServices
{
    public interface IAuthService
    {
        Task<T> LoginAsync<T>(LoginRequestDTO login);
        Task<T> RegisterAsync<T>(RegistrationRequestDTO registration);
    }
}
