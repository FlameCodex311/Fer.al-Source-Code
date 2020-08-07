/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_SelfieMode : UI_Window // TypeDefIndex: 14206
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _showNamebarsButton; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _viewfinderLandscape; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _viewfinderPortrait; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _helpPopup; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _helpPopup_ForWindows; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _helpPopup_ForMac; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private AspectRatioFitter _viewFinderFitter; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _shutterFx; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _shutterSfx; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWFeralSlider fovSlider; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 fovMinMax; // 0x158
	private bool _hasRequestedHideNamebars; // 0x160
	private bool _isPortrait; // 0x161
	private float _defaultFovSliderValue; // 0x164

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14207
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelfieMode> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803B41C0-0x00000001803B4220
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelfieMode window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803B2570-0x00000001803B25F0
	}

	// Constructors
	public UI_Window_SelfieMode(); // 0x00000001803C2E10-0x00000001803C2E30

	// Methods
	public static void OpenWindow(); // 0x00000001803C2A40-0x00000001803C2B40
	public static void QueueWindow(); // 0x00000001803C2B40-0x00000001803C2C40
	public static void CloseWindow(); // 0x00000001803C1C30-0x00000001803C1C80
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803C2100-0x00000001803C27B0
	protected override void OnClose(bool inAnimate); // 0x00000001803C1CF0-0x00000001803C2100
	private void OnInteracted(InteractablePointMessage inMessage); // 0x00000001803C1C30-0x00000001803C1C80
	protected virtual void OnWindowOpened(WindowOpenedMessage inMessage); // 0x00000001803C2880-0x00000001803C2A40
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Help(); // 0x00000001803C1810-0x00000001803C1940
	public void BtnClicked_CloseHelp(); // 0x00000001803C1480-0x00000001803C1510
	public void ToggleBtnClicked_Namebars(bool inIsOn); // 0x00000001803C2D70-0x00000001803C2E10
	public void BtnClicked_ResetCamera(); // 0x00000001803C1940-0x00000001803C1A90
	public void BtnClicked_ToggleChat(); // 0x00000001803C1BA0-0x00000001803C1C30
	public void BtnClicked_FocusChat(); // 0x00000001803C1570-0x00000001803C15E0
	public void BtnClicked_Gallery(); // 0x00000001803C15E0-0x00000001803C1810
	public void BtnClicked_FlipCamera(); // 0x00000001803C1510-0x00000001803C1570
	public void BtnClicked_TakePicture(); // 0x00000001803C1A90-0x00000001803C1BA0
	public void SliderValueChanged_Fov(float inValue); // 0x00000001803C2C40-0x00000001803C2D70
	public void OnSelfieTaken(Texture2D inSelfieShot); // 0x00000001803C27B0-0x00000001803C2880
	private string GetScreenShotFolderName(); // 0x00000001803C1C80-0x00000001803C1CF0
}

