/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LoginMessage : Message // TypeDefIndex: 12863
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LoginStatus <Status>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LoginData <Data>k__BackingField; // 0x20
	public bool renameRequired; // 0x28
	public string renameRequiredKey; // 0x30

	// Properties
	public LoginStatus Status { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
	public LoginData Data { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public bool Success { get; } // 0x00000001803FEC50-0x00000001803FEC60 

	// Constructors
	public LoginMessage(LoginStatus status, LoginData data); // 0x00000001803F9310-0x00000001803F9350
	public LoginMessage(ServerLoginResponse response); // 0x00000001804EF900-0x00000001804EF940
}

