/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace UnityAtoms
{
	[CreateAssetMenu] // 0x00000001802186E0-0x0000000180218750
	[EditorIcon] // 0x00000001802186E0-0x0000000180218750
	public class SetIntVariableIfHigher : VoidAction // TypeDefIndex: 16375
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IntVariable _currentIntVariable; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IntVariable _highestIntVariable; // 0x38
	
		// Constructors
		public SetIntVariableIfHigher(); // 0x0000000180442950-0x0000000180442960
	
		// Methods
		public override void Do(); // 0x0000000180442FF0-0x00000001804430A0
	}
}
