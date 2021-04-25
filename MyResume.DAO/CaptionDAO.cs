
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
		/// Inicializa uma inst�ncia da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="factoryConfigPath">A arquivo de configura��o do NHibernate.</param>
        public CaptionDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia de <see cref="CaptionDAO"/>.
		/// </summary>
		[Microsoft.Practices.Unity.InjectionConstructor]
        public CaptionDAO()
            : base()
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="session">A sess�o NHibernate.</param>
		/// <param name="configuration">A configura��o.</param>
        public CaptionDAO(ISession session, Configuration configuration)
            : base(session,configuration)
        {
        }
		/// <summary>
		/// Inicializa uma inst�ncia da classe <see cref="CaptionDAO"/>.
		/// </summary>
		/// <param name="connection">A conex�o.</param>
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
			throw new NotImplementedException("N�o implementado.");
		}
	}
}
