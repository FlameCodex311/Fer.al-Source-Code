/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UpdateItem : RemoveItem // TypeDefIndex: 11798
{
	// Fields
	public Vector3 position; // 0x18
	public Quaternion rotation; // 0x24
	public int gridId; // 0x34
	public string parentItemId; // 0x38
	public int state; // 0x40

	// Constructors
	public UpdateItem(string denItemInvId, Vector3 position, Quaternion rotation, int gridId, string parentItemId, int state); // 0x000000018121EBE0-0x000000018121EC40

	// Methods
	public override void WriteData(XtWriter writer); // 0x000000018121EB40-0x000000018121EBE0
}

