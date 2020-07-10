/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD.Studio
{
	public struct USER_PROPERTY // TypeDefIndex: 9799
	{
		// Fields
		public StringWrapper name; // 0x00
		public USER_PROPERTY_TYPE type; // 0x08
		private Union_IntBoolFloatString value; // 0x10
	
		// Methods
		public int intValue(); // 0x00000001802CE840-0x00000001802CE850
		public bool boolValue(); // 0x00000001802CE810-0x00000001802CE820
		public float floatValue(); // 0x00000001802CE820-0x00000001802CE840
		public string stringValue(); // 0x00000001802CE850-0x00000001802CE900
	}
}
