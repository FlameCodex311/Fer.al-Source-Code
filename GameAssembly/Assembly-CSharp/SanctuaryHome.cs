/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryHome : ManagedBehaviour // TypeDefIndex: 11790
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
	public enum EComponent // TypeDefIndex: 11791
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
	public SanctuaryHome(); // 0x000000018128C8B0-0x000000018128C910

	// Methods
	public override void MStart(); // 0x000000018128C2A0-0x000000018128C2C0
	private void SetLocators(); // 0x000000018128C2C0-0x000000018128C8B0
	public void ChangeLook(EComponent inType, GameObject inPrefab); // 0x000000018128B4F0-0x000000018128B500
	private void CreateLook(EComponent inType, GameObject inPrefab); // 0x000000018128B500-0x000000018128BDF0
	private void DestroyLook(EComponent inType); // 0x000000018128BDF0-0x000000018128C2A0
}

