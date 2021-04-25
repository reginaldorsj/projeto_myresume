
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
	/// Regras de negócio para gerenciamento da classe <see cref='LevelBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class LevelBO : MarshalByRefObject, MyResume.BO.ILevelBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ILevelDAO levelDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="LevelBO"/>.
		/// </summary>
		public LevelBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			levelDAO = daoAccess.LevelDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="LevelBO"/> is reclaimed by garbage collection.
		/// </summary>
		~LevelBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			levelDAO.Dispose();
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Level> lst)
		{
			return levelDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Level SelecionarPor(string propertyName, object value)
		{
			return levelDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Level SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return levelDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Level SelecionarPor(string[] propertyName, object[] value)
		{
			return levelDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Level SelecionarPorId(object id)
		{
			return levelDAO.SelecionarPor("IdLevel",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Level> Listar(string propertyOrder)
		{
			return levelDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="level">O(A) level.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Level InserirAlterar(MyResume.OR.Level level, Regisoft.Operacao op)
		{
			levelDAO.ValidaNotNull(level);
			levelDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					level = levelDAO.CopiarParaPersistente(level.IdLevel.Value,level);
				level = levelDAO.InserirAlterar(level,op);
				levelDAO.CommitTransaction();				
			}			
			catch
			{
				levelDAO.RollbackTransaction();
				throw;
			}				
			return level;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="level">O(A) level.</param>
		public void Excluir(MyResume.OR.Level level)
		{
			levelDAO.BeginTransaction();
			try 
			{
				levelDAO.Excluir(level);
				levelDAO.CommitTransaction();				
			}			
			catch
			{
				levelDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Level> lst)
		{
			levelDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Level level in lst)
				{
					levelDAO.Excluir(level);
				}
				levelDAO.CommitTransaction();				
			}			
			catch
			{
				levelDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Level> ListarPor(string dado)
		{
			return levelDAO.ListarPor(dado);
		}
	}
}
