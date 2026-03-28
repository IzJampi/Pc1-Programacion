using System;
using System.Collections.Generic;

namespace PC1.Models
{
    public static class CampanaData
    {
        public static List<Campana> Lista = new List<Campana>()
        {
            new Campana {
                Id = 1,
                Nombre = "Cyber Electro",
                Categoria = "Electro",
                Estado = "Vigente",
                FechaInicio = DateTime.Now.AddDays(-5),
                FechaFin = DateTime.Now.AddDays(5),
                DescuentoPct = 20,
                Canal = "Web",
                Descripcion = "Descuentos en electrodomésticos"
            },
            new Campana {
                Id = 2,
                Nombre = "Moda Verano",
                Categoria = "Moda",
                Estado = "Próxima",
                FechaInicio = DateTime.Now.AddDays(3),
                FechaFin = DateTime.Now.AddDays(10),
                DescuentoPct = 15,
                Canal = "App",
                Descripcion = "Nueva colección verano"
            },
            new Campana {
                Id = 3,
                Nombre = "Hogar Sale",
                Categoria = "Hogar",
                Estado = "Finalizada",
                FechaInicio = DateTime.Now.AddDays(-20),
                FechaFin = DateTime.Now.AddDays(-10),
                DescuentoPct = 30,
                Canal = "Tienda",
                Descripcion = "Liquidación hogar"
            }
        };
    }
}