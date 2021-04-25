
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
	/// Regras de negócio para gerenciamento da classe <see cref='EducationBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class EducationBO : MarshalByRefObject, MyResume.BO.IEducationBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IEducationDAO educationDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="EducationBO"/>.
		/// </summary>
		public EducationBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			educationDAO = daoAccess.EducationDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="EducationBO"/> is reclaimed by garbage collection.
		/// </summary>
		~EducationBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			educationDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Education> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return educationDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Education> lst)
		{
			return educationDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Education SelecionarPor(string propertyName, object value)
		{
			return educationDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Education SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return educationDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Education SelecionarPor(string[] propertyName, object[] value)
		{
			return educationDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Education SelecionarPorId(object id)
		{
			return educationDAO.SelecionarPor("IdEducation",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Education> Listar(string propertyOrder)
		{
			return educationDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="education">O(A) education.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Education InserirAlterar(MyResume.OR.Education education, Regisoft.Operacao op)
		{
			educationDAO.ValidaNotNull(education);
			educationDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					education = educationDAO.CopiarParaPersistente(education.IdEducation.Value,education);
				education = educationDAO.InserirAlterar(education,op);
				educationDAO.CommitTransaction();				
			}			
			catch
			{
				educationDAO.RollbackTransaction();
				throw;
			}				
			return education;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="education">O(A) education.</param>
		public void Excluir(MyResume.OR.Education education)
		{
			educationDAO.BeginTransaction();
			try 
			{
				educationDAO.Excluir(education);
				educationDAO.CommitTransaction();				
			}			
			catch
			{
				educationDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Education> lst)
		{
			educationDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Education education in lst)
				{
					educationDAO.Excluir(education);
				}
				educationDAO.CommitTransaction();				
			}			
			catch
			{
				educationDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Education> ListarPor(string dado)
		{
			return educationDAO.ListarPor(dado);
		}
	}
}
