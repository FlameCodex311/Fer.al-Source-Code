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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class XtWriter : INetMessageWriter // TypeDefIndex: 12959
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <Cmd>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <Compress>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <NoReset>k__BackingField; // 0x19
	private List<string> _buffer; // 0x20

	// Properties
	public string Cmd { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public bool Compress { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
	public bool NoReset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180690340-0x0000000180690350 0x0000000180878500-0x0000000180878510
	public string[] Data { get; } // 0x000000018198B360-0x000000018198B3B0 

	// Constructors
	public XtWriter(XtCmd cmd); // 0x000000018198B2E0-0x000000018198B360

	// Methods
	public INetMessageWriter WriteString(string v); // 0x000000018198B140-0x000000018198B1A0
	public INetMessageWriter WriteInt(int v); // 0x000000018198ADF0-0x000000018198AE60
	public INetMessageWriter WriteUInt(uint v); // 0x000000018198B1A0-0x000000018198B210
	public INetMessageWriter WriteLong(long v); // 0x000000018198AFD0-0x000000018198B040
	public INetMessageWriter WriteFloat(float v); // 0x000000018198AD80-0x000000018198ADF0
	public INetMessageWriter WriteDouble(double v); // 0x000000018198AD10-0x000000018198AD80
	public INetMessageWriter WriteBytes(byte[] v); // 0x000000018198ABF0-0x000000018198ACB0
	public INetMessageWriter WriteBool(bool v); // 0x000000018198AB80-0x000000018198ABF0
	public INetMessageWriter WriteDefId(string v); // 0x000000018198ACB0-0x000000018198AD10
	public INetMessageWriter WriteVector3(Vector3 v); // 0x000000018198B210-0x000000018198B2E0
	public INetMessageWriter WriteQuaternion(Quaternion q); // 0x000000018198B040-0x000000018198B140
	public INetMessageWriter WriteJson(JsonData v); // 0x000000018198AE60-0x000000018198AF00
	public INetMessageWriter WriteJson(object v); // 0x000000018198AF00-0x000000018198AF70
	public INetMessageWriter WriteJson(IXtDataWriter dataWriter); // 0x000000018198AF70-0x000000018198AFD0
	public INetMessageWriter WriteArray(IXtDataWriter[] array); // 0x000000018198A990-0x000000018198AAC0
	public INetMessageWriter WriteArray(string[] array); // 0x000000018198A8E0-0x000000018198A990
	public INetMessageWriter WriteArray(int[] array); // 0x000000018198AAC0-0x000000018198AB80
}

