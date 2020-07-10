/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Description] // 0x000000018016C5A0-0x000000018016C5E0
	[DoNotList] // 0x000000018016C5A0-0x000000018016C5E0
	public class MissingAction : ActionTask, IMissingRecoverable // TypeDefIndex: 14655
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _missingType; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _recoveryState; // 0x70
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180358970-0x0000000180358980 0x00000001803A27D0-0x00000001803A27E0
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		protected override string info { get; } // 0x0000000181759D80-0x0000000181759E30 
	
		// Constructors
		public MissingAction(); // 0x0000000180E87F80-0x0000000180E87F90
	}
}
