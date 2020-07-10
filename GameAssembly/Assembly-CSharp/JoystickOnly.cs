/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class JoystickOnly : MonoBehaviour // TypeDefIndex: 10636
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private JoystickOnlySetting _setting; // 0x20

	// Nested types
	public enum JoystickOnlySetting // TypeDefIndex: 10637
	{
		EnableForJoytick = 0,
		DisableForJoystick = 1
	}

	// Constructors
	public JoystickOnly(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001812C07B0-0x00000001812C0880
	private void OnEnable(); // 0x00000001812C05C0-0x00000001812C05D0
	private void OnDestroy(); // 0x00000001812C05D0-0x00000001812C06A0
	private void Refresh(); // 0x00000001812C06A0-0x00000001812C07B0
	private void OnControllerConnected(ControllerConnectedMessage inMessage); // 0x00000001812C05C0-0x00000001812C05D0
	private void OnControllerDisconnected(ControllerDisconnectedMessage inMessage); // 0x00000001812C05C0-0x00000001812C05D0
}

