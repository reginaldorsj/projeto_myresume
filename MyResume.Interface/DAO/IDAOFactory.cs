
using System;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe que expõe os DAO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public interface IDAOFactory : IDisposable
    {
		/// <summary>
		/// Acesso a classe AboutInfoDAO.
		/// </summary>
		/// <returns></returns>
		IAboutInfoDAO AboutInfoDAO();
		/// <summary>
		/// Acesso a classe CaptionDAO.
		/// </summary>
		/// <returns></returns>
		ICaptionDAO CaptionDAO();
		/// <summary>
		/// Acesso a classe EducationDAO.
		/// </summary>
		/// <returns></returns>
		IEducationDAO EducationDAO();
		/// <summary>
		/// Acesso a classe ExperienceDAO.
		/// </summary>
		/// <returns></returns>
		IExperienceDAO ExperienceDAO();
		/// <summary>
		/// Acesso a classe LanguageDAO.
		/// </summary>
		/// <returns></returns>
		ILanguageDAO LanguageDAO();
		/// <summary>
		/// Acesso a classe LevelDAO.
		/// </summary>
		/// <returns></returns>
		ILevelDAO LevelDAO();
		/// <summary>
		/// Acesso a classe ProfessionalDevelopmentDAO.
		/// </summary>
		/// <returns></returns>
		IProfessionalDevelopmentDAO ProfessionalDevelopmentDAO();
		/// <summary>
		/// Acesso a classe SkillDAO.
		/// </summary>
		/// <returns></returns>
		ISkillDAO SkillDAO();

    }
}
