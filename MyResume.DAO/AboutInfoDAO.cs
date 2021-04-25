
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
	public class AboutInfoDAO : BaseDAO<AboutInfo, long>, MyResume.DAO.IAboutInfoDAO
	{
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="AboutInfoDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configura��o do NHibernate.</param>
        public AboutInfoDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia de <see cref="AboutInfoDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public AboutInfoDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="AboutInfoDAO"/>.
		/// </summary>
		/// <param name="session">A sess�o NHibernate.</param>
		/// <param name="configuration">A configura��o.</param>
        public AboutInfoDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="AboutInfoDAO"/>.
		/// </summary>
		/// <param name="connection">A conex�o.</param>
		public AboutInfoDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="firstname"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<AboutInfo> ListarPor(string firstname)
		{
			throw new NotImplementedException("N�o implementado.");
		}
	}
}
