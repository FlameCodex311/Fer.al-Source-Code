/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ActorActionSMB : StateMachineBehaviour // TypeDefIndex: 10383
{
	// Fields
	public string stateID; // 0x18
	public ActorActionType actionType; // 0x20
	public bool forceThirdPersonCamera; // 0x24
	public bool dontAllowMovement; // 0x25

	// Constructors
	public ActorActionSMB(); // 0x0000000182164520-0x0000000182164570

	// Methods
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001803774A0-0x00000001803774B0
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001803774A0-0x00000001803774B0
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x0000000182164480-0x0000000182164520
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash); // 0x0000000182164370-0x00000001821643E0
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash); // 0x00000001821643E0-0x0000000182164480
}

