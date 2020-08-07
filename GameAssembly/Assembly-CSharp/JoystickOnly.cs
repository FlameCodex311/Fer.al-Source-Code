/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class JoystickOnly : MonoBehaviour // TypeDefIndex: 12137
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private JoystickOnlySetting _setting; // 0x20

	// Nested types
	public enum JoystickOnlySetting // TypeDefIndex: 12138
	{
		EnableForJoytick = 0,
		DisableForJoystick = 1
	}

	// Constructors
	public JoystickOnly(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180879FE0-0x000000018087A0B0
	private void OnEnable(); // 0x0000000180879DF0-0x0000000180879E00
	private void OnDestroy(); // 0x0000000180879E00-0x0000000180879ED0
	private void Refresh(); // 0x0000000180879ED0-0x0000000180879FE0
	private void OnControllerConnected(ControllerConnectedMessage inMessage); // 0x0000000180879DF0-0x0000000180879E00
	private void OnControllerDisconnected(ControllerDisconnectedMessage inMessage); // 0x0000000180879DF0-0x0000000180879E00
}

