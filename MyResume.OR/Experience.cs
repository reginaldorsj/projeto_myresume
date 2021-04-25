using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Experience
	{
		

		
		#region Private Members		

		private long? _id_experience; 
		private AboutInfo _id_about_info; 
		private string _title; 
		private string _company; 
		private string _location; 
		private int _start_month; 
		private int _start_year; 
		private int? _end_month; 
		private int? _end_year; 
		private string _description; 		
		#endregion

		
		
		#region Constructor

		public Experience()
		{
			_id_experience = null; 
			_id_about_info = null; 
			_title = null;
			_company = null;
			_location = null;
			_start_month = 0;
			_start_year = 0;
			_end_month = null; 
			_end_year = null; 
			_description = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdExperience
		{
			get
			{ 
				return _id_experience;
			}
			set
			{
				_id_experience = value;
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
			
		public virtual string Title
		{
			get
			{ 
				return _title;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Title'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Title'");					

				_title = value;
			}
		}
			
		public virtual string Company
		{
			get
			{ 
				return _company;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Company'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Company'");					

				_company = value;
			}
		}
			
		public virtual string Location
		{
			get
			{ 
				return _location;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Location'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Location'");					

				_location = value;
			}
		}
			
		public virtual int StartMonth
		{
			get
			{ 
				return _start_month;
			}
			set
			{
				_start_month = value;
			}

		}
			
		public virtual int StartYear
		{
			get
			{ 
				return _start_year;
			}
			set
			{
				_start_year = value;
			}

		}
			
		public virtual int? EndMonth
		{
			get
			{ 
				return _end_month;
			}
			set
			{
				_end_month = value;
			}

		}
			
		public virtual int? EndYear
		{
			get
			{ 
				return _end_year;
			}
			set
			{
				_end_year = value;
			}

		}
			
		public virtual string Description
		{
			get
			{ 
				return _description;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Description'");
				
				if(  value.Length > 3000)
					throw new ExceptionRS("Valor ultrapassa limite em 'Description'");					

				_description = value;
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
			Experience castObj = (Experience)obj; 
			return ( castObj != null ) &&
				( this._id_experience == castObj.IdExperience );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_experience.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
