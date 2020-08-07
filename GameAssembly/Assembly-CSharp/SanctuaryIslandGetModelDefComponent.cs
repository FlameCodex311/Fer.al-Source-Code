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

[ChartComponent] // 0x00000001802371D0-0x0000000180237200
public class SanctuaryIslandGetModelDefComponent : DefComponent // TypeDefIndex: 12134
{
	// Properties
	public virtual string BundleID { get; } // 0x0000000180BEA8F0-0x0000000180BEA9C0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12135
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Material loadedBaseMaterial; // 0x18
		public Texture2D loadedBaseTexture; // 0x20
		public Texture2D loadedBaseColorIDTexture; // 0x28
		public GameObject loadedFXAttachment; // 0x30

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <GetSanctuaryIslandModelRoutine>b__0(GameObject inLoadedAsset); // 0x000000018068E960-0x000000018068E990
		internal void <GetSanctuaryIslandModelRoutine>b__1(GameObject inLoadedAsset); // 0x000000018068E960-0x000000018068E990
		internal void <GetSanctuaryIslandModelRoutine>b__2(Material loadedAsset); // 0x0000000180379F30-0x0000000180379F40
		internal void <GetSanctuaryIslandModelRoutine>b__3(Texture2D loadedAsset); // 0x00000001803F70C0-0x00000001803F70D0
		internal void <GetSanctuaryIslandModelRoutine>b__4(Texture2D loadedAsset); // 0x00000001803FA0C0-0x00000001803FA0D0
		internal void <GetSanctuaryIslandModelRoutine>b__5(GameObject inLoadedAsset); // 0x00000001803FA0A0-0x00000001803FA0B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetSanctuaryIslandModelRoutine>d__3 : IEnumerator<object> // TypeDefIndex: 12136
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetSanctuaryIslandModelRoutine>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BF84C0-0x0000000180BF9890
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BF9890-0x0000000180BF98E0
	}

	// Constructors
	public SanctuaryIslandGetModelDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x007B9581 */, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9582 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B9586 */); // 0x0000000180BEA6E0-0x0000000180BEA840
	[IteratorStateMachine] // 0x0000000180237530-0x0000000180237580
	private IEnumerator GetSanctuaryIslandModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, bool inInSanctuary = false /* Metadata: 0x007B958A */, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B958B */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B958F */); // 0x0000000180BEA840-0x0000000180BEA8F0
}

