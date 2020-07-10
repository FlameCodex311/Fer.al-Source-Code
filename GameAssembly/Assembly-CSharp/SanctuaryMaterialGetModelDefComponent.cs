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

[ChartComponent] // 0x000000018013F910-0x000000018013F940
public class SanctuaryMaterialGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 10585
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 10586
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Material loadedMaterial; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(GameObject inLoadedAsset); // 0x0000000181066220-0x0000000181066250
		internal void <GetModelRoutine>b__1(Material material); // 0x000000018038B160-0x000000018038B170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetModelRoutine>d__0 : IEnumerator<object> // TypeDefIndex: 10587
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryMaterialGetModelDefComponent <>4__this; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public Transform inParentTransform; // 0x30
		public AssetQualityLevel inQuality; // 0x38
		public BundlePriority inPriority; // 0x3C
		private <>c__DisplayClass0_0 <>8__1; // 0x40
		public Action<GameObject> inResult; // 0x48
		public Item inItem; // 0x50
		public BaseDef inDef; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetModelRoutine>d__0(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181372010-0x0000000181372C10
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001813742E0-0x0000000181374330
	}

	// Constructors
	public SanctuaryMaterialGetModelDefComponent(); // 0x000000018128AF80-0x000000018128AF90

	// Methods
	[IteratorStateMachine] // 0x000000018013FAC0-0x000000018013FB10
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781E38 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781E3C */); // 0x0000000181364010-0x00000001813640C0
}

