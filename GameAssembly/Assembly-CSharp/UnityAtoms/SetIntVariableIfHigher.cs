﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace UnityAtoms
{
	[CreateAssetMenu] // 0x00000001801539F0-0x0000000180153A60
	[EditorIcon] // 0x00000001801539F0-0x0000000180153A60
	public class SetIntVariableIfHigher : VoidAction // TypeDefIndex: 15655
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private IntVariable _currentIntVariable; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private IntVariable _highestIntVariable; // 0x38
	
		// Constructors
		public SetIntVariableIfHigher(); // 0x0000000180F769E0-0x0000000180F769F0
	
		// Methods
		public override void Do(); // 0x0000000180F77070-0x0000000180F77120
	}
}
