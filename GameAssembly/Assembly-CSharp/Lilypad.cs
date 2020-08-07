/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Lilypad : ManagedBehaviour // TypeDefIndex: 11405
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject fxLilypad; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject fxLilypadSteppedOn; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _steppedOffOffset; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _fxSteppedOnOffset; // 0x64
	private SphereCollider _sphereCollider; // 0x68
	private Vector3 _fxSpawnPosition; // 0x70
	private Vector3 _steppedOffPosition; // 0x7C
	private Vector3 _steppedOnPosition; // 0x88
	public Fish fishRef; // 0x98

	// Constructors
	public Lilypad(); // 0x0000000180C580A0-0x0000000180C58100

	// Methods
	public override void MStart(); // 0x0000000180C57670-0x0000000180C577B0
	private void SpawnFx(); // 0x0000000180C57D50-0x0000000180C58050
	private void SpawnFxSteppedOn(); // 0x0000000180C57AF0-0x0000000180C57D50
	private void OnTriggerEnter(Collider inCollider); // 0x0000000180C577B0-0x0000000180C57980
	private void OnTriggerExit(Collider inCollider); // 0x0000000180C57980-0x0000000180C57AF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <OnTriggerEnter>b__12_0(); // 0x0000000180C58050-0x0000000180C580A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerEnter>b__12_1(Vector3 x); // 0x0000000180BF11C0-0x0000000180BF1210
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 <OnTriggerExit>b__13_0(); // 0x0000000180C58050-0x0000000180C580A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnTriggerExit>b__13_1(Vector3 x); // 0x0000000180BF11C0-0x0000000180BF1210
}

