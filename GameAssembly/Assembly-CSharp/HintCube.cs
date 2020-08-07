/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class HintCube : MonoBehaviour // TypeDefIndex: 10592
{
	// Fields
	public int codeHintIndex; // 0x20
	public CodeHintType currentHint; // 0x24
	public Renderer hintRenderer; // 0x28
	[EnumList] // 0x000000018022CAD0-0x000000018022CB30
	public List<Material> hintTypeMaterials; // 0x30

	// Constructors
	public HintCube(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018061F440-0x000000018061F570
	public void SetHintType(CodeHintType inHint); // 0x000000018061F370-0x000000018061F440
	private void OnValidate(); // 0x00000001803774A0-0x00000001803774B0
}

