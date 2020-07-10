/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorBase_SMB_IdleAdditive : StateMachineBehaviour // TypeDefIndex: 10034
{
	// Fields
	public float minBaseTime; // 0x18
	public float maxBaseTime; // 0x1C
	public int idleBaseLayerIndex; // 0x20
	[EnumList] // 0x000000018013ABB0-0x000000018013AC10
	public List<float> weights; // 0x28
	private IdleAdditiveState _currentState; // 0x30
	private float noAdditiveTimer; // 0x34
	private const string baseIdleName = "Idle Base Add"; // Metadata: 0x0074692A

	// Nested types
	public enum IdleAdditiveState // TypeDefIndex: 10035
	{
		BaseAdditive = 0,
		LookLeftAdd = 1,
		LookRightAdd = 2,
		LookAroundAdd = 3
	}

	// Constructors
	public ActorBase_SMB_IdleAdditive(); // 0x0000000181401870-0x0000000181401880

	// Methods
	private void OnEnable(); // 0x0000000181401690-0x00000001814016A0
	private IdleAdditiveState ChooseNewState(); // 0x00000001814013D0-0x00000001814015F0
	private void HandleStateSelection(Animator animator); // 0x00000001814015F0-0x0000000181401690
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001814016A0-0x0000000181401740
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000181401740-0x0000000181401870
}

