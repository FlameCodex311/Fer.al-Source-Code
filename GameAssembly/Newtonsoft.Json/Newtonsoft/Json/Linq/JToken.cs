/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800FC9A0-0x00000001800FC9F0
	public abstract class JToken : IJEnumerable<JToken>, IJsonLineInfo, ICloneable // TypeDefIndex: 7980
	{
		// Fields
		private JContainer _parent; // 0x10
		private JToken _previous; // 0x18
		private JToken _next; // 0x20
		private object _annotations; // 0x28
		private static readonly JTokenType[] BooleanTypes; // 0x00
		private static readonly JTokenType[] NumberTypes; // 0x08
		private static readonly JTokenType[] StringTypes; // 0x10
		private static readonly JTokenType[] GuidTypes; // 0x18
		private static readonly JTokenType[] TimeSpanTypes; // 0x20
		private static readonly JTokenType[] UriTypes; // 0x28
		private static readonly JTokenType[] CharTypes; // 0x30
		private static readonly JTokenType[] DateTimeTypes; // 0x38
		private static readonly JTokenType[] BytesTypes; // 0x40
	
		// Properties
		public JContainer Parent { [DebuggerStepThrough] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; internal set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public JToken Root { get; } // 0x0000000180959610-0x0000000180959640 
		public abstract JTokenType Type { get; }
		public abstract bool HasValues { get; }
		public JToken Next { get; internal set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public JToken Previous { get; internal set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string Path { get; } // 0x0000000180959380-0x0000000180959610 
		public virtual JToken First { get; } // 0x0000000180959220-0x00000001809592D0 
		public virtual JToken Last { get; } // 0x00000001809592D0-0x0000000180959380 
		int IJsonLineInfo.LineNumber { get; } // 0x0000000180956ED0-0x0000000180956F20 
		int IJsonLineInfo.LinePosition { get; } // 0x0000000180956F20-0x0000000180956F70 
	
		// Nested types
		private class LineInfoAnnotation // TypeDefIndex: 7981
		{
			// Fields
			internal readonly int LineNumber; // 0x10
			internal readonly int LinePosition; // 0x14
	
			// Constructors
			public LineInfoAnnotation(int lineNumber, int linePosition); // 0x00000001804F7840-0x00000001804F7880
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetAncestors>d__41 // TypeDefIndex: 7982
		{
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AfterSelf>d__42 // TypeDefIndex: 7983
		{
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <BeforeSelf>d__43 // TypeDefIndex: 7984
		{
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Annotations>d__171<T> // TypeDefIndex: 7985
			where T : class
		{
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Annotations>d__172 // TypeDefIndex: 7986
		{
		}
	
		// Constructors
		internal JToken(); // 0x000000018036B6C0-0x000000018036B6D0
		static JToken(); // 0x0000000180958900-0x0000000180959220
	
		// Methods
		internal abstract JToken CloneToken();
		internal abstract bool DeepEquals(JToken node);
		public static bool DeepEquals(JToken t1, JToken t2); // 0x0000000180956B40-0x0000000180956B70
		public virtual JEnumerable<JToken> Children(); // 0x0000000180956A80-0x0000000180956AE0
		public void Remove(); // 0x0000000180957300-0x0000000180957380
		public void Replace(JToken value); // 0x0000000180957380-0x0000000180957410
		public abstract void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters);
		public override string ToString(); // 0x00000001809587D0-0x0000000180958820
		public string ToString(Formatting formatting, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x0000000180958550-0x00000001809587D0
		private static JValue EnsureValue(JToken value); // 0x0000000180956B70-0x0000000180956D00
		private static string GetType(JToken token); // 0x0000000180956D00-0x0000000180956E90
		private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable); // 0x0000000180958820-0x0000000180958900
		public static explicit operator bool(JToken value); // 0x000000018095E4A0-0x000000018095E680
		public static explicit operator DateTimeOffset(JToken value); // 0x000000018095B950-0x000000018095BC60
		public static explicit operator bool?(JToken value); // 0x000000018095C7A0-0x000000018095CA00
		public static explicit operator long(JToken value); // 0x0000000180959A80-0x0000000180959C60
		public static explicit operator DateTime?(JToken value); // 0x0000000180959E40-0x000000018095A110
		public static explicit operator DateTimeOffset?(JToken value); // 0x000000018095D570-0x000000018095D940
		public static explicit operator decimal?(JToken value); // 0x000000018095AF30-0x000000018095B1D0
		public static explicit operator double?(JToken value); // 0x000000018095D300-0x000000018095D570
		public static explicit operator char?(JToken value); // 0x000000018095A5D0-0x000000018095A830
		public static explicit operator int(JToken value); // 0x000000018095E950-0x000000018095EB30
		public static explicit operator short(JToken value); // 0x000000018095BE40-0x000000018095C020
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator ushort(JToken value); // 0x000000018095DB90-0x000000018095DD70
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator char(JToken value); // 0x0000000180959640-0x0000000180959820
		public static explicit operator byte(JToken value); // 0x000000018095B770-0x000000018095B950
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator sbyte(JToken value); // 0x000000018095A3F0-0x000000018095A5D0
		public static explicit operator int?(JToken value); // 0x000000018095CA00-0x000000018095CC60
		public static explicit operator short?(JToken value); // 0x000000018095CEC0-0x000000018095D120
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator ushort?(JToken value); // 0x000000018095DD70-0x000000018095DFD0
		public static explicit operator byte?(JToken value); // 0x000000018095CC60-0x000000018095CEC0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator sbyte?(JToken value); // 0x000000018095C020-0x000000018095C280
		public static explicit operator DateTime(JToken value); // 0x000000018095D940-0x000000018095DB90
		public static explicit operator long?(JToken value); // 0x000000018095AA10-0x000000018095AC80
		public static explicit operator float?(JToken value); // 0x000000018095C540-0x000000018095C7A0
		public static explicit operator decimal(JToken value); // 0x000000018095B1D0-0x000000018095B3D0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator uint?(JToken value); // 0x000000018095E240-0x000000018095E4A0
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator ulong?(JToken value); // 0x000000018095DFD0-0x000000018095E240
		public static explicit operator double(JToken value); // 0x000000018095A830-0x000000018095AA10
		public static explicit operator float(JToken value); // 0x000000018095D120-0x000000018095D300
		public static explicit operator string(JToken value); // 0x000000018095C280-0x000000018095C540
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator uint(JToken value); // 0x000000018095BC60-0x000000018095BE40
		[CLSCompliant] // 0x00000001800BD1B0-0x00000001800BD1D0
		public static explicit operator ulong(JToken value); // 0x0000000180959C60-0x0000000180959E40
		public static explicit operator Guid(JToken value); // 0x000000018095E680-0x000000018095E950
		public static explicit operator Guid?(JToken value); // 0x000000018095B3D0-0x000000018095B770
		public static explicit operator TimeSpan(JToken value); // 0x0000000180959820-0x0000000180959A80
		public static explicit operator TimeSpan?(JToken value); // 0x000000018095A110-0x000000018095A3F0
		public static explicit operator Uri(JToken value); // 0x000000018095AC80-0x000000018095AF30
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001809575E0-0x0000000180957620
		IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator(); // 0x0000000180957580-0x00000001809575E0
		internal abstract int GetDeepHashCode();
		public JsonReader CreateReader(); // 0x0000000180956AE0-0x0000000180956B40
		public object ToObject(Type objectType); // 0x0000000180957750-0x0000000180958550
		public object ToObject(Type objectType, JsonSerializer jsonSerializer); // 0x0000000180957620-0x0000000180957750
		public static JToken ReadFrom(JsonReader reader); // 0x0000000180956F70-0x0000000180956FD0
		public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings); // 0x0000000180956FD0-0x0000000180957300
		internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings); // 0x0000000180957490-0x0000000180957580
		internal void SetLineInfo(int lineNumber, int linePosition); // 0x0000000180957410-0x0000000180957490
		bool IJsonLineInfo.HasLineInfo(); // 0x0000000180956E90-0x0000000180956ED0
		object ICloneable.Clone(); // 0x00000001806A3950-0x00000001806A3970
		public JToken DeepClone(); // 0x00000001806A3950-0x00000001806A3970
		public void AddAnnotation(object annotation); // 0x0000000180956790-0x0000000180956A80
		public T Annotation<T>()
			where T : class;
	}
}
