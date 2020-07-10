/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public struct RegisterUserResponse // TypeDefIndex: 11115
{
	// Fields
	public string refresh_token; // 0x00
	public string auth_token; // 0x08
	public string uuid; // 0x10
	public string error; // 0x18

	// Properties
	public bool IsSuccess { get; } // 0x00000001801F7260-0x00000001801F7370 

	// Methods
	public static bool IsInvalidOTP(string inStatus); // 0x0000000181011D10-0x0000000181011D50
	public static bool IsPendingEmailValidationError(string inStatus); // 0x0000000181011DF0-0x0000000181011E30
	public static bool IsEmailError(string inStatus); // 0x0000000181011C80-0x0000000181011D10
	public static bool IsDisplaynameError(string inStatus); // 0x0000000181011BB0-0x0000000181011C80
	public static bool IsPasswordError(string inStatus); // 0x0000000181011D50-0x0000000181011DF0
	public static bool IsBirthdayError(string inStatus); // 0x0000000181011B10-0x0000000181011BB0
	public static string GetLocalizedError(string inStatus); // 0x00000001810115D0-0x0000000181011B10
}

