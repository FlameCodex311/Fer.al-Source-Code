/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800B6E20-0x00000001800B6E50
public class MinimapBlipArea : MinimapBlip // TypeDefIndex: 10850
{
	// Fields
	public EColorType colorType; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _color; // 0x84
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _radius; // 0x94

	// Nested types
	public enum EColorType // TypeDefIndex: 10851
	{
		Primary = 0,
		Daily = 1,
		UserControlled = 2
	}

	// Constructors
	public MinimapBlipArea(); // 0x00000001810AFFD0-0x00000001810B0050

	// Methods
	public override void MStart(); // 0x00000001810AFCE0-0x00000001810AFDB0
	public override void MUpdate(); // 0x00000001810AFDB0-0x00000001810AFEA0
	private void OnDrawGizmosSelected(); // 0x00000001810AFEA0-0x00000001810AFF50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <MStart>b__4_0(); // 0x00000001810AFF50-0x00000001810AFFD0
}

