/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight.Examples
{
	public abstract class GenericBaseClassPropertySetterExample<T> : MonoBehaviour // TypeDefIndex: 14511
	{
		// Fields
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private T m_Single;
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private List<T> m_Array;
	
		// Properties
		public T Single { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14512
		{
			// Fields
			public static readonly <>c<T> <>9;
			public static Func<T, string> <>9__6_0;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal string <SetArray>b__6_0(T element);
		}
	
		// Constructors
		protected GenericBaseClassPropertySetterExample();
	
		// Methods
		public T[] GetArray();
		public void SetArray(T[] value);
	}
}
