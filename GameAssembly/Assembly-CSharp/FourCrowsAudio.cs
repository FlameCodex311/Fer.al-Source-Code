/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FourCrowsAudio : MonoBehaviour // TypeDefIndex: 13020
{
	// Fields
	private static FourCrowsAudio _instance; // 0x00
	[Tooltip] // 0x00000001800B7A30-0x00000001800B7A60
	public FeralAudioInfo branchMove; // 0x20
	[Tooltip] // 0x00000001800B7E00-0x00000001800B7E30
	public FeralAudioInfo cardPlaced; // 0x28
	[Tooltip] // 0x00000001800B7F30-0x00000001800B7F60
	public FeralAudioInfo cardSelect; // 0x30
	[Tooltip] // 0x00000001800B80D0-0x00000001800B8100
	public FeralAudioInfo cardRetract; // 0x38
	[Tooltip] // 0x00000001800B8390-0x00000001800B83C0
	public FeralAudioInfo crowBanished; // 0x40
	[Tooltip] // 0x00000001800B8660-0x00000001800B8690
	public FeralAudioInfo crowCaw; // 0x48
	[Tooltip] // 0x00000001800B88F0-0x00000001800B8920
	public FeralAudioInfo crowCawDeath; // 0x50
	[Tooltip] // 0x00000001800B8AA0-0x00000001800B8AD0
	public FeralAudioInfo crowSpawn; // 0x58
	[Tooltip] // 0x00000001800B8C50-0x00000001800B8C80
	public FeralAudioInfo dealCard; // 0x60
	[Tooltip] // 0x00000001800B8E50-0x00000001800B8E80
	public FeralAudioInfo treeMaterialize; // 0x68
	[Tooltip] // 0x00000001800BA350-0x00000001800BA380
	public FeralAudioInfo treeMaterializeLP; // 0x70
	[Tooltip] // 0x00000001800BA4B0-0x00000001800BA4E0
	public FeralAudioInfo branchReattach; // 0x78
	[Tooltip] // 0x00000001800BA5C0-0x00000001800BA5F0
	public FeralAudioInfo branchSnap; // 0x80
	[Tooltip] // 0x00000001800BA760-0x00000001800BA790
	public FeralAudioInfo branchCrackle; // 0x88
	[Tooltip] // 0x00000001800BA990-0x00000001800BA9C0
	public FeralAudioInfo crowFlap; // 0x90
	[Tooltip] // 0x00000001800BAB50-0x00000001800BAB80
	public FeralAudioInfo treeVanish; // 0x98

	// Properties
	public static GameObject AudioGO { get; } // 0x000000018110B9D0-0x000000018110BA60 

	// Constructors
	public FourCrowsAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018110B210-0x000000018110B250
	public static void PlayBranchMove(); // 0x000000018110B2D0-0x000000018110B340
	public static void PlayCardPlaced(); // 0x000000018110B430-0x000000018110B4A0
	public static void PlayCardSelect(); // 0x000000018110B510-0x000000018110B580
	public static void PlayCardRetract(); // 0x000000018110B4A0-0x000000018110B510
	public static void PlayCrowBanished(); // 0x000000018110B580-0x000000018110B5F0
	public static void PlayCrowCaw(); // 0x000000018110B660-0x000000018110B6D0
	public static void PlayCrowCawDeath(); // 0x000000018110B5F0-0x000000018110B660
	public static void PlayCrowSpawn(); // 0x000000018110B750-0x000000018110B7C0
	public static void PlayDealCard(); // 0x000000018110B7C0-0x000000018110B830
	public static void PlayTreeMaterialize(); // 0x000000018110B8E0-0x000000018110B950
	public static void PlayMusic_TreeMaterialize(bool inPlay); // 0x000000018110B830-0x000000018110B8E0
	public static void PlayBranchReattach(); // 0x000000018110B340-0x000000018110B3B0
	public static void PlayBranchSnap(); // 0x000000018110B3B0-0x000000018110B430
	public static void PlayBranchCrackle(); // 0x000000018110B250-0x000000018110B2D0
	public static void PlayCrowFlap(); // 0x000000018110B6D0-0x000000018110B750
	public static void PlayTreeVanish(); // 0x000000018110B950-0x000000018110B9D0
}

