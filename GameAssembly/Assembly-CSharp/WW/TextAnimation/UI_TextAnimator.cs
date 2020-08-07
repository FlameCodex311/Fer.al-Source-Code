/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.TextAnimation
{
	[ExecuteAlways] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class UI_TextAnimator : MonoBehaviour // TypeDefIndex: 16231
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private WWTextMeshProUGUI _text; // 0x20
		[Range] // 0x000000018020DDA0-0x000000018020DDE0
		[SerializeField] // 0x000000018020DDA0-0x000000018020DDE0
		private float _animationStrength; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CharacterAnimatorCollection _animatorCollection; // 0x30
		[SerializeField] // 0x0000000180294AB0-0x0000000180294B00
		[Tooltip] // 0x0000000180294AB0-0x0000000180294B00
		private List<CharacterAnimator> _globalAnimators; // 0x38
		private Vector3[] _originalPositions; // 0x40
		private Dictionary<string, ICharacterAnimator> _animatorById; // 0x48
		private List<ICharacterAnimator>[] _animatorByCharacterIndex; // 0x50
		private string _textLastFrame; // 0x58
		private UI_Window_Dialog _dialogWindow; // 0x60
	
		// Properties
		public float AnimationStrength { get; set; } // 0x0000000180491DA0-0x0000000180491DB0 0x000000018097D0A0-0x000000018097D110
		private float VisibleCharacters { get; } // 0x000000018097CFE0-0x000000018097D0A0 
	
		// Constructors
		public UI_TextAnimator(); // 0x000000018097CF40-0x000000018097CFE0
	
		// Methods
		private void Awake(); // 0x000000018097C250-0x000000018097C4C0
		private void Update(); // 0x000000018097C4C0-0x000000018097CF40
	}
}
