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
	public class ArrayPropertySetterExample : MonoBehaviour // TypeDefIndex: 13835
	{
		// Fields
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private int[] m_ArrayProperty; // 0x20
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private List<int> m_ListProperty; // 0x28
		[PropertyBackingField] // 0x00000001800CF4E0-0x00000001800CF510
		[SerializeField] // 0x00000001800CF4E0-0x00000001800CF510
		private List<int> m_AnotherListProperty; // 0x30
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13836
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<int, string> <>9__2_0; // 0x08
			public static Func<int, string> <>9__5_0; // 0x10
			public static Func<int, string> <>9__9_0; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000181034660-0x00000001810346C0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <SetArrayProperty>b__2_0(int element); // 0x0000000181033E90-0x0000000181033EB0
			internal string <SetListProperty>b__5_0(int element); // 0x0000000181033E90-0x0000000181033EB0
			internal string <SetAnotherListProperty>b__9_0(int element); // 0x0000000181033E90-0x0000000181033EB0
		}
	
		// Constructors
		public ArrayPropertySetterExample(); // 0x000000018101D6B0-0x000000018101D780
	
		// Methods
		public int[] GetArrayProperty(); // 0x000000018101D050-0x000000018101D0D0
		public void SetArrayProperty(int[] value); // 0x000000018101D300-0x000000018101D4F0
		public int[] GetListProperty(); // 0x000000018101D0D0-0x000000018101D120
		public void SetListProperty(int[] value); // 0x000000018101D4F0-0x000000018101D6B0
		public int[] GetAnotherListProperty(); // 0x000000018101D000-0x000000018101D050
		private void SetAnotherListProperty(int[] value); // 0x000000018101D120-0x000000018101D130
		public void SetAnotherListProperty(IEnumerable<int> value); // 0x000000018101D130-0x000000018101D300
	}
}
