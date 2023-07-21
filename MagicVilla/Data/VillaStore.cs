using MagicVilla.Models.Dto;

namespace MagicVilla.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> { 
            new VillaDTO { Id=1, Name="Pool View", Ocupancy = 4, Sqft = 40},
            new VillaDTO { Id = 2, Name = "Beach View", Ocupancy = 4, Sqft = 40 }
        };
    }
}
