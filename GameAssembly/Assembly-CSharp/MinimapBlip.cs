/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800B6E20-0x00000001800B6E50
public class MinimapBlip : ManagedBehaviour // TypeDefIndex: 10849
{
	// Fields
	public MinimapManager.EBlipType blipType; // 0x50
	public bool forceDisplayOnExpandedMap; // 0x54
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private MinimapBlipData <minimapBlipData>k__BackingField; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MinimapBlip <uiMinimapBlip>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MinimapIndicator <uiMinimapIndicator>k__BackingField; // 0x68
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Avatar_Network <avatarNetwork>k__BackingField; // 0x70
	internal MinimapBlipMainQuestNavIndicator minimapBlipMainQuestNavIndicator; // 0x78

	// Properties
	public MinimapBlipData minimapBlipData { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180357120-0x0000000180357130 0x0000000180485C70-0x0000000180485C80
	public UI_MinimapBlip uiMinimapBlip { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	public UI_MinimapIndicator uiMinimapIndicator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
	public Avatar_Network avatarNetwork { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800

	// Constructors
	public MinimapBlip(); // 0x00000001810B1780-0x00000001810B17E0

	// Methods
	public override void MOnEnable(); // 0x00000001810B13B0-0x00000001810B16D0
	private void CheckForNetworkPlayer(); // 0x00000001810B0C20-0x00000001810B0EA0
	public override void MOnDisable(); // 0x00000001810B1190-0x00000001810B13B0
	public void SetBlipData(MinimapBlipData inMinimapBlipData); // 0x0000000180485C70-0x0000000180485C80
	public void SetBlipUI(UI_MinimapBlip inUI_MinimapBlip); // 0x00000001803A27E0-0x00000001803A27F0
	public void SetBlipIndicator(UI_MinimapIndicator inUI_MinimapIndicator); // 0x00000001803A27D0-0x00000001803A27E0
	public void ForceState(UI_MinimapBlip.EForceState inForceState); // 0x00000001810B0EA0-0x00000001810B0F70
	public static MinimapManager.EBlipType GetBlipType(string inLevelId); // 0x00000001810B0F70-0x00000001810B1190
	public static void AddBlip(GameObject inParent, string inLevelId); // 0x00000001810B0AF0-0x00000001810B0B90
	public static void AddBlip(GameObject inParent, MinimapManager.EBlipType inBlipType); // 0x00000001810B0B90-0x00000001810B0C20
	public static void RemoveBlip(GameObject inParent); // 0x00000001810B16D0-0x00000001810B1780
}

