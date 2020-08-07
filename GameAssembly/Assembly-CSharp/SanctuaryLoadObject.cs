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

public static class SanctuaryLoadObject // TypeDefIndex: 12085
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12086
	{
		// Fields
		public GameObject loadedObject; // 0x10
		public Texture2D loadedBaseTexture; // 0x18
		public Texture2D loadedBaseColorIDTexture; // 0x20
		public GameObject loadedFXAttachment; // 0x28
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x30
		public Renderer[] instanceRenderers; // 0x38

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Load>b__0(GameObject inLoadedAsset); // 0x0000000180379F20-0x0000000180379F30
		internal void <Load>b__1(Texture2D loadedAsset); // 0x0000000180379F30-0x0000000180379F40
		internal void <Load>b__2(Texture2D loadedAsset); // 0x00000001803F70C0-0x00000001803F70D0
		internal void <Load>b__3(GameObject inLoadedAsset); // 0x00000001803FA0C0-0x00000001803FA0D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_1 // TypeDefIndex: 12087
	{
		// Fields
		public int iIdx; // 0x10
		public <>c__DisplayClass0_0 CS$<>8__locals1; // 0x18
		public Action<GameObject> <>9__4; // 0x20

		// Constructors
		public <>c__DisplayClass0_1(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Load>b__4(GameObject inLoadedAsset); // 0x0000000180BFCB50-0x0000000180BFCE00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Load>d__0 : IEnumerator<object> // TypeDefIndex: 12088
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public SanctuaryObjectBase inSanctuaryObjectBase; // 0x20
		public GameObject inTargetGameObject; // 0x28
		public string modelBundleID; // 0x30
		public Transform inParentTransform; // 0x38
		public string inBundleId; // 0x40
		private <>c__DisplayClass0_0 <>8__1; // 0x48
		public Action<GameObject> inResult; // 0x50
		public Item inItem; // 0x58
		public BaseDef inDef; // 0x60
		public AssetQualityLevel inQuality; // 0x68
		public BundlePriority inPriority; // 0x6C
		private BundleDownloadCollection <bundleDownloadCollection>5__2; // 0x70

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Load>d__0(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180BF9F20-0x0000000180BFB260
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180BFB260-0x0000000180BFB780
	}

	// Methods
	[IteratorStateMachine] // 0x0000000180221120-0x0000000180221170
	public static IEnumerator Load(GameObject inTargetGameObject, Transform inParentTransform, string inBundleId, string modelBundleID, BaseDef inDef, Item inItem, SanctuaryObjectBase inSanctuaryObjectBase, AssetQualityLevel inQuality, BundlePriority inPriority, Action<GameObject> inResult); // 0x0000000180BEB080-0x0000000180BEB150
}

