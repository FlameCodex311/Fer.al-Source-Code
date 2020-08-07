/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class DirectionalTriggerGate : MonoBehaviour, ITriggerGate // TypeDefIndex: 14588
	{
		// Fields
		[Range] // 0x000000018027D520-0x000000018027D580
		[SerializeField] // 0x000000018027D520-0x000000018027D580
		[Tooltip] // 0x000000018027D520-0x000000018027D580
		private float _angle; // 0x20
		[Range] // 0x000000018027D910-0x000000018027D970
		[SerializeField] // 0x000000018027D910-0x000000018027D970
		[Tooltip] // 0x000000018027D910-0x000000018027D970
		private float _angleSpan; // 0x24
		private bool _enteredFromValidDirection; // 0x28
		private Vector3 _validDirection; // 0x2C
	
		// Properties
		public bool IsActive { get; } // 0x00000001803F1920-0x00000001803F1950 
	
		// Constructors
		public DirectionalTriggerGate(); // 0x0000000180CB1860-0x0000000180CB1870
	
		// Methods
		private void Start(); // 0x0000000180CB1470-0x0000000180CB16C0
		public void TriggerWasEntered(Collider other); // 0x0000000180CB16C0-0x0000000180CB1860
		public bool IsTriggerBlocked(); // 0x00000001808A3530-0x00000001808A3540
	}
}
