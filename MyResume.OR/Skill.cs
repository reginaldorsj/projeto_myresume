using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class Skill
	{
		

		
		#region Private Members		

		private long? _id_skill; 
		private AboutInfo _id_about_info; 
		private string _name; 
		private int _rate; 
		private int? _order_number; 		
		#endregion

		
		
		#region Constructor

		public Skill()
		{
			_id_skill = null; 
			_id_about_info = null; 
			_name = null;
			_rate = 0;
			_order_number = null; 
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdSkill
		{
			get
			{ 
				return _id_skill;
			}
			set
			{
				_id_skill = value;
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
				
				if(  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'Name'");					

				_name = value;
			}
		}
			
		public virtual int Rate
		{
			get
			{ 
				return _rate;
			}
			set
			{
				_rate = value;
			}

		}
			
		public virtual int? OrderNumber
		{
			get
			{ 
				return _order_number;
			}
			set
			{
				_order_number = value;
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
			Skill castObj = (Skill)obj; 
			return ( castObj != null ) &&
				( this._id_skill == castObj.IdSkill );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_skill.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
