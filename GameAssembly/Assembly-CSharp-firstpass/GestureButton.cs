/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GestureRecognizer;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public class GestureButton : UnityEngine.MonoBehaviour // TypeDefIndex: 9298
{
	// Fields
	public GestureSelector gestureSelector; // 0x18
	public DrawDetector drawDetector; // 0x20
	public List<GesturePattern> gesturePatterns; // 0x28
	private RectTransform rectTransfrom; // 0x30

	// Constructors
	public GestureButton(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void Start(); // 0x00000001816517E0-0x0000000181651820
	public void OnGestureSelected(); // 0x00000001816516D0-0x00000001816517E0
}

