/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SpawnTexture : ManagedBehaviour // TypeDefIndex: 11412
{
	// Fields
	[RootSelector] // 0x00000001801D8D10-0x00000001801D8D70
	public string imageDefId; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string _resourcePath; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _textureSize; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _offset; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _localScale; // 0x74
	private Vector3 _tempSpawnPosition; // 0x80

	// Properties
	public GameObject resource { get; } // 0x00000001807737C0-0x0000000180773800 

	// Constructors
	public SpawnTexture(); // 0x0000000180773660-0x00000001807737C0

	// Methods
	public override void MStart(); // 0x0000000180773290-0x0000000180773660
}

