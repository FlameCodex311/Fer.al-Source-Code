/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_HarvestNotificationPrompt : MonoBehaviour // TypeDefIndex: 12313
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _scaleGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _numberText; // 0x28
	private Vector3 _targetWorldPosition; // 0x30

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 12314
	{
		// Fields
		public float totalScale; // 0x10
		public UI_HarvestNotificationPrompt <>4__this; // 0x18
		public float yScale; // 0x20

		// Constructors
		public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal float <Show>b__0(); // 0x0000000180493360-0x0000000180493370
		internal void <Show>b__1(float x); // 0x0000000180BD7F10-0x0000000180BD7F20
		internal void <Show>b__2(); // 0x0000000180E3EAB0-0x0000000180E3EAE0
		internal float <Show>b__3(); // 0x0000000180487DA0-0x0000000180487DB0
		internal void <Show>b__4(float y); // 0x00000001805D9090-0x00000001805D90A0
		internal void <Show>b__5(); // 0x0000000180E3EAB0-0x0000000180E3EAE0
		internal void <Show>b__6(); // 0x0000000180E3EAE0-0x0000000180E3EB20
	}

	// Constructors
	public UI_HarvestNotificationPrompt(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180E41780-0x0000000180E41840
	private void OnDestroy(); // 0x0000000180E41280-0x0000000180E41310
	private void Update(); // 0x0000000180E41840-0x0000000180E419E0
	private void OnInteractableHarvested(InteractableHarvestedMessage inMessage); // 0x0000000180E41310-0x0000000180E41380
	private void Show(Vector3 inTargetWorldPosition, int inQuantity); // 0x0000000180E41380-0x0000000180E41780
	private void DoStretchSquash(float inTotalScale, float inYScale); // 0x0000000180E41180-0x0000000180E41280
}

