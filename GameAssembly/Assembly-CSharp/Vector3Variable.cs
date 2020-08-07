/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 14275
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 initialValue; // 0x18
	[NonSerialized]
	public Vector3 runtimeValue; // 0x24

	// Constructors
	public Vector3Variable(); // 0x00000001806764D0-0x0000000180676560

	// Methods
	public void OnAfterDeserialize(); // 0x00000001806764B0-0x00000001806764D0
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
}

