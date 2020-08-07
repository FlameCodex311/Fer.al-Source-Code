/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioMessage : Message // TypeDefIndex: 11799
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Item <item>k__BackingField; // 0x18
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo <audioInfo>k__BackingField; // 0x20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject <attach>k__BackingField; // 0x28
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ParamRef <paramRef>k__BackingField; // 0x30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioParameter <feralAudioParameter>k__BackingField; // 0x38
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <stringParameter>k__BackingField; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string <parameterName>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float? <parameterValue>k__BackingField; // 0x50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EState <state>k__BackingField; // 0x58

	// Properties
	public Item item { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	public FeralAudioInfo audioInfo { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	public GameObject attach { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
	public ParamRef paramRef { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	public FeralAudioParameter feralAudioParameter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
	public string stringParameter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
	public string parameterName { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
	public float? parameterValue { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180378320-0x0000000180378330 0x00000001803F7B90-0x00000001803F7BA0
	public EState state { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ protected set; } // 0x0000000180693DB0-0x0000000180693DC0 0x0000000180693DC0-0x0000000180693DD0

	// Nested types
	public enum EState // TypeDefIndex: 11800
	{
		LOAD = 0,
		PLAY = 1,
		STOP = 2,
		KILL = 3
	}

	// Constructors
	private FeralAudioMessage(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY /* Metadata: 0x007B926D */, GameObject inGameObject = null, ParamRef inParameterRef = null, FeralAudioParameter inFeralAudioParameter = null, string inStringParameter = null, string inParameterName = null, float? inParameterValue = default); // 0x0000000180693D30-0x0000000180693DB0

	// Methods
	public static FeralAudioMessage Create(FeralAudioInfo inAudioInfo, EState inState = EState.PLAY /* Metadata: 0x007B9271 */, GameObject inGameObject = null, ParamRef inParameterRef = null, FeralAudioParameter inFeralAudioParameter = null, string inStringParameter = null, string inParameterName = null, float? inParameterValue = default); // 0x0000000180693BF0-0x0000000180693D00
	public override void ReturnToPool(); // 0x0000000180693D00-0x0000000180693D30
}

