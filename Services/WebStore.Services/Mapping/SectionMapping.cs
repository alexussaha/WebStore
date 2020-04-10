using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.DTO.Products;
using WebStore.Domian.Entities;

namespace WebStore.Services.Mapping
{
    public static class SectionMapping
    {
        public static SectionDTO ToDTO(this Section section) => section is null ? null : new SectionDTO
        {
            Id = section.Id,
            Name = section.Name
        };

        public static Section FromDTO(this SectionDTO section) => section is null ? null : new Section
        {
            Id = section.Id,
            Name = section.Name
        };
    }
}
