/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using UnityEngine;
using UnityEngine.EventSystems;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralInputManager : SingletonManagerBase<FeralInputManager> // TypeDefIndex: 10681
{
	// Fields
	private Dictionary<int, List<Action>> _registeredActions; // 0x60
	private Player _rewiredPlayer; // 0x68
	private int _gameplayActionCategoryDisableRequests; // 0x70
	private int _playerMovementActionCategoryDisableRequests; // 0x74
	private int _uiActionCategoryDisableRequests; // 0x78
	private Waiter _gameplayMapWaiter; // 0x80
	private Waiter _playerMovementMapWaiter; // 0x88
	private Waiter _uiMapWaiter; // 0x90
	private bool _controlsEnabled; // 0x98
	private GameObject _previousSelectedGameObject; // 0xA0
	private PointerEventData _pointerEventData; // 0xA8
	private List<RaycastResult> _pointerRaycastResults; // 0xB0
	private List<GameObject> _currentScrollCandidates; // 0xB8
	private List<GameObject> _currentClickCandidates; // 0xC0
	private int _enablesToDisables; // 0xC8

	// Properties
	public Player RewiredPlayer { get; } // 0x00000001811079A0-0x0000000181107A20 
	public bool IsGameplayActionCategoryEnabled { get; } // 0x0000000181107930-0x0000000181107940 
	public bool ControlsEnabled { get; } // 0x000000018081DF30-0x000000018081DF40 
	public bool IsUsingJoystick { get; } // 0x0000000181107940-0x00000001811079A0 
	public GameObject CurrentSelectedGameObject { get; } // 0x0000000181107830-0x0000000181107890 
	public bool HasScrollCandidate { get; } // 0x00000001811078E0-0x0000000181107930 
	public bool HasClickCandidate { get; } // 0x0000000181107890-0x00000001811078E0 

	// Constructors
	public FeralInputManager(); // 0x0000000181107730-0x0000000181107830

	// Methods
	public override void Init(); // 0x0000000181106C20-0x0000000181106E20
	public override void Deinit(); // 0x0000000181106340-0x0000000181106460
	private void SetControlsEnabled(SetControlsEnabledCommand inCommand); // 0x0000000181107320-0x0000000181107370
	private void OnDisableGameplayActionCategory(DisableGameplayActionCategoryMessage inMessage); // 0x0000000181106E20-0x0000000181107030
	private void OnDisableUIActionCategory(DisableUIActionCategoryMessage inMessage); // 0x0000000181107030-0x0000000181107150
	private void OnInputEvent(InputActionEventData inInputActionEventData); // 0x0000000181107150-0x0000000181107210
	public void RegisterAction(int inActionId, Action inAction); // 0x0000000181107210-0x0000000181107320
	public void UnregisterAction(int inActionId, Action inAction); // 0x00000001811074D0-0x0000000181107560
	public Vector2 GetMoveVector(); // 0x0000000181106B20-0x0000000181106C20
	public void SetSelectedGameObject(GameObject inGameObject); // 0x0000000181107370-0x00000001811073E0
	public List<GameObject> GetCurrentScrollCandidates(); // 0x00000001811067C0-0x0000000181106B20
	public List<GameObject> GetCurrentClickCandidates(); // 0x0000000181106460-0x00000001811067C0
	private new void Update(); // 0x0000000181107560-0x0000000181107730
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnDisableGameplayActionCategory>b__26_0(); // 0x00000001811073E0-0x0000000181107430
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnDisableGameplayActionCategory>b__26_1(); // 0x0000000181107430-0x0000000181107480
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnDisableUIActionCategory>b__27_0(); // 0x0000000181107480-0x00000001811074D0
}

