/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryHome : ManagedBehaviour // TypeDefIndex: 13324
{
	// Fields
	private Transform _windowsParent; // 0x50
	private Transform _doorsParent; // 0x58
	private Transform _shrubsParent; // 0x60
	private Transform _wallsParent; // 0x68
	private Transform _roofParent; // 0x70
	private Transform _moldingParent; // 0x78
	private Transform _baseParent; // 0x80
	private List<Transform> _windowLocators; // 0x88
	private List<Transform> _doorLocators; // 0x90
	private List<Transform> _shrubLocators; // 0x98
	private List<Transform> _wallLocators; // 0xA0
	private List<Transform> _roofLocators; // 0xA8
	private List<Transform> _moldingLocators; // 0xB0
	private List<Transform> _baseLocators; // 0xB8

	// Nested types
	public enum EComponent // TypeDefIndex: 13325
	{
		NONE = 0,
		WINDOWS = 1,
		DOORS = 2,
		SHRUBS = 3,
		WALLS = 4,
		ROOF = 5,
		BASE = 6,
		MOLDING = 7
	}

	// Constructors
	public SanctuaryHome(); // 0x00000001807B6530-0x00000001807B6590

	// Methods
	public override void MStart(); // 0x00000001807B5F50-0x00000001807B5F70
	private void SetLocators(); // 0x00000001807B5F70-0x00000001807B6530
	public void ChangeLook(EComponent inType, GameObject inPrefab); // 0x00000001807B5200-0x00000001807B5210
	private void CreateLook(EComponent inType, GameObject inPrefab); // 0x00000001807B5210-0x00000001807B5AC0
	private void DestroyLook(EComponent inType); // 0x00000001807B5AC0-0x00000001807B5F50
}

