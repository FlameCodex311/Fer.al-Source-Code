/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public class MathTools // TypeDefIndex: 7047
	{
		// Fields
		private const float QnVmxvXKuJqCnpwOBOGsPaYkCWH = 1E-10f; // Metadata: 0x00766772
		private const double tDpTUIISPRMwbUkicImjRmCQAKZ = 1E-10; // Metadata: 0x00766776
		private const float WIXrgWozlHOfDdkYJttJyYeHrnP = 0.0001f; // Metadata: 0x0076677E
		public const float PI = 3.1415927f; // Metadata: 0x00766782
		public const float Infinity = 1F / 0F; // Metadata: 0x00766786
		public const float NegativeInfinity = -1F / 0F; // Metadata: 0x0076678A
		public const float Deg2Rad = 0.017453292f; // Metadata: 0x0076678E
		public const float Rad2Deg = 57.29578f; // Metadata: 0x00766792
		public const float Epsilon = 1E-45f; // Metadata: 0x00766796
	
		// Constructors
		public MathTools(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static sbyte Abs(sbyte value); // 0x00000001813F0CC0-0x00000001813F0D50
		public static short Abs(short value); // 0x00000001813F0DF0-0x00000001813F0E80
		public static int Abs(int value); // 0x00000001813F0FA0-0x00000001813F1010
		public static long Abs(long value); // 0x00000001813F0D50-0x00000001813F0DF0
		public static float Abs(float value); // 0x00000001813F0E80-0x00000001813F0F10
		public static double Abs(double value); // 0x00000001813F0F10-0x00000001813F0FA0
		public static bool Approximately(float a, float b); // 0x00000001813F1250-0x00000001813F12E0
		public static bool ApproximatelyZero(float a); // 0x00000001813F1210-0x00000001813F1250
		public static bool IsZero(float value); // 0x00000001813F2AD0-0x00000001813F2AF0
		public static bool IsZero(float value, float threshold); // 0x00000001813F2B60-0x00000001813F2BB0
		public static bool IsZero(double value); // 0x00000001813F2B40-0x00000001813F2B60
		public static bool IsZero(double value, double threshold); // 0x00000001813F2AF0-0x00000001813F2B40
		public static bool IsExactlyEqual(float a, float b); // 0x00000001813F20E0-0x00000001813F2130
		public static bool IsExactlyEqual(double a, double b); // 0x00000001813F2130-0x00000001813F2160
		public static bool IsNear(float value, float targetValue); // 0x00000001813F2A60-0x00000001813F2AA0
		public static bool IsNear(float value, float targetValue, float threshold); // 0x00000001813F2AA0-0x00000001813F2AD0
		public static bool IsNearZero(float value); // 0x00000001813F2A30-0x00000001813F2A60
		public static bool IsNearZero(float value, float threshold); // 0x00000001813F29F0-0x00000001813F2A30
		public static bool IsNearOrWholeNumber(float value); // 0x00000001813F2760-0x00000001813F27F0
		public static bool IsNearOrWholeNumber(float value, float threshold); // 0x00000001813F27F0-0x00000001813F28C0
		public static bool IsNearOrWholeNumber(float value, out int number); // 0x00000001813F28C0-0x00000001813F29F0
		public static bool IsNearOrWholeNumber(float value, out int number, float threshold); // 0x00000001813F25C0-0x00000001813F2760
		public static float RoundOffIfNearWholeNumber(float value); // 0x00000001813F46E0-0x00000001813F47E0
		public static float RoundOffIfNearWholeNumber(float value, float threshold); // 0x00000001813F47E0-0x00000001813F4990
		public static bool IsEven(int value); // 0x00000001813F20C0-0x00000001813F20E0
		public static float ValueInNewRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax); // 0x00000001813F54E0-0x00000001813F56A0
		public static int ValueInNewRange(int oldValue, int oldMin, int oldMax, int newMin, int newMax); // 0x00000001813F56A0-0x00000001813F5760
		public static sbyte Max(sbyte a, sbyte b); // 0x00000001813F3C20-0x00000001813F3C30
		public static byte Max(byte a, byte b); // 0x00000001813F39E0-0x00000001813F39F0
		public static short Max(short a, short b); // 0x00000001813F3C00-0x00000001813F3C10
		public static ushort Max(ushort a, ushort b); // 0x00000001813F3BE0-0x00000001813F3BF0
		public static int Max(int a, int b); // 0x00000001812006A0-0x00000001812006B0
		public static uint Max(uint a, uint b); // 0x00000001813F3980-0x00000001813F3990
		public static long Max(long a, long b); // 0x0000000181200640-0x0000000181200650
		public static ulong Max(ulong a, ulong b); // 0x00000001813F39F0-0x00000001813F3A00
		public static float Max(float a, float b); // 0x00000001813F3BF0-0x00000001813F3C00
		public static double Max(double a, double b); // 0x00000001813F3C10-0x00000001813F3C20
		public static sbyte Min(sbyte a, sbyte b); // 0x00000001813F3ED0-0x00000001813F3EE0
		public static byte Min(byte a, byte b); // 0x00000001813F3E70-0x00000001813F3E80
		public static short Min(short a, short b); // 0x00000001813F3EC0-0x00000001813F3ED0
		public static ushort Min(ushort a, ushort b); // 0x00000001813F3E60-0x00000001813F3E70
		public static int Min(int a, int b); // 0x0000000181200830-0x0000000181200840
		public static uint Min(uint a, uint b); // 0x00000001813F3D90-0x00000001813F3DA0
		public static long Min(long a, long b); // 0x00000001812007D0-0x00000001812007E0
		public static ulong Min(ulong a, ulong b); // 0x00000001813F3C50-0x00000001813F3C60
		public static float Min(float a, float b); // 0x00000001813F3EE0-0x00000001813F3EF0
		public static double Min(double a, double b); // 0x00000001813F3EF0-0x00000001813F3F00
		public static sbyte MaxMagnitude(sbyte a, sbyte b); // 0x00000001813F3A40-0x00000001813F3A80
		public static byte MaxMagnitude(byte a, byte b); // 0x00000001813F39E0-0x00000001813F39F0
		public static short MaxMagnitude(short a, short b); // 0x00000001813F3B10-0x00000001813F3B50
		public static ushort MaxMagnitude(ushort a, ushort b); // 0x00000001813F3BE0-0x00000001813F3BF0
		public static int MaxMagnitude(int a, int b); // 0x00000001813F3990-0x00000001813F39B0
		public static uint MaxMagnitude(uint a, uint b); // 0x00000001813F3980-0x00000001813F3990
		public static long MaxMagnitude(long a, long b); // 0x00000001813F39B0-0x00000001813F39E0
		public static ulong MaxMagnitude(ulong a, ulong b); // 0x00000001813F39F0-0x00000001813F3A00
		public static float MaxMagnitude(float a, float b); // 0x00000001813F3BA0-0x00000001813F3BE0
		public static double MaxMagnitude(double a, double b); // 0x00000001813F3A00-0x00000001813F3A40
		public static sbyte MinMagnitude(sbyte a, sbyte b); // 0x00000001813F3DD0-0x00000001813F3E10
		public static byte MinMagnitude(byte a, byte b); // 0x00000001813F3E70-0x00000001813F3E80
		public static short MinMagnitude(short a, short b); // 0x00000001813F3C60-0x00000001813F3CD0
		public static ushort MinMagnitude(ushort a, ushort b); // 0x00000001813F3E60-0x00000001813F3E70
		public static int MinMagnitude(int a, int b); // 0x00000001813F3C30-0x00000001813F3C50
		public static uint MinMagnitude(uint a, uint b); // 0x00000001813F3D90-0x00000001813F3DA0
		public static long MinMagnitude(long a, long b); // 0x00000001813F3DA0-0x00000001813F3DD0
		public static ulong MinMagnitude(ulong a, ulong b); // 0x00000001813F3C50-0x00000001813F3C60
		public static float MinMagnitude(float a, float b); // 0x00000001813F3E80-0x00000001813F3EC0
		public static double MinMagnitude(double a, double b); // 0x00000001813F3CD0-0x00000001813F3D20
		public static bool IsMoreMagnitudeOrEqual(sbyte a, sbyte b); // 0x00000001813F2390-0x00000001813F23D0
		public static bool IsMoreMagnitudeOrEqual(byte a, byte b); // 0x00000001813F2380-0x00000001813F2390
		public static bool IsMoreMagnitudeOrEqual(short a, short b); // 0x00000001813F2430-0x00000001813F2490
		public static bool IsMoreMagnitudeOrEqual(ushort a, ushort b); // 0x00000001813F25B0-0x00000001813F25C0
		public static bool IsMoreMagnitudeOrEqual(int a, int b); // 0x00000001813F24F0-0x00000001813F2530
		public static bool IsMoreMagnitudeOrEqual(uint a, uint b); // 0x00000001813F25A0-0x00000001813F25B0
		public static bool IsMoreMagnitudeOrEqual(long a, long b); // 0x00000001813F23D0-0x00000001813F2430
		public static bool IsMoreMagnitudeOrEqual(ulong a, ulong b); // 0x00000001813F2590-0x00000001813F25A0
		public static bool IsMoreMagnitudeOrEqual(float a, float b); // 0x00000001813F2490-0x00000001813F24F0
		public static bool IsMoreMagnitudeOrEqual(double a, double b); // 0x00000001813F2530-0x00000001813F2590
		public static bool IsLessMagnitudeOrEqual(sbyte a, sbyte b); // 0x00000001813F21B0-0x00000001813F2210
		public static bool IsLessMagnitudeOrEqual(byte a, byte b); // 0x00000001813F2370-0x00000001813F2380
		public static bool IsLessMagnitudeOrEqual(short a, short b); // 0x00000001813F2270-0x00000001813F22C0
		public static bool IsLessMagnitudeOrEqual(ushort a, ushort b); // 0x00000001813F22C0-0x00000001813F22D0
		public static bool IsLessMagnitudeOrEqual(int a, int b); // 0x00000001813F2160-0x00000001813F21B0
		public static bool IsLessMagnitudeOrEqual(uint a, uint b); // 0x00000001813F22D0-0x00000001813F22E0
		public static bool IsLessMagnitudeOrEqual(long a, long b); // 0x00000001813F22E0-0x00000001813F2320
		public static bool IsLessMagnitudeOrEqual(ulong a, ulong b); // 0x00000001813F2260-0x00000001813F2270
		public static bool IsLessMagnitudeOrEqual(float a, float b); // 0x00000001813F2210-0x00000001813F2260
		public static bool IsLessMagnitudeOrEqual(double a, double b); // 0x00000001813F2320-0x00000001813F2370
		public static byte Clamp(byte value, byte min, byte max); // 0x00000001813F16C0-0x00000001813F16E0
		public static sbyte Clamp(sbyte value, sbyte min, sbyte max); // 0x00000001813F1AF0-0x00000001813F1B30
		public static short Clamp(short value, short min, short max); // 0x00000001813F1AD0-0x00000001813F1AF0
		public static ushort Clamp(ushort value, ushort min, ushort max); // 0x00000001813F1820-0x00000001813F1860
		public static int Clamp(int value, int min, int max); // 0x00000001813F1AB0-0x00000001813F1AD0
		public static uint Clamp(uint value, uint min, uint max); // 0x00000001813F16E0-0x00000001813F1700
		public static long Clamp(long value, long min, long max); // 0x00000001813F1B30-0x00000001813F1B70
		public static ulong Clamp(ulong value, ulong min, ulong max); // 0x00000001813F17D0-0x00000001813F1820
		public static float Clamp(float value, float min, float max); // 0x00000001813F1B70-0x00000001813F1B90
		public static double Clamp(double value, double min, double max); // 0x00000001813F1700-0x00000001813F1740
		public static float Clamp01(float value); // 0x00000001813F1500-0x00000001813F1520
		public static float ClampAngle360(float angle); // 0x00000001813F1520-0x00000001813F16C0
		public static float ReverseAngleRotationDirection(float angle); // 0x00000001813F4390-0x00000001813F43D0
		public static bool AngleIsNear(float angle, float targetAngle, float threshold); // 0x00000001813F1110-0x00000001813F1210
		public static bool AngleIsBetween(float angle, float min, float max); // 0x00000001813F1070-0x00000001813F1110
		internal static bool vLEHzLGXsBafSyZWSWxgOrUbd(int param_0000f315, int param_0000f316); // 0x00000001813F59A0-0x00000001813F59C0
		public static int IntPow(int x, uint pow); // 0x00000001813F2040-0x00000001813F20C0
		public static uint RoundUpToPowerOf2(uint value); // 0x00000001813F49F0-0x00000001813F4A50
		public static float BooleanToSign(bool b); // 0x00000001813F1420-0x00000001813F1440
		public static bool SignToBoolean(float sign); // 0x00000001813F4AB0-0x00000001813F4AC0
		public static float Sin(float value); // 0x00000001813F4AF0-0x00000001813F4B50
		public static float Cos(float value); // 0x00000001813F1B90-0x00000001813F1BF0
		public static float Tan(float value); // 0x00000001813F4F70-0x00000001813F4FD0
		public static float Asin(float value); // 0x00000001813F12E0-0x00000001813F1340
		public static float Acos(float value); // 0x00000001813F1010-0x00000001813F1070
		public static float Atan(float value); // 0x00000001813F13C0-0x00000001813F1420
		public static float Atan2(float y, float x); // 0x00000001813F1340-0x00000001813F13C0
		public static float Sqrt(float value); // 0x00000001813F4F10-0x00000001813F4F70
		public static float Pow(float value, float p); // 0x00000001813F3F30-0x00000001813F3FB0
		public static float Exp(float power); // 0x00000001813F1D00-0x00000001813F1D60
		public static float Log(float value, float p); // 0x00000001813F3900-0x00000001813F3980
		public static float Log(float value); // 0x00000001813F38A0-0x00000001813F3900
		public static float Log10(float value); // 0x00000001813F3840-0x00000001813F38A0
		public static float Ceil(float value); // 0x00000001813F14A0-0x00000001813F1500
		public static float Floor(float value); // 0x00000001813F1DC0-0x00000001813F1E20
		public static float Round(float value); // 0x00000001813F4A50-0x00000001813F4AB0
		public static int CeilToInt(float value); // 0x00000001813F1440-0x00000001813F14A0
		public static int FloorToInt(float value); // 0x00000001813F1D60-0x00000001813F1DC0
		public static int RoundToInt(float value); // 0x00000001813F4990-0x00000001813F49F0
		public static float Sign(float value); // 0x00000001813F4AC0-0x00000001813F4AE0
		public static int Sign(int value); // 0x00000001813F4AE0-0x00000001813F4AF0
		public static float Repeat(float t, float length); // 0x00000001813F4300-0x00000001813F4390
		public static float DeltaAngle(float current, float target); // 0x00000001813F1C20-0x00000001813F1D00
		public static Vector2 MaxMagnitude(Vector2 a, Vector2 b); // 0x00000001813F3B50-0x00000001813F3BA0
		public static Vector3 MaxMagnitude(Vector3 a, Vector3 b); // 0x00000001813F3A80-0x00000001813F3B10
		public static Vector2 MinMagnitude(Vector2 a, Vector2 b); // 0x00000001813F3E10-0x00000001813F3E60
		public static Vector3 MinMagnitude(Vector3 a, Vector3 b); // 0x00000001813F3D20-0x00000001813F3D90
		public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max); // 0x00000001813F1950-0x00000001813F19C0
		public static Vector2 Clamp(Vector2 value, float min, float max); // 0x00000001813F1740-0x00000001813F17D0
		public static Vector2 Clamp(Vector3 value, Vector3 min, Vector3 max); // 0x00000001813F19C0-0x00000001813F1AB0
		public static Vector2 Clamp(Vector3 value, float min, float max); // 0x00000001813F1860-0x00000001813F1950
		public static float Cross(Vector2 a, Vector2 b); // 0x00000001813F1BF0-0x00000001813F1C20
		public static float Multiply(Vector2 a, Vector2 b); // 0x00000001813F3F00-0x00000001813F3F30
		public static bool RectContains(Rect rect, Vector2 pos, float rotation = 0f /* Metadata: 0x0076676D */); // 0x00000001813F3FB0-0x00000001813F4240
		public static Vector2 RotateWorldPoint(Vector2 point, Vector2 center, float angle); // 0x00000001813F4500-0x00000001813F46E0
		public static Vector2 RotateLocalPoint(Vector2 point, float angle); // 0x00000001813F43D0-0x00000001813F4500
		public static bool LineIntersectsRect(Vector2 point1, Vector2 point2, Rect rect, out float sqrMagnitude); // 0x00000001813F2BB0-0x00000001813F32F0
		public static bool LineSegementsIntersect(Vector2 line1p1, Vector2 line1p2, Vector2 line2p1, Vector2 line2p2, out Vector2 intersection, bool collinearIntersects = false /* Metadata: 0x00766771 */); // 0x00000001813F32F0-0x00000001813F3840
		private static bool mkUwoRIpAgFxxuavPdrupgAQVoe(Vector2 param_0000f362, Vector2 param_0000f363, Vector2 param_0000f364, Vector2 param_0000f365, out Vector2 param_0000f366); // 0x00000001813F5760-0x00000001813F59A0
		public static bool RectContains(Rect container, Rect child); // 0x00000001813F4240-0x00000001813F4300
		public static bool GetOffsetToContainRect(Rect container, Rect child, out Vector2 offset); // 0x00000001813F1E20-0x00000001813F2040
		public static Matrix4x4 TransformTo(Transform from, Transform to); // 0x00000001813F5330-0x00000001813F54E0
		public static Rect TransformRect(Rect fromRect, Transform from, Transform to); // 0x00000001813F4FD0-0x00000001813F5330
		public static Vector2 SnapVectorToNearestAngle(Vector2 vector, float angle); // 0x00000001813F4B50-0x00000001813F4F10
	}
}
