﻿using Estacionamento.Domain.Emails_Pessoa_Juridica;
using Estacionamento.Domain.Telefones_Pessoa_Juridica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estacionamento.Domain.Pessoa_Juridica.Entity
{
    [Table("PessoaJuridica")]
    public class PessoaJuridicaEntity
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereço { get; set; }
        public DateTime CreatedAt { get; set; }

        public IEnumerable<TelefonesPessoaJuridicaEntity> Telefones { get; set; }
        public IEnumerable<EmailsPessoaJuridicaEntity> Emails { get; set; }
    }
}
