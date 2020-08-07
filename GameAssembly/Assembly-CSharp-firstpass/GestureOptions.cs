/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GestureRecognizer;
using UnityEngine;
using UnityEngine.UI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

public class GestureOptions : UnityEngine.MonoBehaviour // TypeDefIndex: 9701
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
	public GestureOptions(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	private void OnEnable(); // 0x0000000180D25B70-0x0000000180D25C60
	private void OnDisable(); // 0x0000000180D25A70-0x0000000180D25B70
	private void RecognitionResult(RecognitionResult result); // 0x0000000180D25C60-0x0000000180D25D00
	public void OnChangeMinMax(); // 0x0000000180D256C0-0x0000000180D25880
	public void OnChangeMode(); // 0x0000000180D25880-0x0000000180D25A30
	public void OnChangeThreads(); // 0x0000000180D25A30-0x0000000180D25A70
}

