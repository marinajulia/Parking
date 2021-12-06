﻿using Estacionamento.Domain.Services.Pessoa_Fisica;
using Estacionamento.Infra.Data;
using Estacionamento.Infra.Pessoa_Fisica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estacionamento.Infra.Repositories.PessoaFisica
{
    public class PessoaFisicaRepository : IPessoaFisicaRepository
    {
        public bool GetByCpf(string cpf)
        {
            using (var context = new ApplicationContext())
            {
                var CPF = context.PessoaFisica.FirstOrDefault(x => x.CPF == cpf);

                if (CPF == null)
                    return false;

                return true;
            }
        }

        public PessoaFisicaEntity PostPessoaFisica(PessoaFisicaEntity pessoaFisicaEntity)
        {
            using (var context = new ApplicationContext())
            {
                var pessoaFisica = context.PessoaFisica.Add(pessoaFisicaEntity);
                context.SaveChanges();

                return pessoaFisicaEntity;
            }
        }
    }
}

