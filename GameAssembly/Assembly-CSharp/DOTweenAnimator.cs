/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DOTweenAnimator : MonoBehaviour // TypeDefIndex: 13383
{
	// Fields
	public bool autoPlay; // 0x20
	public AnimationType animationType; // 0x24
	public float duration; // 0x28
	public float delay; // 0x2C
	[Tooltip] // 0x0000000180133180-0x00000001801331B0
	public Ease easeType; // 0x30
	public AnimationCurve customEaseCurve; // 0x38
	[Tooltip] // 0x00000001801333D0-0x0000000180133400
	public int loops; // 0x40
	public LoopType loopType; // 0x44
	public bool ignoreTimeScale; // 0x48
	[Tooltip] // 0x0000000180133730-0x0000000180133760
	public string ID; // 0x50
	public bool relative; // 0x58
	[Tooltip] // 0x0000000180133870-0x00000001801338A0
	public bool autokill; // 0x59
	public bool from; // 0x5A
	public bool giveStartValue; // 0x5B
	public bool setToStartValueOnCreate; // 0x5C
	public Vector3 vec3Value; // 0x60
	public Vector3 vec3ValueStart; // 0x6C
	public Transform moveToTarget; // 0x78
	public float floatValue; // 0x80
	public float floatValueStart; // 0x84
	public Color colorValue; // 0x88
	public Color colorValueStart; // 0x98
	public ColorTarget fadeTarget; // 0xA8
	public ColorTarget colorTarget; // 0xAC
	public bool extraUseSharedMaterial; // 0xB0
	public string extraPropertyName; // 0xB8
	public bool snapping; // 0xC0
	public RotateMode rotateMode; // 0xC4
	public bool local; // 0xC8
	public UnityEvent OnPlayCallback; // 0xD0
	public UnityEvent OnStartCallback; // 0xD8
	public UnityEvent OnUpdateCallback; // 0xE0
	public UnityEvent OnCompleteCallback; // 0xE8
	public UnityEvent OnStepCallback; // 0xF0
	private Tweener _tweener; // 0xF8

	// Nested types
	public enum AnimationType // TypeDefIndex: 13384
	{
		Move = 0,
		Scale = 1,
		Rotate = 2,
		Alpha_Auto = 3,
		Color_Auto = 4,
		MoveToTransform = 5,
		Alpha_Manual = 6,
		MoveAnchoredPosition = 7,
		SizeDelta = 8,
		TextureOffset = 9,
		Color_Manual = 10
	}

	public enum ColorTarget // TypeDefIndex: 13385
	{
		None = 0,
		NGUI = 1,
		Mesh = 2,
		UnitySprite = 3,
		UnityImage = 4,
		UnityText = 5,
		CanvasGroup = 6
	}

	// Constructors
	public DOTweenAnimator(); // 0x0000000180F466C0-0x0000000180F466F0

	// Methods
	private void OnEnable(); // 0x0000000180F46420-0x0000000180F46460
	private void OnDisable(); // 0x0000000180F463D0-0x0000000180F46420
	private void OnDestroy(); // 0x0000000180F463B0-0x0000000180F463D0
	public void PlayTweenForward(); // 0x0000000180F464E0-0x0000000180F46560
	public void PlayTweenBackward(); // 0x0000000180F46460-0x0000000180F464E0
	public void PlayTween(bool inReversed = false /* Metadata: 0x00783BFC */, bool inRestart = true /* Metadata: 0x00783BFD */); // 0x0000000180F46560-0x0000000180F46610
	[ContextMenu] // 0x0000000180133A20-0x0000000180133A50
	public void CreateTween(); // 0x0000000180F45BE0-0x0000000180F463B0
	private Tweener CreateMoveTween(bool inLocal); // 0x0000000180F453D0-0x0000000180F45530
	private Tweener CreateMoveToTargetTween(); // 0x0000000180F451E0-0x0000000180F453D0
	private Tweener CreateMoveAnchoredPositionTween(); // 0x0000000180F45090-0x0000000180F451E0
	private Tweener CreateSizeDeltaTween(); // 0x0000000180F457C0-0x0000000180F459D0
	private Tweener CreateScaleTween(); // 0x0000000180F45680-0x0000000180F457C0
	private Tweener CreateRotateTween(bool inLocal); // 0x0000000180F45530-0x0000000180F45680
	private Tweener CreateAlphaTween(bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x0000000180F442C0-0x0000000180F44B10
	private Tweener CreateColorTween(bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x0000000180F44B10-0x0000000180F45090
	private Tweener CreateTextureOffsetTween(bool inUseSharedMaterial); // 0x0000000180F459D0-0x0000000180F45BE0
	private T ApplyTweenSettings<T>(T inTarget)
		where T : Tweener;
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <CreateMoveToTargetTween>b__45_0(); // 0x0000000180F46610-0x0000000180F466C0
}

