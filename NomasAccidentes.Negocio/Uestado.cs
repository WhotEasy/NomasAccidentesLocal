﻿using NomasAccidentes.Dalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomasAccidentes.Negocio
{
    public class Uestado
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        Entities db = new Entities();

        public List<Uestado> ReadAll()
        {

            return db.ESTADO_USUARIOS.Select(u => new Uestado()
            {
                Id = u.ID_ESTADO_USUARIOS,
                Descripcion = u.DESCRIPCION
            }).ToList();
        }
    }
}
