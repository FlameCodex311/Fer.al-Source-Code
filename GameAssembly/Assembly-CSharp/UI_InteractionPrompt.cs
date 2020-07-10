/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_InteractionPrompt : MonoBehaviour // TypeDefIndex: 12320
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_InteractionPrompt <instance>k__BackingField; // 0x00
	private float _fillTimer; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _mainRectTransform; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _panelObject; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _panelRectTransform; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWButton _button; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image _btnImage; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _keyboardBtnSprite; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _mobileBtnSprite; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _actionGroup; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _actionIcon; // 0x70
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Tooltip _actionTooltip; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image _progressImage; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent _onProgressStart; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent _onProgressFinish; // 0x90
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UnityEvent _onProgressCancel; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _defaultFirstPersonOffset; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _fxWheelRotate; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _fxWheelFinish; // 0xB0
	private EFillState _fillState; // 0xB8
	private CustomController _customController; // 0xC0
	private Transform _targetTransform; // 0xC8
	private Vector3 _targetOffset; // 0xD0
	private Vector3 _targetOffsetFirstPerson; // 0xDC
	private EButtonState _desiredButtonState; // 0xE8
	private EButtonState _currentButtonState; // 0xEC

	// Properties
	public static UI_InteractionPrompt instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E44FE0-0x0000000180E45020 0x0000000180E45020-0x0000000180E45060

	// Nested types
	private enum EFillState // TypeDefIndex: 12321
	{
		NONE = 0,
		STARTED = 1,
		FILLING = 2
	}

	public enum EButtonState // TypeDefIndex: 12322
	{
		NONE = 0,
		DOWN = 1,
		UP = 2
	}

	// Constructors
	public UI_InteractionPrompt(); // 0x0000000180E44FC0-0x0000000180E44FE0

	// Methods
	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage); // 0x0000000180E44020-0x0000000180E440A0
	private void OnInteractableInteracted(InteractableInteractedMessage inMessage); // 0x0000000180E43F40-0x0000000180E44020
	private void Setup(Interactable inPromptTarget); // 0x0000000180E44230-0x0000000180E446A0
	private void Start(); // 0x0000000180E446A0-0x0000000180E447F0
	private void OnDestroy(); // 0x0000000180E43E40-0x0000000180E43F40
	private void Update(); // 0x0000000180E44910-0x0000000180E44FC0
	private void FinishFX(); // 0x0000000180E43DA0-0x0000000180E43E40
	private void ResetButton(); // 0x0000000180E440A0-0x0000000180E44230
	public void BtnClicked_InteractDown(); // 0x0000000180E43D80-0x0000000180E43D90
	public void BtnClicked_InteractUp(); // 0x0000000180E43D90-0x0000000180E43DA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__34_0(Sprite cSprite); // 0x0000000180E44850-0x0000000180E448A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__34_1(); // 0x0000000180E448A0-0x0000000180E44910
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <FinishFX>b__38_0(); // 0x0000000180E447F0-0x0000000180E44850
}

