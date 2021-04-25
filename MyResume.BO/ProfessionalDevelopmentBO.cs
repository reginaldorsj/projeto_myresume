
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
	/// Regras de negócio para gerenciamento da classe <see cref='ProfessionalDevelopmentBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class ProfessionalDevelopmentBO : MarshalByRefObject, MyResume.BO.IProfessionalDevelopmentBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IProfessionalDevelopmentDAO professionaldevelopmentDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="ProfessionalDevelopmentBO"/>.
		/// </summary>
		public ProfessionalDevelopmentBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			professionaldevelopmentDAO = daoAccess.ProfessionalDevelopmentDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="ProfessionalDevelopmentBO"/> is reclaimed by garbage collection.
		/// </summary>
		~ProfessionalDevelopmentBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			professionaldevelopmentDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.ProfessionalDevelopment> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return professionaldevelopmentDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.ProfessionalDevelopment> lst)
		{
			return professionaldevelopmentDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.ProfessionalDevelopment SelecionarPor(string propertyName, object value)
		{
			return professionaldevelopmentDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.ProfessionalDevelopment SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return professionaldevelopmentDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.ProfessionalDevelopment SelecionarPor(string[] propertyName, object[] value)
		{
			return professionaldevelopmentDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.ProfessionalDevelopment SelecionarPorId(object id)
		{
			return professionaldevelopmentDAO.SelecionarPor("IdProfessionalDevelopment",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.ProfessionalDevelopment> Listar(string propertyOrder)
		{
			return professionaldevelopmentDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="professionaldevelopment">O(A) professionaldevelopment.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.ProfessionalDevelopment InserirAlterar(MyResume.OR.ProfessionalDevelopment professionaldevelopment, Regisoft.Operacao op)
		{
			professionaldevelopmentDAO.ValidaNotNull(professionaldevelopment);
			professionaldevelopmentDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					professionaldevelopment = professionaldevelopmentDAO.CopiarParaPersistente(professionaldevelopment.IdProfessionalDevelopment.Value,professionaldevelopment);
				professionaldevelopment = professionaldevelopmentDAO.InserirAlterar(professionaldevelopment,op);
				professionaldevelopmentDAO.CommitTransaction();				
			}			
			catch
			{
				professionaldevelopmentDAO.RollbackTransaction();
				throw;
			}				
			return professionaldevelopment;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="professionaldevelopment">O(A) professionaldevelopment.</param>
		public void Excluir(MyResume.OR.ProfessionalDevelopment professionaldevelopment)
		{
			professionaldevelopmentDAO.BeginTransaction();
			try 
			{
				professionaldevelopmentDAO.Excluir(professionaldevelopment);
				professionaldevelopmentDAO.CommitTransaction();				
			}			
			catch
			{
				professionaldevelopmentDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.ProfessionalDevelopment> lst)
		{
			professionaldevelopmentDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.ProfessionalDevelopment professionaldevelopment in lst)
				{
					professionaldevelopmentDAO.Excluir(professionaldevelopment);
				}
				professionaldevelopmentDAO.CommitTransaction();				
			}			
			catch
			{
				professionaldevelopmentDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<ProfessionalDevelopment> ListarPor(string dado)
		{
			return professionaldevelopmentDAO.ListarPor(dado);
		}
	}
}
