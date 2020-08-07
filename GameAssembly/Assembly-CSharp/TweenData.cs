/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[CreateAssetMenu] // 0x0000000180216870-0x00000001802168B0
public class TweenData : ScriptableObject // TypeDefIndex: 11058
{
	// Fields
	public bool autoPlay; // 0x18
	public AnimationType animationType; // 0x1C
	public float duration; // 0x20
	public float delay; // 0x24
	[Tooltip] // 0x00000001802153E0-0x0000000180215410
	public Ease easeType; // 0x28
	public AnimationCurve customEaseCurve; // 0x30
	[Tooltip] // 0x0000000180215590-0x00000001802155C0
	public int loops; // 0x38
	public LoopType loopType; // 0x3C
	public bool ignoreTimeScale; // 0x40
	public bool relative; // 0x41
	[Tooltip] // 0x0000000180215970-0x00000001802159A0
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
	public enum AnimationType // TypeDefIndex: 11059
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

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 11060
	{
		// Fields
		public TweenTarget inTarget; // 0x10

		// Constructors
		public <>c__DisplayClass28_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <CreateMoveToTargetTween>b__0(); // 0x0000000180517420-0x00000001805174C0
	}

	// Constructors
	public TweenData(); // 0x0000000180510850-0x0000000180510880

	// Methods
	public Tweener CreateTween(TweenTarget inTarget); // 0x00000001805102B0-0x0000000180510850
	private Tweener CreateMoveTween(TweenTarget inTarget, bool inLocal); // 0x000000018050FEC0-0x0000000180510020
	private Tweener CreateMoveToTargetTween(TweenTarget inTarget); // 0x000000018050FC90-0x000000018050FEC0
	private Tweener CreateMoveAnchoredPositionTween(TweenTarget inTarget); // 0x000000018050FB30-0x000000018050FC90
	private Tweener CreateScaleTween(TweenTarget inTarget); // 0x0000000180510170-0x00000001805102B0
	private Tweener CreateRotateTween(TweenTarget inTarget, bool inLocal); // 0x0000000180510020-0x0000000180510170
	private Tweener CreateAlphaTween(TweenTarget inTarget, bool inUseSharedMaterial, string inCustomPropertyName = null); // 0x000000018050EEA0-0x000000018050F6E0
	private Tweener CreateColorTween(TweenTarget inTarget); // 0x000000018050F6E0-0x000000018050FB30
	private T ApplyTweenSettings<T>(TweenTarget inTarget, T inTweener)
		where T : Tweener;
}

