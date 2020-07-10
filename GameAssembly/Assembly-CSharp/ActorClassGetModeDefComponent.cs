/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800E9FD0-0x00000001800EA000
public class ActorClassGetModeDefComponent : GetModelDefComponent // TypeDefIndex: 10872
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 10873
	{
		// Fields
		public BaseDef inDef; // 0x10
		public Action<GameObject> inResult; // 0x18
		public Action<GameObject, ActorInfo> <>9__1; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(QRoutine inQRoutine); // 0x000000018141C660-0x000000018141C800
		internal void <GetModelRoutine>b__1(GameObject inGameObject, ActorInfo inActorInfo); // 0x000000018141C870-0x000000018141C8E0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetModelRoutine>d__0 : IEnumerator<object> // TypeDefIndex: 10874
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseDef inDef; // 0x20
		public Action<GameObject> inResult; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetModelRoutine>d__0(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181412240-0x0000000181412370
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001814123C0-0x0000000181412410
	}

	// Constructors
	public ActorClassGetModeDefComponent(); // 0x000000018128AF80-0x000000018128AF90

	// Methods
	[IteratorStateMachine] // 0x00000001800EA0B0-0x00000001800EA100
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007820AE */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007820B2 */); // 0x0000000181404400-0x0000000181404470
}

