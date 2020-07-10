/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryGreenHouse : ManagedBehaviour // TypeDefIndex: 11735
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static SanctuaryGreenHouse <instance>k__BackingField; // 0x00
	private List<SanctuaryGreenHouseBox> _boxes; // 0x50
	private int _boxIndex; // 0x58
	private int _plotIndex; // 0x5C
	private Transform _interiorSpawn; // 0x60
	private Transform _interiorExitVolume; // 0x68
	private Transform _exteriorSpawn; // 0x70
	private Transform _exteriorEnterVolume; // 0x78
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static bool <insideGreenhouse>k__BackingField; // 0x08
	[Header] // 0x0000000180105A30-0x0000000180105A60
	private Vector3 _cameraStartPosition; // 0x80
	private Quaternion _cameraStartRotation; // 0x8C
	private List<SanctuaryGreenhouseSeedDefComponent> _seeds; // 0xA0
	private Vector2 _scroll; // 0xA8
	private Rect _guiWindowRect; // 0xB0

	// Properties
	public static SanctuaryGreenHouse instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018128AC00-0x000000018128AC40 0x000000018128AC80-0x000000018128ACC0
	public static bool insideGreenhouse { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018128ABC0-0x000000018128AC00 0x000000018128AC40-0x000000018128AC80

	// Constructors
	public SanctuaryGreenHouse(); // 0x000000018128AA00-0x000000018128ABC0

	// Methods
	public override void MStart(); // 0x00000001812895B0-0x0000000181289760
	public override void MOnDestroy(); // 0x0000000181289400-0x00000001812895B0
	public void Setup(SanctuaryGreenhouseDefComponent inSanctuaryGreenhouseDefComponent, GameObject inExteriorGreenhouse); // 0x000000018128A6D0-0x000000018128AA00
	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseWater inMessage); // 0x0000000181289F70-0x000000018128A020
	private void OnSanctuaryGreenhousePlant(SanctuaryGreenhousePlant inMessage); // 0x0000000181289EA0-0x0000000181289F70
	private void OnSanctuaryGreenhouseHarvest(SanctuaryGreenhouseHarvest inMessage); // 0x0000000181289DD0-0x0000000181289EA0
	private void SetupBoxes(SanctuaryGreenhouseDefComponent inDefComponent, string inName, SanctuaryGreenHouseBox.EType inType); // 0x000000018128A2D0-0x000000018128A6D0
	private void OnTriggerEnter(Collider inCollider); // 0x000000018128A020-0x000000018128A110
	private void OnTriggerExit(Collider inCollider); // 0x000000018128A110-0x000000018128A200
	private void OnSanctuaryGreenhouseEntered(SanctuaryGreenhouseEntered inMessage); // 0x0000000181289D80-0x0000000181289DD0
	private void GetAllSeeds(); // 0x0000000181289050-0x0000000181289220
	private bool CanWater(); // 0x0000000181288E60-0x0000000181289050
	public override void MUpdate(); // 0x0000000181289760-0x0000000181289D80
	private void ResetCamera(); // 0x000000018128A200-0x000000018128A2D0
	private bool HitPlot(Transform inTransform); // 0x0000000181289220-0x0000000181289400
}

