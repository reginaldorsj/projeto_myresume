
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
	public class LanguageDAO : BaseDAO<Language, long>, MyResume.DAO.ILanguageDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="LanguageDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public LanguageDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="LanguageDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public LanguageDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="LanguageDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public LanguageDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="LanguageDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public LanguageDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<Language> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return Listar("IdAboutInfo","IdAboutInfo",aboutinfo.IdAboutInfo,"IdAboutInfo");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="level">O(A) level.</param>
		/// <returns>A lista.</returns>
		public IList<Language> ListarPorLevel(Level level)
		{
			return Listar("IdLevel","IdLevel",level.IdLevel,"IdLevel");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Language> ListarPor(string idaboutinfo)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
