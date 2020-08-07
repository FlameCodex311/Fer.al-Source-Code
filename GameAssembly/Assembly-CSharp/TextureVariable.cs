/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x00000001801CDAD0-0x00000001801CDAE0
public class TextureVariable : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 14272
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Texture initialValue; // 0x18
	[NonSerialized]
	public Texture runtimeValue; // 0x20

	// Constructors
	public TextureVariable(); // 0x00000001803FEC00-0x00000001803FEC10

	// Methods
	public void OnAfterDeserialize(); // 0x000000018050DCA0-0x000000018050DCB0
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
}

