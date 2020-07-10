/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SocialExpanseChestObject : MonoBehaviour // TypeDefIndex: 11706
{
	// Fields
	public NetworkedObjectInfo chestNetworkObjectInfo; // 0x20
	public GameObject interactionObject; // 0x28
	public DOTweenAnimator openTween; // 0x30
	public DOTweenAnimator closeTween; // 0x38
	public FeralAudioInfo openChestSfx; // 0x40
	public FeralAudioInfo closeChestSfx; // 0x48

	// Constructors
	public SocialExpanseChestObject(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x000000018135A770-0x000000018135A800
	private void OnDestroy(); // 0x000000018135A5D0-0x000000018135A660
	private void OnSocialExpanseStart(SocialExpanseStartupMessage inMessage); // 0x000000018135A660-0x000000018135A760
	private void InternalOpenChest(bool playSfx); // 0x000000018135A4B0-0x000000018135A5D0
	private void InternalCloseChest(bool playSfx); // 0x000000018135A390-0x000000018135A4B0
	public void CloseChest(); // 0x000000018135A280-0x000000018135A390
	public void OpenChest(); // 0x000000018135A760-0x000000018135A770
}

