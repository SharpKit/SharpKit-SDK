class JsCompiler
{
ctor(){return null;}
Compile_Direct():void{return null;}
Compile_Phase1():void{return null;}
Compile_Phase2():void{return null;}
Compile_Phase2_TmpType(tmpType:Object):void{return null;}
LinkInterfaceMethods():void{return null;}
Compile_Phase3():void{return null;}
CopyMemberIfNotDefined(source:any,name:string,target:any):void{return null;}
_CopyObject(source:any,target:any):void{return null;}
_SafeCopyObject(source:Object,target:Object):void{return null;}
_EnumTryParse(name:String):any{return null;}
NewByFunc(ctor:Function):any{return null;}
NewByFuncArgs(ctor:Function,args:Array<any>):any{return null;}
GetNativeToStringFunction():Function{return null;}
Throw(exception:System.Exception):void{return null;}
CreateEmptyCtor():Function{return null;}
CreateBaseCtor(type:Object):Function{return null;}
Global2():void{return null;}
ResolveNamespace(nsText:String):Object{return null;}
ResolveBaseType(type:Object,currentType:Object):void{return null;}
ResolveInterfaces(type:Object,currentType:Object):void{return null;}
CompileType(type:Object):Object{return null;}
CompileEnum(currentType:Object):void{return null;}
GetHashKey(obj:any):String{return null;}
}
module SharpKit.JavaScript.Compilation
{
export class JsCompilerGlobal
{
ctor(){return null;}
RemoveDelegate(delOriginal:Function,delToRemove:Function):Function{return null;}
CombineDelegates(del1:Function,del2:Function):Function{return null;}
CreateMulticastDelegateFunction():Function{return null;}
CreateClrDelegate(type:Object,genericArgs:Array<Object>,target:any,func:Function):Function{return null;}
Typeof(jsTypeOrName:any):System.Type{return null;}
JsTypeof(typeName:string):Object{return null;}
New(typeName:string,args:Array<any>):any{return null;}
NewWithInitializer(type:Object,json:Object):any{return null;}
As(obj:any,typeOrName:string):any{return null;}
Cast(obj:any,typeOrName:string):any{return null;}
_TestTypeInterfacesIs(testType:Object,iface:Object,testedInterfaces:Object):boolean{return null;}
TypeIs(objType:Object,type:Object):boolean{return null;}
Is(obj:any,typeOrName:any):boolean{return null;}
Default(T:any):any{return null;}
GetObjectType(obj:any):Object{return null;}
TryImplicitConvert(obj:any,type:Object):any{return null;}
Compile():void{return null;}
AfterCompilation(func:Object):void{return null;}
AfterNextCompilation(func:Object):void{return null;}
BeforeCompilation(func:Object):void{return null;}
}

}
class JsTypeHelper
{
ctor(){return null;}
GetTypeIgnoreNamespace(name:string,throwIfNotFound:boolean):Object{return null;}
_HasTypeArguments(typeName:string):boolean{return null;}
_GetTypeWithArguments(typeName:string,throwIfNotFound:boolean):Array<any>{return null;}
_ParseTypeNameArgs(name:string):Array<any>{return null;}
GetType(typeOrNameOrCtor:any,throwIfNotFound:boolean):Object{return null;}
FindType(name:string,throwIfNotFound:boolean):Object{return null;}
GetAssemblyQualifiedName(type:Object):string{return null;}
GetName(type:Object):string{return null;}
getMemberTypeName(instance:Object,memberName:String):String{return null;}
GetDelegate(obj:any,func:Function):Function{return null;}
}
module System
{
export class Activator
{
ctor(){return null;}
CreateInstance$$Type(type:System.Type):any{return null;}
CreateInstance$$Type$$BindingFlags$$Binder$$Object$Array$$CultureInfo(type:System.Type,bindingAttr:System.Reflection.BindingFlags,binder:System.Reflection.Binder,args:Array<any>,culture:System.Globalization.CultureInfo):any{return null;}
CreateInstance$$Type$$BindingFlags$$Binder$$Object$Array$$CultureInfo$$Object$Array(type:System.Type,bindingAttr:System.Reflection.BindingFlags,binder:System.Reflection.Binder,args:Array<any>,culture:System.Globalization.CultureInfo,activationAttributes:Array<any>):any{return null;}
CreateInstance$$Type$$Object$Array(type:System.Type,args:Array<any>):any{return null;}
CreateInstance$$Type$$Object$Array$$Object$Array(type:System.Type,args:Array<any>,activationAttributes:Array<any>):any{return null;}
CreateInstance$$Type$$Boolean(type:System.Type,nonPublic:boolean):any{return null;}
CreateInstance$1<T>():T{return null;}
}

}
module SharpKit.JavaScript.Private
{
export class JsComparerHelper$1<T>
{
ctor(cmp:System.Collections.Generic.IComparer$1<T>){return null;}
Compare(x:T,y:T):number{return null;}
}

}
module System
{
export class Attribute
{
ctor(){return null;}
}

}
module System.Collections
{
export class ArrayList
{
ctor(){return null;}
}

}
module System.Collections
{
export class Comparer
{
ctor(){return null;}
static Default:System.Collections.Comparer;
}

}
module SharpKit.JavaScript.Private
{
export class DefaultComparer
{
ctor(){return null;}
Compare(x:any,y:any):number{return null;}
}

}
module System.Collections.Generic
{
export class Comparer$1<T>
{
ctor(){return null;}
static Default:System.Collections.Generic.Comparer$1<T>;
}

}
module System.Collections.Generic
{
export class Dictionary$2<TKey,TValue>
{
ctor(){return null;}
ctor$$IEqualityComparer$1(comparer:System.Collections.Generic.IEqualityComparer$1<TKey>){return null;}
GetHashKey(key:TKey):string{return null;}
Add(key:TKey,value:TValue):void{return null;}
Remove(key:TKey):boolean{return null;}
Item:TValue;
ContainsKey(key:TKey):boolean{return null;}
Keys:System.Collections.Generic.ICollection$1<TKey>;
Values:System.Collections.Generic.ICollection$1<TValue>;
GetEnumerator():System.Collections.Generic.IEnumerator$1<System.Collections.Generic.KeyValuePair$2<TKey,TValue>>{return null;}
Clear():void{return null;}
TryGetValue(key:TKey,value:TValue):boolean{return null;}
Count:number;
IsReadOnly:boolean;
}

}
module System.Collections.Generic
{
export class KeyNotFoundException
{
ctor(){return null;}
ctor$$String(s:string){return null;}
ctor$$String$$Exception(s:string,innerException:System.Exception){return null;}
}

}
module System.Collections.Generic
{
export class HashSet$1<T>
{
ctor(){return null;}
ctor$$IEqualityComparer$1(comparer:System.Collections.Generic.IEqualityComparer$1<T>){return null;}
GetHashKey(key:T):string{return null;}
Add(item:T):boolean{return null;}
UnionWith(other:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
IntersectWith(other:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
ExceptWith(other:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
SymmetricExceptWith(other:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
IsSubsetOf(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
IsSupersetOf(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
IsProperSupersetOf(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
IsProperSubsetOf(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
Overlaps(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
SetEquals(other:System.Collections.Generic.IEnumerable$1<T>):boolean{return null;}
Count:number;
IsReadOnly:boolean;
Clear():void{return null;}
Contains(item:T):boolean{return null;}
CopyTo(array:Array<any>,arrayIndex:number):void{return null;}
Remove(item:T):boolean{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Collections.Generic
{
export interface IEnumerator$1<T>
{
ctor();
Current:T;
}

}
module System.Collections.Generic
{
export interface IEnumerable$1<T>
{
ctor();
}

}
module System.Collections.Generic
{
export interface IList$1<T>
{
ctor();
}

}
module System.Collections.Generic
{
export interface ICollection$1<T>
{
ctor();
Count:number;
IsReadOnly:boolean;
}

}
module System.Collections.Generic
{
export interface IDictionary$2<K,T>
{
ctor();
}

}
module System.Collections.Generic
{
export interface ISet$1<T>
{
ctor();
}

}
module System.Collections
{
export interface IEqualityComparer
{
ctor();
}

}
module System.Collections.Generic
{
export interface IEqualityComparer$1<T>
{
ctor();
}

}
module System
{
export class StringComparer
{
ctor(){return null;}
static InvariantCultureIgnoreCase:System.StringComparer;
}

}
module SharpKit.JavaScript.Private
{
export class StringComparer_InvariantCultureIgnoreCase
{
ctor(){return null;}
Equals$$T$$T(x:string,y:string):boolean{return null;}
GetHashCode$$T(obj:string):number{return null;}
}

}
module System.Collections.Generic
{
export interface IComparer$1<T>
{
ctor();
}

}
module System.Collections.Generic
{
export class KeyValuePair$2<TKey,TValue>
{
ctor$$TKey$$TValue(key:TKey,value:TValue){return null;}
Key:TKey;
Value:TValue;
ctor(){return null;}
}

}
module System.Collections.Generic
{
export class List$1<T>
{
ctor(){return null;}
ctor$$IEnumerable$1(collection:System.Collections.Generic.IEnumerable$1<T>){return null;}
RemoveRange(index:number,count:number):void{return null;}
Clear():void{return null;}
Item:T;
Count:number;
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
ToArray():Array<any>{return null;}
AddRange(items:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
Add(item:T):void{return null;}
Remove(item:T):boolean{return null;}
Contains(item:T):boolean{return null;}
SetItems(items:System.Collections.Generic.IEnumerable$1<T>):void{return null;}
IndexOf(item:T):number{return null;}
Insert(index:number,item:T):void{return null;}
RemoveAt(index:number):void{return null;}
TryRemove(item:T):boolean{return null;}
CopyTo(array:Array<any>,arrayIndex:number):void{return null;}
IsReadOnly:boolean;
Reverse():void{return null;}
Sort():void{return null;}
Sort$$Comparison$1(comparison:(x:T,y:T)=>number):void{return null;}
ForEach(action:(obj:T)=>void):void{return null;}
}

}
module System
{
export interface Comparison$1<T>
{
(x:T,y:T):number;
}

}
module System.Collections.Generic
{
export class Queue$1<T>
{
ctor(){return null;}
ctor$$Int32(capacity:number){return null;}
ctor$$IEnumerable$1(collection:System.Collections.Generic.IEnumerable$1<T>){return null;}
Clear():void{return null;}
Count:number;
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
ToArray():Array<any>{return null;}
Enqueue(item:T):void{return null;}
Dequeue():any{return null;}
Peek():any{return null;}
Contains(item:T):boolean{return null;}
}

}
module System.Collections.Generic
{
export class Stack$1<T>
{
ctor(){return null;}
ctor$$Int32(capacity:number){return null;}
ctor$$IEnumerable$1(collection:System.Collections.Generic.IEnumerable$1<T>){return null;}
Count:number;
Clear():void{return null;}
ToArray():Array<any>{return null;}
Push(item:T):void{return null;}
Pop():any{return null;}
Peek():any{return null;}
Contains(item:T):boolean{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Collections
{
export interface IDictionary
{
ctor();
IsFixedSize:boolean;
IsReadOnly:boolean;
Item:any;
Keys:System.Collections.ICollection;
Values:System.Collections.ICollection;
}

}
module System.Collections
{
export interface IEnumerable
{
ctor();
}

}
module System.Collections
{
export interface IEnumerator
{
ctor();
}

}
module System.Collections
{
export interface ICollection
{
ctor();
}

}
module System.Collections
{
export interface IList
{
ctor();
}

}
module System.Collections
{
export interface IComparer
{
ctor();
}

}
module System.Collections.Generic
{
export class JsArrayEnumerator$1<T>
{
ctor(list:Array<T>){return null;}
Current:T;
Dispose():void{return null;}
MoveNext():boolean{return null;}
Reset():void{return null;}
}

}
module System.Collections.ObjectModel
{
export class Collection$1<T>
{
ctor(){return null;}
ctor$$IList$1(items:System.Collections.Generic.IList$1<T>){return null;}
Add(item:T):void{return null;}
Clear():void{return null;}
ClearItems():void{return null;}
Contains(item:T):boolean{return null;}
CopyTo(array:Array<any>,index:number):void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
IndexOf(item:T):number{return null;}
Insert(index:number,item:T):void{return null;}
InsertItem(index:number,item:T):void{return null;}
Items:System.Collections.Generic.IList$1<T>;
Remove(item:T):boolean{return null;}
RemoveAt(index:number):void{return null;}
RemoveItem(index:number):void{return null;}
Count:number;
Item:T;
SetItem(index:number,item:T):void{return null;}
ConvertItem(item:any):T{return null;}
CheckWritable(items:System.Collections.Generic.IList$1<T>):void{return null;}
IsSynchronized(items:System.Collections.Generic.IList$1<T>):boolean{return null;}
IsFixedSize(items:System.Collections.Generic.IList$1<T>):boolean{return null;}
IsValidItem(item:any):boolean{return null;}
}

}
module System.Collections.ObjectModel
{
export class ObservableCollection$1<T>
{
ctor(){return null;}
ctor$$IEnumerable$1(collection:System.Collections.Generic.IEnumerable$1<T>){return null;}
ctor$$List$1(list:System.Collections.Generic.List$1<T>){return null;}
CollectionChanged:(sender:any,e:System.Collections.Specialized.NotifyCollectionChangedEventArgs)=>void;
PropertyChanged:(sender:any,e:System.ComponentModel.PropertyChangedEventArgs)=>void;
BlockReentrancy():System.IDisposable{return null;}
CheckReentrancy():void{return null;}
ClearItems():void{return null;}
InsertItem(index:number,item:T):void{return null;}
Move(oldIndex:number,newIndex:number):void{return null;}
MoveItem(oldIndex:number,newIndex:number):void{return null;}
OnCollectionChanged(e:System.Collections.Specialized.NotifyCollectionChangedEventArgs):void{return null;}
OnPropertyChanged(e:System.ComponentModel.PropertyChangedEventArgs):void{return null;}
RemoveItem(index:number):void{return null;}
SetItem(index:number,item:T):void{return null;}
}

}
module System.Collections.ObjectModel.ObservableCollection$1
{
export class Reentrant<T>
{
ctor(){return null;}
Enter():void{return null;}
Dispose():void{return null;}
Busy:boolean;
}

}
module System.Collections.ObjectModel
{
export class ReadOnlyCollection$1<T>
{
ctor(list:System.Collections.Generic.IList$1<T>){return null;}
Contains(value:T):boolean{return null;}
CopyTo(array:Array<any>,index:number):void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
IndexOf(value:T):number{return null;}
Count:number;
Items:System.Collections.Generic.IList$1<T>;
Item:T;
}

}
module System.Collections.ObjectModel
{
export class ReadOnlyObservableCollection$1<T>
{
ctor(list:System.Collections.ObjectModel.ObservableCollection$1<T>){return null;}
CollectionChanged:(sender:any,e:System.Collections.Specialized.NotifyCollectionChangedEventArgs)=>void;
PropertyChanged:(sender:any,e:System.ComponentModel.PropertyChangedEventArgs)=>void;
OnCollectionChanged(args:System.Collections.Specialized.NotifyCollectionChangedEventArgs):void{return null;}
OnPropertyChanged(args:System.ComponentModel.PropertyChangedEventArgs):void{return null;}
SourceCollection_CollectionChanged(sender:any,e:System.Collections.Specialized.NotifyCollectionChangedEventArgs):void{return null;}
SourceCollection_PropertyChanged(sender:any,e:System.ComponentModel.PropertyChangedEventArgs):void{return null;}
}

}
module System.Collections.Specialized
{
export class NotifyCollectionChangedAction
{
ctor(){return null;}
}

}
module System.Collections.Specialized
{
export interface INotifyCollectionChanged
{
ctor();
CollectionChanged:(sender:any,e:System.Collections.Specialized.NotifyCollectionChangedEventArgs)=>void;
}

}
module System.Collections.Specialized
{
export class NotifyCollectionChangedEventArgs
{
ctor$$NotifyCollectionChangedAction(action:System.Collections.Specialized.NotifyCollectionChangedAction){return null;}
ctor$$NotifyCollectionChangedAction$$IList(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItems:System.Collections.IList){return null;}
ctor$$NotifyCollectionChangedAction$$Object(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItem:any){return null;}
ctor$$NotifyCollectionChangedAction$$IList$$IList(action:System.Collections.Specialized.NotifyCollectionChangedAction,newItems:System.Collections.IList,oldItems:System.Collections.IList){return null;}
ctor$$NotifyCollectionChangedAction$$IList$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItems:System.Collections.IList,startingIndex:number){return null;}
ctor$$NotifyCollectionChangedAction$$Object$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItem:any,index:number){return null;}
ctor$$NotifyCollectionChangedAction$$Object$$Object(action:System.Collections.Specialized.NotifyCollectionChangedAction,newItem:any,oldItem:any){return null;}
ctor$$NotifyCollectionChangedAction$$IList$$IList$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,newItems:System.Collections.IList,oldItems:System.Collections.IList,startingIndex:number){return null;}
ctor$$NotifyCollectionChangedAction$$IList$$Int32$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItems:System.Collections.IList,index:number,oldIndex:number){return null;}
ctor$$NotifyCollectionChangedAction$$Object$$Int32$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,changedItem:any,index:number,oldIndex:number){return null;}
ctor$$NotifyCollectionChangedAction$$Object$$Object$$Int32(action:System.Collections.Specialized.NotifyCollectionChangedAction,newItem:any,oldItem:any,index:number){return null;}
Action:System.Collections.Specialized.NotifyCollectionChangedAction;
NewItems:System.Collections.IList;
NewStartingIndex:number;
OldItems:System.Collections.IList;
OldStartingIndex:number;
InitializeAdd(items:System.Collections.IList,index:number):void{return null;}
InitializeRemove(items:System.Collections.IList,index:number):void{return null;}
InitializeMove(changedItems:System.Collections.IList,newItemIndex:number,oldItemIndex:number):void{return null;}
InitializeReplace(addedItems:System.Collections.IList,removedItems:System.Collections.IList,index:number):void{return null;}
}

}
module System.ComponentModel
{
export interface AsyncCompletedEventHandler
{
(sender:any,e:System.ComponentModel.AsyncCompletedEventArgs):void;
}

}
module System.ComponentModel
{
export class AsyncCompletedEventArgs
{
ctor(error:System.Exception,cancelled:boolean,userState:any){return null;}
RaiseExceptionIfNecessary():void{return null;}
Cancelled:boolean;
Error:System.Exception;
UserState:any;
}

}
module System.ComponentModel
{
export interface CancelEventHandler
{
(sender:any,e:System.ComponentModel.CancelEventArgs):void;
}

}
module System.ComponentModel
{
export class CancelEventArgs
{
ctor(){return null;}
ctor$$Boolean(cancel:boolean){return null;}
Cancel:boolean;
}

}
module System.ComponentModel
{
export class ListSortDirection
{
ctor(){return null;}
}

}
module System.ComponentModel
{
export interface INotifyPropertyChanging
{
ctor();
}

}
module System.ComponentModel
{
export interface INotifyPropertyChanged
{
ctor();
}

}
module System.ComponentModel
{
export interface PropertyChangedEventHandler
{
(sender:any,e:System.ComponentModel.PropertyChangedEventArgs):void;
}

}
module System.ComponentModel
{
export class PropertyChangedEventArgs
{
ctor(propertyName:string){return null;}
PropertyName:string;
}

}
module System
{
export class DateTime
{
ctor(){return null;}
ctor$$Int64(ticks:number){return null;}
ctor$$Int32$$Int32$$Int32(year:number,month:number,day:number){return null;}
ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32(year:number,month:number,day:number,hour:number,minute:number,second:number){return null;}
ctor$$Int32$$Int32$$Int32$$Int32$$Int32$$Int32$$DateTimeKind(year:number,month:number,day:number,hour:number,minute:number,second:number,kind:System.DateTimeKind){return null;}
cctor(){return null;}
Parse$$String(str:string):System.DateTime{return null;}
DaysInMonth(year:number,month:number):number{return null;}
Compare(t1:System.DateTime,t2:System.DateTime):number{return null;}
op_Equality(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_Inequality(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_GreaterThan$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_LessThan$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_LessThanOrEqual$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_GreaterThanOrEqual$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):boolean{return null;}
op_Subtraction$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):System.TimeSpan{return null;}
op_Subtraction$$DateTime$$TimeSpan(t1:System.DateTime,t2:System.TimeSpan):System.DateTime{return null;}
op_Addition$$DateTime$$DateTime(t1:System.DateTime,t2:System.DateTime):System.TimeSpan{return null;}
op_Addition$$DateTime$$TimeSpan(t1:System.DateTime,t2:System.TimeSpan):System.DateTime{return null;}
Equals$$Object(obj:any):boolean{return null;}
GetHashCode():number{return null;}
CompareJsDates(d1:Date,d2:Date):number{return null;}
static Now:System.DateTime;
static UtcNow:System.DateTime;
static Today:System.DateTime;
}

}
module System
{
export class DateTimeKind
{
ctor(){return null;}
}

}
module System
{
export class Delegate
{
ctor(){return null;}
Combine$$Delegate$Array(delegates:Array<any>):System.Delegate{return null;}
Combine$$Delegate$$Delegate(delegate1:System.Delegate,delegate2:System.Delegate):System.Delegate{return null;}
Remove(delegate1:System.Delegate,delegate2:System.Delegate):System.Delegate{return null;}
DynamicInvoke(args:Array<any>):any{return null;}
}

}
module System
{
export class MulticastDelegate
{
ctor(){return null;}
GetInvocationList():Array<any>{return null;}
Equals$$MulticastDelegate(del:System.MulticastDelegate):boolean{return null;}
Invoke(varargs:Array<any>):any{return null;}
}

}
module System
{
export interface Action
{
():void;
}

}
module System
{
export interface Action$1<T>
{
(obj:T):void;
}

}
module System
{
export interface Action$2<T1,T2>
{
(arg1:T1,arg2:T2):void;
}

}
module System
{
export interface Action$3<T1,T2,T3>
{
(arg1:T1,arg2:T2,arg3:T3):void;
}

}
module System
{
export interface Func$1<TResult>
{
():TResult;
}

}
module System
{
export interface Func$2<T,TResult>
{
(obj:T):TResult;
}

}
module System
{
export interface Func$3<T1,T2,TResult>
{
(arg1:T1,arg2:T2):TResult;
}

}
module System
{
export interface Func$4<T1,T2,T3,TResult>
{
(arg1:T1,arg2:T2,arg3:T3):TResult;
}

}
module System
{
export interface EventHandler
{
(sender:any,e:System.EventArgs):void;
}

}
module System
{
export interface EventHandler$1<TEventArgs>
{
(sender:any,e:TEventArgs):void;
}

}
module System
{
export interface Predicate$1<T>
{
(item:T):boolean;
}

}
module System.Diagnostics
{
export class Debugger
{
ctor(){return null;}
Break():void{return null;}
}

}
module System.Diagnostics
{
export class Trace
{
ctor(){return null;}
TraceWarning$$String(msg:string):void{return null;}
TraceWarning$$String$$Object$Array(format:string,args:Array<any>):void{return null;}
}

}
module System
{
export class Enum
{
ctor(){return null;}
GetName(enumType:System.Type,value:any):string{return null;}
GetNames(enumType:System.Type):Array<any>{return null;}
GetValues(enumType:System.Type):Array<any>{return null;}
Parse$$Type$$String(enumType:System.Type,value:string):any{return null;}
Parse$$Type$$String$$Boolean(enumType:System.Type,value:string,ignoreCase:boolean):any{return null;}
}

}
module System
{
export class Environment
{
ctor(){return null;}
GetResourceString(p:string):string{return null;}
static TickCount:number;
}

}
module System
{
export class EventArgs
{
ctor(){return null;}
}

}
module System
{
export class Exception
{
ctor$$String$$Exception(message:string,innerException:System.Exception){return null;}
ctor$$String(message:string){return null;}
ctor(){return null;}
InnerException:System.Exception;
Message:string;
toString():string{return null;}
SetErrorCode(hr:number):void{return null;}
}

}
module System
{
export class NotImplementedException
{
ctor(){return null;}
ctor$$String(s:string){return null;}
}

}
module System
{
export class SystemException
{
ctor(){return null;}
ctor$$String(message:string){return null;}
ctor$$String$$Exception(message:string,innerException:System.Exception){return null;}
}

}
module System
{
export class ArgumentException
{
ctor(){return null;}
ctor$$String(message:string){return null;}
ctor$$String$$Exception(message:string,innerException:System.Exception){return null;}
ctor$$String$$String(message:string,paramName:string){return null;}
ctor$$String$$String$$Exception(message:string,paramName:string,innerException:System.Exception){return null;}
ParamName:string;
}

}
module System
{
export class NullReferenceException
{
ctor(){return null;}
ctor$$String(message:string){return null;}
}

}
module System
{
export class NotSupportedException
{
ctor(){return null;}
ctor$$String(message:string){return null;}
ctor$$String$$Exception(message:string,innerException:System.Exception){return null;}
}

}
module System
{
export class ArgumentOutOfRangeException
{
ctor(){return null;}
ctor$$String(paramName:string){return null;}
ctor$$String$$Exception(message:string,innerException:System.Exception){return null;}
ctor$$String$$String(paramName:string,message:string){return null;}
ctor$$String$$Object$$String(paramName:string,actualValue:any,message:string){return null;}
ActualValue:any;
RangeMessage:string;
}

}
module System
{
export class Guid
{
ctor$$Byte$Array(b:Uint8Array){return null;}
NewGuid():System.Guid{return null;}
ctor$$UInt32$$UInt16$$UInt16$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte(a:number,b:number,c:number,d:number,e:number,f:number,g:number,h:number,i:number,j:number,k:number){return null;}
ctor$$Int32$$Int16$$Int16$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte$$Byte(a:number,b:number,c:number,d:number,e:number,f:number,g:number,h:number,i:number,j:number,k:number){return null;}
AppendByte(builder:System.Text.StringBuilder,value:number):void{return null;}
AppendInt(builder:System.Text.StringBuilder,value:number):void{return null;}
AppendShort(builder:System.Text.StringBuilder,value:number):void{return null;}
CheckArray(o:Uint8Array,l:number):void{return null;}
CheckLength(o:Uint8Array,l:number):void{return null;}
CheckNull(o:any):void{return null;}
Compare(x:number,y:number):number{return null;}
CreateFormatException(s:string):System.Exception{return null;}
ToHex(b:number):string{return null;}
BaseToString(h:boolean,p:boolean,b:boolean):string{return null;}
CompareTo$$Guid(value:System.Guid):number{return null;}
CompareTo$$Object(value:any):number{return null;}
Equals$$Object(o:any):boolean{return null;}
Equals$$Guid(g:System.Guid):boolean{return null;}
GetHashCode():number{return null;}
toString():string{return null;}
ToString$$String(format:string):string{return null;}
ToString$$String$$IFormatProvider(format:string,provider:System.IFormatProvider):string{return null;}
op_Equality(a:System.Guid,b:System.Guid):boolean{return null;}
op_Inequality(a:System.Guid,b:System.Guid):boolean{return null;}
ctor(){return null;}
}

}
module System
{
export interface ICloneable
{
ctor();
}

}
module System
{
export interface IDisposable
{
ctor();
}

}
module System
{
export class Int64
{
ctor(){return null;}
ctor$$Object(value:any){return null;}
Convert(value:any):Number{return null;}
op_Implicit$$UInt32(value:number):System.Int64{return null;}
op_Explicit(value:number):System.Int64{return null;}
op_Implicit$$Int64(value:System.Int64):Number{return null;}
}

}
module System
{
export interface IComparable
{
ctor();
}

}
module System
{
export interface IComparable$1<T>
{
ctor();
}

}
module System
{
export interface IEquatable$1<T>
{
ctor();
}

}
module System
{
export interface IFormattable
{
ctor();
}

}
module SharpKit.JavaScript.Private
{
export class IOGlobal
{
ctor(){return null;}
Global():void{return null;}
}

}
module System.IO
{
export class Path
{
ctor(){return null;}
ChangeExtension(path:string,extension:string):string{return null;}
CharArrayStartsWithOrdinal(array:Array<any>,numChars:number,compareTo:string,ignoreCase:boolean):boolean{return null;}
CheckInvalidPathChars(path:string):void{return null;}
CheckSearchPattern(searchPattern:string):void{return null;}
Combine(path1:string,path2:string):string{return null;}
FixupPath(path:string):string{return null;}
GetDirectoryName(path:string):string{return null;}
GetExtension(path:string):string{return null;}
GetFileName(path:string):string{return null;}
GetFileNameWithoutExtension(path:string):string{return null;}
GetFullPath(path:string):string{return null;}
GetFullPathInternal(path:string):string{return null;}
GetInvalidFileNameChars():Array<any>{return null;}
GetInvalidPathChars():Array<any>{return null;}
GetPathRoot(path:string):string{return null;}
GetRandomFileName():string{return null;}
GetRootLength(path:string):number{return null;}
GetTempFileName():string{return null;}
GetTempPath():string{return null;}
HasExtension(path:string):boolean{return null;}
InternalCombine(path1:string,path2:string):string{return null;}
IsDirectorySeparator(c:System.Char):boolean{return null;}
IsPathRooted(path:string):boolean{return null;}
NormalizePath(path:string,fullCheck:boolean):string{return null;}
NormalizePathSlow(path:string,fullCheck:boolean):string{return null;}
}

}
class Date
{
CompareTo(value:Date):number{return null;}
Year:number;
Month:number;
Day:number;
Hour:number;
Minute:number;
Second:number;
Millisecond:number;
Ticks:number;
DayOfWeek:number;
ToLocalTime():Date{return null;}
ToUniversalTime():Date{return null;}
static Today:Date;
Subtract$$DateTime(value:System.DateTime):System.TimeSpan{return null;}
Subtract$$TimeSpan(value:System.TimeSpan):Date{return null;}
ToString$$String(format:string):string{return null;}
Clone():Date{return null;}
AddMilliseconds(miliseconds:number):Date{return null;}
AddSeconds(seconds:number):Date{return null;}
AddMinutes(minutes:number):Date{return null;}
AddHours(hours:number):Date{return null;}
AddDays(days:number):Date{return null;}
AddMonths(months:number):Date{return null;}
AddYears(years:number):Date{return null;}
RemoveTime():Date{return null;}
Equals$$Object(obj:any):boolean{return null;}
GetHashCode():number{return null;}
GetType():System.Type{return null;}
Kind:System.DateTimeKind;
}
class Number
{
CompareTo$$Double(value:number):number{return null;}
CompareTo$$Int32(value:number):number{return null;}
}
module System.Linq
{
export class Enumerable
{
ctor(){return null;}
CombinePredicates$1<TSource>(predicate1:(arg:TSource)=>boolean,predicate2:(arg:TSource)=>boolean):(arg:TSource)=>boolean{return null;}
CombineSelectors$3<TSource,TMiddle,TResult>(selector1:(arg:TSource)=>TMiddle,selector2:(arg:TMiddle)=>TResult):(arg:TSource)=>TResult{return null;}
First$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
First$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
FirstOrDefault$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
FirstOrDefault$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
Single$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
Single$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
SingleOrDefault$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
SingleOrDefault$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
Last$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
Last$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
LastOrDefault$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):TSource{return null;}
LastOrDefault$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):TSource{return null;}
Where$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
Where$1$$IEnumerable$1$$Func$3<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg1:TSource,arg2:number)=>boolean):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
Contains$1$$IEnumerable$1$$TSource<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,value:TSource):boolean{return null;}
Contains$1$$IEnumerable$1$$TSource$$IEqualityComparer$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,value:TSource,comparer:System.Collections.Generic.IEqualityComparer$1<TSource>):boolean{return null;}
Any$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):boolean{return null;}
Any$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):boolean{return null;}
Concat$1<TSource>(first:System.Collections.Generic.IEnumerable$1<TSource>,second:System.Collections.Generic.IEnumerable$1<TSource>):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
Count$1$$IEnumerable$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):number{return null;}
Count$1$$IEnumerable$1$$Func$2<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean):number{return null;}
OfType$1<TResult>(source:System.Collections.IEnumerable):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
OrderBy$2$$IEnumerable$1$$Func$2<TSource,TKey>(source:System.Collections.Generic.IEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
OrderBy$2$$IEnumerable$1$$Func$2$$IComparer$1<TSource,TKey>(source:System.Collections.Generic.IEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
OrderByDescending$2$$IEnumerable$1$$Func$2<TSource,TKey>(source:System.Collections.Generic.IEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
OrderByDescending$2$$IEnumerable$1$$Func$2$$IComparer$1<TSource,TKey>(source:System.Collections.Generic.IEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
ThenBy$2$$IOrderedEnumerable$1$$Func$2<TSource,TKey>(source:System.Linq.IOrderedEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
ThenBy$2$$IOrderedEnumerable$1$$Func$2$$IComparer$1<TSource,TKey>(source:System.Linq.IOrderedEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
ThenByDescending$2$$IOrderedEnumerable$1$$Func$2<TSource,TKey>(source:System.Linq.IOrderedEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
ThenByDescending$2$$IOrderedEnumerable$1$$Func$2$$IComparer$1<TSource,TKey>(source:System.Linq.IOrderedEnumerable$1<TSource>,keySelector:(arg:TSource)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>):System.Linq.IOrderedEnumerable$1<TSource>{return null;}
Select$2$$IEnumerable$1$$Func$2<TSource,TResult>(source:System.Collections.Generic.IEnumerable$1<TSource>,selector:(arg:TSource)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
Select$2$$IEnumerable$1$$Func$3<TSource,TResult>(source:System.Collections.Generic.IEnumerable$1<TSource>,selector:(arg1:TSource,arg2:number)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
SelectMany$2$$IEnumerable$1$$Func$2<TSource,TResult>(source:System.Collections.Generic.IEnumerable$1<TSource>,selector:(arg:TSource)=>System.Collections.Generic.IEnumerable$1<TResult>):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
SelectMany$2$$IEnumerable$1$$Func$3<TSource,TResult>(source:System.Collections.Generic.IEnumerable$1<TSource>,selector:(arg1:TSource,arg2:number)=>System.Collections.Generic.IEnumerable$1<TResult>):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
SelectMany$3$$IEnumerable$1$$Func$2$$Func$3<TSource,TCollection,TResult>(source:System.Collections.Generic.IEnumerable$1<TSource>,collectionSelector:(arg:TSource)=>System.Collections.Generic.IEnumerable$1<TCollection>,resultSelector:(arg1:TSource,arg2:TCollection)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
Skip$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,count:number):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
Take$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>,count:number):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
ToArray$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):Array<any>{return null;}
ToList$1<TSource>(source:System.Collections.Generic.IEnumerable$1<TSource>):System.Collections.Generic.List$1<TSource>{return null;}
}

}
module System.Linq.Enumerable
{
export class Iterator<TSource>
{
ctor(){return null;}
Current:TSource;
Dispose():void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<TSource>{return null;}
}

}
module System.Linq.Enumerable
{
export class SelectManyEnumerableIterator<TSource,TResult>
{
ctor(source:System.Collections.Generic.IEnumerable$1<TSource>,selector:(arg:TSource)=>System.Collections.Generic.IEnumerable$1<TResult>){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
Dispose():void{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq.Enumerable
{
export class SelectManyListIterator<TSource,TResult>
{
ctor(source:System.Collections.Generic.List$1<TSource>,selector:(arg:TSource)=>System.Collections.Generic.IEnumerable$1<TResult>){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereArrayIterator<TSource>
{
ctor(source:Array<any>,predicate:(arg:TSource)=>boolean){return null;}
Clone():System.Linq.Enumerable.Iterator<TSource>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult>(selector:(arg:TSource)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
Where(predicate:(arg:TSource)=>boolean):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereEnumerableIterator<TSource>
{
ctor(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean){return null;}
Clone():System.Linq.Enumerable.Iterator<TSource>{return null;}
Dispose():void{return null;}
MoveNext():boolean{return null;}
Select$1<TResult>(selector:(arg:TSource)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
Where(predicate:(arg:TSource)=>boolean):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereListIterator<TSource>
{
ctor(source:System.Collections.Generic.List$1<TSource>,predicate:(arg:TSource)=>boolean){return null;}
Clone():System.Linq.Enumerable.Iterator<TSource>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult>(selector:(arg:TSource)=>TResult):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
Where(predicate:(arg:TSource)=>boolean):System.Collections.Generic.IEnumerable$1<TSource>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereSelectArrayIterator<TSource,TResult>
{
ctor(source:Array<any>,predicate:(arg:TSource)=>boolean,selector:(arg:TSource)=>TResult){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereSelectEnumerableIterator<TSource,TResult>
{
ctor(source:System.Collections.Generic.IEnumerable$1<TSource>,predicate:(arg:TSource)=>boolean,selector:(arg:TSource)=>TResult){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
Dispose():void{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq.Enumerable
{
export class WhereSelectListIterator<TSource,TResult>
{
ctor(source:System.Collections.Generic.List$1<TSource>,predicate:(arg:TSource)=>boolean,selector:(arg:TSource)=>TResult){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq.Enumerable
{
export class OfTypeIterator<T>
{
ctor(source:System.Collections.IEnumerable){return null;}
Reset():void{return null;}
Current:T;
MoveNext():boolean{return null;}
Dispose():void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Linq.Enumerable
{
export class SkipIterator<T>
{
ctor(source:System.Collections.IEnumerable,skipCount:number){return null;}
Reset():void{return null;}
Current:T;
MoveNext():boolean{return null;}
Dispose():void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Linq.Enumerable
{
export class TakeIterator<T>
{
ctor(source:System.Collections.IEnumerable,takeCount:number){return null;}
Reset():void{return null;}
Current:T;
MoveNext():boolean{return null;}
Dispose():void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Linq.Enumerable
{
export class ConcatIterator<T>
{
ctor(first:System.Collections.IEnumerable,second:System.Collections.IEnumerable){return null;}
Reset():void{return null;}
Current:T;
MoveNext():boolean{return null;}
Dispose():void{return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<T>{return null;}
}

}
module System.Linq.Enumerable
{
export class SelectManyArrayIterator<TSource,TResult>
{
ctor(source:Array<any>,selector:(arg:TSource)=>System.Collections.Generic.IEnumerable$1<TResult>){return null;}
Clone():System.Linq.Enumerable.Iterator<TResult>{return null;}
MoveNext():boolean{return null;}
Select$1<TResult2>(selector:(arg:TResult)=>TResult2):System.Collections.Generic.IEnumerable$1<TResult2>{return null;}
Where(predicate:(arg:TResult)=>boolean):System.Collections.Generic.IEnumerable$1<TResult>{return null;}
}

}
module System.Linq
{
export class _Error
{
ctor(){return null;}
ArgumentArrayHasTooManyElements(p0:any):System.Exception{return null;}
ArgumentNotIEnumerableGeneric(p0:any):System.Exception{return null;}
ArgumentNotSequence(p0:any):System.Exception{return null;}
ArgumentNotValid(p0:any):System.Exception{return null;}
IncompatibleElementTypes():System.Exception{return null;}
ArgumentNotLambda(p0:any):System.Exception{return null;}
MoreThanOneElement():System.Exception{return null;}
MoreThanOneMatch():System.Exception{return null;}
NoArgumentMatchingMethodsInQueryable(p0:any):System.Exception{return null;}
NoElements():System.Exception{return null;}
NoMatch():System.Exception{return null;}
NoMethodOnType(p0:any,p1:any):System.Exception{return null;}
NoMethodOnTypeMatchingArguments(p0:any,p1:any):System.Exception{return null;}
NoNameMatchingMethodsInQueryable(p0:any):System.Exception{return null;}
ArgumentNull(paramName:string):System.Exception{return null;}
ArgumentOutOfRange(paramName:string):System.Exception{return null;}
NotImplemented():System.Exception{return null;}
NotSupported():System.Exception{return null;}
}

}
module System.Linq
{
export interface IGrouping$2<TKey,TElement>
{
ctor();
Key:TKey;
}

}
module System.Linq
{
export interface IOrderedEnumerable$1<TElement>
{
ctor();
}

}
module System.Linq
{
export class Error
{
ctor(){return null;}
ArgumentNull(p:string):System.Exception{return null;}
NoElements():System.Exception{return null;}
NoMatch():System.Exception{return null;}
}

}
module System.Linq
{
export class _OrderedEnumerable$1<TElement>
{
ctor(){return null;}
GetEnumerator():System.Collections.Generic.IEnumerator$1<TElement>{return null;}
SortSource():Array<any>{return null;}
CreateOrderedEnumerable$1<TKey>(keySelector:(arg:TElement)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>,descending:boolean):System.Linq.IOrderedEnumerable$1<TElement>{return null;}
}

}
module System.Linq
{
export class _OrderedEnumerable$2<TElement,TKey>
{
ctor(source:System.Collections.Generic.IEnumerable$1<TElement>,keySelector:(arg:TElement)=>TKey,comparer:System.Collections.Generic.IComparer$1<TKey>,descending:boolean){return null;}
Compare(x:TElement,y:TElement):Number{return null;}
}

}
module System
{
export class Math
{
ctor(){return null;}
Abs$$Number(value:Number):Number{return null;}
Abs$$Double(value:number):number{return null;}
Abs$$Int32(value:number):number{return null;}
Abs$$Int64(value:number):number{return null;}
Abs$$Single(value:number):number{return null;}
AbsHelper$$Int16(value:number):number{return null;}
AbsHelper$$Int32(value:number):number{return null;}
AbsHelper$$Int64(value:number):number{return null;}
AbsHelper$$SByte(value:number):number{return null;}
Acos(d:number):number{return null;}
Asin(d:number):number{return null;}
Atan(d:number):number{return null;}
Atan2(y:number,x:number):number{return null;}
BigMul(a:number,b:number):number{return null;}
Ceiling$$Decimal(d:number):number{return null;}
Ceiling$$Double(a:number):number{return null;}
Cos(d:number):number{return null;}
Cosh(value:number):number{return null;}
Exp(d:number):number{return null;}
Floor$$Decimal(d:number):number{return null;}
Floor$$Double(d:number):number{return null;}
IEEERemainder(x:number,y:number):number{return null;}
InternalRound(value:number,digits:number,mode:System.MidpointRounding):number{return null;}
InternalTruncate(d:number):number{return null;}
Log$$Double(d:number):number{return null;}
Log$$Double$$Double(a:number,newBase:number):number{return null;}
Log10(d:number):number{return null;}
Max$$Decimal$$Decimal(val1:number,val2:number):number{return null;}
Max$$Double$$Double(val1:number,val2:number):number{return null;}
Max$$Int32$$Int32(val1:number,val2:number):number{return null;}
Max$$Int64$$Int64(val1:number,val2:number):number{return null;}
Max$$SByte$$SByte(val1:number,val2:number):number{return null;}
Max$$Single$$Single(val1:number,val2:number):number{return null;}
Max$$UInt32$$UInt32(val1:number,val2:number):number{return null;}
Max$$UInt64$$UInt64(val1:number,val2:number):number{return null;}
Min$$Decimal$$Decimal(val1:number,val2:number):number{return null;}
Min$$Double$$Double(val1:number,val2:number):number{return null;}
Min$$Int32$$Int32(val1:number,val2:number):number{return null;}
Min$$Int64$$Int64(val1:number,val2:number):number{return null;}
Min$$SByte$$SByte(val1:number,val2:number):number{return null;}
Min$$Single$$Single(val1:number,val2:number):number{return null;}
Min$$UInt32$$UInt32(val1:number,val2:number):number{return null;}
Min$$UInt64$$UInt64(val1:number,val2:number):number{return null;}
Pow(x:number,y:number):number{return null;}
Round$$Decimal(d:number):number{return null;}
Round$$Double(a:number):number{return null;}
Round$$Decimal$$Int32(d:number,decimals:number):number{return null;}
Round$$Decimal$$MidpointRounding(d:number,mode:System.MidpointRounding):number{return null;}
Round$$Double$$Int32(value:number,digits:number):number{return null;}
Round$$Double$$MidpointRounding(value:number,mode:System.MidpointRounding):number{return null;}
Round$$Decimal$$Int32$$MidpointRounding(d:number,decimals:number,mode:System.MidpointRounding):number{return null;}
Round$$Double$$Int32$$MidpointRounding(value:number,digits:number,mode:System.MidpointRounding):number{return null;}
Sign$$Decimal(value:number):number{return null;}
Sign$$Double(value:number):number{return null;}
Sign$$Int16(value:number):number{return null;}
Sign$$Int32(value:number):number{return null;}
Sign$$Int64(value:number):number{return null;}
Sign$$SByte(value:number):number{return null;}
Sign$$Single(value:number):number{return null;}
Sin(a:number):number{return null;}
Sinh(value:number):number{return null;}
Sqrt(d:number):number{return null;}
Tan(a:number):number{return null;}
Tanh(value:number):number{return null;}
Truncate$$Decimal(d:number):number{return null;}
Truncate$$Double(d:number):number{return null;}
}

}
module System
{
export class Nullable$1<T>
{
ctor(value:T){return null;}
HasValue:boolean;
Value:T;
GetValueOrDefault():T{return null;}
GetValueOrDefault$$T(defaultValue:T):T{return null;}
Equals$$Object(other:any):boolean{return null;}
GetHashCode():number{return null;}
toString():string{return null;}
}

}
module System
{
export class Random
{
ctor(){return null;}
ctor$$Int32(Seed:number){return null;}
Sample():number{return null;}
InternalSample():number{return null;}
Next():number{return null;}
GetSampleForLargeRange():number{return null;}
Next$$Int32$$Int32(minValue:number,maxValue:number):number{return null;}
Next$$Int32(maxValue:number):number{return null;}
NextDouble():number{return null;}
NextBytes(buffer:Uint8Array):void{return null;}
}

}
module System.Reflection
{
export class BindingFlags
{
ctor(){return null;}
}

}
module System.Reflection
{
export class MemberInfo
{
ctor(){return null;}
Name:string;
DeclaringType:System.Type;
VerifyCustomAttributes():void{return null;}
GetBaseMember():System.Reflection.MemberInfo{return null;}
AddCustomAttributes(list:System.Collections.Generic.List$1<any>,attributeType:System.Type,inherit:boolean):void{return null;}
GetCustomAttributes$$Type$$Boolean(attributeType:System.Type,inherit:boolean):Array<any>{return null;}
GetCustomAttributes$$Boolean(inherit:boolean):Array<any>{return null;}
}

}
module System.Reflection
{
export class MethodBase
{
ctor(){return null;}
}

}
module System.Reflection
{
export class MethodInfo
{
ctor(){return null;}
IsStatic:boolean;
Invoke(obj:any,parameters:Array<any>):any{return null;}
}

}
module System.Reflection
{
export class PropertyInfo
{
ctor(){return null;}
op_Equality(left:System.Reflection.PropertyInfo,right:System.Reflection.PropertyInfo):boolean{return null;}
op_Inequality(left:System.Reflection.PropertyInfo,right:System.Reflection.PropertyInfo):boolean{return null;}
GetBaseMember():System.Reflection.MemberInfo{return null;}
GetValue$$Object$$Object$Array(obj:any,indexes:Array<any>):any{return null;}
GetValue$$Object(obj:any):any{return null;}
GetValue$$Object$$BindingFlags$$Binder$$Object$Array$$CultureInfo(obj:any,invokeAttr:System.Reflection.BindingFlags,binder:System.Reflection.Binder,index:Array<any>,culture:System.Globalization.CultureInfo):any{return null;}
SetValue$$Object$$Object$$Object$Array(obj:any,value:any,indexes:Array<any>):void{return null;}
SetValue$$Object$$Object(obj:any,value:any):void{return null;}
SetValue$$Object$$Object$$BindingFlags$$Binder$$Object$Array$$CultureInfo(obj:any,value:any,invokeAttr:System.Reflection.BindingFlags,binder:System.Reflection.Binder,index:Array<any>,culture:System.Globalization.CultureInfo):void{return null;}
Name:string;
PropertyType:System.Type;
}

}
module System.Runtime.Serialization
{
export interface IExtensibleDataObject
{
ctor();
}

}
module System.Runtime.Serialization
{
export interface ISerializable
{
ctor();
}

}
module System
{
export class StringSplitOptions
{
ctor(){return null;}
}

}
module System
{
export class Char
{
ctor(){return null;}
IsWhiteSpace(c:System.Char):boolean{return null;}
IsUpper(c:System.Char):boolean{return null;}
IsDigit$$Char(s:System.Char):boolean{return null;}
}

}
module System
{
export class CharEnumerator
{
ctor(str2:String){return null;}
MoveNext():boolean{return null;}
Reset():void{return null;}
Current:System.Char;
}

}
module System.Text
{
export class StringBuilder
{
ctor(){return null;}
ctor$$Int32(len:number){return null;}
ctor$$String(s:string){return null;}
Append$$Char(s:System.Char):void{return null;}
Append$$String(s:string):void{return null;}
AppendFormat$$String$$Object(s:string,arg0:any):void{return null;}
AppendFormat$$String$$Object$$Object(s:string,arg0:any,arg1:any):void{return null;}
AppendFormat$$String$$Object$$Object$$Object(s:string,arg0:any,arg1:any,arg2:any):void{return null;}
Append$$Object(obj:any):void{return null;}
Insert$$Int32$$Boolean(index:number,value:boolean):System.Text.StringBuilder{return null;}
Insert$$Int32$$Byte(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Char(index:number,value:System.Char):System.Text.StringBuilder{return null;}
Insert$$Int32$$Char$Array(index:number,value:Array<any>):System.Text.StringBuilder{return null;}
Insert$$Int32$$Decimal(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Double(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Int16(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Int32(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Int64(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Object(index:number,value:any):System.Text.StringBuilder{return null;}
Insert$$Int32$$SByte(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Single(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$String(index:number,value:string):System.Text.StringBuilder{return null;}
Insert$$Int32$$UInt16(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$UInt32(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$UInt64(index:number,value:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$String$$Int32(index:number,value:string,count:number):System.Text.StringBuilder{return null;}
Insert$$Int32$$Char$Array$$Int32(index:number,value:Array<any>,count:number):System.Text.StringBuilder{return null;}
toString():string{return null;}
Length:number;
Remove(start:number,count:number):System.Text.StringBuilder{return null;}
}

}
module System
{
export class StringComparison
{
ctor(){return null;}
}

}
module System
{
export class TimeSpan
{
ctor(){return null;}
Ticks:number;
Days:number;
Hours:number;
Milliseconds:number;
Minutes:number;
Seconds:number;
TotalDays:number;
TotalHours:number;
TotalMilliseconds:number;
TotalMinutes:number;
TotalSeconds:number;
ctor$$Int64(ticks:number){return null;}
ctor$$Int32$$Int32$$Int32(hours:number,minutes:number,seconds:number){return null;}
ctor$$Int32$$Int32$$Int32$$Int32(days:number,hours:number,minutes:number,seconds:number){return null;}
ctor$$Int32$$Int32$$Int32$$Int32$$Int32(days:number,hours:number,minutes:number,seconds:number,milliseconds:number){return null;}
Add(ts:System.TimeSpan):System.TimeSpan{return null;}
Compare(t1:System.TimeSpan,t2:System.TimeSpan):number{return null;}
CompareTo$$Object(value:any):number{return null;}
CompareTo$$TimeSpan(value:System.TimeSpan):number{return null;}
FromDays(value:number):System.TimeSpan{return null;}
Duration():System.TimeSpan{return null;}
Equals$$Object(value:any):boolean{return null;}
Equals$$TimeSpan(obj:System.TimeSpan):boolean{return null;}
Equals$$TimeSpan$$TimeSpan(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
GetHashCode():number{return null;}
FromHours(value:number):System.TimeSpan{return null;}
Interval(value:number,scale:number):System.TimeSpan{return null;}
FromMilliseconds(value:number):System.TimeSpan{return null;}
FromMinutes(value:number):System.TimeSpan{return null;}
Negate():System.TimeSpan{return null;}
FromSeconds(value:number):System.TimeSpan{return null;}
Subtract(ts:System.TimeSpan):System.TimeSpan{return null;}
FromTicks(value:number):System.TimeSpan{return null;}
TimeToTicks(hour:number,minute:number,second:number):number{return null;}
op_UnaryNegation(t:System.TimeSpan):System.TimeSpan{return null;}
op_Subtraction(t1:System.TimeSpan,t2:System.TimeSpan):System.TimeSpan{return null;}
op_UnaryPlus(t:System.TimeSpan):System.TimeSpan{return null;}
op_Addition(t1:System.TimeSpan,t2:System.TimeSpan):System.TimeSpan{return null;}
op_Equality(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
op_Inequality(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
op_LessThan(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
op_LessThanOrEqual(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
op_GreaterThan(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
op_GreaterThanOrEqual(t1:System.TimeSpan,t2:System.TimeSpan):boolean{return null;}
}

}
module System
{
export class Tuple
{
ctor(){return null;}
Create$1$$T1<T1>(item1:T1):System.Tuple$1<T1>{return null;}
Create$2$$T1$$T2<T1,T2>(item1:T1,item2:T2):System.Tuple$2<T1,T2>{return null;}
Create$3$$T1$$T2$$T3<T1,T2,T3>(item1:T1,item2:T2,item3:T3):System.Tuple$3<T1,T2,T3>{return null;}
Create$4$$T1$$T2$$T3$$T4<T1,T2,T3,T4>(item1:T1,item2:T2,item3:T3,item4:T4):System.Tuple$4<T1,T2,T3,T4>{return null;}
Create$5$$T1$$T2$$T3$$T4$$T5<T1,T2,T3,T4,T5>(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5):System.Tuple$5<T1,T2,T3,T4,T5>{return null;}
Create$6$$T1$$T2$$T3$$T4$$T5$$T6<T1,T2,T3,T4,T5,T6>(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5,item6:T6):System.Tuple$6<T1,T2,T3,T4,T5,T6>{return null;}
Create$7$$T1$$T2$$T3$$T4$$T5$$T6$$T7<T1,T2,T3,T4,T5,T6,T7>(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5,item6:T6,item7:T7):System.Tuple$7<T1,T2,T3,T4,T5,T6,T7>{return null;}
Create$8$$T1$$T2$$T3$$T4$$T5$$T6$$T7$$T8<T1,T2,T3,T4,T5,T6,T7,T8>(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5,item6:T6,item7:T7,item8:T8):System.Tuple$8<T1,T2,T3,T4,T5,T6,T7,System.Tuple$1<T8>>{return null;}
}

}
module System
{
export class Tuple$1<T1>
{
ctor(item1:T1){return null;}
Item1:T1;
}

}
module System
{
export class Tuple$2<T1,T2>
{
ctor(item1:T1,item2:T2){return null;}
Item1:T1;
Item2:T2;
}

}
module System
{
export class Tuple$3<T1,T2,T3>
{
ctor(item1:T1,item2:T2,item3:T3){return null;}
Item1:T1;
Item2:T2;
Item3:T3;
}

}
module System
{
export class Tuple$4<T1,T2,T3,T4>
{
ctor(item1:T1,item2:T2,item3:T3,item4:T4){return null;}
Item1:T1;
Item2:T2;
Item3:T3;
Item4:T4;
}

}
module System
{
export class Tuple$5<T1,T2,T3,T4,T5>
{
ctor(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5){return null;}
Item1:T1;
Item2:T2;
Item3:T3;
Item4:T4;
Item5:T5;
}

}
module System
{
export class Tuple$6<T1,T2,T3,T4,T5,T6>
{
ctor(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5,item6:T6){return null;}
Item1:T1;
Item2:T2;
Item3:T3;
Item4:T4;
Item5:T5;
Item6:T6;
}

}
module System
{
export class Tuple$7<T1,T2,T3,T4,T5,T6,T7>
{
ctor(item1:T1,item2:T2,item3:T3,item4:T4,item5:T5,item6:T6,item7:T7){return null;}
Item1:T1;
Item2:T2;
Item3:T3;
Item4:T4;
Item5:T5;
Item6:T6;
Item7:T7;
}

}
module System
{
export class Type
{
ctor(jsType:Object){return null;}
IsEnum:boolean;
GetBaseMember():System.Reflection.MemberInfo{return null;}
_TypeOf(jsType:Object):System.Type{return null;}
GetType$$String(name:string):System.Type{return null;}
GetType$$String$$Boolean(name:string,throwOnError:boolean):System.Type{return null;}
GetType$$String$$Boolean$$Boolean(name:string,throwOnError:boolean,ignoreCase:boolean):System.Type{return null;}
BaseType:System.Type;
FillProperties(def:Object):void{return null;}
FillProperty(def:Object,funcName:string,isSetter:boolean):void{return null;}
TryFillProperty(def:Object,name:string):boolean{return null;}
GetProperty$$String(name:string):System.Reflection.PropertyInfo{return null;}
GetProperty$$String$$BindingFlags(name:string,bindingAttr:System.Reflection.BindingFlags):System.Reflection.PropertyInfo{return null;}
GetProperty$$String$$Type(name:string,returnType:System.Type):System.Reflection.PropertyInfo{return null;}
VerifyProperty(name:string):void{return null;}
VerifyProperties():void{return null;}
GetProperties():Array<any>{return null;}
FillMethods(def:Object):void{return null;}
GetMethod(name:string):System.Reflection.MethodInfo{return null;}
VerifyMethods():void{return null;}
GetMethods():Array<any>{return null;}
GetMethods$$String(name:string):Array<any>{return null;}
GetMethods$$BindingFlags(bindingFlags:System.Reflection.BindingFlags):Array<any>{return null;}
VerifyCustomAttributes():void{return null;}
Name:string;
FullName:string;
AssemblyQualifiedName:string;
VerifyCustomAttributesOnTypeAndMembers():void{return null;}
GetAttributeTarget(memberType:string,memberName:string):System.Reflection.MemberInfo{return null;}
IsAssignableFrom(type:System.Type):boolean{return null;}
IsInstanceOfType(obj:any):boolean{return null;}
toString():string{return null;}
MakeGenericType(typeArguments:Array<any>):System.Type{return null;}
GetGenericTypeDefinition():System.Type{return null;}
GetGenericArguments():Array<any>{return null;}
_MakeGenericType(typeArguments:Array<any>):System.Type{return null;}
}

}
module System
{
export class UInt32
{
ctor(){return null;}
ctor$$Object(value:any){return null;}
Convert(value:any):Number{return null;}
op_Implicit$$UInt32(value:number):System.UInt32{return null;}
op_Explicit(value:number):System.UInt32{return null;}
op_Implicit$$UInt32(value:System.UInt32):Number{return null;}
}

}
module System
{
export class Uri
{
ctor(){return null;}
ctor$$String(uri:string){return null;}
OriginalString:string;
AbsoluteUri:string;
toString():string{return null;}
Equals$$Object(obj:any):boolean{return null;}
GetHashCode():number{return null;}
op_Equality(u1:System.Uri,u2:System.Uri):boolean{return null;}
op_Inequality(u1:System.Uri,u2:System.Uri):boolean{return null;}
Fragment:string;
}

}
module System
{
export class ValueType
{
ctor(){return null;}
}

}
module SharpKit.Html4
{
export interface HtmlDomEventHandler
{
(e:any):void;
}

}
module SharpKit
{
export class PropertyInfoExtensions
{
ctor(){return null;}
IsStatic(pi:System.Reflection.PropertyInfo):boolean{return null;}
IsPublic(pi:System.Reflection.PropertyInfo):boolean{return null;}
}

}
module SharpKit
{
export class Extensions2
{
ctor(){return null;}
GetValueOrDefaultIfNullOrEmpty(s:string,defaultValue:string):string{return null;}
IsNullOrEmpty$$String(s:String):boolean{return null;}
IsNotNullOrEmpty$$String(s:String):boolean{return null;}
HtmlEscape(s:string):string{return null;}
ReplaceFirst$$String$$String$$String(s:string,search:string,replace:string):string{return null;}
ReplaceFirst$$String$$String$$String$$StringComparison(s:string,search:string,replace:string,comparisonType:System.StringComparison):string{return null;}
FixCamelCasing(s:string):string{return null;}
RemoveLast(s:string,count:number):string{return null;}
TrimEnd(s:string,trimText:string):string{return null;}
EqualsIgnoreCase(s1:string,s2:string):boolean{return null;}
}

}
module System.Collections
{
export class IListEnumerator$1<T>
{
ctor(list:System.Collections.Generic.IList$1<T>){return null;}
Current:T;
Dispose():void{return null;}
MoveNext():boolean{return null;}
Reset():void{return null;}
}

}
module SharpKit.JavaScript.Utils
{
export class Js
{
ctor(){return null;}
escape(s:string):string{return null;}
JsEquals(obj:any,value:any):boolean{return null;}
JsExactEqualsToUndefined(obj:any):boolean{return null;}
JsExactEquals(obj:any,value:any):boolean{return null;}
Typeof(obj:any):string{return null;}
ApplyFunction(func:any,thisArg:any,prms:Array<any>):any{return null;}
CallFunction(func:any,thisArg:any,prms:Array<any>):any{return null;}
CallFunction2(obj:any,funcName:string,prms:Array<any>):any{return null;}
FindOverloadedMethodName(obj:any,funcName:string):string{return null;}
Eval(code:string):any{return null;}
Compile():void{return null;}
GetHashKey(key:any):string{return null;}
DeleteMember(obj:any,name:string):void{return null;}
parseFloat(s:string):Number{return null;}
parseInt(s:string):Number{return null;}
ApplyNew(jsCtor:Function,prms:Array<any>):any{return null;}
IsArray(obj:any):boolean{return null;}
isNaN(obj:any):boolean{return null;}
decodeURIComponent(encodedURIString:string):string{return null;}
encodeURIComponent(encodedURIString:string):string{return null;}
encodeURI(URIString:string):string{return null;}
decodeURI(URIString:string):string{return null;}
unescape(s:string):string{return null;}
}

}
module SharpKit.JsClr.Utils
{
export class JsClrClientSerializer
{
ctor(){return null;}
Serialize(obj:any):String{return null;}
Serialize2(obj:any):any{return null;}
SerializeRefOrContent(obj:any):Object{return null;}
SerializeFirstRef(obj:any,info:Object):Object{return null;}
}

}
module SharpKit.JavaScript
{
export class JsNamingHelper
{
ctor(){return null;}
JsFunctionNameToClrMethodName(jsFuncName:string):string{return null;}
ClrTypeToJsTypeRef(type:System.Type):string{return null;}
ClrConstructorToJsFunctionName(mi:System.Reflection.ConstructorInfo):string{return null;}
ConvertParametersToJsFunctionName(prms:Array<any>,sb:System.Text.StringBuilder):void{return null;}
ClrMethodBaseToJsFunctionName(mi:System.Reflection.MethodBase):string{return null;}
ClrMethodToJsFunctionName(mi:System.Reflection.MethodInfo):string{return null;}
IsPropertySetter(mi:System.Reflection.MethodInfo):boolean{return null;}
}

}
class JsRuntime
{
ctor(){return null;}
Start():void{return null;}
}
