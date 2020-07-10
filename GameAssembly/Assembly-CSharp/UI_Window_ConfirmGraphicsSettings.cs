/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ConfirmGraphicsSettings : UI_Window // TypeDefIndex: 12423
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected WWTextMeshProUGUI _timeText; // 0x108
	private bool _isSetup; // 0x110
	private bool _coreReset; // 0x111
	private float _remainingTime; // 0x114
	private int _prevRemaningSeconds; // 0x118
	private Resolution _originalResolution; // 0x11C
	private bool _originalFullscreen; // 0x128
	private DeviceQualityLevel _originalQuality; // 0x12C

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12424
	{
		// Fields
		public Resolution inOriginalResolution; // 0x10
		public bool inOriginalFullscreen; // 0x1C
		public DeviceQualityLevel inOriginalQuality; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ConfirmGraphicsSettings window); // 0x0000000180EFEE50-0x0000000180EFEEA0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12425
	{
		// Fields
		public Resolution inOriginalResolution; // 0x10
		public bool inOriginalFullscreen; // 0x1C
		public DeviceQualityLevel inOriginalQuality; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180EFF130-0x0000000180EFF220
	}

	// Constructors
	public UI_Window_ConfirmGraphicsSettings(); // 0x0000000180F06BB0-0x0000000180F06BD0

	// Methods
	public static void OpenWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180F067C0-0x0000000180F068B0
	public static void QueueWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180F068B0-0x0000000180F069A0
	public static void CloseWindow(); // 0x0000000180F06530-0x0000000180F06580
	public void BtnClicked_Confirm(); // 0x0000000180F064C0-0x0000000180F06530
	public void BtnClicked_Cancel(); // 0x0000000180F063F0-0x0000000180F064C0
	private void Setup(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180F06A90-0x0000000180F06BB0
	private void RefreshTimeText(); // 0x0000000180F069A0-0x0000000180F06A90
	public override void MUpdate(); // 0x0000000180F06580-0x0000000180F067C0
}

