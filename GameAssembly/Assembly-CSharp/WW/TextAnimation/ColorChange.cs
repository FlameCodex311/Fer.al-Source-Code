/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.TextAnimation
{
	[CreateAssetMenu] // 0x000000018028EF20-0x000000018028EF60
	public class ColorChange : CharacterAnimator // TypeDefIndex: 16223
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Gradient _gradient; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _offsetByVertPosition; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _offset; // 0x34
	
		// Constructors
		public ColorChange(); // 0x0000000180967F90-0x0000000180967FE0
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x0000000180967A00-0x0000000180967F90
	}
}
