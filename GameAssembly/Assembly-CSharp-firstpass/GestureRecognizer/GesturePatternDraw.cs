/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	public class GesturePatternDraw : UILineRenderer // TypeDefIndex: 10039
	{
		// Fields
		public GesturePattern pattern; // 0x108
		public float endingSize; // 0x110
	
		// Constructors
		public GesturePatternDraw(); // 0x0000000180D263D0-0x0000000180D26470
	
		// Methods
		private void OnValidate(); // 0x0000000180D26330-0x0000000180D263D0
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180D26300-0x0000000180D26330
		public void DrawPattern(); // 0x0000000180D25D00-0x0000000180D26300
	}
}
