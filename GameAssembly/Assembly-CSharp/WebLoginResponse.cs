/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public struct WebLoginResponse // TypeDefIndex: 12440
{
	// Fields
	public LoginStatus status; // 0x00
	public string uuid; // 0x08
	public string authToken; // 0x10
	public string refreshToken; // 0x18
	public string error; // 0x20
	public bool renameRequired; // 0x28
	public string renameRequiredKey; // 0x30

	// Properties
	public bool IsSuccess { get; } // 0x0000000180009BD0-0x0000000180009E50 
	public static WebLoginResponse Fake { get; } // 0x00000001805E4BA0-0x00000001805E4C80 

	// Methods
	public void SetStatus(string inError); // 0x0000000180009B00-0x0000000180009BD0
}

