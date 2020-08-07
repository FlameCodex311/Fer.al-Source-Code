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

public class GetModelDefComponent : DefComponent // TypeDefIndex: 11727
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool useStageOverrides; // 0x18
	[ChartFloat] // 0x00000001801DE450-0x00000001801DE460
	public float stageOverrideScale; // 0x1C
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 stageOverrideOffset; // 0x20
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 stageOverrideRotation; // 0x2C

	// Properties
	public virtual string BundleID { get; } // 0x0000000180680A70-0x0000000180680B40 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 11728
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetModelRoutine>b__0(GameObject inLoadedAsset); // 0x000000018068E960-0x000000018068E990
		internal void <GetModelRoutine>b__1(GameObject inLoadedAsset); // 0x000000018068E960-0x000000018068E990
		internal void <GetModelRoutine>b__2(Texture2D loadedAsset); // 0x0000000180379F30-0x0000000180379F40
		internal void <GetModelRoutine>b__3(Texture2D loadedAsset); // 0x00000001803F70C0-0x00000001803F70D0
		internal void <GetModelRoutine>b__4(GameObject inLoadedAsset); // 0x00000001803FA0C0-0x00000001803FA0D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetModelRoutine>d__7 : IEnumerator<object> // TypeDefIndex: 11729
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetModelRoutine>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180688560-0x0000000180689650
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180689650-0x0000000180689E50
	}

	// Constructors
	public GetModelDefComponent(); // 0x00000001806809E0-0x0000000180680A70

	// Methods
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9188 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B918C */); // 0x0000000180680880-0x00000001806809E0
	[IteratorStateMachine] // 0x0000000180249230-0x0000000180249280
	protected virtual IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9190 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B9194 */); // 0x00000001806807D0-0x0000000180680880
	protected override void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
}

