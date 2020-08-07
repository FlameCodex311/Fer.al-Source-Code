/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CollideFX : MonoBehaviour // TypeDefIndex: 13428
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _FX; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _distanceFromPlayer; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _timeBetweenFX; // 0x2C
	private float _timeSinceLastFX; // 0x30

	// Constructors
	public CollideFX(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Update(); // 0x000000018077B2D0-0x000000018077B310
	public void Collide(Transform other); // 0x000000018077B180-0x000000018077B2D0
}

