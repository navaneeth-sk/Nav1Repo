using System;
using System.Web;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

	/// <summary>
	/// Class Name: ActivityDO
	/// </summary>
	public class ActivityDO
	{
		
		/// <summary>
		/// Property to get and set ACTIVITY_ID
		/// </summary>

        public int ACTIVITY_ID {get; set;}
		
		/// <summary>
		/// Property to get and set PROJECT_ID
		/// </summary>
 
		public int PROJECT_ID {get; set;}
		
		/// <summary>
		/// Property to get and set ACTIVITY_DESC
		/// </summary>

        public string ACTIVITY_DESC {get; set;}
	}

