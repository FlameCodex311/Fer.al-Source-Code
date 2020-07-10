/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DisableGameCameraController : MonoBehaviour // TypeDefIndex: 11464
{
	// Fields
	private static DisableGameCameraController _instance; // 0x00
	private static int _disabledCount; // 0x08
	private List<UI_Window> _disabledGameCameraWindows; // 0x20

	// Properties
	public static DisableGameCameraController instance { get; } // 0x0000000181188CC0-0x0000000181188DF0 
	public List<UI_Window> disabledGameCameraWindows { get; } // 0x000000018036AC70-0x000000018036AC80 
	public bool IsEnabled { get; } // 0x0000000181188C40-0x0000000181188CC0 

	// Constructors
	public DisableGameCameraController(); // 0x0000000181188BE0-0x0000000181188C40
	static DisableGameCameraController(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	private void Start(); // 0x0000000181188A50-0x0000000181188BE0
	private void OnDestroy(); // 0x0000000181188410-0x00000001811885A0
	private void OnWindowOpenComplete(WindowOpenCompleteMessage inMessage); // 0x0000000181188870-0x0000000181188950
	private void OnWindowClosed(WindowClosedMessage inMessage); // 0x00000001811886B0-0x0000000181188790
	private void OnWindowHidden(WindowHiddenMessage inMessage); // 0x0000000181188790-0x0000000181188870
	private void OnWindowShown(WindowShownMessage inMessage); // 0x0000000181188950-0x0000000181188A50
	private bool HasDisabledGameCamera(UI_Window inWindow); // 0x00000001811883A0-0x0000000181188410
	private void OnDisableGameCameraMessage(DisableGameCameraMessage message); // 0x00000001811885A0-0x00000001811886B0
}

