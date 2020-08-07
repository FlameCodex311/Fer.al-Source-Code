/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BBMappingParameter : BBObjectParameter // TypeDefIndex: 15783
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _targetSubGraphVariableID; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _canRead; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _canWrite; // 0x69
	
		// Properties
		public string targetSubGraphVariableID { get; } // 0x0000000180418970-0x0000000180418980 
		public bool canRead { get; set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
		public bool canWrite { get; set; } // 0x0000000180CBEEF0-0x0000000180CBEF00 0x00000001808612B0-0x00000001808612C0
	
		// Constructors
		public BBMappingParameter(); // 0x0000000180CBEEE0-0x0000000180CBEEF0
		public BBMappingParameter(Variable subVariable); // 0x0000000180CBEE80-0x0000000180CBEEE0
	}
}
