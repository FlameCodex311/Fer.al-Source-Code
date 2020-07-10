/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LoginAndRegistrationStage : MonoBehaviour // TypeDefIndex: 12639
{
	// Fields
	public static UI_LoginAndRegistrationStage instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _foxParent; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _catParent; // 0x28
	private GameObject _fox; // 0x30
	private GameObject _cat; // 0x38

	// Constructors
	public UI_LoginAndRegistrationStage(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180E80BF0-0x0000000180E80CE0
	private void OnDestroy(); // 0x0000000180E80760-0x0000000180E807F0
	public void SpawnAvatars(); // 0x0000000180E80930-0x0000000180E80BF0
	public void ShowAvatars(bool inShow); // 0x0000000180E808B0-0x0000000180E80930
	public void RemoveScene(); // 0x0000000180E807F0-0x0000000180E808B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnAvatars>b__7_0(GameObject inActorBase, ActorInfo _actorInfo); // 0x0000000180E80CE0-0x0000000180E80E90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SpawnAvatars>b__7_1(GameObject inActorBase, ActorInfo _actorInfo); // 0x0000000180E80E90-0x0000000180E81040
}

