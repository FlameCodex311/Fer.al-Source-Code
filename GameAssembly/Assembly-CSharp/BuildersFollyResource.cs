/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BuildersFollyResource : ScriptableObject // TypeDefIndex: 10480
{
	// Fields
	public Sprite resourceImage; // 0x18
	[RootSelector] // 0x00000001801FFF70-0x00000001801FFFD0
	public string Resource_Name; // 0x20
	[RootSelector] // 0x0000000180200240-0x00000001802002A0
	public string Resource_Description; // 0x28
	public BuildersFollyData.EStationType requiredStation; // 0x30
	[Header] // 0x0000000180200480-0x00000001802004B0
	public GameObject tilePrefab; // 0x38
	[NonSerialized]
	internal EResourceColor resourceColor; // 0x40
	public EResourceOption resourceOption; // 0x44
	public BuildersFollyResource[] input; // 0x48
	public bool canBeDyed; // 0x50

	// Properties
	internal string ResourceName { get; } // 0x0000000180AB2CD0-0x0000000180AB2DD0 

	// Nested types
	public enum EResourceOption // TypeDefIndex: 10481
	{
		_1 = 0,
		_2 = 1,
		_3 = 2
	}

	public enum EResourceColor // TypeDefIndex: 10482
	{
		White = 0,
		Red = 1,
		Blue = 2,
		Green = 3,
		Yellow = 4,
		Mixed = 5
	}

	// Constructors
	public BuildersFollyResource(); // 0x0000000180AB2CC0-0x0000000180AB2CD0
}

