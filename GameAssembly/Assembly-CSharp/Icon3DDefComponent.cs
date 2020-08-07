/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018024DF50-0x000000018024DF80
public class Icon3DDefComponent : DefComponent // TypeDefIndex: 11742
{
	// Fields
	[ChartVector3] // 0x00000001801DE450-0x00000001801DE460
	public Vector3 rotation; // 0x18
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool useAutoCentering; // 0x24
	[ChartFloat] // 0x000000018024E410-0x000000018024E450
	public float scale; // 0x28
	[ChartVector3] // 0x000000018024E410-0x000000018024E450
	public Vector3 offset; // 0x2C

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 11743
	{
		// Fields
		public Transform inParentTransform; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Get3DIconModel>b__0(GameObject inGameObject); // 0x0000000180631490-0x0000000180631640
	}

	// Constructors
	public Icon3DDefComponent(); // 0x0000000180620610-0x00000001806206A0

	// Methods
	public QRoutine Get3DIconModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B91A8 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B91AC */); // 0x0000000180620500-0x0000000180620610
}

