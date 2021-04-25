using System;
using Regisoft;
using System.Collections.Generic ;

namespace MyResume.OR
{
	/// <summary>
	/// Gerado por RSClass - Gerador de Classes
	/// </summary>
	[Serializable]
	public /*sealed*/ class AboutInfo
	{
		

		
		#region Private Members		

		private long? _id_about_info; 
		private string _idiom; 
		private string _first_name; 
		private string _last_name; 
		private string _head_line; 
		private string _country; 
		private string _location_in_this_country; 
		private string _summary; 
		private string _facebook_url; 
		private string _linkedin_url; 
		private string _github_url; 
		private string _email; 
		private string _cell_phone; 
		private string _skill_summary; 
		private string _contact_summary; 
		private string _name_contact_field; 
		private string _email_contact_field; 
		private string _phone_contact_field; 
		private string _comments_contact_field; 
		private string _send_message_contactt_button; 		
		#endregion

		
		
		#region Constructor

		public AboutInfo()
		{
			_id_about_info = null; 
			_idiom = null;
			_first_name = null;
			_last_name = null;
			_head_line = null;
			_country = null;
			_location_in_this_country = null;
			_summary = null;
			_facebook_url = null;
			_linkedin_url = null;
			_github_url = null;
			_email = null;
			_cell_phone = null;
			_skill_summary = null;
			_contact_summary = null;
			_name_contact_field = null;
			_email_contact_field = null;
			_phone_contact_field = null;
			_comments_contact_field = null;
			_send_message_contactt_button = null;
		}
		#endregion // End of Default ( Empty ) Class Constuctor

		
		
		#region Public Properties
			
		public virtual long? IdAboutInfo
		{
			get
			{ 
				return _id_about_info;
			}
			set
			{
				_id_about_info = value;
			}

		}
			






		public virtual string Idiom
		{
			get
			{ 
				return _idiom;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Idiom'");
				
				if(  value.Length > 2)
					throw new ExceptionRS("Valor ultrapassa limite em 'Idiom'");					

				_idiom = value;
			}
		}
			
		public virtual string FirstName
		{
			get
			{ 
				return _first_name;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'FirstName'");
				
				if(  value.Length > 50)
					throw new ExceptionRS("Valor ultrapassa limite em 'FirstName'");					

				_first_name = value;
			}
		}
			
		public virtual string LastName
		{
			get
			{ 
				return _last_name;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'LastName'");
				
				if(  value.Length > 50)
					throw new ExceptionRS("Valor ultrapassa limite em 'LastName'");					

				_last_name = value;
			}
		}
			
		public virtual string HeadLine
		{
			get
			{ 
				return _head_line;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'HeadLine'");
				
				if(  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'HeadLine'");					

				_head_line = value;
			}
		}
			
		public virtual string Country
		{
			get
			{ 
				return _country;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'Country'");
				
				if(  value.Length > 40)
					throw new ExceptionRS("Valor ultrapassa limite em 'Country'");					

				_country = value;
			}
		}
			
		public virtual string LocationInThisCountry
		{
			get
			{ 
				return _location_in_this_country;
			}

			set	
			{	
				if( value == null )
					throw new ExceptionRS("Informe 'LocationInThisCountry'");
				
				if(  value.Length > 40)
					throw new ExceptionRS("Valor ultrapassa limite em 'LocationInThisCountry'");					

				_location_in_this_country = value;
			}
		}
			
		public virtual string Summary
		{
			get
			{ 
				return _summary;
			}

			set	
			{	
				if(  value != null &&  value.Length > 5000)
					throw new ExceptionRS("Valor ultrapassa limite em 'Summary'");					

				_summary = value;
			}
		}
			
		public virtual string FacebookUrl
		{
			get
			{ 
				return _facebook_url;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'FacebookUrl'");					

				_facebook_url = value;
			}
		}
			
		public virtual string LinkedinUrl
		{
			get
			{ 
				return _linkedin_url;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'LinkedinUrl'");					

				_linkedin_url = value;
			}
		}
			
		public virtual string GithubUrl
		{
			get
			{ 
				return _github_url;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'GithubUrl'");					

				_github_url = value;
			}
		}
			
		public virtual string Email
		{
			get
			{ 
				return _email;
			}

			set	
			{	
				if(  value != null &&  value.Length > 100)
					throw new ExceptionRS("Valor ultrapassa limite em 'Email'");					

				_email = value;
			}
		}
			
		public virtual string CellPhone
		{
			get
			{ 
				return _cell_phone;
			}

			set	
			{	
				if(  value != null &&  value.Length > 19)
					throw new ExceptionRS("Valor ultrapassa limite em 'CellPhone'");					

				_cell_phone = value;
			}
		}
			
		public virtual string SkillSummary
		{
			get
			{ 
				return _skill_summary;
			}

			set	
			{	
				if(  value != null &&  value.Length > 5000)
					throw new ExceptionRS("Valor ultrapassa limite em 'SkillSummary'");					

				_skill_summary = value;
			}
		}
			
		public virtual string ContactSummary
		{
			get
			{ 
				return _contact_summary;
			}

			set	
			{	
				if(  value != null &&  value.Length > 5000)
					throw new ExceptionRS("Valor ultrapassa limite em 'ContactSummary'");					

				_contact_summary = value;
			}
		}
			
		public virtual string NameContactField
		{
			get
			{ 
				return _name_contact_field;
			}

			set	
			{	
				if(  value != null &&  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'NameContactField'");					

				_name_contact_field = value;
			}
		}
			
		public virtual string EmailContactField
		{
			get
			{ 
				return _email_contact_field;
			}

			set	
			{	
				if(  value != null &&  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'EmailContactField'");					

				_email_contact_field = value;
			}
		}
			
		public virtual string PhoneContactField
		{
			get
			{ 
				return _phone_contact_field;
			}

			set	
			{	
				if(  value != null &&  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'PhoneContactField'");					

				_phone_contact_field = value;
			}
		}
			
		public virtual string CommentsContactField
		{
			get
			{ 
				return _comments_contact_field;
			}

			set	
			{	
				if(  value != null &&  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'CommentsContactField'");					

				_comments_contact_field = value;
			}
		}
			
		public virtual string SendMessageContacttButton
		{
			get
			{ 
				return _send_message_contactt_button;
			}

			set	
			{	
				if(  value != null &&  value.Length > 60)
					throw new ExceptionRS("Valor ultrapassa limite em 'SendMessageContacttButton'");					

				_send_message_contactt_button = value;
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
			AboutInfo castObj = (AboutInfo)obj; 
			return ( castObj != null ) &&
				( this._id_about_info == castObj.IdAboutInfo );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id_about_info.GetHashCode();
			return hash; 
		}
		#endregion
		
	}
}
