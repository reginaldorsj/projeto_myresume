

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using MyResume.OR;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe <see cref='IAboutInfoDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface IAboutInfoDAO : Regisoft.Camadas.Generic.IBaseDAO<AboutInfo, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="firstname"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<AboutInfo> ListarPor(string firstname);
			
	}
}
