
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
	/// Regras de negócio para gerenciamento da classe <see cref='AboutInfoBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class AboutInfoBO : MarshalByRefObject, MyResume.BO.IAboutInfoBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected IAboutInfoDAO aboutinfoDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="AboutInfoBO"/>.
		/// </summary>
		public AboutInfoBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			aboutinfoDAO = daoAccess.AboutInfoDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="AboutInfoBO"/> is reclaimed by garbage collection.
		/// </summary>
		~AboutInfoBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			aboutinfoDAO.Dispose();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.AboutInfo> lst)
		{
			return aboutinfoDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.AboutInfo SelecionarPor(string propertyName, object value)
		{
			return aboutinfoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.AboutInfo SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return aboutinfoDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.AboutInfo SelecionarPor(string[] propertyName, object[] value)
		{
			return aboutinfoDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.AboutInfo SelecionarPorId(object id)
		{
			return aboutinfoDAO.SelecionarPor("IdAboutInfo",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.AboutInfo> Listar(string propertyOrder)
		{
			return aboutinfoDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.AboutInfo InserirAlterar(MyResume.OR.AboutInfo aboutinfo, Regisoft.Operacao op)
		{
			aboutinfoDAO.ValidaNotNull(aboutinfo);
			aboutinfoDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					aboutinfo = aboutinfoDAO.CopiarParaPersistente(aboutinfo.IdAboutInfo.Value,aboutinfo);
				aboutinfo = aboutinfoDAO.InserirAlterar(aboutinfo,op);
				aboutinfoDAO.CommitTransaction();				
			}			
			catch
			{
				aboutinfoDAO.RollbackTransaction();
				throw;
			}				
			return aboutinfo;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		public void Excluir(MyResume.OR.AboutInfo aboutinfo)
		{
			aboutinfoDAO.BeginTransaction();
			try 
			{
				aboutinfoDAO.Excluir(aboutinfo);
				aboutinfoDAO.CommitTransaction();				
			}			
			catch
			{
				aboutinfoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.AboutInfo> lst)
		{
			aboutinfoDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.AboutInfo aboutinfo in lst)
				{
					aboutinfoDAO.Excluir(aboutinfo);
				}
				aboutinfoDAO.CommitTransaction();				
			}			
			catch
			{
				aboutinfoDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<AboutInfo> ListarPor(string dado)
		{
			return aboutinfoDAO.ListarPor(dado);
		}
	}
}
