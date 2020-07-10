/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TimestampItemComponent : ItemComponent // TypeDefIndex: 10516
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private DateTime <Timestamp>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static readonly DateTime <Epoch>k__BackingField; // 0x00

	// Properties
	public DateTime Timestamp { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	private static DateTime Epoch { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180FA2960-0x0000000180FA29C0 

	// Constructors
	public TimestampItemComponent(); // 0x0000000180363710-0x0000000180363720
	static TimestampItemComponent(); // 0x0000000180FA2900-0x0000000180FA2960

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180FA26A0-0x0000000180FA27A0
	protected override JsonData ToJsonOverride(); // 0x0000000180FA27B0-0x0000000180FA2900
	public TimestampItemComponent Setup(DateTime inDateTime); // 0x0000000180FA27A0-0x0000000180FA27B0
}

