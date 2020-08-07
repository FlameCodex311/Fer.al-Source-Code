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
	[Serializable]
	public struct OrdinalName : IPropertyBackingFieldCompatible<OrdinalName> // TypeDefIndex: 14507
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_Index; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_Name; // 0x08
	
		// Properties
		public int Index { get; } // 0x0000000180004EC0-0x0000000180004ED0 
		public string Name { get; } // 0x0000000180004ED0-0x0000000180004F20 
	
		// Constructors
		public OrdinalName(int index, string name); // 0x0000000180004E40-0x0000000180004EC0
	
		// Methods
		object ICloneable.Clone(); // 0x0000000180004DE0-0x0000000180004E30
		public override bool Equals(object obj); // 0x0000000180004D30-0x0000000180004DD0
		public bool Equals(OrdinalName other); // 0x0000000180004D10-0x0000000180004D30
		public override int GetHashCode(); // 0x0000000180004DD0-0x0000000180004DE0
		int IPropertyBackingFieldCompatible.GetSerializedPropertiesHash(); // 0x0000000180004D00-0x0000000180004D10
		public override string ToString(); // 0x0000000180004E30-0x0000000180004E40
	}
}
