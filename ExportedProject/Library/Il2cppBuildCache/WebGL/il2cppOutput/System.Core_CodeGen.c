#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000F TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Collections.Generic.Dictionary`2<TKey,TElement> System.Linq.Enumerable::ToDictionary(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>,System.Func`2<TSource,TElement>)
// 0x00000012 System.Collections.Generic.Dictionary`2<TKey,TElement> System.Linq.Enumerable::ToDictionary(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>,System.Func`2<TSource,TElement>,System.Collections.Generic.IEqualityComparer`1<TKey>)
// 0x00000013 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000014 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000015 TSource System.Linq.Enumerable::Last(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000016 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000017 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000018 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000019 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001A System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001B System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001C System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x0000001D System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001E System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001F TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000020 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000021 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000022 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000023 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000024 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000025 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000026 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000027 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000028 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000029 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002A System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000002B System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x0000002C System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x0000002D System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002F System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000030 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000031 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000032 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000033 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000034 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000035 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000036 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000037 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000038 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000039 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003A System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000003B System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x0000003C System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x0000003D System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003F System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000040 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000041 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000042 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000043 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000044 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000045 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000046 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000047 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000048 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000049 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000004A System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000004B System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x0000004C TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x0000004D System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004E System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x0000004F System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000050 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000051 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x00000052 TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000053 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000054 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000055 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000056 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000057 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000058 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000059 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x0000005A System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x0000005B TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x0000005C System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000005D System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005E System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000005F System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000060 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000061 System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x00000062 System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000063 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000064 System.Void System.Linq.Set`1::Resize()
// 0x00000065 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000066 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000067 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000068 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000069 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006A System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x0000006B System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x0000006C System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x0000006D System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x0000006E TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x0000006F System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x00000070 System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x00000071 System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000072 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000073 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000074 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000075 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000076 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000077 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000078 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000079 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x0000007A System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x0000007B System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x0000007C TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000007D System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x0000007E System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000007F System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000080 System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x00000081 System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x00000082 System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000083 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000084 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000085 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000086 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000087 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000088 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000089 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000008A System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000008B System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x0000008C System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000008D System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x0000008E System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x0000008F System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x00000090 System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x00000091 System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x00000092 System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000093 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000094 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000095 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000096 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000097 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000098 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000099 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[153] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[153] = 
{
	3750,
	3750,
	3871,
	3871,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[52] = 
{
	{ 0x02000004, { 85, 4 } },
	{ 0x02000005, { 89, 9 } },
	{ 0x02000006, { 100, 7 } },
	{ 0x02000007, { 109, 10 } },
	{ 0x02000008, { 121, 11 } },
	{ 0x02000009, { 135, 9 } },
	{ 0x0200000A, { 147, 12 } },
	{ 0x0200000B, { 162, 1 } },
	{ 0x0200000C, { 163, 2 } },
	{ 0x0200000D, { 165, 12 } },
	{ 0x0200000E, { 177, 11 } },
	{ 0x02000010, { 188, 8 } },
	{ 0x02000012, { 196, 3 } },
	{ 0x02000013, { 201, 5 } },
	{ 0x02000014, { 206, 7 } },
	{ 0x02000015, { 213, 3 } },
	{ 0x02000016, { 216, 7 } },
	{ 0x02000017, { 223, 4 } },
	{ 0x02000018, { 227, 21 } },
	{ 0x0200001A, { 248, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 1 } },
	{ 0x0600000E, { 37, 2 } },
	{ 0x0600000F, { 39, 3 } },
	{ 0x06000010, { 42, 2 } },
	{ 0x06000011, { 44, 1 } },
	{ 0x06000012, { 45, 7 } },
	{ 0x06000013, { 52, 4 } },
	{ 0x06000014, { 56, 3 } },
	{ 0x06000015, { 59, 4 } },
	{ 0x06000016, { 63, 3 } },
	{ 0x06000017, { 66, 3 } },
	{ 0x06000018, { 69, 1 } },
	{ 0x06000019, { 70, 3 } },
	{ 0x0600001A, { 73, 2 } },
	{ 0x0600001B, { 75, 3 } },
	{ 0x0600001C, { 78, 2 } },
	{ 0x0600001D, { 80, 5 } },
	{ 0x0600002D, { 98, 2 } },
	{ 0x06000032, { 107, 2 } },
	{ 0x06000037, { 119, 2 } },
	{ 0x0600003D, { 132, 3 } },
	{ 0x06000042, { 144, 3 } },
	{ 0x06000047, { 159, 3 } },
	{ 0x06000069, { 199, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[250] = 
{
	{ (Il2CppRGCTXDataType)2, 1826 },
	{ (Il2CppRGCTXDataType)3, 7236 },
	{ (Il2CppRGCTXDataType)2, 3141 },
	{ (Il2CppRGCTXDataType)2, 2686 },
	{ (Il2CppRGCTXDataType)3, 14417 },
	{ (Il2CppRGCTXDataType)2, 1947 },
	{ (Il2CppRGCTXDataType)2, 2693 },
	{ (Il2CppRGCTXDataType)3, 14461 },
	{ (Il2CppRGCTXDataType)2, 2688 },
	{ (Il2CppRGCTXDataType)3, 14424 },
	{ (Il2CppRGCTXDataType)2, 1827 },
	{ (Il2CppRGCTXDataType)3, 7237 },
	{ (Il2CppRGCTXDataType)2, 3163 },
	{ (Il2CppRGCTXDataType)2, 2695 },
	{ (Il2CppRGCTXDataType)3, 14468 },
	{ (Il2CppRGCTXDataType)2, 1967 },
	{ (Il2CppRGCTXDataType)2, 2703 },
	{ (Il2CppRGCTXDataType)3, 14534 },
	{ (Il2CppRGCTXDataType)2, 2699 },
	{ (Il2CppRGCTXDataType)3, 14498 },
	{ (Il2CppRGCTXDataType)2, 646 },
	{ (Il2CppRGCTXDataType)3, 56 },
	{ (Il2CppRGCTXDataType)3, 57 },
	{ (Il2CppRGCTXDataType)2, 1170 },
	{ (Il2CppRGCTXDataType)3, 5513 },
	{ (Il2CppRGCTXDataType)2, 647 },
	{ (Il2CppRGCTXDataType)3, 70 },
	{ (Il2CppRGCTXDataType)3, 71 },
	{ (Il2CppRGCTXDataType)2, 1184 },
	{ (Il2CppRGCTXDataType)3, 5519 },
	{ (Il2CppRGCTXDataType)3, 16879 },
	{ (Il2CppRGCTXDataType)2, 652 },
	{ (Il2CppRGCTXDataType)3, 104 },
	{ (Il2CppRGCTXDataType)2, 2371 },
	{ (Il2CppRGCTXDataType)3, 11654 },
	{ (Il2CppRGCTXDataType)3, 6062 },
	{ (Il2CppRGCTXDataType)3, 16847 },
	{ (Il2CppRGCTXDataType)2, 648 },
	{ (Il2CppRGCTXDataType)3, 76 },
	{ (Il2CppRGCTXDataType)2, 756 },
	{ (Il2CppRGCTXDataType)3, 1008 },
	{ (Il2CppRGCTXDataType)3, 1009 },
	{ (Il2CppRGCTXDataType)2, 1948 },
	{ (Il2CppRGCTXDataType)3, 7925 },
	{ (Il2CppRGCTXDataType)3, 16900 },
	{ (Il2CppRGCTXDataType)2, 852 },
	{ (Il2CppRGCTXDataType)3, 1615 },
	{ (Il2CppRGCTXDataType)2, 1451 },
	{ (Il2CppRGCTXDataType)2, 1525 },
	{ (Il2CppRGCTXDataType)3, 5517 },
	{ (Il2CppRGCTXDataType)3, 5518 },
	{ (Il2CppRGCTXDataType)3, 1616 },
	{ (Il2CppRGCTXDataType)2, 1754 },
	{ (Il2CppRGCTXDataType)2, 1329 },
	{ (Il2CppRGCTXDataType)2, 1434 },
	{ (Il2CppRGCTXDataType)2, 1521 },
	{ (Il2CppRGCTXDataType)2, 1435 },
	{ (Il2CppRGCTXDataType)2, 1522 },
	{ (Il2CppRGCTXDataType)3, 5515 },
	{ (Il2CppRGCTXDataType)2, 1755 },
	{ (Il2CppRGCTXDataType)2, 1330 },
	{ (Il2CppRGCTXDataType)2, 1436 },
	{ (Il2CppRGCTXDataType)2, 1523 },
	{ (Il2CppRGCTXDataType)2, 1437 },
	{ (Il2CppRGCTXDataType)2, 1524 },
	{ (Il2CppRGCTXDataType)3, 5516 },
	{ (Il2CppRGCTXDataType)2, 1753 },
	{ (Il2CppRGCTXDataType)2, 1433 },
	{ (Il2CppRGCTXDataType)2, 1520 },
	{ (Il2CppRGCTXDataType)2, 1423 },
	{ (Il2CppRGCTXDataType)2, 1424 },
	{ (Il2CppRGCTXDataType)2, 1517 },
	{ (Il2CppRGCTXDataType)3, 5512 },
	{ (Il2CppRGCTXDataType)2, 1328 },
	{ (Il2CppRGCTXDataType)2, 1431 },
	{ (Il2CppRGCTXDataType)2, 1432 },
	{ (Il2CppRGCTXDataType)2, 1519 },
	{ (Il2CppRGCTXDataType)3, 5514 },
	{ (Il2CppRGCTXDataType)2, 1327 },
	{ (Il2CppRGCTXDataType)3, 16834 },
	{ (Il2CppRGCTXDataType)3, 4861 },
	{ (Il2CppRGCTXDataType)2, 1047 },
	{ (Il2CppRGCTXDataType)2, 1426 },
	{ (Il2CppRGCTXDataType)2, 1518 },
	{ (Il2CppRGCTXDataType)2, 1588 },
	{ (Il2CppRGCTXDataType)3, 7238 },
	{ (Il2CppRGCTXDataType)3, 7240 },
	{ (Il2CppRGCTXDataType)2, 445 },
	{ (Il2CppRGCTXDataType)3, 7239 },
	{ (Il2CppRGCTXDataType)3, 7248 },
	{ (Il2CppRGCTXDataType)2, 1830 },
	{ (Il2CppRGCTXDataType)2, 2689 },
	{ (Il2CppRGCTXDataType)3, 14425 },
	{ (Il2CppRGCTXDataType)3, 7249 },
	{ (Il2CppRGCTXDataType)2, 1481 },
	{ (Il2CppRGCTXDataType)2, 1549 },
	{ (Il2CppRGCTXDataType)3, 5526 },
	{ (Il2CppRGCTXDataType)3, 16819 },
	{ (Il2CppRGCTXDataType)2, 2700 },
	{ (Il2CppRGCTXDataType)3, 14499 },
	{ (Il2CppRGCTXDataType)3, 7241 },
	{ (Il2CppRGCTXDataType)2, 1829 },
	{ (Il2CppRGCTXDataType)2, 2687 },
	{ (Il2CppRGCTXDataType)3, 14418 },
	{ (Il2CppRGCTXDataType)3, 5525 },
	{ (Il2CppRGCTXDataType)3, 7242 },
	{ (Il2CppRGCTXDataType)3, 16818 },
	{ (Il2CppRGCTXDataType)2, 2696 },
	{ (Il2CppRGCTXDataType)3, 14469 },
	{ (Il2CppRGCTXDataType)3, 7255 },
	{ (Il2CppRGCTXDataType)2, 1831 },
	{ (Il2CppRGCTXDataType)2, 2694 },
	{ (Il2CppRGCTXDataType)3, 14462 },
	{ (Il2CppRGCTXDataType)3, 7979 },
	{ (Il2CppRGCTXDataType)3, 3866 },
	{ (Il2CppRGCTXDataType)3, 5527 },
	{ (Il2CppRGCTXDataType)3, 3865 },
	{ (Il2CppRGCTXDataType)3, 7256 },
	{ (Il2CppRGCTXDataType)3, 16820 },
	{ (Il2CppRGCTXDataType)2, 2704 },
	{ (Il2CppRGCTXDataType)3, 14535 },
	{ (Il2CppRGCTXDataType)3, 7269 },
	{ (Il2CppRGCTXDataType)2, 1833 },
	{ (Il2CppRGCTXDataType)2, 2702 },
	{ (Il2CppRGCTXDataType)3, 14501 },
	{ (Il2CppRGCTXDataType)3, 7270 },
	{ (Il2CppRGCTXDataType)2, 1484 },
	{ (Il2CppRGCTXDataType)2, 1552 },
	{ (Il2CppRGCTXDataType)3, 5531 },
	{ (Il2CppRGCTXDataType)3, 5530 },
	{ (Il2CppRGCTXDataType)2, 2691 },
	{ (Il2CppRGCTXDataType)3, 14427 },
	{ (Il2CppRGCTXDataType)3, 16828 },
	{ (Il2CppRGCTXDataType)2, 2701 },
	{ (Il2CppRGCTXDataType)3, 14500 },
	{ (Il2CppRGCTXDataType)3, 7262 },
	{ (Il2CppRGCTXDataType)2, 1832 },
	{ (Il2CppRGCTXDataType)2, 2698 },
	{ (Il2CppRGCTXDataType)3, 14471 },
	{ (Il2CppRGCTXDataType)3, 5529 },
	{ (Il2CppRGCTXDataType)3, 5528 },
	{ (Il2CppRGCTXDataType)3, 7263 },
	{ (Il2CppRGCTXDataType)2, 2690 },
	{ (Il2CppRGCTXDataType)3, 14426 },
	{ (Il2CppRGCTXDataType)3, 16827 },
	{ (Il2CppRGCTXDataType)2, 2697 },
	{ (Il2CppRGCTXDataType)3, 14470 },
	{ (Il2CppRGCTXDataType)3, 7276 },
	{ (Il2CppRGCTXDataType)2, 1834 },
	{ (Il2CppRGCTXDataType)2, 2706 },
	{ (Il2CppRGCTXDataType)3, 14537 },
	{ (Il2CppRGCTXDataType)3, 7980 },
	{ (Il2CppRGCTXDataType)3, 3868 },
	{ (Il2CppRGCTXDataType)3, 5533 },
	{ (Il2CppRGCTXDataType)3, 5532 },
	{ (Il2CppRGCTXDataType)3, 3867 },
	{ (Il2CppRGCTXDataType)3, 7277 },
	{ (Il2CppRGCTXDataType)2, 2692 },
	{ (Il2CppRGCTXDataType)3, 14428 },
	{ (Il2CppRGCTXDataType)3, 16829 },
	{ (Il2CppRGCTXDataType)2, 2705 },
	{ (Il2CppRGCTXDataType)3, 14536 },
	{ (Il2CppRGCTXDataType)3, 5522 },
	{ (Il2CppRGCTXDataType)3, 5523 },
	{ (Il2CppRGCTXDataType)3, 5534 },
	{ (Il2CppRGCTXDataType)3, 107 },
	{ (Il2CppRGCTXDataType)3, 106 },
	{ (Il2CppRGCTXDataType)2, 1476 },
	{ (Il2CppRGCTXDataType)2, 1545 },
	{ (Il2CppRGCTXDataType)3, 5524 },
	{ (Il2CppRGCTXDataType)2, 1490 },
	{ (Il2CppRGCTXDataType)2, 1563 },
	{ (Il2CppRGCTXDataType)3, 109 },
	{ (Il2CppRGCTXDataType)2, 577 },
	{ (Il2CppRGCTXDataType)2, 653 },
	{ (Il2CppRGCTXDataType)3, 105 },
	{ (Il2CppRGCTXDataType)3, 108 },
	{ (Il2CppRGCTXDataType)3, 78 },
	{ (Il2CppRGCTXDataType)2, 2463 },
	{ (Il2CppRGCTXDataType)3, 13142 },
	{ (Il2CppRGCTXDataType)2, 1473 },
	{ (Il2CppRGCTXDataType)2, 1543 },
	{ (Il2CppRGCTXDataType)3, 13143 },
	{ (Il2CppRGCTXDataType)3, 80 },
	{ (Il2CppRGCTXDataType)2, 442 },
	{ (Il2CppRGCTXDataType)2, 649 },
	{ (Il2CppRGCTXDataType)3, 77 },
	{ (Il2CppRGCTXDataType)3, 79 },
	{ (Il2CppRGCTXDataType)3, 4894 },
	{ (Il2CppRGCTXDataType)2, 1061 },
	{ (Il2CppRGCTXDataType)2, 3248 },
	{ (Il2CppRGCTXDataType)3, 13139 },
	{ (Il2CppRGCTXDataType)3, 13140 },
	{ (Il2CppRGCTXDataType)2, 1602 },
	{ (Il2CppRGCTXDataType)3, 13141 },
	{ (Il2CppRGCTXDataType)2, 378 },
	{ (Il2CppRGCTXDataType)2, 650 },
	{ (Il2CppRGCTXDataType)3, 90 },
	{ (Il2CppRGCTXDataType)3, 11641 },
	{ (Il2CppRGCTXDataType)2, 2372 },
	{ (Il2CppRGCTXDataType)3, 11655 },
	{ (Il2CppRGCTXDataType)2, 757 },
	{ (Il2CppRGCTXDataType)3, 1010 },
	{ (Il2CppRGCTXDataType)3, 11647 },
	{ (Il2CppRGCTXDataType)3, 3841 },
	{ (Il2CppRGCTXDataType)2, 475 },
	{ (Il2CppRGCTXDataType)3, 11642 },
	{ (Il2CppRGCTXDataType)2, 2368 },
	{ (Il2CppRGCTXDataType)3, 1048 },
	{ (Il2CppRGCTXDataType)2, 771 },
	{ (Il2CppRGCTXDataType)2, 1022 },
	{ (Il2CppRGCTXDataType)3, 3847 },
	{ (Il2CppRGCTXDataType)3, 11643 },
	{ (Il2CppRGCTXDataType)3, 3836 },
	{ (Il2CppRGCTXDataType)3, 3837 },
	{ (Il2CppRGCTXDataType)3, 3835 },
	{ (Il2CppRGCTXDataType)3, 3838 },
	{ (Il2CppRGCTXDataType)2, 1018 },
	{ (Il2CppRGCTXDataType)2, 3211 },
	{ (Il2CppRGCTXDataType)3, 5521 },
	{ (Il2CppRGCTXDataType)3, 3840 },
	{ (Il2CppRGCTXDataType)2, 1408 },
	{ (Il2CppRGCTXDataType)3, 3839 },
	{ (Il2CppRGCTXDataType)2, 1331 },
	{ (Il2CppRGCTXDataType)2, 3166 },
	{ (Il2CppRGCTXDataType)2, 1452 },
	{ (Il2CppRGCTXDataType)2, 1526 },
	{ (Il2CppRGCTXDataType)3, 4877 },
	{ (Il2CppRGCTXDataType)2, 1055 },
	{ (Il2CppRGCTXDataType)3, 5895 },
	{ (Il2CppRGCTXDataType)3, 5896 },
	{ (Il2CppRGCTXDataType)3, 5901 },
	{ (Il2CppRGCTXDataType)2, 1597 },
	{ (Il2CppRGCTXDataType)3, 5898 },
	{ (Il2CppRGCTXDataType)3, 17263 },
	{ (Il2CppRGCTXDataType)2, 1024 },
	{ (Il2CppRGCTXDataType)3, 3859 },
	{ (Il2CppRGCTXDataType)1, 1405 },
	{ (Il2CppRGCTXDataType)2, 3176 },
	{ (Il2CppRGCTXDataType)3, 5897 },
	{ (Il2CppRGCTXDataType)1, 3176 },
	{ (Il2CppRGCTXDataType)1, 1597 },
	{ (Il2CppRGCTXDataType)2, 3246 },
	{ (Il2CppRGCTXDataType)2, 3176 },
	{ (Il2CppRGCTXDataType)3, 5902 },
	{ (Il2CppRGCTXDataType)3, 5900 },
	{ (Il2CppRGCTXDataType)3, 5899 },
	{ (Il2CppRGCTXDataType)2, 315 },
	{ (Il2CppRGCTXDataType)3, 3869 },
	{ (Il2CppRGCTXDataType)2, 455 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	153,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	52,
	s_rgctxIndices,
	250,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
