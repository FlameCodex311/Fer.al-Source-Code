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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RuntimeCreatedCutscene : Cutscene // TypeDefIndex: 11877
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _freeLookCameraHUD; // 0xE0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _freeLookCameraParametersDisplay; // 0xE8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _moveSpeedText; // 0xF0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _mouseSpeedText; // 0xF8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _scrollSpeedText; // 0x100
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _fieldOfViewText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _smoothingFramesText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _mouseWheelText; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _positionText; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _rotationText; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _fpsText; // 0x130
	private const float _secondsBetweenKeyPresses = 0.75f; // Metadata: 0x007B930F
	private readonly List<Vector3> _previousTranslations; // 0x138
	private readonly List<Vector2> _previousMousePositions; // 0x140
	private readonly List<float> _previousScrollWheelValues; // 0x148
	private readonly KeyCode[] _jklCode; // 0x150
	private readonly KeyCode[] _konamiCode; // 0x158
	private bool _isCutsceneSystemActive; // 0x160
	private bool _isDisplayingHUD; // 0x161
	private bool _isDisplayingParameters; // 0x162
	private int _jklCodeIndex; // 0x164
	private int _konamiCodeIndex; // 0x168
	private int _fpsTextUpdateFrameCount; // 0x16C
	private float? _lastKeyUpTime; // 0x170
	private float _speedMultiplier; // 0x178
	private float _cameraTranslationSpeed; // 0x17C
	private float _cameraRotationSpeed; // 0x180
	private float _scrollWheelSensativity; // 0x184
	private float _smoothingFramesCount; // 0x188
	private float _fieldOfView; // 0x18C
	private Vector2 _cameraEulerRotation; // 0x190

	// Properties
	private CinematicManager CinematicManager { get; } // 0x00000001807407A0-0x0000000180740840 
	private bool IsUsingEitherCode { get; } // 0x0000000180740840-0x0000000180740860 
	private bool IsUsingJKLCode { get; } // 0x0000000180740860-0x0000000180740880 
	private bool IsUsingKonamiCode { get; } // 0x0000000180740880-0x00000001807408B0 
	public override bool IsPlayable { get; } // 0x000000018073E8B0-0x000000018073E9E0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Play>d__43 : IEnumerator<object> // TypeDefIndex: 11878
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public RuntimeCreatedCutscene <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Play>d__43(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001807494C0-0x0000000180749770
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180749770-0x00000001807497C0
	}

	// Constructors
	public RuntimeCreatedCutscene(); // 0x0000000180740690-0x00000001807407A0

	// Methods
	private void Update(); // 0x0000000180740670-0x0000000180740690
	protected override void PrePlay(); // 0x000000018073F800-0x000000018073F880
	[IteratorStateMachine] // 0x00000001801D6A60-0x00000001801D6AB0
	protected override IEnumerator Play(); // 0x000000018073F6A0-0x000000018073F700
	protected override void PostPlay(); // 0x000000018073F700-0x000000018073F800
	private void UpdateControlSettings(); // 0x000000018073FCF0-0x0000000180740270
	private void UpdateParametersDisplay(); // 0x0000000180740270-0x0000000180740670
	private void ResetStates(); // 0x000000018073F8A0-0x000000018073FB60
	private void ToggleHUDVisibility(); // 0x000000018073FC20-0x000000018073FC90
	private void SetHUDVisibility(bool isVisible); // 0x000000018073FB60-0x000000018073FBC0
	private void ToggleParametersVisibility(); // 0x000000018073FC90-0x000000018073FCF0
	private void SetParametersVisibility(bool isVisible); // 0x000000018073FBC0-0x000000018073FC20
	private void CheckForParameterChanges(KeyCode increaseKey, KeyCode decreaseKey, ref float parameter, float valueMagnitude, float lowerBound, float upperBound); // 0x000000018073E7D0-0x000000018073E8B0
	private void CheckForActivationKeyCodes(); // 0x000000018073E510-0x000000018073E7D0
	private KeyCode[] GetNonActivationKeysDown(); // 0x000000018073F2B0-0x000000018073F580
	private bool IsBadActivationKey(KeyCode keyCode); // 0x000000018073F5E0-0x000000018073F6A0
	private void ResetActivationKeys(); // 0x000000018073F880-0x000000018073F8A0
	private Vector3 GetCameraTranslationVector(); // 0x000000018073EDC0-0x000000018073F250
	private Vector3 GetCameraRotationVector(); // 0x000000018073E9E0-0x000000018073EDC0
	private bool CheckUserEmailSubdomain(); // 0x000000018073E8B0-0x000000018073E9E0
	private string GetWildWorksSubdomain(); // 0x000000018073F580-0x000000018073F5E0
	private string GetHammerCreativeSubdomain(); // 0x000000018073F250-0x000000018073F2B0
}

