

using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using MyResume.OR;

namespace MyResume.BO
{
	/// <summary>
	/// Regras de neg?cio para gerenciamento da classe <see cref='IExperienceBO'/>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IExperienceBO : IDisposable
	{
		/// <summary>
		/// Selecionar objeto.
		/// </summary>
		/// <param name="id">O id.</param>
		/// <returns></returns>
		MyResume.OR.Experience SelecionarPorId(object id);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="propertyOrder">A propriedade ordem.</param>
		/// <returns>A lista ordenada.</returns>
		System.Collections.Generic.IList<MyResume.OR.Experience> Listar(string propertyOrder);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O nome da propriedade para utilizar na sele??o.</param>
		/// <param name="value">O valor procurado na propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		MyResume.OR.Experience SelecionarPor(string propertyName, object value);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName1">O nome da primeira propriedade a ser utilizada na sele??o.</param>
		/// <param name="value1">O valor procurado na primeira propriedade.</param>
		/// <param name="propertyName2">O nome da segunda propriedade a ser utlizada na sele??o.</param>
		/// <param name="value2">TO valor procurado na segunda propriedade.</param>
		/// <returns>O objeto selecionado.</returns>
		MyResume.OR.Experience SelecionarPor(string propertyName1, object value1,string propertyName2, object value2);
		/// <summary>
		/// Selecionar um objeto.
		/// </summary>
		/// <param name="propertyName">O array de propriedades para utilizar na sele??o.</param>
		/// <param name="value">O array de valores procurados nas propriedades.</param>
		/// <returns>O objeto selecionado.</returns>
		MyResume.OR.Experience SelecionarPor(string[] propertyName, object[] value);
		/// <summary>
		/// Transforma um lista em um DataTable.
		/// </summary>
		/// <param name="lst">A lista.</param>
		/// <returns>O DataTable.</returns>
		DataTable ToDataTable(IList<MyResume.OR.Experience> lst);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		IList<MyResume.OR.Experience> ListarPorAboutInfo(MyResume.OR.AboutInfo aboutinfo);
		/// <summary>
		/// Insere ou altera um objeto no banco de dados.
		/// </summary>
		/// <param name="experience">O(A) experience.</param>
		/// <param name="op">A opera??o.</param>
		/// <returns>O objeto ap?s a persist?ncia.</returns>
		MyResume.OR.Experience InserirAlterar(MyResume.OR.Experience experience, Regisoft.Operacao op);
		/// <summary>
		/// Exclui o objeto do banco de dados.
		/// </summary>
		/// <param name="experience">O(A) experience.</param>
		void Excluir(MyResume.OR.Experience experience);
		/// <summary>
		/// Exclui uma lista de objeto do banco de dados.
		/// </summary>
		/// <param name="lst">A lista.</param>
		void Excluir(IList<MyResume.OR.Experience> lst);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="dado"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Experience> ListarPor(string dado);
					
	}
}
