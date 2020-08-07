/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018026FA70-0x000000018026FAA0
public class UI_MinimapBlip : ManagedBehaviour // TypeDefIndex: 12369
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private EState <currentState>k__BackingField; // 0x88
	private MinimapBlipData _minimapBlipData; // 0x90
	private MinimapBlip _minimapBlip; // 0x98
	private MinimapManager.EBlipType _blipType; // 0xA0
	private string _blipTooltipText; // 0xA8

	// Properties
	public UI_Tooltip tooltip { get; } // 0x00000001803CCE30-0x00000001803CCEB0 
	public FeralButton button { get; } // 0x00000001803CCDA0-0x00000001803CCE20 
	public RawImage activeRawImage { get; } // 0x00000001803CCD80-0x00000001803CCDA0 
	private bool _showInsideMap { get; } // 0x00000001803CCC40-0x00000001803CCD00 
	private bool _showOutsideMap { get; } // 0x00000001803CCD00-0x00000001803CCD80 
	public EState currentState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0

	// Nested types
	public enum EForceState // TypeDefIndex: 12370
	{
		DEFAULT = 0,
		FADE = 1,
		SHOW = 2
	}

	public enum EState // TypeDefIndex: 12371
	{
		NONE = 0,
		IN_MAP = 1,
		OUTSIDE_MAP = 2
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass33_0 // TypeDefIndex: 12372
	{
		// Fields
		public InteractableWorldMap cInteractableWorldMap; // 0x10
		public UI_MinimapBlip <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass33_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <BtnClicked>b__0(bool cb); // 0x00000001803C6530-0x00000001803C6710
	}

	// Constructors
	public UI_MinimapBlip(); // 0x00000001803CCBE0-0x00000001803CCC40

	// Methods
	public void SetBlipData(MinimapBlipData inBlipData); // 0x00000001803CBD70-0x00000001803CC2B0
	public void SetScale(float inScale); // 0x00000001803CC910-0x00000001803CCBE0
	public void ForceState(EForceState inForceState); // 0x00000001803CB660-0x00000001803CB670
	public void SetMapState(bool inExpandedMap); // 0x00000001803CC7A0-0x00000001803CC7B0
	public void BtnClicked(); // 0x00000001803CB3A0-0x00000001803CB660
	public void SetPositionAndRotation(Vector3 inPosition, Quaternion inRotation); // 0x00000001803CC7B0-0x00000001803CC910
	public void SetBlipType(MinimapBlip inBlip); // 0x00000001803CC340-0x00000001803CC7A0
	private string GetNetworkPlayerName(); // 0x00000001803CB670-0x00000001803CB720
	private string GetPlayerName(); // 0x00000001803CB850-0x00000001803CB890
	private string GetWorldMapLocationName(); // 0x00000001803CB890-0x00000001803CBBF0
	private string GetNpcName(); // 0x00000001803CB720-0x00000001803CB850
	public void SetBlipState(EState inState); // 0x00000001803CC2B0-0x00000001803CC340
	public void Hide(bool inFadeout); // 0x00000001803CBBF0-0x00000001803CBC00
	private void LateUpdate(); // 0x00000001803CBC00-0x00000001803CBD70
}

