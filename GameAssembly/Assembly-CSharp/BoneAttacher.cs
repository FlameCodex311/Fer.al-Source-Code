/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BoneAttacher : ManagedBehaviour // TypeDefIndex: 11444
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _objectReference; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _instanceDestroyTimer; // 0x58
	public EState state; // 0x5C
	private string _lastBoneName; // 0x60
	private Transform _lastBone; // 0x68
	public UnityEvent OnSetup; // 0x70

	// Nested types
	public enum EState // TypeDefIndex: 11445
	{
		Attach = 0,
		Instance = 1
	}

	// Constructors
	public BoneAttacher(); // 0x00000001814D01E0-0x00000001814D0250

	// Methods
	public void Setup(string inBoneName); // 0x00000001814D00C0-0x00000001814D01E0
	private void Setup(); // 0x00000001814CFE80-0x00000001814D00C0
}

