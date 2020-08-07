/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018028D4A0-0x000000018028D4D0
public class ActorInfoGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 12398
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12399
	{
		// Fields
		public BaseInfo inInfo; // 0x10
		public Action<GameObject> inResult; // 0x18
		public Action<GameObject, ActorInfo> <>9__1; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModelRoutine>b__0(QRoutine inQRoutine); // 0x00000001821EB880-0x00000001821EBA60
		internal void <GetModelRoutine>b__1(GameObject inGameObject, ActorInfo inActorInfo); // 0x00000001821EBC00-0x00000001821EBC70
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetModelRoutine>d__0 : IEnumerator<object> // TypeDefIndex: 12400
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseInfo inInfo; // 0x20
		public Action<GameObject> inResult; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetModelRoutine>d__0(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001821E16C0-0x00000001821E17F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001821E1920-0x00000001821E1970
	}

	// Constructors
	public ActorInfoGetModelDefComponent(); // 0x00000001803FE710-0x00000001803FE720

	// Methods
	[IteratorStateMachine] // 0x000000018028D620-0x000000018028D670
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B97FA */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B97FE */); // 0x00000001821D8F70-0x00000001821D8FE0
}

