/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001800B36B0-0x00000001800B36C0
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 12699
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float initialValue; // 0x18
	[NonSerialized]
	public float runtimeValue; // 0x1C

	// Constructors
	public FloatVariable(); // 0x00000001803A2BB0-0x00000001803A2BC0

	// Methods
	public void OnAfterDeserialize(); // 0x0000000180F5D250-0x0000000180F5D260
	public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
}

