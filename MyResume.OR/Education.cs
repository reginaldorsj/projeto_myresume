using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Education
	{
		

		
		#region Private Members		

		private long? _id_education; 
		private AboutInfo _id_about_info; 
		private string _school; 
		private string _degree; 
		private string _field_of_study; 
		private int _start_year; 
		private int _end_year; 		
		#endregion

		
		
		#region Constructor

		public Education()
		{
			_id_education = null; 
			_id_about_info = null; 
			_school = null;
			_degree = null;
			_field_of_study = null;
			_start_year = 0;
			_end_year = 0;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdEducation
		{
			get
			{ 
				return _id_education;
			}
			set
			{
				_id_education = value;
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
			
		public virtual string School
		{
			get
			{ 
				return _school;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'School'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'School'");					

				_school = value;
			}
		}
			
		public virtual string Degree
		{
			get
			{ 
				return _degree;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Degree'");
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Degree'");					

				_degree = value;
			}
		}
			
		public virtual string FieldOfStudy
		{
			get
			{ 
				return _field_of_study;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'FieldOfStudy'");					

				_field_of_study = value;
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
			
		public virtual int EndYear
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
			Education castObj = (Education)obj; 
			return ( castObj != null ) &&
				( this._id_education == castObj.IdEducation );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_education.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
