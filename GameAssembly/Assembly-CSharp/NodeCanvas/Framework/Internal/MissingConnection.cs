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
	[DoNotList] // 0x00000001800B36B0-0x00000001800B36C0
	public sealed class MissingConnection : Connection, IMissingRecoverable // TypeDefIndex: 14620
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _missingType; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _recoveryState; // 0x30
	
		// Properties
		string IMissingRecoverable.missingType { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		string IMissingRecoverable.recoveryState { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
		// Constructors
		public MissingConnection(); // 0x000000018174C600-0x000000018174C610
	}
}
