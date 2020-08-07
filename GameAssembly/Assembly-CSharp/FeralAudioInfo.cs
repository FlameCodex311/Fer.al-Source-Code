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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class FeralAudioInfo // TypeDefIndex: 11564
{
	// Fields
	[EventRef] // 0x00000001801CEA70-0x00000001801CEA80
	public string eventRef; // 0x10
	[Header] // 0x000000018021E0A0-0x000000018021E0F0
	[SerializeField] // 0x000000018021E0A0-0x000000018021E0F0
	private bool _allowFadeout; // 0x18
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _triggerOnce; // 0x19
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _attachToOverride; // 0x20
	[FormerlySerializedAs] // 0x000000018021E570-0x000000018021E5E0
	[Header] // 0x000000018021E570-0x000000018021E5E0
	[SerializeField] // 0x000000018021E570-0x000000018021E5E0
	private ParamRef[] _parameters; // 0x28
	private string _bankName; // 0x30
	[Header] // 0x000000018021E920-0x000000018021E970
	[SerializeField] // 0x000000018021E920-0x000000018021E970
	private FeralAudioParameter[] _modParameter; // 0x38
	[Header] // 0x000000018021EC40-0x000000018021EC90
	[SerializeField] // 0x000000018021EC40-0x000000018021EC90
	private bool _overrideAttenuation; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _overrideMinDistance; // 0x44
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _overrideMaxDistance; // 0x48
	public EventInstance eventInstance; // 0x50
	public EventDescription eventDescription; // 0x58

	// Properties
	public bool allowFadeout { get; } // 0x00000001803F6D30-0x00000001803F6D40 
	public bool triggerOnce { get; } // 0x0000000180690340-0x0000000180690350 
	public GameObject attachToOverride { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public ParamRef[] parameters { get; } // 0x00000001803745B0-0x00000001803745C0 
	public string bankName { get; } // 0x0000000180690270-0x0000000180690330 
	public FeralAudioParameter[] modParameter { get; } // 0x00000001803743D0-0x00000001803743E0 
	public bool overrideAttenuation { get; } // 0x0000000180455BA0-0x0000000180455BB0 
	public float overrideMinDistance { get; } // 0x0000000180690330-0x0000000180690340 
	public float overrideMaxDistance { get; } // 0x00000001804D5810-0x00000001804D5820 

	// Constructors
	public FeralAudioInfo(); // 0x0000000180690200-0x0000000180690270

	// Methods
	private FeralAudioManager GetAudioManager(); // 0x000000018068F6E0-0x000000018068F790
	public void Play(GameObject inGameObject); // 0x000000018068F960-0x000000018068FA00
	public void Play(GameObject inGameObject, string inParameter); // 0x000000018068F8C0-0x000000018068F960
	public void Play(GameObject inGameObject, string inParameter, float inValue); // 0x000000018068FA00-0x000000018068FAE0
	public void Play(GameObject inGameObject, ParamRef inParameter); // 0x000000018068FAE0-0x000000018068FB80
	public void Play(GameObject inGameObject, FeralAudioParameter inParameter); // 0x000000018068FB80-0x000000018068FC20
	public void Load(GameObject inGameObject); // 0x000000018068F830-0x000000018068F8C0
	public void Stop(GameObject inGameObject); // 0x0000000180690160-0x0000000180690200
	public void SetParameters(GameObject inGameObject, ParamRef[] inParameters); // 0x000000018068FFE0-0x0000000180690160
	public void SetParameter(GameObject inGameObject, string inParameter, float inValue); // 0x000000018068FDB0-0x000000018068FEB0
	public void SetParameter(GameObject inGameObject, ParamRef inParameter); // 0x000000018068FEB0-0x000000018068FFE0
	public void SetParameter(GameObject inGameObject, FeralAudioParameter inParameter); // 0x000000018068FC20-0x000000018068FCE0
	public void SetParameter(GameObject inGameObject, string inParameter); // 0x000000018068FCE0-0x000000018068FDB0
	public void Kill(GameObject inGameObject); // 0x000000018068F790-0x000000018068F830
}

