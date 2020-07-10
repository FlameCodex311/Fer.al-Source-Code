/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using LitJson;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	public interface INetMessageWriter // TypeDefIndex: 16021
	{
		// Properties
		string Cmd { get; }
		bool Compress { get; set; }
		bool NoReset { get; set; }
	
		// Methods
		INetMessageWriter WriteString(string v);
		INetMessageWriter WriteInt(int v);
		INetMessageWriter WriteUInt(uint v);
		INetMessageWriter WriteLong(long v);
		INetMessageWriter WriteFloat(float v);
		INetMessageWriter WriteDouble(double v);
		INetMessageWriter WriteBytes(byte[] v);
		INetMessageWriter WriteBool(bool v);
		INetMessageWriter WriteDefId(string v);
		INetMessageWriter WriteVector3(Vector3 v);
		INetMessageWriter WriteQuaternion(Quaternion q);
		INetMessageWriter WriteJson(JsonData v);
		INetMessageWriter WriteJson(object o);
		INetMessageWriter WriteJson(IXtDataWriter o);
		INetMessageWriter WriteArray(IXtDataWriter[] o);
		INetMessageWriter WriteArray(string[] o);
		INetMessageWriter WriteArray(int[] o);
	}
}
