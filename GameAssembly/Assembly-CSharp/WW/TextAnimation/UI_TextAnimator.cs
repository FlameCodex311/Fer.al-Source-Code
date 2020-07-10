/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.TextAnimation
{
	[ExecuteAlways] // 0x00000001800B36B0-0x00000001800B36C0
	public class UI_TextAnimator : MonoBehaviour // TypeDefIndex: 15851
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private WWTextMeshProUGUI _text; // 0x20
		[Range] // 0x00000001800DC820-0x00000001800DC860
		[SerializeField] // 0x00000001800DC820-0x00000001800DC860
		private float _animationStrength; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CharacterAnimatorCollection _animatorCollection; // 0x30
		[SerializeField] // 0x0000000180171E80-0x0000000180171ED0
		[Tooltip] // 0x0000000180171E80-0x0000000180171ED0
		private List<CharacterAnimator> _globalAnimators; // 0x38
		private Vector3[] _originalPositions; // 0x40
		private Dictionary<string, ICharacterAnimator> _animatorById; // 0x48
		private List<ICharacterAnimator>[] _animatorByCharacterIndex; // 0x50
		private string _textLastFrame; // 0x58
		private UI_Window_Dialog _dialogWindow; // 0x60
	
		// Properties
		public float AnimationStrength { get; set; } // 0x0000000180487D50-0x0000000180487D60 0x000000018112D5E0-0x000000018112D650
		private float VisibleCharacters { get; } // 0x000000018112D520-0x000000018112D5E0 
	
		// Constructors
		public UI_TextAnimator(); // 0x000000018112D480-0x000000018112D520
	
		// Methods
		private void Awake(); // 0x000000018112C730-0x000000018112C9B0
		private void Update(); // 0x000000018112C9B0-0x000000018112D480
	}
}
