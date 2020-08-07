/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SimpleWeatherVolume : ManagedBehaviour // TypeDefIndex: 14282
{
	// Fields
	[Header] // 0x0000000180206100-0x0000000180206150
	[SerializeField] // 0x0000000180206100-0x0000000180206150
	private bool _setOnEnter; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WeatherState _stateOnEnter; // 0x54
	private WeatherState _priorEnterWeatherState; // 0x58
	[Header] // 0x0000000180206650-0x00000001802066A0
	[SerializeField] // 0x0000000180206650-0x00000001802066A0
	private bool _setOnExit; // 0x5C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WeatherState _stateOnExit; // 0x60
	private WeatherState _priorExitWeatherState; // 0x64

	// Constructors
	public SimpleWeatherVolume(); // 0x000000018076EC40-0x000000018076ECA0

	// Methods
	private void OnTriggerEnter(Collider other); // 0x000000018076E900-0x000000018076EAA0
	private void OnTriggerExit(Collider other); // 0x000000018076EAA0-0x000000018076EC40
}

