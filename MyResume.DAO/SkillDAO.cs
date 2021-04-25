
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
	public class SkillDAO : BaseDAO<Skill, long>, MyResume.DAO.ISkillDAO
	{
		/// <summary>
		/// Inicializa uma instância da classe <see cref="SkillDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configuração do NHibernate.</param>
        public SkillDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma instância de <see cref="SkillDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public SkillDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="SkillDAO"/>.
		/// </summary>
		/// <param name="session">A sessão NHibernate.</param>
		/// <param name="configuration">A configuração.</param>
        public SkillDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma instância da classe <see cref="SkillDAO"/>.
		/// </summary>
		/// <param name="connection">A conexão.</param>
		public SkillDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<Skill> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return Listar("IdAboutInfo","IdAboutInfo",aboutinfo.IdAboutInfo,"OrderNumber");
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Skill> ListarPor(string idaboutinfo)
		{
			throw new NotImplementedException("Não implementado.");
		}
	}
}
