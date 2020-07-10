/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[CreateAssetMenu] // 0x00000001801355B0-0x00000001801355F0
public class TweenData : ScriptableObject // TypeDefIndex: 13388
{
	// Fields
	public bool autoPlay; // 0x18
	public AnimationType animationType; // 0x1C
	public float duration; // 0x20
	public float delay; // 0x24
	[Tooltip] // 0x0000000180133180-0x00000001801331B0
	public Ease easeType; // 0x28
	public AnimationCurve customEaseCurve; // 0x30
	[Tooltip] // 0x00000001801333D0-0x0000000180133400
	public int loops; // 0x38
	public LoopType loopType; // 0x3C
	public bool ignoreTimeScale; // 0x40
	public bool relative; // 0x41
	[Tooltip] // 0x0000000180133870-0x00000001801338A0
	public bool autokill; // 0x42
	public bool from; // 0x43
	public bool giveStartValue; // 0x44
	public bool setToStartValueOnCreate; // 0x45
	public Vector3 vec3Value; // 0x48
	public Vector3 vec3ValueStart; // 0x54
	public float floatValue; // 0x60
	public float floatValueStart; // 0x64
	public Color colorValue; // 0x68
	public Color colorValueStart; // 0x78
	public bool extraUseSharedMaterial; // 0x88
	public string extraPropertyName; // 0x90
	public bool snapping; // 0x98
	public RotateMode rotateMode; // 0x9C
	public bool local; // 0xA0

	// Nested types
	public enum AnimationType // TypeDefIndex: 13389
	{
		Move = 0,
		Scale = 1,
		Rotate = 2,
		Alpha_Auto = 3,
		Color_Auto = 4,
		MoveToTransform = 5,
		Alpha_Manual = 6,
		MoveAnchoredPosition = 7
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 13390
	{
		// Fields
		public TweenTarget inTarget; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <CreateMoveToTargetTween>b__0(); // 0x0000000180FB2430-0x0000000180FB24E0
	}

	// Constructors
	public TweenData(); // 0x0000000180FAB410-0x0000000180FAB440

	// Methods
	public Tweener CreateTween(TweenTarget inTarget); // 0x0000000180FAAE50-0x0000000180FAB410
	private Tweener CreateMoveTween(TweenTarget inTarget, bool inLocal); // 0x0000000180FAAA50-0x0000000180FAABC0
	private Tweener CreateMoveToTargetTween(TweenTarget inTarget); // 0x0000000180FAA810-0x0000000180FAAA50
	private Tweener CreateMoveAnchoredPositionTween(TweenTarget inTarget); // 0x0000000180FAA6B0-0x0000000180FAA810
	private Tweener CreateScaleTween(TweenTarget inTarget); // 0x0000000180FAAD10-0x0000000180FAAE50
	private Tweener CreateRotateTween(TweenTarget inTarget, bool inLocal); // 0x0000000180FAABC0-0x0000000180FAAD10
	private Tweener CreateAlphaTween(TweenTarget inTarget, bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x0000000180FA99E0-0x0000000180FAA240
	private Tweener CreateColorTween(TweenTarget inTarget); // 0x0000000180FAA240-0x0000000180FAA6B0
	private T ApplyTweenSettings<T>(TweenTarget inTarget, T inTweener)
		where T : Tweener;
}

