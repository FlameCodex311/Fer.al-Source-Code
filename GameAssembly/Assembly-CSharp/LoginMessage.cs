/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class LoginMessage : Message // TypeDefIndex: 11335
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LoginStatus <Status>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private LoginData <Data>k__BackingField; // 0x20

	// Properties
	public LoginStatus Status { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
	public LoginData Data { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public bool Success { get; } // 0x0000000180EBFF40-0x0000000180EBFF50 

	// Constructors
	public LoginMessage(LoginStatus status, LoginData data); // 0x0000000180EBFF00-0x0000000180EBFF40
	public LoginMessage(ServerLoginResponse response); // 0x00000001811E8D10-0x00000001811E8D50
}

