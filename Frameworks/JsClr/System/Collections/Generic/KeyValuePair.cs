using System;
using System.Collections.Generic;

using System.Text;

namespace SharpKit.JavaScript.Private
{
    [JsType(Name = "System.Collections.Generic.KeyValuePair$2", Filename = "~/res/System.Collections.js")]
    public struct JsImplKeyValuePair<TKey, TValue>
    {

        TKey _Key;
        TValue _Value;

        JsImplKeyValuePair(TKey key, TValue value)
        {
            this._Key = key;
            this._Value = value;
        }

        public TKey Key
        {
            get
            {
                return this._Key;
            }
        }

        public TValue Value
        {
            get { return _Value; }
        }

    }
}
