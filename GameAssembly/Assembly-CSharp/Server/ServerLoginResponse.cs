/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	public class ServerLoginResponse : Message // TypeDefIndex: 16044
	{
		// Fields
		public readonly LoginStatus Status; // 0x18
		public readonly LoginData Data; // 0x20
	
		// Properties
		public bool Success { get; } // 0x0000000180EBFF40-0x0000000180EBFF50 
	
		// Constructors
		public ServerLoginResponse(LoginStatus status, LoginData data); // 0x0000000180EBFF00-0x0000000180EBFF40
	}
}
