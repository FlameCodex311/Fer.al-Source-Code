/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	public class Triangulator // TypeDefIndex: 9103
	{
		// Fields
		private List<Vector2> m_points; // 0x10
	
		// Properties
		public List<Vector2> Points { get; } // 0x0000000180372440-0x0000000180372450 
	
		// Constructors
		public Triangulator(Vector2[] points); // 0x000000018208B330-0x000000018208B3D0
		public Triangulator(Vector2[] points, bool invertY = true /* Metadata: 0x00778B01 */); // 0x000000018208B3D0-0x000000018208B530
	
		// Methods
		public int[] Triangulate(); // 0x000000018208AE60-0x000000018208B330
		private float Area(); // 0x000000018208A950-0x000000018208AAA0
		private bool Snip(int u, int v, int w, int n, int[] V); // 0x000000018208AB80-0x000000018208AE60
		private bool InsideTriangle(Vector2 pt, Vector2 v1, Vector2 v2, Vector2 v3); // 0x000000018208AAA0-0x000000018208AB80
	}
}
