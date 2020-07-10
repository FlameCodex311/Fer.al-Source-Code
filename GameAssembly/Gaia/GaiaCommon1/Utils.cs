/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace GaiaCommon1
{
	public class Utils : UnityEngine.MonoBehaviour // TypeDefIndex: 8989
	{
		// Constructors
		public Utils(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		public static string FixFileName(string sourceFileName); // 0x0000000181C0AB40-0x0000000181C0AC30
		public static FileStream OpenRead(string path); // 0x0000000181C0D4A0-0x0000000181C0D510
		public static string ReadAllText(string path); // 0x0000000181C0DB30-0x0000000181C0DCD0
		public static void WriteAllText(string path, string contents); // 0x0000000181C0E4A0-0x0000000181C0E690
		public static byte[] ReadAllBytes(string path); // 0x0000000181C0D750-0x0000000181C0D990
		public static void WriteAllBytes(string path, byte[] bytes); // 0x0000000181C0E1B0-0x0000000181C0E2B0
		public static string GetEditorScriptsPath(AppConfig appConfig); // 0x0000000181C0B620-0x0000000181C0B650
		public static string GetAppsSubfolder(string appFolder, string subfolderPath); // 0x0000000181C0AE20-0x0000000181C0B340
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x0000000181C0CF00-0x0000000181C0CF90
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x0000000181C0CE70-0x0000000181C0CF00
		public static bool Math_IsPowerOf2(int value); // 0x000000018159C000-0x000000018159C010
		public static float Math_Clamp(float min, float max, float value); // 0x000000018159BE10-0x000000018159BE30
		public static float Math_Modulo(float value, float mod); // 0x0000000181C0D1F0-0x0000000181C0D270
		public static int Math_Modulo(int value, int mod); // 0x0000000181C0D310-0x0000000181C0D3B0
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x000000018159BF30-0x000000018159BF50
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x000000018159BF90-0x000000018159C000
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x0000000181C0D150-0x0000000181C0D1F0
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x000000018159BF50-0x000000018159BF90
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x000000018159BED0-0x000000018159BF30
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x0000000181C0DCD0-0x0000000181C0DE40
		public static int GetFrapoch(); // 0x0000000181C0B650-0x0000000181C0B700
		public static int TimeToFrapoch(DateTime time); // 0x0000000181C0DFB0-0x0000000181C0E050
		public static DateTime FrapochToLocalDate(int seconds); // 0x0000000181C0AD20-0x0000000181C0ADA0
		public static DateTime FrapochToLocalDate(double seconds); // 0x0000000181C0ADA0-0x0000000181C0AE20
		public static bool IsInLayerMask(GameObject obj, LayerMask mask); // 0x0000000181C0C390-0x0000000181C0C3F0
		public static bool IsSameTexture(Texture2D tex1, Texture2D tex2, bool checkID = false /* Metadata: 0x00743F87 */); // 0x0000000181C0C690-0x0000000181C0C850
		public static bool IsSameGameObject(GameObject go1, GameObject go2, bool checkID = false /* Metadata: 0x00743F88 */); // 0x0000000181C0C540-0x0000000181C0C690
		public static Type GetType(string TypeName); // 0x0000000181C0BFB0-0x0000000181C0C390
	}
}
