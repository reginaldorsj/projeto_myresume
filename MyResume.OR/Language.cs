using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Language
	{
		

		
		#region Private Members		

		private long? _id_language; 
		private AboutInfo _id_about_info; 
		private string _name; 
		private Level _id_level; 		
		#endregion

		
		
		#region Constructor

		public Language()
		{
			_id_language = null; 
			_id_about_info = null; 
			_name = null;
			_id_level = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdLanguage
		{
			get
			{ 
				return _id_language;
			}
			set
			{
				_id_language = value;
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
				
				if(  value.Length > 40)
					throw new ExceptionRS("Valor ultrapassa limite em 'Name'");					

				_name = value;
			}
		}
			
		public virtual Level IdLevel
		{
			get
			{ 
				return _id_level;
			}
			set
			{
				if( value == null )
					throw new ExceptionRS("Informe 'IdLevel'");

				_id_level = value;
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
			Language castObj = (Language)obj; 
			return ( castObj != null ) &&
				( this._id_language == castObj.IdLanguage );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_language.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
