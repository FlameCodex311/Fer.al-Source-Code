/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	public class ServerLoginResponse : Message // TypeDefIndex: 14431
	{
		// Fields
		public readonly LoginStatus Status; // 0x18
		public readonly LoginData Data; // 0x20
	
		// Properties
		public bool Success { get; } // 0x00000001803FEC50-0x00000001803FEC60 
	
		// Constructors
		public ServerLoginResponse(LoginStatus status, LoginData data); // 0x00000001803F9310-0x00000001803F9350
	}
}
