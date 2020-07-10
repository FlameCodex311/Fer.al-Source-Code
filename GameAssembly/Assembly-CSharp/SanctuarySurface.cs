/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuarySurface : ManagedBehaviour // TypeDefIndex: 11851
{
	// Fields
	private int _index; // 0x50
	private bool _meshColliderChecked; // 0x54
	private MeshCollider _meshCollider; // 0x58
	private bool _boxColliderChecked; // 0x60
	private BoxCollider _boxCollider; // 0x68

	// Properties
	public MeshCollider meshCollider { get; } // 0x000000018136F6A0-0x000000018136F700 
	public BoxCollider boxCollider { get; } // 0x000000018136F640-0x000000018136F6A0 

	// Constructors
	public SanctuarySurface(); // 0x000000018136F5E0-0x000000018136F640

	// Methods
	public override void MStart(); // 0x000000018136F570-0x000000018136F5E0
	public int GetIndex(); // 0x0000000180369BA0-0x0000000180369BB0
	public void SetIndex(int inIndex); // 0x0000000180478850-0x0000000180478860
}

