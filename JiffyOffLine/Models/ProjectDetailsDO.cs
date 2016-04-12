using System;
using System.Web;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

	/// <summary>
	/// Class Name: ProjectDetailsDO
	/// </summary>
	public class ProjectDetailsDO 
	{
		
		/// <summary>
		/// Property to get and set PROJECT_ID
		/// </summary>

        public int PROJECT_ID {get; set;}
		
		/// <summary>
		/// Property to get and set PROJECT_DESC
		/// </summary>

        public string PROJECT_DESC {get; set;}
		
		/// <summary>
		/// Property to get and set COMMENTS
		/// </summary>

		public string COMMENTS {get; set;}
	}

