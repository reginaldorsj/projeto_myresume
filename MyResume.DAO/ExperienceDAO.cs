
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
	public class ExperienceDAO : BaseDAO<Experience, long>, MyResume.DAO.IExperienceDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ExperienceDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public ExperienceDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="ExperienceDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public ExperienceDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ExperienceDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public ExperienceDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ExperienceDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public ExperienceDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<Experience> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			ICriteria crit = Get<ICriteria>()
				.AddOrder(Order.Desc("StartYear"))
				.AddOrder(Order.Desc("StartMonth"))
				.CreateAlias("IdAboutInfo", "about", NHibernate.SqlCommand.JoinType.InnerJoin)
					.Add(Restrictions.Eq("about.IdAboutInfo", aboutinfo.IdAboutInfo));

			return crit.List<Experience>();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Experience> ListarPor(string idaboutinfo)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
