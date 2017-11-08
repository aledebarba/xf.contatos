﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.Recursos.Estilo
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
