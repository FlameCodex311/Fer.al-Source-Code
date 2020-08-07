/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActiveStateEnsurer : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 14246
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _active; // 0x20
	[DeComment] // 0x00000001801F7E30-0x00000001801F7E80
	[SerializeField] // 0x00000001801F7E30-0x00000001801F7E80
	private Behaviour _component; // 0x28

	// Constructors
	public ActiveStateEnsurer(); // 0x00000001805DFA20-0x00000001805DFA30

	// Methods
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
	public void OnAfterDeserialize(); // 0x00000001803774A0-0x00000001803774B0
}

