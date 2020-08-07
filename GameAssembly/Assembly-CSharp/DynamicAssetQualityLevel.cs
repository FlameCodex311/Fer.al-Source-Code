/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class DynamicAssetQualityLevel // TypeDefIndex: 11115
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private AssetQualityLevel _targetQualityLevel; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _forced; // 0x14
	private AssetQualityLevel? _qualityLevel; // 0x18

	// Properties
	public AssetQualityLevel QualityLevel { get; } // 0x00000001808567B0-0x0000000180856860 

	// Constructors
	public DynamicAssetQualityLevel(); // 0x00000001808567A0-0x00000001808567B0

	// Methods
	public void Set(AssetQualityLevel inTargetQualityLevel, bool inForced); // 0x0000000180856790-0x00000001808567A0
}

