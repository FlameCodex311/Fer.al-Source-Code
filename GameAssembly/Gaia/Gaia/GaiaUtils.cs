/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class GaiaUtils : UnityEngine.MonoBehaviour // TypeDefIndex: 9251
	{
		// Constructors
		public GaiaUtils(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		public static string GetGaiaAssetDirectory(); // 0x000000018198F300-0x000000018198F3C0
		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType); // 0x000000018198F3C0-0x000000018198F4E0
		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType); // 0x000000018198F750-0x000000018198F7D0
		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x000000018198F4E0-0x000000018198F580
		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x000000018198F5E0-0x000000018198F690
		public static string GetGaiaStampPath(Texture2D source); // 0x000000018198F690-0x000000018198F750
		public static bool CheckValidGaiaStampPath(Texture2D source); // 0x000000018198D4D0-0x000000018198D600
		public static void CreateGaiaAssetDirectories(); // 0x00000001803774A0-0x00000001803774B0
		public static T[] GetAtPath<T>(string path);
		public static void CreateAsset<T>()
			where T : ScriptableObject;
		public static string GetAssetPath(UnityEngine.Object uo); // 0x000000018198F090-0x000000018198F0C0
		public static string WrapScriptableObject(ScriptableObject so); // 0x00000001819900A0-0x00000001819900D0
		public static void UnwrapScriptableObject(string path, string newpath); // 0x00000001803774A0-0x00000001803774B0
		public static string WrapGameObjectAsPrefab(GameObject go); // 0x0000000181990070-0x00000001819900A0
		public static string GetAssetPath(string fileName); // 0x000000018198F060-0x000000018198F090
		public static string GetAssetPath(string name, string type); // 0x000000018198F030-0x000000018198F060
		public static UnityEngine.Object GetAsset(string fileNameOrPath, Type assetType); // 0x000000018037DDC0-0x000000018037DDD0
		public static GameObject GetAssetPrefab(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static ScriptableObject GetAssetScriptableObject(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static Texture2D GetAssetTexture2D(string name); // 0x000000018037DDC0-0x000000018037DDD0
		public static void MakeTextureNormal(Texture2D texture); // 0x000000018198FB00-0x000000018198FB60
		public static void MakeTextureReadable(Texture2D texture); // 0x000000018198FB60-0x000000018198FBC0
		public static void MakeTextureUncompressed(Texture2D texture); // 0x000000018198FBC0-0x000000018198FC20
		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F1C */, bool exportPNG = true /* Metadata: 0x00778F20 */, bool exportJPG = true /* Metadata: 0x00778F21 */); // 0x000000018198DEA0-0x000000018198E0F0
		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F22 */, bool exportPNG = true /* Metadata: 0x00778F26 */, bool exportJPG = true /* Metadata: 0x00778F27 */); // 0x000000018198DB10-0x000000018198DEA0
		public static void CompressToMultiChannelFileImage(string imageName, HeightMap r, HeightMap g, HeightMap b, HeightMap a, TextureFormat imageStorageFormat, GaiaConstants.ImageFileType imageFileType); // 0x000000018198D600-0x000000018198DB10
		public static float[,] ConvertTextureToArray(Texture2D texture); // 0x000000018198E0F0-0x000000018198E250
		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00778F28 */, bool channelR = true /* Metadata: 0x00778F2C */, bool channelG = false /* Metadata: 0x00778F2D */, bool channelB = false /* Metadata: 0x00778F2E */, bool channelA = false /* Metadata: 0x00778F2F */); // 0x000000018198E9C0-0x000000018198EB70
		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true /* Metadata: 0x00778F30 */, bool channelG = false /* Metadata: 0x00778F31 */, bool channelB = false /* Metadata: 0x00778F32 */, bool channelA = false /* Metadata: 0x00778F33 */); // 0x000000018198EB70-0x000000018198EF50
		public static void ExportJPG(string fileName, Texture2D texture); // 0x000000018198EF50-0x000000018198EFC0
		public static void ExportPNG(string fileName, Texture2D texture); // 0x000000018198EFC0-0x000000018198F030
		public static float[,] LoadRawFile(string fileName); // 0x000000018198F7D0-0x000000018198FB00
		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize); // 0x000000018198E250-0x000000018198E9C0
		public static Bounds GetBounds(GameObject go); // 0x000000018198F0C0-0x000000018198F300
		private Vector3 Rotate90LeftXAxis(Vector3 input); // 0x0000000181702EB0-0x0000000181702F00
		private Vector3 Rotate90RightXAxis(Vector3 input); // 0x0000000181702FA0-0x0000000181702FF0
		private Vector3 Rotate90LeftYAxis(Vector3 input); // 0x0000000181702F00-0x0000000181702F50
		private Vector3 Rotate90RightYAxis(Vector3 input); // 0x0000000181702FF0-0x0000000181703040
		private Vector3 Rotate90LeftZAxis(Vector3 input); // 0x0000000181702F50-0x0000000181702FA0
		private Vector3 Rotate90RightZAxis(Vector3 input); // 0x0000000181703040-0x0000000181703090
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x000000018198FCB0-0x000000018198FD40
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x000000018198FC20-0x000000018198FCB0
		public static bool Math_IsPowerOf2(int value); // 0x00000001817023E0-0x00000001817023F0
		public static float Math_Clamp(float min, float max, float value); // 0x0000000181702150-0x0000000181702170
		public static float Math_Modulo(float value, float mod); // 0x000000018198FE80-0x000000018198FF00
		public static int Math_Modulo(int value, int mod); // 0x000000018198FDE0-0x000000018198FE80
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x0000000181702310-0x0000000181702330
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x0000000181702370-0x00000001817023E0
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x000000018198FD40-0x000000018198FDE0
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x0000000181702330-0x0000000181702370
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x00000001817022B0-0x0000000181702310
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x000000018198FF00-0x0000000181990070
		public static GaiaSettings GetGaiaSettings(); // 0x000000018198F580-0x000000018198F5E0
	}
}
