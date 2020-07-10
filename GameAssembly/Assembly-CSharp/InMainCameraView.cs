/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class InMainCameraView : ManagedBehaviour // TypeDefIndex: 10413
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Renderer _triggerer; // 0x50
	private EState _state; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnOnScreen; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent OnOffScreen; // 0x68

	// Nested types
	public enum EState // TypeDefIndex: 10414
	{
		OFFSCREEN = 0,
		ONSCREEN = 1
	}

	// Constructors
	public InMainCameraView(); // 0x0000000180F5ABD0-0x0000000180F5AC30

	// Methods
	public override void MUpdate(); // 0x0000000180F5AAC0-0x0000000180F5AB90
	private void OnScreen(); // 0x0000000180F5ABB0-0x0000000180F5ABD0
	private void OffScreen(); // 0x0000000180F5AB90-0x0000000180F5ABB0
}

