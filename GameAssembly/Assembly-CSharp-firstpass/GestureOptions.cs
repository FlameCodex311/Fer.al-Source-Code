/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GestureRecognizer;
using UnityEngine;
using UnityEngine.UI;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public class GestureOptions : UnityEngine.MonoBehaviour // TypeDefIndex: 9297
{
	// Fields
	public Dropdown dropdownMin; // 0x18
	public Dropdown dropdownMax; // 0x20
	public Dropdown dropdownThreads; // 0x28
	public Dropdown dropdownMode; // 0x30
	public UnityEngine.UI.Text textTime; // 0x38
	public DrawDetector[] detectors; // 0x40
	public Recognizer recognizer; // 0x48

	// Constructors
	public GestureOptions(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void OnEnable(); // 0x0000000181651E20-0x0000000181651F20
	private void OnDisable(); // 0x0000000181651D20-0x0000000181651E20
	private void RecognitionResult(RecognitionResult result); // 0x0000000181651F20-0x0000000181651FC0
	public void OnChangeMinMax(); // 0x0000000181651950-0x0000000181651B20
	public void OnChangeMode(); // 0x0000000181651B20-0x0000000181651CE0
	public void OnChangeThreads(); // 0x0000000181651CE0-0x0000000181651D20
}

