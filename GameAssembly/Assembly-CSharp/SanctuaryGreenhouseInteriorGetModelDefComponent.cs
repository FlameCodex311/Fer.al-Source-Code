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

[ChartComponent] // 0x000000018021B5A0-0x000000018021B5D0
public class SanctuaryGreenhouseInteriorGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 12070
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12071
	{
		// Fields
		public GameObject gLoadedObject; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModelRoutine>b__0(GameObject gObject); // 0x0000000180379F20-0x0000000180379F30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetModelRoutine>d__0 : IEnumerator<object> // TypeDefIndex: 12072
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseDef inDef; // 0x20
		public Item inItem; // 0x28
		public Action<GameObject> inResult; // 0x30
		public GameObject inTargetGameObject; // 0x38
		public Transform inParentTransform; // 0x40
		public SanctuaryGreenhouseInteriorGetModelDefComponent <>4__this; // 0x48
		public AssetQualityLevel inQuality; // 0x50
		public BundlePriority inPriority; // 0x54
		private <>c__DisplayClass0_0 <>8__1; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetModelRoutine>d__0(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BBDB0-0x00000001807BC0A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BC2F0-0x00000001807BC340
	}

	// Constructors
	public SanctuaryGreenhouseInteriorGetModelDefComponent(); // 0x00000001803FE710-0x00000001803FE720

	// Methods
	[IteratorStateMachine] // 0x000000018021B990-0x000000018021B9E0
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B94DB */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B94DF */); // 0x00000001807B4CC0-0x00000001807B4D70
}

