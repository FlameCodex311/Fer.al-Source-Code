/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FourCrowsAudio : MonoBehaviour // TypeDefIndex: 10685
{
	// Fields
	private static FourCrowsAudio _instance; // 0x00
	[Tooltip] // 0x0000000180252CF0-0x0000000180252D20
	public FeralAudioInfo branchMove; // 0x20
	[Tooltip] // 0x0000000180252F40-0x0000000180252F70
	public FeralAudioInfo cardPlaced; // 0x28
	[Tooltip] // 0x0000000180253170-0x00000001802531A0
	public FeralAudioInfo cardSelect; // 0x30
	[Tooltip] // 0x0000000180253310-0x0000000180253340
	public FeralAudioInfo cardRetract; // 0x38
	[Tooltip] // 0x00000001802534D0-0x0000000180253500
	public FeralAudioInfo crowBanished; // 0x40
	[Tooltip] // 0x00000001802536C0-0x00000001802536F0
	public FeralAudioInfo crowCaw; // 0x48
	[Tooltip] // 0x00000001802537A0-0x00000001802537D0
	public FeralAudioInfo crowCawDeath; // 0x50
	[Tooltip] // 0x0000000180253A50-0x0000000180253A80
	public FeralAudioInfo crowSpawn; // 0x58
	[Tooltip] // 0x0000000180253C40-0x0000000180253C70
	public FeralAudioInfo dealCard; // 0x60
	[Tooltip] // 0x0000000180253E70-0x0000000180253EA0
	public FeralAudioInfo treeMaterialize; // 0x68
	[Tooltip] // 0x0000000180254070-0x00000001802540A0
	public FeralAudioInfo treeMaterializeLP; // 0x70
	[Tooltip] // 0x0000000180254230-0x0000000180254260
	public FeralAudioInfo branchReattach; // 0x78
	[Tooltip] // 0x0000000180254410-0x0000000180254440
	public FeralAudioInfo branchSnap; // 0x80
	[Tooltip] // 0x00000001802545A0-0x00000001802545D0
	public FeralAudioInfo branchCrackle; // 0x88
	[Tooltip] // 0x0000000180254740-0x0000000180254770
	public FeralAudioInfo crowFlap; // 0x90
	[Tooltip] // 0x00000001802547F0-0x0000000180254820
	public FeralAudioInfo treeVanish; // 0x98

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001806A1990-0x00000001806A1A20 

	// Constructors
	public FourCrowsAudio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001806A1190-0x00000001806A11D0
	public static void PlayBranchMove(); // 0x00000001806A1240-0x00000001806A12B0
	public static void PlayCardPlaced(); // 0x00000001806A1390-0x00000001806A1400
	public static void PlayCardSelect(); // 0x00000001806A1470-0x00000001806A14E0
	public static void PlayCardRetract(); // 0x00000001806A1400-0x00000001806A1470
	public static void PlayCrowBanished(); // 0x00000001806A14E0-0x00000001806A1550
	public static void PlayCrowCaw(); // 0x00000001806A15C0-0x00000001806A1630
	public static void PlayCrowCawDeath(); // 0x00000001806A1550-0x00000001806A15C0
	public static void PlayCrowSpawn(); // 0x00000001806A16A0-0x00000001806A1710
	public static void PlayDealCard(); // 0x00000001806A1710-0x00000001806A1780
	public static void PlayTreeMaterialize(); // 0x00000001806A18B0-0x00000001806A1920
	public static void PlayMusic_TreeMaterialize(bool inPlay); // 0x00000001806A1780-0x00000001806A18B0
	public static void PlayBranchReattach(); // 0x00000001806A12B0-0x00000001806A1320
	public static void PlayBranchSnap(); // 0x00000001806A1320-0x00000001806A1390
	public static void PlayBranchCrackle(); // 0x00000001806A11D0-0x00000001806A1240
	public static void PlayCrowFlap(); // 0x00000001806A1630-0x00000001806A16A0
	public static void PlayTreeVanish(); // 0x00000001806A1920-0x00000001806A1990
}

