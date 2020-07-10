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

public class XtReader : INetMessageReader // TypeDefIndex: 11425
{
	// Fields
	private int cursor; // 0x10
	public readonly string[] Data; // 0x18

	// Properties
	public string Cmd { get; } // 0x0000000181B04B00-0x0000000181B04B40 
	public bool HasNext { get; } // 0x0000000181F3D680-0x0000000181F3D6A0 

	// Constructors
	public XtReader(string[] data, int cursorIndex = 2 /* Metadata: 0x0078297C */); // 0x0000000181F3D640-0x0000000181F3D680
	public XtReader(XtReader copy); // 0x0000000181F3D5A0-0x0000000181F3D640

	// Methods
	public XtReader SetCursor(int index); // 0x0000000181F3D300-0x0000000181F3D550
	public string At(int index); // 0x00000001807CF330-0x00000001807CF370
	public string ReadString(); // 0x0000000181F3C4E0-0x0000000181F3C530
	public bool ReadSuccess(); // 0x0000000181F3D040-0x0000000181F3D0C0
	public int ReadInt(); // 0x0000000181F3C8A0-0x0000000181F3C8F0
	public uint ReadUInt(); // 0x0000000181F3D0C0-0x0000000181F3D110
	public long ReadLong(); // 0x0000000181F3CD50-0x0000000181F3CDA0
	public float ReadFloat(); // 0x0000000181F3C720-0x0000000181F3C770
	public double ReadDouble(); // 0x0000000181F3C690-0x0000000181F3C720
	public bool ReadBool(); // 0x0000000181F3C460-0x0000000181F3C4E0
	public Vector2 ReadVector2(); // 0x0000000181F3D110-0x0000000181F3D1D0
	public Vector3 ReadVector3(); // 0x0000000181F3D1D0-0x0000000181F3D300
	public Quaternion ReadQuaternion(); // 0x0000000181F3CDA0-0x0000000181F3CF30
	public string ReadDefId(); // 0x0000000181F3C4E0-0x0000000181F3C530
	public DateTime ReadJamaaTimeSeconds(); // 0x0000000181F3C8F0-0x0000000181F3C990
	public string PeekString(); // 0x0000000181F3C020-0x0000000181F3C060
	public bool PeekSuccess(); // 0x0000000181F3C1E0-0x0000000181F3C250
	public int PeekInt(); // 0x0000000181F3C140-0x0000000181F3C190
	public uint PeekUInt(); // 0x0000000181F3C250-0x0000000181F3C2A0
	public long PeekLong(); // 0x0000000181F3C190-0x0000000181F3C1E0
	public float PeekFloat(); // 0x0000000181F3C0F0-0x0000000181F3C140
	public double PeekDouble(); // 0x0000000181F3C060-0x0000000181F3C0F0
	public bool PeekBool(); // 0x0000000181F3BFB0-0x0000000181F3C020
	public Vector2 PeekVector2(); // 0x0000000181F3C2A0-0x0000000181F3C350
	public Vector3 PeekVector3(); // 0x0000000181F3C350-0x0000000181F3C460
	public string PeekDefId(); // 0x0000000181F3C020-0x0000000181F3C060
	public void Skip(int amount = 1 /* Metadata: 0x00782980 */); // 0x0000000181F3D550-0x0000000181F3D560
	public Dictionary<string, string> ReadDictionaryStringArray(); // 0x0000000181F3C530-0x0000000181F3C690
	public string[] ReadStringArray(); // 0x0000000181F3CF30-0x0000000181F3CFF0
	public void ReadStringArray(string[] into, int atIndex); // 0x0000000181F3CFF0-0x0000000181F3D040
	public int[] ReadIntArray(); // 0x0000000181F3C770-0x0000000181F3C8A0
	public T ReadEnum<T>()
		where T : struct, IConvertible;
	public override string ToString(); // 0x0000000181F3D560-0x0000000181F3D5A0
	public T ReadJson<T>();
	public JsonData ReadJson(); // 0x0000000181F3CCC0-0x0000000181F3CD50
	public T ReadJsonCompressed<T>();
	public JsonData ReadJsonCompressed(); // 0x0000000181F3C990-0x0000000181F3CCC0
}

