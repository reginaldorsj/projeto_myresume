
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Regisoft.Camadas.Generic;
using System.Data;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Cfg;
using MyResume.OR;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe para acesso ao banco de dados utilizando o NHiberante.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class CaptionDAO : BaseDAO<Caption, long>, MyResume.DAO.ICaptionDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public CaptionDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="CaptionDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public CaptionDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public CaptionDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public CaptionDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<Caption> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return Listar("IdAboutInfo","IdAboutInfo",aboutinfo.IdAboutInfo,"IdAboutInfo");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Caption> ListarPor(string idaboutinfo)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
