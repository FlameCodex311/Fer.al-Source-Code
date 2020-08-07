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

public class TweenTarget : MonoBehaviour // TypeDefIndex: 11061
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private TweenData _tweenData; // 0x20
	[Tooltip] // 0x0000000180215730-0x0000000180215760
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
	public Tweener Tweener { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Nested types
	public enum ColorTarget // TypeDefIndex: 11062
	{
		None = 0,
		Mesh = 1,
		UnitySprite = 2,
		UnityImage = 3,
		UnityText = 4,
		CanvasGroup = 5
	}

	// Constructors
	public TweenTarget(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void OnEnable(); // 0x00000001805109A0-0x0000000180510B20
	private void OnDisable(); // 0x0000000180510950-0x00000001805109A0
	private void OnDestroy(); // 0x0000000180510910-0x0000000180510950
	public void PlayTweenForward(); // 0x0000000180510B30-0x0000000180510B40
	public void PlayTweenBackward(); // 0x0000000180510B20-0x0000000180510B30
	public void PlayTween(bool inReversed = false /* Metadata: 0x0077C72A */); // 0x0000000180510B40-0x0000000180510C70
	[ContextMenu] // 0x0000000180215B60-0x0000000180215B90
	public void CreateTween(); // 0x0000000180510880-0x0000000180510910
	private T AddTweenCallbacks<T>(T inTarget)
		where T : Tweener;
}

