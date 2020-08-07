/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x000000018024D690-0x000000018024D6C0
public class Icon2DDefComponent : DefComponent // TypeDefIndex: 11741
{
	// Fields
	[ChartDef] // 0x000000018024D910-0x000000018024D9A0
	public string imageDefID; // 0x18

	// Properties
	public ImageDefComponent IconImageDef { get; } // 0x00000001806204A0-0x0000000180620500 

	// Constructors
	public Icon2DDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public virtual QRoutine Get2DIconTexture(GameObject inReferenceGameObject, Action<Texture2D> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B9198 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B919C */); // 0x00000001806203B0-0x00000001806204A0
	public virtual QRoutine Get2DIconSprite(GameObject inReferenceGameObject, Action<Sprite> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x007B91A0 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x007B91A4 */); // 0x00000001806202C0-0x00000001806203B0
}

