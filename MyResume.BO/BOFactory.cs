
using System;
using Microsoft.Practices.Unity;

namespace MyResume.BO
{
	/// <summary>
	/// Classe que expõe os BO's.
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
    public class BOFactory : MarshalByRefObject, MyResume.BO.IBOFactory
    {
		/// <summary>
		/// Container para injeção de dependência.
		/// </summary>
        private UnityContainer unityContainer;
		/// <summary>
		/// Instância da classe para acesso estático.
		/// </summary>
        private static BOFactory instance = null;

		/// <summary>
		/// Inicializa uma instância de <see cref="BOFactory"/>.
		/// </summary>
		public BOFactory()
		{
			Inicialize();
		}

		/// <summary>
		/// Lê/Cria uma instância da classe.
		/// </summary>
		/// <returns></returns>
        public static BOFactory getInstance()
        {
            if (instance == null)
            {
                instance = new BOFactory();
            }
            return instance;
        }
		/// <summary>
		/// Inicializa esta instância.
		/// </summary>
		private void Inicialize() 
		{
			unityContainer = new UnityContainer();
			unityContainer.RegisterType<IAboutInfoBO, AboutInfoBO>();
			unityContainer.RegisterType<ICaptionBO, CaptionBO>();
			unityContainer.RegisterType<IEducationBO, EducationBO>();
			unityContainer.RegisterType<IExperienceBO, ExperienceBO>();
			unityContainer.RegisterType<ILanguageBO, LanguageBO>();
			unityContainer.RegisterType<ILevelBO, LevelBO>();
			unityContainer.RegisterType<IProfessionalDevelopmentBO, ProfessionalDevelopmentBO>();
			unityContainer.RegisterType<ISkillBO, SkillBO>();
		}

		#region IDAOFactory Members
		/// <summary>
		/// Acesso a classe AboutInfoBO.
		/// </summary>
		/// <returns></returns>
        public IAboutInfoBO AboutInfoBO()
        {
			return unityContainer.Resolve<AboutInfoBO>();
        }
		/// <summary>
		/// Acesso a classe CaptionBO.
		/// </summary>
		/// <returns></returns>
        public ICaptionBO CaptionBO()
        {
			return unityContainer.Resolve<CaptionBO>();
        }
		/// <summary>
		/// Acesso a classe EducationBO.
		/// </summary>
		/// <returns></returns>
        public IEducationBO EducationBO()
        {
			return unityContainer.Resolve<EducationBO>();
        }
		/// <summary>
		/// Acesso a classe ExperienceBO.
		/// </summary>
		/// <returns></returns>
        public IExperienceBO ExperienceBO()
        {
			return unityContainer.Resolve<ExperienceBO>();
        }
		/// <summary>
		/// Acesso a classe LanguageBO.
		/// </summary>
		/// <returns></returns>
        public ILanguageBO LanguageBO()
        {
			return unityContainer.Resolve<LanguageBO>();
        }
		/// <summary>
		/// Acesso a classe LevelBO.
		/// </summary>
		/// <returns></returns>
        public ILevelBO LevelBO()
        {
			return unityContainer.Resolve<LevelBO>();
        }
		/// <summary>
		/// Acesso a classe ProfessionalDevelopmentBO.
		/// </summary>
		/// <returns></returns>
        public IProfessionalDevelopmentBO ProfessionalDevelopmentBO()
        {
			return unityContainer.Resolve<ProfessionalDevelopmentBO>();
        }
		/// <summary>
		/// Acesso a classe SkillBO.
		/// </summary>
		/// <returns></returns>
        public ISkillBO SkillBO()
        {
			return unityContainer.Resolve<SkillBO>();
        }

        #endregion
		
    }
}
