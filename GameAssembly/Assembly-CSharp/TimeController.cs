/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801D1400-0x00000001801D1430
public class TimeController : ManagedBehaviour // TypeDefIndex: 12157
{
	// Fields
	public static TimeController _instance; // 0x00
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <secondRotation>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <minuteRotation>k__BackingField; // 0x54
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <hourRotation>k__BackingField; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <dayRotation>k__BackingField; // 0x5C

	// Properties
	public static TimeController instance { get; } // 0x0000000180F8DBD0-0x0000000180F8DD00 
	public float secondRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180791CE0-0x0000000180791CF0 0x00000001807E32A0-0x00000001807E32B0
	public float minuteRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180791CD0-0x0000000180791CE0 0x0000000180A506C0-0x0000000180A506D0
	public float hourRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018099EBC0-0x000000018099EBD0 0x0000000180F8DD10-0x0000000180F8DD20
	public float dayRotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018099EBB0-0x000000018099EBC0 0x0000000180F8DD00-0x0000000180F8DD10

	// Constructors
	public TimeController(); // 0x0000000180F8DB70-0x0000000180F8DBD0
	static TimeController(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public override void MOnDestroy(); // 0x0000000180F8D980-0x0000000180F8D9F0
	public override void MUpdate(); // 0x0000000180F8D9F0-0x0000000180F8DB70
}

