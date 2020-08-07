/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Minimap : UI_Window // TypeDefIndex: 14119
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_Window_Minimap <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupMapOn; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _groupMapOff; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapPanel; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapContainer; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _indicatorContainer; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapRotator; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mapNorth; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _elementContainerMasked; // 0x140
	[RootSelector] // 0x000000018028A5F0-0x000000018028A670
	[SerializeField] // 0x000000018028A5F0-0x000000018028A670
	private string _blipId; // 0x148
	[RootSelector] // 0x000000018028A7F0-0x000000018028A870
	[SerializeField] // 0x000000018028A7F0-0x000000018028A870
	private string _indicatorId; // 0x150
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MinimapBlip <blipReference>k__BackingField; // 0x158
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MinimapIndicator <indicatorReference>k__BackingField; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _labelLevelIntro; // 0x168
	private string _prevLevelName; // 0x170
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEngine.UI.Text _labelTime; // 0x178
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEngine.UI.Text _labelWeather; // 0x180
	private Vector3 _lastPlayerPosition; // 0x188
	private List<GameObject> _imageGameObjects; // 0x198
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _showTime; // 0x1A0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _showWeather; // 0x1A1
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _showLocation; // 0x1A2
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _showPosition; // 0x1A3
	private bool _mapOn; // 0x1A4
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static bool <DelayShowLocation>k__BackingField; // 0x08
	private StringBuilder _tempSB; // 0x1A8

	// Properties
	public static UI_Window_Minimap instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF1A0-0x00000001803EF200 0x00000001803EF2C0-0x00000001803EF320
	public RectTransform mapPanel { get; } // 0x00000001803916B0-0x00000001803916C0 
	public RectTransform mapContainer { get; } // 0x00000001803EF220-0x00000001803EF230 
	public RectTransform indicatorContainer { get; } // 0x00000001803EF180-0x00000001803EF190 
	public RectTransform mapRotator { get; } // 0x0000000180383C00-0x0000000180383C10 
	public RectTransform mapNorth { get; } // 0x00000001803EF230-0x00000001803EF240 
	public RectTransform elementContainerMasked { get; } // 0x00000001803EF170-0x00000001803EF180 
	public UI_MinimapBlip blipReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF160-0x00000001803EF170 0x00000001803EF2A0-0x00000001803EF2B0
	public UI_MinimapIndicator indicatorReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803EF190-0x00000001803EF1A0 0x00000001803EF2B0-0x00000001803EF2C0
	public UnityEngine.UI.Text labelTime { get; } // 0x00000001803EF200-0x00000001803EF210 
	public UnityEngine.UI.Text labelWeather { get; } // 0x00000001803EF210-0x00000001803EF220 
	public static bool DelayShowLocation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803EF100-0x00000001803EF160 0x00000001803EF240-0x00000001803EF2A0

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass53_0 // TypeDefIndex: 14120
	{
		// Fields
		public bool inMapOn; // 0x10

		// Constructors
		public <>c__DisplayClass53_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Minimap window); // 0x00000001803E2240-0x00000001803E22B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 14121
	{
		// Fields
		public UI_Window_Minimap <>4__this; // 0x10
		public string inText; // 0x18
		public Color c; // 0x20
		public Action <>9__3; // 0x30
		public Action <>9__2; // 0x38

		// Constructors
		public <>c__DisplayClass62_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <InitLevelNameIntro>b__0(); // 0x00000001803E22B0-0x00000001803E23E0
		internal void <InitLevelNameIntro>b__2(); // 0x00000001803E23E0-0x00000001803E24F0
		internal void <InitLevelNameIntro>b__3(); // 0x00000001803E24F0-0x00000001803E2530
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14122
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__62_1; // 0x08

		// Constructors
		static <>c(); // 0x00000001803E2BB0-0x00000001803E2C10
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <InitLevelNameIntro>b__62_1(); // 0x00000001803E09E0-0x00000001803E0A90
	}

	// Constructors
	public UI_Window_Minimap(); // 0x00000001803EF040-0x00000001803EF100
	static UI_Window_Minimap(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public static void OpenWindow(bool inMapOn = true /* Metadata: 0x007BA660 */); // 0x00000001803EE640-0x00000001803EE700
	public static void CloseWindow(); // 0x00000001803ED510-0x00000001803ED560
	protected override void OnOpen(); // 0x00000001803EE610-0x00000001803EE640
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	private void ToggleExpandedMinimap(); // 0x00000001803EEB40-0x00000001803EECB0
	public override void MStart(); // 0x00000001803EE3D0-0x00000001803EE610
	public override void MOnDestroy(); // 0x00000001803EE320-0x00000001803EE3D0
	private void LateUpdate(); // 0x00000001803EDB00-0x00000001803EE320
	private void InitLevelNameIntro(string inText); // 0x00000001803ED700-0x00000001803ED870
	private void InitElements(); // 0x00000001803ED560-0x00000001803ED700
	private void InitMinimap(); // 0x00000001803ED870-0x00000001803EDB00
	private void SetMinimapMap(); // 0x00000001803EE760-0x00000001803EE890
	public static List<GameObject> SpawnMapImages(Transform inParent, bool inFullscreen = false /* Metadata: 0x007BA661 */); // 0x00000001803EE890-0x00000001803EEB40
	public void BtnClicked_ZoomIn(); // 0x00000001803ED470-0x00000001803ED4C0
	public void BtnClicked_ZoomOut(); // 0x00000001803ED4C0-0x00000001803ED510
	public void BtnClicked_ExpandMinimap(); // 0x00000001803ED420-0x00000001803ED470
	public void SetMapOn(bool inOn); // 0x00000001803EE700-0x00000001803EE760
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitElements>b__63_0(GameObject loadedAsset); // 0x00000001803EECB0-0x00000001803EEDB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitElements>b__63_1(GameObject loadedAsset); // 0x00000001803EEDB0-0x00000001803EEEB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InitMinimap>b__64_0(); // 0x00000001803EEEB0-0x00000001803EF040
}

