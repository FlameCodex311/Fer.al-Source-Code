/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SanctuaryGreenHouseInterior : ManagedBehaviour // TypeDefIndex: 13270
{
	// Fields
	public List<SanctuaryGreenHouseBox> sanctuaryGreenHouseBoxes; // 0x50
	private int _boxIndex; // 0x58
	private int _plotIndex; // 0x5C
	public Transform spawn; // 0x60
	public List<Transform> exitVolumes; // 0x68
	public List<Transform> cameraMounts; // 0x70
	public List<Transform> cameraInteracts; // 0x78
	public List<SanctuaryGreenHouseCameraInteractable> cameraInteractables; // 0x80
	private List<SeedDefComponent> _seeds; // 0x88
	private Vector2 _scroll; // 0x90
	private Rect _guiWindowRect; // 0x98

	// Constructors
	public SanctuaryGreenHouseInterior(); // 0x00000001807B21D0-0x00000001807B2360

	// Methods
	public override void MStart(); // 0x00000001807B14B0-0x00000001807B1610
	public override void MOnDestroy(); // 0x00000001807B1390-0x00000001807B14B0
	public void TeleportToSpawn(); // 0x00000001807B2010-0x00000001807B21D0
	public void EnableCamera(SanctuaryGreenHouseCameraInteractable inSanctuaryGreenHouseCameraInteractable); // 0x00000001807B0DA0-0x00000001807B0FF0
	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseWater inMessage); // 0x00000001807B1800-0x00000001807B18B0
	private void OnSanctuaryGreenhousePlant(SanctuaryGreenhousePlant inMessage); // 0x00000001807B1730-0x00000001807B1800
	private void OnSanctuaryGreenhouseHarvest(SanctuaryGreenhouseMatured inMessage); // 0x00000001807B1610-0x00000001807B1730
	private void SetupCameraInteracts(SanctuaryGreenhouseDefComponent inDefComponent); // 0x00000001807B1D20-0x00000001807B2010
	private void SetupBoxes(SanctuaryGreenhouseDefComponent inDefComponent, string inName, SanctuaryGreenHouseBox.EType inType); // 0x00000001807B1A90-0x00000001807B1D20
	private void OnTriggerEnter(Collider inCollider); // 0x00000001807B18B0-0x00000001807B19A0
	private void OnTriggerExit(Collider inCollider); // 0x00000001807B19A0-0x00000001807B1A90
	private void GetAllSeeds(); // 0x00000001807B0FF0-0x00000001807B11C0
	private bool CanWater(); // 0x00000001807B0520-0x00000001807B0700
	private bool HitPlot(Transform inTransform); // 0x00000001807B11C0-0x00000001807B1390
	private void CreateInteriorVolumeTrigger(); // 0x00000001807B0700-0x00000001807B0CC0
	private void DestroyMeshRenderer(GameObject inGameObject); // 0x00000001807B0CC0-0x00000001807B0DA0
}

