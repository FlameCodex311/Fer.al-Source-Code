/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	public class MissingBBParameterType : BBParameter<object>, IMissingRecoverable // TypeDefIndex: 14663
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _missingType; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _recoveryState; // 0x50
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		string IMissingRecoverable.recoveryState { get; set; } // 0x00000001803A27A0-0x00000001803A27B0 0x00000001803A2850-0x00000001803A2860
	
		// Constructors
		public MissingBBParameterType(); // 0x0000000181759E30-0x0000000181759E70
	}
}
