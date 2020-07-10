/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 8815
	{
		// Constructors
		protected TMP_InputValidator(); // 0x00000001803A2BB0-0x00000001803A2BC0
	
		// Methods
		public abstract char Validate(ref string text, ref int pos, char ch);
	}
}
