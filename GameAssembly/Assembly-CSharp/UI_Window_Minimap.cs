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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Minimap : UI_Window // TypeDefIndex: 12517
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_Window_Minimap <instance>k__BackingField; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupMapOn; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _groupMapOff; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapPanel; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapContainer; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _indicatorContainer; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapRotator; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mapNorth; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _elementContainerMasked; // 0x140
	[RootSelector] // 0x00000001800D27C0-0x00000001800D2840
	[SerializeField] // 0x00000001800D27C0-0x00000001800D2840
	private string _blipId; // 0x148
	[RootSelector] // 0x00000001800D2B40-0x00000001800D2BC0
	[SerializeField] // 0x00000001800D2B40-0x00000001800D2BC0
	private string _indicatorId; // 0x150
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MinimapBlip <blipReference>k__BackingField; // 0x158
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MinimapIndicator <indicatorReference>k__BackingField; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _labelLevelIntro; // 0x168
	private string _prevLevelName; // 0x170
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEngine.UI.Text _labelTime; // 0x178
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEngine.UI.Text _labelWeather; // 0x180
	private Vector3 _lastPlayerPosition; // 0x188
	private List<GameObject> _imageGameObjects; // 0x198
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _showTime; // 0x1A0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _showWeather; // 0x1A1
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _showLocation; // 0x1A2
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _showPosition; // 0x1A3
	private bool _mapOn; // 0x1A4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static bool <DelayShowLocation>k__BackingField; // 0x08
	private StringBuilder _tempSB; // 0x1A8

	// Properties
	public static UI_Window_Minimap instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EDBAB0-0x0000000180EDBB10 0x0000000180EDBB80-0x0000000180EDBBE0
	public RectTransform mapPanel { get; } // 0x00000001803BD3A0-0x00000001803BD3B0 
	public RectTransform mapContainer { get; } // 0x00000001803BD3D0-0x00000001803BD3E0 
	public RectTransform indicatorContainer { get; } // 0x00000001803BD350-0x00000001803BD360 
	public RectTransform mapRotator { get; } // 0x00000001803BD390-0x00000001803BD3A0 
	public RectTransform mapNorth { get; } // 0x00000001803BD3B0-0x00000001803BD3C0 
	public RectTransform elementContainerMasked { get; } // 0x00000001803BD3E0-0x00000001803BD3F0 
	public UI_MinimapBlip blipReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803BD330-0x00000001803BD340 0x00000001803BE550-0x00000001803BE560
	public UI_MinimapIndicator indicatorReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180CB7670-0x0000000180CB7680 0x0000000180EDBB70-0x0000000180EDBB80
	public UnityEngine.UI.Text labelTime { get; } // 0x000000018081E150-0x000000018081E160 
	public UnityEngine.UI.Text labelWeather { get; } // 0x000000018081E0E0-0x000000018081E0F0 
	public static bool DelayShowLocation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180EDBA50-0x0000000180EDBAB0 0x0000000180EDBB10-0x0000000180EDBB70

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass53_0 // TypeDefIndex: 12518
	{
		// Fields
		public bool inMapOn; // 0x10

		// Constructors
		public <>c__DisplayClass53_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_Minimap window); // 0x0000000180ECEF60-0x0000000180ECEFD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 12519
	{
		// Fields
		public UI_Window_Minimap <>4__this; // 0x10
		public string inText; // 0x18
		public Color c; // 0x20
		public Action <>9__3; // 0x30
		public Action <>9__2; // 0x38

		// Constructors
		public <>c__DisplayClass62_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <InitLevelNameIntro>b__0(); // 0x0000000180ECEFD0-0x0000000180ECF100
		internal void <InitLevelNameIntro>b__2(); // 0x0000000180ECF100-0x0000000180ECF210
		internal void <InitLevelNameIntro>b__3(); // 0x0000000180ECF210-0x0000000180ECF250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12520
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__62_1; // 0x08

		// Constructors
		static <>c(); // 0x0000000180ECF870-0x0000000180ECF8D0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <InitLevelNameIntro>b__62_1(); // 0x0000000180ECD4A0-0x0000000180ECD550
	}

	// Constructors
	public UI_Window_Minimap(); // 0x0000000180EDB990-0x0000000180EDBA50
	static UI_Window_Minimap(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public static void OpenWindow(bool inMapOn = true /* Metadata: 0x00782F48 */); // 0x0000000180EDAF50-0x0000000180EDB010
	public static void CloseWindow(); // 0x0000000180ED9DE0-0x0000000180ED9E30
	protected override void OnOpen(); // 0x0000000180EDAF20-0x0000000180EDAF50
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	private void ToggleExpandedMinimap(); // 0x0000000180EDB470-0x0000000180EDB5E0
	public override void MStart(); // 0x0000000180EDACE0-0x0000000180EDAF20
	public override void MOnDestroy(); // 0x0000000180EDAC30-0x0000000180EDACE0
	private void LateUpdate(); // 0x0000000180EDA3F0-0x0000000180EDAC30
	private void InitLevelNameIntro(string inText); // 0x0000000180ED9FD0-0x0000000180EDA150
	private void InitElements(); // 0x0000000180ED9E30-0x0000000180ED9FD0
	private void InitMinimap(); // 0x0000000180EDA150-0x0000000180EDA3F0
	private void SetMinimapMap(); // 0x0000000180EDB070-0x0000000180EDB1B0
	public static List<GameObject> SpawnMapImages(Transform inParent, bool inFullscreen = false /* Metadata: 0x00782F49 */); // 0x0000000180EDB1B0-0x0000000180EDB470
	public void BtnClicked_ZoomIn(); // 0x0000000180ED9D40-0x0000000180ED9D90
	public void BtnClicked_ZoomOut(); // 0x0000000180ED9D90-0x0000000180ED9DE0
	public void BtnClicked_ExpandMinimap(); // 0x0000000180ED9CF0-0x0000000180ED9D40
	public void SetMapOn(bool inOn); // 0x0000000180EDB010-0x0000000180EDB070
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitElements>b__63_0(GameObject loadedAsset); // 0x0000000180EDB5E0-0x0000000180EDB6F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitElements>b__63_1(GameObject loadedAsset); // 0x0000000180EDB6F0-0x0000000180EDB800
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <InitMinimap>b__64_0(); // 0x0000000180EDB800-0x0000000180EDB990
}

