﻿using MagicVilla_VillaAPI.Models.Dtos;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaDataStore
    {
        public static List<VillaDTO> VillaList = new() { 
            new VillaDTO() {Id=1, Name="Pool View"},
            new VillaDTO() {Id=2,Name="Beach View"} 
        };
    }
}