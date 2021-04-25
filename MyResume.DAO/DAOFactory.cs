
using System;
using Microsoft.Practices.Unity;

namespace MyResume.DAO
{
	/// <summary>
	/// Classe que expõe os DAO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public class DAOFactory : MarshalByRefObject, MyResume.DAO.IDAOFactory
    {
		/// <summary>
		/// Container para injeção de dependência.
		/// </summary>
        private UnityContainer unityContainer;
		/// <summary>
		/// Inicializa uma instância de <see cref="DAOFactory"/>.
		/// </summary>
        public DAOFactory() 
        {			
			Inicialize();
		}
		/// <summary>
		/// Inicializa esta instância.
		/// </summary>
		private void Inicialize() 
		{
			unityContainer = new UnityContainer();
			unityContainer.RegisterType<IAboutInfoDAO, AboutInfoDAO>();
			unityContainer.RegisterType<ICaptionDAO, CaptionDAO>();
			unityContainer.RegisterType<IEducationDAO, EducationDAO>();
			unityContainer.RegisterType<IExperienceDAO, ExperienceDAO>();
			unityContainer.RegisterType<ILanguageDAO, LanguageDAO>();
			unityContainer.RegisterType<ILevelDAO, LevelDAO>();
			unityContainer.RegisterType<IProfessionalDevelopmentDAO, ProfessionalDevelopmentDAO>();
			unityContainer.RegisterType<ISkillDAO, SkillDAO>();
		}
		#region IDAOFactory Members
		/// <summary>
		/// Acesso a classe AboutInfoDAO.
		/// </summary>
		/// <returns></returns>
        public IAboutInfoDAO AboutInfoDAO()
        {
			return unityContainer.Resolve<AboutInfoDAO>();
        }
		/// <summary>
		/// Acesso a classe CaptionDAO.
		/// </summary>
		/// <returns></returns>
        public ICaptionDAO CaptionDAO()
        {
			return unityContainer.Resolve<CaptionDAO>();
        }
		/// <summary>
		/// Acesso a classe EducationDAO.
		/// </summary>
		/// <returns></returns>
        public IEducationDAO EducationDAO()
        {
			return unityContainer.Resolve<EducationDAO>();
        }
		/// <summary>
		/// Acesso a classe ExperienceDAO.
		/// </summary>
		/// <returns></returns>
        public IExperienceDAO ExperienceDAO()
        {
			return unityContainer.Resolve<ExperienceDAO>();
        }
		/// <summary>
		/// Acesso a classe LanguageDAO.
		/// </summary>
		/// <returns></returns>
        public ILanguageDAO LanguageDAO()
        {
			return unityContainer.Resolve<LanguageDAO>();
        }
		/// <summary>
		/// Acesso a classe LevelDAO.
		/// </summary>
		/// <returns></returns>
        public ILevelDAO LevelDAO()
        {
			return unityContainer.Resolve<LevelDAO>();
        }
		/// <summary>
		/// Acesso a classe ProfessionalDevelopmentDAO.
		/// </summary>
		/// <returns></returns>
        public IProfessionalDevelopmentDAO ProfessionalDevelopmentDAO()
        {
			return unityContainer.Resolve<ProfessionalDevelopmentDAO>();
        }
		/// <summary>
		/// Acesso a classe SkillDAO.
		/// </summary>
		/// <returns></returns>
        public ISkillDAO SkillDAO()
        {
			return unityContainer.Resolve<SkillDAO>();
        }
		public void Dispose()
		{
			// Nada
		}

        #endregion
		
    }
}
