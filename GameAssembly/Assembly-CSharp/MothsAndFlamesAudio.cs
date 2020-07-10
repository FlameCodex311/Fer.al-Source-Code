/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MothsAndFlamesAudio : MonoBehaviour // TypeDefIndex: 13069
{
	// Fields
	private static MothsAndFlamesAudio _instance; // 0x00
	[Tooltip] // 0x00000001800D5D50-0x00000001800D5D80
	public FeralAudioInfo diceRoll; // 0x20
	[Tooltip] // 0x00000001800D5F20-0x00000001800D5F50
	public FeralAudioInfo crystalPulseRing; // 0x28
	[Tooltip] // 0x00000001800D6160-0x00000001800D6190
	public FeralAudioInfo crystalTokenPickup; // 0x30
	[Tooltip] // 0x00000001800D63E0-0x00000001800D6410
	public FeralAudioInfo crystalTokenPlaced; // 0x38
	[Tooltip] // 0x00000001800D65B0-0x00000001800D65E0
	public FeralAudioInfo diceCupRevealFlame; // 0x40
	[Tooltip] // 0x00000001800D67F0-0x00000001800D6820
	public FeralAudioInfo diceCupRevealPlaced; // 0x48
	[Tooltip] // 0x00000001800D6A60-0x00000001800D6A90
	public FeralAudioInfo diceCupRevealMoths; // 0x50
	[Tooltip] // 0x00000001800D6BC0-0x00000001800D6BF0
	public FeralAudioInfo diceCupScoop; // 0x58

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001812DE0F0-0x00000001812DE180 

	// Constructors
	public MothsAndFlamesAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x00000001812DDB30-0x00000001812DDB70
	public static void PlayDiceRoll(); // 0x00000001812DE040-0x00000001812DE0F0
	public static void PlayCrystalPulseRing(); // 0x00000001812DDB70-0x00000001812DDC20
	public static void PlayCrystalTokenPickup(); // 0x00000001812DDC20-0x00000001812DDCD0
	public static void PlayCrystalTokenPlaced(); // 0x00000001812DDCD0-0x00000001812DDD80
	public static void PlayDiceCupRevealFlame(); // 0x00000001812DDD80-0x00000001812DDE30
	public static void PlayDiceCupRevealPlaced(); // 0x00000001812DDEE0-0x00000001812DDF90
	public static void PlayDiceCupRevealMoths(); // 0x00000001812DDE30-0x00000001812DDEE0
	public static void PlayDiceCupScoop(); // 0x00000001812DDF90-0x00000001812DE040
}

