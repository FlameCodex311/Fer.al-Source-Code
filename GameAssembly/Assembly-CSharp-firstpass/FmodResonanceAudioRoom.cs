/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

[AddComponentMenu] // 0x0000000180115640-0x0000000180115670
public class FmodResonanceAudioRoom : UnityEngine.MonoBehaviour // TypeDefIndex: 9287
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
	public enum SurfaceMaterial // TypeDefIndex: 9288
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
	public FmodResonanceAudioRoom(); // 0x00000001816500A0-0x0000000181650150

	// Methods
	private void OnEnable(); // 0x000000018164FFE0-0x0000000181650040
	private void OnDisable(); // 0x000000018164FE70-0x000000018164FED0
	private void Update(); // 0x0000000181650040-0x00000001816500A0
	private void OnDrawGizmosSelected(); // 0x000000018164FED0-0x000000018164FFE0
}

