/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_3DIcon_BodyPart : MonoBehaviour // TypeDefIndex: 11919
{
	// Fields
	private ActorInfo _actorInfo; // 0x20
	private ActorBodyPartDefComponent _bodyPartDef; // 0x28
	private Renderer[] _instanceRenderers; // 0x30

	// Constructors
	public UI_3DIcon_BodyPart(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(ActorInfo inActorInfo, ActorBodyPartDefComponent inBodyPartDef); // 0x0000000180FB6740-0x0000000180FB67C0
	private void OnDestroy(); // 0x0000000180FB5E50-0x0000000180FB5E60
	private void AddListener(); // 0x0000000180FB5490-0x0000000180FB5C80
	private void RemoveListener(); // 0x0000000180FB6220-0x0000000180FB6560
	private void OnBodyColorChanged(); // 0x0000000180FB5C80-0x0000000180FB5E50
	private void OnHornColorChanged(); // 0x0000000180FB5E60-0x0000000180FB6040
	private void OnWingColorChanged(); // 0x0000000180FB6040-0x0000000180FB6220
	private void SetColors(List<HSVColor> inColors); // 0x0000000180FB6560-0x0000000180FB6740
}

