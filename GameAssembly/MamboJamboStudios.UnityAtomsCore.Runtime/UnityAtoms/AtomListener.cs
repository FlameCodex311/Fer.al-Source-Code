/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 63: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7577-7750

namespace UnityAtoms
{
	[AddComponentMenu] // 0x00000001800DB750-0x00000001800DB7B0
	[EditorIcon] // 0x00000001800DB750-0x00000001800DB7B0
	public sealed class AtomListener : BaseAtomListener, IAtomListener // TypeDefIndex: 7658
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AtomEvent _event; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public UnityEvent _unityEventResponse; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<AtomAction> _actionResponses; // 0x30
	
		// Properties
		public AtomEvent Event { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
		// Constructors
		public AtomListener(); // 0x00000001822A0540-0x00000001822A05A0
	
		// Methods
		private void OnEnable(); // 0x00000001822A0340-0x00000001822A0480
		private void OnDisable(); // 0x00000001822A0200-0x00000001822A0340
		public void OnEventRaised(); // 0x00000001822A0480-0x00000001822A0540
	}
}
