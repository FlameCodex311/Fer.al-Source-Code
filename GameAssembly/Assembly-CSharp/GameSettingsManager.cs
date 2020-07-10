/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GameSettingsManager : SingletonManagerBase<GameSettingsManager> // TypeDefIndex: 10682
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _helpOverlaysOnUserVar; // 0x60
	private bool? _helpOverlaysOn; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _tooltipsOnUserVar; // 0x70
	private bool? _tooltipsOn; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _chatBubblesOnUserVar; // 0x80
	private bool? _chatBubblesOn; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _chatIsFilteredUserVar; // 0x90
	private bool? _chatIsFiltered; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _controlModeUserVar; // 0xA0
	private ControlSetting? _controlMode; // 0xA8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private ControlSetting? <OverrideControlMode>k__BackingField; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _invertCameraUserVar; // 0xB8
	private bool? _invertCamera; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _cameraSensitivityUserVar; // 0xC8
	private float? _cameraSensitivity; // 0xD0
	private bool? _cameraFollowSetting; // 0xD8
	private bool? _cameraOrbitToggleModeSetting; // 0xDA
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CachedUserVar _sanctuaryPrivacyUserVar; // 0xE0
	private SanctuaryPrivacySetting? _sanctuaryPrivacy; // 0xE8

	// Properties
	public bool HelpOverlaysOn { get; set; } // 0x0000000181052F40-0x0000000181052FC0 0x0000000181053680-0x0000000181053740
	public bool TooltipsOn { get; set; } // 0x00000001810530E0-0x0000000181053160 0x0000000181053840-0x00000001810538B0
	public bool ChatBubblesOn { get; set; } // 0x0000000181052D60-0x0000000181052DF0 0x00000001810534C0-0x0000000181053540
	[DebugField] // 0x000000018016F2A0-0x000000018016F300
	public bool ChatIsFiltered { get; set; } // 0x0000000181052DF0-0x0000000181052E80 0x0000000181053540-0x0000000181053600
	public ControlSetting ControlMode { get; set; } // 0x0000000181052E80-0x0000000181052F40 0x0000000181053600-0x0000000181053680
	public ControlSetting? OverrideControlMode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803ED9D0-0x00000001803ED9E0 0x00000001804A0A60-0x00000001804A0A70
	public bool InvertCamera { get; set; } // 0x0000000181052FC0-0x0000000181053050 0x0000000181053740-0x00000001810537C0
	public float CameraSensitivity { get; set; } // 0x0000000181052C80-0x0000000181052D60 0x0000000181053360-0x00000001810534C0
	public bool CameraFollowSetting { get; set; } // 0x0000000181052A40-0x0000000181052B60 0x0000000181053160-0x0000000181053260
	public bool CameraOrbitToggleModeSetting { get; set; } // 0x0000000181052B60-0x0000000181052C80 0x0000000181053260-0x0000000181053360
	public SanctuaryPrivacySetting SanctuaryPrivacy { get; set; } // 0x0000000181053050-0x00000001810530E0 0x00000001810537C0-0x0000000181053840

	// Nested types
	public class HelpOverlaysSettingChangedMessage : Message // TypeDefIndex: 10683
	{
		// Fields
		public readonly bool HelpOverlaysOn; // 0x18

		// Constructors
		public HelpOverlaysSettingChangedMessage(bool inHelpOverlaysOn); // 0x0000000180EC14B0-0x0000000180EC14E0
	}

	public enum ControlSetting // TypeDefIndex: 10684
	{
		Standard = 0,
		Simplified = 5,
		FirstPerson = 10
	}

	public enum SanctuaryPrivacySetting // TypeDefIndex: 10685
	{
		Everyone = 0,
		Friends = 1,
		Noone = 2
	}

	// Constructors
	public GameSettingsManager(); // 0x0000000181052A00-0x0000000181052A40

	// Methods
	public override void Init(); // 0x0000000181052910-0x00000001810529C0
	public override void Deinit(); // 0x0000000181052860-0x0000000181052910
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x00000001810529C0-0x0000000181052A00
	public void ApplySettings(); // 0x0000000181052170-0x0000000181052860
}

