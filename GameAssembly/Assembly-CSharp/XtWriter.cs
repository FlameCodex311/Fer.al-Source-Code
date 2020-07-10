/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class XtWriter : INetMessageWriter // TypeDefIndex: 11426
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Cmd>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <Compress>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <NoReset>k__BackingField; // 0x19
	private List<string> _buffer; // 0x20

	// Properties
	public string Cmd { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public bool Compress { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
	public bool NoReset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018048F440-0x000000018048F450 0x000000018048F560-0x000000018048F570
	public string[] Data { get; } // 0x0000000181F3E150-0x0000000181F3E1A0 

	// Constructors
	public XtWriter(XtCmd cmd); // 0x0000000181F3E0D0-0x0000000181F3E150

	// Methods
	public INetMessageWriter WriteString(string v); // 0x0000000181F3DF30-0x0000000181F3DF90
	public INetMessageWriter WriteInt(int v); // 0x0000000181F3DBD0-0x0000000181F3DC40
	public INetMessageWriter WriteUInt(uint v); // 0x0000000181F3DF90-0x0000000181F3E000
	public INetMessageWriter WriteLong(long v); // 0x0000000181F3DDB0-0x0000000181F3DE20
	public INetMessageWriter WriteFloat(float v); // 0x0000000181F3DB60-0x0000000181F3DBD0
	public INetMessageWriter WriteDouble(double v); // 0x0000000181F3DAF0-0x0000000181F3DB60
	public INetMessageWriter WriteBytes(byte[] v); // 0x0000000181F3D9C0-0x0000000181F3DA90
	public INetMessageWriter WriteBool(bool v); // 0x0000000181F3D950-0x0000000181F3D9C0
	public INetMessageWriter WriteDefId(string v); // 0x0000000181F3DA90-0x0000000181F3DAF0
	public INetMessageWriter WriteVector3(Vector3 v); // 0x0000000181F3E000-0x0000000181F3E0D0
	public INetMessageWriter WriteQuaternion(Quaternion q); // 0x0000000181F3DE20-0x0000000181F3DF30
	public INetMessageWriter WriteJson(JsonData v); // 0x0000000181F3DC40-0x0000000181F3DCE0
	public INetMessageWriter WriteJson(object v); // 0x0000000181F3DCE0-0x0000000181F3DD50
	public INetMessageWriter WriteJson(IXtDataWriter dataWriter); // 0x0000000181F3DD50-0x0000000181F3DDB0
	public INetMessageWriter WriteArray(IXtDataWriter[] array); // 0x0000000181F3D750-0x0000000181F3D890
	public INetMessageWriter WriteArray(string[] array); // 0x0000000181F3D6A0-0x0000000181F3D750
	public INetMessageWriter WriteArray(int[] array); // 0x0000000181F3D890-0x0000000181F3D950
}

