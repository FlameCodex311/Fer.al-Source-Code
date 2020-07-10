/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia
{
	public class GaiaUtils : UnityEngine.MonoBehaviour // TypeDefIndex: 9085
	{
		// Constructors
		public GaiaUtils(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		public static string GetGaiaAssetDirectory(); // 0x000000018159B3C0-0x000000018159B480
		public static string GetGaiaAssetDirectory(GaiaConstants.FeatureType featureType); // 0x000000018159B480-0x000000018159B5A0
		public static List<string> GetGaiaStampsList(GaiaConstants.FeatureType featureType); // 0x000000018159B810-0x000000018159B890
		public static string GetGaiaAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x000000018159B5A0-0x000000018159B640
		public static string GetGaiaStampAssetPath(GaiaConstants.FeatureType featureType, string assetName); // 0x000000018159B6A0-0x000000018159B750
		public static string GetGaiaStampPath(Texture2D source); // 0x000000018159B750-0x000000018159B810
		public static bool CheckValidGaiaStampPath(Texture2D source); // 0x0000000181599520-0x0000000181599660
		public static void CreateGaiaAssetDirectories(); // 0x00000001803581E0-0x00000001803581F0
		public static T[] GetAtPath<T>(string path);
		public static void CreateAsset<T>()
			where T : ScriptableObject;
		public static string GetAssetPath(UnityEngine.Object uo); // 0x000000018159B140-0x000000018159B170
		public static string WrapScriptableObject(ScriptableObject so); // 0x000000018159C4B0-0x000000018159C4E0
		public static void UnwrapScriptableObject(string path, string newpath); // 0x00000001803581E0-0x00000001803581F0
		public static string WrapGameObjectAsPrefab(GameObject go); // 0x000000018159C480-0x000000018159C4B0
		public static string GetAssetPath(string fileName); // 0x000000018159B110-0x000000018159B140
		public static string GetAssetPath(string name, string type); // 0x000000018159B0E0-0x000000018159B110
		public static UnityEngine.Object GetAsset(string fileNameOrPath, Type assetType); // 0x000000018035FCC0-0x000000018035FCD0
		public static GameObject GetAssetPrefab(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static ScriptableObject GetAssetScriptableObject(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static Texture2D GetAssetTexture2D(string name); // 0x000000018035FCC0-0x000000018035FCD0
		public static void MakeTextureNormal(Texture2D texture); // 0x000000018159BBD0-0x000000018159BC30
		public static void MakeTextureReadable(Texture2D texture); // 0x000000018159BC30-0x000000018159BC90
		public static void MakeTextureUncompressed(Texture2D texture); // 0x000000018159BC90-0x000000018159BCF0
		public static void CompressToSingleChannelFileImage(float[,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x0074422E */, bool exportPNG = true /* Metadata: 0x00744232 */, bool exportJPG = true /* Metadata: 0x00744233 */); // 0x0000000181599F30-0x000000018159A150
		public static void CompressToMultiChannelFileImage(float[,,] input, string imageName, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x00744234 */, bool exportPNG = true /* Metadata: 0x00744238 */, bool exportJPG = true /* Metadata: 0x00744239 */); // 0x0000000181599B90-0x0000000181599F30
		public static void CompressToMultiChannelFileImage(string imageName, HeightMap r, HeightMap g, HeightMap b, HeightMap a, TextureFormat imageStorageFormat, GaiaConstants.ImageFileType imageFileType); // 0x0000000181599660-0x0000000181599B90
		public static float[,] ConvertTextureToArray(Texture2D texture); // 0x000000018159A150-0x000000018159A2B0
		public static float[,] DecompressFromSingleChannelFileImage(string fileName, int width, int height, TextureFormat imageStorageFormat = TextureFormat.RGBA32 /* Metadata: 0x0074423A */, bool channelR = true /* Metadata: 0x0074423E */, bool channelG = false /* Metadata: 0x0074423F */, bool channelB = false /* Metadata: 0x00744240 */, bool channelA = false /* Metadata: 0x00744241 */); // 0x000000018159AA50-0x000000018159AC10
		public static float[,] DecompressFromSingleChannelTexture(Texture2D importTexture, bool channelR = true /* Metadata: 0x00744242 */, bool channelG = false /* Metadata: 0x00744243 */, bool channelB = false /* Metadata: 0x00744244 */, bool channelA = false /* Metadata: 0x00744245 */); // 0x000000018159AC10-0x000000018159B000
		public static void ExportJPG(string fileName, Texture2D texture); // 0x000000018159B000-0x000000018159B070
		public static void ExportPNG(string fileName, Texture2D texture); // 0x000000018159B070-0x000000018159B0E0
		public static float[,] LoadRawFile(string fileName); // 0x000000018159B890-0x000000018159BBD0
		public static Mesh CreateMesh(float[,] heightmap, Vector3 targetSize); // 0x000000018159A2B0-0x000000018159AA50
		public static Bounds GetBounds(GameObject go); // 0x000000018159B170-0x000000018159B3C0
		private Vector3 Rotate90LeftXAxis(Vector3 input); // 0x000000018159C130-0x000000018159C180
		private Vector3 Rotate90RightXAxis(Vector3 input); // 0x000000018159C220-0x000000018159C270
		private Vector3 Rotate90LeftYAxis(Vector3 input); // 0x000000018159C180-0x000000018159C1D0
		private Vector3 Rotate90RightYAxis(Vector3 input); // 0x000000018159C270-0x000000018159C2C0
		private Vector3 Rotate90LeftZAxis(Vector3 input); // 0x000000018159C1D0-0x000000018159C220
		private Vector3 Rotate90RightZAxis(Vector3 input); // 0x000000018159C2C0-0x000000018159C310
		public static bool Math_ApproximatelyEqual(float a, float b, float threshold); // 0x000000018159BD80-0x000000018159BE10
		public static bool Math_ApproximatelyEqual(float a, float b); // 0x000000018159BCF0-0x000000018159BD80
		public static bool Math_IsPowerOf2(int value); // 0x000000018159C000-0x000000018159C010
		public static float Math_Clamp(float min, float max, float value); // 0x000000018159BE10-0x000000018159BE30
		public static float Math_Modulo(float value, float mod); // 0x000000018159C0B0-0x000000018159C130
		public static int Math_Modulo(int value, int mod); // 0x000000018159C010-0x000000018159C0B0
		public static float Math_InterpolateLinear(float value1, float value2, float fraction); // 0x000000018159BF30-0x000000018159BF50
		public static float Math_InterpolateSmooth(float value1, float value2, float fraction); // 0x000000018159BF90-0x000000018159C000
		public static float Math_Distance(float x1, float y1, float x2, float y2); // 0x000000018159BE30-0x000000018159BED0
		public static float Math_InterpolateSmooth2(float v1, float v2, float fraction); // 0x000000018159BF50-0x000000018159BF90
		public static float Math_InterpolateCubic(float v0, float v1, float v2, float v3, float fraction); // 0x000000018159BED0-0x000000018159BF30
		public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle); // 0x000000018159C310-0x000000018159C480
		public static GaiaSettings GetGaiaSettings(); // 0x000000018159B640-0x000000018159B6A0
	}
}
