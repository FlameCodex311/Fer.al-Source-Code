/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LoginAndRegistrationStage : MonoBehaviour // TypeDefIndex: 13828
{
	// Fields
	public static UI_LoginAndRegistrationStage instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _foxParent; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _catParent; // 0x28
	private GameObject _fox; // 0x30
	private GameObject _cat; // 0x38

	// Constructors
	public UI_LoginAndRegistrationStage(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001803CA550-0x00000001803CA630
	private void OnDestroy(); // 0x00000001803CA0E0-0x00000001803CA170
	public void SpawnAvatars(); // 0x00000001803CA2A0-0x00000001803CA550
	public void ShowAvatars(bool inShow); // 0x00000001803CA220-0x00000001803CA2A0
	public void RemoveScene(); // 0x00000001803CA170-0x00000001803CA220
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnAvatars>b__7_0(GameObject inActorBase, ActorInfo _actorInfo); // 0x00000001803CA630-0x00000001803CA7E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SpawnAvatars>b__7_1(GameObject inActorBase, ActorInfo _actorInfo); // 0x00000001803CA7E0-0x00000001803CA990
}

