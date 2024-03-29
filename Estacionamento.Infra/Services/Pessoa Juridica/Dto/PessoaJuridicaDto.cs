﻿using Estacionamento.Domain.Emails_Pessoa_Juridica;
using Estacionamento.Domain.Telefones_Pessoa_Juridica;
using System.Collections.Generic;

namespace Estacionamento.Domain.Services.Pessoa_Juridica.Dto
{
    public class PessoaJuridicaDto
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereço { get; set; }

        public IEnumerable<TelefonesPessoaJuridicaEntity> Telefones { get; set; }
        public IEnumerable<EmailsPessoaJuridicaEntity> Emails { get; set; }
    }
}
