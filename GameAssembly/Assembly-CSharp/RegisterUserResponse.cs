/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public struct RegisterUserResponse // TypeDefIndex: 12640
{
	// Fields
	public string refresh_token; // 0x00
	public string auth_token; // 0x08
	public string uuid; // 0x10
	public string error; // 0x18

	// Properties
	public bool IsSuccess { get; } // 0x000000018000A180-0x000000018000A290 

	// Methods
	public static bool IsInvalidOTP(string inStatus); // 0x0000000180656D90-0x0000000180656DD0
	public static bool IsPendingEmailValidationError(string inStatus); // 0x0000000180656E70-0x0000000180656EB0
	public static bool IsEmailError(string inStatus); // 0x0000000180656D00-0x0000000180656D90
	public static bool IsDisplaynameError(string inStatus); // 0x0000000180656C10-0x0000000180656D00
	public static bool IsPasswordError(string inStatus); // 0x0000000180656DD0-0x0000000180656E70
	public static bool IsBirthdayError(string inStatus); // 0x0000000180656B70-0x0000000180656C10
	public static string GetLocalizedError(string inStatus); // 0x00000001806565D0-0x0000000180656B70
}

