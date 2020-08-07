/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180225D80-0x0000000180225DD0
public class UI_CornerNoise : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler // TypeDefIndex: 13874
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Polygon _polygon; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _moveScale; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _speedScale; // 0x30
	private Vector2 _currentMoveScale; // 0x34
	private Vector2 _cornerAStart; // 0x3C
	private Vector2 _cornerBStart; // 0x44
	private Vector2 _cornerCStart; // 0x4C
	private Vector2 _cornerDStart; // 0x54

	// Constructors
	public UI_CornerNoise(); // 0x000000018054C140-0x000000018054C1E0

	// Methods
	public void OnPointerEnter(PointerEventData eventData); // 0x000000018054B8C0-0x000000018054B9B0
	public void OnPointerExit(PointerEventData eventData); // 0x000000018054B9B0-0x000000018054BAB0
	private void OnEnable(); // 0x000000018054B680-0x000000018054B8C0
	private void Update(); // 0x000000018054BB20-0x000000018054C140
	private void Reset(); // 0x000000018054BAB0-0x000000018054BAF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 <OnPointerEnter>b__8_0(); // 0x000000018054BAF0-0x000000018054BB10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnPointerEnter>b__8_1(Vector2 x); // 0x000000018054BB10-0x000000018054BB20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 <OnPointerExit>b__9_0(); // 0x000000018054BAF0-0x000000018054BB10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnPointerExit>b__9_1(Vector2 x); // 0x000000018054BB10-0x000000018054BB20
}

