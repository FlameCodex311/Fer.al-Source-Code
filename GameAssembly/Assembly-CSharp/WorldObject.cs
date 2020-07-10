/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800BAB80-0x00000001800BABB0
public class WorldObject : ManagedBehaviour // TypeDefIndex: 11455
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Id>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UserInfo <User>k__BackingField; // 0x58
	protected int? _initialRoomIDAtInstantiation; // 0x60
	private bool _subscribed; // 0x68
	private bool _deleted; // 0x69

	// Properties
	public string Id { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
	public UserInfo User { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
	public bool InInitialRoomID { get; } // 0x0000000181003720-0x00000001810037A0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <WaitForUserInfo>d__18 : IAsyncStateMachine // TypeDefIndex: 11456
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string OwnerId; // 0x28
		public WorldObject <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F6E30-0x00000001801F6E40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public WorldObject(); // 0x00000001810036C0-0x0000000181003720

	// Methods
	public virtual void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x0000000181002F80-0x0000000181003250
	public virtual void OnObjectDeleted(); // 0x0000000181002D80-0x0000000181002F80
	protected bool DestroyIfNotInInitialRoomID(); // 0x0000000181002AD0-0x0000000181002BB0
	public override void UpdateInternal(); // 0x0000000181003520-0x0000000181003600
	public override void MOnDestroy(); // 0x0000000181002BB0-0x0000000181002BE0
	[AsyncStateMachine] // 0x00000001800BB510-0x00000001800BB560
	public void WaitForUserInfo(string OwnerId); // 0x0000000181003600-0x00000001810036C0
	public virtual void Teleport(Vector3 inPosition, Quaternion inRotation); // 0x0000000181003250-0x00000001810032E0
	public void Teleport(Vector3 inPosition, Vector3 inDestination, float inSpeed = 5f /* Metadata: 0x00782A1D */); // 0x00000001810032E0-0x0000000181003520
	protected virtual void OnMoveMessage(WorldObjectMoveMessage inMessage); // 0x0000000181002CF0-0x0000000181002D80
	protected virtual void OnActionMessage(WorldObjectActionMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void OnDeleteMessage(WorldObjectDeleteMessage inMessage); // 0x0000000181002CE0-0x0000000181002CF0
	private void Delete(); // 0x0000000181002A30-0x0000000181002AD0
	protected virtual void OnBroadcastMessage(WorldObjectBroadcastMessage inMessage); // 0x0000000181002BE0-0x0000000181002CE0
}

