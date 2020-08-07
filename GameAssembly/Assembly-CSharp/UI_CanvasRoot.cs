/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CanvasRoot : SingletonManagedBehaviour<UI_CanvasRoot> // TypeDefIndex: 11295
{
	// Fields
	private static bool _developerConsoleVisible; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Camera _uiCamera; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _windowCanvas; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _overlayCanvas; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Canvas _popupCanvas; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GraphicRaycaster _inputBlocker; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _windowDepth; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_Window> _globalWindows; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Shader _defaultUIShader; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Dictionary<Type, Canvas> _attachCanvasOverrides; // 0x90

	// Properties
	public Camera UICamera { get; } // 0x0000000180378320-0x0000000180378330 
	public Canvas WindowCanvas { get; } // 0x00000001803A1580-0x00000001803A1590 
	public Canvas OverlayCanvas { get; } // 0x0000000180418970-0x0000000180418980 
	public Canvas PopupCanvas { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Constructors
	public UI_CanvasRoot(); // 0x00000001805200C0-0x0000000180520170
	static UI_CanvasRoot(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	[DebugButton] // 0x000000018027BE80-0x000000018027BEE0
	public static void EnableConsole(); // 0x000000018051F0E0-0x000000018051F140
	[DebugButton] // 0x000000018027C090-0x000000018027C0F0
	public static void DisableConsole(); // 0x000000018051F080-0x000000018051F0E0
	public override void MAwake(); // 0x000000018051F640-0x000000018051F990
	public void BlockInput(bool block); // 0x000000018051F060-0x000000018051F080
	public Canvas GetCanvas<T>(CoreWindowManager.UILayer inDesiredLayer)
		where T : UI_Window;
	public void AttachWindow<T>(UI_Window inWindow)
		where T : UI_Window;
	public void AddAttachWindowOverride(Type inType, Canvas inCanvas); // 0x000000018051EFA0-0x000000018051F060
	public void RemoveAttachWindowOverride(Type inType, Canvas inCanvas); // 0x000000018051FA30-0x000000018051FB20
	public void MoveWindowToFront(UI_Window inWindow); // 0x000000018051F990-0x000000018051FA30
	public void UpdateDepthPositions(); // 0x000000018051FB20-0x00000001805200C0
	public UI_Window GetForwardMostWindow(UI_Window inWindowToIgnore = null); // 0x000000018051F140-0x000000018051F640
}

