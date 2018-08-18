using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorSystem.Core.Model
{
    public class MessageReturnModel
    {
        #region Public Members

        public bool Sucesso { get; set; }
        public List<string> Mensagem { get; set; }
        public object Retorno { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public MessageReturnModel() { }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="sucesso"></param>
        /// <param name="mensagem"></param>
        /// <param name="retorno"></param>
        public MessageReturnModel(bool sucesso, List<string> mensagem, object retorno)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Retorno = retorno;
        }
        
        #endregion
    }
}
