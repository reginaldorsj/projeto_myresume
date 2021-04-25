using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Caption
	{
		

		
		#region Private Members		

		private long? _id_caption; 
		private AboutInfo _id_about_info; 
		private string _about; 
		private string _skills; 
		private string _experience; 
		private string _education; 
		private string _certifications; 
		private string _languages; 
		private string _contact; 		
		#endregion

		
		
		#region Constructor

		public Caption()
		{
			_id_caption = null; 
			_id_about_info = null; 
			_about = null;
			_skills = null;
			_experience = null;
			_education = null;
			_certifications = null;
			_languages = null;
			_contact = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdCaption
		{
			get
			{ 
				return _id_caption;
			}
			set
			{
				_id_caption = value;
			}

		}
			
		public virtual AboutInfo IdAboutInfo
		{
			get
			{ 
				return _id_about_info;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdAboutInfo'");

				_id_about_info = value;
			}

		}
			
		public virtual string About
		{
			get
			{ 
				return _about;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'About'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'About'");					

				_about = value;
			}
		}
			
		public virtual string Skills
		{
			get
			{ 
				return _skills;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Skills'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Skills'");					

				_skills = value;
			}
		}
			
		public virtual string Experience
		{
			get
			{ 
				return _experience;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Experience'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Experience'");					

				_experience = value;
			}
		}
			
		public virtual string Education
		{
			get
			{ 
				return _education;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Education'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Education'");					

				_education = value;
			}
		}
			
		public virtual string Certifications
		{
			get
			{ 
				return _certifications;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Certifications'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Certifications'");					

				_certifications = value;
			}
		}
			
		public virtual string Languages
		{
			get
			{ 
				return _languages;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Languages'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Languages'");					

				_languages = value;
			}
		}
			
		public virtual string Contact
		{
			get
			{ 
				return _contact;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Contact'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Contact'");					

				_contact = value;
			}
		}
			
		#endregion 
		
		
		#region Public Functions

		#endregion

		
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			Caption castObj = (Caption)obj; 
			return ( castObj != null ) &&
				( this._id_caption == castObj.IdCaption );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_caption.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
