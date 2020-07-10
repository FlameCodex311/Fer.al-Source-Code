/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class LazyLayoutElement // TypeDefIndex: 12088
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
	public Vector2 CurrentPos { get; } // 0x00000001812CCA50-0x00000001812CCA70 
	public Vector2 CurrentSize { get; } // 0x00000001812CCA70-0x00000001812CCA90 

	// Constructors
	public LazyLayoutElement(); // 0x00000001812CC700-0x00000001812CC720
	public LazyLayoutElement(RectTransform inTransform); // 0x00000001812CC720-0x00000001812CCA50

	// Methods
	public virtual void UpdateElement(); // 0x00000001812CBFC0-0x00000001812CC700
	private void OnTweenUpdate(); // 0x00000001812CBBF0-0x00000001812CBCB0
	public void SetActive(bool inActive); // 0x00000001812CBCB0-0x00000001812CBD80
	public void SetTransform(Transform inTransform); // 0x00000001812CBE70-0x00000001812CBFA0
	public void SetTransform(RectTransform inTransform); // 0x00000001812CBD80-0x00000001812CBE70
	public float GetPreferredSize(int inAxis); // 0x00000001812CBB40-0x00000001812CBBF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 <UpdateElement>b__21_0(); // 0x0000000180F2E340-0x0000000180F2E360
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <UpdateElement>b__21_1(Vector2 pos); // 0x0000000180F2E360-0x0000000180F2E370
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 <UpdateElement>b__21_2(); // 0x00000001812CBFA0-0x00000001812CBFC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <UpdateElement>b__21_3(Vector2 size); // 0x0000000180CC6540-0x0000000180CC6550
}

