
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
	/// Regras de negócio para gerenciamento da classe <see cref='SkillBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public class SkillBO : MarshalByRefObject, MyResume.BO.ISkillBO
	{
		/// <summary>
		/// Define o objeto de acesso a dados.
		/// </summary>
		protected ISkillDAO skillDAO;
	
		/// <summary>
		/// Inicializa uma instância da classe <see cref="SkillBO"/>.
		/// </summary>
		public SkillBO()
            : base()
        {
            IDAOFactory daoAccess = DAOAccess.GetDAOFactory();
			skillDAO = daoAccess.SkillDAO();
        }
		/// <summary>
		/// Releases unmanaged resources and performs other cleanup operations before the
		/// <see cref="SkillBO"/> is reclaimed by garbage collection.
		/// </summary>
		~SkillBO()
		{
			Dispose();
		}
		/// <summary>
		/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
		/// </summary>
		public void Dispose()
		{
			skillDAO.Dispose();
		}
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		public IList<MyResume.OR.Skill> ListarPorAboutInfo(AboutInfo aboutinfo)
		{
			return skillDAO.ListarPorAboutInfo(aboutinfo);
		}
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		public DataTable ToDataTable(IList<MyResume.OR.Skill> lst)
		{
			return skillDAO.ToDataTable(lst);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na seleção.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Skill SelecionarPor(string propertyName, object value)
		{
			return skillDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na seleção.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na seleção.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Skill SelecionarPor(string propertyName1, object value1, string propertyName2, object value2)
		{
			return skillDAO.SelecionarPor(propertyName1, value1, propertyName2, value2);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na seleção.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Skill SelecionarPor(string[] propertyName, object[] value)
		{
			return skillDAO.SelecionarPor(propertyName, value);
		}
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="id">O ID do objeto.</param>
		/// <returns>O objeto selecionado.</returns>
		public MyResume.OR.Skill SelecionarPorId(object id)
		{
			return skillDAO.SelecionarPor("IdSkill",Convert.ChangeType(id,typeof(long)));
		}
		/// <summary>
		/// Listar objetos por uma propriedade específica.
		/// </summary>
		/// <param name="propertyOrder">A propriedade que ordena a seleção.</param>
		/// <returns>A lista ordenada.</returns>
		public IList<MyResume.OR.Skill> Listar(string propertyOrder)
		{
			return skillDAO.Listar(propertyOrder);
		}
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="skill">O(A) skill.</param>
		/// <param name="op">A operação.</param>
		/// <returns>O objeto após a persistência.</returns>
		public MyResume.OR.Skill InserirAlterar(MyResume.OR.Skill skill, Regisoft.Operacao op)
		{
			skillDAO.ValidaNotNull(skill);
			skillDAO.BeginTransaction();
			try 
			{
				if (op==Regisoft.Operacao.Alterar)
					skill = skillDAO.CopiarParaPersistente(skill.IdSkill.Value,skill);
				skill = skillDAO.InserirAlterar(skill,op);
				skillDAO.CommitTransaction();				
			}			
			catch
			{
				skillDAO.RollbackTransaction();
				throw;
			}				
			return skill;
		}
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="skill">O(A) skill.</param>
		public void Excluir(MyResume.OR.Skill skill)
		{
			skillDAO.BeginTransaction();
			try 
			{
				skillDAO.Excluir(skill);
				skillDAO.CommitTransaction();				
			}			
			catch
			{
				skillDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Registro em uso.");
			}
		}
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		public void Excluir(IList<MyResume.OR.Skill> lst)
		{
			skillDAO.BeginTransaction();
			try 
			{
				foreach (MyResume.OR.Skill skill in lst)
				{
					skillDAO.Excluir(skill);
				}
				skillDAO.CommitTransaction();				
			}			
			catch
			{
				skillDAO.RollbackTransaction();
				throw new ExceptionRS("Impossivel excluir. Na lista informada possui registro em uso.");
			}
		}			
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		public IList<Skill> ListarPor(string dado)
		{
			return skillDAO.ListarPor(dado);
		}
	}
}
