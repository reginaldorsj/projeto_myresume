
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Regisoft;
using MyResume.OR;
using MyResume.DAO;

namespace MyResume.BO
{
	/// <summary>
	/// Regras de negócio para gerenciamento da classe <see cref='ExperienceBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class ExperienceBO : MarshalByRefObject, MyResume.BO.IExperienceBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IExperienceDAO experienceDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ExperienceBO"/>.
		/// </summary>
		public ExperienceBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			experienceDAO = daoAccess.ExperienceDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="ExperienceBO"/> is reclaimed by garbage collection.
		/// </summary>
		~ExperienceBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			experienceDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Experience> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return experienceDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Experience> lst)
		{
			return experienceDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Experience SelecionarPor(string propertyName, object value)
		{
			return experienceDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Experience SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return experienceDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Experience SelecionarPor(string[] propertyName, object[] value)
		{
			return experienceDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Experience SelecionarPorId(object id)
		{
			return experienceDAO.SelecionarPor("IdExperience",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Experience> Listar(string propertyOrder)
		{
			return experienceDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="experience">O(A) experience.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Experience InserirAlterar(MyResume.OR.Experience experience, Regisoft.Operacao op)
		{
			experienceDAO.ValidaNotNull(experience);
			experienceDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					experience = experienceDAO.CopiarParaPersistente(experience.IdExperience.Value,experience);
				experience = experienceDAO.InserirAlterar(experience,op);
				experienceDAO.CommitTransaction();				
			}			
			catch
			{
				experienceDAO.RollbackTransaction();
				throw;
			}				
			return experience;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="experience">O(A) experience.</param>
		public void Excluir(MyResume.OR.Experience experience)
		{
			experienceDAO.BeginTransaction();
			try 
			{
				experienceDAO.Excluir(experience);
				experienceDAO.CommitTransaction();				
			}			
			catch
			{
				experienceDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Experience> lst)
		{
			experienceDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Experience experience in lst)
				{
					experienceDAO.Excluir(experience);
				}
				experienceDAO.CommitTransaction();				
			}			
			catch
			{
				experienceDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Experience> ListarPor(string dado)
		{
			return experienceDAO.ListarPor(dado);
		}
	}
}
