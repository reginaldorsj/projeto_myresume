
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
	/// Regras de negócio para gerenciamento da classe <see cref='CaptionBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class CaptionBO : MarshalByRefObject, MyResume.BO.ICaptionBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ICaptionDAO captionDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="CaptionBO"/>.
		/// </summary>
		public CaptionBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			captionDAO = daoAccess.CaptionDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="CaptionBO"/> is reclaimed by garbage collection.
		/// </summary>
		~CaptionBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			captionDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Caption> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return captionDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Caption> lst)
		{
			return captionDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Caption SelecionarPor(string propertyName, object value)
		{
			return captionDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Caption SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return captionDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Caption SelecionarPor(string[] propertyName, object[] value)
		{
			return captionDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Caption SelecionarPorId(object id)
		{
			return captionDAO.SelecionarPor("IdCaption",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Caption> Listar(string propertyOrder)
		{
			return captionDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="caption">O(A) caption.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Caption InserirAlterar(MyResume.OR.Caption caption, Regisoft.Operacao op)
		{
			captionDAO.ValidaNotNull(caption);
			Caption _un_caption = captionDAO.SelecionarPor(new string[]{ "IdAboutInfo" }, new object[]{ caption.IdAboutInfo });
			 if ((op == Operacao.Incluir && _un_caption != null) ||(op == Operacao.Alterar && _un_caption != null && _un_caption.IdCaption != caption.IdCaption))
				throw new ExceptionRS("Violação do índice: UN_CAPTION");

			captionDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					caption = captionDAO.CopiarParaPersistente(caption.IdCaption.Value,caption);
				caption = captionDAO.InserirAlterar(caption,op);
				captionDAO.CommitTransaction();				
			}			
			catch
			{
				captionDAO.RollbackTransaction();
				throw;
			}				
			return caption;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="caption">O(A) caption.</param>
		public void Excluir(MyResume.OR.Caption caption)
		{
			captionDAO.BeginTransaction();
			try 
			{
				captionDAO.Excluir(caption);
				captionDAO.CommitTransaction();				
			}			
			catch
			{
				captionDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Caption> lst)
		{
			captionDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Caption caption in lst)
				{
					captionDAO.Excluir(caption);
				}
				captionDAO.CommitTransaction();				
			}			
			catch
			{
				captionDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Caption> ListarPor(string dado)
		{
			return captionDAO.ListarPor(dado);
		}
	}
}
