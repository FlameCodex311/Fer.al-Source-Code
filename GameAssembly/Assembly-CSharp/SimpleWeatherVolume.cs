/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SimpleWeatherVolume : ManagedBehaviour // TypeDefIndex: 12710
{
	// Fields
	[Header] // 0x00000001801138F0-0x0000000180113940
	[SerializeField] // 0x00000001801138F0-0x0000000180113940
	private bool _setOnEnter; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WeatherState _stateOnEnter; // 0x54
	private WeatherState _priorEnterWeatherState; // 0x58
	[Header] // 0x0000000180114E40-0x0000000180114E90
	[SerializeField] // 0x0000000180114E40-0x0000000180114E90
	private bool _setOnExit; // 0x5C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WeatherState _stateOnExit; // 0x60
	private WeatherState _priorExitWeatherState; // 0x64

	// Constructors
	public SimpleWeatherVolume(); // 0x0000000181358120-0x0000000181358180

	// Methods
	private void OnTriggerEnter(Collider other); // 0x0000000181357DE0-0x0000000181357F80
	private void OnTriggerExit(Collider other); // 0x0000000181357F80-0x0000000181358120
}

