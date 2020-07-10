﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class Singleton<T> : UnityEngine.MonoBehaviour // TypeDefIndex: 9094
		where T : UnityEngine.MonoBehaviour
	{
		// Fields
		private static T _instance;
		private static object _lock;
		private static bool applicationIsQuitting;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		public Singleton();
		static Singleton();
	
		// Methods
		public void OnDestroy();
	}
}
