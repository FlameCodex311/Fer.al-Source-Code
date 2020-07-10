/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ActorActionSMB : StateMachineBehaviour // TypeDefIndex: 12726
{
	// Fields
	public string stateID; // 0x18
	public ActorActionType actionType; // 0x20
	public bool forceThirdPersonCamera; // 0x24
	public bool dontAllowMovement; // 0x25

	// Constructors
	public ActorActionSMB(); // 0x000000018122F280-0x000000018122F2D0

	// Methods
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001803581E0-0x00000001803581F0
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x00000001803581E0-0x00000001803581F0
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex); // 0x000000018122F1E0-0x000000018122F280
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash); // 0x000000018122F0D0-0x000000018122F140
	public override void OnStateMachineExit(Animator animator, int stateMachinePathHash); // 0x000000018122F140-0x000000018122F1E0
}

