/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight.Examples
{
	public abstract class GenericBaseClassPropertySetterExample<T> : MonoBehaviour // TypeDefIndex: 13844
	{
		// Fields
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private T m_Single;
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private List<T> m_Array;
	
		// Properties
		public T Single { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13845
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
