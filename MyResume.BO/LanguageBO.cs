
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
	/// Regras de negócio para gerenciamento da classe <see cref='LanguageBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class LanguageBO : MarshalByRefObject, MyResume.BO.ILanguageBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ILanguageDAO languageDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="LanguageBO"/>.
		/// </summary>
		public LanguageBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			languageDAO = daoAccess.LanguageDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="LanguageBO"/> is reclaimed by garbage collection.
		/// </summary>
		~LanguageBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			languageDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Language> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return languageDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="level">O(A) level.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Language> ListarPorLevel(Level level)
		{
			return languageDAO.ListarPorLevel(level);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Language> lst)
		{
			return languageDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Language SelecionarPor(string propertyName, object value)
		{
			return languageDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Language SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return languageDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Language SelecionarPor(string[] propertyName, object[] value)
		{
			return languageDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Language SelecionarPorId(object id)
		{
			return languageDAO.SelecionarPor("IdLanguages",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Language> Listar(string propertyOrder)
		{
			return languageDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="language">O(A) language.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Language InserirAlterar(MyResume.OR.Language language, Regisoft.Operacao op)
		{
			languageDAO.ValidaNotNull(language);
			languageDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					language = languageDAO.CopiarParaPersistente(language.IdLanguage.Value,language);
				language = languageDAO.InserirAlterar(language,op);
				languageDAO.CommitTransaction();				
			}			
			catch
			{
				languageDAO.RollbackTransaction();
				throw;
			}				
			return language;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="language">O(A) language.</param>
		public void Excluir(MyResume.OR.Language language)
		{
			languageDAO.BeginTransaction();
			try 
			{
				languageDAO.Excluir(language);
				languageDAO.CommitTransaction();				
			}			
			catch
			{
				languageDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Language> lst)
		{
			languageDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Language language in lst)
				{
					languageDAO.Excluir(language);
				}
				languageDAO.CommitTransaction();				
			}			
			catch
			{
				languageDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Language> ListarPor(string dado)
		{
			return languageDAO.ListarPor(dado);
		}
	}
}
