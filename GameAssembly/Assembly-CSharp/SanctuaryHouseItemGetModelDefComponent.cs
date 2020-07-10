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

[ChartComponent] // 0x0000000180156EB0-0x0000000180156EE0
public class SanctuaryHouseItemGetModelDefComponent : DefComponent // TypeDefIndex: 10628
{
	// Properties
	public virtual string BundleID { get; } // 0x000000018128E940-0x000000018128EA20 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 10629
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetSanctuaryModelRoutine>b__0(GameObject inLoadedAsset); // 0x000000018129FD80-0x000000018129FE50
		internal void <GetSanctuaryModelRoutine>b__1(GameObject inLoadedAsset); // 0x000000018129FE50-0x000000018129FF20
		internal void <GetSanctuaryModelRoutine>b__2(Texture2D loadedAsset); // 0x000000018038B160-0x000000018038B170
		internal void <GetSanctuaryModelRoutine>b__3(Texture2D loadedAsset); // 0x000000018036AC90-0x000000018036ACA0
		internal void <GetSanctuaryModelRoutine>b__4(GameObject inLoadedAsset); // 0x0000000180422D30-0x0000000180422D40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetSanctuaryModelRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 10630
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetSanctuaryModelRoutine>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018129A110-0x000000018129B2E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018129B2E0-0x000000018129B330
	}

	// Constructors
	public SanctuaryHouseItemGetModelDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public virtual QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781EA6 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781EAA */); // 0x000000018128E730-0x000000018128E890
	[IteratorStateMachine] // 0x00000001801570F0-0x0000000180157140
	private IEnumerator GetSanctuaryModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781EAE */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781EB2 */); // 0x000000018128E890-0x000000018128E940
}

