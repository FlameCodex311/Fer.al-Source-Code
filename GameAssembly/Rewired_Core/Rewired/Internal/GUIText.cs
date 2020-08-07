/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Internal
{
	[AddComponentMenu] // 0x00000001801D60C0-0x00000001801D6120
	[Browsable] // 0x00000001801D60C0-0x00000001801D6120
	[EditorBrowsable] // 0x00000001801D60C0-0x00000001801D6120
	public class GUIText : UnityEngine.MonoBehaviour // TypeDefIndex: 5950
	{
		// Fields
		private string YzelLklqQyBWyeZpelflpymZWoR; // 0x18
		private GUIStyle drUyndMYGDaoxcprJgqquvgbTTJ; // 0x20
		private TextAnchor BLDQREeeQIdwNUHLCbMtdFzECkbl; // 0x28
		private TextAlignment CdQDHOhMgJvAcZcRadOkWENZCtkK; // 0x2C
		private float QPcppVhVCjKjRBIvNIPDJtJhRvF; // 0x30
		private Font QpGwYYyTdfQXtYsBDqjJpErQUKy; // 0x38
		private int sEVlINNAyoXtetENkfNAdZlAYvPm; // 0x40
		private FontStyle eItCfxoSxfBXRfFmoaVUDYnRFci; // 0x44
		private Color iyHSeEsLpIATafsDoDRFpPOvQOf; // 0x48
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private Vector2 _pixelOffset; // 0x58
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private bool _useUnityUI; // 0x60
		private bool ePSrWgmYQcBYGBrbGsVVfFIFTJD; // 0x61
		private bool NCggVpdDNSPHhfdgMlSXalteSfet; // 0x62
		private bool NIDeVsfDjqNrCKFepeBMbCGCzCuP; // 0x63
		private bool xdditwFbBPDUuLDmHtjZvgNXpoSW; // 0x64
		private bool rXdkmYUmSeeLwHZHFQtvzpnZmtB; // 0x65
		private bool tuPILTICDUiLGghGWDqfGgSVHMp; // 0x66
		private bool xgnJTOqLJxFKaIvuwgzhcBekbgTW; // 0x67
		private UnityEngine.UI.Text FbfCTVGMgfpXqUPzXtvEljfioUd; // 0x68
		private bool DTsNkpVcjRPmwHaebVldRoVXaqIB; // 0x70
		private bool ubUgauIreOqdzIukDqyfJIvfgivj; // 0x71
	
		// Properties
		public string text { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public TextAnchor anchor { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018099CAA0-0x000000018099CB00
		public TextAlignment alignment { get; set; } // 0x000000018043C670-0x000000018043C680 0x000000018099CA80-0x000000018099CAA0
		public float lineSpacing { get; set; } // 0x00000001806757B0-0x00000001806757C0 0x000000018099CC40-0x000000018099CC50
		public Font font { get; set; } // 0x00000001803743D0-0x00000001803743E0 0x000000018099CBD0-0x000000018099CC40
		public int fontSize { get; set; } // 0x0000000180379F10-0x0000000180379F20 0x000000018099CB50-0x000000018099CBB0
		public FontStyle fontStyle { get; set; } // 0x00000001804ADA70-0x00000001804ADA80 0x000000018099CBB0-0x000000018099CBD0
		public Color color { get; set; } // 0x000000018099C970-0x000000018099C980 0x000000018099CB00-0x000000018099CB50
		public Vector2 pixelOffset { get; set; } // 0x000000018099C980-0x000000018099C9A0 0x00000001803A1740-0x00000001803A1750
		public bool useUnityUI { get; set; } // 0x00000001803CE080-0x00000001803CE090 0x000000018099CC50-0x000000018099CCC0
	
		// Constructors
		public GUIText(); // 0x000000018099C930-0x000000018099C970
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Awake(); // 0x000000018099BDF0-0x000000018099BE00
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Start(); // 0x000000018099C460-0x000000018099C480
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnGUI(); // 0x000000018099C0D0-0x000000018099C3D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Update(); // 0x000000018099C480-0x000000018099C630
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnValidate(); // 0x000000018099C3D0-0x000000018099C460
		private void wZYIMNtbczspopwrOvnscfHqcww(); // 0x000000018099CCC0-0x000000018099D510
		private void jPqZRjrXsvsnuQfDTchRceYsZvJ(); // 0x000000018099C9A0-0x000000018099CA80
		private void ZTtpoMiQcmxXfTThckMAdbvPBfw(); // 0x000000018099C630-0x000000018099C930
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static GUIText GetOrAddComponent(GameObject gameObject); // 0x000000018099BFC0-0x000000018099C0D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal static GUIText CreateLogger(GameObject gameObject); // 0x000000018099BE00-0x000000018099BFC0
	}
}
