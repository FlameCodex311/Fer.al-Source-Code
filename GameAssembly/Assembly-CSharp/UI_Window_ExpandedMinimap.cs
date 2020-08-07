/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018026FA70-0x000000018026FAA0
public class UI_Window_ExpandedMinimap : UI_Window // TypeDefIndex: 14057
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_Window_ExpandedMinimap <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapPanel; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapContainer; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _elementContainer; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MinimapBlip _blipReference; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _labelLevelName; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _labelTime; // 0x130
	private List<GameObject> _imageGameObjects; // 0x138
	private string _lastRoomDefId; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _minZoom; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _maxZoom; // 0x14C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _currentZoom; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _zoomSensitivity; // 0x154
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _zoomPercentage; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _zoomModifier; // 0x15C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _draggableRect; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _zoomPosition; // 0x170
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _priorZoomPosition; // 0x17C

	// Properties
	public static UI_Window_ExpandedMinimap instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804908B0-0x00000001804908F0 0x00000001804908F0-0x0000000180490930
	public RectTransform mapPanel { get; } // 0x0000000180380B50-0x0000000180380B60 
	public RectTransform mapContainer { get; } // 0x0000000180385320-0x0000000180385330 
	public RectTransform elementContainer { get; } // 0x00000001803916B0-0x00000001803916C0 
	public UI_MinimapBlip blipReference { get; } // 0x00000001803EF220-0x00000001803EF230 
	public WWTextMeshProUGUI labelLevelName { get; } // 0x00000001803EF180-0x00000001803EF190 
	public WWTextMeshProUGUI labelTime { get; } // 0x0000000180383C00-0x0000000180383C10 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14058
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ExpandedMinimap> <>9__24_0; // 0x08
		public static Action<UI_Window> <>9__25_0; // 0x10

		// Constructors
		static <>c(); // 0x000000018047F650-0x000000018047F6B0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__24_0(UI_Window_ExpandedMinimap window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__25_0(UI_Window inWindow); // 0x000000018047E530-0x000000018047E5B0
	}

	// Constructors
	public UI_Window_ExpandedMinimap(); // 0x0000000180490780-0x00000001804908B0

	// Methods
	public static void OpenWindow(); // 0x000000018048FFC0-0x00000001804900C0
	public static void QueueWindow(); // 0x00000001804900C0-0x00000001804901C0
	public static void CloseWindow(); // 0x000000018048F800-0x000000018048F850
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x000000018048FE80-0x000000018048FFC0
	protected override void OnClose(bool inAnimate); // 0x000000018048FD40-0x000000018048FE80
	public void BtnClicked_ZoomIn(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_ZoomOut(); // 0x00000001803774A0-0x00000001803774B0
	public void BtnClicked_Waypoint(); // 0x00000001803774A0-0x00000001803774B0
	public override void MStart(); // 0x000000018048FCA0-0x000000018048FCF0
	public override void MOnDestroy(); // 0x000000018048FC60-0x000000018048FCA0
	private void InitMinimap(); // 0x000000018048F850-0x000000018048FAC0
	private void SetMinimapMap(); // 0x00000001804901C0-0x00000001804902F0
	public override void MUpdate(); // 0x000000018048FCF0-0x000000018048FD40
	private void Zoom(float inZoom); // 0x00000001804902F0-0x0000000180490780
	private void LateUpdate(); // 0x000000018048FAC0-0x000000018048FC60
	public override void OnReceiveFocus(); // 0x00000001803B58C0-0x00000001803B58D0
	public override void OnLoseFocus(); // 0x00000001803B5460-0x00000001803B5470
	public void BtnClicked_OpenQuickTravel(); // 0x000000018048F7A0-0x000000018048F800
}

