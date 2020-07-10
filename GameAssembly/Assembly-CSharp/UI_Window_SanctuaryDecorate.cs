/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SanctuaryDecorate : UI_Window // TypeDefIndex: 12570
{
	// Fields
	[Header] // 0x00000001800E4A00-0x00000001800E4A50
	[SerializeField] // 0x00000001800E4A00-0x00000001800E4A50
	private CanvasGroup _furnitureListPanel; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _lightSettingsPanel; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _favoriteLooksPanel; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _sidePanel; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _controlPanel; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _currentModeText; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _goToInteriorBtn; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _goToExteriorBtn; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _categoryText; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_SanctuaryDecoration _itemList; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _filterTabGroup; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _dayNightToggle; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _cameraResetBtn; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _shardImage; // 0x170
	[Header] // 0x00000001800E6640-0x00000001800E6690
	[SerializeField] // 0x00000001800E6640-0x00000001800E6690
	private GameObject _floorNavigationGroup; // 0x178
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _floorNameText; // 0x180
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _floorUpBtn; // 0x188
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _floorDownBtn; // 0x190
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _roomNavigationGroup; // 0x198
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _roomLeftBtn; // 0x1A0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _roomUpBtn; // 0x1A8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _roomRightBtn; // 0x1B0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _roomDownBtn; // 0x1B8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TMP_InputField _roomName; // 0x1C0
	private bool _sidePanelIsOn; // 0x1C8
	private string[] _filterStrings; // 0x1D0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12571
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SanctuaryDecorate> <>9__2_0; // 0x08
		public static Action<UI_Window> <>9__3_0; // 0x10
		public static Action<bool> <>9__44_0; // 0x18
		public static Func<bool> <>9__53_0; // 0x20

		// Constructors
		static <>c(); // 0x0000000180E9F030-0x0000000180E9F090
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__2_0(UI_Window_SanctuaryDecorate window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__3_0(UI_Window inWindow); // 0x0000000180E9D590-0x0000000180E9D610
		internal void <BtnClicked_RemoveAllDecorations>b__44_0(bool inResponse); // 0x0000000180E9CEF0-0x0000000180E9CFB0
		internal bool <SetInteriorMode>b__53_0(); // 0x0000000180E9D750-0x0000000180E9D830
	}

	// Constructors
	public UI_Window_SanctuaryDecorate(); // 0x0000000180EA5F50-0x0000000180EA5F60

	// Methods
	[RuntimeInitializeOnLoadMethod] // 0x00000001800C1340-0x00000001800C1350
	private static void StaticInit(); // 0x0000000180EA5D10-0x0000000180EA5DA0
	private static void OnSanctuaryExited(SanctuaryExitMessage inMessage); // 0x0000000180EA3930-0x0000000180EA3980
	public static void OpenWindow(); // 0x0000000180EA4DA0-0x0000000180EA4EA0
	public static void QueueWindow(); // 0x0000000180EA4EA0-0x0000000180EA4FA0
	public static void CloseWindow(); // 0x0000000180EA3930-0x0000000180EA3980
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EA42C0-0x0000000180EA4C50
	protected override void OnClose(bool inAnimate); // 0x0000000180EA3BE0-0x0000000180EA3EB0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void OnFilterChanged(int inFilterIndex); // 0x0000000180EA3FA0-0x0000000180EA42C0
	public void BtnClicked_RotateCamera(); // 0x0000000180EA31A0-0x0000000180EA3270
	public void BtnClicked_ZoomIn(); // 0x0000000180EA35E0-0x0000000180EA3690
	public void BtnClicked_ZoomOut(); // 0x0000000180EA3690-0x0000000180EA3740
	public void BtnClicked_GoToInterior(); // 0x0000000180EA2EE0-0x0000000180EA2FC0
	public void BtnClicked_GoToExterior(); // 0x0000000180EA2E00-0x0000000180EA2EE0
	public void BtnClicked_Shop(); // 0x0000000180EA33E0-0x0000000180EA3470
	public void BtnClicked_ToggleDayNight(bool inIsOn); // 0x0000000180EA3470-0x0000000180EA35C0
	public void BtnClicked_ToggleSidePanel(); // 0x0000000180EA35C0-0x0000000180EA35E0
	public void BtnClicked_RemoveAllDecorations(); // 0x0000000180EA2FC0-0x0000000180EA3160
	public void BtnClicked_FloorUp(); // 0x0000000180EA2D50-0x0000000180EA2E00
	public void BtnClicked_FloorDown(); // 0x0000000180EA2CA0-0x0000000180EA2D50
	public void BtnClicked_RoomLeft(); // 0x0000000180EA3170-0x0000000180EA3180
	public void BtnClicked_RoomUp(); // 0x0000000180EA3190-0x0000000180EA31A0
	public void BtnClicked_RoomRight(); // 0x0000000180EA3180-0x0000000180EA3190
	public void BtnClicked_RoomDown(); // 0x0000000180EA3160-0x0000000180EA3170
	public void BtnClicked_SaveLook(); // 0x0000000180EA3270-0x0000000180EA33E0
	public void OnEndEdit_RoomName(); // 0x0000000180EA3EB0-0x0000000180EA3FA0
	private void SetInteriorMode(bool inIsInterior); // 0x0000000180EA5610-0x0000000180EA58A0
	private void RefreshRoomName(); // 0x0000000180EA5250-0x0000000180EA53F0
	private void RefreshFloorNavigation(); // 0x0000000180EA4FA0-0x0000000180EA5250
	private void RefreshRoomNavigation(); // 0x0000000180EA53F0-0x0000000180EA5610
	private bool CheckRoomNavigation(int inDirection); // 0x0000000180EA3740-0x0000000180EA3930
	private void DoRoomNavigation(int inDirection); // 0x0000000180EA3980-0x0000000180EA3BE0
	private void OnSanctuaryObjectDragStart(SanctuaryObjectDragStartMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnSanctuaryObjectDragEnd(SanctuaryObjectDragEndMessage inMessage); // 0x00000001803581E0-0x00000001803581F0
	private void OnSanctuaryIndoorRoom(SanctuaryIndoorRoomMessage inMessage); // 0x0000000180EA4D70-0x0000000180EA4DA0
	private void OnSanctuaryCameraRotate(SanctuaryCameraRotateMessage inMessage); // 0x0000000180EA4C50-0x0000000180EA4D70
	private void SlideSidePanel(); // 0x0000000180EA58A0-0x0000000180EA5D10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Shop>b__41_0(UI_Window_Shop_Furniture openedWindow); // 0x0000000180EA5DA0-0x0000000180EA5F00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <BtnClicked_Shop>b__41_1(UI_Window closedWindow); // 0x0000000180EA5F00-0x0000000180EA5F20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetInteriorMode>b__53_1(); // 0x0000000180EA5F20-0x0000000180EA5F50
}

