//kernel.js
var isIE = navigator.userAgent.toLowerCase().indexOf("msie") > -1;
var isMoz = document.implementation && document.implementation.createDocument;
var isWebkit = navigator.userAgent.indexOf("WebKit") > -1; //navigator.vendor == "Apple Computer, Inc.";
//TODO: Add all the rest, or find another way
if (!isMoz) {
	var HTMLImageElement = null;
	var HTMLInputElement = null;
}
String.Format = function (format, varargs) {
	return String.format.apply(String, arguments);
}
String.prototype.startsWith = function (str) {
	return this.indexOf(str) == 0;
}
String.prototype.endsWith = function (str) {
	return this.substr(this.length - str.length, str.length) == str;
}
Object.ctor = Object;
Array.ctor = Array;
Date.ctor = Date;
Function.ctor = Function;
if (typeof (ActiveXObject) != "undefined")
	ActiveXObject.ctor$$String = ActiveXObject;
Number.prototype.get_Value = function () //nullable support
{
	return this;
}
Number.prototype.ToString$$String = function (format) {
	var s = this.toString();
	for (var i = 0; i < format.length; i++) {
		var ch = format.charAt(i);
		if (ch == "0") {
			if (s.length < i + 1)
				s = "0" + s;
		}
		else
			throw new Error("not implemented");
	}
	return s;
}
//whether to wrap functions with profiler functions
var ENABLE_PROFILER = typeof (appConfig) == "object" ? appConfig.enableProfiler : false;
//can be changed in runtime - whether to profile functions that are running
var ENABLE_PROFILING = typeof (appConfig) == "object" ? appConfig.enableProfiling : false;
if (ENABLE_PROFILER) {
	BeforeCompilation(function () { Profiler.Initialize(); });
}
var envDebugFunction = (typeof (Debug) != "undefined" && Debug != null && Debug.writeln) ||
											 (typeof (console) != "undefined" && console != null && console.log) ||
											 function (t) { };
if (typeof (Debug) != "undefined")
	var Debug = { writeln: envDebugFunction }

Array.parse = function (value) {
	return eval('(' + value + ')');
}
JsTypes.push(
{ fullname: "System.Object", definition:
{
	ctor: function () {
	},
	toString: function () {
		return "{" + this.constructor._type.fullname + "}";
	},
	construct: function (type) {
		//		arguments.callee.caller._type.baseType.ctor.apply(this, arguments);
		type.baseType.ctor.apply(this, arguments);
	},
	GetType: function () {
		return System.Type._TypeOf(this.constructor._type);
	},
	getType: function () {
		return this.constructor._type;
	},
	getTypeName: function () {
		return this.constructor._type.name;
	},
	base: function () {
		//TODO: remove use of callee/caller!
		return arguments.callee.caller._type.baseType.ctor.prototype[arguments.callee.caller._name].apply(this, arguments);
	},
	callBase: function (methodName) {
		//TODO: remove use of callee/caller!
		return arguments.callee.caller._type.baseType.ctor.prototype[methodName].apply(this, Arguments.from(arguments, 1));
	}
}, staticDefinition:
{
	Equals$$Object$$Object: function (x, y) {
		//TODO: check value types for valueOf()
		return x == y;
	},
	ReferenceEquals: function (x, y) {
		return x == y;
	},
	ReferenceEquals$$Object$$Object: function (x, y) {
		return x == y;
	}
}
});

JsTypes.push({ fullname: "Object" });
JsTypes.push({ fullname: "Int8Array" });
JsTypes.push({ fullname: "Uint8Array"});
JsTypes.push({ fullname: "Int16Array"});
JsTypes.push({ fullname: "Uint16Array"});
JsTypes.push({ fullname: "Int32Array"});
JsTypes.push({ fullname: "Uint32Array"});
JsTypes.push({ fullname: "Float32Array"});
JsTypes.push({ fullname: "Float64Array"});

