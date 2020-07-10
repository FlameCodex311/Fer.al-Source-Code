/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x000000018012D810-0x000000018012D860
public class UI_CornerNoise : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 12290
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Polygon _polygon; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _moveScale; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _speedScale; // 0x30
	private Vector2 _currentMoveScale; // 0x34
	private Vector2 _cornerAStart; // 0x3C
	private Vector2 _cornerBStart; // 0x44
	private Vector2 _cornerCStart; // 0x4C
	private Vector2 _cornerDStart; // 0x54

	// Constructors
	public UI_CornerNoise(); // 0x0000000180F2E9B0-0x0000000180F2EA50

	// Methods
	public void OnPointerEnter(PointerEventData eventData); // 0x0000000180F2E110-0x0000000180F2E200
	public void OnPointerExit(PointerEventData eventData); // 0x0000000180F2E200-0x0000000180F2E300
	private void OnEnable(); // 0x0000000180F2DE90-0x0000000180F2E110
	private void Update(); // 0x0000000180F2E370-0x0000000180F2E9B0
	private void Reset(); // 0x0000000180F2E300-0x0000000180F2E340
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 <OnPointerEnter>b__8_0(); // 0x0000000180F2E340-0x0000000180F2E360
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnPointerEnter>b__8_1(Vector2 x); // 0x0000000180F2E360-0x0000000180F2E370
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 <OnPointerExit>b__9_0(); // 0x0000000180F2E340-0x0000000180F2E360
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnPointerExit>b__9_1(Vector2 x); // 0x0000000180F2E360-0x0000000180F2E370
}

