/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public struct WebLoginResponse // TypeDefIndex: 10917
{
	// Fields
	public LoginStatus status; // 0x00
	public string uuid; // 0x08
	public string authToken; // 0x10
	public string refreshToken; // 0x18
	public string error; // 0x20

	// Properties
	public bool IsSuccess { get; } // 0x00000001801F6F50-0x00000001801F7070 
	public static WebLoginResponse Fake { get; } // 0x0000000180FFD8B0-0x0000000180FFD990 

	// Methods
	public void SetStatus(string inError); // 0x00000001801F6EA0-0x00000001801F6F50
}

