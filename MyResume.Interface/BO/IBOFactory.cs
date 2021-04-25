
using System;

namespace MyResume.BO
{
	/// <summary>
	/// Classe que expõe os BO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public interface IBOFactory
    {
		/// <summary>
		/// Acesso a classe AboutInfoBO.
		/// </summary>
		/// <returns></returns>
		IAboutInfoBO AboutInfoBO();
		/// <summary>
		/// Acesso a classe CaptionBO.
		/// </summary>
		/// <returns></returns>
		ICaptionBO CaptionBO();
		/// <summary>
		/// Acesso a classe EducationBO.
		/// </summary>
		/// <returns></returns>
		IEducationBO EducationBO();
		/// <summary>
		/// Acesso a classe ExperienceBO.
		/// </summary>
		/// <returns></returns>
		IExperienceBO ExperienceBO();
		/// <summary>
		/// Acesso a classe LanguageBO.
		/// </summary>
		/// <returns></returns>
		ILanguageBO LanguageBO();
		/// <summary>
		/// Acesso a classe LevelBO.
		/// </summary>
		/// <returns></returns>
		ILevelBO LevelBO();
		/// <summary>
		/// Acesso a classe ProfessionalDevelopmentBO.
		/// </summary>
		/// <returns></returns>
		IProfessionalDevelopmentBO ProfessionalDevelopmentBO();
		/// <summary>
		/// Acesso a classe SkillBO.
		/// </summary>
		/// <returns></returns>
		ISkillBO SkillBO();

    }
}