JsTypes.push({ fullname: "Array", baseTypeName: "Object", definition:
{
	GetEnumerator: function () {
		return new ArrayEnumerator.ctor(this);
	},
	getItem: function (index) {
		return this[index];
	},
	getCount: function () {
		return this.length;
	},
	get_Count: function () {
		return this.length;
	},
	///
	/// returns an array that contains the values of the specified 
	/// property name from each item
	///
	selectSingle: function (propName) {
		var result = [];
		for (var i = 0; i < this.length; i++) {
			var item = this[i];
			var value = item[propName]; //TODO: support getValue
			if (value === undefined) //array cannot contain undefined.
				value = null;
			result.push(value);
		}
		return result;
	},
	Clone: function () {
		return this.concat();
	},
	toArray: function () {
		return this;
	},
	Add: function (item) {
		this.push(item);
	},
	AddRange: function (items) {
		var length = items.length;
		var thisLength = this.length;
		for (var i = 0; i < length; i++) {
			this[thisLength] = items[i]; //Keep order
			thisLength++;
		}
	},
	Clear: function () {
		if (this.length > 0) {
			this.splice(0, this.length);
		}
	},
	clone: function () {
		return this.slice(0);
	},
	contains: function (item) {
		var index = this.indexOf(item);
		return (index >= 0);
	},
	Contains$$Object: function (item) {
		return Contains(item);
	},
	Contains: function (item) {
		var index = this.indexOf(item);
		return (index >= 0);
	},
	dequeue: function () {
		return this.shift();
	},
	indexOf: function (item, startFrom) {
		if (startFrom == null)
			startFrom = 0;
		var length = this.length;
		if (length != 0) {
			for (var index = startFrom; index < length; index++) {
				if (this[index] == item) {
					return index;
				}
			}
		}
		return -1;
	},
	insert: function (index, item) {
		this.splice(index, 0, item);
	},
	addAt: function (index, item) {
		this.splice(index, 0, item);
	},
	queue: function (item) {
		this.push(item);
	},
	Remove$$Object: function (item) {
		return this.Remove(item);
	},
	Remove: function (item) {
		var index = this.indexOf(item);
		if (index >= 0) {
			this.splice(index, 1);
		}
		return index;
	},
	RemoveAt: function (index) {
		this.splice(index, 1);
	},
	copyTo: function (target, startIndex) {
		for (var i = startIndex; i < this.length; i++) {
			target.push(this[i]);
		}
	},
	filter: function (pred) {
		var item, i = 0;
		for (var i = 0, j = this.length; i < j; i++) {
			item = this[i];
			if (!pred(item)) {
				this.splice(i, 1);
				i--; //prevent increase
				j--; //length is decreased
			}
		}
		return this;
	},
	filterOut: function (pred) {
		return this.filter(function (item) { return !pred(item); });
	},
	apply: function (modifier) {
		for (var i = 0, j = this.length; i < j; i++) {
			this[i] = modifier(this[i]);
		}
		return this;
	},
	findFirst: function (pred) {
		var item;
		for (var i = 0, j = this.length; i < j; i++) {
			item = this[i];
			if (pred(item))
				return item;
		}
		return null;
	},
	ToArray: function () {
		return this;
	},
	peek: function () {
		return this[this.length - 1];
	},
	getLast: function () {
		return this[this.length - 1];
	},
	getIterator: function () {
		return new ArrayIterator(this);
	},
	get_Length: function () {
		return this.length;
	},
	get_Item: function (index) {
		return this[index];
	},
	get_Item$$Int32: function (index) {
		return this[index];
	}
}
});
JsTypes.push({ fullname: "ArrayEnumerator", baseTypeName: "System.Object", definition: //TODO: implement IEnumerator
{
ctor: function (array) {
	this._array = array;
	this._idx = -1;
},
Reset: function () {
	this._idx = -1;
},
get_Current: function () {
	return this._array[this._idx];
},
MoveNext: function () {
	this._idx++;
	return this._array.length > this._idx;
},
Dispose: function () {
	//TODO
}
}
});
AfterCompilation(function () {
	Function._type = System.Delegate;
});
JsTypes.push({ fullname: "System.Boolean", baseTypeName: "System.ValueType", definition:
{
	ctor: Boolean,
	toString: function () {
		return this == true ? "true" : "false";
	}
}, staticDefinition:
{
	tryParse: function (s) {
		if (s == null)
			return false;
		return s.toLowerCase().trim() == "true";
	},
    Parse: function (s) {
        if (s == null)
            return false;
        return s.toLowerCase().trim() == "true";
    }
}
});
JsTypes.push({ fullname: "System.Int32", baseTypeName: "System.ValueType", definition:
{
	ctor: Number,
	toString: Number.prototype.toString //avoid toString override by compiler (toString(radix) won't work if overriden)
}, staticDefinition:
{
	tryParse: function (s) {
		return parseInt(s);
	},
	Parse$$String: function (s) {
		return parseInt(s);
	}
}
});
JsTypes.push({
    fullname: "System.Single", baseTypeName: "System.ValueType", definition:
    {
        ctor: Number,
        toString: Number.prototype.toString //avoid toString override by compiler (toString(radix) won't work if overriden)
    }, staticDefinition:
    {
        tryParse: function (s) {
            return parseFloat(s);
        },
        Parse$$String: function (s) {
            return parseFloat(s);
        }
    }
});

