﻿using UnityEngine;

namespace SeaberyTest.Common
{
	
	public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
	{
		#region PRIVATE VARIABLES
		
		private static T _instance; 

		#endregion

		#region PUBLIC PROPERTIES

		/// <summary>
		/// Single instance of the class (static property).
		/// </summary>
		public static T Instance
		{
			get
			{
				if (_instance == null)
					Debug.LogError(typeof(T).ToString() + " is NULL!");

				return _instance;
			}
		}

		#endregion

		#region UNITY EVENTS

		private void Awake()
		{
			_instance = (T)this;

			Init();
		}

		#endregion

		#region PRIVATE METHODS

		/// <summary>
		/// Method used for initialize data (optional to override).
		/// </summary>
		protected virtual void Init()
		{

		} 

		#endregion
	}
}