/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RuntimeCreatedCutscene : Cutscene // TypeDefIndex: 10386
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _freeLookCameraHUD; // 0xE0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _freeLookCameraParametersDisplay; // 0xE8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _moveSpeedText; // 0xF0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _mouseSpeedText; // 0xF8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _scrollSpeedText; // 0x100
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _fieldOfViewText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _smoothingFramesText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _mouseWheelText; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _positionText; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _rotationText; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _fpsText; // 0x130
	private const float _secondsBetweenKeyPresses = 0.75f; // Metadata: 0x00781C64
	private readonly List<Vector3> _previousTranslations; // 0x138
	private readonly List<Vector2> _previousMousePositions; // 0x140
	private readonly List<float> _previousScrollWheelValues; // 0x148
	private readonly List<KeyCode> _keysUp; // 0x150
	private readonly KeyCode[] _jklCode; // 0x158
	private readonly KeyCode[] _konamiCode; // 0x160
	private bool _isCutsceneSystemActive; // 0x168
	private bool _isDisplayingHUD; // 0x169
	private bool _isDisplayingParameters; // 0x16A
	private int _jklCodeIndex; // 0x16C
	private int _konamiCodeIndex; // 0x170
	private int _fpsTextUpdateFrameCount; // 0x174
	private float? _lastKeyUpTime; // 0x178
	private float _speedMultiplier; // 0x180
	private float _cameraTranslationSpeed; // 0x184
	private float _cameraRotationSpeed; // 0x188
	private float _scrollWheelSensativity; // 0x18C
	private float _smoothingFramesCount; // 0x190
	private float _fieldOfView; // 0x194
	private Vector2 _cameraEulerRotation; // 0x198

	// Properties
	private CinematicManager CinematicManager { get; } // 0x0000000180E0E8B0-0x0000000180E0E950 
	private bool IsUsingEitherCode { get; } // 0x0000000180E0E950-0x0000000180E0E970 
	private bool IsUsingJKLCode { get; } // 0x0000000180E0E970-0x0000000180E0E990 
	private bool IsUsingKonamiCode { get; } // 0x0000000180E0E990-0x0000000180E0E9C0 
	public override bool IsPlayable { get; } // 0x0000000180E0CB40-0x0000000180E0CC70 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Play>d__45 : IEnumerator<object> // TypeDefIndex: 10387
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RuntimeCreatedCutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Play>d__45(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180E3B420-0x0000000180E3B6E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180E3B6E0-0x0000000180E3B730
	}

	// Constructors
	public RuntimeCreatedCutscene(); // 0x0000000180E0E780-0x0000000180E0E8B0

	// Methods
	private void Update(); // 0x0000000180E0E720-0x0000000180E0E780
	private void OnGUI(); // 0x0000000180E0D5C0-0x0000000180E0D650
	protected override void PrePlay(); // 0x0000000180E0D820-0x0000000180E0D910
	[IteratorStateMachine] // 0x0000000180105D50-0x0000000180105DA0
	protected override IEnumerator Play(); // 0x0000000180E0D650-0x0000000180E0D6B0
	protected override void PostPlay(); // 0x0000000180E0D6B0-0x0000000180E0D820
	private void UpdateControlSettings(); // 0x0000000180E0DD90-0x0000000180E0E310
	private void UpdateParametersDisplay(); // 0x0000000180E0E310-0x0000000180E0E720
	private void ResetStates(); // 0x0000000180E0D930-0x0000000180E0DC00
	private void ToggleHUDVisibility(); // 0x0000000180E0DCC0-0x0000000180E0DD30
	private void SetHUDVisibility(bool isVisible); // 0x0000000180E0DC00-0x0000000180E0DC60
	private void ToggleParametersVisibility(); // 0x0000000180E0DD30-0x0000000180E0DD90
	private void SetParametersVisibility(bool isVisible); // 0x0000000180E0DC60-0x0000000180E0DCC0
	private void CheckForParameterChanges(KeyCode increaseKey, KeyCode decreaseKey, ref float parameter, float valueMagnitude, float lowerBound, float upperBound); // 0x0000000180E0CA60-0x0000000180E0CB40
	private void CheckForActivationKeyCodes(); // 0x0000000180E0C690-0x0000000180E0CA60
	private void ResetActivationKeys(); // 0x0000000180E0D910-0x0000000180E0D930
	private Vector3 GetCameraTranslationVector(); // 0x0000000180E0D060-0x0000000180E0D500
	private Vector3 GetCameraRotationVector(); // 0x0000000180E0CC70-0x0000000180E0D060
	private bool CheckUserEmailSubdomain(); // 0x0000000180E0CB40-0x0000000180E0CC70
	private string GetWildWorksSubdomain(); // 0x0000000180E0D560-0x0000000180E0D5C0
	private string GetHammerCreativeSubdomain(); // 0x0000000180E0D500-0x0000000180E0D560
}

