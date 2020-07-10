/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class DynamicAssetQualityLevel // TypeDefIndex: 13444
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private AssetQualityLevel _targetQualityLevel; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _forced; // 0x14
	private AssetQualityLevel? _qualityLevel; // 0x18

	// Properties
	public AssetQualityLevel QualityLevel { get; } // 0x0000000181189AD0-0x0000000181189B80 

	// Constructors
	public DynamicAssetQualityLevel(); // 0x0000000181189AC0-0x0000000181189AD0

	// Methods
	public void Set(AssetQualityLevel inTargetQualityLevel, bool inForced); // 0x0000000181189AB0-0x0000000181189AC0
}

