/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UVLerp : MonoBehaviour // TypeDefIndex: 12696
{
	// Fields
	public int materialIndex; // 0x20
	public Vector2 uvAnimationRateMin; // 0x24
	public Vector2 uvAnimationRateMax; // 0x2C
	public string textureName; // 0x38
	private Vector2 uvOffset; // 0x40
	private float _timer; // 0x48
	public float time; // 0x4C
	private Material[] _materials; // 0x50
	private bool _lerpOut; // 0x58

	// Constructors
	public UVLerp(); // 0x0000000180F88F70-0x0000000180F89050

	// Methods
	private void Start(); // 0x0000000180F88CD0-0x0000000180F88D50
	private void Update(); // 0x0000000180F88D50-0x0000000180F88F70
}

