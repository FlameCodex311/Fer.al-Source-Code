/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PersistentAtomController : MonoBehaviour // TypeDefIndex: 10847
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _userVar; // 0x20
	public List<PersistentAtomData_Int> intVariables; // 0x28

	// Constructors
	public PersistentAtomController(); // 0x00000001804DFEF0-0x00000001804DFF50

	// Methods
	public void LoadAtomVariables(); // 0x00000001804DFAF0-0x00000001804DFCC0
	public void SaveAtomVariables(); // 0x00000001804DFCC0-0x00000001804DFEF0
}

