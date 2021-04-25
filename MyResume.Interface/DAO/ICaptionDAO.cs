

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using MyResume.OR;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe <see cref='ICaptionDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ICaptionDAO : Regisoft.Camadas.Generic.IBaseDAO<Caption, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="aboutinfo">O(A) aboutinfo.</param>
		/// <returns>A lista.</returns>
		IList<Caption> ListarPorAboutInfo(AboutInfo aboutinfo);
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="idaboutinfo"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Caption> ListarPor(string idaboutinfo);
			
	}
}
