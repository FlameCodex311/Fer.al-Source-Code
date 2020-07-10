/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActiveStateEnsurer : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 12677
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _active; // 0x20
	[DeComment] // 0x000000018010CB10-0x000000018010CB60
	[SerializeField] // 0x000000018010CB10-0x000000018010CB60
	private Behaviour _component; // 0x28

	// Constructors
	public ActiveStateEnsurer(); // 0x0000000180FF8660-0x0000000180FF8670

	// Methods
	public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
	public void OnAfterDeserialize(); // 0x00000001803581E0-0x00000001803581F0
}

