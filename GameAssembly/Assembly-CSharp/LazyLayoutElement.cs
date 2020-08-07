/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class LazyLayoutElement // TypeDefIndex: 13634
{
	// Fields
	public RectTransform rectTransform; // 0x10
	public LazyLayoutInfo layoutInfo; // 0x18
	public bool allowAnimation; // 0x20
	public bool snapNextPos; // 0x21
	public bool snapNextSize; // 0x22
	private Vector2 _currentPos; // 0x24
	public Vector2 targetPos; // 0x2C
	private Vector2 _animatedCurrentPos; // 0x34
	private Vector2 _currentSize; // 0x3C
	public Vector2 targetSize; // 0x44
	private Vector2 _animatedCurrentSize; // 0x4C
	private Tweener _posTween; // 0x58
	private Tweener _sizeTween; // 0x60
	public bool isActive; // 0x68
	public bool isVisible; // 0x69

	// Properties
	public Vector2 CurrentPos { get; } // 0x000000018087BD00-0x000000018087BD20 
	public Vector2 CurrentSize { get; } // 0x000000018087BD20-0x000000018087BD40 

	// Constructors
	public LazyLayoutElement(); // 0x000000018087B9C0-0x000000018087B9E0
	public LazyLayoutElement(RectTransform inTransform); // 0x000000018087B9E0-0x000000018087BD00

	// Methods
	public virtual void UpdateElement(); // 0x000000018087B280-0x000000018087B9C0
	private void OnTweenUpdate(); // 0x000000018087AEA0-0x000000018087AF60
	public void SetActive(bool inActive); // 0x000000018087AF60-0x000000018087B030
	public void SetTransform(Transform inTransform); // 0x000000018087B120-0x000000018087B250
	public void SetTransform(RectTransform inTransform); // 0x000000018087B030-0x000000018087B120
	public float GetPreferredSize(int inAxis); // 0x000000018087ADF0-0x000000018087AEA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 <UpdateElement>b__21_0(); // 0x000000018054BAF0-0x000000018054BB10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <UpdateElement>b__21_1(Vector2 pos); // 0x000000018054BB10-0x000000018054BB20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 <UpdateElement>b__21_2(); // 0x000000018087B250-0x000000018087B270
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <UpdateElement>b__21_3(Vector2 size); // 0x000000018087B270-0x000000018087B280
}

