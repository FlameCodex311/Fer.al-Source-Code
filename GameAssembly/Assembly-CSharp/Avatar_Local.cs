/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Avatar_Local : AvatarBase // TypeDefIndex: 10077
{
	// Fields
	public const float MovementSampleInterval = 0.2f; // Metadata: 0x007469BF
	public static Avatar_Local instance; // 0x00
	private int _cachedSFSUserId; // 0x3E8
	private static Coroutine _persistentEmoteTimer; // 0x08
	public static Color persistentDirtTargetColor; // 0x10
	public static float persistentDirtAccel; // 0x20
	public static float persistentDirtCurrentLerp; // 0x24
	private Vector3 _lastSentPosition; // 0x3EC
	private WorldObjectMoverNodeType _lastSentNodeType; // 0x3F8
	private ActorActionType _lastSentActionType; // 0x3FC
	private float _sendTimer; // 0x400

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnCreate>d__8 : IAsyncStateMachine // TypeDefIndex: 10078
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public Avatar_Local <>4__this; // 0x28
		public ActorInfo inInfo; // 0x30
		public Action<GameObject, ActorInfo> inFinishedCallback; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F7FE0-0x00000001801F7FF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public Avatar_Local(); // 0x000000018103EC20-0x000000018103EC80

	// Methods
	public static Avatar_Local CreateLocal(Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback); // 0x000000018103F700-0x000000018103F800
	[AsyncStateMachine] // 0x0000000180145E90-0x0000000180145EE0
	public override void OnCreate(ActorInfo inInfo, Action<GameObject, ActorInfo> inFinishedCallback); // 0x000000018103FA80-0x000000018103FB50
	public void SetDefault(); // 0x000000018103FE70-0x000000018103FF30
	public override void MStart(); // 0x000000018103F9D0-0x000000018103FA20
	public override void MOnEnable(); // 0x000000018103F980-0x000000018103F9D0
	public override void MOnDisable(); // 0x000000018103F930-0x000000018103F980
	public override void MOnDestroy(); // 0x000000018103F8D0-0x000000018103F930
	public static void DestroyInstance(); // 0x000000018103F800-0x000000018103F8D0
	public override void MUpdate(); // 0x000000018103FA20-0x000000018103FA80
	public override void Teleport(Vector3 inPosition, Quaternion inRotation); // 0x000000018103FF30-0x0000000181040020
	public void SendLatestMovement(); // 0x000000018103FB50-0x000000018103FE70
}

