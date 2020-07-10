/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.Serialization;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class FeralAudioInfo // TypeDefIndex: 10074
{
	// Fields
	[EventRef] // 0x00000001800BDB50-0x00000001800BDB60
	public string eventRef; // 0x10
	[Header] // 0x00000001800D6560-0x00000001800D65B0
	[SerializeField] // 0x00000001800D6560-0x00000001800D65B0
	private bool _allowFadeout; // 0x18
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _attachToOverride; // 0x20
	[FormerlySerializedAs] // 0x00000001801441F0-0x0000000180144260
	[Header] // 0x00000001801441F0-0x0000000180144260
	[SerializeField] // 0x00000001801441F0-0x0000000180144260
	private ParamRef[] _parameters; // 0x28
	private string _bankName; // 0x30
	[Header] // 0x0000000180145710-0x0000000180145760
	[SerializeField] // 0x0000000180145710-0x0000000180145760
	private FeralAudioParameter[] _modParameter; // 0x38
	[Header] // 0x00000001801458F0-0x0000000180145940
	[SerializeField] // 0x00000001801458F0-0x0000000180145940
	private bool _overrideAttenuation; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _overrideMinDistance; // 0x44
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _overrideMaxDistance; // 0x48
	public EventInstance eventInstance; // 0x50
	public EventDescription eventDescription; // 0x58

	// Properties
	public bool allowFadeout { get; } // 0x000000018041BAC0-0x000000018041BAD0 
	public GameObject attachToOverride { get; } // 0x000000018036AC70-0x000000018036AC80 
	public ParamRef[] parameters { get; } // 0x0000000180369B60-0x0000000180369B70 
	public string bankName { get; } // 0x00000001810FAEA0-0x00000001810FAF60 
	public FeralAudioParameter[] modParameter { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public bool overrideAttenuation { get; } // 0x0000000180478660-0x0000000180478670 
	public float overrideMinDistance { get; } // 0x0000000180487D40-0x0000000180487D50 
	public float overrideMaxDistance { get; } // 0x0000000180487CC0-0x0000000180487CD0 

	// Constructors
	public FeralAudioInfo(); // 0x00000001810FAE30-0x00000001810FAEA0

	// Methods
	private FeralAudioManager GetAudioManager(); // 0x00000001810FA300-0x00000001810FA3B0
	public void Play(GameObject inGameObject); // 0x00000001810FA580-0x00000001810FA620
	public void Play(GameObject inGameObject, string inParameter); // 0x00000001810FA4E0-0x00000001810FA580
	public void Play(GameObject inGameObject, string inParameter, float inValue); // 0x00000001810FA620-0x00000001810FA700
	public void Play(GameObject inGameObject, ParamRef inParameter); // 0x00000001810FA700-0x00000001810FA7A0
	public void Play(GameObject inGameObject, FeralAudioParameter inParameter); // 0x00000001810FA7A0-0x00000001810FA840
	public void Load(GameObject inGameObject); // 0x00000001810FA450-0x00000001810FA4E0
	public void Stop(GameObject inGameObject); // 0x00000001810FAD90-0x00000001810FAE30
	public void SetParameters(GameObject inGameObject, ParamRef[] inParameters); // 0x00000001810FAC00-0x00000001810FAD90
	public void SetParameter(GameObject inGameObject, string inParameter, float inValue); // 0x00000001810FA9D0-0x00000001810FAAD0
	public void SetParameter(GameObject inGameObject, ParamRef inParameter); // 0x00000001810FAAD0-0x00000001810FAC00
	public void SetParameter(GameObject inGameObject, FeralAudioParameter inParameter); // 0x00000001810FA840-0x00000001810FA900
	public void SetParameter(GameObject inGameObject, string inParameter); // 0x00000001810FA900-0x00000001810FA9D0
	public void Kill(GameObject inGameObject); // 0x00000001810FA3B0-0x00000001810FA450
}

