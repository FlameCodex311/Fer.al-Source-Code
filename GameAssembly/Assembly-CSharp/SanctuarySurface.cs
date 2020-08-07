/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuarySurface : ManagedBehaviour // TypeDefIndex: 13387
{
	// Fields
	private int _index; // 0x50
	private bool _meshColliderChecked; // 0x54
	private MeshCollider _meshCollider; // 0x58
	private bool _boxColliderChecked; // 0x60
	private BoxCollider _boxCollider; // 0x68

	// Properties
	public MeshCollider meshCollider { get; } // 0x00000001803F83C0-0x00000001803F8420 
	public BoxCollider boxCollider { get; } // 0x00000001803F8360-0x00000001803F83C0 

	// Constructors
	public SanctuarySurface(); // 0x00000001803F8300-0x00000001803F8360

	// Methods
	public override void MStart(); // 0x00000001803F8280-0x00000001803F82F0
	public int GetIndex(); // 0x00000001803F8270-0x00000001803F8280
	public void SetIndex(int inIndex); // 0x00000001803F82F0-0x00000001803F8300
}

