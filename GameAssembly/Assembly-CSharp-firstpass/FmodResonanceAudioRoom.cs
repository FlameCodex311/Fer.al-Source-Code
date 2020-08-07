/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

[AddComponentMenu] // 0x00000001801E5470-0x00000001801E54A0
public class FmodResonanceAudioRoom : UnityEngine.MonoBehaviour // TypeDefIndex: 9691
{
	// Fields
	public SurfaceMaterial leftWall; // 0x18
	public SurfaceMaterial rightWall; // 0x1C
	public SurfaceMaterial floor; // 0x20
	public SurfaceMaterial ceiling; // 0x24
	public SurfaceMaterial backWall; // 0x28
	public SurfaceMaterial frontWall; // 0x2C
	public float reflectivity; // 0x30
	public float reverbGainDb; // 0x34
	public float reverbBrightness; // 0x38
	public float reverbTime; // 0x3C
	public Vector3 size; // 0x40

	// Nested types
	public enum SurfaceMaterial // TypeDefIndex: 9692
	{
		Transparent = 0,
		AcousticCeilingTiles = 1,
		BrickBare = 2,
		BrickPainted = 3,
		ConcreteBlockCoarse = 4,
		ConcreteBlockPainted = 5,
		CurtainHeavy = 6,
		FiberglassInsulation = 7,
		GlassThin = 8,
		GlassThick = 9,
		Grass = 10,
		LinoleumOnConcrete = 11,
		Marble = 12,
		Metal = 13,
		ParquetOnConcrete = 14,
		PlasterRough = 15,
		PlasterSmooth = 16,
		PlywoodPanel = 17,
		PolishedConcreteOrTile = 18,
		Sheetrock = 19,
		WaterOrIceSurface = 20,
		WoodCeiling = 21,
		WoodPanel = 22
	}

	// Constructors
	public FmodResonanceAudioRoom(); // 0x0000000180D23D30-0x0000000180D23DE0

	// Methods
	private void OnEnable(); // 0x0000000180D23C70-0x0000000180D23CD0
	private void OnDisable(); // 0x0000000180D23B00-0x0000000180D23B60
	private void Update(); // 0x0000000180D23CD0-0x0000000180D23D30
	private void OnDrawGizmosSelected(); // 0x0000000180D23B60-0x0000000180D23C70
}

