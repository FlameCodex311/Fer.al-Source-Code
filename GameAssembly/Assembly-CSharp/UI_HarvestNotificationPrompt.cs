/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_HarvestNotificationPrompt : MonoBehaviour // TypeDefIndex: 13897
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _scaleGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _numberText; // 0x28
	private Vector3 _targetWorldPosition; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 13898
	{
		// Fields
		public float totalScale; // 0x10
		public UI_HarvestNotificationPrompt <>4__this; // 0x18
		public float yScale; // 0x20

		// Constructors
		public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal float <Show>b__0(); // 0x0000000180373AA0-0x0000000180373AB0
		internal void <Show>b__1(float x); // 0x0000000180373AB0-0x0000000180373AC0
		internal void <Show>b__2(); // 0x0000000180373AC0-0x0000000180373AF0
		internal float <Show>b__3(); // 0x0000000180373AF0-0x0000000180373B00
		internal void <Show>b__4(float y); // 0x0000000180373B00-0x0000000180373B10
		internal void <Show>b__5(); // 0x0000000180373AC0-0x0000000180373AF0
		internal void <Show>b__6(); // 0x0000000180373B10-0x0000000180373B50
	}

	// Constructors
	public UI_HarvestNotificationPrompt(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180378F60-0x0000000180379010
	private void OnDestroy(); // 0x0000000180378A70-0x0000000180378B00
	private void Update(); // 0x0000000180379010-0x00000001803791B0
	private void OnInteractableHarvested(InteractableHarvestedMessage inMessage); // 0x0000000180378B00-0x0000000180378B70
	private void Show(Vector3 inTargetWorldPosition, int inQuantity); // 0x0000000180378B70-0x0000000180378F60
	private void DoStretchSquash(float inTotalScale, float inYScale); // 0x0000000180378970-0x0000000180378A70
}

