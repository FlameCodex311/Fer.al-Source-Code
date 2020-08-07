/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace GaiaCommon1
{
	public class Utils : UnityEngine.MonoBehaviour // TypeDefIndex: 9155
	{
		// Constructors
		public Utils(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		public static string FixFileName(string sourceFileName); // 0x00000001816FFC70-0x00000001816FFD60
		public static FileStream OpenRead(string path); // 0x00000001817026A0-0x0000000181702710
		public static string ReadAllText(string path); // 0x0000000181702D10-0x0000000181702EB0
		public static void WriteAllText(string path, string contents); // 0x0000000181703850-0x0000000181703A30
		public static byte[] ReadAllBytes(string path); // 0x0000000181702940-0x0000000181702B70
		public static void WriteAllBytes(string path, byte[] bytes); // 0x0000000181703570-0x0000000181703670
		public static string GetEditorScriptsPath(AppConfig appConfig); // 0x0000000181700710-0x0000000181700740
		public static string GetAppsSubfolder(string appFolder, string subfolderPath); // 0x00000001816FFF50-0x0000000181700440
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x0000000181701FA0-0x0000000181702030
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x0000000181701F10-0x0000000181701FA0
		public static bool Math_IsPowerOf2(int value); // 0x00000001817023E0-0x00000001817023F0
		public static float Math_Clamp(float min, float max, float value); // 0x0000000181702150-0x0000000181702170
		public static float Math_Modulo(float value, float mod); // 0x00000001817023F0-0x0000000181702470
		public static int Math_Modulo(int value, int mod); // 0x0000000181702510-0x00000001817025B0
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x0000000181702310-0x0000000181702330
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x0000000181702370-0x00000001817023E0
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x0000000181702210-0x00000001817022B0
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x0000000181702330-0x0000000181702370
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x00000001817022B0-0x0000000181702310
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x0000000181703090-0x0000000181703200
		public static int GetFrapoch(); // 0x0000000181700740-0x00000001817007F0
		public static int TimeToFrapoch(DateTime time); // 0x0000000181703370-0x0000000181703410
		public static DateTime FrapochToLocalDate(int seconds); // 0x00000001816FFE50-0x00000001816FFED0
		public static DateTime FrapochToLocalDate(double seconds); // 0x00000001816FFED0-0x00000001816FFF50
		public static bool IsInLayerMask(GameObject obj, LayerMask mask); // 0x0000000181701460-0x00000001817014C0
		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false /* Metadata: 0x00778C75 */); // 0x0000000181701760-0x0000000181701910
		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false /* Metadata: 0x00778C76 */); // 0x0000000181701610-0x0000000181701760
		public static Type GetType(string TypeName); // 0x0000000181701090-0x0000000181701460
	}
}
