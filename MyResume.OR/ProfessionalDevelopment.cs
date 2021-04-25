using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class ProfessionalDevelopment
	{
		

		
		#region Private Members		

		private long? _id_professional_development; 
		private AboutInfo _id_about_info; 
		private string _name; 
		private string _issuing_organization; 
		private int _issue_month; 
		private int _issue_year; 
		private string _credential_url; 		
		#endregion

		
		
		#region Constructor

		public ProfessionalDevelopment()
		{
			_id_professional_development = null; 
			_id_about_info = null; 
			_name = null;
			_issuing_organization = null;
			_issue_month = 0;
			_issue_year = 0;
			_credential_url = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdProfessionalDevelopment
		{
			get
			{ 
				return _id_professional_development;
			}
			set
			{
				_id_professional_development = value;
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
			
		public virtual string Name
		{
			get
			{ 
				return _name;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Name'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Name'");					

				_name = value;
			}
		}
			
		public virtual string IssuingOrganization
		{
			get
			{ 
				return _issuing_organization;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'IssuingOrganization'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'IssuingOrganization'");					

				_issuing_organization = value;
			}
		}
			
		public virtual int IssueMonth
		{
			get
			{ 
				return _issue_month;
			}
			set
			{
				_issue_month = value;
			}

		}
			
		public virtual int IssueYear
		{
			get
			{ 
				return _issue_year;
			}
			set
			{
				_issue_year = value;
			}

		}
			
		public virtual string CredentialUrl
		{
			get
			{ 
				return _credential_url;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'CredentialUrl'");					

				_credential_url = value;
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
			ProfessionalDevelopment castObj = (ProfessionalDevelopment)obj; 
			return ( castObj != null ) &&
				( this._id_professional_development == castObj.IdProfessionalDevelopment );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_professional_development.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
