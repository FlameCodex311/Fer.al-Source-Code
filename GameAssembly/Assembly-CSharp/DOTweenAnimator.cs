/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DOTweenAnimator : MonoBehaviour // TypeDefIndex: 11053
{
	// Fields
	public bool autoPlay; // 0x20
	public AnimationType animationType; // 0x24
	public float duration; // 0x28
	public float delay; // 0x2C
	[Tooltip] // 0x00000001802153E0-0x0000000180215410
	public Ease easeType; // 0x30
	public AnimationCurve customEaseCurve; // 0x38
	[Tooltip] // 0x0000000180215590-0x00000001802155C0
	public int loops; // 0x40
	public LoopType loopType; // 0x44
	public bool ignoreTimeScale; // 0x48
	[Tooltip] // 0x0000000180215730-0x0000000180215760
	public string ID; // 0x50
	public bool relative; // 0x58
	[Tooltip] // 0x0000000180215970-0x00000001802159A0
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
	public enum AnimationType // TypeDefIndex: 11054
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

	public enum ColorTarget // TypeDefIndex: 11055
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
	public DOTweenAnimator(); // 0x0000000180559080-0x00000001805590B0

	// Methods
	private void OnEnable(); // 0x0000000180558DF0-0x0000000180558E30
	private void OnDisable(); // 0x0000000180558DA0-0x0000000180558DF0
	private void OnDestroy(); // 0x0000000180558D80-0x0000000180558DA0
	public void PlayTweenForward(); // 0x0000000180558EB0-0x0000000180558F30
	public void PlayTweenBackward(); // 0x0000000180558E30-0x0000000180558EB0
	public void PlayTween(bool inReversed = false /* Metadata: 0x0077C6B7 */, bool inRestart = true /* Metadata: 0x0077C6B8 */); // 0x0000000180558F30-0x0000000180558FE0
	[ContextMenu] // 0x0000000180215B60-0x0000000180215B90
	public void CreateTween(); // 0x0000000180558430-0x0000000180558D80
	private Tweener CreateMoveTween(bool inLocal); // 0x0000000180557C40-0x0000000180557DA0
	private Tweener CreateMoveToTargetTween(); // 0x0000000180557A50-0x0000000180557C40
	private Tweener CreateMoveAnchoredPositionTween(); // 0x0000000180557900-0x0000000180557A50
	private Tweener CreateSizeDeltaTween(); // 0x0000000180558020-0x0000000180558230
	private Tweener CreateScaleTween(); // 0x0000000180557EE0-0x0000000180558020
	private Tweener CreateRotateTween(bool inLocal); // 0x0000000180557DA0-0x0000000180557EE0
	private Tweener CreateAlphaTween(bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x0000000180556B70-0x00000001805573A0
	private Tweener CreateColorTween(bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x00000001805573A0-0x0000000180557900
	private Tweener CreateTextureOffsetTween(bool inUseSharedMaterial); // 0x0000000180558230-0x0000000180558430
	private T ApplyTweenSettings<T>(T inTarget)
		where T : Tweener;
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <CreateMoveToTargetTween>b__45_0(); // 0x0000000180558FE0-0x0000000180559080
}

