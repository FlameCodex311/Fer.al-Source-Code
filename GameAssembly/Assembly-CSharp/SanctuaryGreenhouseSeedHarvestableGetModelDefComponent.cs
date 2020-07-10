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

[ChartComponent] // 0x000000018013E380-0x000000018013E3B0
public class SanctuaryGreenhouseSeedHarvestableGetModelDefComponent : GetModelDefComponent // TypeDefIndex: 10578
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 10579
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(GameObject inLoadedAsset); // 0x000000018036B1E0-0x000000018036B1F0
		internal void <GetModelRoutine>b__1(Texture2D loadedAsset); // 0x000000018038B160-0x000000018038B170
		internal void <GetModelRoutine>b__2(Texture2D loadedAsset); // 0x000000018036AC90-0x000000018036ACA0
		internal void <GetModelRoutine>b__3(GameObject inLoadedAsset); // 0x0000000180422D30-0x0000000180422D40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetModelRoutine>d__0 : IEnumerator<object> // TypeDefIndex: 10580
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public BaseDef inDef; // 0x20
		public Item inItem; // 0x28
		public Action<GameObject> inResult; // 0x30
		public GameObject inTargetGameObject; // 0x38
		public Transform inParentTransform; // 0x40
		public SanctuaryGreenhouseSeedHarvestableGetModelDefComponent <>4__this; // 0x48
		private <>c__DisplayClass0_0 <>8__1; // 0x50
		private BundleDownloadCollection <bundleDownloadCollection>5__2; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetModelRoutine>d__0(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001812970B0-0x0000000181298180
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001812992A0-0x00000001812992F0
	}

	// Constructors
	public SanctuaryGreenhouseSeedHarvestableGetModelDefComponent(); // 0x000000018128AF80-0x000000018128AF90

	// Methods
	[IteratorStateMachine] // 0x000000018013E4A0-0x000000018013E4F0
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781E28 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781E2C */); // 0x000000018128AED0-0x000000018128AF80
}

