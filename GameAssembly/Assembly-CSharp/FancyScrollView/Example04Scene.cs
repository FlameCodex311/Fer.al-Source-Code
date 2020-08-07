/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public class Example04Scene : MonoBehaviour // TypeDefIndex: 14317
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Example04ScrollView scrollView; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button prevCellButton; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Button nextCellButton; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text selectedItemInfo; // 0x38
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14318
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<int, Example04CellDto> <>9__4_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180E3AD10-0x0000000180E3AD70
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Example04CellDto <Start>b__4_0(int i); // 0x0000000180E3A840-0x0000000180E3A8D0
		}
	
		// Constructors
		public Example04Scene(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		private void Start(); // 0x0000000180E20E30-0x0000000180E210D0
		private void HandleSelectedIndexChanged(int index); // 0x0000000180E20DA0-0x0000000180E20E30
	}
}
