/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyResource : ScriptableObject // TypeDefIndex: 12822
{
	// Fields
	public Sprite resourceImage; // 0x18
	[RootSelector] // 0x000000018012C3C0-0x000000018012C420
	public string Resource_Name; // 0x20
	[RootSelector] // 0x000000018012C560-0x000000018012C5C0
	public string Resource_Description; // 0x28
	public BuildersFollyData.EStationType requiredStation; // 0x30
	[Header] // 0x000000018012C870-0x000000018012C8A0
	public GameObject tilePrefab; // 0x38
	[NonSerialized]
	internal EResourceColor resourceColor; // 0x40
	public EResourceOption resourceOption; // 0x44
	public BuildersFollyResource[] input; // 0x48
	public bool canBeDyed; // 0x50

	// Properties
	internal string ResourceName { get; } // 0x00000001813C2890-0x00000001813C2990 

	// Nested types
	public enum EResourceOption // TypeDefIndex: 12823
	{
		_1 = 0,
		_2 = 1,
		_3 = 2
	}

	public enum EResourceColor // TypeDefIndex: 12824
	{
		White = 0,
		Red = 1,
		Blue = 2,
		Green = 3,
		Yellow = 4,
		Mixed = 5
	}

	// Constructors
	public BuildersFollyResource(); // 0x00000001813C2880-0x00000001813C2890
}

