/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class SavedAccountData // TypeDefIndex: 12674
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Email>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Token>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsGuest>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private DateTime <LastSeen>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private DateTime <Created>k__BackingField; // 0x30

	// Properties
	public string Email { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public string Token { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public bool IsGuest { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
	public DateTime LastSeen { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public DateTime Created { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810

	// Nested types
	public enum SortOrder // TypeDefIndex: 12675
	{
		None = 0,
		LastPlayed = 1,
		DateCreated = 2
	}

	// Constructors
	public SavedAccountData(string email, string token, bool isGuest); // 0x0000000181371270-0x0000000181371310

	// Methods
	public void ClearToken(); // 0x00000001813711C0-0x00000001813711D0
	public static int SortByLastPlayed(SavedAccountData left, SavedAccountData right); // 0x0000000181371220-0x0000000181371270
	public static int SortByDateCreated(SavedAccountData left, SavedAccountData right); // 0x00000001813711D0-0x0000000181371220
}

