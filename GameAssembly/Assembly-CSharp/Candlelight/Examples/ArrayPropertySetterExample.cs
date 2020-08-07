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
	public class ArrayPropertySetterExample : MonoBehaviour // TypeDefIndex: 14502
	{
		// Fields
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private int[] m_ArrayProperty; // 0x20
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private List<int> m_ListProperty; // 0x28
		[PropertyBackingField] // 0x00000001801E0E00-0x00000001801E0E30
		[SerializeField] // 0x00000001801E0E00-0x00000001801E0E30
		private List<int> m_AnotherListProperty; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14503
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<int, string> <>9__2_0; // 0x08
			public static Func<int, string> <>9__5_0; // 0x10
			public static Func<int, string> <>9__9_0; // 0x18
	
			// Constructors
			static <>c(); // 0x00000001804A93D0-0x00000001804A9430
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <SetArrayProperty>b__2_0(int element); // 0x00000001804A8BA0-0x00000001804A8BC0
			internal string <SetListProperty>b__5_0(int element); // 0x00000001804A8BA0-0x00000001804A8BC0
			internal string <SetAnotherListProperty>b__9_0(int element); // 0x00000001804A8BA0-0x00000001804A8BC0
		}
	
		// Constructors
		public ArrayPropertySetterExample(); // 0x0000000180491B50-0x0000000180491C20
	
		// Methods
		public int[] GetArrayProperty(); // 0x00000001804914F0-0x0000000180491570
		public void SetArrayProperty(int[] value); // 0x00000001804917A0-0x0000000180491990
		public int[] GetListProperty(); // 0x0000000180491570-0x00000001804915C0
		public void SetListProperty(int[] value); // 0x0000000180491990-0x0000000180491B50
		public int[] GetAnotherListProperty(); // 0x00000001804914A0-0x00000001804914F0
		private void SetAnotherListProperty(int[] value); // 0x00000001804915C0-0x00000001804915D0
		public void SetAnotherListProperty(IEnumerable<int> value); // 0x00000001804915D0-0x00000001804917A0
	}
}
