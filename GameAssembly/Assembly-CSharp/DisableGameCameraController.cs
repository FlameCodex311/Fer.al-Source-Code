/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DisableGameCameraController : MonoBehaviour // TypeDefIndex: 12985
{
	// Fields
	private static DisableGameCameraController _instance; // 0x00
	private static int _disabledCount; // 0x08
	private List<UI_Window> _disabledGameCameraWindows; // 0x20

	// Properties
	public static DisableGameCameraController instance { get; } // 0x00000001808558F0-0x0000000180855A20 
	public List<UI_Window> disabledGameCameraWindows { get; } // 0x0000000180374AF0-0x0000000180374B00 
	public bool IsEnabled { get; } // 0x0000000180855870-0x00000001808558F0 

	// Constructors
	public DisableGameCameraController(); // 0x0000000180855810-0x0000000180855870
	static DisableGameCameraController(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	private void Start(); // 0x0000000180855680-0x0000000180855810
	private void OnDestroy(); // 0x0000000180855040-0x00000001808551D0
	private void OnWindowOpenComplete(WindowOpenCompleteMessage inMessage); // 0x00000001808554A0-0x0000000180855580
	private void OnWindowClosed(WindowClosedMessage inMessage); // 0x00000001808552E0-0x00000001808553C0
	private void OnWindowHidden(WindowHiddenMessage inMessage); // 0x00000001808553C0-0x00000001808554A0
	private void OnWindowShown(WindowShownMessage inMessage); // 0x0000000180855580-0x0000000180855680
	private bool HasDisabledGameCamera(UI_Window inWindow); // 0x0000000180854FD0-0x0000000180855040
	private void OnDisableGameCameraMessage(DisableGameCameraMessage message); // 0x00000001808551D0-0x00000001808552E0
}

