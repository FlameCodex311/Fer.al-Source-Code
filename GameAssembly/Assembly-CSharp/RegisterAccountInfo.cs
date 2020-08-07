/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RegisterAccountInfo // TypeDefIndex: 12807
{
	// Fields
	public string uuid; // 0x10
	public string display_name; // 0x18
	public string email; // 0x20
	public string password; // 0x28
	public int birthdayMonth; // 0x30
	public int birthdayDay; // 0x34
	public int birthdayYear; // 0x38
	public Gender gender; // 0x3C
	public string emailVerificationCode; // 0x40

	// Nested types
	public enum Gender // TypeDefIndex: 12808
	{
		Female = 0,
		Male = 1,
		None = 2
	}

	// Constructors
	public RegisterAccountInfo(); // 0x0000000180656570-0x00000001806565D0
}

