/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F7BB0-0x00000001800F7BE0
public class TimeController : ManagedBehaviour // TypeDefIndex: 10654
{
	// Fields
	public static TimeController _instance; // 0x00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <secondRotation>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <minuteRotation>k__BackingField; // 0x54
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <hourRotation>k__BackingField; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <dayRotation>k__BackingField; // 0x5C

	// Properties
	public static TimeController instance { get; } // 0x0000000181A0C750-0x0000000181A0C880 
	public float secondRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D20-0x0000000180487D30 0x0000000180DD2D90-0x0000000180DD2DA0
	public float minuteRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487CF0-0x0000000180487D00 0x0000000180DD2D30-0x0000000180DD2D40
	public float hourRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487CE0-0x0000000180487CF0 0x0000000181A0C890-0x0000000181A0C8A0
	public float dayRotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487CB0-0x0000000180487CC0 0x0000000181A0C880-0x0000000181A0C890

	// Constructors
	public TimeController(); // 0x0000000181A0C6F0-0x0000000181A0C750
	static TimeController(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public override void MOnDestroy(); // 0x0000000181A0C500-0x0000000181A0C570
	public override void MUpdate(); // 0x0000000181A0C570-0x0000000181A0C6F0
}

