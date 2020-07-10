/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_InspirationThoughtBubble : MonoBehaviour // TypeDefIndex: 12317
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _rotationSpeed; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _rotationPivot; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<CanvasGroup> _inspirationGroups; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<RawImage> _inspirationIcons; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _enigmaIcon; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _sucessFX; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _failureFX; // 0x50
	private EnigmaDefComponent _enigma; // 0x58
	private List<ThoughtBubbleItem> _thoughtBubbleItems; // 0x60

	// Nested types
	private class ThoughtBubbleItem // TypeDefIndex: 12318
	{
		// Fields
		private RawImage _iconImage; // 0x10
		private CanvasGroup _group; // 0x18
		public InspirationItemComponent inspiration; // 0x20

		// Properties
		public RawImage IconImage { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CanvasGroup Group { get; } // 0x000000018038B150-0x000000018038B160 
		public bool IsFull { get; } // 0x0000000180713C80-0x0000000180713C90 

		// Constructors
		public ThoughtBubbleItem(RawImage iconImage, CanvasGroup inGroup); // 0x0000000180E3D0E0-0x0000000180E3D870

		// Methods
		public void AddInspiration(InspirationItemComponent inInspiration); // 0x0000000180E3CEF0-0x0000000180E3D030
		public void RemoveInspiration(); // 0x0000000180E3D030-0x0000000180E3D0E0
	}

	// Constructors
	public UI_InspirationThoughtBubble(); // 0x0000000180E43860-0x0000000180E43910

	// Methods
	private void Start(); // 0x0000000180E43520-0x0000000180E437E0
	private void Update(); // 0x0000000180E437E0-0x0000000180E43860
	public void BtnClicked_ThoughtBubbleItem(int inIndex); // 0x0000000180E428B0-0x0000000180E429F0
	public void AddInspiration(InspirationItemComponent inInspiration); // 0x0000000180E426E0-0x0000000180E428B0
	public void RemoveInspiration(InspirationItemComponent inInspiration); // 0x0000000180E432B0-0x0000000180E433F0
	public void SetEnigma(EnigmaDefComponent inEnigma); // 0x0000000180E433F0-0x0000000180E43520
	public float DoCombination(bool inSuccess); // 0x0000000180E429F0-0x0000000180E42FA0
	private bool InspirationAlreadyAdded(InspirationItemComponent inInspiration); // 0x0000000180E43120-0x0000000180E432B0
	private ThoughtBubbleItem GetNextThoughtBubbleItem(); // 0x0000000180E42FA0-0x0000000180E43120
}

