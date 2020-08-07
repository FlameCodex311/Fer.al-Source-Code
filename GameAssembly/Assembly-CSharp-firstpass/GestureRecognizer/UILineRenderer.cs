/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	public class UILineRenderer : MaskableGraphic // TypeDefIndex: 10052
	{
		// Fields
		private const float MIN_MITER_JOIN = 0.2617994f; // Metadata: 0x0077ACFB
		private const float MIN_BEVEL_NICE_JOIN = 0.5235988f; // Metadata: 0x0077ACFF
		private static readonly Vector2 UV_TOP_LEFT; // 0x00
		private static readonly Vector2 UV_BOTTOM_LEFT; // 0x08
		private static readonly Vector2 UV_TOP_CENTER; // 0x10
		private static readonly Vector2 UV_BOTTOM_CENTER; // 0x18
		private static readonly Vector2 UV_TOP_RIGHT; // 0x20
		private static readonly Vector2 UV_BOTTOM_RIGHT; // 0x28
		private static readonly Vector2[] startUvs; // 0x30
		private static readonly Vector2[] middleUvs; // 0x38
		private static readonly Vector2[] endUvs; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture m_Texture; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Rect m_UVRect; // 0xD0
		public float LineThickness; // 0xE0
		public bool UseMargins; // 0xE4
		public Vector2 Margin; // 0xE8
		public Vector2[] Points; // 0xF0
		public bool relativeSize; // 0xF8
		public bool LineList; // 0xF9
		public bool LineCaps; // 0xFA
		public JoinType LineJoins; // 0xFC
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action OnPopulateCallback; // 0x100
	
		// Properties
		public override Texture mainTexture { get; } // 0x0000000180D38AC0-0x0000000180D38B70 
		public Texture texture { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x0000000180D38C20-0x0000000180D38CD0
		public Rect uvRect { get; set; } // 0x0000000180D38B70-0x0000000180D38B80 0x0000000180D38CD0-0x0000000180D38D40
	
		// Events
		public event Action OnPopulateCallback {
			add; // 0x0000000180D38A20-0x0000000180D38AC0
			remove; // 0x0000000180D38B80-0x0000000180D38C20
		}
	
		// Nested types
		private enum SegmentType // TypeDefIndex: 10053
		{
			Start = 0,
			Middle = 1,
			End = 2
		}
	
		public enum JoinType // TypeDefIndex: 10054
		{
			Bevel = 0,
			Miter = 1
		}
	
		// Constructors
		public UILineRenderer(); // 0x0000000180D389C0-0x0000000180D38A20
		static UILineRenderer(); // 0x0000000180D38480-0x0000000180D389C0
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh); // 0x0000000180D37020-0x0000000180D38210
		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type); // 0x0000000180D36970-0x0000000180D36B30
		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type); // 0x0000000180D36B30-0x0000000180D37020
		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs); // 0x0000000180D38210-0x0000000180D38480
	}
}
