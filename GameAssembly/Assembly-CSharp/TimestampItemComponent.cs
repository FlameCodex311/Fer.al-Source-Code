/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TimestampItemComponent : ItemComponent // TypeDefIndex: 12004
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private DateTime <Timestamp>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static readonly DateTime <Epoch>k__BackingField; // 0x00

	// Properties
	public DateTime Timestamp { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	private static DateTime Epoch { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180F90820-0x0000000180F90880 

	// Constructors
	public TimestampItemComponent(); // 0x00000001803FB1F0-0x00000001803FB200
	static TimestampItemComponent(); // 0x0000000180F907C0-0x0000000180F90820

	// Methods
	public override ItemComponent ParseJsonOverride(JsonData jsonData); // 0x0000000180F90560-0x0000000180F90660
	protected override JsonData ToJsonOverride(); // 0x0000000180F90670-0x0000000180F907C0
	public TimestampItemComponent Setup(DateTime inDateTime); // 0x0000000180F90660-0x0000000180F90670
}

