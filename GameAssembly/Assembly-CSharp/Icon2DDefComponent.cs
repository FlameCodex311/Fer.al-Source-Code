/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800BABB0-0x00000001800BABE0
public class Icon2DDefComponent : DefComponent // TypeDefIndex: 10250
{
	// Fields
	[ChartDef] // 0x00000001800BAE00-0x00000001800BAE90
	public string imageDefID; // 0x18

	// Properties
	public ImageDefComponent IconImageDef { get; } // 0x0000000180F57160-0x0000000180F571C0 

	// Constructors
	public Icon2DDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public virtual QRoutine Get2DIconTexture(GameObject inReferenceGameObject, Action<Texture2D> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781AFD */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781B01 */); // 0x0000000180F57070-0x0000000180F57160
	public virtual QRoutine Get2DIconSprite(GameObject inReferenceGameObject, Action<Sprite> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None /* Metadata: 0x00781B05 */, BundlePriority inPriority = BundlePriority.Normal /* Metadata: 0x00781B09 */); // 0x0000000180F56F80-0x0000000180F57070
}

