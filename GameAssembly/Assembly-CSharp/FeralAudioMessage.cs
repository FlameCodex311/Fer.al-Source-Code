/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioMessage : Message // TypeDefIndex: 10309
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Item <item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo <audioInfo>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject <attach>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ParamRef <paramRef>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioParameter <feralAudioParameter>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <stringParameter>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <parameterName>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float? <parameterValue>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private EState <state>k__BackingField; // 0x58

	// Properties
	public Item item { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	public FeralAudioInfo audioInfo { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	public GameObject attach { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
	public ParamRef paramRef { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	public FeralAudioParameter feralAudioParameter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	public string stringParameter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
	public string parameterName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
	public float? parameterValue { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
	public EState state { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ protected set; } // 0x000000018049CAA0-0x000000018049CAB0 0x000000018049CAB0-0x000000018049CAC0

	// Nested types
	public enum EState // TypeDefIndex: 10310
	{
		LOAD = 0,
		PLAY = 1,
		STOP = 2,
		KILL = 3
	}

	// Constructors
	private FeralAudioMessage(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY /* Metadata: 0x00781BD2 */, GameObject inGameObject = null, ParamRef inParameterRef = null, FeralAudioParameter inFeralAudioParameter = null, string inStringParameter = null, string inParameterName = null, float? inParameterValue = default); // 0x00000001810FE580-0x00000001810FE600

	// Methods
	public static FeralAudioMessage Create(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY /* Metadata: 0x00781BD6 */, GameObject inGameObject = null, ParamRef inParameterRef = null, FeralAudioParameter inFeralAudioParameter = null, string inStringParameter = null, string inParameterName = null, float? inParameterValue = default); // 0x00000001810FE440-0x00000001810FE550
	public override void ReturnToPool(); // 0x00000001810FE550-0x00000001810FE580
}

