/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_SelfieMode : UI_Window // TypeDefIndex: 12604
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _showNamebarsButton; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _viewfinderLandscape; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _viewfinderPortrait; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _helpPopup; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _helpPopup_ForWindows; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _helpPopup_ForMac; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private AspectRatioFitter _viewFinderFitter; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _shutterFx; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _shutterSfx; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWFeralSlider fovSlider; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 fovMinMax; // 0x158
	private bool _hasRequestedHideNamebars; // 0x160
	private bool _isPortrait; // 0x161
	private float _defaultFovSliderValue; // 0x164

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12605
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_SelfieMode> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180E9F330-0x0000000180E9F390
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_SelfieMode window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180E9D150-0x0000000180E9D1D0
	}

	// Constructors
	public UI_Window_SelfieMode(); // 0x0000000180EACA50-0x0000000180EACA70

	// Methods
	public static void OpenWindow(); // 0x0000000180EAC680-0x0000000180EAC780
	public static void QueueWindow(); // 0x0000000180EAC780-0x0000000180EAC880
	public static void CloseWindow(); // 0x0000000180EAB850-0x0000000180EAB8A0
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180EABD30-0x0000000180EAC3F0
	protected override void OnClose(bool inAnimate); // 0x0000000180EAB910-0x0000000180EABD30
	private void OnInteracted(InteractablePointMessage inMessage); // 0x0000000180EAB850-0x0000000180EAB8A0
	protected virtual void OnWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180EAC4C0-0x0000000180EAC680
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	public void BtnClicked_Help(); // 0x0000000180EAB430-0x0000000180EAB560
	public void BtnClicked_CloseHelp(); // 0x0000000180EAB090-0x0000000180EAB120
	public void ToggleBtnClicked_Namebars(bool inIsOn); // 0x0000000180EAC9B0-0x0000000180EACA50
	public void BtnClicked_ResetCamera(); // 0x0000000180EAB560-0x0000000180EAB6B0
	public void BtnClicked_ToggleChat(); // 0x0000000180EAB7C0-0x0000000180EAB850
	public void BtnClicked_FocusChat(); // 0x0000000180EAB180-0x0000000180EAB1F0
	public void BtnClicked_Gallery(); // 0x0000000180EAB1F0-0x0000000180EAB430
	public void BtnClicked_FlipCamera(); // 0x0000000180EAB120-0x0000000180EAB180
	public void BtnClicked_TakePicture(); // 0x0000000180EAB6B0-0x0000000180EAB7C0
	public void SliderValueChanged_Fov(float inValue); // 0x0000000180EAC880-0x0000000180EAC9B0
	public void OnSelfieTaken(Texture2D inSelfieShot); // 0x0000000180EAC3F0-0x0000000180EAC4C0
	private string GetScreenShotFolderName(); // 0x0000000180EAB8A0-0x0000000180EAB910
}

