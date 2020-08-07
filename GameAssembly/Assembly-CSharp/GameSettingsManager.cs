/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GameSettingsManager : SingletonManagerBase<GameSettingsManager> // TypeDefIndex: 12185
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _helpOverlaysOnUserVar; // 0x60
	private bool? _helpOverlaysOn; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _tooltipsOnUserVar; // 0x70
	private bool? _tooltipsOn; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _chatBubblesOnUserVar; // 0x80
	private bool? _chatBubblesOn; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _chatIsFilteredUserVar; // 0x90
	private bool? _chatIsFiltered; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _controlModeUserVar; // 0xA0
	private ControlSetting? _controlMode; // 0xA8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private ControlSetting? <OverrideControlMode>k__BackingField; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _invertCameraUserVar; // 0xB8
	private bool? _invertCamera; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _cameraSensitivityUserVar; // 0xC8
	private float? _cameraSensitivity; // 0xD0
	private bool? _cameraFollowSetting; // 0xD8
	private bool? _cameraOrbitToggleModeSetting; // 0xDA
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _isMotionBlurEnabledUserVar; // 0xE0
	private bool? _isMotionBlurEnabled; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _sanctuaryPrivacyUserVar; // 0xF0
	private PrivacySetting.PrivacyLevel? _sanctuaryPrivacy; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _tradingPrivacyUserVar; // 0x100
	private PrivacySetting.PrivacyLevel? _tradingPrivacy; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CachedUserVar _goToPlayerPrivacyUserVar; // 0x110
	private PrivacySetting.PrivacyLevel? _goToPlayerPrivacy; // 0x118

	// Properties
	public bool HelpOverlaysOn { get; set; } // 0x000000018067DB80-0x000000018067DC00 0x000000018067E470-0x000000018067E530
	public bool TooltipsOn { get; set; } // 0x000000018067DDC0-0x000000018067DE40 0x000000018067E6C0-0x000000018067E730
	public bool ChatBubblesOn { get; set; } // 0x000000018067D910-0x000000018067D9A0 0x000000018067E230-0x000000018067E2B0
	[DebugField] // 0x000000018024BC30-0x000000018024BC90
	public bool ChatIsFiltered { get; set; } // 0x000000018067D9A0-0x000000018067DA30 0x000000018067E2B0-0x000000018067E370
	public ControlSetting ControlMode { get; set; } // 0x000000018067DA30-0x000000018067DAF0 0x000000018067E370-0x000000018067E3F0
	public ControlSetting? OverrideControlMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018067DD20-0x000000018067DD30 0x000000018067E630-0x000000018067E640
	public bool InvertCamera { get; set; } // 0x000000018067DC00-0x000000018067DC90 0x000000018067E530-0x000000018067E5B0
	public float CameraSensitivity { get; set; } // 0x000000018067D830-0x000000018067D910 0x000000018067E0D0-0x000000018067E230
	public bool CameraFollowSetting { get; set; } // 0x000000018067D5F0-0x000000018067D710 0x000000018067DED0-0x000000018067DFD0
	public bool CameraOrbitToggleModeSetting { get; set; } // 0x000000018067D710-0x000000018067D830 0x000000018067DFD0-0x000000018067E0D0
	public bool IsMotionBlurEnabled { get; set; } // 0x000000018067DC90-0x000000018067DD20 0x000000018067E5B0-0x000000018067E630
	public PrivacySetting.PrivacyLevel SanctuaryPrivacy { get; set; } // 0x000000018067DD30-0x000000018067DDC0 0x000000018067E640-0x000000018067E6C0
	public PrivacySetting.PrivacyLevel TradingPrivacy { get; set; } // 0x000000018067DE40-0x000000018067DED0 0x000000018067E730-0x000000018067E7B0
	public PrivacySetting.PrivacyLevel GoToPlayerPrivacy { get; set; } // 0x000000018067DAF0-0x000000018067DB80 0x000000018067E3F0-0x000000018067E470

	// Nested types
	public class HelpOverlaysSettingChangedMessage : Message // TypeDefIndex: 12186
	{
		// Fields
		public readonly bool HelpOverlaysOn; // 0x18

		// Constructors
		public HelpOverlaysSettingChangedMessage(bool inHelpOverlaysOn); // 0x000000018049D870-0x000000018049D8A0
	}

	public enum ControlSetting // TypeDefIndex: 12187
	{
		Standard = 0,
		Simplified = 5,
		FirstPerson = 10
	}

	// Constructors
	public GameSettingsManager(); // 0x000000018067D5B0-0x000000018067D5F0

	// Methods
	public override void Init(); // 0x000000018067D450-0x000000018067D500
	public override void Deinit(); // 0x000000018067D3A0-0x000000018067D450
	private void OnLoginComplete(LoginCompleteResponse inMessage); // 0x000000018067D500-0x000000018067D5B0
	public void ApplySettings(); // 0x000000018067CA50-0x000000018067D3A0
}

