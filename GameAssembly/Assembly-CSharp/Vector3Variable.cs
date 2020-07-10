/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 12706
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 initialValue; // 0x18
	[NonSerialized]
	public Vector3 runtimeValue; // 0x24

	// Constructors
	public Vector3Variable(); // 0x0000000181132540-0x00000001811325D0

	// Methods
	public void OnAfterDeserialize(); // 0x0000000181132520-0x0000000181132540
	public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
}

