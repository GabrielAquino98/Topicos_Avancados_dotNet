using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class Carro
    {

        public static List<Carro> lstCarro = new List<Carro>();

        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public Motor Motor { get; set; }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Id: " + this.Id + "\nNome: " + this.Nome + "\nMarca: " + this.Marca + "\nModelo: " + this.Modelo
                + "\nCor: " + this.Cor + "\nAno de Fabricação: " + this.AnoFabricacao + "\nModelo ano: " + this.AnoModelo 
                + "Motor: " + this.Motor.Descricao;
        }

        public void Inserir()
        {
            lstCarro.Add(this);
        }

        public string GetAll(Carro c)
        {
            return ToString(c);
        }
        #endregion
    }
}