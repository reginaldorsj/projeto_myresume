
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
    public class EducationDAO : BaseDAO<Education, long>, MyResume.DAO.IEducationDAO
    {
        /// <summary>
        /// Inicializa uma inst�ncia da classe <see cref="EducationDAO"/>.
        /// </summary>
        /// <param name="factoryConfigPath">A arquivo de configura��o do NHibernate.</param>
        public EducationDAO(string factoryConfigPath)
            : base(factoryConfigPath, "MyResume.OR", null)
        {
        }
        /// <summary>
        /// Inicializa uma inst�ncia de <see cref="EducationDAO"/>.
        /// </summary>
        [Microsoft.Practices.Unity.InjectionConstructor]
        public EducationDAO()
            : base()
        {
        }
        /// <summary>
        /// Inicializa uma inst�ncia da classe <see cref="EducationDAO"/>.
        /// </summary>
        /// <param name="session">A sess�o NHibernate.</param>
        /// <param name="configuration">A configura��o.</param>
        public EducationDAO(ISession session, Configuration configuration)
            : base(session, configuration)
        {
        }
        /// <summary>
        /// Inicializa uma inst�ncia da classe <see cref="EducationDAO"/>.
        /// </summary>
        /// <param name="connection">A conex�o.</param>
        public EducationDAO(System.Data.Common.DbConnection connection)
            : base(connection)
        {
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="aboutinfo">O(A) aboutinfo.</param>
        /// <returns>A lista.</returns>
        public IList<Education> ListarPorAboutInfo(AboutInfo aboutinfo)
        {
            ICriteria crit = Get<ICriteria>()
                .AddOrder(Order.Desc("StartYear"))
				.CreateAlias("IdAboutInfo", "about", NHibernate.SqlCommand.JoinType.InnerJoin)
                    .Add(Restrictions.Eq("about.IdAboutInfo", aboutinfo.IdAboutInfo));
            return crit.List<Education>();
        }
        /// <summary>
        /// Listar objetos.
        /// </summary>
        /// <param name="idaboutinfo"> O dado para pesquisa.</param>
        /// <returns>A lista.</returns>
        public IList<Education> ListarPor(string idaboutinfo)
        {
            throw new NotImplementedException("N�o implementado.");
        }
    }
}
