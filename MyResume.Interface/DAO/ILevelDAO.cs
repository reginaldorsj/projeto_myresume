

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using Regisoft.Camadas.Generic;
using MyResume.OR;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe <see cref='ILevelDAO'/> para acesso a dados
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	public interface ILevelDAO : Regisoft.Camadas.Generic.IBaseDAO<Level, long>
	{
		/// <summary>
		/// Listar objetos.
		/// </summary>
		/// <param name="description"> O dado para pesquisa.</param>
		/// <returns>A lista.</returns>
		IList<Level> ListarPor(string description);
			
	}
}
