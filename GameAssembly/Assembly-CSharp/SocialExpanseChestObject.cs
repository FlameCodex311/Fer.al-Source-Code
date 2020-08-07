/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SocialExpanseChestObject : MonoBehaviour // TypeDefIndex: 13233
{
	// Fields
	public NetworkedObjectInfo chestNetworkObjectInfo; // 0x20
	public GameObject interactionObject; // 0x28
	public DOTweenAnimator openTween; // 0x30
	public DOTweenAnimator closeTween; // 0x38
	public FeralAudioInfo openChestSfx; // 0x40
	public FeralAudioInfo closeChestSfx; // 0x48

	// Constructors
	public SocialExpanseChestObject(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180770FF0-0x0000000180771080
	private void OnDestroy(); // 0x0000000180770E50-0x0000000180770EE0
	private void OnSocialExpanseStart(SocialExpanseStartupMessage inMessage); // 0x0000000180770EE0-0x0000000180770FE0
	private void InternalOpenChest(bool playSfx); // 0x0000000180770D30-0x0000000180770E50
	private void InternalCloseChest(bool playSfx); // 0x0000000180770C10-0x0000000180770D30
	public void CloseChest(); // 0x0000000180770B00-0x0000000180770C10
	public void OpenChest(); // 0x0000000180770FE0-0x0000000180770FF0
}

