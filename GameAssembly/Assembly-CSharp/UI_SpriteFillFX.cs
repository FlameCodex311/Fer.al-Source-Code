/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SpriteFillFX : MonoBehaviour // TypeDefIndex: 13953
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _frameOverlap; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _framesToClip; // 0x24
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<WWImage> _images; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite[] _frames; // 0x30
	[Range] // 0x000000018020DDA0-0x000000018020DDE0
	[SerializeField] // 0x000000018020DDA0-0x000000018020DDE0
	private float _testValue; // 0x38

	// Constructors
	public UI_SpriteFillFX(); // 0x00000001804CC590-0x00000001804CC5F0

	// Methods
	public void OnProgressUpdated(float inNormalizedValue); // 0x00000001804CC2C0-0x00000001804CC560
	private void OnValidate(); // 0x00000001804CC560-0x00000001804CC590
}

