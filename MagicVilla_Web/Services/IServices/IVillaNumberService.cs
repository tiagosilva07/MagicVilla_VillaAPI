﻿using MagicVilla_Web.Models.Dtos;

namespace MagicVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>();
        Task<T> GetAsync<T>(int id);
        Task<T> CreateAsync<T>(VillaNumberCreateDTO createDTO);
        Task<T> UpdateAsync<T>(VillaNumberUpdateDTO updateDTO);
        Task<T> DeleteAsync<T>(int id);
    }
}
