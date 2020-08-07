/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD.Studio
{
	public struct USER_PROPERTY // TypeDefIndex: 10253
	{
		// Fields
		public StringWrapper name; // 0x00
		public USER_PROPERTY_TYPE type; // 0x08
		private Union_IntBoolFloatString value; // 0x10
	
		// Methods
		public int intValue(); // 0x0000000180127460-0x0000000180127470
		public bool boolValue(); // 0x0000000180127430-0x0000000180127440
		public float floatValue(); // 0x0000000180127440-0x0000000180127460
		public string stringValue(); // 0x0000000180127470-0x0000000180127520
	}
}
