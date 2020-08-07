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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralInputManager : SingletonManagerBase<FeralInputManager> // TypeDefIndex: 12184
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
	public Player RewiredPlayer { get; } // 0x000000018069D5D0-0x000000018069D650 
	public bool IsGameplayActionCategoryEnabled { get; } // 0x000000018069D560-0x000000018069D570 
	public bool ControlsEnabled { get; } // 0x00000001803D3E90-0x00000001803D3EA0 
	public bool IsUsingJoystick { get; } // 0x000000018069D570-0x000000018069D5D0 
	public GameObject CurrentSelectedGameObject { get; } // 0x000000018069D460-0x000000018069D4C0 
	public bool HasScrollCandidate { get; } // 0x000000018069D510-0x000000018069D560 
	public bool HasClickCandidate { get; } // 0x000000018069D4C0-0x000000018069D510 

	// Constructors
	public FeralInputManager(); // 0x000000018069D360-0x000000018069D460

	// Methods
	public override void Init(); // 0x000000018069C540-0x000000018069C740
	public override void Deinit(); // 0x000000018069BC00-0x000000018069BD20
	private void SetControlsEnabled(SetControlsEnabledCommand inCommand); // 0x000000018069CC30-0x000000018069CC70
	private void OnDisableGameplayActionCategory(DisableGameplayActionCategoryMessage inMessage); // 0x000000018069C740-0x000000018069C940
	private void OnDisableUIActionCategory(DisableUIActionCategoryMessage inMessage); // 0x000000018069C940-0x000000018069CA60
	private void OnInputEvent(InputActionEventData inInputActionEventData); // 0x000000018069CA60-0x000000018069CB20
	public void RegisterAction(int inActionId, Action inAction); // 0x000000018069CB20-0x000000018069CC30
	public void UnregisterAction(int inActionId, Action inAction); // 0x000000018069D100-0x000000018069D190
	public Vector2 GetMoveVector(); // 0x000000018069C3C0-0x000000018069C4C0
	public Vector2 GetRotationVector(); // 0x000000018069C4C0-0x000000018069C540
	public void SetMouseAxisRotationMapping(bool isMapping); // 0x000000018069CC70-0x000000018069CFA0
	public void SetSelectedGameObject(GameObject inGameObject); // 0x000000018069CFA0-0x000000018069D010
	public List<GameObject> GetCurrentScrollCandidates(); // 0x000000018069C070-0x000000018069C3C0
	public List<GameObject> GetCurrentClickCandidates(); // 0x000000018069BD20-0x000000018069C070
	private new void Update(); // 0x000000018069D190-0x000000018069D360
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnDisableGameplayActionCategory>b__26_0(); // 0x000000018069D010-0x000000018069D060
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnDisableGameplayActionCategory>b__26_1(); // 0x000000018069D060-0x000000018069D0B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnDisableUIActionCategory>b__27_0(); // 0x000000018069D0B0-0x000000018069D100
}

