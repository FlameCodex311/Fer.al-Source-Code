/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018026FA70-0x000000018026FAA0
public class MinimapBlip : ManagedBehaviour // TypeDefIndex: 12359
{
	// Fields
	public MinimapManager.EBlipType blipType; // 0x50
	public bool forceDisplayOnExpandedMap; // 0x54
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private MinimapBlipData <minimapBlipData>k__BackingField; // 0x58
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MinimapBlip <uiMinimapBlip>k__BackingField; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MinimapIndicator <uiMinimapIndicator>k__BackingField; // 0x68
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Avatar_Network <avatarNetwork>k__BackingField; // 0x70
	internal MinimapBlipMainQuestNavIndicator minimapBlipMainQuestNavIndicator; // 0x78

	// Properties
	public MinimapBlipData minimapBlipData { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803A1580-0x00000001803A1590 0x00000001803A1740-0x00000001803A1750
	public UI_MinimapBlip uiMinimapBlip { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
	public UI_MinimapIndicator uiMinimapIndicator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
	public Avatar_Network avatarNetwork { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0

	// Constructors
	public MinimapBlip(); // 0x0000000180C00C40-0x0000000180C00CA0

	// Methods
	public override void MOnEnable(); // 0x0000000180C00880-0x0000000180C00B90
	private void CheckForNetworkPlayer(); // 0x0000000180C00110-0x0000000180C00380
	public override void MOnDisable(); // 0x0000000180C00670-0x0000000180C00880
	public void SetBlipData(MinimapBlipData inMinimapBlipData); // 0x00000001803A1740-0x00000001803A1750
	public void SetBlipUI(UI_MinimapBlip inUI_MinimapBlip); // 0x00000001804AF510-0x00000001804AF520
	public void SetBlipIndicator(UI_MinimapIndicator inUI_MinimapIndicator); // 0x00000001804ADAC0-0x00000001804ADAD0
	public void ForceState(UI_MinimapBlip.EForceState inForceState); // 0x0000000180C00380-0x0000000180C00450
	public static MinimapManager.EBlipType GetBlipType(string inLevelId); // 0x0000000180C00450-0x0000000180C00670
	public static void AddBlip(GameObject inParent, string inLevelId); // 0x0000000180BFFFE0-0x0000000180C00080
	public static void AddBlip(GameObject inParent, MinimapManager.EBlipType inBlipType); // 0x0000000180C00080-0x0000000180C00110
	public static void RemoveBlip(GameObject inParent); // 0x0000000180C00B90-0x0000000180C00C40
}

