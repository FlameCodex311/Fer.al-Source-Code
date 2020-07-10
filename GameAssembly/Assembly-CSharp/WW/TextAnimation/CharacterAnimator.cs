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
	public abstract class CharacterAnimator : ScriptableObject, ICharacterAnimator // TypeDefIndex: 15841
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _id; // 0x18
	
		// Properties
		public string Id { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		protected CharacterAnimator(); // 0x0000000181119630-0x0000000181119670
	
		// Methods
		protected abstract void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength);
		public void UpdateAnimation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength); // 0x00000001811194D0-0x0000000181119630
	}
}
