/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	public class BankLoadException : Exception // TypeDefIndex: 9836
	{
		// Fields
		public string Path; // 0x88
		public RESULT Result; // 0x90
	
		// Constructors
		public BankLoadException(string path, RESULT result); // 0x0000000181B1FCB0-0x0000000181B1FDB0
		public BankLoadException(string path, string error); // 0x0000000181B1FC10-0x0000000181B1FCB0
	}
}
