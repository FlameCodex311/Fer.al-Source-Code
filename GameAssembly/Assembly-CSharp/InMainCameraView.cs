/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class InMainCameraView : ManagedBehaviour // TypeDefIndex: 11901
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Renderer _triggerer; // 0x50
	private EState _state; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnOnScreen; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent OnOffScreen; // 0x68

	// Nested types
	public enum EState // TypeDefIndex: 11902
	{
		OFFSCREEN = 0,
		ONSCREEN = 1
	}

	// Constructors
	public InMainCameraView(); // 0x00000001806240A0-0x0000000180624100

	// Methods
	public override void MUpdate(); // 0x0000000180623F90-0x0000000180624060
	private void OnScreen(); // 0x0000000180624080-0x00000001806240A0
	private void OffScreen(); // 0x0000000180624060-0x0000000180624080
}

