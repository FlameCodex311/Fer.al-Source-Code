/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class HintCube : MonoBehaviour // TypeDefIndex: 12927
{
	// Fields
	public int codeHintIndex; // 0x20
	public CodeHintType currentHint; // 0x24
	public Renderer hintRenderer; // 0x28
	[EnumList] // 0x000000018014C4F0-0x000000018014C550
	public List<Material> hintTypeMaterials; // 0x30

	// Constructors
	public HintCube(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F54F70-0x0000000180F550B0
	public void SetHintType(CodeHintType inHint); // 0x0000000180F54EA0-0x0000000180F54F70
	private void OnValidate(); // 0x00000001803581E0-0x00000001803581F0
}

