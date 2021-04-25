

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using MyResume.OR;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe <see cref='ILanguageDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ILanguageDAO : Regisoft.Camadas.Generic.IBaseDAO<Language, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		IList<Language> ListarPorAboutInfo(AboutInfo aboutinfo);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="level">O(A) level.</param>
		/// <returns>A lista.</returns>
		IList<Language> ListarPorLevel(Level level);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Language> ListarPor(string idaboutinfo);
			
	}
}
