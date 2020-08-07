/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_InspirationThoughtBubble : MonoBehaviour // TypeDefIndex: 13901
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _rotationSpeed; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _rotationPivot; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<CanvasGroup> _inspirationGroups; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<RawImage> _inspirationIcons; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _enigmaIcon; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _sucessFX; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _failureFX; // 0x50
	private EnigmaDefComponent _enigma; // 0x58
	private List<ThoughtBubbleItem> _thoughtBubbleItems; // 0x60

	// Nested types
	private class ThoughtBubbleItem // TypeDefIndex: 13902
	{
		// Fields
		private RawImage _iconImage; // 0x10
		private CanvasGroup _group; // 0x18
		public InspirationItemComponent inspiration; // 0x20

		// Properties
		public RawImage IconImage { get; } // 0x0000000180372440-0x0000000180372450 
		public CanvasGroup Group { get; } // 0x0000000180372430-0x0000000180372440 
		public bool IsFull { get; } // 0x0000000180372450-0x0000000180372AA0 

		// Constructors
		public ThoughtBubbleItem(RawImage iconImage, CanvasGroup inGroup); // 0x0000000180372320-0x0000000180372430

		// Methods
		public void AddInspiration(InspirationItemComponent inInspiration); // 0x0000000180372130-0x0000000180372270
		public void RemoveInspiration(); // 0x0000000180372270-0x0000000180372320
	}

	// Constructors
	public UI_InspirationThoughtBubble(); // 0x000000018037B0A0-0x000000018037B150

	// Methods
	private void Start(); // 0x000000018037AD70-0x000000018037B020
	private void Update(); // 0x000000018037B020-0x000000018037B0A0
	public void BtnClicked_ThoughtBubbleItem(int inIndex); // 0x000000018037A120-0x000000018037A250
	public void AddInspiration(InspirationItemComponent inInspiration); // 0x0000000180379F50-0x000000018037A120
	public void RemoveInspiration(InspirationItemComponent inInspiration); // 0x000000018037AB00-0x000000018037AC40
	public void SetEnigma(EnigmaDefComponent inEnigma); // 0x000000018037AC40-0x000000018037AD70
	public float DoCombination(bool inSuccess); // 0x000000018037A250-0x000000018037A7F0
	private bool InspirationAlreadyAdded(InspirationItemComponent inInspiration); // 0x000000018037A970-0x000000018037AB00
	private ThoughtBubbleItem GetNextThoughtBubbleItem(); // 0x000000018037A7F0-0x000000018037A970
}

