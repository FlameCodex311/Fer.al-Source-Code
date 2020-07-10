/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.TextAnimation
{
	[CreateAssetMenu] // 0x000000018016BF00-0x000000018016BF40
	public class ColorChange : CharacterAnimator // TypeDefIndex: 15843
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _speedScale; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Gradient _gradient; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _offsetByVertPosition; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _offset; // 0x34
	
		// Constructors
		public ColorChange(); // 0x0000000181119C20-0x0000000181119C70
	
		// Methods
		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x0000000181119670-0x0000000181119C20
	}
}
