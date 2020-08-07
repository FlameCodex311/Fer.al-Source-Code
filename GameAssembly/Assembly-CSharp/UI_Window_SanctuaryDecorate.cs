/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SanctuaryDecorate : UI_Window // TypeDefIndex: 14172
{
	// Fields
	[Header] // 0x00000001801D4480-0x00000001801D44D0
	[SerializeField] // 0x00000001801D4480-0x00000001801D44D0
	private CanvasGroup _furnitureListPanel; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _lightSettingsPanel; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _favoriteLooksPanel; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _sidePanel; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _controlPanel; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _currentModeText; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _goToInteriorBtn; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _goToExteriorBtn; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _categoryText; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_SanctuaryDecoration _itemList; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _filterTabGroup; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _dayNightToggle; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _cameraResetBtn; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _shardImage; // 0x170
	[Header] // 0x00000001801D5B70-0x00000001801D5BC0
	[SerializeField] // 0x00000001801D5B70-0x00000001801D5BC0
	private GameObject _floorNavigationGroup; // 0x178
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _floorNameText; // 0x180
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _floorUpBtn; // 0x188
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _floorDownBtn; // 0x190
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _roomNavigationGroup; // 0x198
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _roomLeftBtn; // 0x1A0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _roomUpBtn; // 0x1A8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _roomRightBtn; // 0x1B0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _roomDownBtn; // 0x1B8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TMP_InputField _roomName; // 0x1C0
	private bool _sidePanelIsOn; // 0x1C8
	private string[] _filterStrings; // 0x1D0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14173
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SanctuaryDecorate> <>9__2_0; // 0x08
		public static Action<UI_Window> <>9__3_0; // 0x10
		public static Action<bool> <>9__44_0; // 0x18
		public static Func<bool> <>9__53_0; // 0x20

		// Constructors
		static <>c(); // 0x00000001803B3F20-0x00000001803B3F80
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__2_0(UI_Window_SanctuaryDecorate window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__3_0(UI_Window inWindow); // 0x00000001803B29B0-0x00000001803B2A30
		internal void <BtnClicked_RemoveAllDecorations>b__44_0(bool inResponse); // 0x00000001803B2310-0x00000001803B23D0
		internal bool <SetInteriorMode>b__53_0(); // 0x00000001803B2B70-0x00000001803B2C50
	}

	// Constructors
	public UI_Window_SanctuaryDecorate(); // 0x00000001803BB740-0x00000001803BB750

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001801CF2D0-0x00000001801CF2E0
	private static void StaticInit(); // 0x00000001803BB500-0x00000001803BB590
	private static void OnSanctuaryExited(SanctuaryExitMessage inMessage); // 0x00000001803B91D0-0x00000001803B9220
	public static void OpenWindow(); // 0x00000001803BA5B0-0x00000001803BA6B0
	public static void QueueWindow(); // 0x00000001803BA6B0-0x00000001803BA7B0
	public static void CloseWindow(); // 0x00000001803B91D0-0x00000001803B9220
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803B9B40-0x00000001803BA470
	protected override void OnClose(bool inAnimate); // 0x00000001803B9470-0x00000001803B9740
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void OnFilterChanged(int inFilterIndex); // 0x00000001803B9830-0x00000001803B9B40
	public void BtnClicked_RotateCamera(); // 0x00000001803B8A40-0x00000001803B8B10
	public void BtnClicked_ZoomIn(); // 0x00000001803B8E80-0x00000001803B8F30
	public void BtnClicked_ZoomOut(); // 0x00000001803B8F30-0x00000001803B8FE0
	public void BtnClicked_GoToInterior(); // 0x00000001803B8780-0x00000001803B8860
	public void BtnClicked_GoToExterior(); // 0x00000001803B86A0-0x00000001803B8780
	public void BtnClicked_Shop(); // 0x00000001803B8C80-0x00000001803B8D10
	public void BtnClicked_ToggleDayNight(bool inIsOn); // 0x00000001803B8D10-0x00000001803B8E60
	public void BtnClicked_ToggleSidePanel(); // 0x00000001803B8E60-0x00000001803B8E80
	public void BtnClicked_RemoveAllDecorations(); // 0x00000001803B8860-0x00000001803B8A00
	public void BtnClicked_FloorUp(); // 0x00000001803B85F0-0x00000001803B86A0
	public void BtnClicked_FloorDown(); // 0x00000001803B8540-0x00000001803B85F0
	public void BtnClicked_RoomLeft(); // 0x00000001803B8A10-0x00000001803B8A20
	public void BtnClicked_RoomUp(); // 0x00000001803B8A30-0x00000001803B8A40
	public void BtnClicked_RoomRight(); // 0x00000001803B8A20-0x00000001803B8A30
	public void BtnClicked_RoomDown(); // 0x00000001803B8A00-0x00000001803B8A10
	public void BtnClicked_SaveLook(); // 0x00000001803B8B10-0x00000001803B8C80
	public void OnEndEdit_RoomName(); // 0x00000001803B9740-0x00000001803B9830
	private void SetInteriorMode(bool inIsInterior); // 0x00000001803BAE00-0x00000001803BB090
	private void RefreshRoomName(); // 0x00000001803BAA50-0x00000001803BABF0
	private void RefreshFloorNavigation(); // 0x00000001803BA7B0-0x00000001803BAA50
	private void RefreshRoomNavigation(); // 0x00000001803BABF0-0x00000001803BAE00
	private bool CheckRoomNavigation(int inDirection); // 0x00000001803B8FE0-0x00000001803B91D0
	private void DoRoomNavigation(int inDirection); // 0x00000001803B9220-0x00000001803B9470
	private void OnSanctuaryObjectDragStart(SanctuaryObjectDragStartMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnSanctuaryObjectDragEnd(SanctuaryObjectDragEndMessage inMessage); // 0x00000001803774A0-0x00000001803774B0
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x00000001803BA580-0x00000001803BA5B0
	private void OnSanctuaryCameraRotate(SanctuaryCameraRotateMessage inMessage); // 0x00000001803BA470-0x00000001803BA580
	private void SlideSidePanel(); // 0x00000001803BB090-0x00000001803BB500
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Shop>b__41_0(UI_Window_Shop_Furniture openedWindow); // 0x00000001803BB590-0x00000001803BB6F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <BtnClicked_Shop>b__41_1(UI_Window closedWindow); // 0x00000001803BB6F0-0x00000001803BB710
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetInteriorMode>b__53_1(); // 0x00000001803BB710-0x00000001803BB740
}