JsTypes.push({ fullname: "System.Decimal", baseTypeName: "System.ValueType", definition:
{
	ctor: function (x) { return new Number(x); },
	toString: function () {
		return this.toString();
	}
}, staticDefinition:
{
	tryParse: function (s) {
		return parseFloat(s);
	}
}
});

JsTypes.push({ fullname: "System.Double", baseTypeName: "System.ValueType", definition:
{
	ctor: function (x) { return new Number(x); }
},
	staticDefinition:
{
	tryParse: function (s) {
		return parseFloat(s);
	},
	IsNaN: isNaN,
	PositiveInfinity: Number.POSITIVE_INFINITY,
	NegativeInfinity: Number.NEGATIVE_INFINITY
}
});

String.prototype._toString = String.prototype.toString;
JsTypes.push({ fullname: "System.String", baseTypeName: "System.Object", definition:
{
	ctor: String,
	GetEnumerator: function () {
		return new System.CharEnumerator.ctor$$String(this);
	},
	GetType: function () {
		return Typeof(System.String);
	},
	Insert$$Int32$$String: function (startIndex, str) {
		var sub1 = this.substring(0, startIndex);
		var sub2 = this.substring(startIndex);
		return sub1 + str + sub2;
	},
	Split$$Char$Array: function (varargs) {
		if (arguments.length != 1) {
			var re = "[";
			for (var i = 0; i < arguments.length; i++) {
				re += arguments[i];
			}
			re += "]";
			var regExp = new RegExp(re);
			var arr = this.split(regExp);
			////////////////////// Fix for FireFox
			if (isMoz) {
				var arr2 = [];
				for (var i = 0, j = arr.length; i < j; i++) {
					if (arr[i].length > 0)
						arr2.push(arr[i]);
				}
				arr = arr2;
			}
			////////////////////////
			return arr;
		}
		var firstArg = varargs;
		return this.split(firstArg); //TODO: escape new value?
	},
	ReplaceFirst: function (find, replace) {
		return this.replace(find, replace);
	},
	Replace$$Char$$Char: function (oldValue, newValue) {
		return this.Replace(oldValue, newValue);
	},
	Replace$$String$$String: function (oldValue, newValue) {
		return this.Replace(oldValue, newValue);
	},
	Replace: function (oldValue, newValue) {
		//TODO: var regExp = new RegExp(RegExp.Escape(oldValue), "g");
		//        var last = this;
		//        var replaced = this.replace(oldValue, newValue);
		//        while (last != replaced)
		//        {
		//            last = replaced;
		//            replaced = replaced.replace(oldValue, newValue);
		//        }
		//        return replaced;

		var escape = function (str) {
			return str.replace(/[-[\]{}()*+?.,\\^$|#\s]/g, "\\$&");
		};

		var regExp = new RegExp(escape(oldValue), "g");
		return this.replace(regExp, newValue);
	},
	Substring$$Int32: function (startIndex) {
		return this.substr(startIndex);
	},
	Substring$$Int32$$Int32: function (startIndex, length) {
		return this.substr(startIndex, length);
	},
	Substring: function (startIndex, length) {
		return this.substr(startIndex, length);
	},
	ToLower$$: function () {
		return this.toLowerCase();
	},
	ToLower: function () {
		return this.toLowerCase();
	},
	ToUpper: function () {
		return this.toUpperCase();
	},
	getItem: function (index) {
		return this.charAt(index);
	},
	IndexOf$$String: function (s) {
		return this.indexOf(s);
	},
	IndexOf$$Char: function (ch) {
		return this.indexOf(ch);
	},
	Split$$Char$Array$$StringSplitOptions: function (charArray, stringSplitOptions) {
		if (stringSplitOptions == System.StringSplitOptions.None)
			throw new Error("Not Implemented");
		return this.Split$$Char$Array.apply(this, charArray);
	},
	IndexOfAny$$Char$Array: function (charArray) {
		//TODO: Convert to RegExp
		var s = charArray.join("");
		for (var i = 0; i < this.length; i++) {
			var ch = this.charAt(i);
			if (s.search(ch) >= 0)
				return i;
		}
		return -1;
	},
	IndexOf: function (value, startIndex) {
		return this.indexOf.apply(this, arguments);
	},
	LastIndexOf: function (value, startIndex) {
		return this.lastIndexOf.apply(this, arguments);
	},
	LastIndexOf$$Char: function (ch) {
		return this.lastIndexOf(ch);
	},
	LastIndexOf$$String: function (s) {
		return this.lastIndexOf(s);
	},
	Remove$$Int32$$Int32: function (start, count) {
		return this.substr(0, start) + this.substr(start + count);
	},
	StartsWith$$String: function (str) {
		if (str == null)
			throw new System.ArgumentNullException.ctor();
		return this.indexOf(str) == 0;
	},
	EndsWith$$String: function (str) {
		return this.lastIndexOf(str) == this.length - str.length;
	},
	Contains: function (s) {
		return this.indexOf(s) != -1;
	},
	toString: function () {
		return this._toString();
	},
	getLength: function () {
		return this.length;
	},
	get_Chars$$Int32: String.prototype.charAt,
	get_Chars: String.prototype.charAt,
	get_Length: function () {
		return this.length;
	},
	trim: function () {
		return this.replace(/^\s+|\s+$/g, "");
	},
	Trim: function () {
		return this.replace(/^\s+|\s+$/g, "");
	},
	ltrim: function () {
		return this.replace(/^\s+/, "");
	},
	rtrim: function () {
		return this.replace(/\s+$/, "");
	},
	FormatObject$$String$$Object$Array: function (formatStr, object) {
		var r = /{[A-Za-z]+}/g;
		var s = formatStr;
		var matches = s.match(r);
		for (var i = 0, j = matches.length; i < j; i++) {
			var m = matches[i];
			var n = m.substring(1, m.length - 1);
			var v = dataObject["get" + n]();
			s = s.split(m).join(v);
		}
		return s;
    },
    // The CRC32 calculation of a string seems like as good a hashcode as anything else to me. -- Yvan
    // http://noteslog.com/post/crc32-for-javascript/
    GetHashCode: function () { 
        var table = "00000000 77073096 EE0E612C 990951BA 076DC419 706AF48F E963A535 9E6495A3 0EDB8832 79DCB8A4 E0D5E91E 97D2D988 09B64C2B 7EB17CBD E7B82D07 90BF1D91 1DB71064 6AB020F2 F3B97148 84BE41DE 1ADAD47D 6DDDE4EB F4D4B551 83D385C7 136C9856 646BA8C0 FD62F97A 8A65C9EC 14015C4F 63066CD9 FA0F3D63 8D080DF5 3B6E20C8 4C69105E D56041E4 A2677172 3C03E4D1 4B04D447 D20D85FD A50AB56B 35B5A8FA 42B2986C DBBBC9D6 ACBCF940 32D86CE3 45DF5C75 DCD60DCF ABD13D59 26D930AC 51DE003A C8D75180 BFD06116 21B4F4B5 56B3C423 CFBA9599 B8BDA50F 2802B89E 5F058808 C60CD9B2 B10BE924 2F6F7C87 58684C11 C1611DAB B6662D3D 76DC4190 01DB7106 98D220BC EFD5102A 71B18589 06B6B51F 9FBFE4A5 E8B8D433 7807C9A2 0F00F934 9609A88E E10E9818 7F6A0DBB 086D3D2D 91646C97 E6635C01 6B6B51F4 1C6C6162 856530D8 F262004E 6C0695ED 1B01A57B 8208F4C1 F50FC457 65B0D9C6 12B7E950 8BBEB8EA FCB9887C 62DD1DDF 15DA2D49 8CD37CF3 FBD44C65 4DB26158 3AB551CE A3BC0074 D4BB30E2 4ADFA541 3DD895D7 A4D1C46D D3D6F4FB 4369E96A 346ED9FC AD678846 DA60B8D0 44042D73 33031DE5 AA0A4C5F DD0D7CC9 5005713C 270241AA BE0B1010 C90C2086 5768B525 206F85B3 B966D409 CE61E49F 5EDEF90E 29D9C998 B0D09822 C7D7A8B4 59B33D17 2EB40D81 B7BD5C3B C0BA6CAD EDB88320 9ABFB3B6 03B6E20C 74B1D29A EAD54739 9DD277AF 04DB2615 73DC1683 E3630B12 94643B84 0D6D6A3E 7A6A5AA8 E40ECF0B 9309FF9D 0A00AE27 7D079EB1 F00F9344 8708A3D2 1E01F268 6906C2FE F762575D 806567CB 196C3671 6E6B06E7 FED41B76 89D32BE0 10DA7A5A 67DD4ACC F9B9DF6F 8EBEEFF9 17B7BE43 60B08ED5 D6D6A3E8 A1D1937E 38D8C2C4 4FDFF252 D1BB67F1 A6BC5767 3FB506DD 48B2364B D80D2BDA AF0A1B4C 36034AF6 41047A60 DF60EFC3 A867DF55 316E8EEF 4669BE79 CB61B38C BC66831A 256FD2A0 5268E236 CC0C7795 BB0B4703 220216B9 5505262F C5BA3BBE B2BD0B28 2BB45A92 5CB36A04 C2D7FFA7 B5D0CF31 2CD99E8B 5BDEAE1D 9B64C2B0 EC63F226 756AA39C 026D930A 9C0906A9 EB0E363F 72076785 05005713 95BF4A82 E2B87A14 7BB12BAE 0CB61B38 92D28E9B E5D5BE0D 7CDCEFB7 0BDBDF21 86D3D2D4 F1D4E242 68DDB3F8 1FDA836E 81BE16CD F6B9265B 6FB077E1 18B74777 88085AE6 FF0F6A70 66063BCA 11010B5C 8F659EFF F862AE69 616BFFD3 166CCF45 A00AE278 D70DD2EE 4E048354 3903B3C2 A7672661 D06016F7 4969474D 3E6E77DB AED16A4A D9D65ADC 40DF0B66 37D83BF0 A9BCAE53 DEBB9EC5 47B2CF7F 30B5FFE9 BDBDF21C CABAC28A 53B39330 24B4A3A6 BAD03605 CDD70693 54DE5729 23D967BF B3667A2E C4614AB8 5D681B02 2A6F2B94 B40BBE37 C30C8EA1 5A05DF1B 2D02EF8D";     
 
        var str = this.toString();
        var crc = 0; 
        var n = 0; //a number between 0 and 255 
        var x = 0; //an hex number 
 
        crc = crc ^ (-1); 
        for( var i = 0, iTop = str.length; i < iTop; i++ ) { 
            n = ( crc ^ str.charCodeAt( i ) ) & 0xFF; 
            x = "0x" + table.substr( n * 9, 8 ); 
            crc = ( crc >>> 8 ) ^ x; 
        } 
        return crc ^ (-1); 
    }
}, staticDefinition:
{
	Empty: "",
    Format: function (format, varargs)
    {
        var format = arguments[0];
        for (var i = 1; i < arguments.length; i++)
        {
            var str = '{' + (i - 1) + '}';
            format = format.split(str).join(arguments[i]);
        }
        return format;
    },
    Format$$String$$Object$Array: function (format, argsArray){
        for (var i = 0; i < argsArray.length; i++) {
            var str = '{' + i + '}';
            format = format.split(str).join(argsArray[i]);
        }
        return format;
    },
	Format$$String$$Object$$Object$$Object: function (s, obj1, obj2, obj3) {
	    return System.String.Format$$String$$Object$Array(s, [obj1, obj2, obj3]);
	},
	Format$$String$$Object$$Object: function (s, obj1, obj2) {
	    return System.String.Format$$String$$Object$Array(s, [obj1, obj2]);
	},
	Format$$String$$Object: function (s, obj1) {
	    return System.String.Format$$String$$Object$Array(s, [obj1]);
	},
	Join$$String$$String$Array: function (separator, values) {
		return values.join(separator);
	},
	Compare$$String$$String$$Boolean: function (s1, s2, ignoreCase) {
		if (ignoreCase) {
			s1 = s1.toLowerCase();
			s2 = s2.toLowerCase();
		}
		if (s1 > s2)
			return 1;
		else if (s1 < s2)
			return -1;
		else
			return 0;
	},
	IsNullOrEmpty: function (s) {
		return s == null || s.length == 0;
	}
}
});
var Arguments = function () {
}
//TODO: this method doesn't work good when argsObject contains undefineds
Arguments.from = function (argsObject, start) {
	//1;
	return Array.prototype.slice.call(argsObject, start);
	//	var end = argsObject.length;
	//	var list = new Array();
	//	for(var i=start;i<end;i++)
	//	{
	//		list.push(argsObject[i] || null);
	//	}
	//	return list;
}
Arguments.Range = function (argsObject, start, end) {
	if (end == null)
		end = argsObject.length - 1;
	var list = new Array();
	for (var i = start; i <= end; i++) {
		list.push(argsObject[i]);
	}
	return list;
}
Arguments.Contains = function (args, object) {
	for (var i = 0; i < args.length; i++) {
		if (args[i] == object)
			return true;
	}
	return false;
}
JsTypes.push({ fullname: "Date", definition:
{
	removeTime: function () {
		return new Date(this.getFullYear(), this.getMonth(), this.getDate());
	},
	getStartMonthDayOfWeek: function () {
		return new Date(this.getFullYear(), this.getMonth(), 1).getDay();
	},
	getShortDayOfWeek: function () {
		return Date.shortDays[this.getDay()];
	},
	addMonths: function (months) {
		return new Date(this.getFullYear(), this.getMonth() + months, this.getDate(), this.getHours(), this.getMinutes(), this.getSeconds(), this.getMilliseconds());
	},
	addDays: function (days) {
		return new Date(this.getFullYear(), this.getMonth(), this.getDate() + days, this.getHours(), this.getMinutes(), this.getSeconds(), this.getMilliseconds());
	},
	isInMonth: function (date) {
		return this.getFullYear() == date.getFullYear() && this.getMonth() == date.getMonth();
	}
}, staticDefinition:
{
	shortDays: ["Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"],
	getNow: function () {
		return new Date();
	},
	getToday: function () {
		return new Date().removeTime();
	}
}
});
//THIS file is for backward compatability and should be deprecated
JsTypes.push({ fullname: "VM", definition:
{
}, staticDefinition:
{
	tryParse: function (text, ctor) {
		if (ctor == null)
			return null;
		var type = ctor._type;
		return this._TryParse(text, type);
	},
	TryParse: function (text, type) {
		if (typeof (type) == "string")
			type = Typeof(type);
		if (type == null)
			return null;
		return this._TryParse(text, type._JsType);
	},
	_TryParse: function (text, jsType) {
		if (jsType == null)
			return null;
		if (typeof (jsType) == "string") {
			jsType = this.getType(jsType);
			if (jsType == null)
				return null;
		}
		if (jsType.tryParse == null)
			return null;
		return jsType.tryParse(text);
	},
	PropertyIs: function (object, propertyName, typeName) {
		var propertyCtor = VM.getPropertyType(object, propertyName);
		if (propertyCtor != null)//TODO: recieved ctor
		{
			var propertyType = propertyCtor._type;
			var type = Type.GetType(typeName, true);
			return TypeIs(propertyType, type);
		}
		return false;
	}
}
});
JsTypes.push({ fullname: "SharpKit.DataModel.NotifyCollectionChangedEventArgs", baseTypeName: "System.Object", definition:
{
	ctor: function (action, changedItem) {
		if (arguments.length == 0)
			return; //TODO: Support serialization constructors
		this._Action = action;
		if (action == "Add") {
			this._NewItems = [changedItem];
		}
		else if (action == "Remove") {
			this._OldItems = [changedItem];
		}
		else
			throw new Error("Not implemented");
	},
	get_OldItems: function () {
		return this._OldItems;
	},
	get_NewItems: function () {
		return this._NewItems;
	},
	get_Action: function () {
		return this._Action;
	}
}
});

JsTypes.push({
	fullname: "Uint8Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Uint8Array(this);
  }
}
});

JsTypes.push({
	fullname: "Int16Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Int16Array(this);
  }
}
});

JsTypes.push({
	fullname: "Uint16Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Uint16Array(this);
  }
}
});

JsTypes.push({
    fullname: "Int32Array",
definition:
{
  GetEnumerator: function() {
     return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Int32Array(this);
  }
}
});

JsTypes.push({
	fullname: "Uint32Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Uint32Array(this);
  }
}
});

JsTypes.push({
	fullname: "Float32Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Float32Array(this);
  }
}
});

JsTypes.push({
	fullname: "Float64Array",
definition:
{
  GetEnumerator: function () {
    return new ArrayEnumerator.ctor(this);
  },
  Clone: function() {
    return new Float64Array(this);
  }
}
});
