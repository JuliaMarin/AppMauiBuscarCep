﻿namespace AppMauiBuscarCep.Models
{
    public class Endereco
    {
        
        public string id_logradouro { get; set; }
        public string id_cidade { get; set; }
        public string tipo { get; set; }
        public string descricao { get; set; }        
        public string uf { get; set; }
        public string complemento { get; set; }
        public string descricao_sem_numero { get; set; }
        public string codigo_cidade_ibge { get; set; }
        public string descricao_bairro { get; set; }
        public string rows { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }

    }
}
