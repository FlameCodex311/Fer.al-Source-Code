/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800B6E20-0x00000001800B6E50
public class UI_Window_ExpandedMinimap : UI_Window // TypeDefIndex: 12458
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_Window_ExpandedMinimap <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapPanel; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapContainer; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _elementContainer; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MinimapBlip _blipReference; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _labelLevelName; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _labelTime; // 0x130
	private List<GameObject> _imageGameObjects; // 0x138
	private string _lastRoomDefId; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _minZoom; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _maxZoom; // 0x14C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _currentZoom; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _zoomSensitivity; // 0x154
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _zoomPercentage; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _zoomModifier; // 0x15C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _draggableRect; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _zoomPosition; // 0x170
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _priorZoomPosition; // 0x17C

	// Properties
	public static UI_Window_ExpandedMinimap instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F12830-0x0000000180F12870 0x0000000180F12870-0x0000000180F128B0
	public RectTransform mapPanel { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 
	public RectTransform mapContainer { get; } // 0x00000001803BD380-0x00000001803BD390 
	public RectTransform elementContainer { get; } // 0x00000001803BD3A0-0x00000001803BD3B0 
	public UI_MinimapBlip blipReference { get; } // 0x00000001803BD3D0-0x00000001803BD3E0 
	public WWTextMeshProUGUI labelLevelName { get; } // 0x00000001803BD350-0x00000001803BD360 
	public WWTextMeshProUGUI labelTime { get; } // 0x00000001803BD390-0x00000001803BD3A0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12459
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_ExpandedMinimap> <>9__24_0; // 0x08
		public static Action<UI_Window> <>9__25_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180EFFF20-0x0000000180EFFF80
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__24_0(UI_Window_ExpandedMinimap window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__25_0(UI_Window inWindow); // 0x0000000180EFEBF0-0x0000000180EFEC70
	}

	// Constructors
	public UI_Window_ExpandedMinimap(); // 0x0000000180F12700-0x0000000180F12830

	// Methods
	public static void OpenWindow(); // 0x0000000180F11F20-0x0000000180F12020
	public static void QueueWindow(); // 0x0000000180F12020-0x0000000180F12120
	public static void CloseWindow(); // 0x0000000180F11730-0x0000000180F11780
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180F11DD0-0x0000000180F11F20
	protected override void OnClose(bool inAnimate); // 0x0000000180F11C90-0x0000000180F11DD0
	public void BtnClicked_ZoomIn(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_ZoomOut(); // 0x00000001803581E0-0x00000001803581F0
	public void BtnClicked_Waypoint(); // 0x00000001803581E0-0x00000001803581F0
	public override void MStart(); // 0x0000000180F11BF0-0x0000000180F11C40
	public override void MOnDestroy(); // 0x0000000180F11BB0-0x0000000180F11BF0
	private void InitMinimap(); // 0x0000000180F11780-0x0000000180F11A00
	private void SetMinimapMap(); // 0x0000000180F12120-0x0000000180F12260
	public override void MUpdate(); // 0x0000000180F11C40-0x0000000180F11C90
	private void Zoom(float inZoom); // 0x0000000180F12260-0x0000000180F12700
	private void LateUpdate(); // 0x0000000180F11A00-0x0000000180F11BB0
	public override void OnReceiveFocus(); // 0x0000000180EA0010-0x0000000180EA0020
	public override void OnLoseFocus(); // 0x0000000180E9FBB0-0x0000000180E9FBC0
	public void BtnClicked_OpenQuickTravel(); // 0x0000000180F116D0-0x0000000180F11730
}

