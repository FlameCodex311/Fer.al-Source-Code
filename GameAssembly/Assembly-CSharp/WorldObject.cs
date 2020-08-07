/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018025A170-0x000000018025A1A0
public class WorldObject : ManagedBehaviour // TypeDefIndex: 12976
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <Id>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UserInfo <User>k__BackingField; // 0x58
	protected int? _initialRoomIDAtInstantiation; // 0x60
	private bool _subscribed; // 0x68
	private bool _deleted; // 0x69

	// Properties
	public string Id { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
	public UserInfo User { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	public bool InInitialRoomID { get; } // 0x00000001805EAE50-0x00000001805EAED0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <WaitForUserInfo>d__18 : IAsyncStateMachine // TypeDefIndex: 12977
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string OwnerId; // 0x28
		public WorldObject <>4__this; // 0x30
		private UniTask<UserInfo> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009A90-0x0000000180009AA0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public WorldObject(); // 0x00000001805EADF0-0x00000001805EAE50

	// Methods
	public virtual void OnObjectInfo(WorldObjectInfoMessage inInfoMessage); // 0x00000001805EA3B0-0x00000001805EA680
	public virtual void OnObjectDeleted(); // 0x00000001805EA1B0-0x00000001805EA3B0
	protected bool DestroyIfNotInInitialRoomID(); // 0x00000001805E9F00-0x00000001805E9FE0
	public override void UpdateInternal(); // 0x00000001805EAC50-0x00000001805EAD30
	public override void MOnDestroy(); // 0x00000001805E9FE0-0x00000001805EA010
	[AsyncStateMachine] // 0x000000018025BEC0-0x000000018025BF10
	public void WaitForUserInfo(string OwnerId); // 0x00000001805EAD30-0x00000001805EADF0
	public virtual void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation); // 0x00000001805EA6F0-0x00000001805EA850
	public virtual void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation, string inUniqueMapId = null, string userToGoToId = null); // 0x00000001805EA680-0x00000001805EA6F0
	public void Teleport(ObscuredVector3 inPosition, ObscuredVector3 inDestination, float inSpeed = 5f /* Metadata: 0x007BA11E */); // 0x00000001805EA850-0x00000001805EAC50
	protected virtual void OnMoveMessage(WorldObjectMoveMessage inMessage); // 0x00000001805EA120-0x00000001805EA1B0
	protected virtual void OnActionMessage(WorldObjectActionMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	protected virtual void OnDeleteMessage(WorldObjectDeleteMessage inMessage); // 0x00000001805EA110-0x00000001805EA120
	private void Delete(); // 0x00000001805E9CB0-0x00000001805E9F00
	protected virtual void OnBroadcastMessage(WorldObjectBroadcastMessage inMessage); // 0x00000001805EA010-0x00000001805EA110
}

