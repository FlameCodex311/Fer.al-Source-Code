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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CanvasRoot : SingletonManagedBehaviour<UI_CanvasRoot> // TypeDefIndex: 13628
{
	// Fields
	private static bool _developerConsoleVisible; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Camera _uiCamera; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _windowCanvas; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _overlayCanvas; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Canvas _popupCanvas; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GraphicRaycaster _inputBlocker; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _windowDepth; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_Window> _globalWindows; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Shader _defaultUIShader; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Dictionary<Type, Canvas> _attachCanvasOverrides; // 0x90

	// Properties
	public Camera UICamera { get; } // 0x00000001803A27A0-0x00000001803A27B0 
	public Canvas WindowCanvas { get; } // 0x0000000180357120-0x0000000180357130 
	public Canvas OverlayCanvas { get; } // 0x0000000180369B40-0x0000000180369B50 
	public Canvas PopupCanvas { get; } // 0x0000000180358970-0x0000000180358980 

	// Constructors
	public UI_CanvasRoot(); // 0x0000000180FBB290-0x0000000180FC8180
	static UI_CanvasRoot(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	[DebugButton] // 0x00000001800DF640-0x00000001800DF6A0
	public static void EnableConsole(); // 0x0000000180FBA270-0x0000000180FBA2D0
	[DebugButton] // 0x00000001800DF9A0-0x00000001800DFA00
	public static void DisableConsole(); // 0x0000000180FBA210-0x0000000180FBA270
	public override void MAwake(); // 0x0000000180FBA7F0-0x0000000180FBAB40
	public void BlockInput(bool block); // 0x0000000180FBA1F0-0x0000000180FBA210
	public Canvas GetCanvas<T>(CoreWindowManager.UILayer inDesiredLayer)
		where T : UI_Window;
	public void AttachWindow<T>(UI_Window inWindow)
		where T : UI_Window;
	public void AddAttachWindowOverride(Type inType, Canvas inCanvas); // 0x0000000180FBA130-0x0000000180FBA1F0
	public void RemoveAttachWindowOverride(Type inType, Canvas inCanvas); // 0x0000000180FBABE0-0x0000000180FBACD0
	public void MoveWindowToFront(UI_Window inWindow); // 0x0000000180FBAB40-0x0000000180FBABE0
	public void UpdateDepthPositions(); // 0x0000000180FBACD0-0x0000000180FBB290
	public UI_Window GetForwardMostWindow(UI_Window inWindowToIgnore = null); // 0x0000000180FBA2D0-0x0000000180FBA7F0
}

