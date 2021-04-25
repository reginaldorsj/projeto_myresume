using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Level
	{
		

		
		#region Private Members		

		private long? _id_level; 
		private string _description; 		
		#endregion

		
		
		#region Constructor

		public Level()
		{
			_id_level = null; 
			_description = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdLevel
		{
			get
			{ 
				return _id_level;
			}
			set
			{
				_id_level = value;
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
				
				if(  value.Length > 30)
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
			Level castObj = (Level)obj; 
			return ( castObj != null ) &&
				( this._id_level == castObj.IdLevel );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_level.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
