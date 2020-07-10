/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public abstract class Singleton<T> : UnityEngine.MonoBehaviour // TypeDefIndex: 9322
		where T : Singleton<T>
	{
		// Fields
		private static T sInstance;
	
		// Properties
		public static T instance { get; }
	
		// Constructors
		protected Singleton();
		static Singleton();
	
		// Methods
		protected virtual void Awake();
	}
}
