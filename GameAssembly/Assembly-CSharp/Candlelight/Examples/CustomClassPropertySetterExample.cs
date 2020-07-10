/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Candlelight.Examples
{
	public class CustomClassPropertySetterExample : MonoBehaviour // TypeDefIndex: 13841
	{
		// Fields
		[Header] // 0x000000018011AD40-0x000000018011ADA0
		[PropertyBackingField] // 0x000000018011AD40-0x000000018011ADA0
		[SerializeField] // 0x000000018011AD40-0x000000018011ADA0
		private OrdinalName m_OrdinalName; // 0x20
		[PropertyBackingField] // 0x000000018011AFE0-0x000000018011B060
		[SerializeField] // 0x000000018011AFE0-0x000000018011B060
		private OrdinalName[] m_OrdinalNames; // 0x30
		[Header] // 0x000000018011B250-0x000000018011B2B0
		[PropertyBackingField] // 0x000000018011B250-0x000000018011B2B0
		[SerializeField] // 0x000000018011B250-0x000000018011B2B0
		private Character m_Character; // 0x38
		[PropertyBackingField] // 0x000000018011B420-0x000000018011B4A0
		[SerializeField] // 0x000000018011B420-0x000000018011B4A0
		private Character[] m_Characters; // 0x40
	
		// Properties
		public OrdinalName OrdinalName { get; set; } // 0x0000000180CC6480-0x0000000180CC6490 0x000000018102D820-0x000000018102D950
		public Character Character { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x000000018102D750-0x000000018102D820
	
		// Nested types
		public class TwoLineReorderableListElement : PropertyAttribute // TypeDefIndex: 13842
		{
			// Constructors
			public TwoLineReorderableListElement(); // 0x0000000180363710-0x0000000180363720
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13843
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<OrdinalName, string> <>9__7_0; // 0x08
			public static Func<Character, string> <>9__14_0; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000181034600-0x0000000181034660
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <SetOrdinalNames>b__7_0(OrdinalName element); // 0x0000000181033EE0-0x0000000181033F80
			internal string <SetCharacters>b__14_0(Character element); // 0x0000000181033EB0-0x0000000181033EE0
		}
	
		// Constructors
		public CustomClassPropertySetterExample(); // 0x000000018102D690-0x000000018102D750
	
		// Methods
		public OrdinalName[] GetOrdinalNames(); // 0x000000018102D1D0-0x000000018102D250
		public void SetOrdinalNames(OrdinalName[] value); // 0x000000018102D470-0x000000018102D690
		public Character[] GetCharacters(); // 0x000000018102D150-0x000000018102D1D0
		public void SetCharacters(Character[] value); // 0x000000018102D250-0x000000018102D470
	}
}
