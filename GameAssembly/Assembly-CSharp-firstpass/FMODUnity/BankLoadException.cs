/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	public class BankLoadException : Exception // TypeDefIndex: 10290
	{
		// Fields
		public string Path; // 0x88
		public RESULT Result; // 0x90
	
		// Constructors
		public BankLoadException(string path, RESULT result); // 0x0000000180D1A580-0x0000000180D1A680
		public BankLoadException(string path, string error); // 0x0000000180D1A4E0-0x0000000180D1A580
	}
}
