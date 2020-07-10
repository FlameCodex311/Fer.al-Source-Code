/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SpriteFillFX : MonoBehaviour // TypeDefIndex: 12368
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _frameOverlap; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _framesToClip; // 0x24
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<WWImage> _images; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite[] _frames; // 0x30
	[Range] // 0x00000001800DC820-0x00000001800DC860
	[SerializeField] // 0x00000001800DC820-0x00000001800DC860
	private float _testValue; // 0x38

	// Constructors
	public UI_SpriteFillFX(); // 0x0000000180EF74E0-0x0000000180EF7540

	// Methods
	public void OnProgressUpdated(float inNormalizedValue); // 0x0000000180EF7200-0x0000000180EF74B0
	private void OnValidate(); // 0x0000000180EF74B0-0x0000000180EF74E0
}

