/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TimelineEventBehaviour : PlayableBehaviour // TypeDefIndex: 13437
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass12_0 // TypeDefIndex: 13438
	{
		// Fields
		public string methodName; // 0x10
		public bool methodWitharg; // 0x18

		// Constructors
		public <>c__DisplayClass12_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <GetInvocationInfo>b__0(MethodInfo m); // 0x0000000180F92910-0x0000000180F92A40
	}

	// Constructors
	public TimelineEventBehaviour(); // 0x00000001803F46D0-0x00000001803F46E0

	// Methods
	public override void OnBehaviourPlay(Playable playable, FrameData info); // 0x0000000180F8E810-0x0000000180F8E880
	public override void OnBehaviourPause(Playable playable, FrameData info); // 0x0000000180F8E7C0-0x0000000180F8E810
	public override void OnPlayableCreate(Playable playable); // 0x0000000180F8E880-0x0000000180F8E8A0
	public override void OnPlayableDestroy(Playable playable); // 0x0000000180F8E880-0x0000000180F8E8A0
	private void UpdateDelegates(); // 0x0000000180F8E8A0-0x0000000180F8E8F0
	private TimelineEventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, TimelineEventInvocationInfo currentInfo, bool methodWitharg); // 0x0000000180F8E5C0-0x0000000180F8E7C0
	private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName); // 0x0000000180F8E180-0x0000000180F8E5C0
}

