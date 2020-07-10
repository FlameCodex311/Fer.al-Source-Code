/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800B6E20-0x00000001800B6E50
public class UI_MinimapBlip : ManagedBehaviour // TypeDefIndex: 10859
{
	// Fields
	private GameObject _blipInsideMapGameObject; // 0x50
	private GameObject _blipOutsideMapGameObject; // 0x58
	private RawImage _blipInsideMapRawImage; // 0x60
	private RawImage _blipOutsideMapRawImage; // 0x68
	private UI_Tooltip _tooltip; // 0x70
	private FeralButton _button; // 0x78
	private bool _fadeOut; // 0x80
	private bool _inExpandedMap; // 0x81
	private EForceState _forceState; // 0x84
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private EState <currentState>k__BackingField; // 0x88
	private MinimapBlipData _minimapBlipData; // 0x90
	private MinimapBlip _minimapBlip; // 0x98
	private MinimapManager.EBlipType _blipType; // 0xA0
	private string _blipTooltipText; // 0xA8

	// Properties
	public UI_Tooltip tooltip { get; } // 0x0000000180E83520-0x0000000180E835A0 
	public FeralButton button { get; } // 0x0000000180E834A0-0x0000000180E83520 
	public RawImage activeRawImage { get; } // 0x0000000180E83480-0x0000000180E834A0 
	private bool _showInsideMap { get; } // 0x0000000180E83340-0x0000000180E83400 
	private bool _showOutsideMap { get; } // 0x0000000180E83400-0x0000000180E83480 
	public EState currentState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018049D3B0-0x000000018049D3C0 0x000000018049D3C0-0x000000018049D3D0

	// Nested types
	public enum EForceState // TypeDefIndex: 10860
	{
		DEFAULT = 0,
		FADE = 1,
		SHOW = 2
	}

	public enum EState // TypeDefIndex: 10861
	{
		NONE = 0,
		IN_MAP = 1,
		OUTSIDE_MAP = 2
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 10862
	{
		// Fields
		public InteractableWorldMap cInteractableWorldMap; // 0x10

		// Constructors
		public <>c__DisplayClass33_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <BtnClicked>b__0(bool cb); // 0x0000000180E722B0-0x0000000180E724C0
	}

	// Constructors
	public UI_MinimapBlip(); // 0x0000000180E832E0-0x0000000180E83340

	// Methods
	public void SetBlipData(MinimapBlipData inBlipData); // 0x0000000180E82440-0x0000000180E829A0
	public void SetScale(float inScale); // 0x0000000180E83010-0x0000000180E832E0
	public void ForceState(EForceState inForceState); // 0x0000000180E81D20-0x0000000180E81D30
	public void SetMapState(bool inExpandedMap); // 0x0000000180E82E90-0x0000000180E82EA0
	public void BtnClicked(); // 0x0000000180E81A60-0x0000000180E81D20
	public void SetPositionAndRotation(Vector3 inPosition, Quaternion inRotation); // 0x0000000180E82EA0-0x0000000180E83010
	public void SetBlipType(MinimapBlip inBlip); // 0x0000000180E82A30-0x0000000180E82E90
	private string GetNetworkPlayerName(); // 0x0000000180E81D30-0x0000000180E81DE0
	private string GetPlayerName(); // 0x0000000180E81F10-0x0000000180E81F50
	private string GetWorldMapLocationName(); // 0x0000000180E81F50-0x0000000180E822C0
	private string GetNpcName(); // 0x0000000180E81DE0-0x0000000180E81F10
	public void SetBlipState(EState inState); // 0x0000000180E829A0-0x0000000180E82A30
	public void Hide(bool inFadeout); // 0x0000000180E822C0-0x0000000180E822D0
	private void LateUpdate(); // 0x0000000180E822D0-0x0000000180E82440
}

