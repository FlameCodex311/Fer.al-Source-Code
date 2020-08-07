/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UpdateItem : RemoveItem // TypeDefIndex: 13332
{
	// Fields
	public Vector3 position; // 0x18
	public Quaternion rotation; // 0x24
	public int gridId; // 0x34
	public string parentItemId; // 0x38
	public int state; // 0x40

	// Constructors
	public UpdateItem(string denItemInvId, Vector3 position, Quaternion rotation, int gridId, string parentItemId, int state); // 0x000000018066A9E0-0x000000018066AA40

	// Methods
	public override void WriteData(XtWriter writer); // 0x000000018066A940-0x000000018066A9E0
}

