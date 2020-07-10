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

public class GetModelDefComponent : DefComponent // TypeDefIndex: 10236
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool useStageOverrides; // 0x18
	[ChartFloat] // 0x00000001800B5960-0x00000001800B5970
	public float stageOverrideScale; // 0x1C
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 stageOverrideOffset; // 0x20
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 stageOverrideRotation; // 0x2C

	// Properties
	public virtual string BundleID { get; } // 0x0000000181055B90-0x0000000181055C70 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 10237
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <GetModelRoutine>b__0(GameObject inLoadedAsset); // 0x0000000181066220-0x0000000181066250
		internal void <GetModelRoutine>b__1(GameObject inLoadedAsset); // 0x0000000181066220-0x0000000181066250
		internal void <GetModelRoutine>b__2(Texture2D loadedAsset); // 0x000000018038B160-0x000000018038B170
		internal void <GetModelRoutine>b__3(Texture2D loadedAsset); // 0x000000018036AC90-0x000000018036ACA0
		internal void <GetModelRoutine>b__4(GameObject inLoadedAsset); // 0x0000000180422D30-0x0000000180422D40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetModelRoutine>d__7 : IEnumerator<object> // TypeDefIndex: 10238
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GetModelDefComponent <>4__this; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public Transform inParentTransform; // 0x30
		public AssetQualityLevel inQuality; // 0x38
		public BundlePriority inPriority; // 0x3C
		private <>c__DisplayClass7_0 <>8__1; // 0x40
		public Action<GameObject> inResult; // 0x48
		public Item inItem; // 0x50
		public BaseDef inDef; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetModelRoutine>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181060520-0x0000000181061680
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181061680-0x0000000181061E80
	}

	// Constructors
	public GetModelDefComponent(); // 0x0000000181055B00-0x0000000181055B90

	// Methods
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781AED */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781AF1 */); // 0x00000001810559A0-0x0000000181055B00
	[IteratorStateMachine] // 0x00000001800B5CB0-0x00000001800B5D00
	protected virtual IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781AF5 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781AF9 */); // 0x00000001810558F0-0x00000001810559A0
	protected override void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
}

