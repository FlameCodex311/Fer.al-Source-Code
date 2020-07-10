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
	[Serializable]
	public struct OrdinalName : IPropertyBackingFieldCompatible<OrdinalName> // TypeDefIndex: 13840
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_Index; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_Name; // 0x08
	
		// Properties
		public int Index { get; } // 0x0000000180004180-0x0000000180004190 
		public string Name { get; } // 0x00000001801F7940-0x00000001801F7990 
	
		// Constructors
		public OrdinalName(int index, string name); // 0x00000001801F78C0-0x00000001801F7940
	
		// Methods
		object ICloneable.Clone(); // 0x00000001801F7860-0x00000001801F78B0
		public override bool Equals(object obj); // 0x00000001801F77B0-0x00000001801F7850
		public bool Equals(OrdinalName other); // 0x00000001801F7790-0x00000001801F77B0
		public override int GetHashCode(); // 0x00000001801F7850-0x00000001801F7860
		int IPropertyBackingFieldCompatible.GetSerializedPropertiesHash(); // 0x00000001801F7780-0x00000001801F7790
		public override string ToString(); // 0x00000001801F78B0-0x00000001801F78C0
	}
}
