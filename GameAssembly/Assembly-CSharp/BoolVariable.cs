/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class BoolVariable : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 14267
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool initialValue; // 0x18
	[NonSerialized]
	public bool runtimeValue; // 0x19

	// Constructors
	public BoolVariable(); // 0x00000001803FEC00-0x00000001803FEC10

	// Methods
	public void OnAfterDeserialize(); // 0x0000000182130DD0-0x0000000182130DE0
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
}

