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

public class XtReader : INetMessageReader // TypeDefIndex: 12958
{
	// Fields
	private int cursor; // 0x10
	public readonly string[] Data; // 0x18

	// Properties
	public string Cmd { get; } // 0x000000018198A880-0x000000018198A8C0 
	public bool HasNext { get; } // 0x000000018198A8C0-0x000000018198A8E0 

	// Constructors
	public XtReader(string[] data, int cursorIndex = 2 /* Metadata: 0x007BA102 */); // 0x000000018198A840-0x000000018198A880
	public XtReader(XtReader copy); // 0x000000018198A7A0-0x000000018198A840

	// Methods
	public XtReader SetCursor(int index); // 0x000000018198A520-0x000000018198A750
	public string At(int index); // 0x000000018111E080-0x000000018111E0C0
	public string ReadString(); // 0x0000000181989770-0x00000001819897B0
	public bool ReadSuccess(); // 0x000000018198A280-0x000000018198A2F0
	public int ReadInt(); // 0x0000000181989B00-0x0000000181989B50
	public uint ReadUInt(); // 0x000000018198A2F0-0x000000018198A340
	public long ReadLong(); // 0x0000000181989F90-0x0000000181989FE0
	public float ReadFloat(); // 0x0000000181989990-0x00000001819899E0
	public double ReadDouble(); // 0x0000000181989900-0x0000000181989990
	public bool ReadBool(); // 0x0000000181989700-0x0000000181989770
	public Vector2 ReadVector2(); // 0x000000018198A340-0x000000018198A400
	public Vector3 ReadVector3(); // 0x000000018198A400-0x000000018198A520
	public Quaternion ReadQuaternion(); // 0x0000000181989FE0-0x000000018198A170
	public string ReadDefId(); // 0x0000000181989770-0x00000001819897B0
	public DateTime ReadJamaaTimeSeconds(); // 0x0000000181989B50-0x0000000181989BF0
	public string PeekString(); // 0x0000000181989310-0x0000000181989350
	public bool PeekSuccess(); // 0x0000000181989490-0x0000000181989500
	public int PeekInt(); // 0x0000000181989410-0x0000000181989450
	public uint PeekUInt(); // 0x0000000181989500-0x0000000181989540
	public long PeekLong(); // 0x0000000181989450-0x0000000181989490
	public float PeekFloat(); // 0x00000001819893D0-0x0000000181989410
	public double PeekDouble(); // 0x0000000181989350-0x00000001819893D0
	public bool PeekBool(); // 0x00000001819892A0-0x0000000181989310
	public Vector2 PeekVector2(); // 0x0000000181989540-0x00000001819895F0
	public Vector3 PeekVector3(); // 0x00000001819895F0-0x0000000181989700
	public string PeekDefId(); // 0x0000000181989310-0x0000000181989350
	public void Skip(int amount = 1 /* Metadata: 0x007BA106 */); // 0x000000018198A750-0x000000018198A760
	public Dictionary<string, string> ReadDictionaryStringArray(); // 0x00000001819897B0-0x0000000181989900
	public string[] ReadStringArray(); // 0x000000018198A170-0x000000018198A230
	public void ReadStringArray(string[] into, int atIndex); // 0x000000018198A230-0x000000018198A280
	public int[] ReadIntArray(); // 0x00000001819899E0-0x0000000181989B00
	public T ReadEnum<T>()
		where T : struct, IConvertible;
	public override string ToString(); // 0x000000018198A760-0x000000018198A7A0
	public T ReadJson<T>();
	public JsonData ReadJson(); // 0x0000000181989F00-0x0000000181989F90
	public T ReadJsonCompressed<T>();
	public JsonData ReadJsonCompressed(); // 0x0000000181989BF0-0x0000000181989F00
}

