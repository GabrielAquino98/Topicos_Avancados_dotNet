using System.Collections.Generic;

namespace Entidade
{
    public class GrauSatisfacao
    {

        #region Atributos

        public static List<GrauSatisfacao> lstGrauSatisfacao = new List<GrauSatisfacao>();
        

        #endregion

        #region Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region Metodos
        
        public void addGrauSatisfacao()
        {
            lstGrauSatisfacao.Add(this);
        }

        public List<GrauSatisfacao> getAll()
        {
            return lstGrauSatisfacao;
        }

        public override string ToString()
        {
            return "Id: " + this.Id + "\nDescricao: " +this.Descricao;
                ;
        }

        #endregion
    }
}