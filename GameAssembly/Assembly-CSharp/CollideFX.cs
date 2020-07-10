/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CollideFX : MonoBehaviour // TypeDefIndex: 11892
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _FX; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _distanceFromPlayer; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _timeBetweenFX; // 0x2C
	private float _timeSinceLastFX; // 0x30

	// Constructors
	public CollideFX(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Update(); // 0x000000018146FB70-0x000000018146FBB0
	public void Collide(Transform other); // 0x000000018146FA20-0x000000018146FB70
}

