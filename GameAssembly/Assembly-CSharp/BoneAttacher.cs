/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BoneAttacher : ManagedBehaviour // TypeDefIndex: 12381
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _objectReference; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _instanceDestroyTimer; // 0x58
	public EState state; // 0x5C
	private string _lastBoneName; // 0x60
	private Transform _lastBone; // 0x68
	public UnityEvent OnSetup; // 0x70

	// Nested types
	public enum EState // TypeDefIndex: 12382
	{
		Attach = 0,
		Instance = 1
	}

	// Constructors
	public BoneAttacher(); // 0x0000000182130D60-0x0000000182130DD0

	// Methods
	public void Setup(string inBoneName); // 0x0000000182130C40-0x0000000182130D60
	private void Setup(); // 0x0000000182130A10-0x0000000182130C40
}

