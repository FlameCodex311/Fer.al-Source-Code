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

[ChartComponent] // 0x0000000180158590-0x00000001801585C0
public class SanctuaryIslandGetModelDefComponent : DefComponent // TypeDefIndex: 10633
{
	// Properties
	public virtual string BundleID { get; } // 0x0000000181362070-0x0000000181362150 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 10634
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Material loadedBaseMaterial; // 0x18
		public Texture2D loadedBaseTexture; // 0x20
		public Texture2D loadedBaseColorIDTexture; // 0x28
		public GameObject loadedFXAttachment; // 0x30

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetSanctuaryIslandModelRoutine>b__0(GameObject inLoadedAsset); // 0x0000000181066220-0x0000000181066250
		internal void <GetSanctuaryIslandModelRoutine>b__1(GameObject inLoadedAsset); // 0x0000000181066220-0x0000000181066250
		internal void <GetSanctuaryIslandModelRoutine>b__2(Material loadedAsset); // 0x000000018038B160-0x000000018038B170
		internal void <GetSanctuaryIslandModelRoutine>b__3(Texture2D loadedAsset); // 0x000000018036AC90-0x000000018036ACA0
		internal void <GetSanctuaryIslandModelRoutine>b__4(Texture2D loadedAsset); // 0x0000000180422D30-0x0000000180422D40
		internal void <GetSanctuaryIslandModelRoutine>b__5(GameObject inLoadedAsset); // 0x00000001803A2800-0x00000001803A2810
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetSanctuaryIslandModelRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 10635
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryIslandGetModelDefComponent <>4__this; // 0x20
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
		public <GetSanctuaryIslandModelRoutine>d__3(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181374330-0x0000000181375790
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181375790-0x00000001813759C0
	}

	// Constructors
	public SanctuaryIslandGetModelDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x00781EBE */, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781EBF */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781EC3 */); // 0x0000000181361E60-0x0000000181361FC0
	[IteratorStateMachine] // 0x00000001801587C0-0x0000000180158810
	private IEnumerator GetSanctuaryIslandModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x00781EC7 */, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781EC8 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781ECC */); // 0x0000000181361FC0-0x0000000181362070
}

