
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
	public class LevelDAO : BaseDAO<Level, long>, MyResume.DAO.ILevelDAO
	{
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="LevelDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configura��o do NHibernate.</param>
        public LevelDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia de <see cref="LevelDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public LevelDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="LevelDAO"/>.
		/// </summary>
		/// <param name="session">A sess�o NHibernate.</param>
		/// <param name="configuration">A configura��o.</param>
        public LevelDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="LevelDAO"/>.
		/// </summary>
		/// <param name="connection">A conex�o.</param>
		public LevelDAO(System.Data.Common.DbConnection connection)
			: base(connection)
        {
        }
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="description"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Level> ListarPor(string description)
		{
			throw new NotImplementedException("N�o implementado.");
		}
	}
}
