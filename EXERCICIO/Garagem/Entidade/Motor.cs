using System.Collections.Generic;

namespace Entidade
{
    public class Motor
    {

        public static List<Motor> lstMotor = new List<Motor>();

        #region Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return "Id: " + this.Id + "\nDescricao: " + this.Descricao;
        }

        public void Inserir()
        {
            lstMotor.Add(this);
        }
        #endregion
    }
}