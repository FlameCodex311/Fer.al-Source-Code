/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class JsonReader : IDisposable // TypeDefIndex: 7812
	{
		// Fields
		private JsonToken _tokenType; // 0x10
		private object _value; // 0x18
		internal char _quoteChar; // 0x20
		internal State _currentState; // 0x24
		private JsonPosition _currentPosition; // 0x28
		private CultureInfo _culture; // 0x40
		private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
		private int? _maxDepth; // 0x4C
		private bool _hasExceededMaxDepth; // 0x54
		internal DateParseHandling _dateParseHandling; // 0x58
		internal FloatParseHandling _floatParseHandling; // 0x5C
		private string _dateFormatString; // 0x60
		private List<JsonPosition> _stack; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CloseInput>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <SupportMultipleContent>k__BackingField; // 0x71
	
		// Properties
		protected State CurrentState { get; } // 0x00000001803C26F0-0x00000001803C2700 
		public bool CloseInput { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180545D70-0x0000000180545D80 0x0000000180545DC0-0x0000000180545DD0
		public bool SupportMultipleContent { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805459C0-0x00000001805459D0 0x0000000180545DA0-0x0000000180545DB0
		public DateTimeZoneHandling DateTimeZoneHandling { get; set; } // 0x0000000180384C10-0x0000000180384C20 0x0000000180692030-0x00000001806920A0
		public DateParseHandling DateParseHandling { get; set; } // 0x000000018049CAA0-0x000000018049CAB0 0x0000000180691FC0-0x0000000180692030
		public FloatParseHandling FloatParseHandling { get; set; } // 0x00000001804A3740-0x00000001804A3750 0x00000001806920A0-0x0000000180692110
		public string DateFormatString { get; set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public int? MaxDepth { get; set; } // 0x0000000180691E90-0x0000000180691EA0 0x0000000180692110-0x00000001806921A0
		public virtual JsonToken TokenType { get; } // 0x000000018036CFF0-0x000000018036D000 
		public virtual object Value { get; } // 0x000000018038B150-0x000000018038B160 
		public virtual Type ValueType { get; } // 0x0000000180691FA0-0x0000000180691FC0 
		public virtual int Depth { get; } // 0x0000000180691E20-0x0000000180691E90 
		public virtual string Path { get; } // 0x0000000180691EA0-0x0000000180691FA0 
		public CultureInfo Culture { get; set; } // 0x0000000180691DC0-0x0000000180691E20 0x00000001803A2810-0x00000001803A2820
	
		// Nested types
		protected internal enum State // TypeDefIndex: 7813
		{
			Start = 0,
			Complete = 1,
			Property = 2,
			ObjectStart = 3,
			Object = 4,
			ArrayStart = 5,
			Array = 6,
			Closed = 7,
			PostValue = 8,
			ConstructorStart = 9,
			Constructor = 10,
			Error = 11,
			Finished = 12
		}
	
		// Constructors
		protected JsonReader(); // 0x0000000180691D90-0x0000000180691DC0
	
		// Methods
		internal JsonPosition GetPosition(int depth); // 0x000000018068E230-0x000000018068E2D0
		private void Push(JsonContainerType value); // 0x000000018068E510-0x000000018068E7B0
		private JsonContainerType Pop(); // 0x000000018068E420-0x000000018068E510
		private JsonContainerType Peek(); // 0x000000018038E0E0-0x000000018038E0F0
		public abstract bool Read();
		public virtual int? ReadAsInt32(); // 0x000000018068FE00-0x00000001806900E0
		internal int? ReadInt32String(string s); // 0x00000001806911A0-0x00000001806913C0
		public virtual string ReadAsString(); // 0x00000001806900E0-0x00000001806904A0
		public virtual byte[] ReadAsBytes(); // 0x000000018068EDC0-0x000000018068F250
		internal byte[] ReadArrayIntoByteArray(); // 0x000000018068E880-0x000000018068EAF0
		public virtual double? ReadAsDouble(); // 0x000000018068FB30-0x000000018068FE00
		internal double? ReadDoubleString(string s); // 0x0000000180690F40-0x00000001806911A0
		public virtual bool? ReadAsBoolean(); // 0x000000018068EAF0-0x000000018068EDC0
		internal bool? ReadBooleanString(string s); // 0x00000001806904A0-0x0000000180690680
		public virtual decimal? ReadAsDecimal(); // 0x000000018068F830-0x000000018068FB30
		internal decimal? ReadDecimalString(string s); // 0x0000000180690CB0-0x0000000180690F40
		public virtual DateTime? ReadAsDateTime(); // 0x000000018068F560-0x000000018068F830
		internal DateTime? ReadDateTimeString(string s); // 0x00000001806909D0-0x0000000180690CB0
		public virtual DateTimeOffset? ReadAsDateTimeOffset(); // 0x000000018068F250-0x000000018068F560
		internal DateTimeOffset? ReadDateTimeOffsetString(string s); // 0x0000000180690680-0x00000001806909D0
		internal void ReaderReadAndAssert(); // 0x0000000180691630-0x0000000180691690
		internal JsonReaderException CreateUnexpectedEndException(); // 0x000000018068E160-0x000000018068E1A0
		internal void ReadIntoWrappedTypeObject(); // 0x00000001806913C0-0x0000000180691630
		public void Skip(); // 0x00000001806919D0-0x0000000180691A80
		protected void SetToken(JsonToken newToken); // 0x00000001806919B0-0x00000001806919D0
		protected void SetToken(JsonToken newToken, object value); // 0x0000000180691990-0x00000001806919B0
		internal void SetToken(JsonToken newToken, object value, bool updateIndex); // 0x00000001806917F0-0x0000000180691990
		internal void SetPostValueState(bool updateIndex); // 0x00000001806916B0-0x00000001806916E0
		private void UpdateScopeWithFinishedValue(); // 0x0000000180691AF0-0x0000000180691B00
		private void ValidateEnd(JsonToken endToken); // 0x0000000180691B00-0x0000000180691D90
		protected void SetStateBasedOnCurrent(); // 0x00000001806916E0-0x00000001806917F0
		private void SetFinished(); // 0x0000000180691690-0x00000001806916B0
		private JsonContainerType GetTypeForCloseToken(JsonToken token); // 0x000000018068E2D0-0x000000018068E3C0
		void IDisposable.Dispose(); // 0x0000000180691A80-0x0000000180691AF0
		protected virtual void Dispose(bool disposing); // 0x000000018068E1A0-0x000000018068E1C0
		public virtual void Close(); // 0x000000018068E140-0x000000018068E160
		internal void ReadAndAssert(); // 0x000000018068E7B0-0x000000018068E820
		internal bool ReadAndMoveToContent(); // 0x000000018068E820-0x000000018068E880
		internal bool MoveToContent(); // 0x000000018068E3C0-0x000000018068E420
		private JsonToken GetContentToken(); // 0x000000018068E1C0-0x000000018068E230
	}
}
