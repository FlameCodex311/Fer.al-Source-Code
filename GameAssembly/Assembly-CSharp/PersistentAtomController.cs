/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PersistentAtomController : MonoBehaviour // TypeDefIndex: 13181
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _userVar; // 0x20
	public List<PersistentAtomData_Int> intVariables; // 0x28

	// Constructors
	public PersistentAtomController(); // 0x0000000181172E10-0x0000000181172E70

	// Methods
	public void LoadAtomVariables(); // 0x00000001811729F0-0x0000000181172BD0
	public void SaveAtomVariables(); // 0x0000000181172BD0-0x0000000181172E10
}

