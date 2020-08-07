/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MoonPhasesAudio : MonoBehaviour // TypeDefIndex: 10709
{
	// Fields
	private static MoonPhasesAudio _instance; // 0x00
	[Tooltip] // 0x000000018025E0A0-0x000000018025E0D0
	public FeralAudioInfo tokenSpawn; // 0x20
	[Tooltip] // 0x000000018025E1C0-0x000000018025E1F0
	public FeralAudioInfo tilePlaced; // 0x28
	[Tooltip] // 0x000000018025E3D0-0x000000018025E400
	public FeralAudioInfo tileSelected; // 0x30
	[Tooltip] // 0x000000018025E4F0-0x000000018025E520
	public FeralAudioInfo tilesReturned; // 0x38
	[Tooltip] // 0x000000018025E610-0x000000018025E640
	public FeralAudioInfo crystalTokenLP; // 0x40
	[Tooltip] // 0x000000018025E810-0x000000018025E840
	public FeralAudioInfo dealerTokenLP; // 0x48
	[Tooltip] // 0x000000018025E930-0x000000018025E960
	public FeralAudioInfo crystalTokenStart; // 0x50
	[Tooltip] // 0x000000018025EB90-0x000000018025EBC0
	public FeralAudioInfo dealerTokenStart; // 0x58
	[Tooltip] // 0x000000018025EC90-0x000000018025ECC0
	public FeralAudioInfo crystalTokenStop; // 0x60
	[Tooltip] // 0x000000018025EE20-0x000000018025EE50
	public FeralAudioInfo dealerTokenStop; // 0x68

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000180C088A0-0x0000000180C08930 

	// Constructors
	public MoonPhasesAudio(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	private void Awake(); // 0x0000000180C08100-0x0000000180C08140
	public void PlayTokenSpawn(); // 0x0000000180C087F0-0x0000000180C088A0
	public static void PlayTilePlaced(); // 0x0000000180C085E0-0x0000000180C08690
	public static void PlayTileSelected(); // 0x0000000180C08690-0x0000000180C08740
	public static void PlayTilesReturned(); // 0x0000000180C08740-0x0000000180C087F0
	public static void PlayCrystalTokenLP(bool inPlay); // 0x0000000180C08140-0x0000000180C08230
	public static void PlayDealerTokenLP(bool inPlay); // 0x0000000180C08390-0x0000000180C08480
	public static void PlayCrystalTokenStart(); // 0x0000000180C08230-0x0000000180C082E0
	public static void PlayDealerTokenStart(); // 0x0000000180C08480-0x0000000180C08530
	public static void PlayCrystalTokenStop(); // 0x0000000180C082E0-0x0000000180C08390
	public static void PlayDealerTokenStop(); // 0x0000000180C08530-0x0000000180C085E0
}

