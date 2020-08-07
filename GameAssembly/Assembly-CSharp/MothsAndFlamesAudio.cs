/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class MothsAndFlamesAudio : MonoBehaviour // TypeDefIndex: 10734
{
	// Fields
	private static MothsAndFlamesAudio _instance; // 0x00
	[Tooltip] // 0x000000018026BC30-0x000000018026BC60
	public FeralAudioInfo diceRoll; // 0x20
	[Tooltip] // 0x000000018026BD50-0x000000018026BD80
	public FeralAudioInfo crystalPulseRing; // 0x28
	[Tooltip] // 0x000000018026C080-0x000000018026C0B0
	public FeralAudioInfo crystalTokenPickup; // 0x30
	[Tooltip] // 0x000000018026C150-0x000000018026C180
	public FeralAudioInfo crystalTokenPlaced; // 0x38
	[Tooltip] // 0x000000018026C530-0x000000018026C560
	public FeralAudioInfo diceCupRevealFlame; // 0x40
	[Tooltip] // 0x000000018026C650-0x000000018026C680
	public FeralAudioInfo diceCupRevealPlaced; // 0x48
	[Tooltip] // 0x000000018026C8F0-0x000000018026C920
	public FeralAudioInfo diceCupRevealMoths; // 0x50
	[Tooltip] // 0x000000018026CA80-0x000000018026CAB0
	public FeralAudioInfo diceCupScoop; // 0x58

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000180C112D0-0x0000000180C11360 

	// Constructors
	public MothsAndFlamesAudio(); // 0x0000000180568C50-0x0000000180569020

	// Methods
	private void Awake(); // 0x0000000180C10D10-0x0000000180C10D50
	public static void PlayDiceRoll(); // 0x0000000180C11220-0x0000000180C112D0
	public static void PlayCrystalPulseRing(); // 0x0000000180C10D50-0x0000000180C10E00
	public static void PlayCrystalTokenPickup(); // 0x0000000180C10E00-0x0000000180C10EB0
	public static void PlayCrystalTokenPlaced(); // 0x0000000180C10EB0-0x0000000180C10F60
	public static void PlayDiceCupRevealFlame(); // 0x0000000180C10F60-0x0000000180C11010
	public static void PlayDiceCupRevealPlaced(); // 0x0000000180C110C0-0x0000000180C11170
	public static void PlayDiceCupRevealMoths(); // 0x0000000180C11010-0x0000000180C110C0
	public static void PlayDiceCupScoop(); // 0x0000000180C11170-0x0000000180C11220
}

