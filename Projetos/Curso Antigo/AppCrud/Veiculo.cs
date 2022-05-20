using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCrud
{
    public class Veiculo : New_crud
    {
        public Veiculo GetVeiculo(int id)
        {
            using (var dbContext = new CrudEntities())
            {
                var entveiculo = dbContext.New_crud.Find(id);
                if (entveiculo != null)
                {
                    var veiculo = new Veiculo();
                    veiculo.Id = entveiculo.Id;
                    veiculo.Nome = entveiculo.Nome;
                    veiculo.Ano= entveiculo.Ano;
                    veiculo.Modelo = entveiculo.Modelo;
                    veiculo.Fabricacao = entveiculo.Fabricacao;
                    veiculo.Cor = entveiculo.Cor;
                    veiculo.Valor = entveiculo.Valor;
                    veiculo.Combustivel = entveiculo.Combustivel;
                    veiculo.Automatico = entveiculo.Automatico;
                    veiculo.Ativo = entveiculo.Ativo;
                    return veiculo;
                }
                else
                {
                    return null;
                }
            }
        }
             
    }
}
