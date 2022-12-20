using MovieRental.Contract.DTOs.Direcor;
using MovieRental.Contract.DTOs.Director;
using MovieRental.Domain.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Services.Mapper
{
    public static class DirectorMapper
    {
        public static DirectorDto ToDirectorDto(this Director director)
        {
            return new DirectorDto()
            {
                FirstName = director.FirstName,
                LastName = director.LastName,
                Image_Url = director.Image_Url,
            };
        }

        public static DirectorSelectionDto ToDirectorSelectionDto(this Director director)
        {
            return new DirectorSelectionDto()
            {
                Id = director.Id,
                FirstName = director.FirstName,
                LastName = director.LastName
            };
        }
    }
}
