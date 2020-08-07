/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	[AddComponentMenu] // 0x000000018023D0B0-0x000000018023D110
	[EditorIcon] // 0x000000018023D0B0-0x000000018023D110
	public sealed class AtomListener : BaseAtomListener, IAtomListener // TypeDefIndex: 7824
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AtomEvent _event; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UnityEvent _unityEventResponse; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<AtomAction> _actionResponses; // 0x30
	
		// Properties
		public AtomEvent Event { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
		// Constructors
		public AtomListener(); // 0x0000000182065D20-0x0000000182065D80
	
		// Methods
		private void OnEnable(); // 0x0000000182065B30-0x0000000182065C60
		private void OnDisable(); // 0x0000000182065A00-0x0000000182065B30
		public void OnEventRaised(); // 0x0000000182065C60-0x0000000182065D20
	}
}
