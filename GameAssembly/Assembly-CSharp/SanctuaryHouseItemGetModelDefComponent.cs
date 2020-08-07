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

[ChartComponent] // 0x0000000180235910-0x0000000180235940
public class SanctuaryHouseItemGetModelDefComponent : DefComponent // TypeDefIndex: 12129
{
	// Properties
	public virtual string BundleID { get; } // 0x00000001807B8520-0x00000001807B85F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12130
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetSanctuaryModelRoutine>b__0(GameObject inLoadedAsset); // 0x00000001807C2DC0-0x00000001807C2E90
		internal void <GetSanctuaryModelRoutine>b__1(GameObject inLoadedAsset); // 0x00000001807C2E90-0x00000001807C2F60
		internal void <GetSanctuaryModelRoutine>b__2(Texture2D loadedAsset); // 0x0000000180379F30-0x0000000180379F40
		internal void <GetSanctuaryModelRoutine>b__3(Texture2D loadedAsset); // 0x00000001803F70C0-0x00000001803F70D0
		internal void <GetSanctuaryModelRoutine>b__4(GameObject inLoadedAsset); // 0x00000001803FA0C0-0x00000001803FA0D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetSanctuaryModelRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 12131
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryHouseItemGetModelDefComponent <>4__this; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public Transform inParentTransform; // 0x30
		public AssetQualityLevel inQuality; // 0x38
		public BundlePriority inPriority; // 0x3C
		private <>c__DisplayClass3_0 <>8__1; // 0x40
		public Action<GameObject> inResult; // 0x48
		public Item inItem; // 0x50
		public BaseDef inDef; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetSanctuaryModelRoutine>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807BD1D0-0x00000001807BE320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001807BE320-0x00000001807BE370
	}

	// Constructors
	public SanctuaryHouseItemGetModelDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public virtual QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9569 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B956D */); // 0x00000001807B8310-0x00000001807B8470
	[IteratorStateMachine] // 0x0000000180235C70-0x0000000180235CC0
	private IEnumerator GetSanctuaryModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9571 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B9575 */); // 0x00000001807B8470-0x00000001807B8520
}

