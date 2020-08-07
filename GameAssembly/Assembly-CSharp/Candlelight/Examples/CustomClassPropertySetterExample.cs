/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Candlelight;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight.Examples
{
	public class CustomClassPropertySetterExample : MonoBehaviour // TypeDefIndex: 14508
	{
		// Fields
		[Header] // 0x0000000180247630-0x0000000180247690
		[PropertyBackingField] // 0x0000000180247630-0x0000000180247690
		[SerializeField] // 0x0000000180247630-0x0000000180247690
		private OrdinalName m_OrdinalName; // 0x20
		[PropertyBackingField] // 0x0000000180247940-0x00000001802479C0
		[SerializeField] // 0x0000000180247940-0x00000001802479C0
		private OrdinalName[] m_OrdinalNames; // 0x30
		[Header] // 0x0000000180247D30-0x0000000180247D90
		[PropertyBackingField] // 0x0000000180247D30-0x0000000180247D90
		[SerializeField] // 0x0000000180247D30-0x0000000180247D90
		private Character m_Character; // 0x38
		[PropertyBackingField] // 0x0000000180247F20-0x0000000180247FA0
		[SerializeField] // 0x0000000180247F20-0x0000000180247FA0
		private Character[] m_Characters; // 0x40
	
		// Properties
		public OrdinalName OrdinalName { get; set; } // 0x00000001804A4210-0x00000001804A4220 0x00000001804A42F0-0x00000001804A4420
		public Character Character { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001804A4220-0x00000001804A42F0
	
		// Nested types
		public class TwoLineReorderableListElement : PropertyAttribute // TypeDefIndex: 14509
		{
			// Constructors
			public TwoLineReorderableListElement(); // 0x00000001803FB1F0-0x00000001803FB200
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14510
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<OrdinalName, string> <>9__7_0; // 0x08
			public static Func<Character, string> <>9__14_0; // 0x10
	
			// Constructors
			static <>c(); // 0x00000001804A9370-0x00000001804A93D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <SetOrdinalNames>b__7_0(OrdinalName element); // 0x00000001804A8BF0-0x00000001804A8C90
			internal string <SetCharacters>b__14_0(Character element); // 0x00000001804A8BC0-0x00000001804A8BF0
		}
	
		// Constructors
		public CustomClassPropertySetterExample(); // 0x00000001804A4150-0x00000001804A4210
	
		// Methods
		public OrdinalName[] GetOrdinalNames(); // 0x00000001804A3C90-0x00000001804A3D10
		public void SetOrdinalNames(OrdinalName[] value); // 0x00000001804A3F30-0x00000001804A4150
		public Character[] GetCharacters(); // 0x00000001804A3C10-0x00000001804A3C90
		public void SetCharacters(Character[] value); // 0x00000001804A3D10-0x00000001804A3F30
	}
}
