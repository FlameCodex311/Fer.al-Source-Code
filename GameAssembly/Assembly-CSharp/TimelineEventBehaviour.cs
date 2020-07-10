/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TimelineEventBehaviour : PlayableBehaviour // TypeDefIndex: 11901
{
	// Fields
	public string HandlerKey; // 0x10
	public bool IsMethodWithParam; // 0x18
	public bool InvokeEventsInEditMode; // 0x19
	public GameObject TargetObject; // 0x20
	public string ArgValue; // 0x28
	private TimelineEventInvocationInfo invocationInfo; // 0x30
	private bool _hasFired; // 0x38

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 11902
	{
		// Fields
		public string methodName; // 0x10
		public bool methodWitharg; // 0x18

		// Constructors
		public <>c__DisplayClass12_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <GetInvocationInfo>b__0(MethodInfo m); // 0x0000000181A0E700-0x0000000181A0E830
	}

	// Constructors
	public TimelineEventBehaviour(); // 0x000000018037E800-0x000000018037E810

	// Methods
	public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000181A0D3D0-0x0000000181A0D440
	public override void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000181A0D380-0x0000000181A0D3D0
	public override void OnPlayableCreate(Playable playable); // 0x0000000181A0D440-0x0000000181A0D460
	public override void OnPlayableDestroy(Playable playable); // 0x0000000181A0D440-0x0000000181A0D460
	private void UpdateDelegates(); // 0x0000000181A0D460-0x0000000181A0D4B0
	private TimelineEventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, TimelineEventInvocationInfo currentInfo, bool methodWitharg); // 0x0000000181A0D180-0x0000000181A0D380
	private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName); // 0x0000000181A0CD10-0x0000000181A0D180
}

