/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_3DIcon_BodyPart : MonoBehaviour // TypeDefIndex: 13455
{
	// Fields
	private ActorInfo _actorInfo; // 0x20
	private ActorBodyPartDefComponent _bodyPartDef; // 0x28
	private Renderer[] _instanceRenderers; // 0x30

	// Constructors
	public UI_3DIcon_BodyPart(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(ActorInfo inActorInfo, ActorBodyPartDefComponent inBodyPartDef); // 0x000000018051B610-0x000000018051B690
	private void OnDestroy(); // 0x000000018051AD50-0x000000018051AD60
	private void AddListener(); // 0x000000018051A3C0-0x000000018051AB90
	private void RemoveListener(); // 0x000000018051B100-0x000000018051B440
	private void OnBodyColorChanged(); // 0x000000018051AB90-0x000000018051AD50
	private void OnHornColorChanged(); // 0x000000018051AD60-0x000000018051AF30
	private void OnWingColorChanged(); // 0x000000018051AF30-0x000000018051B100
	private void SetColors(List<HSVColor> inColors); // 0x000000018051B440-0x000000018051B610
}

