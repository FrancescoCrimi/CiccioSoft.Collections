// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CiccioSoft.Collections.Core.Resources
{
    internal static class Strings { }
}

namespace System
{
    internal static partial class SR
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(CiccioSoft.Collections.Core.Resources.Strings)));

        /// <summary>Cannot create an abstract class.</summary>
        internal static string @Acc_CreateAbst => GetResourceString("Acc_CreateAbst");
        /// <summary>Cannot create an instance of {0} because it is an abstract class.</summary>
        internal static string @Acc_CreateAbstEx => GetResourceString("Acc_CreateAbstEx");
        /// <summary>Cannot dynamically create an instance of ArgIterator.</summary>
        internal static string @Acc_CreateArgIterator => GetResourceString("Acc_CreateArgIterator");
        /// <summary>Cannot create a type for which Type.ContainsGenericParameters is true.</summary>
        internal static string @Acc_CreateGeneric => GetResourceString("Acc_CreateGeneric");
        /// <summary>Cannot create an instance of {0} because Type.ContainsGenericParameters is true.</summary>
        internal static string @Acc_CreateGenericEx => GetResourceString("Acc_CreateGenericEx");
        /// <summary>Cannot create an instance of an interface.</summary>
        internal static string @Acc_CreateInterface => GetResourceString("Acc_CreateInterface");
        /// <summary>Cannot create an instance of {0} because it is an interface.</summary>
        internal static string @Acc_CreateInterfaceEx => GetResourceString("Acc_CreateInterfaceEx");
        /// <summary>Cannot dynamically create an instance of System.Void.</summary>
        internal static string @Acc_CreateVoid => GetResourceString("Acc_CreateVoid");
        /// <summary>Type initializer was not callable.</summary>
        internal static string @Acc_NotClassInit => GetResourceString("Acc_NotClassInit");
        /// <summary>Cannot set a constant field.</summary>
        internal static string @Acc_ReadOnly => GetResourceString("Acc_ReadOnly");
        /// <summary>Cannot create an instance of void.</summary>
        internal static string @Access_Void => GetResourceString("Access_Void");
        /// <summary>One or more errors occurred.</summary>
        internal static string @AggregateException_ctor_DefaultMessage => GetResourceString("AggregateException_ctor_DefaultMessage");
        /// <summary>An element of innerExceptions was null.</summary>
        internal static string @AggregateException_ctor_InnerExceptionNull => GetResourceString("AggregateException_ctor_InnerExceptionNull");
        /// <summary>The serialization stream contains no inner exceptions.</summary>
        internal static string @AggregateException_DeserializationFailure => GetResourceString("AggregateException_DeserializationFailure");
        /// <summary>(Inner Exception #{0})</summary>
        internal static string @AggregateException_InnerException => GetResourceString("AggregateException_InnerException");
        /// <summary>Name:</summary>
        internal static string @AppDomain_Name => GetResourceString("AppDomain_Name");
        /// <summary>There are no context policies.</summary>
        internal static string @AppDomain_NoContextPolicies => GetResourceString("AppDomain_NoContextPolicies");
        /// <summary>Default principal object cannot be set twice.</summary>
        internal static string @AppDomain_Policy_PrincipalTwice => GetResourceString("AppDomain_Policy_PrincipalTwice");
        /// <summary>Cannot access member.</summary>
        internal static string @Arg_AccessException => GetResourceString("Arg_AccessException");
        /// <summary>Attempted to read or write protected memory. This is often an indication that other memory is corrupt.</summary>
        internal static string @Arg_AccessViolationException => GetResourceString("Arg_AccessViolationException");
        /// <summary>Ambiguous implementation found.</summary>
        internal static string @Arg_AmbiguousImplementationException_NoMessage => GetResourceString("Arg_AmbiguousImplementationException_NoMessage");
        /// <summary>Multiple custom attributes of the same type '{0}' found.</summary>
        internal static string @Arg_AmbiguousMatchException_Attribute => GetResourceString("Arg_AmbiguousMatchException_Attribute");
        /// <summary>Ambiguous match found.</summary>
        internal static string @Arg_AmbiguousMatchException_NoMessage => GetResourceString("Arg_AmbiguousMatchException_NoMessage");
        /// <summary>Ambiguous match found for '{0}'.</summary>
        internal static string @Arg_AmbiguousMatchException_CustomAttributeData => GetResourceString("Arg_AmbiguousMatchException_CustomAttributeData");
        /// <summary>Ambiguous match found for '{0} {1}'.</summary>
        internal static string @Arg_AmbiguousMatchException_MemberInfo => GetResourceString("Arg_AmbiguousMatchException_MemberInfo");
        /// <summary>Ambiguity in binding of UnsafeAccessorAttribute.</summary>
        internal static string @Arg_AmbiguousMatchException_UnsafeAccessor => GetResourceString("Arg_AmbiguousMatchException_UnsafeAccessor");
        /// <summary>Error in the application.</summary>
        internal static string @Arg_ApplicationException => GetResourceString("Arg_ApplicationException");
        /// <summary>Value does not fall within the expected range.</summary>
        internal static string @Arg_ArgumentException => GetResourceString("Arg_ArgumentException");
        /// <summary>Specified argument was out of the range of valid values.</summary>
        internal static string @Arg_ArgumentOutOfRangeException => GetResourceString("Arg_ArgumentOutOfRangeException");
        /// <summary>Overflow or underflow in the arithmetic operation.</summary>
        internal static string @Arg_ArithmeticException => GetResourceString("Arg_ArithmeticException");
        /// <summary>Array lengths must be the same.</summary>
        internal static string @Arg_ArrayLengthsDiffer => GetResourceString("Arg_ArrayLengthsDiffer");
        /// <summary>Destination array is not long enough to copy all the items in the collection. Check array index and length.</summary>
        internal static string @Arg_ArrayPlusOffTooSmall => GetResourceString("Arg_ArrayPlusOffTooSmall");
        /// <summary>The array starting from the specified index is not long enough to read a value of the specified type.</summary>
        internal static string @Arg_ByteArrayTooSmallForValue => GetResourceString("Arg_ByteArrayTooSmallForValue");
        /// <summary>Attempted to access an element as a type incompatible with the array.</summary>
        internal static string @Arg_ArrayTypeMismatchException => GetResourceString("Arg_ArrayTypeMismatchException");
        /// <summary>Array must not be of length zero.</summary>
        internal static string @Arg_ArrayZeroError => GetResourceString("Arg_ArrayZeroError");
        /// <summary>Read an invalid decimal value from the buffer.</summary>
        internal static string @Arg_BadDecimal => GetResourceString("Arg_BadDecimal");
        /// <summary>Format of the executable (.exe) or library (.dll) is invalid.</summary>
        internal static string @Arg_BadImageFormatException => GetResourceString("Arg_BadImageFormatException");
        /// <summary>Encountered an invalid type for a default value.</summary>
        internal static string @Arg_BadLiteralFormat => GetResourceString("Arg_BadLiteralFormat");
        /// <summary>Unable to sort because the IComparer.Compare() method returns inconsistent results. Either a value does not compare equal to itself, or one value repeatedly compared to another value yields different results. IComparer: '{0}'.</summary>
        internal static string @Arg_BogusIComparer => GetResourceString("Arg_BogusIComparer");
        /// <summary>Not enough space available in the buffer.</summary>
        internal static string @Arg_BufferTooSmall => GetResourceString("Arg_BufferTooSmall");
        /// <summary>TimeSpan does not accept floating point Not-a-Number values.</summary>
        internal static string @Arg_CannotBeNaN => GetResourceString("Arg_CannotBeNaN");
        /// <summary>String cannot contain a minus sign if the base is not 10.</summary>
        internal static string @Arg_CannotHaveNegativeValue => GetResourceString("Arg_CannotHaveNegativeValue");
        /// <summary>Type '{0}' cannot be marshaled as an unmanaged structure; no meaningful size or offset can be computed.</summary>
        internal static string @Arg_CannotMarshal => GetResourceString("Arg_CannotMarshal");
        /// <summary>The usage of IKeyComparer and IHashCodeProvider/IComparer interfaces cannot be mixed; use one or the other.</summary>
        internal static string @Arg_CannotMixComparisonInfrastructure => GetResourceString("Arg_CannotMixComparisonInfrastructure");
        /// <summary>Attempt to unload the AppDomain failed.</summary>
        internal static string @Arg_CannotUnloadAppDomainException => GetResourceString("Arg_CannotUnloadAppDomainException");
        /// <summary>Must specify property Set or Get or method call for a COM Object.</summary>
        internal static string @Arg_COMAccess => GetResourceString("Arg_COMAccess");
        /// <summary>Error HRESULT E_FAIL has been returned from a call to a COM component.</summary>
        internal static string @Arg_COMException => GetResourceString("Arg_COMException");
        /// <summary>Only one of the following binding flags can be set: BindingFlags.SetProperty, BindingFlags.PutDispProperty,  BindingFlags.PutRefDispProperty.</summary>
        internal static string @Arg_COMPropSetPut => GetResourceString("Arg_COMPropSetPut");
        /// <summary>Text must not contain non-ASCII characters.</summary>
        internal static string @Arg_ContainsNonAscii => GetResourceString("Arg_ContainsNonAscii");
        /// <summary>Cannot specify both CreateInstance and another access type.</summary>
        internal static string @Arg_CreatInstAccess => GetResourceString("Arg_CreatInstAccess");
        /// <summary>Error occurred during a cryptographic operation.</summary>
        internal static string @Arg_CryptographyException => GetResourceString("Arg_CryptographyException");
        /// <summary>Binary format of the specified custom attribute was invalid.</summary>
        internal static string @Arg_CustomAttributeFormatException => GetResourceString("Arg_CustomAttributeFormatException");
        /// <summary>A datatype misalignment was detected in a load or store instruction.</summary>
        internal static string @Arg_DataMisalignedException => GetResourceString("Arg_DataMisalignedException");
        /// <summary>Decimal constructor requires an array or span of four valid decimal bytes.</summary>
        internal static string @Arg_DecBitCtor => GetResourceString("Arg_DecBitCtor");
        /// <summary>Attempted to access a path that is not on the disk.</summary>
        internal static string @Arg_DirectoryNotFoundException => GetResourceString("Arg_DirectoryNotFoundException");
        /// <summary>Attempted to divide by zero.</summary>
        internal static string @Arg_DivideByZero => GetResourceString("Arg_DivideByZero");
        /// <summary>Delegate to an instance method cannot have null 'this'.</summary>
        internal static string @Arg_DlgtNullInst => GetResourceString("Arg_DlgtNullInst");
        /// <summary>Cannot bind to the target method because its signature is not compatible with that of the delegate type.</summary>
        internal static string @Arg_DlgtTargMeth => GetResourceString("Arg_DlgtTargMeth");
        /// <summary>Delegates must be of the same type.</summary>
        internal static string @Arg_DlgtTypeMis => GetResourceString("Arg_DlgtTypeMis");
        /// <summary>Dll was not found.</summary>
        internal static string @Arg_DllNotFoundException => GetResourceString("Arg_DllNotFoundException");
        /// <summary>DllName cannot be empty.</summary>
        internal static string @Arg_DllNameCannotBeEmpty => GetResourceString("Arg_DllNameCannotBeEmpty");
        /// <summary>Duplicate objects in argument.</summary>
        internal static string @Arg_DuplicateWaitObjectException => GetResourceString("Arg_DuplicateWaitObjectException");
        /// <summary>This ExceptionHandlingClause is not a clause.</summary>
        internal static string @Arg_EHClauseNotClause => GetResourceString("Arg_EHClauseNotClause");
        /// <summary>This ExceptionHandlingClause is not a filter.</summary>
        internal static string @Arg_EHClauseNotFilter => GetResourceString("Arg_EHClauseNotFilter");
        /// <summary>Array may not be empty.</summary>
        internal static string @Arg_EmptyArray => GetResourceString("Arg_EmptyArray");
        /// <summary>Span may not be empty.</summary>
        internal static string @Arg_EmptySpan => GetResourceString("Arg_EmptySpan");
        /// <summary>Attempted to read past the end of the stream.</summary>
        internal static string @Arg_EndOfStreamException => GetResourceString("Arg_EndOfStreamException");
        /// <summary>Entry point was not found.</summary>
        internal static string @Arg_EntryPointNotFoundException => GetResourceString("Arg_EntryPointNotFoundException");
        /// <summary>Object must be the same type as the enum. The type passed in was '{0}'; the enum type was '{1}'.</summary>
        internal static string @Arg_EnumAndObjectMustBeSameType => GetResourceString("Arg_EnumAndObjectMustBeSameType");
        /// <summary>Enum underlying type and the object must be same type or object. Type passed in was '{0}'; the enum underlying type was '{1}'.</summary>
        internal static string @Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType => GetResourceString("Arg_EnumFormatUnderlyingTypeAndObjectMustBeSameType");
        /// <summary>Illegal enum value: {0}.</summary>
        internal static string @Arg_EnumIllegalVal => GetResourceString("Arg_EnumIllegalVal");
        /// <summary>Literal value was not found.</summary>
        internal static string @Arg_EnumLitValueNotFound => GetResourceString("Arg_EnumLitValueNotFound");
        /// <summary>Enum underlying type and the object must be same type or object must be a String. Type passed in was '{0}'; the enum underlying type was '{1}'.</summary>
        internal static string @Arg_EnumUnderlyingTypeAndObjectMustBeSameType => GetResourceString("Arg_EnumUnderlyingTypeAndObjectMustBeSameType");
        /// <summary>Requested value '{0}' was not found.</summary>
        internal static string @Arg_EnumValueNotFound => GetResourceString("Arg_EnumValueNotFound");
        /// <summary>Internal error in the runtime.</summary>
        internal static string @Arg_ExecutionEngineException => GetResourceString("Arg_ExecutionEngineException");
        /// <summary>External component has thrown an exception.</summary>
        internal static string @Arg_ExternalException => GetResourceString("Arg_ExternalException");
        /// <summary>Edit and Continue: Expected a primitive, valuetype, class or interface field.</summary>
        internal static string @Arg_EnC_ExpectedPrimitive => GetResourceString("Arg_EnC_ExpectedPrimitive");
        /// <summary>Attempted to access a field that is not accessible by the caller.</summary>
        internal static string @Arg_FieldAccessException => GetResourceString("Arg_FieldAccessException");
        /// <summary>Field '{0}' defined on type '{1}' is not a field on the target object which is of type '{2}'.</summary>
        internal static string @Arg_FieldDeclTarget => GetResourceString("Arg_FieldDeclTarget");
        /// <summary>No arguments can be provided to Get a field value.</summary>
        internal static string @Arg_FldGetArgErr => GetResourceString("Arg_FldGetArgErr");
        /// <summary>Cannot specify both GetField and SetProperty.</summary>
        internal static string @Arg_FldGetPropSet => GetResourceString("Arg_FldGetPropSet");
        /// <summary>Only the field value can be specified to set a field value.</summary>
        internal static string @Arg_FldSetArgErr => GetResourceString("Arg_FldSetArgErr");
        /// <summary>Cannot specify both Get and Set on a field.</summary>
        internal static string @Arg_FldSetGet => GetResourceString("Arg_FldSetGet");
        /// <summary>Cannot specify Set on a Field and Invoke on a method.</summary>
        internal static string @Arg_FldSetInvoke => GetResourceString("Arg_FldSetInvoke");
        /// <summary>Cannot specify both SetField and GetProperty.</summary>
        internal static string @Arg_FldSetPropGet => GetResourceString("Arg_FldSetPropGet");
        /// <summary>One of the identified items was in an invalid format.</summary>
        internal static string @Arg_FormatException => GetResourceString("Arg_FormatException");
        /// <summary>Generic arguments after array spec or pointer type.</summary>
        internal static string @Arg_GenericArgumentsAfterArrayOrPointerType => GetResourceString("Arg_GenericArgumentsAfterArrayOrPointerType");
        /// <summary>Method must be called on a Type for which Type.IsGenericParameter is false.</summary>
        internal static string @Arg_GenericParameter => GetResourceString("Arg_GenericParameter");
        /// <summary>Property Get method was not found.</summary>
        internal static string @Arg_GetMethNotFnd => GetResourceString("Arg_GetMethNotFnd");
        /// <summary>Byte array for Guid must be exactly {0} bytes long.</summary>
        internal static string @Arg_GuidArrayCtor => GetResourceString("Arg_GuidArrayCtor");
        /// <summary>Handle does not support asynchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened synchronously (that is, it was not opened for overlapped I/O).</summary>
        internal static string @Arg_HandleNotAsync => GetResourceString("Arg_HandleNotAsync");
        /// <summary>Handle does not support synchronous operations. The parameters to the FileStream constructor may need to be changed to indicate that the handle was opened asynchronously (that is, it was opened explicitly for overlapped I/O).</summary>
        internal static string @Arg_HandleNotSync => GetResourceString("Arg_HandleNotSync");
        /// <summary>The number styles AllowHexSpecifier and AllowBinarySpecifier are not supported on floating point data types.</summary>
        internal static string @Arg_HexBinaryStylesNotSupported => GetResourceString("Arg_HexBinaryStylesNotSupported");
        /// <summary>Hashtable's capacity overflowed and went negative. Check load factor, capacity and the current size of the table.</summary>
        internal static string @Arg_HTCapacityOverflow => GetResourceString("Arg_HTCapacityOverflow");
        /// <summary>All indexes must be of type Int32.</summary>
        internal static string @Arg_IndexMustBeInt => GetResourceString("Arg_IndexMustBeInt");
        /// <summary>Index was outside the bounds of the array.</summary>
        internal static string @Arg_IndexOutOfRangeException => GetResourceString("Arg_IndexOutOfRangeException");
        /// <summary>Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.</summary>
        internal static string @Arg_InsufficientExecutionStackException => GetResourceString("Arg_InsufficientExecutionStackException");
        /// <summary>The ANSI string passed in could not be converted from the default ANSI code page to Unicode.</summary>
        internal static string @Arg_InvalidANSIString => GetResourceString("Arg_InvalidANSIString");
        /// <summary>Invalid Base.</summary>
        internal static string @Arg_InvalidBase => GetResourceString("Arg_InvalidBase");
        /// <summary>Specified cast is not valid.</summary>
        internal static string @Arg_InvalidCastException => GetResourceString("Arg_InvalidCastException");
        /// <summary>Attempt has been made to use a COM object that does not have a backing class factory.</summary>
        internal static string @Arg_InvalidComObjectException => GetResourceString("Arg_InvalidComObjectException");
        /// <summary>Specified filter criteria was invalid.</summary>
        internal static string @Arg_InvalidFilterCriteriaException => GetResourceString("Arg_InvalidFilterCriteriaException");
        /// <summary>Invalid handle.</summary>
        internal static string @Arg_InvalidHandle => GetResourceString("Arg_InvalidHandle");
        /// <summary>With the AllowHexSpecifier or AllowBinarySpecifier bit set in the enum bit field, the only other valid bits that can be combined into the enum value must be AllowLeadingWhite and AllowTrailingWhite.</summary>
        internal static string @Arg_InvalidHexBinaryStyle => GetResourceString("Arg_InvalidHexBinaryStyle");
        /// <summary>The NeutralResourcesLanguageAttribute on the assembly "{0}" specifies an invalid culture name: "{1}".</summary>
        internal static string @Arg_InvalidNeutralResourcesLanguage_Asm_Culture => GetResourceString("Arg_InvalidNeutralResourcesLanguage_Asm_Culture");
        /// <summary>The NeutralResourcesLanguageAttribute specifies an invalid or unrecognized ultimate resource fallback location: "{0}".</summary>
        internal static string @Arg_InvalidNeutralResourcesLanguage_FallbackLoc => GetResourceString("Arg_InvalidNeutralResourcesLanguage_FallbackLoc");
        /// <summary>Satellite contract version attribute on the assembly '{0}' specifies an invalid version: {1}.</summary>
        internal static string @Arg_InvalidSatelliteContract_Asm_Ver => GetResourceString("Arg_InvalidSatelliteContract_Asm_Ver");
        /// <summary>Specified OLE variant was invalid.</summary>
        internal static string @Arg_InvalidOleVariantTypeException => GetResourceString("Arg_InvalidOleVariantTypeException");
        /// <summary>Operation is not valid due to the current state of the object.</summary>
        internal static string @Arg_InvalidOperationException => GetResourceString("Arg_InvalidOperationException");
        /// <summary>The return Type must be a type provided by the runtime.</summary>
        internal static string @Arg_InvalidTypeInRetType => GetResourceString("Arg_InvalidTypeInRetType");
        /// <summary>The signature Type array contains some invalid type (i.e. null, void)</summary>
        internal static string @Arg_InvalidTypeInSignature => GetResourceString("Arg_InvalidTypeInSignature");
        /// <summary>The UTF-8 string passed in could not be converted to Unicode.</summary>
        internal static string @Arg_InvalidUTF8String => GetResourceString("Arg_InvalidUTF8String");
        /// <summary>I/O error occurred.</summary>
        internal static string @Arg_IOException => GetResourceString("Arg_IOException");
        /// <summary>The given key was not present in the dictionary.</summary>
        internal static string @Arg_KeyNotFound => GetResourceString("Arg_KeyNotFound");
        /// <summary>The given key '{0}' was not present in the dictionary.</summary>
        internal static string @Arg_KeyNotFoundWithKey => GetResourceString("Arg_KeyNotFoundWithKey");
        /// <summary>Destination array was not long enough. Check the destination index, length, and the array's lower bounds.</summary>
        internal static string @Arg_LongerThanDestArray => GetResourceString("Arg_LongerThanDestArray");
        /// <summary>Source array was not long enough. Check the source index, length, and the array's lower bounds.</summary>
        internal static string @Arg_LongerThanSrcArray => GetResourceString("Arg_LongerThanSrcArray");
        /// <summary>Source string was not long enough. Check sourceIndex and count.</summary>
        internal static string @Arg_LongerThanSrcString => GetResourceString("Arg_LongerThanSrcString");
        /// <summary>The arrays' lower bounds must be identical.</summary>
        internal static string @Arg_LowerBoundsMustMatch => GetResourceString("Arg_LowerBoundsMustMatch");
        /// <summary>AsAny cannot be used on return types, ByRef parameters, ArrayWithOffset, or parameters passed from unmanaged to managed.</summary>
        internal static string @Arg_MarshalAsAnyRestriction => GetResourceString("Arg_MarshalAsAnyRestriction");
        /// <summary>Marshaling directives are invalid.</summary>
        internal static string @Arg_MarshalDirectiveException => GetResourceString("Arg_MarshalDirectiveException");
        /// <summary>Attempt to access the method failed.</summary>
        internal static string @Arg_MethodAccessException => GetResourceString("Arg_MethodAccessException");
        /// <summary>Attempted to access a non-existing field.</summary>
        internal static string @Arg_MissingFieldException => GetResourceString("Arg_MissingFieldException");
        /// <summary>Unable to find manifest resource.</summary>
        internal static string @Arg_MissingManifestResourceException => GetResourceString("Arg_MissingManifestResourceException");
        /// <summary>Attempted to access a missing member.</summary>
        internal static string @Arg_MissingMemberException => GetResourceString("Arg_MissingMemberException");
        /// <summary>Attempted to access a missing method.</summary>
        internal static string @Arg_MissingMethodException => GetResourceString("Arg_MissingMethodException");
        /// <summary>Attempted to add multiple callbacks to a delegate that does not support multicast.</summary>
        internal static string @Arg_MulticastNotSupportedException => GetResourceString("Arg_MulticastNotSupportedException");
        /// <summary>Object must be of type Boolean.</summary>
        internal static string @Arg_MustBeBoolean => GetResourceString("Arg_MustBeBoolean");
        /// <summary>Object must be of type Byte.</summary>
        internal static string @Arg_MustBeByte => GetResourceString("Arg_MustBeByte");
        /// <summary>Object must be of type Char.</summary>
        internal static string @Arg_MustBeChar => GetResourceString("Arg_MustBeChar");
        /// <summary>Object must be of type DateOnly.</summary>
        internal static string @Arg_MustBeDateOnly => GetResourceString("Arg_MustBeDateOnly");
        /// <summary>Object must be of type TimeOnly.</summary>
        internal static string @Arg_MustBeTimeOnly => GetResourceString("Arg_MustBeTimeOnly");
        /// <summary>Object must be of type DateTime.</summary>
        internal static string @Arg_MustBeDateTime => GetResourceString("Arg_MustBeDateTime");
        /// <summary>Object must be of type DateTimeOffset.</summary>
        internal static string @Arg_MustBeDateTimeOffset => GetResourceString("Arg_MustBeDateTimeOffset");
        /// <summary>Object must be of type Decimal.</summary>
        internal static string @Arg_MustBeDecimal => GetResourceString("Arg_MustBeDecimal");
        /// <summary>Type must derive from Delegate.</summary>
        internal static string @Arg_MustBeDelegate => GetResourceString("Arg_MustBeDelegate");
        /// <summary>Object must be of type Double.</summary>
        internal static string @Arg_MustBeDouble => GetResourceString("Arg_MustBeDouble");
        /// <summary>Drive name must be a root directory (i.e. 'C:\') or a drive letter ('C').</summary>
        internal static string @Arg_MustBeDriveLetterOrRootDir => GetResourceString("Arg_MustBeDriveLetterOrRootDir");
        /// <summary>Type provided must be an Enum.</summary>
        internal static string @Arg_MustBeEnum => GetResourceString("Arg_MustBeEnum");
        /// <summary>The value passed in must be an enum base or an underlying type for an enum, such as an Int32.</summary>
        internal static string @Arg_MustBeEnumBaseTypeOrEnum => GetResourceString("Arg_MustBeEnumBaseTypeOrEnum");
        /// <summary>Object must be of type GUID.</summary>
        internal static string @Arg_MustBeGuid => GetResourceString("Arg_MustBeGuid");
        /// <summary>Object must be of type Int16.</summary>
        internal static string @Arg_MustBeInt16 => GetResourceString("Arg_MustBeInt16");
        /// <summary>Object must be of type Int32.</summary>
        internal static string @Arg_MustBeInt32 => GetResourceString("Arg_MustBeInt32");
        /// <summary>Object must be of type Int64.</summary>
        internal static string @Arg_MustBeInt64 => GetResourceString("Arg_MustBeInt64");
        /// <summary>Object must be of type Int128.</summary>
        internal static string @Arg_MustBeInt128 => GetResourceString("Arg_MustBeInt128");
        /// <summary>Object must be of type IntPtr.</summary>
        internal static string @Arg_MustBeIntPtr => GetResourceString("Arg_MustBeIntPtr");
        /// <summary>Type passed must be an interface.</summary>
        internal static string @Arg_MustBeInterface => GetResourceString("Arg_MustBeInterface");
        /// <summary>Object must be of type NFloat.</summary>
        internal static string @Arg_MustBeNFloat => GetResourceString("Arg_MustBeNFloat");
        /// <summary>Type must be a Pointer.</summary>
        internal static string @Arg_MustBePointer => GetResourceString("Arg_MustBePointer");
        /// <summary>Object must be an array of primitives.</summary>
        internal static string @Arg_MustBePrimArray => GetResourceString("Arg_MustBePrimArray");
        /// <summary>Object must be of type RuntimeAssembly.</summary>
        internal static string @Arg_MustBeRuntimeAssembly => GetResourceString("Arg_MustBeRuntimeAssembly");
        /// <summary>Object must be of type SByte.</summary>
        internal static string @Arg_MustBeSByte => GetResourceString("Arg_MustBeSByte");
        /// <summary>Object must be of type Single.</summary>
        internal static string @Arg_MustBeSingle => GetResourceString("Arg_MustBeSingle");
        /// <summary>Object must be of type String.</summary>
        internal static string @Arg_MustBeString => GetResourceString("Arg_MustBeString");
        /// <summary>Object must be of type TimeSpan.</summary>
        internal static string @Arg_MustBeTimeSpan => GetResourceString("Arg_MustBeTimeSpan");
        /// <summary>Type must be a type provided by the runtime.</summary>
        internal static string @Arg_MustBeType => GetResourceString("Arg_MustBeType");
        /// <summary>Argument must be true.</summary>
        internal static string @Arg_MustBeTrue => GetResourceString("Arg_MustBeTrue");
        /// <summary>Object must be of type UInt16.</summary>
        internal static string @Arg_MustBeUInt16 => GetResourceString("Arg_MustBeUInt16");
        /// <summary>Object must be of type UInt32.</summary>
        internal static string @Arg_MustBeUInt32 => GetResourceString("Arg_MustBeUInt32");
        /// <summary>Object must be of type UInt64.</summary>
        internal static string @Arg_MustBeUInt64 => GetResourceString("Arg_MustBeUInt64");
        /// <summary>Object must be of type UInt128.</summary>
        internal static string @Arg_MustBeUInt128 => GetResourceString("Arg_MustBeUInt128");
        /// <summary>Object must be of type UIntPtr.</summary>
        internal static string @Arg_MustBeUIntPtr => GetResourceString("Arg_MustBeUIntPtr");
        /// <summary>Object must be of type Version.</summary>
        internal static string @Arg_MustBeVersion => GetResourceString("Arg_MustBeVersion");
        /// <summary>Must specify valid information for parsing in the string.</summary>
        internal static string @Arg_MustContainEnumInfo => GetResourceString("Arg_MustContainEnumInfo");
        /// <summary>Named parameter value must not be null.</summary>
        internal static string @Arg_NamedParamNull => GetResourceString("Arg_NamedParamNull");
        /// <summary>Named parameter array cannot be bigger than argument array.</summary>
        internal static string @Arg_NamedParamTooBig => GetResourceString("Arg_NamedParamTooBig");
        /// <summary>No PInvoke conversion exists for value passed to Object-typed parameter.</summary>
        internal static string @Arg_NDirectBadObject => GetResourceString("Arg_NDirectBadObject");
        /// <summary>Array was not a one-dimensional array.</summary>
        internal static string @Arg_Need1DArray => GetResourceString("Arg_Need1DArray");
        /// <summary>Array was not a two-dimensional array.</summary>
        internal static string @Arg_Need2DArray => GetResourceString("Arg_Need2DArray");
        /// <summary>Array was not a three-dimensional array.</summary>
        internal static string @Arg_Need3DArray => GetResourceString("Arg_Need3DArray");
        /// <summary>Must provide at least one rank.</summary>
        internal static string @Arg_NeedAtLeast1Rank => GetResourceString("Arg_NeedAtLeast1Rank");
        /// <summary>Argument count must not be negative.</summary>
        internal static string @Arg_NegativeArgCount => GetResourceString("Arg_NegativeArgCount");
        /// <summary>Must specify binding flags describing the invoke operation required (BindingFlags.InvokeMethod CreateInstance GetField SetField GetProperty SetProperty).</summary>
        internal static string @Arg_NoAccessSpec => GetResourceString("Arg_NoAccessSpec");
        /// <summary>No parameterless constructor defined.</summary>
        internal static string @Arg_NoDefCTorWithoutTypeName => GetResourceString("Arg_NoDefCTorWithoutTypeName");
        /// <summary>No parameterless constructor defined for type '{0}'.</summary>
        internal static string @Arg_NoDefCTor => GetResourceString("Arg_NoDefCTor");
        /// <summary>The lower bound of target array must be zero.</summary>
        internal static string @Arg_NonZeroLowerBound => GetResourceString("Arg_NonZeroLowerBound");
        /// <summary>Method cannot be both static and virtual.</summary>
        internal static string @Arg_NoStaticVirtual => GetResourceString("Arg_NoStaticVirtual");
        /// <summary>Number encountered was not a finite quantity.</summary>
        internal static string @Arg_NotFiniteNumberException => GetResourceString("Arg_NotFiniteNumberException");
        /// <summary>Interface not found.</summary>
        internal static string @Arg_NotFoundIFace => GetResourceString("Arg_NotFoundIFace");
        /// <summary>{0} is not a GenericMethodDefinition. MakeGenericMethod may only be called on a method for which MethodBase.IsGenericMethodDefinition is true.</summary>
        internal static string @Arg_NotGenericMethodDefinition => GetResourceString("Arg_NotGenericMethodDefinition");
        /// <summary>Method may only be called on a Type for which Type.IsGenericParameter is true.</summary>
        internal static string @Arg_NotGenericParameter => GetResourceString("Arg_NotGenericParameter");
        /// <summary>{0} is not a GenericTypeDefinition. MakeGenericType may only be called on a type for which Type.IsGenericTypeDefinition is true.</summary>
        internal static string @Arg_NotGenericTypeDefinition => GetResourceString("Arg_NotGenericTypeDefinition");
        /// <summary>The method or operation is not implemented.</summary>
        internal static string @Arg_NotImplementedException => GetResourceString("Arg_NotImplementedException");
        /// <summary>Specified method is not supported.</summary>
        internal static string @Arg_NotSupportedException => GetResourceString("Arg_NotSupportedException");
        /// <summary>Object reference not set to an instance of an object.</summary>
        internal static string @Arg_NullReferenceException => GetResourceString("Arg_NullReferenceException");
        /// <summary>Object type cannot be converted to target type.</summary>
        internal static string @Arg_ObjObj => GetResourceString("Arg_ObjObj");
        /// <summary>Object of type '{0}' cannot be converted to type '{1}'.</summary>
        internal static string @Arg_ObjObjEx => GetResourceString("Arg_ObjObjEx");
        /// <summary>Not a legal OleAut date.</summary>
        internal static string @Arg_OleAutDateInvalid => GetResourceString("Arg_OleAutDateInvalid");
        /// <summary>OleAut date did not convert to a DateTime correctly.</summary>
        internal static string @Arg_OleAutDateScale => GetResourceString("Arg_OleAutDateScale");
        /// <summary>Arithmetic operation resulted in an overflow.</summary>
        internal static string @Arg_OverflowException => GetResourceString("Arg_OverflowException");
        /// <summary>Insufficient memory to continue the execution of the program.</summary>
        internal static string @Arg_OutOfMemoryException => GetResourceString("Arg_OutOfMemoryException");
        /// <summary>(Parameter '{0}')</summary>
        internal static string @Arg_ParamName_Name => GetResourceString("Arg_ParamName_Name");
        /// <summary>Must specify one or more parameters.</summary>
        internal static string @Arg_ParmArraySize => GetResourceString("Arg_ParmArraySize");
        /// <summary>Parameter count mismatch.</summary>
        internal static string @Arg_ParmCnt => GetResourceString("Arg_ParmCnt");
        /// <summary>The path is empty.</summary>
        internal static string @Arg_PathEmpty => GetResourceString("Arg_PathEmpty");
        /// <summary>Operation is not supported on this platform.</summary>
        internal static string @Arg_PlatformNotSupported => GetResourceString("Arg_PlatformNotSupported");
        /// <summary>Cannot widen from source type to target type either because the source type is a not a primitive type or the conversion cannot be accomplished.</summary>
        internal static string @Arg_PrimWiden => GetResourceString("Arg_PrimWiden");
        /// <summary>Cannot specify both Get and Set on a property.</summary>
        internal static string @Arg_PropSetGet => GetResourceString("Arg_PropSetGet");
        /// <summary>Cannot specify Set on a property and Invoke on a method.</summary>
        internal static string @Arg_PropSetInvoke => GetResourceString("Arg_PropSetInvoke");
        /// <summary>Attempted to operate on an array with the incorrect number of dimensions.</summary>
        internal static string @Arg_RankException => GetResourceString("Arg_RankException");
        /// <summary>Indices length does not match the array rank.</summary>
        internal static string @Arg_RankIndices => GetResourceString("Arg_RankIndices");
        /// <summary>Only single dimensional arrays are supported for the requested action.</summary>
        internal static string @Arg_RankMultiDimNotSupported => GetResourceString("Arg_RankMultiDimNotSupported");
        /// <summary>Number of lengths and lowerBounds must match.</summary>
        internal static string @Arg_RanksAndBounds => GetResourceString("Arg_RanksAndBounds");
        /// <summary>RegistryKey.GetValue does not support values with more than Int32.MaxValue bytes.</summary>
        internal static string @Arg_RegValueTooLarge => GetResourceString("Arg_RegValueTooLarge");
        /// <summary>The specified registry key does not exist.</summary>
        internal static string @Arg_RegKeyNotFound => GetResourceString("Arg_RegKeyNotFound");
        /// <summary>No value exists with that name.</summary>
        internal static string @Arg_RegSubKeyValueAbsent => GetResourceString("Arg_RegSubKeyValueAbsent");
        /// <summary>Registry value names should not be greater than 16,383 characters.</summary>
        internal static string @Arg_RegValStrLenBug => GetResourceString("Arg_RegValStrLenBug");
        /// <summary>Type parameter must refer to a subclass of ResourceSet.</summary>
        internal static string @Arg_ResMgrNotResSet => GetResourceString("Arg_ResMgrNotResSet");
        /// <summary>The ResourceReader class does not know how to read this version of .resources files. Expected version: {0}  This file: {1}</summary>
        internal static string @Arg_ResourceFileUnsupportedVersion => GetResourceString("Arg_ResourceFileUnsupportedVersion");
        /// <summary>The specified resource name "{0}" does not exist in the resource file.</summary>
        internal static string @Arg_ResourceNameNotExist => GetResourceString("Arg_ResourceNameNotExist");
        /// <summary>Specified array was not of the expected rank.</summary>
        internal static string @Arg_SafeArrayRankMismatchException => GetResourceString("Arg_SafeArrayRankMismatchException");
        /// <summary>Specified array was not of the expected type.</summary>
        internal static string @Arg_SafeArrayTypeMismatchException => GetResourceString("Arg_SafeArrayTypeMismatchException");
        /// <summary>Security error.</summary>
        internal static string @Arg_SecurityException => GetResourceString("Arg_SecurityException");
        /// <summary>Serialization error.</summary>
        internal static string @SerializationException => GetResourceString("SerializationException");
        /// <summary>Property set method not found.</summary>
        internal static string @Arg_SetMethNotFnd => GetResourceString("Arg_SetMethNotFnd");
        /// <summary>Operation caused a stack overflow.</summary>
        internal static string @Arg_StackOverflowException => GetResourceString("Arg_StackOverflowException");
        /// <summary>Unicode surrogate characters must be written out as pairs together in the same call, not individually. Consider passing in a character array instead.</summary>
        internal static string @Arg_SurrogatesNotAllowedAsSingleChar => GetResourceString("Arg_SurrogatesNotAllowedAsSingleChar");
        /// <summary>Object synchronization method was called from an unsynchronized block of code.</summary>
        internal static string @Arg_SynchronizationLockException => GetResourceString("Arg_SynchronizationLockException");
        /// <summary>System error.</summary>
        internal static string @Arg_SystemException => GetResourceString("Arg_SystemException");
        /// <summary>Exception has been thrown by the target of an invocation.</summary>
        internal static string @Arg_TargetInvocationException => GetResourceString("Arg_TargetInvocationException");
        /// <summary>Number of parameters specified does not match the expected number.</summary>
        internal static string @Arg_TargetParameterCountException => GetResourceString("Arg_TargetParameterCountException");
        /// <summary>Thread failed to start.</summary>
        internal static string @Arg_ThreadStartException => GetResourceString("Arg_ThreadStartException");
        /// <summary>Thread was in an invalid state for the operation being executed.</summary>
        internal static string @Arg_ThreadStateException => GetResourceString("Arg_ThreadStateException");
        /// <summary>The operation has timed out.</summary>
        internal static string @Arg_TimeoutException => GetResourceString("Arg_TimeoutException");
        /// <summary>Attempt to access the type failed.</summary>
        internal static string @Arg_TypeAccessException => GetResourceString("Arg_TypeAccessException");
        /// <summary>The TypedReference must be initialized.</summary>
        internal static string @Arg_TypedReference_Null => GetResourceString("Arg_TypedReference_Null");
        /// <summary>Failure has occurred while loading a type.</summary>
        internal static string @Arg_TypeLoadException => GetResourceString("Arg_TypeLoadException");
        /// <summary>A null or zero length string does not represent a valid Type.</summary>
        internal static string @Arg_TypeLoadNullStr => GetResourceString("Arg_TypeLoadNullStr");
        /// <summary>TypedReferences cannot be redefined as primitives. Field name '{0}'.</summary>
        internal static string @Arg_TypeRefPrimitive => GetResourceString("Arg_TypeRefPrimitive");
        /// <summary>Type had been unloaded.</summary>
        internal static string @Arg_TypeUnloadedException => GetResourceString("Arg_TypeUnloadedException");
        /// <summary>Attempted to perform an unauthorized operation.</summary>
        internal static string @Arg_UnauthorizedAccessException => GetResourceString("Arg_UnauthorizedAccessException");
        /// <summary>Late bound operations cannot be performed on fields with types for which Type.ContainsGenericParameters is true.</summary>
        internal static string @Arg_UnboundGenField => GetResourceString("Arg_UnboundGenField");
        /// <summary>Late bound operations cannot be performed on types or methods for which ContainsGenericParameters is true.</summary>
        internal static string @Arg_UnboundGenParam => GetResourceString("Arg_UnboundGenParam");
        /// <summary>Unknown TypeCode value.</summary>
        internal static string @Arg_UnknownTypeCode => GetResourceString("Arg_UnknownTypeCode");
        /// <summary>The program executed an instruction that was thought to be unreachable.</summary>
        internal static string @Arg_UnreachableException => GetResourceString("Arg_UnreachableException");
        /// <summary>Missing parameter does not have a default value.</summary>
        internal static string @Arg_VarMissNull => GetResourceString("Arg_VarMissNull");
        /// <summary>Version string portion was too short or too long.</summary>
        internal static string @Arg_VersionString => GetResourceString("Arg_VersionString");
        /// <summary>The value "{0}" is not of type "{1}" and cannot be used in this generic collection.</summary>
        internal static string @Arg_WrongType => GetResourceString("Arg_WrongType");
        /// <summary>Path "{0}" is not an absolute path.</summary>
        internal static string @Argument_AbsolutePathRequired => GetResourceString("Argument_AbsolutePathRequired");
        /// <summary>An item with the same key has already been added.</summary>
        internal static string @Argument_AddingDuplicate => GetResourceString("Argument_AddingDuplicate");
        /// <summary>Item has already been added. Key in dictionary: '{0}'  Key being added: '{1}'</summary>
        internal static string @Argument_AddingDuplicate__ => GetResourceString("Argument_AddingDuplicate__");
        /// <summary>An item with the same key has already been added. Key: {0}</summary>
        internal static string @Argument_AddingDuplicateWithKey => GetResourceString("Argument_AddingDuplicateWithKey");
        /// <summary>The AdjustmentRule array cannot contain null elements.</summary>
        internal static string @Argument_AdjustmentRulesNoNulls => GetResourceString("Argument_AdjustmentRulesNoNulls");
        /// <summary>The elements of the AdjustmentRule array must be in chronological order and must not overlap.</summary>
        internal static string @Argument_AdjustmentRulesOutOfOrder => GetResourceString("Argument_AdjustmentRulesOutOfOrder");
        /// <summary>The alignment must be a power of two.</summary>
        internal static string @Argument_AlignmentMustBePow2 => GetResourceString("Argument_AlignmentMustBePow2");
        /// <summary>The object already has a CCW associated with it.</summary>
        internal static string @Argument_AlreadyACCW => GetResourceString("Argument_AlreadyACCW");
        /// <summary>'handle' has already been bound to the thread pool, or was not opened for asynchronous I/O.</summary>
        internal static string @Argument_AlreadyBoundOrSyncHandle => GetResourceString("Argument_AlreadyBoundOrSyncHandle");
        /// <summary>Interface maps for generic interfaces on arrays cannot be retrieved.</summary>
        internal static string @Argument_ArrayGetInterfaceMap => GetResourceString("Argument_ArrayGetInterfaceMap");
        /// <summary>Array or pointer types are not valid.</summary>
        internal static string @Argument_ArraysInvalid => GetResourceString("Argument_ArraysInvalid");
        /// <summary>Error parsing array spec.</summary>
        internal static string @Argument_ArrayParsingError => GetResourceString("Argument_ArrayParsingError");
        /// <summary>Attribute names must be unique.</summary>
        internal static string @Argument_AttributeNamesMustBeUnique => GetResourceString("Argument_AttributeNamesMustBeUnique");
        /// <summary>Bad default value.</summary>
        internal static string @Argument_BadConstantValue => GetResourceString("Argument_BadConstantValue");
        /// <summary>Cannot have private or static constructor.</summary>
        internal static string @Argument_BadConstructor => GetResourceString("Argument_BadConstructor");
        /// <summary>Constructor must have standard calling convention.</summary>
        internal static string @Argument_BadConstructorCallConv => GetResourceString("Argument_BadConstructorCallConv");
        /// <summary>Incorrect code generation for exception block.</summary>
        internal static string @Argument_BadExceptionCodeGen => GetResourceString("Argument_BadExceptionCodeGen");
        /// <summary>Field must be on the same type of the given ConstructorInfo.</summary>
        internal static string @Argument_BadFieldForConstructorBuilder => GetResourceString("Argument_BadFieldForConstructorBuilder");
        /// <summary>Field signatures do not have return types.</summary>
        internal static string @Argument_BadFieldSig => GetResourceString("Argument_BadFieldSig");
        /// <summary>Bad field type in defining field.</summary>
        internal static string @Argument_BadFieldType => GetResourceString("Argument_BadFieldType");
        /// <summary>Format specifier was invalid.</summary>
        internal static string @Argument_BadFormatSpecifier => GetResourceString("Argument_BadFormatSpecifier");
        /// <summary>A BadImageFormatException has been thrown while parsing the signature. This is likely due to lack of a generic context. Ensure genericTypeArguments and genericMethodArguments are provided and contain enough context.</summary>
        internal static string @Argument_BadImageFormatExceptionResolve => GetResourceString("Argument_BadImageFormatExceptionResolve");
        /// <summary>Bad label in ILGenerator.</summary>
        internal static string @Argument_BadLabel => GetResourceString("Argument_BadLabel");
        /// <summary>Bad label content in ILGenerator.</summary>
        internal static string @Argument_BadLabelContent => GetResourceString("Argument_BadLabelContent");
        /// <summary>Visibility of interfaces must be one of the following: NestedAssembly, NestedFamANDAssem, NestedFamily, NestedFamORAssem, NestedPrivate or NestedPublic.</summary>
        internal static string @Argument_BadNestedTypeFlags => GetResourceString("Argument_BadNestedTypeFlags");
        /// <summary>Invalid ObjRef provided to '{0}'.</summary>
        internal static string @Argument_BadObjRef => GetResourceString("Argument_BadObjRef");
        /// <summary>Parameter count does not match passed in argument value count.</summary>
        internal static string @Argument_BadParameterCountsForConstructor => GetResourceString("Argument_BadParameterCountsForConstructor");
        /// <summary>Cannot emit a CustomAttribute with argument of type {0}.</summary>
        internal static string @Argument_BadParameterTypeForCAB => GetResourceString("Argument_BadParameterTypeForCAB");
        /// <summary>Property must be on the same type of the given ConstructorInfo.</summary>
        internal static string @Argument_BadPropertyForConstructorBuilder => GetResourceString("Argument_BadPropertyForConstructorBuilder");
        /// <summary>Incorrect signature format.</summary>
        internal static string @Argument_BadSigFormat => GetResourceString("Argument_BadSigFormat");
        /// <summary>Data size must be &gt; 1 and &lt; 0x3f0000</summary>
        internal static string @Argument_BadSizeForData => GetResourceString("Argument_BadSizeForData");
        /// <summary>Bad type attributes. Invalid layout attribute specified.</summary>
        internal static string @Argument_BadTypeAttrInvalidLayout => GetResourceString("Argument_BadTypeAttrInvalidLayout");
        /// <summary>Bad type attributes. Nested visibility flag set on a non-nested type.</summary>
        internal static string @Argument_BadTypeAttrNestedVisibilityOnNonNestedType => GetResourceString("Argument_BadTypeAttrNestedVisibilityOnNonNestedType");
        /// <summary>Bad type attributes. Non-nested visibility flag set on a nested type.</summary>
        internal static string @Argument_BadTypeAttrNonNestedVisibilityNestedType => GetResourceString("Argument_BadTypeAttrNonNestedVisibilityNestedType");
        /// <summary>Bad type attributes. Reserved bits set on the type.</summary>
        internal static string @Argument_BadTypeAttrReservedBitsSet => GetResourceString("Argument_BadTypeAttrReservedBitsSet");
        /// <summary>An invalid type was used as a custom attribute constructor argument, field or property.</summary>
        internal static string @Argument_BadTypeInCustomAttribute => GetResourceString("Argument_BadTypeInCustomAttribute");
        /// <summary>Byref qualifier must be the last one of a type.</summary>
        internal static string @Argument_ByrefQualifierMustBeLastOneOfAType => GetResourceString("Argument_ByrefQualifierMustBeLastOneOfAType");
        /// <summary>Cannot use function evaluation to create a TypedReference object.</summary>
        internal static string @Argument_CannotCreateTypedReference => GetResourceString("Argument_CannotCreateTypedReference");
        /// <summary>Cannot set parent to an interface.</summary>
        internal static string @Argument_CannotSetParentToInterface => GetResourceString("Argument_CannotSetParentToInterface");
        /// <summary>{0} is not a supported code page.</summary>
        internal static string @Argument_CodepageNotSupported => GetResourceString("Argument_CodepageNotSupported");
        /// <summary>CompareOption.Ordinal cannot be used with other options.</summary>
        internal static string @Argument_CompareOptionOrdinal => GetResourceString("Argument_CompareOptionOrdinal");
        /// <summary>The DateTimeStyles value RoundtripKind cannot be used with the values AssumeLocal, AssumeUniversal or AdjustToUniversal.</summary>
        internal static string @Argument_ConflictingDateTimeRoundtripStyles => GetResourceString("Argument_ConflictingDateTimeRoundtripStyles");
        /// <summary>The DateTimeStyles values AssumeLocal and AssumeUniversal cannot be used together.</summary>
        internal static string @Argument_ConflictingDateTimeStyles => GetResourceString("Argument_ConflictingDateTimeStyles");
        /// <summary>Constant does not match the defined type.</summary>
        internal static string @Argument_ConstantDoesntMatch => GetResourceString("Argument_ConstantDoesntMatch");
        /// <summary>{0} is not a supported constant type.</summary>
        internal static string @Argument_ConstantNotSupported => GetResourceString("Argument_ConstantNotSupported");
        /// <summary>Null is not a valid constant value for this type.</summary>
        internal static string @Argument_ConstantNull => GetResourceString("Argument_ConstantNull");
        /// <summary>The specified constructor must be declared on a generic type definition.</summary>
        internal static string @Argument_ConstructorNeedGenericDeclaringType => GetResourceString("Argument_ConstructorNeedGenericDeclaringType");
        /// <summary>Conversion buffer overflow.</summary>
        internal static string @Argument_ConversionOverflow => GetResourceString("Argument_ConversionOverflow");
        /// <summary>The conversion could not be completed because the supplied DateTime did not have the Kind property set correctly.  For example, when the Kind property is DateTimeKind.Local, the source time zone must be TimeZoneInfo.Local.</summary>
        internal static string @Argument_ConvertMismatch => GetResourceString("Argument_ConvertMismatch");
        /// <summary>Cannot find the method on the object instance.</summary>
        internal static string @Argument_CORDBBadMethod => GetResourceString("Argument_CORDBBadMethod");
        /// <summary>Cannot evaluate a VarArgs function.</summary>
        internal static string @Argument_CORDBBadVarArgCallConv => GetResourceString("Argument_CORDBBadVarArgCallConv");
        /// <summary>Culture IETF Name {0} is not a recognized IETF name.</summary>
        internal static string @Argument_CultureIetfNotSupported => GetResourceString("Argument_CultureIetfNotSupported");
        /// <summary>{0} is an invalid culture identifier.</summary>
        internal static string @Argument_CultureInvalidIdentifier => GetResourceString("Argument_CultureInvalidIdentifier");
        /// <summary>Culture ID {0} (0x{0:X4}) is a neutral culture; a region cannot be created from it.</summary>
        internal static string @Argument_CultureIsNeutral => GetResourceString("Argument_CultureIsNeutral");
        /// <summary>Culture is not supported.</summary>
        internal static string @Argument_CultureNotSupported => GetResourceString("Argument_CultureNotSupported");
        /// <summary>Only the invariant culture is supported in globalization-invariant mode. See https://aka.ms/GlobalizationInvariantMode for more information.</summary>
        internal static string @Argument_CultureNotSupportedInInvariantMode => GetResourceString("Argument_CultureNotSupportedInInvariantMode");
        /// <summary>Resolved assembly's simple name should be the same as of the requested assembly.</summary>
        internal static string @Argument_CustomAssemblyLoadContextRequestedNameMismatch => GetResourceString("Argument_CustomAssemblyLoadContextRequestedNameMismatch");
        /// <summary>Customized cultures cannot be passed by LCID, only by name.</summary>
        internal static string @Argument_CustomCultureCannotBePassedByNumber => GetResourceString("Argument_CustomCultureCannotBePassedByNumber");
        /// <summary>Custom modifiers length '{0}' does not match the size of the arguments.</summary>
        internal static string @Argument_CustomModifierLengthInvalidLength => GetResourceString("Argument_CustomModifierLengthInvalidLength");
        /// <summary>The binary data must result in a DateTime with ticks between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
        internal static string @Argument_DateTimeBadBinaryData => GetResourceString("Argument_DateTimeBadBinaryData");
        /// <summary>The supplied DateTime must have the Year, Month, and Day properties set to 1.  The time cannot be specified more precisely than whole milliseconds.</summary>
        internal static string @Argument_DateTimeHasTicks => GetResourceString("Argument_DateTimeHasTicks");
        /// <summary>The supplied DateTime includes a TimeOfDay setting.   This is not supported.</summary>
        internal static string @Argument_DateTimeHasTimeOfDay => GetResourceString("Argument_DateTimeHasTimeOfDay");
        /// <summary>The supplied DateTime represents an invalid time.  For example, when the clock is adjusted forward, any time in the period that is skipped is invalid.</summary>
        internal static string @Argument_DateTimeIsInvalid => GetResourceString("Argument_DateTimeIsInvalid");
        /// <summary>The supplied DateTime is not in an ambiguous time range.</summary>
        internal static string @Argument_DateTimeIsNotAmbiguous => GetResourceString("Argument_DateTimeIsNotAmbiguous");
        /// <summary>The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified.</summary>
        internal static string @Argument_DateTimeKindMustBeUnspecified => GetResourceString("Argument_DateTimeKindMustBeUnspecified");
        /// <summary>The supplied DateTime must have the Kind property set to DateTimeKind.Unspecified or DateTimeKind.Utc.</summary>
        internal static string @Argument_DateTimeKindMustBeUnspecifiedOrUtc => GetResourceString("Argument_DateTimeKindMustBeUnspecifiedOrUtc");
        /// <summary>The DateTimeStyles value 'NoCurrentDateDefault' is not allowed when parsing DateTimeOffset.</summary>
        internal static string @Argument_DateTimeOffsetInvalidDateTimeStyles => GetResourceString("Argument_DateTimeOffsetInvalidDateTimeStyles");
        /// <summary>The supplied DateTimeOffset is not in an ambiguous time range.</summary>
        internal static string @Argument_DateTimeOffsetIsNotAmbiguous => GetResourceString("Argument_DateTimeOffsetIsNotAmbiguous");
        /// <summary>Destination is too short.</summary>
        internal static string @Argument_DestinationTooShort => GetResourceString("Argument_DestinationTooShort");
        /// <summary>Duplicate type name within an assembly.</summary>
        internal static string @Argument_DuplicateTypeName => GetResourceString("Argument_DuplicateTypeName");
        /// <summary>EmitWriteLine does not support this field or local type.</summary>
        internal static string @Argument_EmitWriteLineType => GetResourceString("Argument_EmitWriteLineType");
        /// <summary>Empty file name is not legal.</summary>
        internal static string @Argument_EmptyFileName => GetResourceString("Argument_EmptyFileName");
        /// <summary>Empty name is not legal.</summary>
        internal static string @Argument_EmptyName => GetResourceString("Argument_EmptyName");
        /// <summary>Waithandle array may not be empty.</summary>
        internal static string @Argument_EmptyWaithandleArray => GetResourceString("Argument_EmptyWaithandleArray");
        /// <summary>Must complete Convert() operation or call Encoder.Reset() before calling GetBytes() or GetByteCount(). Encoder '{0}' fallback '{1}'.</summary>
        internal static string @Argument_EncoderFallbackNotEmpty => GetResourceString("Argument_EncoderFallbackNotEmpty");
        /// <summary>The output byte buffer is too small to contain the encoded data, encoding codepage '{0}' and fallback '{1}'.</summary>
        internal static string @Argument_EncodingConversionOverflowBytes => GetResourceString("Argument_EncodingConversionOverflowBytes");
        /// <summary>The output char buffer is too small to contain the decoded characters, encoding codepage '{0}' and fallback '{1}'.</summary>
        internal static string @Argument_EncodingConversionOverflowChars => GetResourceString("Argument_EncodingConversionOverflowChars");
        /// <summary>'{0}' is not a supported encoding name. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.</summary>
        internal static string @Argument_EncodingNotSupported => GetResourceString("Argument_EncodingNotSupported");
        /// <summary>The argument type, '{0}', is not the same as the enum type '{1}'.</summary>
        internal static string @Argument_EnumTypeDoesNotMatch => GetResourceString("Argument_EnumTypeDoesNotMatch");
        /// <summary>Cannot change fallback when buffer is not empty. Previous Convert() call left data in the fallback buffer.</summary>
        internal static string @Argument_FallbackBufferNotEmpty => GetResourceString("Argument_FallbackBufferNotEmpty");
        /// <summary>Cannot resolve field {0} because the declaring type of the field handle {1} is generic. Explicitly provide the declaring type to GetFieldFromHandle.</summary>
        internal static string @Argument_FieldDeclaringTypeGeneric => GetResourceString("Argument_FieldDeclaringTypeGeneric");
        /// <summary>Field '{0}' does not belong to the same class as the constructor.</summary>
        internal static string @Argument_FieldDoesNotBelongToConstructorClass => GetResourceString("Argument_FieldDoesNotBelongToConstructorClass");
        /// <summary>Field '{0}' does not have a valid type.</summary>
        internal static string @Argument_FieldDoesNotHaveAValidType => GetResourceString("Argument_FieldDoesNotHaveAValidType");
        /// <summary>Field '{0}' does not have a valid value.</summary>
        internal static string @Argument_FieldDoesNotHaveAValidValue => GetResourceString("Argument_FieldDoesNotHaveAValidValue");
        /// <summary>The field, property or event handle and the type handle are incompatible.</summary>
        internal static string @Argument_FieldPropertyEventAndTypeHandleIncompatibility => GetResourceString("Argument_FieldPropertyEventAndTypeHandleIncompatibility");
        /// <summary>The specified field must be declared on a generic type definition.</summary>
        internal static string @Argument_FieldNeedGenericDeclaringType => GetResourceString("Argument_FieldNeedGenericDeclaringType");
        /// <summary>GenericArguments[{0}], '{1}', on '{2}' violates the constraint of type '{3}'.</summary>
        internal static string @Argument_GenConstraintViolation => GetResourceString("Argument_GenConstraintViolation");
        /// <summary>The number of generic arguments provided doesn't equal the arity of the generic type definition.</summary>
        internal static string @Argument_GenericArgsCount => GetResourceString("Argument_GenericArgsCount");
        /// <summary>Generic argument can't be a byref or pointer type.</summary>
        internal static string @Argument_GenericArgumentCannotBeByrefOrPointerType => GetResourceString("Argument_GenericArgumentCannotBeByrefOrPointerType");
        /// <summary>Generic types are not valid.</summary>
        internal static string @Argument_GenericsInvalid => GetResourceString("Argument_GenericsInvalid");
        /// <summary>Error parsing generic params spec.</summary>
        internal static string @Argument_GenericParsingError => GetResourceString("Argument_GenericParsingError");
        /// <summary>Open generic type not permitted.</summary>
        internal static string @Argument_OpenGenericTypeNotPermitted => GetResourceString("Argument_OpenGenericTypeNotPermitted");
        /// <summary>Global members must be static.</summary>
        internal static string @Argument_GlobalMembersMustBeStatic => GetResourceString("Argument_GlobalMembersMustBeStatic");
        /// <summary>Must be an array type.</summary>
        internal static string @Argument_HasToBeArrayClass => GetResourceString("Argument_HasToBeArrayClass");
        /// <summary>Left to right characters may not be mixed with right to left characters in IDN labels.</summary>
        internal static string @Argument_IdnBadBidi => GetResourceString("Argument_IdnBadBidi");
        /// <summary>IDN labels must be between 1 and 63 characters long.</summary>
        internal static string @Argument_IdnBadLabelSize => GetResourceString("Argument_IdnBadLabelSize");
        /// <summary>IDN names must be between 1 and {0} characters long.</summary>
        internal static string @Argument_IdnBadNameSize => GetResourceString("Argument_IdnBadNameSize");
        /// <summary>Invalid IDN encoded string.</summary>
        internal static string @Argument_IdnBadPunycode => GetResourceString("Argument_IdnBadPunycode");
        /// <summary>Label contains character '{0}' not allowed with UseStd3AsciiRules</summary>
        internal static string @Argument_IdnBadStd3 => GetResourceString("Argument_IdnBadStd3");
        /// <summary>Decoded string is not a valid IDN name.</summary>
        internal static string @Argument_IdnIllegalName => GetResourceString("Argument_IdnIllegalName");
        /// <summary>Environment variable name cannot contain equal character.</summary>
        internal static string @Argument_IllegalEnvVarName => GetResourceString("Argument_IllegalEnvVarName");
        /// <summary>Illegal name.</summary>
        internal static string @Argument_IllegalName => GetResourceString("Argument_IllegalName");
        /// <summary>At least one object must implement IComparable.</summary>
        internal static string @Argument_ImplementIComparable => GetResourceString("Argument_ImplementIComparable");
        /// <summary>The specified index is out of bounds of the specified array.</summary>
        internal static string @Argument_IndexOutOfArrayBounds => GetResourceString("Argument_IndexOutOfArrayBounds");
        /// <summary>'this' type cannot be an interface itself.</summary>
        internal static string @Argument_InterfaceMap => GetResourceString("Argument_InterfaceMap");
        /// <summary>Append access can be requested only in write-only mode.</summary>
        internal static string @Argument_InvalidAppendMode => GetResourceString("Argument_InvalidAppendMode");
        /// <summary>Preallocation size can be requested only in write mode.</summary>
        internal static string @Argument_InvalidPreallocateAccess => GetResourceString("Argument_InvalidPreallocateAccess");
        /// <summary>Preallocation size can be requested only for new files.</summary>
        internal static string @Argument_InvalidPreallocateMode => GetResourceString("Argument_InvalidPreallocateMode");
        /// <summary>UnixCreateMode can be requested only for modes that can create new files.</summary>
        internal static string @Argument_InvalidUnixCreateMode => GetResourceString("Argument_InvalidUnixCreateMode");
        /// <summary>Type of argument is not compatible with the generic comparer.</summary>
        internal static string @Argument_InvalidArgumentForComparison => GetResourceString("Argument_InvalidArgumentForComparison");
        /// <summary>Length of the array must be {0}.</summary>
        internal static string @Argument_InvalidArrayLength => GetResourceString("Argument_InvalidArrayLength");
        /// <summary>Invalid array spec, multi-dimensional array cannot be bound.</summary>
        internal static string @Argument_MultiDimensionalArrayCannotBeBound => GetResourceString("Argument_MultiDimensionalArrayCannotBeBound");
        /// <summary>Target array type is not compatible with the type of items in the collection.</summary>
        internal static string @Argument_IncompatibleArrayType => GetResourceString("Argument_IncompatibleArrayType");
        /// <summary>Invalid array/generic spec.</summary>
        internal static string @Argument_InvalidArrayType => GetResourceString("Argument_InvalidArrayType");
        /// <summary>The given assembly name was invalid.</summary>
        internal static string @InvalidAssemblyName => GetResourceString("InvalidAssemblyName");
        /// <summary>Not a valid calendar for the given culture.</summary>
        internal static string @Argument_InvalidCalendar => GetResourceString("Argument_InvalidCalendar");
        /// <summary>"Invalid character in array spec: '{0}'.</summary>
        internal static string @Argument_InvalidCharInArraySpecification => GetResourceString("Argument_InvalidCharInArraySpecification");
        /// <summary>Invalid Unicode code point found at index {0}.</summary>
        internal static string @Argument_InvalidCharSequence => GetResourceString("Argument_InvalidCharSequence");
        /// <summary>String contains invalid Unicode code points.</summary>
        internal static string @Argument_InvalidCharSequenceNoIndex => GetResourceString("Argument_InvalidCharSequenceNoIndex");
        /// <summary>Unable to translate bytes {0} at index {1} from specified code page to Unicode.</summary>
        internal static string @Argument_InvalidCodePageBytesIndex => GetResourceString("Argument_InvalidCodePageBytesIndex");
        /// <summary>Unable to translate Unicode character \\u{0:X4} at index {1} to specified code page.</summary>
        internal static string @Argument_InvalidCodePageConversionIndex => GetResourceString("Argument_InvalidCodePageConversionIndex");
        /// <summary>The specified constructor must be declared on the generic type definition of the specified type.</summary>
        internal static string @Argument_InvalidConstructorDeclaringType => GetResourceString("Argument_InvalidConstructorDeclaringType");
        /// <summary>The ConstructorInfo object is not valid.</summary>
        internal static string @Argument_InvalidConstructorInfo => GetResourceString("Argument_InvalidConstructorInfo");
        /// <summary>Culture name '{0}' is not supported.</summary>
        internal static string @Argument_InvalidCultureName => GetResourceString("Argument_InvalidCultureName");
        /// <summary>Culture name '{0}' is not a predefined culture.</summary>
        internal static string @Argument_InvalidPredefinedCultureName => GetResourceString("Argument_InvalidPredefinedCultureName");
        /// <summary>Invalid DateTimeKind value.</summary>
        internal static string @Argument_InvalidDateTimeKind => GetResourceString("Argument_InvalidDateTimeKind");
        /// <summary>An undefined DateTimeStyles value is being used.</summary>
        internal static string @Argument_InvalidDateTimeStyles => GetResourceString("Argument_InvalidDateTimeStyles");
        /// <summary>The only allowed values for the styles are AllowWhiteSpaces, AllowTrailingWhite, AllowLeadingWhite, and AllowInnerWhite.</summary>
        internal static string @Argument_InvalidDateStyles => GetResourceString("Argument_InvalidDateStyles");
        /// <summary>The DigitSubstitution property must be of a valid member of the DigitShapes enumeration. Valid entries include Context, NativeNational or None.</summary>
        internal static string @Argument_InvalidDigitSubstitution => GetResourceString("Argument_InvalidDigitSubstitution");
        /// <summary>Invalid element name '{0}'.</summary>
        internal static string @Argument_InvalidElementName => GetResourceString("Argument_InvalidElementName");
        /// <summary>Invalid element tag '{0}'.</summary>
        internal static string @Argument_InvalidElementTag => GetResourceString("Argument_InvalidElementTag");
        /// <summary>Invalid element text '{0}'.</summary>
        internal static string @Argument_InvalidElementText => GetResourceString("Argument_InvalidElementText");
        /// <summary>Invalid element value '{0}'.</summary>
        internal static string @Argument_InvalidElementValue => GetResourceString("Argument_InvalidElementValue");
        /// <summary>The Enum type should contain one and only one instance field.</summary>
        internal static string @Argument_InvalidEnum => GetResourceString("Argument_InvalidEnum");
        /// <summary>The value '{0}' is not valid for this usage of the type {1}.</summary>
        internal static string @Argument_InvalidEnumValue => GetResourceString("Argument_InvalidEnumValue");
        /// <summary>The specified field must be declared on the generic type definition of the specified type.</summary>
        internal static string @Argument_InvalidFieldDeclaringType => GetResourceString("Argument_InvalidFieldDeclaringType");
        /// <summary>Combining FileMode: {0} with FileAccess: {1} is invalid.</summary>
        internal static string @Argument_InvalidFileModeAndAccessCombo => GetResourceString("Argument_InvalidFileModeAndAccessCombo");
        /// <summary>Value of flags is invalid.</summary>
        internal static string @Argument_InvalidFlag => GetResourceString("Argument_InvalidFlag");
        /// <summary>The generic type parameter was not valid</summary>
        internal static string @Argument_InvalidGenericArg => GetResourceString("Argument_InvalidGenericArg");
        /// <summary>Invalid generic arguments separator '{0}'</summary>
        internal static string @Argument_InvalidGenericArgumentsSeparator => GetResourceString("Argument_InvalidGenericArgumentsSeparator");
        /// <summary>Generic arguments must be provided for each generic parameter and each generic argument must be a RuntimeType.</summary>
        internal static string @Argument_InvalidGenericInstArray => GetResourceString("Argument_InvalidGenericInstArray");
        /// <summary>Every element in the value array should be between one and nine, except for the last element, which can be zero.</summary>
        internal static string @Argument_InvalidGroupSize => GetResourceString("Argument_InvalidGroupSize");
        /// <summary>The handle is invalid.</summary>
        internal static string @Argument_InvalidHandle => GetResourceString("Argument_InvalidHandle");
        /// <summary>Found a high surrogate char without a following low surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.</summary>
        internal static string @Argument_InvalidHighSurrogate => GetResourceString("Argument_InvalidHighSurrogate");
        /// <summary>The specified ID parameter '{0}' is not supported.</summary>
        internal static string @Argument_InvalidId => GetResourceString("Argument_InvalidId");
        /// <summary>This type cannot be represented as a custom attribute.</summary>
        internal static string @Argument_InvalidKindOfTypeForCA => GetResourceString("Argument_InvalidKindOfTypeForCA");
        /// <summary>Invalid Label.</summary>
        internal static string @Argument_InvalidLabel => GetResourceString("Argument_InvalidLabel");
        /// <summary>Found a low surrogate char without a preceding high surrogate at index: {0}. The input may not be in this encoding, or may not contain valid Unicode (UTF-16) characters.</summary>
        internal static string @Argument_InvalidLowSurrogate => GetResourceString("Argument_InvalidLowSurrogate");
        /// <summary>The member must be either a field or a property.</summary>
        internal static string @Argument_InvalidMemberForNamedArgument => GetResourceString("Argument_InvalidMemberForNamedArgument");
        /// <summary>The specified method must be declared on the generic type definition of the specified type.</summary>
        internal static string @Argument_InvalidMethodDeclaringType => GetResourceString("Argument_InvalidMethodDeclaringType");
        /// <summary>Invalid name.</summary>
        internal static string @Argument_InvalidName => GetResourceString("Argument_InvalidName");
        /// <summary>The NativeDigits array must contain exactly ten members.</summary>
        internal static string @Argument_InvalidNativeDigitCount => GetResourceString("Argument_InvalidNativeDigitCount");
        /// <summary>Each member of the NativeDigits array must be a single text element (one or more UTF-16 code points) with a Unicode Nd (Number, Decimal Digit) property indicating it is a digit.</summary>
        internal static string @Argument_InvalidNativeDigitValue => GetResourceString("Argument_InvalidNativeDigitValue");
        /// <summary>The region name {0} should not correspond to neutral culture; a specific culture name is required.</summary>
        internal static string @Argument_InvalidNeutralRegionName => GetResourceString("Argument_InvalidNeutralRegionName");
        /// <summary>Invalid or unsupported normalization form.</summary>
        internal static string @Argument_InvalidNormalizationForm => GetResourceString("Argument_InvalidNormalizationForm");
        /// <summary>An undefined NumberStyles value is being used.</summary>
        internal static string @Argument_InvalidNumberStyles => GetResourceString("Argument_InvalidNumberStyles");
        /// <summary>Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection.</summary>
        internal static string @Argument_InvalidOffLen => GetResourceString("Argument_InvalidOffLen");
        /// <summary>Ldtoken, Ldftn and Ldvirtftn OpCodes cannot target DynamicMethods.</summary>
        internal static string @Argument_InvalidOpCodeOnDynamicMethod => GetResourceString("Argument_InvalidOpCodeOnDynamicMethod");
        /// <summary>The ParameterInfo object is not valid.</summary>
        internal static string @Argument_InvalidParameterInfo => GetResourceString("Argument_InvalidParameterInfo");
        /// <summary>Invalid type for ParameterInfo member in Attribute class.</summary>
        internal static string @Argument_InvalidParamInfo => GetResourceString("Argument_InvalidParamInfo");
        /// <summary>Null character in path.</summary>
        internal static string @Argument_NullCharInPath => GetResourceString("Argument_NullCharInPath");
        /// <summary>The given culture name '{0}' cannot be used to locate a resource file. Resource filenames must consist of only letters, numbers, hyphens or underscores.</summary>
        internal static string @Argument_InvalidResourceCultureName => GetResourceString("Argument_InvalidResourceCultureName");
        /// <summary>Offset and length were greater than the size of the SafeBuffer.</summary>
        internal static string @Argument_InvalidSafeBufferOffLen => GetResourceString("Argument_InvalidSafeBufferOffLen");
        /// <summary>Invalid seek origin.</summary>
        internal static string @Argument_InvalidSeekOrigin => GetResourceString("Argument_InvalidSeekOrigin");
        /// <summary>The specified serialized string '{0}' is not supported.</summary>
        internal static string @Argument_InvalidSerializedString => GetResourceString("Argument_InvalidSerializedString");
        /// <summary>The signature of the startup hook '{0}' in assembly '{1}' was invalid. It must be 'public static void Initialize()'.</summary>
        internal static string @Argument_InvalidStartupHookSignature => GetResourceString("Argument_InvalidStartupHookSignature");
        /// <summary>An undefined TimeSpanStyles value is being used.</summary>
        internal static string @Argument_InvalidTimeSpanStyles => GetResourceString("Argument_InvalidTimeSpanStyles");
        /// <summary>Token {0:x} is not valid in the scope of module {1}.</summary>
        internal static string @Argument_InvalidToken => GetResourceString("Argument_InvalidToken");
        /// <summary>Cannot build type parameter for custom attribute with a type that does not support the AssemblyQualifiedName property. The type instance supplied was of type '{0}'.</summary>
        internal static string @Argument_InvalidTypeForCA => GetResourceString("Argument_InvalidTypeForCA");
        /// <summary>Invalid type owner for DynamicMethod.</summary>
        internal static string @Argument_InvalidTypeForDynamicMethod => GetResourceString("Argument_InvalidTypeForDynamicMethod");
        /// <summary>The name of the type is invalid.</summary>
        internal static string @Argument_InvalidTypeName => GetResourceString("Argument_InvalidTypeName");
        /// <summary>Cannot use type '{0}'. Only value types without pointers or references are supported.</summary>
        internal static string @Argument_InvalidTypeWithPointersNotSupported => GetResourceString("Argument_InvalidTypeWithPointersNotSupported");
        /// <summary>Type '{0}' is not deserializable.</summary>
        internal static string @Argument_InvalidUnity => GetResourceString("Argument_InvalidUnity");
        /// <summary>Value was invalid.</summary>
        internal static string @Argument_InvalidValue => GetResourceString("Argument_InvalidValue");
        /// <summary>Integer or token was too large to be encoded.</summary>
        internal static string @Argument_LargeInteger => GetResourceString("Argument_LargeInteger");
        /// <summary>Label #{0} is not marked in method '{1}'.</summary>
        internal static string @Argument_LabelUnmarked => GetResourceString("Argument_LabelUnmarked");
        /// <summary>Environment variable name or value is too long.</summary>
        internal static string @Argument_LongEnvVarValue => GetResourceString("Argument_LongEnvVarValue");
        /// <summary>Method body must belong to this type.</summary>
        internal static string @Argument_MethodBodyMustBelongToType => GetResourceString("Argument_MethodBodyMustBelongToType");
        /// <summary>Cannot resolve method {0} because the declaring type of the method handle {1} is generic. Explicitly provide the declaring type to GetMethodFromHandle.</summary>
        internal static string @Argument_MethodDeclaringTypeGeneric => GetResourceString("Argument_MethodDeclaringTypeGeneric");
        /// <summary>Method '{0}' has a generic declaring type '{1}'. Explicitly provide the declaring type to GetTokenFor.</summary>
        internal static string @Argument_MethodDeclaringTypeGenericLcg => GetResourceString("Argument_MethodDeclaringTypeGenericLcg");
        /// <summary>The specified method cannot be dynamic or global and must be declared on a generic type definition.</summary>
        internal static string @Argument_MethodNeedGenericDeclaringType => GetResourceString("Argument_MethodNeedGenericDeclaringType");
        /// <summary>'{0}' cannot be greater than {1}.</summary>
        internal static string @Argument_MinMaxValue => GetResourceString("Argument_MinMaxValue");
        /// <summary>Two arrays, {0} and {1}, must be of  the same size.</summary>
        internal static string @Argument_MismatchedArrays => GetResourceString("Argument_MismatchedArrays");
        /// <summary>Argument must be initialized to false</summary>
        internal static string @Argument_MustBeFalse => GetResourceString("Argument_MustBeFalse");
        /// <summary>Assembly must be a runtime Assembly object.</summary>
        internal static string @Argument_MustBeRuntimeAssembly => GetResourceString("Argument_MustBeRuntimeAssembly");
        /// <summary>FieldInfo must be a runtime FieldInfo object.</summary>
        internal static string @Argument_MustBeRuntimeFieldInfo => GetResourceString("Argument_MustBeRuntimeFieldInfo");
        /// <summary>ConstructorInfo must be a runtime ConstructorInfo object.</summary>
        internal static string @Argument_MustBeRuntimeConstructorInfo => GetResourceString("Argument_MustBeRuntimeConstructorInfo");
        /// <summary>MethodInfo must be a runtime MethodInfo object.</summary>
        internal static string @Argument_MustBeRuntimeMethodInfo => GetResourceString("Argument_MustBeRuntimeMethodInfo");
        /// <summary>Method must be a runtime MethodInfo, ConstructorInfo or DynamicMethod object.</summary>
        internal static string @Argument_MustBeRuntimeMethod => GetResourceString("Argument_MustBeRuntimeMethod");
        /// <summary>Type must be a runtime Type object.</summary>
        internal static string @Argument_MustBeRuntimeType => GetResourceString("Argument_MustBeRuntimeType");
        /// <summary>'type' must be or must contain a TypeBuilder as a generic argument.</summary>
        internal static string @Argument_MustBeTypeBuilder => GetResourceString("Argument_MustBeTypeBuilder");
        /// <summary>Type passed in must be derived from System.Attribute or System.Attribute itself.</summary>
        internal static string @Argument_MustHaveAttributeBaseClass => GetResourceString("Argument_MustHaveAttributeBaseClass");
        /// <summary>The specified structure must be blittable or have layout information.</summary>
        internal static string @Argument_MustHaveLayoutOrBeBlittable => GetResourceString("Argument_MustHaveLayoutOrBeBlittable");
        /// <summary>'overlapped' has already been freed.</summary>
        internal static string @Argument_NativeOverlappedAlreadyFree => GetResourceString("Argument_NativeOverlappedAlreadyFree");
        /// <summary>'overlapped' was not allocated by this ThreadPoolBoundHandle instance.</summary>
        internal static string @Argument_NativeOverlappedWrongBoundHandle => GetResourceString("Argument_NativeOverlappedWrongBoundHandle");
        /// <summary>Method must represent a generic method definition on a generic type definition.</summary>
        internal static string @Argument_NeedGenericMethodDefinition => GetResourceString("Argument_NeedGenericMethodDefinition");
        /// <summary>The specified object must not be an instance of a generic type.</summary>
        internal static string @Argument_NeedNonGenericObject => GetResourceString("Argument_NeedNonGenericObject");
        /// <summary>The specified Type must not be a generic type.</summary>
        internal static string @Argument_NeedNonGenericType => GetResourceString("Argument_NeedNonGenericType");
        /// <summary>The specified Type must be a struct containing no references.</summary>
        internal static string @Argument_NeedStructWithNoRefs => GetResourceString("Argument_NeedStructWithNoRefs");
        /// <summary>Negative field offset is not allowed.</summary>
        internal static string @Argument_NegativeFieldOffsetNotPermitted => GetResourceString("Argument_NegativeFieldOffsetNotPermitted");
        /// <summary>The type '{0}' may not be used as a type argument.</summary>
        internal static string @Argument_NeverValidGenericArgument => GetResourceString("Argument_NeverValidGenericArgument");
        /// <summary>No Era was supplied.</summary>
        internal static string @Argument_NoEra => GetResourceString("Argument_NoEra");
        /// <summary>There is no region associated with the Invariant Culture (Culture ID: 0x7F).</summary>
        internal static string @Argument_NoRegionInvariantCulture => GetResourceString("Argument_NoRegionInvariantCulture");
        /// <summary>Not a writable property.</summary>
        internal static string @Argument_NotAWritableProperty => GetResourceString("Argument_NotAWritableProperty");
        /// <summary>There are not enough bytes remaining in the accessor to read at this position.</summary>
        internal static string @Argument_NotEnoughBytesToRead => GetResourceString("Argument_NotEnoughBytesToRead");
        /// <summary>There are not enough bytes remaining in the accessor to write at this position.</summary>
        internal static string @Argument_NotEnoughBytesToWrite => GetResourceString("Argument_NotEnoughBytesToWrite");
        /// <summary>The type or method has {1} generic parameter(s), but {0} generic argument(s) were provided. A generic argument must be provided for each generic parameter.</summary>
        internal static string @Argument_NotEnoughGenArguments => GetResourceString("Argument_NotEnoughGenArguments");
        /// <summary>Does not extend Exception.</summary>
        internal static string @Argument_NotExceptionType => GetResourceString("Argument_NotExceptionType");
        /// <summary>Not currently in an exception block.</summary>
        internal static string @Argument_NotInExceptionBlock => GetResourceString("Argument_NotInExceptionBlock");
        /// <summary>The specified opcode cannot be passed to EmitCall.</summary>
        internal static string @Argument_NotMethodCallOpcode => GetResourceString("Argument_NotMethodCallOpcode");
        /// <summary>Uninitialized Strings cannot be created.</summary>
        internal static string @Argument_NoUninitializedStrings => GetResourceString("Argument_NoUninitializedStrings");
        /// <summary>The object's type must be __ComObject or derived from __ComObject.</summary>
        internal static string @Argument_ObjNotComObject => GetResourceString("Argument_ObjNotComObject");
        /// <summary>Offset and capacity were greater than the size of the view.</summary>
        internal static string @Argument_OffsetAndCapacityOutOfBounds => GetResourceString("Argument_OffsetAndCapacityOutOfBounds");
        /// <summary>The UTC Offset of the local dateTime parameter does not match the offset argument.</summary>
        internal static string @Argument_OffsetLocalMismatch => GetResourceString("Argument_OffsetLocalMismatch");
        /// <summary>Field passed in is not a marshaled member of the type '{0}'.</summary>
        internal static string @Argument_OffsetOfFieldNotFound => GetResourceString("Argument_OffsetOfFieldNotFound");
        /// <summary>Offset must be within plus or minus 14 hours.</summary>
        internal static string @Argument_OffsetOutOfRange => GetResourceString("Argument_OffsetOutOfRange");
        /// <summary>Offset must be specified in whole minutes.</summary>
        internal static string @Argument_OffsetPrecision => GetResourceString("Argument_OffsetPrecision");
        /// <summary>The UTC Offset for Utc DateTime instances must be 0.</summary>
        internal static string @Argument_OffsetUtcMismatch => GetResourceString("Argument_OffsetUtcMismatch");
        /// <summary>Culture name {0} or {1} is not supported.</summary>
        internal static string @Argument_OneOfCulturesNotSupported => GetResourceString("Argument_OneOfCulturesNotSupported");
        /// <summary>Only mscorlib's assembly is valid.</summary>
        internal static string @Argument_OnlyMscorlib => GetResourceString("Argument_OnlyMscorlib");
        /// <summary>The DateStart property must come before the DateEnd property.</summary>
        internal static string @Argument_OutOfOrderDateTimes => GetResourceString("Argument_OutOfOrderDateTimes");
        /// <summary>Path cannot be the empty string or all whitespace.</summary>
        internal static string @Argument_PathEmpty => GetResourceString("Argument_PathEmpty");
        /// <summary>Value of argument {0} does not match parameter type: {1} -&gt; {2}.</summary>
        internal static string @Argument_ParameterHasUnmatchedArgumentValue => GetResourceString("Argument_ParameterHasUnmatchedArgumentValue");
        /// <summary>Parameter {0} does not have a valid type.</summary>
        internal static string @Argument_ParameterInvalidType => GetResourceString("Argument_ParameterInvalidType");
        /// <summary>Parameter {0} is not a valid value.</summary>
        internal static string @Argument_ParameterInvalidValue => GetResourceString("Argument_ParameterInvalidValue");
        /// <summary>Could not parse the type name.</summary>
        internal static string @Argument_TypeParseError => GetResourceString("Argument_TypeParseError");
        /// <summary>'preAllocated' is already in use.</summary>
        internal static string @Argument_PreAllocatedAlreadyAllocated => GetResourceString("Argument_PreAllocatedAlreadyAllocated");
        /// <summary>Recursive fallback not allowed for character \\u{0:X4}.</summary>
        internal static string @Argument_RecursiveFallback => GetResourceString("Argument_RecursiveFallback");
        /// <summary>Recursive fallback not allowed for bytes {0}.</summary>
        internal static string @Argument_RecursiveFallbackBytes => GetResourceString("Argument_RecursiveFallbackBytes");
        /// <summary>Label multiply defined.</summary>
        internal static string @Argument_RedefinedLabel => GetResourceString("Argument_RedefinedLabel");
        /// <summary>Token {0:x} is not a valid FieldInfo token in the scope of module {1}.</summary>
        internal static string @Argument_ResolveField => GetResourceString("Argument_ResolveField");
        /// <summary>Type handle '{0}' and field handle with declaring type '{1}' are incompatible. Get RuntimeFieldHandle and declaring RuntimeTypeHandle off the same FieldInfo.</summary>
        internal static string @Argument_ResolveFieldHandle => GetResourceString("Argument_ResolveFieldHandle");
        /// <summary>Token {0:x} is not a valid MemberInfo token in the scope of module {1}.</summary>
        internal static string @Argument_ResolveMember => GetResourceString("Argument_ResolveMember");
        /// <summary>Token {0:x} is not a valid MethodBase token in the scope of module {1}.</summary>
        internal static string @Argument_ResolveMethod => GetResourceString("Argument_ResolveMethod");
        /// <summary>Type handle '{0}' and method handle with declaring type '{1}' are incompatible. Get RuntimeMethodHandle and declaring RuntimeTypeHandle off the same MethodBase.</summary>
        internal static string @Argument_ResolveMethodHandle => GetResourceString("Argument_ResolveMethodHandle");
        /// <summary>Token {0} resolves to the special module type representing this module.</summary>
        internal static string @Argument_ResolveModuleType => GetResourceString("Argument_ResolveModuleType");
        /// <summary>Token {0:x} is not a valid string token in the scope of module {1}.</summary>
        internal static string @Argument_ResolveString => GetResourceString("Argument_ResolveString");
        /// <summary>Token {0:x} is not a valid Type token in the scope of module {1}.</summary>
        internal static string @Argument_ResolveType => GetResourceString("Argument_ResolveType");
        /// <summary>The result is out of the supported range for this calendar. The result should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.</summary>
        internal static string @Argument_ResultCalendarRange => GetResourceString("Argument_ResultCalendarRange");
        /// <summary>The initial count for the semaphore must be greater than or equal to zero and less than the maximum count.</summary>
        internal static string @Argument_SemaphoreInitialMaximum => GetResourceString("Argument_SemaphoreInitialMaximum");
        /// <summary>Should not specify exception type for catch clause for filter block.</summary>
        internal static string @Argument_ShouldNotSpecifyExceptionType => GetResourceString("Argument_ShouldNotSpecifyExceptionType");
        /// <summary>Should only set visibility flags when creating EnumBuilder.</summary>
        internal static string @Argument_ShouldOnlySetVisibilityFlags => GetResourceString("Argument_ShouldOnlySetVisibilityFlags");
        /// <summary>Completed signature cannot be modified.</summary>
        internal static string @Argument_SigIsFinalized => GetResourceString("Argument_SigIsFinalized");
        /// <summary>Stream was not readable.</summary>
        internal static string @Argument_StreamNotReadable => GetResourceString("Argument_StreamNotReadable");
        /// <summary>Stream was not writable.</summary>
        internal static string @Argument_StreamNotWritable => GetResourceString("Argument_StreamNotWritable");
        /// <summary>The first char in the string is the null character.</summary>
        internal static string @Argument_StringFirstCharIsZero => GetResourceString("Argument_StringFirstCharIsZero");
        /// <summary>The structure must not be a value class.</summary>
        internal static string @Argument_StructMustNotBeValueClass => GetResourceString("Argument_StructMustNotBeValueClass");
        /// <summary>The TimeSpan parameter cannot be specified more precisely than whole minutes.</summary>
        internal static string @Argument_TimeSpanHasSeconds => GetResourceString("Argument_TimeSpanHasSeconds");
        /// <summary>The tzfile does not begin with the magic characters 'TZif'.  Please verify that the file is not corrupt.</summary>
        internal static string @Argument_TimeZoneInfoBadTZif => GetResourceString("Argument_TimeZoneInfoBadTZif");
        /// <summary>The TZif data structure is corrupt.</summary>
        internal static string @Argument_TimeZoneInfoInvalidTZif => GetResourceString("Argument_TimeZoneInfoInvalidTZif");
        /// <summary>fromInclusive must be less than or equal to toExclusive.</summary>
        internal static string @Argument_ToExclusiveLessThanFromExclusive => GetResourceString("Argument_ToExclusiveLessThanFromExclusive");
        /// <summary>Exception blocks may have at most one finally clause.</summary>
        internal static string @Argument_TooManyFinallyClause => GetResourceString("Argument_TooManyFinallyClause");
        /// <summary>The DaylightTransitionStart property must not equal the DaylightTransitionEnd property.</summary>
        internal static string @Argument_TransitionTimesAreIdentical => GetResourceString("Argument_TransitionTimesAreIdentical");
        /// <summary>Field '{0}' in TypedReferences cannot be static.</summary>
        internal static string @Argument_TypedReferenceInvalidField => GetResourceString("Argument_TypedReferenceInvalidField");
        /// <summary>The specified type must be visible from COM.</summary>
        internal static string @Argument_TypeMustBeVisibleFromCom => GetResourceString("Argument_TypeMustBeVisibleFromCom");
        /// <summary>The type must not be imported from COM.</summary>
        internal static string @Argument_TypeMustNotBeComImport => GetResourceString("Argument_TypeMustNotBeComImport");
        /// <summary>Type name was too long. The fully qualified type name must be less than 1,024 characters.</summary>
        internal static string @Argument_TypeNameTooLong => GetResourceString("Argument_TypeNameTooLong");
        /// <summary>The type must be __ComObject or be derived from __ComObject.</summary>
        internal static string @Argument_TypeNotComObject => GetResourceString("Argument_TypeNotComObject");
        /// <summary>Unclosed assembly-qualified type name at '{0}'.</summary>
        internal static string @Argument_UnclosedAssemblyQualifiedTypeName => GetResourceString("Argument_UnclosedAssemblyQualifiedTypeName");
        /// <summary>The IL Generator cannot be used while there are unclosed exceptions.</summary>
        internal static string @Argument_UnclosedExceptionBlock => GetResourceString("Argument_UnclosedExceptionBlock");
        /// <summary>Unknown unmanaged calling convention for function signature.</summary>
        internal static string @Argument_UnknownUnmanagedCallConv => GetResourceString("Argument_UnknownUnmanagedCallConv");
        /// <summary>The UnmanagedMemoryAccessor capacity and offset would wrap around the high end of the address space.</summary>
        internal static string @Argument_UnmanagedMemAccessorWrapAround => GetResourceString("Argument_UnmanagedMemAccessorWrapAround");
        /// <summary>Specified unmanaged type is only valid on fields.</summary>
        internal static string @Argument_UnmanagedTypeOnlyValidOnFields => GetResourceString("Argument_UnmanagedTypeOnlyValidOnFields");
        /// <summary>Value of field '{0}' does not match field type '{1}'.</summary>
        internal static string @Argument_UnmatchedFieldValueAndType => GetResourceString("Argument_UnmatchedFieldValueAndType");
        /// <summary>Local passed in does not belong to this ILGenerator.</summary>
        internal static string @Argument_UnmatchedMethodForLocal => GetResourceString("Argument_UnmatchedMethodForLocal");
        /// <summary>Unmatched ']' while parsing generic argument assembly name.</summary>
        internal static string @Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName => GetResourceString("Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName");
        /// <summary>Non-matching symbol scope.</summary>
        internal static string @Argument_UnmatchingSymScope => GetResourceString("Argument_UnmatchingSymScope");
        /// <summary>The UTC time represented when the offset is applied must be between year 0 and 10,000.</summary>
        internal static string @Argument_UTCOutOfRange => GetResourceString("Argument_UTCOutOfRange");
        /// <summary>The length of the name exceeds the maximum limit.</summary>
        internal static string @Argument_WaitHandleNameTooLong => GetResourceString("Argument_WaitHandleNameTooLong");
        /// <summary>MethodOverride's body must be from this type.</summary>
        internal static string @ArgumentException_BadMethodImplBody => GetResourceString("ArgumentException_BadMethodImplBody");
        /// <summary>The buffer is not associated with this pool and may not be returned to it.</summary>
        internal static string @ArgumentException_BufferNotFromPool => GetResourceString("ArgumentException_BufferNotFromPool");
        /// <summary>The object is not an array with the same number of elements as the array to compare it to.</summary>
        internal static string @ArgumentException_OtherNotArrayOfCorrectLength => GetResourceString("ArgumentException_OtherNotArrayOfCorrectLength");
        /// <summary>Object contains references.</summary>
        internal static string @ArgumentException_NotIsomorphic => GetResourceString("ArgumentException_NotIsomorphic");
        /// <summary>Argument must be of type {0}.</summary>
        internal static string @ArgumentException_TupleIncorrectType => GetResourceString("ArgumentException_TupleIncorrectType");
        /// <summary>The last element of an eight element tuple must be a Tuple.</summary>
        internal static string @ArgumentException_TupleLastArgumentNotATuple => GetResourceString("ArgumentException_TupleLastArgumentNotATuple");
        /// <summary>Argument must be of type {0}.</summary>
        internal static string @ArgumentException_ValueTupleIncorrectType => GetResourceString("ArgumentException_ValueTupleIncorrectType");
        /// <summary>The last element of an eight element ValueTuple must be a ValueTuple.</summary>
        internal static string @ArgumentException_ValueTupleLastArgumentNotAValueTuple => GetResourceString("ArgumentException_ValueTupleLastArgumentNotAValueTuple");
        /// <summary>Array cannot be null.</summary>
        internal static string @ArgumentNull_Array => GetResourceString("ArgumentNull_Array");
        /// <summary>At least one element in the specified array was null.</summary>
        internal static string @ArgumentNull_ArrayElement => GetResourceString("ArgumentNull_ArrayElement");
        /// <summary>Found a null value within an array.</summary>
        internal static string @ArgumentNull_ArrayValue => GetResourceString("ArgumentNull_ArrayValue");
        /// <summary>Assembly cannot be null.</summary>
        internal static string @ArgumentNull_Assembly => GetResourceString("ArgumentNull_Assembly");
        /// <summary>AssemblyName cannot be null.</summary>
        internal static string @ArgumentNull_AssemblyName => GetResourceString("ArgumentNull_AssemblyName");
        /// <summary>AssemblyName.Name cannot be null or an empty string.</summary>
        internal static string @ArgumentNull_AssemblyNameName => GetResourceString("ArgumentNull_AssemblyNameName");
        /// <summary>Buffer cannot be null.</summary>
        internal static string @ArgumentNull_Buffer => GetResourceString("ArgumentNull_Buffer");
        /// <summary>Cannot have a null child.</summary>
        internal static string @ArgumentNull_Child => GetResourceString("ArgumentNull_Child");
        /// <summary>File name cannot be null.</summary>
        internal static string @ArgumentNull_FileName => GetResourceString("ArgumentNull_FileName");
        /// <summary>Value cannot be null.</summary>
        internal static string @ArgumentNull_Generic => GetResourceString("ArgumentNull_Generic");
        /// <summary>SafeHandle cannot be null.</summary>
        internal static string @ArgumentNull_SafeHandle => GetResourceString("ArgumentNull_SafeHandle");
        /// <summary>String reference not set to an instance of a String.</summary>
        internal static string @ArgumentNull_String => GetResourceString("ArgumentNull_String");
        /// <summary>Type cannot be null.</summary>
        internal static string @ArgumentNull_Type => GetResourceString("ArgumentNull_Type");
        /// <summary>Type in TypedReference cannot be null.</summary>
        internal static string @ArgumentNull_TypedRefType => GetResourceString("ArgumentNull_TypedRefType");
        /// <summary>Actual value was {0}.</summary>
        internal static string @ArgumentOutOfRange_ActualValue => GetResourceString("ArgumentOutOfRange_ActualValue");
        /// <summary>The number of bytes cannot exceed the virtual address space on a 32 bit machine.</summary>
        internal static string @ArgumentOutOfRange_AddressSpace => GetResourceString("ArgumentOutOfRange_AddressSpace");
        /// <summary>Value to add was out of range.</summary>
        internal static string @ArgumentOutOfRange_AddValue => GetResourceString("ArgumentOutOfRange_AddValue");
        /// <summary>Number was less than the array's lower bound in the first dimension.</summary>
        internal static string @ArgumentOutOfRange_ArrayLB => GetResourceString("ArgumentOutOfRange_ArrayLB");
        /// <summary>Higher indices will exceed Int32.MaxValue because of large lower bound and/or length.</summary>
        internal static string @ArgumentOutOfRange_ArrayLBAndLength => GetResourceString("ArgumentOutOfRange_ArrayLBAndLength");
        /// <summary>Hour, Minute, and Second parameters describe an un-representable DateTime.</summary>
        internal static string @ArgumentOutOfRange_BadHourMinuteSecond => GetResourceString("ArgumentOutOfRange_BadHourMinuteSecond");
        /// <summary>Year, Month, and Day parameters describe an un-representable DateTime.</summary>
        internal static string @ArgumentOutOfRange_BadYearMonthDay => GetResourceString("ArgumentOutOfRange_BadYearMonthDay");
        /// <summary>Larger than collection size.</summary>
        internal static string @ArgumentOutOfRange_BiggerThanCollection => GetResourceString("ArgumentOutOfRange_BiggerThanCollection");
        /// <summary>The number of bytes requested does not fit into BinaryReader's internal buffer.</summary>
        internal static string @ArgumentOutOfRange_BinaryReaderFillBuffer => GetResourceString("ArgumentOutOfRange_BinaryReaderFillBuffer");
        /// <summary>Argument must be between {0} and {1}.</summary>
        internal static string @ArgumentOutOfRange_Bounds_Lower_Upper => GetResourceString("ArgumentOutOfRange_Bounds_Lower_Upper");
        /// <summary>Specified time is not supported in this calendar. It should be between {0} (Gregorian date) and {1} (Gregorian date), inclusive.</summary>
        internal static string @ArgumentOutOfRange_CalendarRange => GetResourceString("ArgumentOutOfRange_CalendarRange");
        /// <summary>Capacity exceeds maximum capacity.</summary>
        internal static string @ArgumentOutOfRange_Capacity => GetResourceString("ArgumentOutOfRange_Capacity");
        /// <summary>Count must be positive and count must refer to a location within the string/array/collection.</summary>
        internal static string @ArgumentOutOfRange_Count => GetResourceString("ArgumentOutOfRange_Count");
        /// <summary>The added or subtracted value results in an un-representable DateTime.</summary>
        internal static string @ArgumentOutOfRange_DateArithmetic => GetResourceString("ArgumentOutOfRange_DateArithmetic");
        /// <summary>Months value must be between +/-120000.</summary>
        internal static string @ArgumentOutOfRange_DateTimeBadMonths => GetResourceString("ArgumentOutOfRange_DateTimeBadMonths");
        /// <summary>Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
        internal static string @ArgumentOutOfRange_DateTimeBadTicks => GetResourceString("ArgumentOutOfRange_DateTimeBadTicks");
        /// <summary>Ticks must be between 0 and and TimeOnly.MaxValue.Ticks.</summary>
        internal static string @ArgumentOutOfRange_TimeOnlyBadTicks => GetResourceString("ArgumentOutOfRange_TimeOnlyBadTicks");
        /// <summary>Years value must be between +/-10000.</summary>
        internal static string @ArgumentOutOfRange_DateTimeBadYears => GetResourceString("ArgumentOutOfRange_DateTimeBadYears");
        /// <summary>Day must be between 1 and {0} for month {1}.</summary>
        internal static string @ArgumentOutOfRange_Day => GetResourceString("ArgumentOutOfRange_Day");
        /// <summary>The DayOfWeek enumeration must be in the range 0 through 6.</summary>
        internal static string @ArgumentOutOfRange_DayOfWeek => GetResourceString("ArgumentOutOfRange_DayOfWeek");
        /// <summary>The Day parameter must be in the range 1 through 31.</summary>
        internal static string @ArgumentOutOfRange_DayParam => GetResourceString("ArgumentOutOfRange_DayParam");
        /// <summary>Decimal can only round to between 0 and 28 digits of precision.</summary>
        internal static string @ArgumentOutOfRange_DecimalRound => GetResourceString("ArgumentOutOfRange_DecimalRound");
        /// <summary>Decimal's scale value must be between 0 and 28, inclusive.</summary>
        internal static string @ArgumentOutOfRange_DecimalScale => GetResourceString("ArgumentOutOfRange_DecimalScale");
        /// <summary>endIndex cannot be greater than startIndex.</summary>
        internal static string @ArgumentOutOfRange_EndIndexStartIndex => GetResourceString("ArgumentOutOfRange_EndIndexStartIndex");
        /// <summary>Enum value was out of legal range.</summary>
        internal static string @ArgumentOutOfRange_Enum => GetResourceString("ArgumentOutOfRange_Enum");
        /// <summary>Time value was out of era range.</summary>
        internal static string @ArgumentOutOfRange_Era => GetResourceString("ArgumentOutOfRange_Era");
        /// <summary>Specified file length was too large for the file system.</summary>
        internal static string @ArgumentOutOfRange_FileLengthTooBig => GetResourceString("ArgumentOutOfRange_FileLengthTooBig");
        /// <summary>Not a valid Win32 FileTime.</summary>
        internal static string @ArgumentOutOfRange_FileTimeInvalid => GetResourceString("ArgumentOutOfRange_FileTimeInvalid");
        /// <summary>Too many characters. The resulting number of bytes is larger than what can be returned as an int.</summary>
        internal static string @ArgumentOutOfRange_GetByteCountOverflow => GetResourceString("ArgumentOutOfRange_GetByteCountOverflow");
        /// <summary>Too many bytes. The resulting number of chars is larger than what can be returned as an int.</summary>
        internal static string @ArgumentOutOfRange_GetCharCountOverflow => GetResourceString("ArgumentOutOfRange_GetCharCountOverflow");
        /// <summary>Load factor needs to be between 0.1 and 1.0.</summary>
        internal static string @ArgumentOutOfRange_HashtableLoadFactor => GetResourceString("ArgumentOutOfRange_HashtableLoadFactor");
        /// <summary>Arrays larger than 2GB are not supported.</summary>
        internal static string @ArgumentOutOfRange_HugeArrayNotSupported => GetResourceString("ArgumentOutOfRange_HugeArrayNotSupported");
        /// <summary>Index was out of range. Must be non-negative and less than the size of the collection.</summary>
        internal static string @ArgumentOutOfRange_IndexMustBeLess => GetResourceString("ArgumentOutOfRange_IndexMustBeLess");
        /// <summary>Index was out of range. Must be non-negative and less than or equal to the size of the collection.</summary>
        internal static string @ArgumentOutOfRange_IndexMustBeLessOrEqual => GetResourceString("ArgumentOutOfRange_IndexMustBeLessOrEqual");
        /// <summary>Index and count must refer to a location within the string.</summary>
        internal static string @ArgumentOutOfRange_IndexCount => GetResourceString("ArgumentOutOfRange_IndexCount");
        /// <summary>Index and count must refer to a location within the buffer.</summary>
        internal static string @ArgumentOutOfRange_IndexCountBuffer => GetResourceString("ArgumentOutOfRange_IndexCountBuffer");
        /// <summary>Index and length must refer to a location within the string.</summary>
        internal static string @ArgumentOutOfRange_IndexLength => GetResourceString("ArgumentOutOfRange_IndexLength");
        /// <summary>Index was out of range. Must be non-negative and less than the length of the string.</summary>
        internal static string @ArgumentOutOfRange_IndexString => GetResourceString("ArgumentOutOfRange_IndexString");
        /// <summary>Input is too large to be processed.</summary>
        internal static string @ArgumentOutOfRange_InputTooLarge => GetResourceString("ArgumentOutOfRange_InputTooLarge");
        /// <summary>Era value was not valid.</summary>
        internal static string @ArgumentOutOfRange_InvalidEraValue => GetResourceString("ArgumentOutOfRange_InvalidEraValue");
        /// <summary>A valid high surrogate character is between 0xd800 and 0xdbff, inclusive.</summary>
        internal static string @ArgumentOutOfRange_InvalidHighSurrogate => GetResourceString("ArgumentOutOfRange_InvalidHighSurrogate");
        /// <summary>A valid low surrogate character is between 0xdc00 and 0xdfff, inclusive.</summary>
        internal static string @ArgumentOutOfRange_InvalidLowSurrogate => GetResourceString("ArgumentOutOfRange_InvalidLowSurrogate");
        /// <summary>A valid UTF32 value is between 0x000000 and 0x10ffff, inclusive, and should not include surrogate codepoint values (0x00d800 ~ 0x00dfff).</summary>
        internal static string @ArgumentOutOfRange_InvalidUTF32 => GetResourceString("ArgumentOutOfRange_InvalidUTF32");
        /// <summary>The specified length exceeds maximum capacity of SecureString.</summary>
        internal static string @ArgumentOutOfRange_Length => GetResourceString("ArgumentOutOfRange_Length");
        /// <summary>The length cannot be greater than the capacity.</summary>
        internal static string @ArgumentOutOfRange_LengthGreaterThanCapacity => GetResourceString("ArgumentOutOfRange_LengthGreaterThanCapacity");
        /// <summary>The specified length exceeds the maximum value of {0}.</summary>
        internal static string @ArgumentOutOfRange_LengthTooLarge => GetResourceString("ArgumentOutOfRange_LengthTooLarge");
        /// <summary>Argument must be less than or equal to 2^31 - 1 milliseconds.</summary>
        internal static string @ArgumentOutOfRange_LessEqualToIntegerMaxVal => GetResourceString("ArgumentOutOfRange_LessEqualToIntegerMaxVal");
        /// <summary>Index must be within the bounds of the List.</summary>
        internal static string @ArgumentOutOfRange_ListInsert => GetResourceString("ArgumentOutOfRange_ListInsert");
        /// <summary>Month must be between one and twelve.</summary>
        internal static string @ArgumentOutOfRange_Month => GetResourceString("ArgumentOutOfRange_Month");
        /// <summary>Day number must be between 0 and DateOnly.MaxValue.DayNumber.</summary>
        internal static string @ArgumentOutOfRange_DayNumber => GetResourceString("ArgumentOutOfRange_DayNumber");
        /// <summary>The Month parameter must be in the range 1 through 12.</summary>
        internal static string @ArgumentOutOfRange_MonthParam => GetResourceString("ArgumentOutOfRange_MonthParam");
        /// <summary>Value must be non-negative and less than or equal to Int32.MaxValue.</summary>
        internal static string @ArgumentOutOfRange_MustBeNonNegInt32 => GetResourceString("ArgumentOutOfRange_MustBeNonNegInt32");
        /// <summary>'{0}' must be non-negative.</summary>
        internal static string @ArgumentOutOfRange_MustBeNonNegNum => GetResourceString("ArgumentOutOfRange_MustBeNonNegNum");
        /// <summary>'{0}' must be greater than zero.</summary>
        internal static string @ArgumentOutOfRange_MustBePositive => GetResourceString("ArgumentOutOfRange_MustBePositive");
        /// <summary>Non-negative number required.</summary>
        internal static string @ArgumentOutOfRange_NeedNonNegNum => GetResourceString("ArgumentOutOfRange_NeedNonNegNum");
        /// <summary>Number must be either non-negative and less than or equal to Int32.MaxValue or -1.</summary>
        internal static string @ArgumentOutOfRange_NeedNonNegOrNegative1 => GetResourceString("ArgumentOutOfRange_NeedNonNegOrNegative1");
        /// <summary>Positive number required.</summary>
        internal static string @ArgumentOutOfRange_NeedPosNum => GetResourceString("ArgumentOutOfRange_NeedPosNum");
        /// <summary>The ID parameter must be in the range {0} through {1}.</summary>
        internal static string @ArgumentOutOfRange_NeedValidId => GetResourceString("ArgumentOutOfRange_NeedValidId");
        /// <summary>Offset and length must refer to a position in the string.</summary>
        internal static string @ArgumentOutOfRange_OffsetLength => GetResourceString("ArgumentOutOfRange_OffsetLength");
        /// <summary>Either offset did not refer to a position in the string, or there is an insufficient length of destination character array.</summary>
        internal static string @ArgumentOutOfRange_OffsetOut => GetResourceString("ArgumentOutOfRange_OffsetOut");
        /// <summary>The specified parameter index is not in range.</summary>
        internal static string @ArgumentOutOfRange_ParamSequence => GetResourceString("ArgumentOutOfRange_ParamSequence");
        /// <summary>Pointer startIndex and length do not refer to a valid string.</summary>
        internal static string @ArgumentOutOfRange_PartialWCHAR => GetResourceString("ArgumentOutOfRange_PartialWCHAR");
        /// <summary>The position may not be greater or equal to the capacity of the accessor.</summary>
        internal static string @ArgumentOutOfRange_PositionLessThanCapacityRequired => GetResourceString("ArgumentOutOfRange_PositionLessThanCapacityRequired");
        /// <summary>Valid values are between {0} and {1}, inclusive.</summary>
        internal static string @ArgumentOutOfRange_Range => GetResourceString("ArgumentOutOfRange_Range");
        /// <summary>Rounding digits must be between 0 and 15, inclusive.</summary>
        internal static string @ArgumentOutOfRange_RoundingDigits => GetResourceString("ArgumentOutOfRange_RoundingDigits");
        /// <summary>Rounding digits must be between 0 and 6, inclusive.</summary>
        internal static string @ArgumentOutOfRange_RoundingDigits_MathF => GetResourceString("ArgumentOutOfRange_RoundingDigits_MathF");
        /// <summary>capacity was less than the current size.</summary>
        internal static string @ArgumentOutOfRange_SmallCapacity => GetResourceString("ArgumentOutOfRange_SmallCapacity");
        /// <summary>StartIndex cannot be less than zero.</summary>
        internal static string @ArgumentOutOfRange_StartIndex => GetResourceString("ArgumentOutOfRange_StartIndex");
        /// <summary>startIndex cannot be larger than length of string.</summary>
        internal static string @ArgumentOutOfRange_StartIndexLargerThanLength => GetResourceString("ArgumentOutOfRange_StartIndexLargerThanLength");
        /// <summary>Stream length must be non-negative and less than 2^31 - 1 - origin.</summary>
        internal static string @ArgumentOutOfRange_StreamLength => GetResourceString("ArgumentOutOfRange_StreamLength");
        /// <summary>The length of the buffer must be less than the maximum UIntPtr value for your platform.</summary>
        internal static string @ArgumentOutOfRange_UIntPtrMax => GetResourceString("ArgumentOutOfRange_UIntPtrMax");
        /// <summary>UnmanagedMemoryStream length must be non-negative and less than 2^63 - 1 - baseAddress.</summary>
        internal static string @ArgumentOutOfRange_UnmanagedMemStreamLength => GetResourceString("ArgumentOutOfRange_UnmanagedMemStreamLength");
        /// <summary>The UnmanagedMemoryStream capacity would wrap around the high end of the address space.</summary>
        internal static string @ArgumentOutOfRange_UnmanagedMemStreamWrapAround => GetResourceString("ArgumentOutOfRange_UnmanagedMemStreamWrapAround");
        /// <summary>The TimeSpan parameter must be within plus or minus 14.0 hours.</summary>
        internal static string @ArgumentOutOfRange_UtcOffset => GetResourceString("ArgumentOutOfRange_UtcOffset");
        /// <summary>The sum of the BaseUtcOffset and DaylightDelta properties must within plus or minus 14.0 hours.</summary>
        internal static string @ArgumentOutOfRange_UtcOffsetAndDaylightDelta => GetResourceString("ArgumentOutOfRange_UtcOffsetAndDaylightDelta");
        /// <summary>The Week parameter must be in the range 1 through 5.</summary>
        internal static string @ArgumentOutOfRange_Week => GetResourceString("ArgumentOutOfRange_Week");
        /// <summary>Year must be between 1 and 9999.</summary>
        internal static string @ArgumentOutOfRange_Year => GetResourceString("ArgumentOutOfRange_Year");
        /// <summary>{0} ('{1}') must be a non-zero value.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeNonZero => GetResourceString("ArgumentOutOfRange_Generic_MustBeNonZero");
        /// <summary>{0} ('{1}') must be a non-negative value.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeNonNegative => GetResourceString("ArgumentOutOfRange_Generic_MustBeNonNegative");
        /// <summary>{0} ('{1}') must be a non-negative and non-zero value.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeNonNegativeNonZero => GetResourceString("ArgumentOutOfRange_Generic_MustBeNonNegativeNonZero");
        /// <summary>{0} ('{1}') must be less than or equal to '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeLessOrEqual => GetResourceString("ArgumentOutOfRange_Generic_MustBeLessOrEqual");
        /// <summary>{0} ('{1}') must be less than '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeLess => GetResourceString("ArgumentOutOfRange_Generic_MustBeLess");
        /// <summary>{0} ('{1}') must be greater than or equal to '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeGreaterOrEqual => GetResourceString("ArgumentOutOfRange_Generic_MustBeGreaterOrEqual");
        /// <summary>{0} ('{1}') must be greater than '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeGreater => GetResourceString("ArgumentOutOfRange_Generic_MustBeGreater");
        /// <summary>{0} ('{1}') must be equal to '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeEqual => GetResourceString("ArgumentOutOfRange_Generic_MustBeEqual");
        /// <summary>{0} ('{1}') must not be equal to '{2}'.</summary>
        internal static string @ArgumentOutOfRange_Generic_MustBeNotEqual => GetResourceString("ArgumentOutOfRange_Generic_MustBeNotEqual");
        /// <summary>Function does not accept floating point Not-a-Number values.</summary>
        internal static string @Arithmetic_NaN => GetResourceString("Arithmetic_NaN");
        /// <summary>Source array type cannot be assigned to destination array type.</summary>
        internal static string @ArrayTypeMismatch_CantAssignType => GetResourceString("ArrayTypeMismatch_CantAssignType");
        /// <summary>Array.ConstrainedCopy will only work on array types that are provably compatible, without any form of boxing, unboxing, widening, or casting of each array element.  Change the array types (i.e., copy a Derived[] to a Base[]), or use a mitigation strategy i ...</summary>
        internal static string @ArrayTypeMismatch_ConstrainedCopy => GetResourceString("ArrayTypeMismatch_ConstrainedCopy");
        /// <summary>Cannot unload non-collectible AssemblyLoadContext.</summary>
        internal static string @AssemblyLoadContext_Unload_CannotUnloadIfNotCollectible => GetResourceString("AssemblyLoadContext_Unload_CannotUnloadIfNotCollectible");
        /// <summary>AssemblyLoadContext is unloading or was already unloaded.</summary>
        internal static string @AssemblyLoadContext_Verify_NotUnloading => GetResourceString("AssemblyLoadContext_Verify_NotUnloading");
        /// <summary>Assertion failed.</summary>
        internal static string @AssertionFailed => GetResourceString("AssertionFailed");
        /// <summary>Assertion failed: {0}</summary>
        internal static string @AssertionFailed_Cnd => GetResourceString("AssertionFailed_Cnd");
        /// <summary>Assumption failed.</summary>
        internal static string @AssumptionFailed => GetResourceString("AssumptionFailed");
        /// <summary>Assumption failed: {0}</summary>
        internal static string @AssumptionFailed_Cnd => GetResourceString("AssumptionFailed_Cnd");
        /// <summary>The builder was not properly initialized.</summary>
        internal static string @AsyncMethodBuilder_InstanceNotInitialized => GetResourceString("AsyncMethodBuilder_InstanceNotInitialized");
        /// <summary>Bad IL format.</summary>
        internal static string @BadImageFormat_BadILFormat => GetResourceString("BadImageFormat_BadILFormat");
        /// <summary>Corrupt .resources file.  The specified type doesn't exist.</summary>
        internal static string @BadImageFormat_InvalidType => GetResourceString("BadImageFormat_InvalidType");
        /// <summary>Corrupt .resources file. String length must be non-negative.</summary>
        internal static string @BadImageFormat_NegativeStringLength => GetResourceString("BadImageFormat_NegativeStringLength");
        /// <summary>The parameters and the signature of the method don't match.</summary>
        internal static string @BadImageFormat_ParameterSignatureMismatch => GetResourceString("BadImageFormat_ParameterSignatureMismatch");
        /// <summary>The type serialized in the .resources file was not the same type that the .resources file said it contained. Expected '{0}' but read '{1}'.</summary>
        internal static string @BadImageFormat_ResType_SerBlobMismatch => GetResourceString("BadImageFormat_ResType_SerBlobMismatch");
        /// <summary>Corrupt .resources file.  The specified data length '{0}' is not a valid position in the stream.</summary>
        internal static string @BadImageFormat_ResourceDataLengthInvalid => GetResourceString("BadImageFormat_ResourceDataLengthInvalid");
        /// <summary>Corrupt .resources file. A resource name extends past the end of the stream.</summary>
        internal static string @BadImageFormat_ResourceNameCorrupted => GetResourceString("BadImageFormat_ResourceNameCorrupted");
        /// <summary>Corrupt .resources file. The resource name for name index {0} extends past the end of the stream.</summary>
        internal static string @BadImageFormat_ResourceNameCorrupted_NameIndex => GetResourceString("BadImageFormat_ResourceNameCorrupted_NameIndex");
        /// <summary>Corrupt .resources file. Invalid offset '{0}' into data section.</summary>
        internal static string @BadImageFormat_ResourcesDataInvalidOffset => GetResourceString("BadImageFormat_ResourcesDataInvalidOffset");
        /// <summary>Corrupt .resources file. Unable to read resources from this file because of invalid header information. Try regenerating the .resources file.</summary>
        internal static string @BadImageFormat_ResourcesHeaderCorrupted => GetResourceString("BadImageFormat_ResourcesHeaderCorrupted");
        /// <summary>Corrupt .resources file. String for name index '{0}' extends past the end of the file.</summary>
        internal static string @BadImageFormat_ResourcesIndexTooLong => GetResourceString("BadImageFormat_ResourcesIndexTooLong");
        /// <summary>Corrupt .resources file. Invalid offset '{0}' into name section.</summary>
        internal static string @BadImageFormat_ResourcesNameInvalidOffset => GetResourceString("BadImageFormat_ResourcesNameInvalidOffset");
        /// <summary>Corrupt .resources file. Resource name extends past the end of the file.</summary>
        internal static string @BadImageFormat_ResourcesNameTooLong => GetResourceString("BadImageFormat_ResourcesNameTooLong");
        /// <summary>Corrupt .resources file.  The specified type doesn't match the available data in the stream.</summary>
        internal static string @BadImageFormat_TypeMismatch => GetResourceString("BadImageFormat_TypeMismatch");
        /// <summary>No tokens were supplied.</summary>
        internal static string @CancellationToken_CreateLinkedToken_TokensIsEmpty => GetResourceString("CancellationToken_CreateLinkedToken_TokensIsEmpty");
        /// <summary>The CancellationTokenSource has been disposed.</summary>
        internal static string @CancellationTokenSource_Disposed => GetResourceString("CancellationTokenSource_Disposed");
        /// <summary>The SyncRoot property may not be used for the synchronization of concurrent collections.</summary>
        internal static string @ConcurrentCollection_SyncRoot_NotSupported => GetResourceString("ConcurrentCollection_SyncRoot_NotSupported");
        /// <summary>Custom marshaler '{0}' implements multiple static GetInstance methods that take a single string parameter.</summary>
        internal static string @CustomMarshaler_MultipleGetInstanceMethods => GetResourceString("CustomMarshaler_MultipleGetInstanceMethods");
        /// <summary>Custom marshaler '{0}' does not implement a static GetInstance method that takes a single string parameter and returns an ICustomMarshaler.</summary>
        internal static string @CustomMarshaler_NoGetInstanceMethod => GetResourceString("CustomMarshaler_NoGetInstanceMethod");
        /// <summary>Custom marshaler '{0}' contains unassigned generic type parameter(s).</summary>
        internal static string @CustomMarshaler_UnassignedGenericParams => GetResourceString("CustomMarshaler_UnassignedGenericParams");
        /// <summary>A call to GetInstance() for custom marshaler '{0}' returned null, which is not allowed.</summary>
        internal static string @CustomMarshaler_NullReturnForGetInstance => GetResourceString("CustomMarshaler_NullReturnForGetInstance");
        /// <summary>Abstract event source must not declare event methods ({0} with ID {1}).</summary>
        internal static string @EventSource_AbstractMustNotDeclareEventMethods => GetResourceString("EventSource_AbstractMustNotDeclareEventMethods");
        /// <summary>Abstract event source must not declare {0} nested type.</summary>
        internal static string @EventSource_AbstractMustNotDeclareKTOC => GetResourceString("EventSource_AbstractMustNotDeclareKTOC");
        /// <summary>Getting out of bounds during scalar addition.</summary>
        internal static string @EventSource_AddScalarOutOfRange => GetResourceString("EventSource_AddScalarOutOfRange");
        /// <summary>Bad Hexidecimal digit "{0}".</summary>
        internal static string @EventSource_BadHexDigit => GetResourceString("EventSource_BadHexDigit");
        /// <summary>Channel {0} does not match event channel value {1}.</summary>
        internal static string @EventSource_ChannelTypeDoesNotMatchEventChannelValue => GetResourceString("EventSource_ChannelTypeDoesNotMatchEventChannelValue");
        /// <summary>Failed to open an EventPipe session for NativeRuntimeEventSource.</summary>
        internal static string @EventSource_CouldNotEnableEventPipe => GetResourceString("EventSource_CouldNotEnableEventPipe");
        /// <summary>Data descriptors are out of range.</summary>
        internal static string @EventSource_DataDescriptorsOutOfRange => GetResourceString("EventSource_DataDescriptorsOutOfRange");
        /// <summary>Multiple definitions for string "{0}".</summary>
        internal static string @EventSource_DuplicateStringKey => GetResourceString("EventSource_DuplicateStringKey");
        /// <summary>The type of {0} is not expected in {1}.</summary>
        internal static string @EventSource_EnumKindMismatch => GetResourceString("EventSource_EnumKindMismatch");
        /// <summary>Must have an even number of Hexidecimal digits.</summary>
        internal static string @EventSource_EvenHexDigits => GetResourceString("EventSource_EvenHexDigits");
        /// <summary>Channel {0} has a value of {1} which is outside the legal range (16-254).</summary>
        internal static string @EventSource_EventChannelOutOfRange => GetResourceString("EventSource_EventChannelOutOfRange");
        /// <summary>Event {0} has ID {1} which is already in use.</summary>
        internal static string @EventSource_EventIdReused => GetResourceString("EventSource_EventIdReused");
        /// <summary>Event {0} (with ID {1}) has a non-default opcode but not a task.</summary>
        internal static string @EventSource_EventMustHaveTaskIfNonDefaultOpcode => GetResourceString("EventSource_EventMustHaveTaskIfNonDefaultOpcode");
        /// <summary>Event method {0} (with ID {1}) is an explicit interface method implementation. Re-write method as implicit implementation.</summary>
        internal static string @EventSource_EventMustNotBeExplicitImplementation => GetResourceString("EventSource_EventMustNotBeExplicitImplementation");
        /// <summary>Event {0} (with ID {1}) has a name that is not the concatenation of its task name and opcode.</summary>
        internal static string @EventSource_EventNameDoesNotEqualTaskPlusOpcode => GetResourceString("EventSource_EventNameDoesNotEqualTaskPlusOpcode");
        /// <summary>Event name {0} used more than once.  If you wish to overload a method, the overloaded method should have a NonEvent attribute.</summary>
        internal static string @EventSource_EventNameReused => GetResourceString("EventSource_EventNameReused");
        /// <summary>Event {0} was called with {1} argument(s), but it is defined with {2} parameter(s).</summary>
        internal static string @EventSource_EventParametersMismatch => GetResourceString("EventSource_EventParametersMismatch");
        /// <summary>An instance of EventSource with Guid {0} already exists.</summary>
        internal static string @EventSource_EventSourceGuidInUse => GetResourceString("EventSource_EventSourceGuidInUse");
        /// <summary>The payload for a single event is too large.</summary>
        internal static string @EventSource_EventTooBig => GetResourceString("EventSource_EventTooBig");
        /// <summary>Event {0} specifies an Admin channel {1}. It must specify a Message property.</summary>
        internal static string @EventSource_EventWithAdminChannelMustHaveMessage => GetResourceString("EventSource_EventWithAdminChannelMustHaveMessage");
        /// <summary>Keyword {0} has a value of {1} which is outside the legal range (0-0x0000080000000000).</summary>
        internal static string @EventSource_IllegalKeywordsValue => GetResourceString("EventSource_IllegalKeywordsValue");
        /// <summary>Opcode {0} has a value of {1} which is outside the legal range (11-238).</summary>
        internal static string @EventSource_IllegalOpcodeValue => GetResourceString("EventSource_IllegalOpcodeValue");
        /// <summary>Task {0} has a value of {1} which is outside the legal range (1-65535).</summary>
        internal static string @EventSource_IllegalTaskValue => GetResourceString("EventSource_IllegalTaskValue");
        /// <summary>Illegal value "{0}" (prefix strings with @ to indicate a literal string).</summary>
        internal static string @EventSource_IllegalValue => GetResourceString("EventSource_IllegalValue");
        /// <summary>Incorrectly-authored TypeInfo - a type should be serialized as one field or as one group</summary>
        internal static string @EventSource_IncorrentlyAuthoredTypeInfo => GetResourceString("EventSource_IncorrentlyAuthoredTypeInfo");
        /// <summary>Invalid command value.</summary>
        internal static string @EventSource_InvalidCommand => GetResourceString("EventSource_InvalidCommand");
        /// <summary>Can't specify both etw event format flags.</summary>
        internal static string @EventSource_InvalidEventFormat => GetResourceString("EventSource_InvalidEventFormat");
        /// <summary>Keywords {0} and {1} are defined with the same value ({2}).</summary>
        internal static string @EventSource_KeywordCollision => GetResourceString("EventSource_KeywordCollision");
        /// <summary>Value {0} for keyword {1} needs to be a power of 2.</summary>
        internal static string @EventSource_KeywordNeedPowerOfTwo => GetResourceString("EventSource_KeywordNeedPowerOfTwo");
        /// <summary>Creating an EventListener inside a EventListener callback.</summary>
        internal static string @EventSource_ListenerCreatedInsideCallback => GetResourceString("EventSource_ListenerCreatedInsideCallback");
        /// <summary>Listener not found.</summary>
        internal static string @EventSource_ListenerNotFound => GetResourceString("EventSource_ListenerNotFound");
        /// <summary>An error occurred when writing to a listener.</summary>
        internal static string @EventSource_ListenerWriteFailure => GetResourceString("EventSource_ListenerWriteFailure");
        /// <summary>Attempt to define more than the maximum limit of 8 channels for a provider.</summary>
        internal static string @EventSource_MaxChannelExceeded => GetResourceString("EventSource_MaxChannelExceeded");
        /// <summary>Event {0} was assigned event ID {1} but {2} was passed to WriteEvent.</summary>
        internal static string @EventSource_MismatchIdToWriteEvent => GetResourceString("EventSource_MismatchIdToWriteEvent");
        /// <summary>The Guid of an EventSource must be non zero.</summary>
        internal static string @EventSource_NeedGuid => GetResourceString("EventSource_NeedGuid");
        /// <summary>The name of an EventSource must not be null.</summary>
        internal static string @EventSource_NeedName => GetResourceString("EventSource_NeedName");
        /// <summary>Event IDs must be positive integers.</summary>
        internal static string @EventSource_NeedPositiveId => GetResourceString("EventSource_NeedPositiveId");
        /// <summary>No Free Buffers available from the operating system (e.g. event rate too fast).</summary>
        internal static string @EventSource_NoFreeBuffers => GetResourceString("EventSource_NoFreeBuffers");
        /// <summary>The API supports only anonymous types or types decorated with the EventDataAttribute. Non-compliant type: {0} dataType.</summary>
        internal static string @EventSource_NonCompliantTypeError => GetResourceString("EventSource_NonCompliantTypeError");
        /// <summary>EventSource expects the first parameter of the Event method to be of type Guid and to be named "relatedActivityId" when calling WriteEventWithRelatedActivityId.</summary>
        internal static string @EventSource_NoRelatedActivityId => GetResourceString("EventSource_NoRelatedActivityId");
        /// <summary>Arrays of Binary are not supported.</summary>
        internal static string @EventSource_NotSupportedArrayOfBinary => GetResourceString("EventSource_NotSupportedArrayOfBinary");
        /// <summary>Arrays of Nil are not supported.</summary>
        internal static string @EventSource_NotSupportedArrayOfNil => GetResourceString("EventSource_NotSupportedArrayOfNil");
        /// <summary>Arrays of null-terminated string are not supported.</summary>
        internal static string @EventSource_NotSupportedArrayOfNullTerminatedString => GetResourceString("EventSource_NotSupportedArrayOfNullTerminatedString");
        /// <summary>Enumerables of custom-serialized data are not supported</summary>
        internal static string @EventSource_NotSupportedCustomSerializedData => GetResourceString("EventSource_NotSupportedCustomSerializedData");
        /// <summary>Nested arrays/enumerables are not supported.</summary>
        internal static string @EventSource_NotSupportedNestedArraysEnums => GetResourceString("EventSource_NotSupportedNestedArraysEnums");
        /// <summary>Null passed as a event argument.</summary>
        internal static string @EventSource_NullInput => GetResourceString("EventSource_NullInput");
        /// <summary>Opcodes {0} and {1} are defined with the same value ({2}).</summary>
        internal static string @EventSource_OpcodeCollision => GetResourceString("EventSource_OpcodeCollision");
        /// <summary>Pins are out of range.</summary>
        internal static string @EventSource_PinArrayOutOfRange => GetResourceString("EventSource_PinArrayOutOfRange");
        /// <summary>Recursive type definition is not supported.</summary>
        internal static string @EventSource_RecursiveTypeDefinition => GetResourceString("EventSource_RecursiveTypeDefinition");
        /// <summary>An event with stop suffix must follow a corresponding event with a start suffix.</summary>
        internal static string @EventSource_StopsFollowStarts => GetResourceString("EventSource_StopsFollowStarts");
        /// <summary>Tasks {0} and {1} are defined with the same value ({2}).</summary>
        internal static string @EventSource_TaskCollision => GetResourceString("EventSource_TaskCollision");
        /// <summary>Event {0} (with ID {1}) has the same task/opcode pair as event {2} (with ID {3}).</summary>
        internal static string @EventSource_TaskOpcodePairReused => GetResourceString("EventSource_TaskOpcodePairReused");
        /// <summary>Too many arguments.</summary>
        internal static string @EventSource_TooManyArgs => GetResourceString("EventSource_TooManyArgs");
        /// <summary>Too many fields in structure.</summary>
        internal static string @EventSource_TooManyFields => GetResourceString("EventSource_TooManyFields");
        /// <summary>EventSource({0}, {1})</summary>
        internal static string @EventSource_ToString => GetResourceString("EventSource_ToString");
        /// <summary>There must be an even number of trait strings (they are key-value pairs).</summary>
        internal static string @EventSource_TraitEven => GetResourceString("EventSource_TraitEven");
        /// <summary>Event source types must be sealed or abstract.</summary>
        internal static string @EventSource_TypeMustBeSealedOrAbstract => GetResourceString("EventSource_TypeMustBeSealedOrAbstract");
        /// <summary>Event source types must derive from EventSource.</summary>
        internal static string @EventSource_TypeMustDeriveFromEventSource => GetResourceString("EventSource_TypeMustDeriveFromEventSource");
        /// <summary>Use of undefined channel value {0} for event {1}.</summary>
        internal static string @EventSource_UndefinedChannel => GetResourceString("EventSource_UndefinedChannel");
        /// <summary>Use of undefined keyword value {0} for event {1}.</summary>
        internal static string @EventSource_UndefinedKeyword => GetResourceString("EventSource_UndefinedKeyword");
        /// <summary>Use of undefined opcode value {0} for event {1}.</summary>
        internal static string @EventSource_UndefinedOpcode => GetResourceString("EventSource_UndefinedOpcode");
        /// <summary>Unknown ETW trait "{0}".</summary>
        internal static string @EventSource_UnknownEtwTrait => GetResourceString("EventSource_UnknownEtwTrait");
        /// <summary>Unsupported type {0} in event source.</summary>
        internal static string @EventSource_UnsupportedEventTypeInManifest => GetResourceString("EventSource_UnsupportedEventTypeInManifest");
        /// <summary>Event {0} specifies an illegal or unsupported formatting message ("{1}").</summary>
        internal static string @EventSource_UnsupportedMessageProperty => GetResourceString("EventSource_UnsupportedMessageProperty");
        /// <summary>Event {0} was called with a different type as defined (argument "{1}"). This may cause the event to be displayed incorrectly.</summary>
        internal static string @EventSource_VarArgsParameterMismatch => GetResourceString("EventSource_VarArgsParameterMismatch");
        /// <summary>Custom attribute type '{0}' doesn't contain a field named '{1}'.</summary>
        internal static string @Exception_EmptyFieldForCustomAttributeType => GetResourceString("Exception_EmptyFieldForCustomAttributeType");
        /// <summary>--- End of inner exception stack trace ---</summary>
        internal static string @Exception_EndOfInnerExceptionStack => GetResourceString("Exception_EndOfInnerExceptionStack");
        /// <summary>--- End of stack trace from previous location ---</summary>
        internal static string @Exception_EndStackTraceFromPreviousThrow => GetResourceString("Exception_EndStackTraceFromPreviousThrow");
        /// <summary>Custom attribute length is only '{0}'.</summary>
        internal static string @Exception_InvalidCustomAttributeLength => GetResourceString("Exception_InvalidCustomAttributeLength");
        /// <summary>Prolog invalid.</summary>
        internal static string @Exception_InvalidProlog => GetResourceString("Exception_InvalidProlog");
        /// <summary>Unknown named type '{0}'.</summary>
        internal static string @Exception_UnknownNamedType => GetResourceString("Exception_UnknownNamedType");
        /// <summary>Unknown MarshalAsAttribute field '{0}'.</summary>
        internal static string @Exception_UnknownMarshalAsAttributeField => GetResourceString("Exception_UnknownMarshalAsAttributeField");
        /// <summary>Subtype '{0}' of type object not yet handled.</summary>
        internal static string @Exception_UnhandledSubType => GetResourceString("Exception_UnhandledSubType");
        /// <summary>Exception of type '{0}' was thrown.</summary>
        internal static string @Exception_WasThrown => GetResourceString("Exception_WasThrown");
        /// <summary>An exception was not handled in an AsyncLocal&lt;T&gt; notification callback.</summary>
        internal static string @ExecutionContext_ExceptionInAsyncLocalNotification => GetResourceString("ExecutionContext_ExceptionInAsyncLocalNotification");
        /// <summary>Could not resolve assembly '{0}'.</summary>
        internal static string @FileNotFound_ResolveAssembly => GetResourceString("FileNotFound_ResolveAssembly");
        /// <summary>Could not load file or assembly '{0}'. The system cannot find the file specified.</summary>
        internal static string @FileNotFound_LoadFile => GetResourceString("FileNotFound_LoadFile");
        /// <summary>Duplicate AttributeUsageAttribute found on attribute type {0}.</summary>
        internal static string @Format_AttributeUsage => GetResourceString("Format_AttributeUsage");
        /// <summary>Too many bytes in what should have been a 7-bit encoded integer.</summary>
        internal static string @Format_Bad7BitInt => GetResourceString("Format_Bad7BitInt");
        /// <summary>Invalid digits for the specified base.</summary>
        internal static string @Format_BadBase => GetResourceString("Format_BadBase");
        /// <summary>The input is not a valid Base-64 string as it contains a non-base 64 character, more than two padding characters, or an illegal character among the padding characters.</summary>
        internal static string @Format_BadBase64Char => GetResourceString("Format_BadBase64Char");
        /// <summary>String '{0}' was not recognized as a valid Boolean.</summary>
        internal static string @Format_BadBoolean => GetResourceString("Format_BadBoolean");
        /// <summary>Could not determine the order of year, month, and date from '{0}'.</summary>
        internal static string @Format_BadDatePattern => GetResourceString("Format_BadDatePattern");
        /// <summary>String '{0}' was not recognized as a valid DateTime.</summary>
        internal static string @Format_BadDateTime => GetResourceString("Format_BadDateTime");
        /// <summary>String '{0}' was not recognized as a valid DateOnly.</summary>
        internal static string @Format_BadDateOnly => GetResourceString("Format_BadDateOnly");
        /// <summary>String '{0}' was not recognized as a valid TimeOnly.</summary>
        internal static string @Format_BadTimeOnly => GetResourceString("Format_BadTimeOnly");
        /// <summary>String '{0}' contains parts which are not specific to the {1}.</summary>
        internal static string @Format_DateTimeOnlyContainsNoneDateParts => GetResourceString("Format_DateTimeOnlyContainsNoneDateParts");
        /// <summary>The DateTime represented by the string '{0}' is not supported in calendar '{1}'.</summary>
        internal static string @Format_BadDateTimeCalendar => GetResourceString("Format_BadDateTimeCalendar");
        /// <summary>String '{0}' was not recognized as a valid DateTime because the day of week was incorrect.</summary>
        internal static string @Format_BadDayOfWeek => GetResourceString("Format_BadDayOfWeek");
        /// <summary>Format specifier '{0}' was invalid.</summary>
        internal static string @Format_BadFormatSpecifier => GetResourceString("Format_BadFormatSpecifier");
        /// <summary>No format specifiers were provided.</summary>
        internal static string @Format_NoFormatSpecifier => GetResourceString("Format_NoFormatSpecifier");
        /// <summary>The input is not a valid hex string as it contains a non-hex character.</summary>
        internal static string @Format_BadHexChar => GetResourceString("Format_BadHexChar");
        /// <summary>The input is not a valid hex string as its length is not a multiple of 2.</summary>
        internal static string @Format_BadHexLength => GetResourceString("Format_BadHexLength");
        /// <summary>Cannot find a matching quote character for the character '{0}'.</summary>
        internal static string @Format_BadQuote => GetResourceString("Format_BadQuote");
        /// <summary>String '{0}' was not recognized as a valid TimeSpan.</summary>
        internal static string @Format_BadTimeSpan => GetResourceString("Format_BadTimeSpan");
        /// <summary>The DateTime represented by the string '{0}' is out of range.</summary>
        internal static string @Format_DateOutOfRange => GetResourceString("Format_DateOutOfRange");
        /// <summary>Input string was either empty or contained only whitespace.</summary>
        internal static string @Format_EmptyInputString => GetResourceString("Format_EmptyInputString");
        /// <summary>Additional non-parsable characters are at the end of the string.</summary>
        internal static string @Format_ExtraJunkAtEnd => GetResourceString("Format_ExtraJunkAtEnd");
        /// <summary>Expected {0xdddddddd, etc}.</summary>
        internal static string @Format_GuidBrace => GetResourceString("Format_GuidBrace");
        /// <summary>Could not find a brace, or the length between the previous token and the brace was zero (i.e., '0x,'etc.).</summary>
        internal static string @Format_GuidBraceAfterLastNumber => GetResourceString("Format_GuidBraceAfterLastNumber");
        /// <summary>Could not find a comma, or the length between the previous token and the comma was zero (i.e., '0x,'etc.).</summary>
        internal static string @Format_GuidComma => GetResourceString("Format_GuidComma");
        /// <summary>Dashes are in the wrong position for GUID parsing.</summary>
        internal static string @Format_GuidDashes => GetResourceString("Format_GuidDashes");
        /// <summary>Could not find the ending brace.</summary>
        internal static string @Format_GuidEndBrace => GetResourceString("Format_GuidEndBrace");
        /// <summary>Expected 0x prefix.</summary>
        internal static string @Format_GuidHexPrefix => GetResourceString("Format_GuidHexPrefix");
        /// <summary>Guid string should only contain hexadecimal characters.</summary>
        internal static string @Format_GuidInvalidChar => GetResourceString("Format_GuidInvalidChar");
        /// <summary>Guid should contain 32 digits with 4 dashes (xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx).</summary>
        internal static string @Format_GuidInvLen => GetResourceString("Format_GuidInvLen");
        /// <summary>Unrecognized Guid format.</summary>
        internal static string @Format_GuidUnrecognized => GetResourceString("Format_GuidUnrecognized");
        /// <summary>Index (zero based) must be greater than or equal to zero and less than the size of the argument list.</summary>
        internal static string @Format_IndexOutOfRange => GetResourceString("Format_IndexOutOfRange");
        /// <summary>Format string can be only "G", "g", "X", "x", "F", "f", "D" or "d".</summary>
        internal static string @Format_InvalidEnumFormatSpecification => GetResourceString("Format_InvalidEnumFormatSpecification");
        /// <summary>Format string can be only "D", "d", "N", "n", "P", "p", "B", "b", "X" or "x".</summary>
        internal static string @Format_InvalidGuidFormatSpecification => GetResourceString("Format_InvalidGuidFormatSpecification");
        /// <summary>Input string was not in a correct format.</summary>
        internal static string @Format_InvalidString => GetResourceString("Format_InvalidString");
        /// <summary>The input string '{0}' was not in a correct format.</summary>
        internal static string @Format_InvalidStringWithValue => GetResourceString("Format_InvalidStringWithValue");
        /// <summary>Input string was not in a correct format. Failure to parse near offset {0}. {1}</summary>
        internal static string @Format_InvalidStringWithOffsetAndReason => GetResourceString("Format_InvalidStringWithOffsetAndReason");
        /// <summary>Unexpected closing brace without a corresponding opening brace.</summary>
        internal static string @Format_UnexpectedClosingBrace => GetResourceString("Format_UnexpectedClosingBrace");
        /// <summary>Format item ends prematurely.</summary>
        internal static string @Format_UnclosedFormatItem => GetResourceString("Format_UnclosedFormatItem");
        /// <summary>Expected an ASCII digit.</summary>
        internal static string @Format_ExpectedAsciiDigit => GetResourceString("Format_ExpectedAsciiDigit");
        /// <summary>There must be at least a partial date with a year present in the input string '{0}'.</summary>
        internal static string @Format_MissingIncompleteDate => GetResourceString("Format_MissingIncompleteDate");
        /// <summary>String must be exactly one character long.</summary>
        internal static string @Format_NeedSingleChar => GetResourceString("Format_NeedSingleChar");
        /// <summary>Could not find any recognizable digits.</summary>
        internal static string @Format_NoParsibleDigits => GetResourceString("Format_NoParsibleDigits");
        /// <summary>The time zone offset of string '{0}' must be within plus or minus 14 hours.</summary>
        internal static string @Format_OffsetOutOfRange => GetResourceString("Format_OffsetOutOfRange");
        /// <summary>DateTime pattern '{0}' appears more than once with different values.</summary>
        internal static string @Format_RepeatDateTimePattern => GetResourceString("Format_RepeatDateTimePattern");
        /// <summary>String cannot have zero length.</summary>
        internal static string @Format_StringZeroLength => GetResourceString("Format_StringZeroLength");
        /// <summary>The string '{0}' was not recognized as a valid DateTime. There is an unknown word starting at index '{1}'.</summary>
        internal static string @Format_UnknownDateTimeWord => GetResourceString("Format_UnknownDateTimeWord");
        /// <summary>The UTC representation of the date '{0}' falls outside the year range 1-9999.</summary>
        internal static string @Format_UTCOutOfRange => GetResourceString("Format_UTCOutOfRange");
        /// <summary>Unicode</summary>
        internal static string @Globalization_cp_1200 => GetResourceString("Globalization_cp_1200");
        /// <summary>Unicode (UTF-32)</summary>
        internal static string @Globalization_cp_12000 => GetResourceString("Globalization_cp_12000");
        /// <summary>Unicode (UTF-32 Big-Endian)</summary>
        internal static string @Globalization_cp_12001 => GetResourceString("Globalization_cp_12001");
        /// <summary>Unicode (Big-Endian)</summary>
        internal static string @Globalization_cp_1201 => GetResourceString("Globalization_cp_1201");
        /// <summary>US-ASCII</summary>
        internal static string @Globalization_cp_20127 => GetResourceString("Globalization_cp_20127");
        /// <summary>Western European (ISO)</summary>
        internal static string @Globalization_cp_28591 => GetResourceString("Globalization_cp_28591");
        /// <summary>Unicode (UTF-7)</summary>
        internal static string @Globalization_cp_65000 => GetResourceString("Globalization_cp_65000");
        /// <summary>Unicode (UTF-8)</summary>
        internal static string @Globalization_cp_65001 => GetResourceString("Globalization_cp_65001");
        /// <summary>Array does not have that many dimensions.</summary>
        internal static string @IndexOutOfRange_ArrayRankIndex => GetResourceString("IndexOutOfRange_ArrayRankIndex");
        /// <summary>Unmanaged memory stream position was beyond the capacity of the stream.</summary>
        internal static string @IndexOutOfRange_UMSPosition => GetResourceString("IndexOutOfRange_UMSPosition");
        /// <summary>Insufficient available memory to meet the expected demands of an operation at this time.  Please try again later.</summary>
        internal static string @InsufficientMemory_MemFailPoint => GetResourceString("InsufficientMemory_MemFailPoint");
        /// <summary>Insufficient memory to meet the expected demands of an operation, and this system is likely to never satisfy this request.  If this is a 32 bit system, consider booting in 3 GB mode.</summary>
        internal static string @InsufficientMemory_MemFailPoint_TooBig => GetResourceString("InsufficientMemory_MemFailPoint_TooBig");
        /// <summary>Insufficient available memory to meet the expected demands of an operation at this time, possibly due to virtual address space fragmentation.  Please try again later.</summary>
        internal static string @InsufficientMemory_MemFailPoint_VAFrag => GetResourceString("InsufficientMemory_MemFailPoint_VAFrag");
        /// <summary>Type mismatch between source and destination types.</summary>
        internal static string @Interop_COM_TypeMismatch => GetResourceString("Interop_COM_TypeMismatch");
        /// <summary>Cannot marshal: Encountered unmappable character.</summary>
        internal static string @Interop_Marshal_Unmappable_Char => GetResourceString("Interop_Marshal_Unmappable_Char");
        /// <summary>Structures containing SafeHandle fields are not allowed in this operation.</summary>
        internal static string @Interop_Marshal_SafeHandle_InvalidOperation => GetResourceString("Interop_Marshal_SafeHandle_InvalidOperation");
        /// <summary>SafeHandle fields cannot be created from an unmanaged handle.</summary>
        internal static string @Interop_Marshal_CannotCreateSafeHandleField => GetResourceString("Interop_Marshal_CannotCreateSafeHandleField");
        /// <summary>CriticalHandle fields cannot be created from an unmanaged handle.</summary>
        internal static string @Interop_Marshal_CannotCreateCriticalHandleField => GetResourceString("Interop_Marshal_CannotCreateCriticalHandleField");
        /// <summary>Null object cannot be converted to a value type.</summary>
        internal static string @InvalidCast_CannotCastNullToValueType => GetResourceString("InvalidCast_CannotCastNullToValueType");
        /// <summary>Object cannot be coerced to the original type of the ByRef VARIANT it was obtained from.</summary>
        internal static string @InvalidCast_CannotCoerceByRefVariant => GetResourceString("InvalidCast_CannotCoerceByRefVariant");
        /// <summary>Object cannot be cast to DBNull.</summary>
        internal static string @InvalidCast_DBNull => GetResourceString("InvalidCast_DBNull");
        /// <summary>At least one element in the source array could not be cast down to the destination array type.</summary>
        internal static string @InvalidCast_DownCastArrayElement => GetResourceString("InvalidCast_DownCastArrayElement");
        /// <summary>Object cannot be cast to Empty.</summary>
        internal static string @InvalidCast_Empty => GetResourceString("InvalidCast_Empty");
        /// <summary>Object cannot be cast from DBNull to other types.</summary>
        internal static string @InvalidCast_FromDBNull => GetResourceString("InvalidCast_FromDBNull");
        /// <summary>Invalid cast from '{0}' to '{1}'.</summary>
        internal static string @InvalidCast_FromTo => GetResourceString("InvalidCast_FromTo");
        /// <summary>Object must implement IConvertible.</summary>
        internal static string @InvalidCast_IConvertible => GetResourceString("InvalidCast_IConvertible");
        /// <summary>OleAut reported a type mismatch.</summary>
        internal static string @InvalidCast_OATypeMismatch => GetResourceString("InvalidCast_OATypeMismatch");
        /// <summary>Object cannot be stored in an array of this type.</summary>
        internal static string @InvalidCast_StoreArrayElement => GetResourceString("InvalidCast_StoreArrayElement");
        /// <summary>Type is concrete but has abstract method '{0}'.</summary>
        internal static string @InvalidOperation_AbstractMethod => GetResourceString("InvalidOperation_AbstractMethod");
        /// <summary>AsyncFlowControl objects can be used to restore flow only on a Context that had its flow suppressed.</summary>
        internal static string @InvalidOperation_AsyncFlowCtrlCtxMismatch => GetResourceString("InvalidOperation_AsyncFlowCtrlCtxMismatch");
        /// <summary>The stream is currently in use by a previous operation on the stream.</summary>
        internal static string @InvalidOperation_AsyncIOInProgress => GetResourceString("InvalidOperation_AsyncIOInProgress");
        /// <summary>Method '{0}' does not have a method body.</summary>
        internal static string @InvalidOperation_BadEmptyMethodBody => GetResourceString("InvalidOperation_BadEmptyMethodBody");
        /// <summary>ILGenerator usage is invalid.</summary>
        internal static string @InvalidOperation_BadILGeneratorUsage => GetResourceString("InvalidOperation_BadILGeneratorUsage");
        /// <summary>Opcodes using a short-form index cannot address a local position over 255.</summary>
        internal static string @InvalidOperation_BadInstructionOrIndexOutOfBound => GetResourceString("InvalidOperation_BadInstructionOrIndexOutOfBound");
        /// <summary>Interface must be declared abstract.</summary>
        internal static string @InvalidOperation_BadInterfaceNotAbstract => GetResourceString("InvalidOperation_BadInterfaceNotAbstract");
        /// <summary>Interface method must be abstract and virtual.</summary>
        internal static string @InvalidOperation_BadInterfaceNotAbstractAndVirtual => GetResourceString("InvalidOperation_BadInterfaceNotAbstractAndVirtual");
        /// <summary>Method '{0}' cannot have a method body.</summary>
        internal static string @InvalidOperation_BadMethodBody => GetResourceString("InvalidOperation_BadMethodBody");
        /// <summary>Type must be declared abstract if any of its methods are abstract.</summary>
        internal static string @InvalidOperation_BadTypeAttributesNotAbstract => GetResourceString("InvalidOperation_BadTypeAttributesNotAbstract");
        /// <summary>The method cannot be called twice on the same instance.</summary>
        internal static string @InvalidOperation_CalledTwice => GetResourceString("InvalidOperation_CalledTwice");
        /// <summary>Unable to import a global method or field from a different module.</summary>
        internal static string @InvalidOperation_CannotImportGlobalFromDifferentModule => GetResourceString("InvalidOperation_CannotImportGlobalFromDifferentModule");
        /// <summary>A resolver is already set for the assembly.</summary>
        internal static string @InvalidOperation_CannotRegisterSecondResolver => GetResourceString("InvalidOperation_CannotRegisterSecondResolver");
        /// <summary>Cannot restore context flow when it is not suppressed.</summary>
        internal static string @InvalidOperation_CannotRestoreUnsuppressedFlow => GetResourceString("InvalidOperation_CannotRestoreUnsuppressedFlow");
        /// <summary>AsyncFlowControl object must be used on the thread where it was created.</summary>
        internal static string @InvalidOperation_CannotUseAFCOtherThread => GetResourceString("InvalidOperation_CannotUseAFCOtherThread");
        /// <summary>Instances of abstract classes cannot be created.</summary>
        internal static string @InvalidOperation_CantInstantiateAbstractClass => GetResourceString("InvalidOperation_CantInstantiateAbstractClass");
        /// <summary>Instances of function pointers cannot be created.</summary>
        internal static string @InvalidOperation_CantInstantiateFunctionPointer => GetResourceString("InvalidOperation_CantInstantiateFunctionPointer");
        /// <summary>A prior operation on this collection was interrupted by an exception. Collection's state is no longer trusted.</summary>
        internal static string @InvalidOperation_CollectionCorrupted => GetResourceString("InvalidOperation_CollectionCorrupted");
        /// <summary>Computer name could not be obtained.</summary>
        internal static string @InvalidOperation_ComputerName => GetResourceString("InvalidOperation_ComputerName");
        /// <summary>Operations that change non-concurrent collections must have exclusive access. A concurrent update was performed on this collection and corrupted its state. The collection's state is no longer correct.</summary>
        internal static string @InvalidOperation_ConcurrentOperationsNotSupported => GetResourceString("InvalidOperation_ConcurrentOperationsNotSupported");
        /// <summary>Interface cannot have constructors.</summary>
        internal static string @InvalidOperation_ConstructorNotAllowedOnInterface => GetResourceString("InvalidOperation_ConstructorNotAllowedOnInterface");
        /// <summary>Internal Error in DateTime and Calendar operations.</summary>
        internal static string @InvalidOperation_DateTimeParsing => GetResourceString("InvalidOperation_DateTimeParsing");
        /// <summary>Unable to access ILGenerator on a constructor created with DefineDefaultConstructor.</summary>
        internal static string @InvalidOperation_DefaultConstructorILGen => GetResourceString("InvalidOperation_DefaultConstructorILGen");
        /// <summary>Enumeration already finished.</summary>
        internal static string @InvalidOperation_EnumEnded => GetResourceString("InvalidOperation_EnumEnded");
        /// <summary>Collection was modified; enumeration operation may not execute.</summary>
        internal static string @InvalidOperation_EnumFailedVersion => GetResourceString("InvalidOperation_EnumFailedVersion");
        /// <summary>Enumeration has not started. Call MoveNext.</summary>
        internal static string @InvalidOperation_EnumNotStarted => GetResourceString("InvalidOperation_EnumNotStarted");
        /// <summary>Enumeration has either not started or has already finished.</summary>
        internal static string @InvalidOperation_EnumOpCantHappen => GetResourceString("InvalidOperation_EnumOpCantHappen");
        /// <summary>This API does not support EventInfo tokens.</summary>
        internal static string @InvalidOperation_EventInfoNotAvailable => GetResourceString("InvalidOperation_EventInfoNotAvailable");
        /// <summary>The generic parameters are already defined on this MethodBuilder.</summary>
        internal static string @InvalidOperation_GenericParametersAlreadySet => GetResourceString("InvalidOperation_GenericParametersAlreadySet");
        /// <summary>OSVersion's call to GetVersionEx failed.</summary>
        internal static string @InvalidOperation_GetVersion => GetResourceString("InvalidOperation_GetVersion");
        /// <summary>Type definition of the global function has been completed.</summary>
        internal static string @InvalidOperation_GlobalsHaveBeenCreated => GetResourceString("InvalidOperation_GlobalsHaveBeenCreated");
        /// <summary>Handle is not initialized.</summary>
        internal static string @InvalidOperation_HandleIsNotInitialized => GetResourceString("InvalidOperation_HandleIsNotInitialized");
        /// <summary>Handle is not pinned.</summary>
        internal static string @InvalidOperation_HandleIsNotPinned => GetResourceString("InvalidOperation_HandleIsNotPinned");
        /// <summary>Formatted string contains characters not representable as valid UTF-8.</summary>
        internal static string @InvalidOperation_InvalidUtf8 => GetResourceString("InvalidOperation_InvalidUtf8");
        /// <summary>Hashtable insert failed. Load factor too high. The most common cause is multiple threads writing to the Hashtable simultaneously.</summary>
        internal static string @InvalidOperation_HashInsertFailed => GetResourceString("InvalidOperation_HashInsertFailed");
        /// <summary>Failed to compare two elements in the array.</summary>
        internal static string @InvalidOperation_IComparerFailed => GetResourceString("InvalidOperation_IComparerFailed");
        /// <summary>Type definition of the method is complete.</summary>
        internal static string @InvalidOperation_MethodBaked => GetResourceString("InvalidOperation_MethodBaked");
        /// <summary>The signature of the MethodBuilder can no longer be modified because an operation on the MethodBuilder caused the methodDef token to be created. For example, a call to SetCustomAttribute requires the methodDef token to emit the CustomAttribute token.</summary>
        internal static string @InvalidOperation_MethodBuilderBaked => GetResourceString("InvalidOperation_MethodBuilderBaked");
        /// <summary>Method already has a body.</summary>
        internal static string @InvalidOperation_MethodHasBody => GetResourceString("InvalidOperation_MethodHasBody");
        /// <summary>Module-level fields or methods cannot be retrieved until after the CreateGlobalFunctions method has been called for the module.</summary>
        internal static string @InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod => GetResourceString("InvalidOperation_ModuleFieldsMethodsRelyOnCreateGlobalFunctionsMethod");
        /// <summary>You must call Initialize on this object instance before using it.</summary>
        internal static string @InvalidOperation_MustCallInitialize => GetResourceString("InvalidOperation_MustCallInitialize");
        /// <summary>NativeOverlapped cannot be reused for multiple operations.</summary>
        internal static string @InvalidOperation_NativeOverlappedReused => GetResourceString("InvalidOperation_NativeOverlappedReused");
        /// <summary>The thread is already executing the ControlledExecution.Run method.</summary>
        internal static string @InvalidOperation_NestedControlledExecutionRun => GetResourceString("InvalidOperation_NestedControlledExecutionRun");
        /// <summary>You cannot have more than one dynamic module in each dynamic assembly in this version of the runtime.</summary>
        internal static string @InvalidOperation_NoMultiModuleAssembly => GetResourceString("InvalidOperation_NoMultiModuleAssembly");
        /// <summary>Cannot add the event handler since no public add method exists for the event.</summary>
        internal static string @InvalidOperation_NoPublicAddMethod => GetResourceString("InvalidOperation_NoPublicAddMethod");
        /// <summary>Cannot remove the event handler since no public remove method exists for the event.</summary>
        internal static string @InvalidOperation_NoPublicRemoveMethod => GetResourceString("InvalidOperation_NoPublicRemoveMethod");
        /// <summary>Not a debug ModuleBuilder.</summary>
        internal static string @InvalidOperation_NotADebugModule => GetResourceString("InvalidOperation_NotADebugModule");
        /// <summary>The requested operation is invalid for DynamicMethod.</summary>
        internal static string @InvalidOperation_NotAllowedInDynamicMethod => GetResourceString("InvalidOperation_NotAllowedInDynamicMethod");
        /// <summary>Calling convention must be VarArgs.</summary>
        internal static string @InvalidOperation_NotAVarArgCallingConvention => GetResourceString("InvalidOperation_NotAVarArgCallingConvention");
        /// <summary>This operation is only valid on generic types.</summary>
        internal static string @InvalidOperation_NotGenericType => GetResourceString("InvalidOperation_NotGenericType");
        /// <summary>This API is not available when the concurrent GC is enabled.</summary>
        internal static string @InvalidOperation_NotWithConcurrentGC => GetResourceString("InvalidOperation_NotWithConcurrentGC");
        /// <summary>Underlying type information on enumeration is not specified.</summary>
        internal static string @InvalidOperation_NoUnderlyingTypeOnEnum => GetResourceString("InvalidOperation_NoUnderlyingTypeOnEnum");
        /// <summary>Nullable object must have a value.</summary>
        internal static string @InvalidOperation_NoValue => GetResourceString("InvalidOperation_NoValue");
        /// <summary>The underlying array is null.</summary>
        internal static string @InvalidOperation_NullArray => GetResourceString("InvalidOperation_NullArray");
        /// <summary>Cannot call Set on a null context</summary>
        internal static string @InvalidOperation_NullContext => GetResourceString("InvalidOperation_NullContext");
        /// <summary>The requested operation is invalid when called on a null ModuleHandle.</summary>
        internal static string @InvalidOperation_NullModuleHandle => GetResourceString("InvalidOperation_NullModuleHandle");
        /// <summary>Local variable scope was not properly closed.</summary>
        internal static string @InvalidOperation_OpenLocalVariableScope => GetResourceString("InvalidOperation_OpenLocalVariableScope");
        /// <summary>Cannot pack a packed Overlapped again.</summary>
        internal static string @InvalidOperation_Overlapped_Pack => GetResourceString("InvalidOperation_Overlapped_Pack");
        /// <summary>This API does not support PropertyInfo tokens.</summary>
        internal static string @InvalidOperation_PropertyInfoNotAvailable => GetResourceString("InvalidOperation_PropertyInfoNotAvailable");
        /// <summary>Instance is read-only.</summary>
        internal static string @InvalidOperation_ReadOnly => GetResourceString("InvalidOperation_ReadOnly");
        /// <summary>'{0}': ResourceSet derived classes must provide a constructor that takes a String file name and a constructor that takes a Stream.</summary>
        internal static string @InvalidOperation_ResMgrBadResSet_Type => GetResourceString("InvalidOperation_ResMgrBadResSet_Type");
        /// <summary>Resource '{0}' was not a Stream - call GetObject instead.</summary>
        internal static string @InvalidOperation_ResourceNotStream_Name => GetResourceString("InvalidOperation_ResourceNotStream_Name");
        /// <summary>Resource '{0}' was not a String - call GetObject instead.</summary>
        internal static string @InvalidOperation_ResourceNotString_Name => GetResourceString("InvalidOperation_ResourceNotString_Name");
        /// <summary>Resource was of type '{0}' instead of String - call GetObject instead.</summary>
        internal static string @InvalidOperation_ResourceNotString_Type => GetResourceString("InvalidOperation_ResourceNotString_Type");
        /// <summary>The NoGCRegion mode is in progress.End it and then set a different mode.</summary>
        internal static string @InvalidOperation_SetLatencyModeNoGC => GetResourceString("InvalidOperation_SetLatencyModeNoGC");
        /// <summary>Method body should not exist.</summary>
        internal static string @InvalidOperation_ShouldNotHaveMethodBody => GetResourceString("InvalidOperation_ShouldNotHaveMethodBody");
        /// <summary>The thread was created with a ThreadStart delegate that does not accept a parameter.</summary>
        internal static string @InvalidOperation_ThreadWrongThreadStart => GetResourceString("InvalidOperation_ThreadWrongThreadStart");
        /// <summary>Timeouts are not supported on this stream.</summary>
        internal static string @InvalidOperation_TimeoutsNotSupported => GetResourceString("InvalidOperation_TimeoutsNotSupported");
        /// <summary>The Timer was already closed using an incompatible Dispose method.</summary>
        internal static string @InvalidOperation_TimerAlreadyClosed => GetResourceString("InvalidOperation_TimerAlreadyClosed");
        /// <summary>The given type cannot be boxed.</summary>
        internal static string @InvalidOperation_TypeCannotBeBoxed => GetResourceString("InvalidOperation_TypeCannotBeBoxed");
        /// <summary>Unable to change after type has been created.</summary>
        internal static string @InvalidOperation_TypeHasBeenCreated => GetResourceString("InvalidOperation_TypeHasBeenCreated");
        /// <summary>Type has not been created.</summary>
        internal static string @InvalidOperation_TypeNotCreated => GetResourceString("InvalidOperation_TypeNotCreated");
        /// <summary>This range in the underlying list is invalid. A possible cause is that elements were removed.</summary>
        internal static string @InvalidOperation_UnderlyingArrayListChanged => GetResourceString("InvalidOperation_UnderlyingArrayListChanged");
        /// <summary>Unknown enum type.</summary>
        internal static string @InvalidOperation_UnknownEnumType => GetResourceString("InvalidOperation_UnknownEnumType");
        /// <summary>Either the IAsyncResult object did not come from the corresponding async method on this type, or the End method was called multiple times with the same IAsyncResult.</summary>
        internal static string @InvalidOperation_WrongAsyncResultOrEndCalledMultiple => GetResourceString("InvalidOperation_WrongAsyncResultOrEndCalledMultiple");
        /// <summary>Common Language Runtime detected an invalid program.</summary>
        internal static string @InvalidProgram_Default => GetResourceString("InvalidProgram_Default");
        /// <summary>The time zone ID '{0}' is invalid.</summary>
        internal static string @InvalidTimeZone_InvalidId => GetResourceString("InvalidTimeZone_InvalidId");
        /// <summary>The time zone ID '{0}' was found on the local computer, but the file at '{1}' was corrupt.</summary>
        internal static string @InvalidTimeZone_InvalidFileData => GetResourceString("InvalidTimeZone_InvalidFileData");
        /// <summary>The time zone ID '{0}' was found on the local computer, but the registry information was corrupt.</summary>
        internal static string @InvalidTimeZone_InvalidRegistryData => GetResourceString("InvalidTimeZone_InvalidRegistryData");
        /// <summary>Invalid Julian day in POSIX strings.</summary>
        internal static string @InvalidTimeZone_InvalidJulianDay => GetResourceString("InvalidTimeZone_InvalidJulianDay");
        /// <summary>There are no ttinfo structures in the tzfile.  At least one ttinfo structure is required in order to construct a TimeZoneInfo object.</summary>
        internal static string @InvalidTimeZone_NoTTInfoStructures => GetResourceString("InvalidTimeZone_NoTTInfoStructures");
        /// <summary>'{0}' is not a valid POSIX-TZ-environment-variable MDate rule.  A valid rule has the format 'Mm.w.d'.</summary>
        internal static string @InvalidTimeZone_UnparsablePosixMDateString => GetResourceString("InvalidTimeZone_UnparsablePosixMDateString");
        /// <summary>Invariant failed.</summary>
        internal static string @InvariantFailed => GetResourceString("InvariantFailed");
        /// <summary>Invariant failed: {0}</summary>
        internal static string @InvariantFailed_Cnd => GetResourceString("InvariantFailed_Cnd");
        /// <summary>This assembly does not have a file table because it was loaded from memory.</summary>
        internal static string @IO_NoFileTableInInMemoryAssemblies => GetResourceString("IO_NoFileTableInInMemoryAssemblies");
        /// <summary>Unsupported unseekable file.</summary>
        internal static string @IO_UnseekableFile => GetResourceString("IO_UnseekableFile");
        /// <summary>Unable to read beyond the end of the stream.</summary>
        internal static string @IO_EOF_ReadBeyondEOF => GetResourceString("IO_EOF_ReadBeyondEOF");
        /// <summary>Could not load the specified file.</summary>
        internal static string @IO_FileLoad => GetResourceString("IO_FileLoad");
        /// <summary>Could not load the file '{0}'.</summary>
        internal static string @IO_FileLoad_FileName => GetResourceString("IO_FileLoad_FileName");
        /// <summary>File name: '{0}'</summary>
        internal static string @IO_FileName_Name => GetResourceString("IO_FileName_Name");
        /// <summary>Unable to find the specified file.</summary>
        internal static string @IO_FileNotFound => GetResourceString("IO_FileNotFound");
        /// <summary>Could not find file '{0}'.</summary>
        internal static string @IO_FileNotFound_FileName => GetResourceString("IO_FileNotFound_FileName");
        /// <summary>Cannot create '{0}' because a file or directory with the same name already exists.</summary>
        internal static string @IO_AlreadyExists_Name => GetResourceString("IO_AlreadyExists_Name");
        /// <summary>Failed to create '{0}' with allocation size '{1}' because the disk was full.</summary>
        internal static string @IO_DiskFull_Path_AllocationSize => GetResourceString("IO_DiskFull_Path_AllocationSize");
        /// <summary>Failed to create '{0}' with allocation size '{1}' because the file was too large.</summary>
        internal static string @IO_FileTooLarge_Path_AllocationSize => GetResourceString("IO_FileTooLarge_Path_AllocationSize");
        /// <summary>BindHandle for ThreadPool failed on this handle.</summary>
        internal static string @IO_BindHandleFailed => GetResourceString("IO_BindHandleFailed");
        /// <summary>The file '{0}' already exists.</summary>
        internal static string @IO_FileExists_Name => GetResourceString("IO_FileExists_Name");
        /// <summary>The OS handle's position is not what FileStream expected. Do not use a handle simultaneously in one FileStream and in Win32 code or another FileStream. This may cause data loss.</summary>
        internal static string @IO_FileStreamHandlePosition => GetResourceString("IO_FileStreamHandlePosition");
        /// <summary>The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size.</summary>
        internal static string @IO_FileTooLong2GB => GetResourceString("IO_FileTooLong2GB");
        /// <summary>IO operation will not work. Most likely the file will become too long.</summary>
        internal static string @IO_FileTooLong => GetResourceString("IO_FileTooLong");
        /// <summary>IO operation will not work. Most likely the file will become too long or the handle was not opened to support synchronous IO operations.</summary>
        internal static string @IO_FileTooLongOrHandleNotSync => GetResourceString("IO_FileTooLongOrHandleNotSync");
        /// <summary>Unable to expand length of this stream beyond its capacity.</summary>
        internal static string @IO_FixedCapacity => GetResourceString("IO_FixedCapacity");
        /// <summary>BinaryReader encountered an invalid string length of {0} characters.</summary>
        internal static string @IO_InvalidStringLen_Len => GetResourceString("IO_InvalidStringLen_Len");
        /// <summary>Unable seek backward to overwrite data that previously existed in a file opened in Append mode.</summary>
        internal static string @IO_SeekAppendOverwrite => GetResourceString("IO_SeekAppendOverwrite");
        /// <summary>An attempt was made to move the position before the beginning of the stream.</summary>
        internal static string @IO_SeekBeforeBegin => GetResourceString("IO_SeekBeforeBegin");
        /// <summary>Unable to truncate data that previously existed in a file opened in Append mode.</summary>
        internal static string @IO_SetLengthAppendTruncate => GetResourceString("IO_SetLengthAppendTruncate");
        /// <summary>The process cannot access the file '{0}' because it is being used by another process.</summary>
        internal static string @IO_SharingViolation_File => GetResourceString("IO_SharingViolation_File");
        /// <summary>The process cannot access the file because it is being used by another process.</summary>
        internal static string @IO_SharingViolation_NoFileName => GetResourceString("IO_SharingViolation_NoFileName");
        /// <summary>Stream was too long.</summary>
        internal static string @IO_StreamTooLong => GetResourceString("IO_StreamTooLong");
        /// <summary>Could not find a part of the path.</summary>
        internal static string @IO_PathNotFound_NoPathName => GetResourceString("IO_PathNotFound_NoPathName");
        /// <summary>Could not find a part of the path '{0}'.</summary>
        internal static string @IO_PathNotFound_Path => GetResourceString("IO_PathNotFound_Path");
        /// <summary>The specified file name or path is too long, or a component of the specified path is too long.</summary>
        internal static string @IO_PathTooLong => GetResourceString("IO_PathTooLong");
        /// <summary>The path '{0}' is too long, or a component of the specified path is too long.</summary>
        internal static string @IO_PathTooLong_Path => GetResourceString("IO_PathTooLong_Path");
        /// <summary>Too many levels of symbolic links in '{0}'.</summary>
        internal static string @IO_TooManySymbolicLinkLevels => GetResourceString("IO_TooManySymbolicLinkLevels");
        /// <summary>[Unknown]</summary>
        internal static string @IO_UnknownFileName => GetResourceString("IO_UnknownFileName");
        /// <summary>Unable to complete the operation after the maximum number of attempts.</summary>
        internal static string @IO_MaxAttemptsReached => GetResourceString("IO_MaxAttemptsReached");
        /// <summary>The lazily-initialized type does not have a public, parameterless constructor.</summary>
        internal static string @Lazy_CreateValue_NoParameterlessCtorForT => GetResourceString("Lazy_CreateValue_NoParameterlessCtorForT");
        /// <summary>The mode argument specifies an invalid value.</summary>
        internal static string @Lazy_ctor_ModeInvalid => GetResourceString("Lazy_ctor_ModeInvalid");
        /// <summary>ValueFactory returned null.</summary>
        internal static string @Lazy_StaticInit_InvalidOperation => GetResourceString("Lazy_StaticInit_InvalidOperation");
        /// <summary>Value is not created.</summary>
        internal static string @Lazy_ToString_ValueNotCreated => GetResourceString("Lazy_ToString_ValueNotCreated");
        /// <summary>ValueFactory attempted to access the Value property of this instance.</summary>
        internal static string @Lazy_Value_RecursiveCallsToValue => GetResourceString("Lazy_Value_RecursiveCallsToValue");
        /// <summary>There are too many threads currently waiting on the event. A maximum of {0} waiting threads are supported.</summary>
        internal static string @ManualResetEventSlim_ctor_TooManyWaiters => GetResourceString("ManualResetEventSlim_ctor_TooManyWaiters");
        /// <summary>Marshaler restriction: Excessively long string.</summary>
        internal static string @Marshaler_StringTooLong => GetResourceString("Marshaler_StringTooLong");
        /// <summary>Constructor on type '{0}' not found.</summary>
        internal static string @MissingConstructor_Name => GetResourceString("MissingConstructor_Name");
        /// <summary>Field not found.</summary>
        internal static string @MissingField => GetResourceString("MissingField");
        /// <summary>Field '{0}.{1}' not found.</summary>
        internal static string @MissingField_Name => GetResourceString("MissingField_Name");
        /// <summary>A case-insensitive lookup for resource file "{0}" in assembly "{1}" found multiple entries. Remove the duplicates or specify the exact case.</summary>
        internal static string @MissingManifestResource_MultipleBlobs => GetResourceString("MissingManifestResource_MultipleBlobs");
        /// <summary>Could not find the resource "{0}" among the resources {2} embedded in the assembly "{1}", nor among the resources in any satellite assemblies for the specified culture. Perhaps the resources were embedded with an incorrect name.</summary>
        internal static string @MissingManifestResource_NoNeutralAsm => GetResourceString("MissingManifestResource_NoNeutralAsm");
        /// <summary>Could not find any resources appropriate for the specified culture (or the neutral culture) on disk.</summary>
        internal static string @MissingManifestResource_NoNeutralDisk => GetResourceString("MissingManifestResource_NoNeutralDisk");
        /// <summary>Member not found.</summary>
        internal static string @MissingMember => GetResourceString("MissingMember");
        /// <summary>Member '{0}.{1}' not found.</summary>
        internal static string @MissingMember_Name => GetResourceString("MissingMember_Name");
        /// <summary>TypedReference can only be made on nested value Types.</summary>
        internal static string @MissingMemberNestErr => GetResourceString("MissingMemberNestErr");
        /// <summary>FieldInfo does not match the target Type.</summary>
        internal static string @MissingMemberTypeRef => GetResourceString("MissingMemberTypeRef");
        /// <summary>Method '{0}.{1}' not found.</summary>
        internal static string @MissingMethod_Name => GetResourceString("MissingMethod_Name");
        /// <summary>The satellite assembly named "{1}" for fallback culture "{0}" either could not be found or could not be loaded. This is generally a setup problem. Please consider reinstalling or repairing the application.</summary>
        internal static string @MissingSatelliteAssembly_Culture_Name => GetResourceString("MissingSatelliteAssembly_Culture_Name");
        /// <summary>Resource lookup fell back to the ultimate fallback resources in a satellite assembly, but that satellite either was not found or could not be loaded. Please consider reinstalling or repairing the application.</summary>
        internal static string @MissingSatelliteAssembly_Default => GetResourceString("MissingSatelliteAssembly_Default");
        /// <summary>Delegates that are not of type MulticastDelegate may not be combined.</summary>
        internal static string @Multicast_Combine => GetResourceString("Multicast_Combine");
        /// <summary>An assembly (probably "{1}") must be rewritten using the code contracts binary rewriter (CCRewrite) because it is calling Contract.{0} and the CONTRACTS_FULL symbol is defined.  Remove any explicit definitions of the CONTRACTS_FULL symbol from your project ...</summary>
        internal static string @MustUseCCRewrite => GetResourceString("MustUseCCRewrite");
        /// <summary>This non-CLS method is not implemented.</summary>
        internal static string @NotSupported_AbstractNonCLS => GetResourceString("NotSupported_AbstractNonCLS");
        /// <summary>Activation Attributes are not supported.</summary>
        internal static string @NotSupported_ActivAttr => GetResourceString("NotSupported_ActivAttr");
        /// <summary>Assembly.LoadFrom with hashValue is not supported.</summary>
        internal static string @NotSupported_AssemblyLoadFromHash => GetResourceString("NotSupported_AssemblyLoadFromHash");
        /// <summary>Cannot create boxed ByRef-like values.</summary>
        internal static string @NotSupported_ByRefLike => GetResourceString("NotSupported_ByRefLike");
        /// <summary>Cannot create arrays of ByRef-like values.</summary>
        internal static string @NotSupported_ByRefLikeArray => GetResourceString("NotSupported_ByRefLikeArray");
        /// <summary>Cannot instantiate a generic type on a ByRef-like type.</summary>
        internal static string @CannotUseByRefLikeTypeInInstantiation => GetResourceString("CannotUseByRefLikeTypeInInstantiation");
        /// <summary>ByRef to ByRef-like return values are not supported in reflection invocation.</summary>
        internal static string @NotSupported_ByRefToByRefLikeReturn => GetResourceString("NotSupported_ByRefToByRefLikeReturn");
        /// <summary>ByRef to void return values are not supported in reflection invocation.</summary>
        internal static string @NotSupported_ByRefToVoidReturn => GetResourceString("NotSupported_ByRefToVoidReturn");
        /// <summary>Vararg calling convention not supported.</summary>
        internal static string @NotSupported_CallToVarArg => GetResourceString("NotSupported_CallToVarArg");
        /// <summary>Equals() on Span and ReadOnlySpan is not supported. Use operator== instead.</summary>
        internal static string @NotSupported_CannotCallEqualsOnSpan => GetResourceString("NotSupported_CannotCallEqualsOnSpan");
        /// <summary>GetHashCode() on Span and ReadOnlySpan is not supported.</summary>
        internal static string @NotSupported_CannotCallGetHashCodeOnSpan => GetResourceString("NotSupported_CannotCallGetHashCodeOnSpan");
        /// <summary>ChangeType operation is not supported.</summary>
        internal static string @NotSupported_ChangeType => GetResourceString("NotSupported_ChangeType");
        /// <summary>Resolving to a collectible assembly is not supported.</summary>
        internal static string @NotSupported_CollectibleAssemblyResolve => GetResourceString("NotSupported_CollectibleAssemblyResolve");
        /// <summary>A non-collectible assembly may not reference a collectible assembly.</summary>
        internal static string @NotSupported_CollectibleBoundNonCollectible => GetResourceString("NotSupported_CollectibleBoundNonCollectible");
        /// <summary>An element type cannot contain a stack pointer.</summary>
        internal static string @NotSupported_ContainsStackPtr => GetResourceString("NotSupported_ContainsStackPtr");
        /// <summary>CreateInstance cannot be used with an object of type TypeBuilder.</summary>
        internal static string @NotSupported_CreateInstanceWithTypeBuilder => GetResourceString("NotSupported_CreateInstanceWithTypeBuilder");
        /// <summary>Only one DBNull instance may exist, and calls to DBNull deserialization methods are not allowed.</summary>
        internal static string @NotSupported_DBNullSerial => GetResourceString("NotSupported_DBNullSerial");
        /// <summary>The invoked member is not supported in a dynamic assembly.</summary>
        internal static string @NotSupported_DynamicAssembly => GetResourceString("NotSupported_DynamicAssembly");
        /// <summary>Wrong MethodAttributes or CallingConventions for DynamicMethod. Only public, static, standard supported</summary>
        internal static string @NotSupported_DynamicMethodFlags => GetResourceString("NotSupported_DynamicMethodFlags");
        /// <summary>The invoked member is not supported in a dynamic module.</summary>
        internal static string @NotSupported_DynamicModule => GetResourceString("NotSupported_DynamicModule");
        /// <summary>Collection was of a fixed size.</summary>
        internal static string @NotSupported_FixedSizeCollection => GetResourceString("NotSupported_FixedSizeCollection");
        /// <summary>Generic methods with UnmanagedCallersOnlyAttribute are invalid.</summary>
        internal static string @InvalidProgram_GenericMethod => GetResourceString("InvalidProgram_GenericMethod");
        /// <summary>This operation is invalid on overlapping buffers.</summary>
        internal static string @InvalidOperation_SpanOverlappedOperation => GetResourceString("InvalidOperation_SpanOverlappedOperation");
        /// <summary>The operation cannot be performed when TimeProvider.LocalTimeZone is null.</summary>
        internal static string @InvalidOperation_TimeProviderNullLocalTimeZone => GetResourceString("InvalidOperation_TimeProviderNullLocalTimeZone");
        /// <summary>The operation cannot be performed when TimeProvider.TimestampFrequency is zero or negative.</summary>
        internal static string @InvalidOperation_TimeProviderInvalidTimestampFrequency => GetResourceString("InvalidOperation_TimeProviderInvalidTimestampFrequency");
        /// <summary>Invoking default method with named arguments is not supported.</summary>
        internal static string @NotSupported_IDispInvokeDefaultMemberWithNamedArgs => GetResourceString("NotSupported_IDispInvokeDefaultMemberWithNamedArgs");
        /// <summary>Illegal one-byte branch at position: {0}. Requested branch was: {1}.</summary>
        internal static string @NotSupported_IllegalOneByteBranch => GetResourceString("NotSupported_IllegalOneByteBranch");
        /// <summary>Mutating a key collection derived from a dictionary is not allowed.</summary>
        internal static string @NotSupported_KeyCollectionSet => GetResourceString("NotSupported_KeyCollectionSet");
        /// <summary>Cannot create uninitialized instances of types requiring managed activation.</summary>
        internal static string @NotSupported_ManagedActivation => GetResourceString("NotSupported_ManagedActivation");
        /// <summary>The number of WaitHandles must be less than or equal to 64.</summary>
        internal static string @NotSupported_MaxWaitHandles => GetResourceString("NotSupported_MaxWaitHandles");
        /// <summary>The number of WaitHandles on a STA thread must be less than or equal to 63.</summary>
        internal static string @NotSupported_MaxWaitHandles_STA => GetResourceString("NotSupported_MaxWaitHandles_STA");
        /// <summary>Memory stream is not expandable.</summary>
        internal static string @NotSupported_MemStreamNotExpandable => GetResourceString("NotSupported_MemStreamNotExpandable");
        /// <summary>Module argument must be a ModuleBuilder.</summary>
        internal static string @NotSupported_MustBeModuleBuilder => GetResourceString("NotSupported_MustBeModuleBuilder");
        /// <summary>Methods with UnmanagedCallersOnlyAttribute cannot be used as delegate target.</summary>
        internal static string @NotSupported_UnmanagedCallersOnlyTarget => GetResourceString("NotSupported_UnmanagedCallersOnlyTarget");
        /// <summary>No data is available for encoding {0}. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method.</summary>
        internal static string @NotSupported_NoCodepageData => GetResourceString("NotSupported_NoCodepageData");
        /// <summary>Function not marked with UnmanagedCallersOnlyAttribute.</summary>
        internal static string @InvalidOperation_FunctionMissingUnmanagedCallersOnly => GetResourceString("InvalidOperation_FunctionMissingUnmanagedCallersOnly");
        /// <summary>Non-blittable parameter types are invalid for UnmanagedCallersOnly methods.</summary>
        internal static string @InvalidProgram_NonBlittableTypes => GetResourceString("InvalidProgram_NonBlittableTypes");
        /// <summary>Not supported in a non-reflected type.</summary>
        internal static string @NotSupported_NonReflectedType => GetResourceString("NotSupported_NonReflectedType");
        /// <summary>Non-static methods with UnmanagedCallersOnlyAttribute are invalid.</summary>
        internal static string @InvalidProgram_NonStaticMethod => GetResourceString("InvalidProgram_NonStaticMethod");
        /// <summary>Mono does not currently support setting modOpt/modReq through SignatureHelper.</summary>
        internal static string @NotImplemented_NoSupportForModOpt => GetResourceString("NotImplemented_NoSupportForModOpt");
        /// <summary>Parent does not have a default constructor. The default constructor must be explicitly defined.</summary>
        internal static string @NotSupported_NoParentDefaultConstructor => GetResourceString("NotSupported_NoParentDefaultConstructor");
        /// <summary>Cannot resolve {0} to a TypeInfo object.</summary>
        internal static string @NotSupported_NoTypeInfo => GetResourceString("NotSupported_NoTypeInfo");
        /// <summary>This feature is not implemented.</summary>
        internal static string @NotSupported_NYI => GetResourceString("NotSupported_NYI");
        /// <summary>Found an obsolete .resources file in assembly '{0}'. Rebuild that .resources file then rebuild that assembly.</summary>
        internal static string @NotSupported_ObsoleteResourcesFile => GetResourceString("NotSupported_ObsoleteResourcesFile");
        /// <summary>The given Variant type is not supported by this OleAut function.</summary>
        internal static string @NotSupported_OleAutBadVarType => GetResourceString("NotSupported_OleAutBadVarType");
        /// <summary>Cannot create arrays of open type.</summary>
        internal static string @NotSupported_OpenType => GetResourceString("NotSupported_OpenType");
        /// <summary>Output streams do not support TypeBuilders.</summary>
        internal static string @NotSupported_OutputStreamUsingTypeBuilder => GetResourceString("NotSupported_OutputStreamUsingTypeBuilder");
        /// <summary>The specified operation is not supported on Ranges.</summary>
        internal static string @NotSupported_RangeCollection => GetResourceString("NotSupported_RangeCollection");
        /// <summary>Accessor does not support reading.</summary>
        internal static string @NotSupported_Reading => GetResourceString("NotSupported_Reading");
        /// <summary>Collection is read-only.</summary>
        internal static string @NotSupported_ReadOnlyCollection => GetResourceString("NotSupported_ReadOnlyCollection");
        /// <summary>Cannot read resources that depend on serialization.</summary>
        internal static string @NotSupported_ResourceObjectSerialization => GetResourceString("NotSupported_ResourceObjectSerialization");
        /// <summary>SignalAndWait on a STA thread is not supported.</summary>
        internal static string @NotSupported_SignalAndWaitSTAThread => GetResourceString("NotSupported_SignalAndWaitSTAThread");
        /// <summary>The string comparison type passed in is currently not supported.</summary>
        internal static string @NotSupported_StringComparison => GetResourceString("NotSupported_StringComparison");
        /// <summary>Derived classes must provide an implementation.</summary>
        internal static string @NotSupported_SubclassOverride => GetResourceString("NotSupported_SubclassOverride");
        /// <summary>Not supported in an array method of a type definition that is not complete.</summary>
        internal static string @NotSupported_SymbolMethod => GetResourceString("NotSupported_SymbolMethod");
        /// <summary>Stack size too deep. Possibly too many arguments.</summary>
        internal static string @NotSupported_TooManyArgs => GetResourceString("NotSupported_TooManyArgs");
        /// <summary>Type is not supported.</summary>
        internal static string @NotSupported_Type => GetResourceString("NotSupported_Type");
        /// <summary>The invoked member is not supported before the type is created.</summary>
        internal static string @NotSupported_TypeNotYetCreated => GetResourceString("NotSupported_TypeNotYetCreated");
        /// <summary>This operation is not supported for an UnmanagedMemoryStream created from a SafeBuffer.</summary>
        internal static string @NotSupported_UmsSafeBuffer => GetResourceString("NotSupported_UmsSafeBuffer");
        /// <summary>The UnitySerializationHolder object is designed to transmit information about other types and is not serializable itself.</summary>
        internal static string @NotSupported_UnitySerHolder => GetResourceString("NotSupported_UnitySerHolder");
        /// <summary>TypeCode '{0}' was not valid.</summary>
        internal static string @NotSupported_UnknownTypeCode => GetResourceString("NotSupported_UnknownTypeCode");
        /// <summary>WaitAll for multiple handles on a STA thread is not supported.</summary>
        internal static string @NotSupported_WaitAllSTAThread => GetResourceString("NotSupported_WaitAllSTAThread");
        /// <summary>Stream does not support reading.</summary>
        internal static string @NotSupported_UnreadableStream => GetResourceString("NotSupported_UnreadableStream");
        /// <summary>Stream does not support seeking.</summary>
        internal static string @NotSupported_UnseekableStream => GetResourceString("NotSupported_UnseekableStream");
        /// <summary>Stream does not support writing.</summary>
        internal static string @NotSupported_UnwritableStream => GetResourceString("NotSupported_UnwritableStream");
        /// <summary>Custom marshalers for value types are not currently supported.</summary>
        internal static string @NotSupported_ValueClassCM => GetResourceString("NotSupported_ValueClassCM");
        /// <summary>Mutating a value collection derived from a dictionary is not allowed.</summary>
        internal static string @NotSupported_ValueCollectionSet => GetResourceString("NotSupported_ValueCollectionSet");
        /// <summary>Arrays of System.Void are not supported.</summary>
        internal static string @NotSupported_VoidArray => GetResourceString("NotSupported_VoidArray");
        /// <summary>Accessor does not support writing.</summary>
        internal static string @NotSupported_Writing => GetResourceString("NotSupported_Writing");
        /// <summary>This .resources file should not be read with this reader. The resource reader type is "{0}".</summary>
        internal static string @NotSupported_WrongResourceReader_Type => GetResourceString("NotSupported_WrongResourceReader_Type");
        /// <summary>The pointer for this method was null.</summary>
        internal static string @NullReference_This => GetResourceString("NullReference_This");
        /// <summary>Cannot access a closed file.</summary>
        internal static string @ObjectDisposed_FileClosed => GetResourceString("ObjectDisposed_FileClosed");
        /// <summary>Cannot access a disposed object.</summary>
        internal static string @ObjectDisposed_Generic => GetResourceString("ObjectDisposed_Generic");
        /// <summary>Object name: '{0}'.</summary>
        internal static string @ObjectDisposed_ObjectName_Name => GetResourceString("ObjectDisposed_ObjectName_Name");
        /// <summary>Cannot write to a closed TextWriter.</summary>
        internal static string @ObjectDisposed_WriterClosed => GetResourceString("ObjectDisposed_WriterClosed");
        /// <summary>Cannot read from a closed TextReader.</summary>
        internal static string @ObjectDisposed_ReaderClosed => GetResourceString("ObjectDisposed_ReaderClosed");
        /// <summary>Cannot access a closed resource set.</summary>
        internal static string @ObjectDisposed_ResourceSet => GetResourceString("ObjectDisposed_ResourceSet");
        /// <summary>Cannot access a closed Stream.</summary>
        internal static string @ObjectDisposed_StreamClosed => GetResourceString("ObjectDisposed_StreamClosed");
        /// <summary>Cannot access a closed accessor.</summary>
        internal static string @ObjectDisposed_ViewAccessorClosed => GetResourceString("ObjectDisposed_ViewAccessorClosed");
        /// <summary>The operation was canceled.</summary>
        internal static string @OperationCanceled => GetResourceString("OperationCanceled");
        /// <summary>Value was either too large or too small for an unsigned byte.</summary>
        internal static string @Overflow_Byte => GetResourceString("Overflow_Byte");
        /// <summary>Value was either too large or too small for a character.</summary>
        internal static string @Overflow_Char => GetResourceString("Overflow_Char");
        /// <summary>Value was either too large or too small for a Currency.</summary>
        internal static string @Overflow_Currency => GetResourceString("Overflow_Currency");
        /// <summary>Value was either too large or too small for a Decimal.</summary>
        internal static string @Overflow_Decimal => GetResourceString("Overflow_Decimal");
        /// <summary>The duration cannot be returned for TimeSpan.MinValue because the absolute value of TimeSpan.MinValue exceeds the value of TimeSpan.MaxValue.</summary>
        internal static string @Overflow_Duration => GetResourceString("Overflow_Duration");
        /// <summary>Value was either too large or too small for an Int16.</summary>
        internal static string @Overflow_Int16 => GetResourceString("Overflow_Int16");
        /// <summary>Value was either too large or too small for an Int32.</summary>
        internal static string @Overflow_Int32 => GetResourceString("Overflow_Int32");
        /// <summary>Value was either too large or too small for an Int64.</summary>
        internal static string @Overflow_Int64 => GetResourceString("Overflow_Int64");
        /// <summary>Value was either too large or too small for an Int128.</summary>
        internal static string @Overflow_Int128 => GetResourceString("Overflow_Int128");
        /// <summary>The current thread attempted to reacquire a mutex that has reached its maximum acquire count.</summary>
        internal static string @Overflow_MutexReacquireCount => GetResourceString("Overflow_MutexReacquireCount");
        /// <summary>Negating the minimum value of a twos complement number is invalid.</summary>
        internal static string @Overflow_NegateTwosCompNum => GetResourceString("Overflow_NegateTwosCompNum");
        /// <summary>The string was being parsed as an unsigned number and could not have a negative sign.</summary>
        internal static string @Overflow_NegativeUnsigned => GetResourceString("Overflow_NegativeUnsigned");
        /// <summary>Value was either too large or too small for a signed byte.</summary>
        internal static string @Overflow_SByte => GetResourceString("Overflow_SByte");
        /// <summary>The TimeSpan string '{0}' could not be parsed because at least one of the numeric components is out of range or contains too many digits.</summary>
        internal static string @Overflow_TimeSpanElementTooLarge => GetResourceString("Overflow_TimeSpanElementTooLarge");
        /// <summary>TimeSpan overflowed because the duration is too long.</summary>
        internal static string @Overflow_TimeSpanTooLong => GetResourceString("Overflow_TimeSpanTooLong");
        /// <summary>Value was either too large or too small for a UInt16.</summary>
        internal static string @Overflow_UInt16 => GetResourceString("Overflow_UInt16");
        /// <summary>Value was either too large or too small for a UInt32.</summary>
        internal static string @Overflow_UInt32 => GetResourceString("Overflow_UInt32");
        /// <summary>Value was either too large or too small for a UInt64.</summary>
        internal static string @Overflow_UInt64 => GetResourceString("Overflow_UInt64");
        /// <summary>Value was either too large or too small for a UInt128.</summary>
        internal static string @Overflow_UInt128 => GetResourceString("Overflow_UInt128");
        /// <summary>ArgIterator is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ArgIterator => GetResourceString("PlatformNotSupported_ArgIterator");
        /// <summary>COM Interop is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ComInterop => GetResourceString("PlatformNotSupported_ComInterop");
        /// <summary>The named version of this synchronization primitive is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_NamedSynchronizationPrimitives => GetResourceString("PlatformNotSupported_NamedSynchronizationPrimitives");
        /// <summary>Wait operations on multiple wait handles including a named synchronization primitive are not supported on this platform.</summary>
        internal static string @PlatformNotSupported_NamedSyncObjectWaitAnyWaitAll => GetResourceString("PlatformNotSupported_NamedSyncObjectWaitAnyWaitAll");
        /// <summary>Locking/unlocking file regions is not supported on this platform. Use FileShare on the entire file instead.</summary>
        internal static string @PlatformNotSupported_OSXFileLocking => GetResourceString("PlatformNotSupported_OSXFileLocking");
        /// <summary>ReflectionOnly loading is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ReflectionOnly => GetResourceString("PlatformNotSupported_ReflectionOnly");
        /// <summary>Remoting is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_Remoting => GetResourceString("PlatformNotSupported_Remoting");
        /// <summary>Secure binary serialization is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_SecureBinarySerialization => GetResourceString("PlatformNotSupported_SecureBinarySerialization");
        /// <summary>Strong-name signing is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_StrongNameSigning => GetResourceString("PlatformNotSupported_StrongNameSigning");
        /// <summary>Unix file modes are not supported on this platform.</summary>
        internal static string @PlatformNotSupported_UnixFileMode => GetResourceString("PlatformNotSupported_UnixFileMode");
        /// <summary>This API is specific to the way in which Windows handles asynchronous I/O, and is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_OverlappedIO => GetResourceString("PlatformNotSupported_OverlappedIO");
        /// <summary>Marshalling a System.Type to an unmanaged ITypeInfo or marshalling an ITypeInfo to a System.Type is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ITypeInfo => GetResourceString("PlatformNotSupported_ITypeInfo");
        /// <summary>Marshalling an IDispatchEx to an IReflect or IExpando is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_IExpando => GetResourceString("PlatformNotSupported_IExpando");
        /// <summary>Secondary AppDomains are not supported on this platform.</summary>
        internal static string @PlatformNotSupported_AppDomains => GetResourceString("PlatformNotSupported_AppDomains");
        /// <summary>Code Access Security is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_CAS => GetResourceString("PlatformNotSupported_CAS");
        /// <summary>Windows Principal functionality is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_Principal => GetResourceString("PlatformNotSupported_Principal");
        /// <summary>Thread abort is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ThreadAbort => GetResourceString("PlatformNotSupported_ThreadAbort");
        /// <summary>Thread suspend is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ThreadSuspend => GetResourceString("PlatformNotSupported_ThreadSuspend");
        /// <summary>User defined subclasses of System.Type are not yet supported.</summary>
        internal static string @PlatformNotSupported_UserDefinedSubclassesOfType => GetResourceString("PlatformNotSupported_UserDefinedSubclassesOfType");
        /// <summary>Postcondition failed.</summary>
        internal static string @PostconditionFailed => GetResourceString("PostconditionFailed");
        /// <summary>Postcondition failed: {0}</summary>
        internal static string @PostconditionFailed_Cnd => GetResourceString("PostconditionFailed_Cnd");
        /// <summary>Postcondition failed after throwing an exception.</summary>
        internal static string @PostconditionOnExceptionFailed => GetResourceString("PostconditionOnExceptionFailed");
        /// <summary>Postcondition failed after throwing an exception: {0}</summary>
        internal static string @PostconditionOnExceptionFailed_Cnd => GetResourceString("PostconditionOnExceptionFailed_Cnd");
        /// <summary>Precondition failed.</summary>
        internal static string @PreconditionFailed => GetResourceString("PreconditionFailed");
        /// <summary>Precondition failed: {0}</summary>
        internal static string @PreconditionFailed_Cnd => GetResourceString("PreconditionFailed_Cnd");
        /// <summary>The home directory of the current user could not be determined.</summary>
        internal static string @PersistedFiles_NoHomeDirectory => GetResourceString("PersistedFiles_NoHomeDirectory");
        /// <summary>Only single dimension arrays are supported here.</summary>
        internal static string @Rank_MultiDimNotSupported => GetResourceString("Rank_MultiDimNotSupported");
        /// <summary>The specified arrays must have the same number of dimensions.</summary>
        internal static string @Rank_MustMatch => GetResourceString("Rank_MustMatch");
        /// <summary>Unable to load one or more of the requested types.</summary>
        internal static string @ReflectionTypeLoad_LoadFailed => GetResourceString("ReflectionTypeLoad_LoadFailed");
        /// <summary>ResourceReader is closed.</summary>
        internal static string @ResourceReaderIsClosed => GetResourceString("ResourceReaderIsClosed");
        /// <summary>Stream is not a valid resource file.</summary>
        internal static string @Resources_StreamNotValid => GetResourceString("Resources_StreamNotValid");
        /// <summary>An Int32 must be provided for the filter criteria.</summary>
        internal static string @InvalidFilterCriteriaException_CritInt => GetResourceString("InvalidFilterCriteriaException_CritInt");
        /// <summary>A String must be provided for the filter criteria.</summary>
        internal static string @InvalidFilterCriteriaException_CritString => GetResourceString("InvalidFilterCriteriaException_CritString");
        /// <summary>'{0}' field specified was not found.</summary>
        internal static string @RFLCT_InvalidFieldFail => GetResourceString("RFLCT_InvalidFieldFail");
        /// <summary>'{0}' property specified was not found.</summary>
        internal static string @RFLCT_InvalidPropFail => GetResourceString("RFLCT_InvalidPropFail");
        /// <summary>Object does not match target type.</summary>
        internal static string @RFLCT_Targ_ITargMismatch => GetResourceString("RFLCT_Targ_ITargMismatch");
        /// <summary>Non-static field requires a target.</summary>
        internal static string @RFLCT_Targ_StatFldReqTarg => GetResourceString("RFLCT_Targ_StatFldReqTarg");
        /// <summary>Non-static method requires a target.</summary>
        internal static string @RFLCT_Targ_StatMethReqTarg => GetResourceString("RFLCT_Targ_StatMethReqTarg");
        /// <summary>An object that does not derive from System.Exception has been wrapped in a RuntimeWrappedException.</summary>
        internal static string @RuntimeWrappedException => GetResourceString("RuntimeWrappedException");
        /// <summary>Failed to get marshaler for IID {0}.</summary>
        internal static string @StandardOleMarshalObjectGetMarshalerFailed => GetResourceString("StandardOleMarshalObjectGetMarshalerFailed");
        /// <summary>The time zone ID '{0}' was found on the local computer, but the application does not have permission to read the file.</summary>
        internal static string @Security_CannotReadFileData => GetResourceString("Security_CannotReadFileData");
        /// <summary>The time zone ID '{0}' was found on the local computer, but the application does not have permission to read the registry information.</summary>
        internal static string @Security_CannotReadRegistryData => GetResourceString("Security_CannotReadRegistryData");
        /// <summary>Requested registry access is not allowed.</summary>
        internal static string @Security_RegistryPermission => GetResourceString("Security_RegistryPermission");
        /// <summary>The initialCount argument must be non-negative and less than or equal to the maximumCount.</summary>
        internal static string @SemaphoreSlim_ctor_InitialCountWrong => GetResourceString("SemaphoreSlim_ctor_InitialCountWrong");
        /// <summary>The maximumCount argument must be a positive number. If a maximum is not required, use the constructor without a maxCount parameter.</summary>
        internal static string @SemaphoreSlim_ctor_MaxCountWrong => GetResourceString("SemaphoreSlim_ctor_MaxCountWrong");
        /// <summary>The releaseCount argument must be greater than zero.</summary>
        internal static string @SemaphoreSlim_Release_CountWrong => GetResourceString("SemaphoreSlim_Release_CountWrong");
        /// <summary>The timeout must represent a value between -1 and Int32.MaxValue, inclusive.</summary>
        internal static string @SemaphoreSlim_Wait_TimeoutWrong => GetResourceString("SemaphoreSlim_Wait_TimeoutWrong");
        /// <summary>Non existent ParameterInfo. Position bigger than member's parameters length.</summary>
        internal static string @Serialization_BadParameterInfo => GetResourceString("Serialization_BadParameterInfo");
        /// <summary>The value of the field '{0}' is invalid.  The serialized data is corrupt.</summary>
        internal static string @Serialization_CorruptField => GetResourceString("Serialization_CorruptField");
        /// <summary>Invalid serialized DateTime data. Ticks must be between DateTime.MinValue.Ticks and DateTime.MaxValue.Ticks.</summary>
        internal static string @Serialization_DateTimeTicksOutOfRange => GetResourceString("Serialization_DateTimeTicksOutOfRange");
        /// <summary>Serializing delegates is not supported on this platform.</summary>
        internal static string @Serialization_DelegatesNotSupported => GetResourceString("Serialization_DelegatesNotSupported");
        /// <summary>Insufficient state to return the real object.</summary>
        internal static string @Serialization_InsufficientState => GetResourceString("Serialization_InsufficientState");
        /// <summary>An error occurred while deserializing the object.  The serialized data is corrupt.</summary>
        internal static string @Serialization_InvalidData => GetResourceString("Serialization_InvalidData");
        /// <summary>The serialized data contained an invalid escape sequence '\\{0}'.</summary>
        internal static string @Serialization_InvalidEscapeSequence => GetResourceString("Serialization_InvalidEscapeSequence");
        /// <summary>OnDeserialization method was called while the object was not being deserialized.</summary>
        internal static string @Serialization_InvalidOnDeser => GetResourceString("Serialization_InvalidOnDeser");
        /// <summary>An IntPtr or UIntPtr with an eight byte value cannot be deserialized on a machine with a four byte word size.</summary>
        internal static string @Serialization_InvalidPtrValue => GetResourceString("Serialization_InvalidPtrValue");
        /// <summary>Only system-provided types can be passed to the GetUninitializedObject method. '{0}' is not a valid instance of a type.</summary>
        internal static string @Serialization_InvalidType => GetResourceString("Serialization_InvalidType");
        /// <summary>The keys and values arrays have different sizes.</summary>
        internal static string @Serialization_KeyValueDifferentSizes => GetResourceString("Serialization_KeyValueDifferentSizes");
        /// <summary>Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'.</summary>
        internal static string @Serialization_MissingDateTimeData => GetResourceString("Serialization_MissingDateTimeData");
        /// <summary>The Keys for this Hashtable are missing.</summary>
        internal static string @Serialization_MissingKeys => GetResourceString("Serialization_MissingKeys");
        /// <summary>The values for this dictionary are missing.</summary>
        internal static string @Serialization_MissingValues => GetResourceString("Serialization_MissingValues");
        /// <summary>Serialized member does not have a ParameterInfo.</summary>
        internal static string @Serialization_NoParameterInfo => GetResourceString("Serialization_NoParameterInfo");
        /// <summary>Member '{0}' was not found.</summary>
        internal static string @Serialization_NotFound => GetResourceString("Serialization_NotFound");
        /// <summary>One of the serialized keys is null.</summary>
        internal static string @Serialization_NullKey => GetResourceString("Serialization_NullKey");
        /// <summary>Version value must be positive.</summary>
        internal static string @Serialization_OptionalFieldVersionValue => GetResourceString("Serialization_OptionalFieldVersionValue");
        /// <summary>Cannot add the same member twice to a SerializationInfo object.</summary>
        internal static string @Serialization_SameNameTwice => GetResourceString("Serialization_SameNameTwice");
        /// <summary>The serialized Capacity property of StringBuilder must be positive, less than or equal to MaxCapacity and greater than or equal to the String length.</summary>
        internal static string @Serialization_StringBuilderCapacity => GetResourceString("Serialization_StringBuilderCapacity");
        /// <summary>The serialized MaxCapacity property of StringBuilder must be positive and greater than or equal to the String length.</summary>
        internal static string @Serialization_StringBuilderMaxCapacity => GetResourceString("Serialization_StringBuilderMaxCapacity");
        /// <summary>Setter must have parameters.</summary>
        internal static string @SetterHasNoParams => GetResourceString("SetterHasNoParams");
        /// <summary>The calling thread does not hold the lock.</summary>
        internal static string @SpinLock_Exit_SynchronizationLockException => GetResourceString("SpinLock_Exit_SynchronizationLockException");
        /// <summary>Thread tracking is disabled.</summary>
        internal static string @SpinLock_IsHeldByCurrentThread => GetResourceString("SpinLock_IsHeldByCurrentThread");
        /// <summary>The timeout must be a value between -1 and Int32.MaxValue, inclusive.</summary>
        internal static string @SpinLock_TryEnter_ArgumentOutOfRange => GetResourceString("SpinLock_TryEnter_ArgumentOutOfRange");
        /// <summary>The calling thread already holds the lock.</summary>
        internal static string @SpinLock_TryEnter_LockRecursionException => GetResourceString("SpinLock_TryEnter_LockRecursionException");
        /// <summary>The tookLock argument must be set to false before calling this method.</summary>
        internal static string @SpinLock_TryReliableEnter_ArgumentException => GetResourceString("SpinLock_TryReliableEnter_ArgumentException");
        /// <summary>The timeout must represent a value between -1 and Int32.MaxValue, inclusive.</summary>
        internal static string @SpinWait_SpinUntil_TimeoutWrong => GetResourceString("SpinWait_SpinUntil_TimeoutWrong");
        /// <summary>in {0}:token 0x{1:x}+0x{2:x}</summary>
        internal static string @StackTrace_InFileILOffset => GetResourceString("StackTrace_InFileILOffset");
        /// <summary>in {0}:line {1}</summary>
        internal static string @StackTrace_InFileLineNumber => GetResourceString("StackTrace_InFileLineNumber");
        /// <summary>Method cannot be invoked.</summary>
        internal static string @TargetInvocation_MethodCannotBeInvoked => GetResourceString("TargetInvocation_MethodCannotBeInvoked");
        /// <summary>The specified TaskContinuationOptions combined LongRunning and ExecuteSynchronously.  Synchronous continuations should not be long running.</summary>
        internal static string @Task_ContinueWith_ESandLR => GetResourceString("Task_ContinueWith_ESandLR");
        /// <summary>The specified TaskContinuationOptions excluded all continuation kinds.</summary>
        internal static string @Task_ContinueWith_NotOnAnything => GetResourceString("Task_ContinueWith_NotOnAnything");
        /// <summary>The value needs to translate in milliseconds to -1 (signifying an infinite timeout), 0, or a positive integer less than or equal to the maximum allowed timer duration.</summary>
        internal static string @Task_InvalidTimerTimeSpan => GetResourceString("Task_InvalidTimerTimeSpan");
        /// <summary>The value needs to be either -1 (signifying an infinite timeout), 0 or a positive integer.</summary>
        internal static string @Task_Delay_InvalidMillisecondsDelay => GetResourceString("Task_Delay_InvalidMillisecondsDelay");
        /// <summary>A task may only be disposed if it is in a completion state (RanToCompletion, Faulted or Canceled).</summary>
        internal static string @Task_Dispose_NotCompleted => GetResourceString("Task_Dispose_NotCompleted");
        /// <summary>It is invalid to specify TaskCreationOptions.LongRunning in calls to FromAsync.</summary>
        internal static string @Task_FromAsync_LongRunning => GetResourceString("Task_FromAsync_LongRunning");
        /// <summary>It is invalid to specify TaskCreationOptions.PreferFairness in calls to FromAsync.</summary>
        internal static string @Task_FromAsync_PreferFairness => GetResourceString("Task_FromAsync_PreferFairness");
        /// <summary>The tasks argument contains no tasks.</summary>
        internal static string @Task_MultiTaskContinuation_EmptyTaskList => GetResourceString("Task_MultiTaskContinuation_EmptyTaskList");
        /// <summary>It is invalid to exclude specific continuation kinds for continuations off of multiple tasks.</summary>
        internal static string @Task_MultiTaskContinuation_FireOptions => GetResourceString("Task_MultiTaskContinuation_FireOptions");
        /// <summary>The tasks argument included a null value.</summary>
        internal static string @Task_MultiTaskContinuation_NullTask => GetResourceString("Task_MultiTaskContinuation_NullTask");
        /// <summary>RunSynchronously may not be called on a task that was already started.</summary>
        internal static string @Task_RunSynchronously_AlreadyStarted => GetResourceString("Task_RunSynchronously_AlreadyStarted");
        /// <summary>RunSynchronously may not be called on a continuation task.</summary>
        internal static string @Task_RunSynchronously_Continuation => GetResourceString("Task_RunSynchronously_Continuation");
        /// <summary>RunSynchronously may not be called on a task not bound to a delegate, such as the task returned from an asynchronous method.</summary>
        internal static string @Task_RunSynchronously_Promise => GetResourceString("Task_RunSynchronously_Promise");
        /// <summary>RunSynchronously may not be called on a task that has already completed.</summary>
        internal static string @Task_RunSynchronously_TaskCompleted => GetResourceString("Task_RunSynchronously_TaskCompleted");
        /// <summary>Start may not be called on a task that was already started.</summary>
        internal static string @Task_Start_AlreadyStarted => GetResourceString("Task_Start_AlreadyStarted");
        /// <summary>Start may not be called on a continuation task.</summary>
        internal static string @Task_Start_ContinuationTask => GetResourceString("Task_Start_ContinuationTask");
        /// <summary>Start may not be called on a promise-style task.</summary>
        internal static string @Task_Start_Promise => GetResourceString("Task_Start_Promise");
        /// <summary>Start may not be called on a task that has completed.</summary>
        internal static string @Task_Start_TaskCompleted => GetResourceString("Task_Start_TaskCompleted");
        /// <summary>The task has been disposed.</summary>
        internal static string @Task_ThrowIfDisposed => GetResourceString("Task_ThrowIfDisposed");
        /// <summary>The tasks array included at least one null element.</summary>
        internal static string @Task_WaitMulti_NullTask => GetResourceString("Task_WaitMulti_NullTask");
        /// <summary>Task&lt;TResult&gt;.ConfigureAwait does not support ConfigureAwaitOptions.SuppressThrowing. To suppress throwing, instead cast the Task&lt;TResult&gt; to its base class Task and await that with SuppressThrowing.</summary>
        internal static string @TaskT_ConfigureAwait_InvalidOptions => GetResourceString("TaskT_ConfigureAwait_InvalidOptions");
        /// <summary>A task was canceled.</summary>
        internal static string @TaskCanceledException_ctor_DefaultMessage => GetResourceString("TaskCanceledException_ctor_DefaultMessage");
        /// <summary>The exceptions collection was empty.</summary>
        internal static string @TaskCompletionSourceT_TrySetException_NoExceptions => GetResourceString("TaskCompletionSourceT_TrySetException_NoExceptions");
        /// <summary>The exceptions collection included at least one null element.</summary>
        internal static string @TaskCompletionSourceT_TrySetException_NullException => GetResourceString("TaskCompletionSourceT_TrySetException_NullException");
        /// <summary>A Task's exception(s) were not observed either by Waiting on the Task or accessing its Exception property. As a result, the unobserved exception was rethrown by the finalizer thread.</summary>
        internal static string @TaskExceptionHolder_UnhandledException => GetResourceString("TaskExceptionHolder_UnhandledException");
        /// <summary>(Internal)Expected an Exception or an IEnumerable&lt;Exception&gt;</summary>
        internal static string @TaskExceptionHolder_UnknownExceptionType => GetResourceString("TaskExceptionHolder_UnknownExceptionType");
        /// <summary>ExecuteTask may not be called for a task which was previously queued to a different TaskScheduler.</summary>
        internal static string @TaskScheduler_ExecuteTask_WrongTaskScheduler => GetResourceString("TaskScheduler_ExecuteTask_WrongTaskScheduler");
        /// <summary>The current SynchronizationContext may not be used as a TaskScheduler.</summary>
        internal static string @TaskScheduler_FromCurrentSynchronizationContext_NoCurrent => GetResourceString("TaskScheduler_FromCurrentSynchronizationContext_NoCurrent");
        /// <summary>The TryExecuteTaskInline call to the underlying scheduler succeeded, but the task body was not invoked.</summary>
        internal static string @TaskScheduler_InconsistentStateAfterTryExecuteTaskInline => GetResourceString("TaskScheduler_InconsistentStateAfterTryExecuteTaskInline");
        /// <summary>An exception was thrown by a TaskScheduler.</summary>
        internal static string @TaskSchedulerException_ctor_DefaultMessage => GetResourceString("TaskSchedulerException_ctor_DefaultMessage");
        /// <summary>{Not yet computed}</summary>
        internal static string @TaskT_DebuggerNoResult => GetResourceString("TaskT_DebuggerNoResult");
        /// <summary>An attempt was made to transition a task to a final state when it had already completed.</summary>
        internal static string @TaskT_TransitionToFinal_AlreadyCompleted => GetResourceString("TaskT_TransitionToFinal_AlreadyCompleted");
        /// <summary>Failed to set the specified COM apartment state. Current apartment state '{0}'.</summary>
        internal static string @Thread_ApartmentState_ChangeFailed => GetResourceString("Thread_ApartmentState_ChangeFailed");
        /// <summary>Use CompressedStack.(Capture/Run) instead.</summary>
        internal static string @Thread_GetSetCompressedStack_NotSupported => GetResourceString("Thread_GetSetCompressedStack_NotSupported");
        /// <summary>This operation must be performed on the same thread as that represented by the Thread instance.</summary>
        internal static string @Thread_Operation_RequiresCurrentThread => GetResourceString("Thread_Operation_RequiresCurrentThread");
        /// <summary>The wait completed due to an abandoned mutex.</summary>
        internal static string @Threading_AbandonedMutexException => GetResourceString("Threading_AbandonedMutexException");
        /// <summary>No handle of the given name exists.</summary>
        internal static string @Threading_WaitHandleCannotBeOpenedException => GetResourceString("Threading_WaitHandleCannotBeOpenedException");
        /// <summary>A WaitHandle with system-wide name '{0}' cannot be created. A WaitHandle of a different type might have the same name.</summary>
        internal static string @Threading_WaitHandleCannotBeOpenedException_InvalidHandle => GetResourceString("Threading_WaitHandleCannotBeOpenedException_InvalidHandle");
        /// <summary>The WaitHandle cannot be signaled because it would exceed its maximum count.</summary>
        internal static string @Threading_WaitHandleTooManyPosts => GetResourceString("Threading_WaitHandleTooManyPosts");
        /// <summary>Adding the specified count to the semaphore would cause it to exceed its maximum count.</summary>
        internal static string @Threading_SemaphoreFullException => GetResourceString("Threading_SemaphoreFullException");
        /// <summary>Thread was interrupted from a waiting state.</summary>
        internal static string @Threading_ThreadInterrupted => GetResourceString("Threading_ThreadInterrupted");
        /// <summary>ValueFactory attempted to access the Value property of this instance.</summary>
        internal static string @ThreadLocal_Value_RecursiveCallsToValue => GetResourceString("ThreadLocal_Value_RecursiveCallsToValue");
        /// <summary>The ThreadLocal object is not tracking values. To use the Values property, use a ThreadLocal constructor that accepts the trackAllValues parameter and set the parameter to true.</summary>
        internal static string @ThreadLocal_ValuesNotAvailable => GetResourceString("ThreadLocal_ValuesNotAvailable");
        /// <summary>The time zone ID '{0}' was not found on the local computer.</summary>
        internal static string @TimeZoneNotFound_MissingData => GetResourceString("TimeZoneNotFound_MissingData");
        /// <summary>Type constructor threw an exception.</summary>
        internal static string @TypeInitialization_Default => GetResourceString("TypeInitialization_Default");
        /// <summary>The type initializer for '{0}' threw an exception.</summary>
        internal static string @TypeInitialization_Type => GetResourceString("TypeInitialization_Type");
        /// <summary>Could not load type '{0}' from assembly '{1}' because it is an enum with methods.</summary>
        internal static string @TypeLoad_AssemblyEnumContainsMethodsError => GetResourceString("TypeLoad_AssemblyEnumContainsMethodsError");
        /// <summary>Could not load type '{0}' from assembly '{1}' because it implements the inaccessible interface '{2}'.</summary>
        internal static string @TypeLoad_AssemblyInaccessibleInterfaceError => GetResourceString("TypeLoad_AssemblyInaccessibleInterfaceError");
        /// <summary>Could not load type '{0}' from assembly '{1}' because the parent type is sealed.</summary>
        internal static string @TypeLoad_AssemblySealedParentTypeError => GetResourceString("TypeLoad_AssemblySealedParentTypeError");
        /// <summary>Could not resolve nested type '{0}' in type "{1}'.</summary>
        internal static string @TypeLoad_ResolveNestedType => GetResourceString("TypeLoad_ResolveNestedType");
        /// <summary>Could not resolve type '{0}'.</summary>
        internal static string @TypeLoad_ResolveType => GetResourceString("TypeLoad_ResolveType");
        /// <summary>Could not resolve type '{0}' in assembly '{1}'.</summary>
        internal static string @TypeLoad_ResolveTypeFromAssembly => GetResourceString("TypeLoad_ResolveTypeFromAssembly");
        /// <summary>Access to the path is denied.</summary>
        internal static string @UnauthorizedAccess_IODenied_NoPathName => GetResourceString("UnauthorizedAccess_IODenied_NoPathName");
        /// <summary>Access to the path '{0}' is denied.</summary>
        internal static string @UnauthorizedAccess_IODenied_Path => GetResourceString("UnauthorizedAccess_IODenied_Path");
        /// <summary>MemoryStream's internal buffer cannot be accessed.</summary>
        internal static string @UnauthorizedAccess_MemStreamBuffer => GetResourceString("UnauthorizedAccess_MemStreamBuffer");
        /// <summary>Access to the registry key '{0}' is denied.</summary>
        internal static string @UnauthorizedAccess_RegistryKeyGeneric_Key => GetResourceString("UnauthorizedAccess_RegistryKeyGeneric_Key");
        /// <summary>Unknown error "{0}".</summary>
        internal static string @UnknownError_Num => GetResourceString("UnknownError_Num");
        /// <summary>Operation could destabilize the runtime.</summary>
        internal static string @Verification_Exception => GetResourceString("Verification_Exception");
        /// <summary>at</summary>
        internal static string @Word_At => GetResourceString("Word_At");
        /// <summary>---- DEBUG ASSERTION FAILED ----</summary>
        internal static string @DebugAssertBanner => GetResourceString("DebugAssertBanner");
        /// <summary>---- Assert Long Message ----</summary>
        internal static string @DebugAssertLongMessage => GetResourceString("DebugAssertLongMessage");
        /// <summary>---- Assert Short Message ----</summary>
        internal static string @DebugAssertShortMessage => GetResourceString("DebugAssertShortMessage");
        /// <summary>A read lock may not be acquired with the write lock held in this mode.</summary>
        internal static string @LockRecursionException_ReadAfterWriteNotAllowed => GetResourceString("LockRecursionException_ReadAfterWriteNotAllowed");
        /// <summary>Recursive read lock acquisitions not allowed in this mode.</summary>
        internal static string @LockRecursionException_RecursiveReadNotAllowed => GetResourceString("LockRecursionException_RecursiveReadNotAllowed");
        /// <summary>Recursive write lock acquisitions not allowed in this mode.</summary>
        internal static string @LockRecursionException_RecursiveWriteNotAllowed => GetResourceString("LockRecursionException_RecursiveWriteNotAllowed");
        /// <summary>Recursive upgradeable lock acquisitions not allowed in this mode.</summary>
        internal static string @LockRecursionException_RecursiveUpgradeNotAllowed => GetResourceString("LockRecursionException_RecursiveUpgradeNotAllowed");
        /// <summary>Write lock may not be acquired with read lock held. This pattern is prone to deadlocks. Please ensure that read locks are released before taking a write lock. If an upgrade is necessary, use an upgrade lock in place of the read lock.</summary>
        internal static string @LockRecursionException_WriteAfterReadNotAllowed => GetResourceString("LockRecursionException_WriteAfterReadNotAllowed");
        /// <summary>The upgradeable lock is being released without being held.</summary>
        internal static string @SynchronizationLockException_MisMatchedUpgrade => GetResourceString("SynchronizationLockException_MisMatchedUpgrade");
        /// <summary>The read lock is being released without being held.</summary>
        internal static string @SynchronizationLockException_MisMatchedRead => GetResourceString("SynchronizationLockException_MisMatchedRead");
        /// <summary>The lock is being disposed while still being used. It either is being held by a thread and/or has active waiters waiting to acquire the lock.</summary>
        internal static string @SynchronizationLockException_IncorrectDispose => GetResourceString("SynchronizationLockException_IncorrectDispose");
        /// <summary>Upgradeable lock may not be acquired with read lock held.</summary>
        internal static string @LockRecursionException_UpgradeAfterReadNotAllowed => GetResourceString("LockRecursionException_UpgradeAfterReadNotAllowed");
        /// <summary>Upgradeable lock may not be acquired with write lock held in this mode. Acquiring Upgradeable lock gives the ability to read along with an option to upgrade to a writer.</summary>
        internal static string @LockRecursionException_UpgradeAfterWriteNotAllowed => GetResourceString("LockRecursionException_UpgradeAfterWriteNotAllowed");
        /// <summary>The write lock is being released without being held.</summary>
        internal static string @SynchronizationLockException_MisMatchedWrite => GetResourceString("SynchronizationLockException_MisMatchedWrite");
        /// <summary>This method is not supported on signature types.</summary>
        internal static string @NotSupported_SignatureType => GetResourceString("NotSupported_SignatureType");
        /// <summary>Release all references before disposing this instance.</summary>
        internal static string @Memory_OutstandingReferences => GetResourceString("Memory_OutstandingReferences");
        /// <summary>HashCode is a mutable struct and should not be compared with other HashCodes. Use ToHashCode to retrieve the computed hash code.</summary>
        internal static string @HashCode_HashCodeNotSupported => GetResourceString("HashCode_HashCodeNotSupported");
        /// <summary>HashCode is a mutable struct and should not be compared with other HashCodes.</summary>
        internal static string @HashCode_EqualityNotSupported => GetResourceString("HashCode_EqualityNotSupported");
        /// <summary>Specified type is not supported</summary>
        internal static string @Arg_TypeNotSupported => GetResourceString("Arg_TypeNotSupported");
        /// <summary>The read operation returned an invalid length.</summary>
        internal static string @IO_InvalidReadLength => GetResourceString("IO_InvalidReadLength");
        /// <summary>Basepath argument is not fully qualified.</summary>
        internal static string @Arg_BasePathNotFullyQualified => GetResourceString("Arg_BasePathNotFullyQualified");
        /// <summary>Number of elements in source vector is greater than the destination array</summary>
        internal static string @Arg_ElementsInSourceIsGreaterThanDestination => GetResourceString("Arg_ElementsInSourceIsGreaterThanDestination");
        /// <summary>The method was called with a null array argument.</summary>
        internal static string @Arg_NullArgumentNullRef => GetResourceString("Arg_NullArgumentNullRef");
        /// <summary>AggressiveGC requires setting the generation parameter to MaxGeneration</summary>
        internal static string @Argument_AggressiveGCRequiresMaxGeneration => GetResourceString("Argument_AggressiveGCRequiresMaxGeneration");
        /// <summary>AggressiveGC requires setting the blocking parameter to true.</summary>
        internal static string @Argument_AggressiveGCRequiresBlocking => GetResourceString("Argument_AggressiveGCRequiresBlocking");
        /// <summary>AggressiveGC requires setting the compacting parameter to true.</summary>
        internal static string @Argument_AggressiveGCRequiresCompacting => GetResourceString("Argument_AggressiveGCRequiresCompacting");
        /// <summary>Abstract methods cannot be prepared.</summary>
        internal static string @Argument_CannotPrepareAbstract => GetResourceString("Argument_CannotPrepareAbstract");
        /// <summary>The given generic instantiation was invalid.</summary>
        internal static string @Argument_InvalidGenericInstantiation => GetResourceString("Argument_InvalidGenericInstantiation");
        /// <summary>Overlapping spans have mismatching alignment.</summary>
        internal static string @Argument_OverlapAlignmentMismatch => GetResourceString("Argument_OverlapAlignmentMismatch");
        /// <summary>At least {0} element(s) are expected in the parameter "{1}".</summary>
        internal static string @Arg_InsufficientNumberOfElements => GetResourceString("Arg_InsufficientNumberOfElements");
        /// <summary>The string must be null-terminated.</summary>
        internal static string @Arg_MustBeNullTerminatedString => GetResourceString("Arg_MustBeNullTerminatedString");
        /// <summary>The week parameter must be in the range 1 through 53.</summary>
        internal static string @ArgumentOutOfRange_Week_ISO => GetResourceString("ArgumentOutOfRange_Week_ISO");
        /// <summary>PInvoke methods must be static and native and cannot be abstract.</summary>
        internal static string @Argument_BadPInvokeMethod => GetResourceString("Argument_BadPInvokeMethod");
        /// <summary>PInvoke methods cannot exist on interfaces.</summary>
        internal static string @Argument_BadPInvokeOnInterface => GetResourceString("Argument_BadPInvokeOnInterface");
        /// <summary>Bad type definition, can't handle '{0}' at '{1}'.</summary>
        internal static string @Argument_BadTypeDef => GetResourceString("Argument_BadTypeDef");
        /// <summary>Method has been already defined.</summary>
        internal static string @Argument_MethodRedefined => GetResourceString("Argument_MethodRedefined");
        /// <summary>Cannot extract a Unicode scalar value from the specified index in the input.</summary>
        internal static string @Argument_CannotExtractScalar => GetResourceString("Argument_CannotExtractScalar");
        /// <summary>Characters following the format symbol must be a number of {0} or less.</summary>
        internal static string @Argument_CannotParsePrecision => GetResourceString("Argument_CannotParsePrecision");
        /// <summary>The 'G' format combined with a precision is not supported.</summary>
        internal static string @Argument_GWithPrecisionNotSupported => GetResourceString("Argument_GWithPrecisionNotSupported");
        /// <summary>Precision cannot be larger than {0}.</summary>
        internal static string @Argument_PrecisionTooLarge => GetResourceString("Argument_PrecisionTooLarge");
        /// <summary>Property '{0}' does not belong to the same class as the constructor.</summary>
        internal static string @Argument_PropertyClassUnmatchedWithConstructor => GetResourceString("Argument_PropertyClassUnmatchedWithConstructor");
        /// <summary>Property '{0}' does not have a valid type.</summary>
        internal static string @Argument_PropertyInvalidType => GetResourceString("Argument_PropertyInvalidType");
        /// <summary>Property '{0}' does not have a valid value.</summary>
        internal static string @Argument_PropertyInvalidValue => GetResourceString("Argument_PropertyInvalidValue");
        /// <summary>"Property '{0}' does not have a setter.</summary>
        internal static string @Argument_PropertyMissingSetter => GetResourceString("Argument_PropertyMissingSetter");
        /// <summary>"Value of property '{0}' does not match property type: '{1}' -&gt; '{2}'.</summary>
        internal static string @Argument_PropertyUnmatchingPropertyType => GetResourceString("Argument_PropertyUnmatchingPropertyType");
        /// <summary>Cannot load hostpolicy library. AssemblyDependencyResolver is currently only supported if the runtime is hosted through hostpolicy library.</summary>
        internal static string @AssemblyDependencyResolver_FailedToLoadHostpolicy => GetResourceString("AssemblyDependencyResolver_FailedToLoadHostpolicy");
        /// <summary>Dependency resolution failed for component {0} with error code {1}. Detailed error: {2}</summary>
        internal static string @AssemblyDependencyResolver_FailedToResolveDependencies => GetResourceString("AssemblyDependencyResolver_FailedToResolveDependencies");
        /// <summary>The supplied object does not implement ICloneable.</summary>
        internal static string @Arg_EnumNotCloneable => GetResourceString("Arg_EnumNotCloneable");
        /// <summary>The returned enumerator does not implement IEnumVARIANT.</summary>
        internal static string @InvalidOp_InvalidNewEnumVariant => GetResourceString("InvalidOp_InvalidNewEnumVariant");
        /// <summary>sysctl {0} failed with {1} error.</summary>
        internal static string @InvalidSysctl => GetResourceString("InvalidSysctl");
        /// <summary>Array size exceeds addressing limitations.</summary>
        internal static string @Argument_StructArrayTooLarge => GetResourceString("Argument_StructArrayTooLarge");
        /// <summary>ArrayWithOffset: offset exceeds array size.</summary>
        internal static string @IndexOutOfRange_ArrayWithOffset => GetResourceString("IndexOutOfRange_ArrayWithOffset");
        /// <summary>An action was attempted during deserialization that could lead to a security vulnerability. The action has been aborted.</summary>
        internal static string @Serialization_DangerousDeserialization => GetResourceString("Serialization_DangerousDeserialization");
        /// <summary>An action was attempted during deserialization that could lead to a security vulnerability. The action has been aborted. To allow the action, set the '{0}' AppContext switch to true.</summary>
        internal static string @Serialization_DangerousDeserialization_Switch => GetResourceString("Serialization_DangerousDeserialization_Switch");
        /// <summary>The startup hook simple assembly name '{0}' is invalid. It must be a valid assembly name and it may not contain directory separator, space or comma characters and must not end with '.dll'.</summary>
        internal static string @Argument_InvalidStartupHookSimpleAssemblyName => GetResourceString("Argument_InvalidStartupHookSimpleAssemblyName");
        /// <summary>Startup hook assembly '{0}' failed to load. See inner exception for details.</summary>
        internal static string @Argument_StartupHookAssemblyLoadFailed => GetResourceString("Argument_StartupHookAssemblyLoadFailed");
        /// <summary>Can't construct custom attribute for TypeBuilder type.</summary>
        internal static string @InvalidOperation_CannotConstructCustomAttributeForTypeBuilderType => GetResourceString("InvalidOperation_CannotConstructCustomAttributeForTypeBuilderType");
        /// <summary>First argument to GetCustomAttributes can't be a TypeBuilder.</summary>
        internal static string @InvalidOperation_CannotHaveFirstArgumentAsTypeBuilder => GetResourceString("InvalidOperation_CannotHaveFirstArgumentAsTypeBuilder");
        /// <summary>COM register function must be static.</summary>
        internal static string @InvalidOperation_NonStaticComRegFunction => GetResourceString("InvalidOperation_NonStaticComRegFunction");
        /// <summary>COM unregister function must be static.</summary>
        internal static string @InvalidOperation_NonStaticComUnRegFunction => GetResourceString("InvalidOperation_NonStaticComUnRegFunction");
        /// <summary>COM register function must have a System.Type parameter and a void return type.</summary>
        internal static string @InvalidOperation_InvalidComRegFunctionSig => GetResourceString("InvalidOperation_InvalidComRegFunctionSig");
        /// <summary>COM unregister function must have a System.Type parameter and a void return type.</summary>
        internal static string @InvalidOperation_InvalidComUnRegFunctionSig => GetResourceString("InvalidOperation_InvalidComUnRegFunctionSig");
        /// <summary>The handle is invalid.</summary>
        internal static string @InvalidOperation_InvalidHandle => GetResourceString("InvalidOperation_InvalidHandle");
        /// <summary>Type '{0}' has more than one COM registration function.</summary>
        internal static string @InvalidOperation_MultipleComRegFunctions => GetResourceString("InvalidOperation_MultipleComRegFunctions");
        /// <summary>Type '{0}' has more than one COM unregistration function.</summary>
        internal static string @InvalidOperation_MultipleComUnRegFunctions => GetResourceString("InvalidOperation_MultipleComUnRegFunctions");
        /// <summary>Attempt to update previously set global instance.</summary>
        internal static string @InvalidOperation_ResetGlobalComWrappersInstance => GetResourceString("InvalidOperation_ResetGlobalComWrappersInstance");
        /// <summary>Attempt to update previously set Objective-C msgSend API overrides.</summary>
        internal static string @InvalidOperation_ResetGlobalObjectiveCMsgSend => GetResourceString("InvalidOperation_ResetGlobalObjectiveCMsgSend");
        /// <summary>Attempt to track an Objective-C Type without initializing.</summary>
        internal static string @InvalidOperation_ObjectiveCMarshalNotInitialized => GetResourceString("InvalidOperation_ObjectiveCMarshalNotInitialized");
        /// <summary>Attempt to reinitialize ObjectiveCMarshal.</summary>
        internal static string @InvalidOperation_ReinitializeObjectiveCMarshal => GetResourceString("InvalidOperation_ReinitializeObjectiveCMarshal");
        /// <summary>Attempt to track an Objective-C Type without a finalizer.</summary>
        internal static string @InvalidOperation_ObjectiveCTypeNoFinalizer => GetResourceString("InvalidOperation_ObjectiveCTypeNoFinalizer");
        /// <summary>Supplying a non-null inner should also be marked as Aggregated.</summary>
        internal static string @InvalidOperation_SuppliedInnerMustBeMarkedAggregation => GetResourceString("InvalidOperation_SuppliedInnerMustBeMarkedAggregation");
        /// <summary>A NoGCRegion callback is already registered.</summary>
        internal static string @InvalidOperationException_NoGCRegionCallbackAlreadyRegistered => GetResourceString("InvalidOperationException_NoGCRegionCallbackAlreadyRegistered");
        /// <summary>Length of items must be same as length of keys.</summary>
        internal static string @Argument_SpansMustHaveSameLength => GetResourceString("Argument_SpansMustHaveSameLength");
        /// <summary>Cannot write to a BufferedStream while the read buffer is not empty if the underlying stream is not seekable. Ensure that the stream underlying this BufferedStream can seek or avoid interleaving read and write operations on this BufferedStream.</summary>
        internal static string @NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed => GetResourceString("NotSupported_CannotWriteToBufferedStreamIfReadBufferCannotBeFlushed");
        /// <summary>Found invalid data while decoding.</summary>
        internal static string @GenericInvalidData => GetResourceString("GenericInvalidData");
        /// <summary>Resource type in the ResourceScope enum is going from a more restrictive resource type to a more general one.  From: "{0}"  To: "{1}"</summary>
        internal static string @Argument_ResourceScopeWrongDirection => GetResourceString("Argument_ResourceScopeWrongDirection");
        /// <summary>The type parameter cannot be null when scoping the resource's visibility to Private or Assembly.</summary>
        internal static string @ArgumentNull_TypeRequiredByResourceScope => GetResourceString("ArgumentNull_TypeRequiredByResourceScope");
        /// <summary>Unknown value for the ResourceScope: {0}  Too many resource type bits may be set.</summary>
        internal static string @Argument_BadResourceScopeTypeBits => GetResourceString("Argument_BadResourceScopeTypeBits");
        /// <summary>Unknown value for the ResourceScope: {0}  Too many resource visibility bits may be set.</summary>
        internal static string @Argument_BadResourceScopeVisibilityBits => GetResourceString("Argument_BadResourceScopeVisibilityBits");
        /// <summary>The value cannot be an empty string.</summary>
        internal static string @Argument_EmptyString => GetResourceString("Argument_EmptyString");
        /// <summary>The value cannot be an empty string or composed entirely of whitespace.</summary>
        internal static string @Argument_EmptyOrWhiteSpaceString => GetResourceString("Argument_EmptyOrWhiteSpaceString");
        /// <summary>FrameworkName is invalid.</summary>
        internal static string @Argument_FrameworkNameInvalid => GetResourceString("Argument_FrameworkNameInvalid");
        /// <summary>FrameworkName version component is invalid.</summary>
        internal static string @Argument_FrameworkNameInvalidVersion => GetResourceString("Argument_FrameworkNameInvalidVersion");
        /// <summary>FrameworkName version component is missing.</summary>
        internal static string @Argument_FrameworkNameMissingVersion => GetResourceString("Argument_FrameworkNameMissingVersion");
        /// <summary>FrameworkName cannot have less than two components or more than three components.</summary>
        internal static string @Argument_FrameworkNameTooShort => GetResourceString("Argument_FrameworkNameTooShort");
        /// <summary>Non-exhaustive switch expression failed to match its input.</summary>
        internal static string @Arg_SwitchExpressionException => GetResourceString("Arg_SwitchExpressionException");
        /// <summary>Attempted to marshal an object across a context boundary.</summary>
        internal static string @Arg_ContextMarshalException => GetResourceString("Arg_ContextMarshalException");
        /// <summary>Attempted to access an unloaded AppDomain.</summary>
        internal static string @Arg_AppDomainUnloadedException => GetResourceString("Arg_AppDomainUnloadedException");
        /// <summary>Unmatched value was {0}.</summary>
        internal static string @SwitchExpressionException_UnmatchedValue => GetResourceString("SwitchExpressionException_UnmatchedValue");
        /// <summary>Support for UTF-7 is disabled. See {0} for more information.</summary>
        internal static string @Encoding_UTF7_Disabled => GetResourceString("Encoding_UTF7_Disabled");
        /// <summary>Type '{0}' returned by IDynamicInterfaceCastable does not implement the requested interface '{1}'.</summary>
        internal static string @IDynamicInterfaceCastable_DoesNotImplementRequested => GetResourceString("IDynamicInterfaceCastable_DoesNotImplementRequested");
        /// <summary>Type '{0}' returned by IDynamicInterfaceCastable does not have the attribute '{1}'.</summary>
        internal static string @IDynamicInterfaceCastable_MissingImplementationAttribute => GetResourceString("IDynamicInterfaceCastable_MissingImplementationAttribute");
        /// <summary>Type '{0}' returned by IDynamicInterfaceCastable is not an interface.</summary>
        internal static string @IDynamicInterfaceCastable_NotInterface => GetResourceString("IDynamicInterfaceCastable_NotInterface");
        /// <summary>Object must be of type Half.</summary>
        internal static string @Arg_MustBeHalf => GetResourceString("Arg_MustBeHalf");
        /// <summary>Object must be of type Rune.</summary>
        internal static string @Arg_MustBeRune => GetResourceString("Arg_MustBeRune");
        /// <summary>BinaryFormatter serialization and deserialization are disabled within this application. See https://aka.ms/binaryformatter for more information.</summary>
        internal static string @BinaryFormatter_SerializationDisallowed => GetResourceString("BinaryFormatter_SerializationDisallowed");
        /// <summary>CodeBase is not supported on assemblies loaded from a single-file bundle.</summary>
        internal static string @NotSupported_CodeBase => GetResourceString("NotSupported_CodeBase");
        /// <summary>Cannot dynamically create an instance of type '{0}'. Reason: {1}</summary>
        internal static string @Activator_CannotCreateInstance => GetResourceString("Activator_CannotCreateInstance");
        /// <summary>The argv[0] argument cannot include a double quote.</summary>
        internal static string @Argv_IncludeDoubleQuote => GetResourceString("Argv_IncludeDoubleQuote");
        /// <summary>Use of ResourceManager for custom types is disabled. Set the MSBuild Property CustomResourceTypesSupport to true in order to enable it.</summary>
        internal static string @ResourceManager_ReflectionNotAllowed => GetResourceString("ResourceManager_ReflectionNotAllowed");
        /// <summary>The assembly can not be edited or changed.</summary>
        internal static string @InvalidOperation_AssemblyNotEditable => GetResourceString("InvalidOperation_AssemblyNotEditable");
        /// <summary>The assembly update failed.</summary>
        internal static string @InvalidOperation_EditFailed => GetResourceString("InvalidOperation_EditFailed");
        /// <summary>Assembly updates cannot be applied while a debugger is attached.</summary>
        internal static string @NotSupported_DebuggerAttached => GetResourceString("NotSupported_DebuggerAttached");
        /// <summary>Method body replacement not supported in this runtime.</summary>
        internal static string @NotSupported_MethodBodyReplacement => GetResourceString("NotSupported_MethodBodyReplacement");
        /// <summary>Built-in COM has been disabled via a feature switch. See https://aka.ms/dotnet-illink/com for more information.</summary>
        internal static string @NotSupported_COM => GetResourceString("NotSupported_COM");
        /// <summary>C++/CLI activation has been disabled via a feature switch. See https://aka.ms/dotnet-illink/nativehost for more information.</summary>
        internal static string @NotSupported_CppCli => GetResourceString("NotSupported_CppCli");
        /// <summary>Queue empty.</summary>
        internal static string @InvalidOperation_EmptyQueue => GetResourceString("InvalidOperation_EmptyQueue");
        /// <summary>The target file '{0}' is a directory, not a file.</summary>
        internal static string @Arg_FileIsDirectory_Name => GetResourceString("Arg_FileIsDirectory_Name");
        /// <summary>Invalid File or Directory attributes value.</summary>
        internal static string @Arg_InvalidFileAttrs => GetResourceString("Arg_InvalidFileAttrs");
        /// <summary>Invalid UnixFileMode value.</summary>
        internal static string @Arg_InvalidUnixFileMode => GetResourceString("Arg_InvalidUnixFileMode");
        /// <summary>Second path fragment must not be a drive or UNC name.</summary>
        internal static string @Arg_Path2IsRooted => GetResourceString("Arg_Path2IsRooted");
        /// <summary>Path must not be a drive.</summary>
        internal static string @Arg_PathIsVolume => GetResourceString("Arg_PathIsVolume");
        /// <summary>The stream's length cannot be changed.</summary>
        internal static string @Argument_FileNotResized => GetResourceString("Argument_FileNotResized");
        /// <summary>The directory specified, '{0}', is not a subdirectory of '{1}'.</summary>
        internal static string @Argument_InvalidSubPath => GetResourceString("Argument_InvalidSubPath");
        /// <summary>The specified directory '{0}' cannot be created.</summary>
        internal static string @IO_CannotCreateDirectory => GetResourceString("IO_CannotCreateDirectory");
        /// <summary>The source '{0}' and destination '{1}' are the same file.</summary>
        internal static string @IO_CannotReplaceSameFile => GetResourceString("IO_CannotReplaceSameFile");
        /// <summary>The specified path '{0}' is not a file.</summary>
        internal static string @IO_NotAFile => GetResourceString("IO_NotAFile");
        /// <summary>Source and destination path must be different.</summary>
        internal static string @IO_SourceDestMustBeDifferent => GetResourceString("IO_SourceDestMustBeDifferent");
        /// <summary>Source and destination path must have identical roots. Move will not work across volumes.</summary>
        internal static string @IO_SourceDestMustHaveSameRoot => GetResourceString("IO_SourceDestMustHaveSameRoot");
        /// <summary>Synchronous operations should not be performed on the UI thread.  Consider wrapping this method in Task.Run.</summary>
        internal static string @IO_SyncOpOnUIThread => GetResourceString("IO_SyncOpOnUIThread");
        /// <summary>Probable I/O race condition detected while copying memory. The I/O package is not thread safe by default. In multithreaded applications, a stream must be accessed in a thread-safe way, such as a thread-safe wrapper returned by TextReader's or TextWriter's  ...</summary>
        internal static string @IndexOutOfRange_IORaceCondition => GetResourceString("IndexOutOfRange_IORaceCondition");
        /// <summary>File encryption is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_FileEncryption => GetResourceString("PlatformNotSupported_FileEncryption");
        /// <summary>A MemberInfo that matches '{0}' could not be found.</summary>
        internal static string @Arg_MemberInfoNotFound => GetResourceString("Arg_MemberInfoNotFound");
        /// <summary>Bad magic in '{0}': Header starts with '{1}' instead of 'tzdata'</summary>
        internal static string @InvalidOperation_BadTZHeader => GetResourceString("InvalidOperation_BadTZHeader");
        /// <summary>Unable to fully read from file '{0}' at offset {1} length {2}; read {3} bytes expected {4}.</summary>
        internal static string @InvalidOperation_ReadTZError => GetResourceString("InvalidOperation_ReadTZError");
        /// <summary>Length in index file less than AndroidTzDataHeader</summary>
        internal static string @InvalidOperation_BadIndexLength => GetResourceString("InvalidOperation_BadIndexLength");
        /// <summary>Unable to properly load any time zone data files.</summary>
        internal static string @TimeZoneNotFound_ValidTimeZoneFileMissing => GetResourceString("TimeZoneNotFound_ValidTimeZoneFileMissing");
        /// <summary>NullabilityInfoContext is not supported in the current application because 'System.Reflection.NullabilityInfoContext.IsSupported' is set to false. Set the MSBuild Property 'NullabilityInfoContextSupport' to true in order to enable it.</summary>
        internal static string @NullabilityInfoContext_NotSupported => GetResourceString("NullabilityInfoContext_NotSupported");
        /// <summary>Thread is running or terminated; it cannot restart.</summary>
        internal static string @ThreadState_AlreadyStarted => GetResourceString("ThreadState_AlreadyStarted");
        /// <summary>Thread has not been started.</summary>
        internal static string @ThreadState_NotStarted => GetResourceString("ThreadState_NotStarted");
        /// <summary>Thread is dead; priority cannot be accessed.</summary>
        internal static string @ThreadState_Dead_Priority => GetResourceString("ThreadState_Dead_Priority");
        /// <summary>Thread is dead; state cannot be accessed.</summary>
        internal static string @ThreadState_Dead_State => GetResourceString("ThreadState_Dead_State");
        /// <summary>Unable to set thread priority.</summary>
        internal static string @ThreadState_SetPriorityFailed => GetResourceString("ThreadState_SetPriorityFailed");
        /// <summary>The target method returned a null reference.</summary>
        internal static string @NullReference_InvokeNullRefReturned => GetResourceString("NullReference_InvokeNullRefReturned");
        /// <summary>Cannot create an instance of {0} as it is an open type.</summary>
        internal static string @Arg_OpenType => GetResourceString("Arg_OpenType");
        /// <summary>lohSize can't be greater than totalSize</summary>
        internal static string @ArgumentOutOfRange_NoGCLohSizeGreaterTotalSize => GetResourceString("ArgumentOutOfRange_NoGCLohSizeGreaterTotalSize");
        /// <summary>totalSize is too large. For more information about setting the maximum size, see "Latency Modes" in http://go.microsoft.com/fwlink/?LinkId=522706.</summary>
        internal static string @ArgumentOutOfRangeException_NoGCRegionSizeTooLarge => GetResourceString("ArgumentOutOfRangeException_NoGCRegionSizeTooLarge");
        /// <summary>The NoGCRegion mode was already in progress.</summary>
        internal static string @InvalidOperationException_AlreadyInNoGCRegion => GetResourceString("InvalidOperationException_AlreadyInNoGCRegion");
        /// <summary>Allocated memory exceeds specified memory for NoGCRegion mode.</summary>
        internal static string @InvalidOperationException_NoGCRegionAllocationExceeded => GetResourceString("InvalidOperationException_NoGCRegionAllocationExceeded");
        /// <summary>Garbage collection was induced in NoGCRegion mode.</summary>
        internal static string @InvalidOperationException_NoGCRegionInduced => GetResourceString("InvalidOperationException_NoGCRegionInduced");
        /// <summary>NoGCRegion mode must be set.</summary>
        internal static string @InvalidOperationException_NoGCRegionNotInProgress => GetResourceString("InvalidOperationException_NoGCRegionNotInProgress");
        /// <summary>RefreshMemoryLimit failed with too low hard limit.</summary>
        internal static string @InvalidOperationException_HardLimitTooLow => GetResourceString("InvalidOperationException_HardLimitTooLow");
        /// <summary>RefreshMemoryLimit failed with invalid hard limit.</summary>
        internal static string @InvalidOperationException_HardLimitInvalid => GetResourceString("InvalidOperationException_HardLimitInvalid");
        /// <summary>Dynamic code generation is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_ReflectionEmit => GetResourceString("PlatformNotSupported_ReflectionEmit");
        /// <summary>AssemblyName.GetAssemblyName() is not supported on this platform.</summary>
        internal static string @PlatformNotSupported_AssemblyName_GetAssemblyName => GetResourceString("PlatformNotSupported_AssemblyName_GetAssemblyName");
        /// <summary>CompareOptions = {0} are not supported when HybridGlobalization=true on this platform. Disable it to load larger ICU bundle, then use this option.</summary>
        internal static string @PlatformNotSupported_HybridGlobalizationWithCompareOptions => GetResourceString("PlatformNotSupported_HybridGlobalizationWithCompareOptions");
        /// <summary>Mixed compositions in string not supported when HybridGlobalization=true on this platform. Disable it to load larger ICU bundle, then use this option.</summary>
        internal static string @PlatformNotSupported_HybridGlobalizationWithMixedCompositions => GetResourceString("PlatformNotSupported_HybridGlobalizationWithMixedCompositions");
        /// <summary>CompareOptions = {0} are not supported for culture = {1} when HybridGlobalization=true on this platform. Disable it to load larger ICU bundle, then use this option.</summary>
        internal static string @PlatformNotSupported_HybridGlobalizationWithCompareOptionsForCulture => GetResourceString("PlatformNotSupported_HybridGlobalizationWithCompareOptionsForCulture");
        /// <summary>Match length calculation is not supported when HybridGlobalization=true. Disable it to load larger ICU bundle, then use this function.</summary>
        internal static string @PlatformNotSupported_HybridGlobalizationWithMatchLength => GetResourceString("PlatformNotSupported_HybridGlobalizationWithMatchLength");
        /// <summary>Arrays with non-zero lower bounds are not supported.</summary>
        internal static string @PlatformNotSupported_NonZeroLowerBound => GetResourceString("PlatformNotSupported_NonZeroLowerBound");
        /// <summary>{0} is not supported when HybridGlobalization=true. Disable it to load larger ICU bundle, then use this option.</summary>
        internal static string @PlatformNotSupported_HybridGlobalization => GetResourceString("PlatformNotSupported_HybridGlobalization");
        /// <summary>The body of this method was removed by the AOT compiler because it's not callable.</summary>
        internal static string @NotSupported_BodyRemoved => GetResourceString("NotSupported_BodyRemoved");
        /// <summary>The feature associated with this method was removed.</summary>
        internal static string @NotSupported_FeatureBodyRemoved => GetResourceString("NotSupported_FeatureBodyRemoved");
        /// <summary>This method is not implemented for incomplete types.</summary>
        internal static string @NotSupported_IncompleteTypes => GetResourceString("NotSupported_IncompleteTypes");
        /// <summary>The body of this instance method was removed by the AOT compiler. This can happen if the owning type was not seen as allocated by the AOT compiler.</summary>
        internal static string @NotSupported_InstanceBodyRemoved => GetResourceString("NotSupported_InstanceBodyRemoved");
        /// <summary>Attempted to load a type that was not created during ahead of time compilation.</summary>
        internal static string @Arg_UnavailableTypeLoadException => GetResourceString("Arg_UnavailableTypeLoadException");
        /// <summary>A type initializer threw an exception. To determine which type, inspect the InnerException's StackTrace property.</summary>
        internal static string @TypeInitialization_Type_NoTypeAvailable => GetResourceString("TypeInitialization_Type_NoTypeAvailable");
        /// <summary>Invalid assembly public key.</summary>
        internal static string @Security_InvalidAssemblyPublicKey => GetResourceString("Security_InvalidAssemblyPublicKey");
        /// <summary>Could not load type '{0}' from assembly '{1}'.</summary>
        internal static string @ClassLoad_General => GetResourceString("ClassLoad_General");
        /// <summary>Could not load type, method or field '0x{0:x}' from assembly '0x{1:x}'.</summary>
        internal static string @ClassLoad_General_Hex => GetResourceString("ClassLoad_General_Hex");
        /// <summary>'{0}' from assembly '{1}' has too many dimensions.</summary>
        internal static string @ClassLoad_RankTooLarge => GetResourceString("ClassLoad_RankTooLarge");
        /// <summary>InlineArrayAttribute requires that the target type has a single instance field. Type: '{0}'.  Assembly: '{1}'.</summary>
        internal static string @ClassLoad_InlineArrayFieldCount => GetResourceString("ClassLoad_InlineArrayFieldCount");
        /// <summary>InlineArrayAttribute requires that the length argument is greater than 0. Type: '{0}'.  Assembly: '{1}'.</summary>
        internal static string @ClassLoad_InlineArrayLength => GetResourceString("ClassLoad_InlineArrayLength");
        /// <summary>InlineArrayAttribute cannot be applied to a type with explicit layout. Type: '{0}'.  Assembly: '{1}'.</summary>
        internal static string @ClassLoad_InlineArrayExplicit => GetResourceString("ClassLoad_InlineArrayExplicit");
        /// <summary>Could not load type '{0}' from assembly '{1}' because generic types cannot have explicit layout.</summary>
        internal static string @ClassLoad_ExplicitGeneric => GetResourceString("ClassLoad_ExplicitGeneric");
        /// <summary>Could not load type '{0}' from assembly '{1}' because the format is invalid.</summary>
        internal static string @ClassLoad_BadFormat => GetResourceString("ClassLoad_BadFormat");
        /// <summary>Array of type '{0}' from assembly '{1}' cannot be created because base value type is too large.</summary>
        internal static string @ClassLoad_ValueClassTooLarge => GetResourceString("ClassLoad_ValueClassTooLarge");
        /// <summary>Could not load type '{0}' from assembly '{1}' because it contains an object field at offset '{2}' that is incorrectly aligned or overlapped by a non-object field.</summary>
        internal static string @ClassLoad_ExplicitLayout => GetResourceString("ClassLoad_ExplicitLayout");
        /// <summary>Method not found: '{0}'.</summary>
        internal static string @EE_MissingMethod => GetResourceString("EE_MissingMethod");
        /// <summary>Field not found: '{0}'.</summary>
        internal static string @EE_MissingField => GetResourceString("EE_MissingField");
        /// <summary>Common Language Runtime detected an invalid program. The body of method '{0}' is invalid.</summary>
        internal static string @InvalidProgram_Specific => GetResourceString("InvalidProgram_Specific");
        /// <summary>Method '{0}' has a variable argument list. Variable argument lists are not supported in .NET Core.</summary>
        internal static string @InvalidProgram_Vararg => GetResourceString("InvalidProgram_Vararg");
        /// <summary>Object.Finalize() can not be called directly. It is only callable by the runtime.</summary>
        internal static string @InvalidProgram_CallVirtFinalize => GetResourceString("InvalidProgram_CallVirtFinalize");
        /// <summary>Multiple unmanaged calling conventions are specified. Only a single calling convention is supported.</summary>
        internal static string @InvalidProgram_MultipleCallConv => GetResourceString("InvalidProgram_MultipleCallConv");
        /// <summary>The corresponding delegate has been garbage collected. Please make sure the delegate is still referenced by managed code when you are using the marshalled native function pointer.</summary>
        internal static string @Delegate_GarbageCollected => GetResourceString("Delegate_GarbageCollected");
        /// <summary>Unable to find an entry point named '{0}' in native library '{1}'.</summary>
        internal static string @Arg_EntryPointNotFoundExceptionParameterized => GetResourceString("Arg_EntryPointNotFoundExceptionParameterized");
        /// <summary>Unable to find an entry point named '{0}' in native library.</summary>
        internal static string @Arg_EntryPointNotFoundExceptionParameterizedNoLibrary => GetResourceString("Arg_EntryPointNotFoundExceptionParameterizedNoLibrary");
        /// <summary>Unable to load DLL '{0}' or one of its dependencies: {1}</summary>
        internal static string @DllNotFound_Windows => GetResourceString("DllNotFound_Windows");
        /// <summary>Unable to load shared library '{0}' or one of its dependencies. In order to help diagnose loading problems, consider using a tool like strace. If you're using glibc, consider setting the LD_DEBUG environment variable: {1}</summary>
        internal static string @DllNotFound_Linux => GetResourceString("DllNotFound_Linux");
        /// <summary>Unable to load shared library '{0}' or one of its dependencies. In order to help diagnose loading problems, consider setting the DYLD_PRINT_LIBRARIES environment variable: {1}</summary>
        internal static string @DllNotFound_Mac => GetResourceString("DllNotFound_Mac");
        /// <summary>COM Interop requires ComWrapper instance registered for marshalling.</summary>
        internal static string @InvalidOperation_ComInteropRequireComWrapperInstance => GetResourceString("InvalidOperation_ComInteropRequireComWrapperInstance");
        /// <summary>COM Interop requires ComWrapper instance registered for reference tracker support.</summary>
        internal static string @InvalidOperation_ComInteropRequireComWrapperTrackerInstance => GetResourceString("InvalidOperation_ComInteropRequireComWrapperTrackerInstance");
        /// <summary>Must not be greater than the length of the buffer.</summary>
        internal static string @ArgumentOutOfRange_NotGreaterThanBufferLength => GetResourceString("ArgumentOutOfRange_NotGreaterThanBufferLength");
        /// <summary>'{0}' is missing structure marshalling data. This can happen for code that is not compatible with AOT. Inspect and fix AOT related warnings that were generated when the app was published. For more information see https://aka.ms/nativeaot-compatibility</summary>
        internal static string @StructMarshalling_MissingInteropData => GetResourceString("StructMarshalling_MissingInteropData");
        /// <summary>'{0}' is missing delegate marshalling data. This can happen for code that is not compatible with AOT. Inspect and fix AOT related warnings that were generated when the app was published. For more information see https://aka.ms/nativeaot-compatibility</summary>
        internal static string @DelegateMarshalling_MissingInteropData => GetResourceString("DelegateMarshalling_MissingInteropData");
        /// <summary>Type names passed to Assembly.GetType() must not specify an assembly.</summary>
        internal static string @Argument_AssemblyGetTypeCannotSpecifyAssembly => GetResourceString("Argument_AssemblyGetTypeCannotSpecifyAssembly");
        /// <summary>There is no metadata token available for the given member.</summary>
        internal static string @NoMetadataTokenAvailable => GetResourceString("NoMetadataTokenAvailable");
        /// <summary>The type '{0}' may not be used as a type argument.</summary>
        internal static string @ArgumentException_InvalidTypeArgument => GetResourceString("ArgumentException_InvalidTypeArgument");
        /// <summary>The type '{0}' may not be used as an array element type.</summary>
        internal static string @ArgumentException_InvalidArrayElementType => GetResourceString("ArgumentException_InvalidArrayElementType");
        /// <summary>TypeHandles are not supported for types that return true for ContainsGenericParameters.</summary>
        internal static string @PlatformNotSupported_NoTypeHandleForOpenTypes => GetResourceString("PlatformNotSupported_NoTypeHandleForOpenTypes");
        /// <summary>The type '{0}' was created by a custom ReflectionContext and cannot be used here.</summary>
        internal static string @Reflection_CustomReflectionObjectsNotSupported => GetResourceString("Reflection_CustomReflectionObjectsNotSupported");
        /// <summary>Type can't be a byref type.</summary>
        internal static string @Argument_CannotBeByRefType => GetResourceString("Argument_CannotBeByRefType");
        /// <summary>Cannot create a byref of a byref: {0}</summary>
        internal static string @CannotCreateByRefOfByRef => GetResourceString("CannotCreateByRefOfByRef");
        /// <summary>Cannot create a pointer to a byref: {0}</summary>
        internal static string @CannotCreatePointerOfByRef => GetResourceString("CannotCreatePointerOfByRef");
        /// <summary>The type '{0}' cannot be found.</summary>
        internal static string @TypeLoad_TypeNotFound => GetResourceString("TypeLoad_TypeNotFound");
        /// <summary>The type '{0}' cannot be found in assembly '{1}'.</summary>
        internal static string @TypeLoad_TypeNotFoundInAssembly => GetResourceString("TypeLoad_TypeNotFoundInAssembly");
        /// <summary>Method '{0}' overrides '{1}' but it is not virtual.</summary>
        internal static string @TypeLoad_MethodOverrideNotVirtual => GetResourceString("TypeLoad_MethodOverrideNotVirtual");
        /// <summary>Cannot load assembly '{0}'. No metadata found for this assembly.</summary>
        internal static string @FileNotFound_AssemblyNotFound => GetResourceString("FileNotFound_AssemblyNotFound");
        /// <summary>The value may not contain directory separator characters.</summary>
        internal static string @Argument_DirectorySeparatorInvalid => GetResourceString("Argument_DirectorySeparatorInvalid");
        /// <summary>Method may only be called on a Type for which Type.IsFunctionPointer is true.</summary>
        internal static string @InvalidOperation_NotFunctionPointer => GetResourceString("InvalidOperation_NotFunctionPointer");
        /// <summary>Modified types do not support this member. Use the UnderlyingSystemType property to call this member.</summary>
        internal static string @NotSupported_ModifiedType => GetResourceString("NotSupported_ModifiedType");
        /// <summary>An unexpected state object was encountered. This is usually a sign of a bug in async method custom infrastructure, such as a custom awaiter or IValueTaskSource implementation.</summary>
        internal static string @Argument_UnexpectedStateForKnownCallback => GetResourceString("Argument_UnexpectedStateForKnownCallback");
        /// <summary>String length exceeded supported range.</summary>
        internal static string @OutOfMemory_StringTooLong => GetResourceString("OutOfMemory_StringTooLong");

    }
}
