/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Avatar_Local : AvatarBase // TypeDefIndex: 11568
{
	// Fields
	public const float MovementSampleInterval = 0.2f; // Metadata: 0x0077CDE5
	public static Avatar_Local instance; // 0x00
	private int _cachedSFSUserId; // 0x3F0
	private static Coroutine _persistentEmoteTimer; // 0x08
	public static Color persistentDirtTargetColor; // 0x10
	public static float persistentDirtAccel; // 0x20
	public static float persistentDirtCurrentLerp; // 0x24
	private ObscuredInt? _maxMoveDistance; // 0x3F4
	private ObscuredVector3 _lastSentPosition; // 0x40C
	private WorldObjectMoverNodeType _lastSentNodeType; // 0x430
	private ActorActionType _lastSentActionType; // 0x434
	private float _sendTimer; // 0x438

	// Properties
	protected ObscuredInt maxMoveDistance { get; } // 0x0000000182159C20-0x0000000182159D00 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnCreate>d__11 : IAsyncStateMachine // TypeDefIndex: 11569
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Avatar_Local <>4__this; // 0x28
		public ActorInfo inInfo; // 0x30
		public Action<GameObject, ActorInfo> inFinishedCallback; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018031D000-0x000000018031D010
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public Avatar_Local(); // 0x0000000182157C60-0x0000000182157CC0

	// Methods
	public static Avatar_Local CreateLocal(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182158710-0x0000000182158810
	[AsyncStateMachine] // 0x000000018021F390-0x000000018021F3E0
	public override void OnCreate(ActorInfo inInfo, Action<GameObject, ActorInfo> inFinishedCallback); // 0x0000000182158A90-0x0000000182158B60
	public void SetDefault(); // 0x00000001821592A0-0x0000000182159360
	public override void MStart(); // 0x00000001821589E0-0x0000000182158A30
	public override void MOnEnable(); // 0x0000000182158990-0x00000001821589E0
	public override void MOnDisable(); // 0x0000000182158940-0x0000000182158990
	public override void MOnDestroy(); // 0x00000001821588E0-0x0000000182158940
	public static void DestroyInstance(); // 0x0000000182158810-0x00000001821588E0
	public override void MUpdate(); // 0x0000000182158A30-0x0000000182158A90
	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation, string inUniqueMapId, string userToGoToId); // 0x0000000182159B10-0x0000000182159BC0
	public override void Teleport(ObscuredVector3 inPosition, ObscuredQuaternion inRotation); // 0x0000000182159BC0-0x0000000182159C20
	public void TeleportFromMap(Transform inTransform, ObscuredVector3? inDestination = default); // 0x0000000182159360-0x0000000182159480
	public void TeleportFromMap(WorldMapLocation inWorldMapLocation, ObscuredVector3? inDestination = default); // 0x0000000182159A60-0x0000000182159B10
	public void TeleportFromMap(string inUniqueMapId, ObscuredVector3? inDestination = default); // 0x0000000182159480-0x0000000182159A60
	public void SendLatestMovement(); // 0x0000000182158B60-0x00000001821592A0
}

