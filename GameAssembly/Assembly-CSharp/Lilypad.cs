/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Lilypad : ManagedBehaviour // TypeDefIndex: 13732
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject fxLilypad; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject fxLilypadSteppedOn; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _steppedOffOffset; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _fxSteppedOnOffset; // 0x64
	private SphereCollider _sphereCollider; // 0x68
	private Vector3 _fxSpawnPosition; // 0x70
	private Vector3 _steppedOffPosition; // 0x7C
	private Vector3 _steppedOnPosition; // 0x88
	public Fish fishRef; // 0x98

	// Constructors
	public Lilypad(); // 0x00000001812D23D0-0x00000001812D2430

	// Methods
	public override void MStart(); // 0x00000001812D1930-0x00000001812D1A70
	private void SpawnFx(); // 0x00000001812D2020-0x00000001812D2330
	private void SpawnFxSteppedOn(); // 0x00000001812D1DB0-0x00000001812D2020
	private void OnTriggerEnter(Collider inCollider); // 0x00000001812D1A70-0x00000001812D1C40
	private void OnTriggerExit(Collider inCollider); // 0x00000001812D1C40-0x00000001812D1DB0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <OnTriggerEnter>b__12_0(); // 0x00000001812D2330-0x00000001812D2380
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerEnter>b__12_1(Vector3 x); // 0x00000001812D2380-0x00000001812D23D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 <OnTriggerExit>b__13_0(); // 0x00000001812D2330-0x00000001812D2380
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTriggerExit>b__13_1(Vector3 x); // 0x00000001812D2380-0x00000001812D23D0
}

