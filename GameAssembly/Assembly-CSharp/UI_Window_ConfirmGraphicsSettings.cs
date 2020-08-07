/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ConfirmGraphicsSettings : UI_Window // TypeDefIndex: 14022
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected WWTextMeshProUGUI _timeText; // 0x108
	private bool _isSetup; // 0x110
	private bool _coreReset; // 0x111
	private float _remainingTime; // 0x114
	private int _prevRemaningSeconds; // 0x118
	private Resolution _originalResolution; // 0x11C
	private bool _originalFullscreen; // 0x128
	private DeviceQualityLevel _originalQuality; // 0x12C

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14023
	{
		// Fields
		public Resolution inOriginalResolution; // 0x10
		public bool inOriginalFullscreen; // 0x1C
		public DeviceQualityLevel inOriginalQuality; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ConfirmGraphicsSettings window); // 0x000000018047E770-0x000000018047E7C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14024
	{
		// Fields
		public Resolution inOriginalResolution; // 0x10
		public bool inOriginalFullscreen; // 0x1C
		public DeviceQualityLevel inOriginalQuality; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EAC0-0x000000018047EBB0
	}

	// Constructors
	public UI_Window_ConfirmGraphicsSettings(); // 0x0000000180484E90-0x0000000180484EB0

	// Methods
	public static void OpenWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180484AA0-0x0000000180484B90
	public static void QueueWindow(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180484B90-0x0000000180484C80
	public static void CloseWindow(); // 0x0000000180484820-0x0000000180484870
	public void BtnClicked_Confirm(); // 0x00000001804847B0-0x0000000180484820
	public void BtnClicked_Cancel(); // 0x00000001804846E0-0x00000001804847B0
	private void Setup(Resolution inOriginalResolution, bool inOriginalFullscreen, DeviceQualityLevel inOriginalQuality); // 0x0000000180484D70-0x0000000180484E90
	private void RefreshTimeText(); // 0x0000000180484C80-0x0000000180484D70
	public override void MUpdate(); // 0x0000000180484870-0x0000000180484AA0
}

