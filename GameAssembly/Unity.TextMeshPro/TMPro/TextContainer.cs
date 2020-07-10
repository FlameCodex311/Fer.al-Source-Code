/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[AddComponentMenu] // 0x000000018013F620-0x000000018013F6A0
	[RequireComponent] // 0x000000018013F620-0x000000018013F6A0
	public class TextContainer : UIBehaviour // TypeDefIndex: 8750
	{
		// Fields
		private bool m_hasChanged; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 m_pivot; // 0x1C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextContainerAnchors m_anchorPosition; // 0x24
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Rect m_rect; // 0x28
		private bool m_isDefaultWidth; // 0x38
		private bool m_isDefaultHeight; // 0x39
		private bool m_isAutoFitting; // 0x3A
		private Vector3[] m_corners; // 0x40
		private Vector3[] m_worldCorners; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector4 m_margins; // 0x50
		private RectTransform m_rectTransform; // 0x60
		private static Vector2 k_defaultSize; // 0x00
		private TextMeshPro m_textMeshPro; // 0x68
	
		// Properties
		public bool hasChanged { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public Vector2 pivot { get; set; } // 0x000000018188B710-0x000000018188B730 0x000000018188BB70-0x000000018188BC30
		public TextContainerAnchors anchorPosition { get; set; } // 0x00000001803C26F0-0x00000001803C2700 0x000000018188B8A0-0x000000018188B9F0
		public Rect rect { get; set; } // 0x000000018036CB50-0x000000018036CB60 0x000000018188BC30-0x000000018188BC90
		public Vector2 size { get; set; } // 0x000000018188B7B0-0x000000018188B810 0x000000018188BC90-0x000000018188BDC0
		public float width { get; set; } // 0x000000018188B890-0x000000018188B8A0 0x000000018188BDC0-0x000000018188BEA0
		public float height { get; set; } // 0x000000018188B700-0x000000018188B710 0x000000018188B9F0-0x000000018188BAD0
		public bool isDefaultWidth { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
		public bool isDefaultHeight { get; } // 0x00000001806EDE30-0x00000001806EDE40 
		public bool isAutoFitting { get; set; } // 0x00000001806EDE20-0x00000001806EDE30 0x00000001806EDE40-0x00000001806EDE50
		public Vector3[] corners { get; } // 0x0000000180369B30-0x0000000180369B40 
		public Vector3[] worldCorners { get; } // 0x0000000180369C40-0x0000000180369C50 
		public Vector4 margins { get; set; } // 0x00000001804A53C0-0x00000001804A53D0 0x000000018188BAD0-0x000000018188BB70
		public RectTransform rectTransform { get; } // 0x000000018188B730-0x000000018188B7B0 
		public TextMeshPro textMeshPro { get; } // 0x000000018188B810-0x000000018188B890 
	
		// Constructors
		public TextContainer(); // 0x000000018188B690-0x000000018188B700
		static TextContainer(); // 0x000000018188B620-0x000000018188B690
	
		// Methods
		protected override void Awake(); // 0x000000018188A7A0-0x000000018188A840
		protected override void OnEnable(); // 0x000000018188AE90-0x000000018188AEA0
		protected override void OnDisable(); // 0x00000001803581E0-0x00000001803581F0
		private void OnContainerChanged(); // 0x000000018188ACB0-0x000000018188AE90
		protected override void OnRectTransformDimensionsChange(); // 0x000000018188AEA0-0x000000018188B240
		private void SetRect(Vector2 size); // 0x000000018188B240-0x000000018188B2C0
		private void UpdateCorners(); // 0x000000018188B2C0-0x000000018188B620
		private Vector2 GetPivot(TextContainerAnchors anchor); // 0x000000018188AB90-0x000000018188ACB0
		private TextContainerAnchors GetAnchorPosition(Vector2 pivot); // 0x000000018188A840-0x000000018188AB90
	}
}
