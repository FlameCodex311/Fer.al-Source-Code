/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	public class UILineRenderer : MaskableGraphic // TypeDefIndex: 9598
	{
		// Fields
		private const float MIN_MITER_JOIN = 0.2617994f; // Metadata: 0x00745249
		private const float MIN_BEVEL_NICE_JOIN = 0.5235988f; // Metadata: 0x0074524D
		private static readonly Vector2 UV_TOP_LEFT; // 0x00
		private static readonly Vector2 UV_BOTTOM_LEFT; // 0x08
		private static readonly Vector2 UV_TOP_CENTER; // 0x10
		private static readonly Vector2 UV_BOTTOM_CENTER; // 0x18
		private static readonly Vector2 UV_TOP_RIGHT; // 0x20
		private static readonly Vector2 UV_BOTTOM_RIGHT; // 0x28
		private static readonly Vector2[] startUvs; // 0x30
		private static readonly Vector2[] middleUvs; // 0x38
		private static readonly Vector2[] endUvs; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture m_Texture; // 0xC8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Rect m_UVRect; // 0xD0
		public float LineThickness; // 0xE0
		public bool UseMargins; // 0xE4
		public Vector2 Margin; // 0xE8
		public Vector2[] Points; // 0xF0
		public bool relativeSize; // 0xF8
		public bool LineList; // 0xF9
		public bool LineCaps; // 0xFA
		public JoinType LineJoins; // 0xFC
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action OnPopulateCallback; // 0x100
	
		// Properties
		public override Texture mainTexture { get; } // 0x000000018165D630-0x000000018165D6E0 
		public Texture texture { get; set; } // 0x00000001804A2590-0x00000001804A25A0 0x000000018165D790-0x000000018165D840
		public Rect uvRect { get; set; } // 0x000000018165D6E0-0x000000018165D6F0 0x000000018165D840-0x000000018165D8B0
	
		// Events
		public event Action OnPopulateCallback {
			add; // 0x000000018165D590-0x000000018165D630
			remove; // 0x000000018165D6F0-0x000000018165D790
		}
	
		// Nested types
		private enum SegmentType // TypeDefIndex: 9599
		{
			Start = 0,
			Middle = 1,
			End = 2
		}
	
		public enum JoinType // TypeDefIndex: 9600
		{
			Bevel = 0,
			Miter = 1
		}
	
		// Constructors
		public UILineRenderer(); // 0x000000018165D530-0x000000018165D590
		static UILineRenderer(); // 0x000000018165CFD0-0x000000018165D530
	
		// Methods
		protected override void OnPopulateMesh(VertexHelper vh); // 0x000000018165BAD0-0x000000018165CD50
		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, SegmentType type); // 0x000000018165B610-0x000000018165B7D0
		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, SegmentType type); // 0x000000018165B7D0-0x000000018165BAD0
		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs); // 0x000000018165CD50-0x000000018165CFD0
	}
}
