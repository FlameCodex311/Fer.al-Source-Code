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

public class TweenTarget : MonoBehaviour // TypeDefIndex: 13391
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private TweenData _tweenData; // 0x20
	[Tooltip] // 0x0000000180133730-0x0000000180133760
	public string ID; // 0x28
	public ColorTarget fadeTarget; // 0x30
	public ColorTarget colorTarget; // 0x34
	public Transform moveToTarget; // 0x38
	public UnityEvent OnPlayCallback; // 0x40
	public UnityEvent OnStartCallback; // 0x48
	public UnityEvent OnUpdateCallback; // 0x50
	public UnityEvent OnCompleteCallback; // 0x58
	public UnityEvent OnStepCallback; // 0x60
	private Tweener _tweener; // 0x68

	// Properties
	public Tweener Tweener { get; } // 0x0000000180358970-0x0000000180358980 

	// Nested types
	public enum ColorTarget // TypeDefIndex: 13392
	{
		None = 0,
		Mesh = 1,
		UnitySprite = 2,
		UnityImage = 3,
		UnityText = 4,
		CanvasGroup = 5
	}

	// Constructors
	public TweenTarget(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void OnEnable(); // 0x0000000180FAB560-0x0000000180FAB6E0
	private void OnDisable(); // 0x0000000180FAB510-0x0000000180FAB560
	private void OnDestroy(); // 0x0000000180FAB4D0-0x0000000180FAB510
	public void PlayTweenForward(); // 0x0000000180FAB6F0-0x0000000180FAB700
	public void PlayTweenBackward(); // 0x0000000180FAB6E0-0x0000000180FAB6F0
	public void PlayTween(bool inReversed = false /* Metadata: 0x00783C6F */); // 0x0000000180FAB700-0x0000000180FAB830
	[ContextMenu] // 0x0000000180133A20-0x0000000180133A50
	public void CreateTween(); // 0x0000000180FAB440-0x0000000180FAB4D0
	private T AddTweenCallbacks<T>(T inTarget)
		where T : Tweener;
}

