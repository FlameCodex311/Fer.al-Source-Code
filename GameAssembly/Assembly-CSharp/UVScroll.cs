/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UVScroll : ManagedBehaviour // TypeDefIndex: 12697
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int materialIndex; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 uvAnimationRate; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string textureName; // 0x60
	private Vector2 uvOffset; // 0x68
	private Renderer _renderer; // 0x70

	// Constructors
	public UVScroll(); // 0x0000000180F89340-0x0000000180F89470

	// Methods
	public override void MStart(); // 0x0000000180F89050-0x0000000180F89160
	public override void MUpdate(); // 0x0000000180F89160-0x0000000180F89340
	public void reset(); // 0x0000000180F89470-0x0000000180F89610
}

