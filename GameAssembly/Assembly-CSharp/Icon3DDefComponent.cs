/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800BB030-0x00000001800BB060
public class Icon3DDefComponent : DefComponent // TypeDefIndex: 10251
{
	// Fields
	[ChartVector3] // 0x00000001800B5960-0x00000001800B5970
	public Vector3 rotation; // 0x18
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool useAutoCentering; // 0x24
	[ChartFloat] // 0x00000001800BB4D0-0x00000001800BB510
	public float scale; // 0x28
	[ChartVector3] // 0x00000001800BB4D0-0x00000001800BB510
	public Vector3 offset; // 0x2C

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0 // TypeDefIndex: 10252
	{
		// Fields
		public Transform inParentTransform; // 0x10
		public Action<GameObject> inResult; // 0x18

		// Constructors
		public <>c__DisplayClass4_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Get3DIconModel>b__0(GameObject inGameObject); // 0x0000000180F701E0-0x0000000180F70390
	}

	// Constructors
	public Icon3DDefComponent(); // 0x0000000180F572D0-0x0000000180F57360

	// Methods
	public QRoutine Get3DIconModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, Item inItem = null, BaseDef inDef = null, BaseInfo inInfo = null, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781B0D */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781B11 */); // 0x0000000180F571C0-0x0000000180F572D0
}

