/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SpawnTexture : ManagedBehaviour // TypeDefIndex: 13739
{
	// Fields
	[RootSelector] // 0x0000000180100F50-0x0000000180100FB0
	public string imageDefId; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private string _resourcePath; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _textureSize; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _offset; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _localScale; // 0x74
	private Vector3 _tempSpawnPosition; // 0x80

	// Properties
	public GameObject resource { get; } // 0x000000018135CDB0-0x000000018135CDF0 

	// Constructors
	public SpawnTexture(); // 0x000000018135CC50-0x000000018135CDB0

	// Methods
	public override void MStart(); // 0x000000018135C870-0x000000018135CC50
}

