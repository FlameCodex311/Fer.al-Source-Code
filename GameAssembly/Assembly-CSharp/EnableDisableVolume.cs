/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class EnableDisableVolume : ManagedBehaviour // TypeDefIndex: 14279
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EState _onEnter; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EState _onExit; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _localPlayerOnly; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject[] _objects; // 0x60

	// Nested types
	public enum EState // TypeDefIndex: 14280
	{
		NONE = 0,
		ENABLE = 1,
		DISABLE = 2,
		TOGGLE = 3
	}

	// Constructors
	public EnableDisableVolume(); // 0x000000018085E000-0x000000018085E070

	// Methods
	private void OnTriggerEnter(Collider other); // 0x000000018085DC00-0x000000018085DCD0
	private void OnTriggerExit(Collider other); // 0x000000018085DCD0-0x000000018085DDA0
	private void UpdateObjects(EState inState); // 0x000000018085DDA0-0x000000018085E000
}

