/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public abstract class MonoBehaviourSingleton<T> : MonoBehaviour // TypeDefIndex: 13904
		where T : MonoBehaviour
	{
		// Fields
		private static T _instance;
	
		// Properties
		public static T Instance { get; }
	
		// Constructors
		protected MonoBehaviourSingleton();
	
		// Methods
		protected virtual void Awake();
		protected virtual void OnDestroy();
		protected virtual void OnApplicationQuit();
	}
}
