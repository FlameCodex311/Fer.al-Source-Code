/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class EnableDisableVolume : ManagedBehaviour // TypeDefIndex: 12708
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EState _onEnter; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private EState _onExit; // 0x54
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _localPlayerOnly; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject[] _objects; // 0x60

	// Nested types
	public enum EState // TypeDefIndex: 12709
	{
		NONE = 0,
		ENABLE = 1,
		DISABLE = 2,
		TOGGLE = 3
	}

	// Constructors
	public EnableDisableVolume(); // 0x0000000181191420-0x0000000181191490

	// Methods
	private void OnTriggerEnter(Collider other); // 0x0000000181191000-0x00000001811910D0
	private void OnTriggerExit(Collider other); // 0x00000001811910D0-0x00000001811911A0
	private void UpdateObjects(EState inState); // 0x00000001811911A0-0x0000000181191420
}

