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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_InteractionPrompt : MonoBehaviour // TypeDefIndex: 13904
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_InteractionPrompt <instance>k__BackingField; // 0x00
	private float _fillTimer; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _mainRectTransform; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _panelObject; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _panelRectTransform; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWButton _button; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image _btnImage; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _keyboardBtnSprite; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _mobileBtnSprite; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _actionGroup; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _actionIcon; // 0x70
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Tooltip _actionTooltip; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image _progressImage; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent _onProgressStart; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent _onProgressFinish; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UnityEvent _onProgressCancel; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _fxWheelRotate; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _fxWheelFinish; // 0xA8
	private Vector3 _screenPosition; // 0xB0
	private bool _continuePressFromUI; // 0xBC
	private EFillState _fillState; // 0xC0
	private CustomController _customController; // 0xC8
	private Transform _targetTransform; // 0xD0
	private Vector3 _targetOffset; // 0xD8
	private Vector3 _targetOffsetFirstPerson; // 0xE4
	private Interactable _interactable; // 0xF0
	private EButtonState _desiredButtonState; // 0xF8
	private EButtonState _currentButtonState; // 0xFC

	// Properties
	public static UI_InteractionPrompt instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018037CAC0-0x000000018037CB00 0x000000018037CB00-0x000000018037CB40

	// Nested types
	private enum EFillState // TypeDefIndex: 13905
	{
		NONE = 0,
		STARTED = 1,
		FILLING = 2
	}

	public enum EButtonState // TypeDefIndex: 13906
	{
		NONE = 0,
		BUTTON_DOWN = 1,
		BUTTON_UP = 2,
		UI_DOWN = 3,
		UI_UP = 4
	}

	// Constructors
	public UI_InteractionPrompt(); // 0x000000018037CA40-0x000000018037CAC0

	// Methods
	private void OnPrimaryInteractableUpdated(PrimaryInteractableUpdatedMessage inMessage); // 0x000000018037BAC0-0x000000018037BB30
	private void OnInteractableInteracted(InteractableInteractedMessage inMessage); // 0x000000018037B9E0-0x000000018037BAC0
	private void Setup(Interactable inPromptTarget); // 0x000000018037BCD0-0x000000018037C140
	private void Start(); // 0x000000018037C1C0-0x000000018037C310
	private void OnDestroy(); // 0x000000018037B8E0-0x000000018037B9E0
	private void Update(); // 0x000000018037C430-0x000000018037CA40
	private void StartFill(); // 0x000000018037C140-0x000000018037C1C0
	private void CancelFill(); // 0x000000018037B5E0-0x000000018037B660
	private void FinishFill(); // 0x000000018037B700-0x000000018037B8E0
	private void FinishFX(); // 0x000000018037B660-0x000000018037B700
	private void ResetButton(); // 0x000000018037BB30-0x000000018037BCD0
	public void BtnClicked_InteractDown(); // 0x000000018037B5C0-0x000000018037B5D0
	public void BtnClicked_InteractUp(); // 0x000000018037B5D0-0x000000018037B5E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__36_0(Sprite cSprite); // 0x000000018037C370-0x000000018037C3C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__36_1(); // 0x000000018037C3C0-0x000000018037C430
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <FinishFX>b__43_0(); // 0x000000018037C310-0x000000018037C370
}

