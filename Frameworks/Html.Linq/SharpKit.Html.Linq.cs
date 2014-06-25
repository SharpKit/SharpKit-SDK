using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using System.Collections;

namespace SharpKit.Html
{
    /// <summary>
    /// Provides Linq-like extensions for HtmlElement without requiring Clr mode
    /// This library requires a script include SharpKit.Html.Linq.js
    /// </summary>
    [JsType(JsMode.Prototype)]
    public static class Extensions
    {
        /// <summary>
        /// Returns a collection of the descendant elements for this element
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlElement> Descendents(this HtmlElement el)
        {
            return new HtmlElementEnumerator(el, true, false);
        }
        /// <summary>
        /// Returns a collection of the child elements for this element
        /// </summary>
        /// <param name="el"></param>
        /// <returns></returns>
        public static IEnumerable<HtmlElement> Children(this HtmlElement el)
        {
            return new HtmlElementEnumerator(el, false, false);
        }

    }


    [JsType(JsMode.Prototype)]
    class HtmlElementEnumerator : IEnumerator<HtmlElement>, IEnumerable<HtmlElement>
    {
        public HtmlElementEnumerator(HtmlElement root, bool includeDescendents, bool includeSelf)
        {
            IncludeDescendents = includeDescendents;
            IncludeSelf = includeSelf;
            Root = root;
            if (IncludeDescendents)
            {
                Stack = new JsArray<HtmlElement>();
                Stack.push(Root);
            }
        }
        #region IEnumerator<Node> Members

        bool IncludeDescendents;
        bool IncludeSelf;
        HtmlElement _Current;
        public HtmlElement Current { get { return _Current; } }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            Root = null;
            _Current = null;
            Stack = null;
        }

        #endregion

        #region IEnumerator Members

        object IEnumerator.Current
        {
            get { return Current; }
        }

        HtmlElement Root;
        public bool MoveNext()
        {
            if (!IncludeDescendents)
            {
                Node node = _Current;
                if (node == null)
                    node = Root.firstChild;
                else
                    node = node.nextSibling;
                while (node != null && node.nodeType != 1)
                    node = node.nextSibling;
                _Current = node.As<HtmlElement>();
                return _Current != null;
            }
            else
            {
                Node node = _Current;
                if (node != null)
                {
                    node = node.nextSibling;
                    while (node != null && _Current.nodeType != 1)
                        node = node.nextSibling;
                }
                while (node == null && Stack.length > 0)
                {
                    var parent = Stack.pop();
                    node = parent.firstChild;
                    while (node != null && node.nodeType != 1)
                        node = node.nextSibling;
                }
                _Current = node.As<HtmlElement>();
                if (_Current == null)
                    return false;
                Stack.push(_Current);
                return true;
            }
        }

        JsArray<HtmlElement> Stack;

        public void Reset()
        {
            if (IncludeDescendents)
            {
                Stack = new JsArray<HtmlElement>();
                Stack.push(Root);
            }
            _Current = null;
        }

        #endregion

        #region IEnumerable<Node> Members

        public IEnumerator<HtmlElement> GetEnumerator()
        {
            return this;
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    //[JsType(JsMode.Prototype)]
    //class NodeEnumerator : IEnumerator<Node>, IEnumerable<Node>
    //{
    //    public NodeEnumerator(Node root, bool includeDescendents, bool includeSelf)
    //    {
    //        IncludeDescendents = includeDescendents;
    //        IncludeSelf = includeSelf;
    //        Root = root;
    //        if (IncludeDescendents)
    //        {
    //            Stack = new JsArray<Node>();
    //            Stack.push(Root);
    //        }
    //    }
    //    #region IEnumerator<Node> Members

    //    bool IncludeDescendents;
    //    bool IncludeSelf;
    //    Node _Current;
    //    public Node Current { get { return _Current; } }

    //    #endregion

    //    #region IDisposable Members

    //    public void Dispose()
    //    {
    //        Root = null;
    //        _Current = null;
    //        Stack = null;
    //    }

    //    #endregion

    //    #region IEnumerator Members

    //    object IEnumerator.Current
    //    {
    //        get { return Current; }
    //    }

    //    Node Root;
    //    public bool MoveNext()
    //    {
    //        if (!IncludeDescendents)
    //        {
    //            if (_Current == null)
    //                _Current = Root.firstChild;
    //            else
    //                _Current = _Current.nextSibling;
    //            return _Current != null;
    //        }
    //        else
    //        {

    //            if (_Current != null)
    //                _Current = _Current.nextSibling;
    //            while (_Current == null && Stack.length > 0)
    //            {
    //                var parent = Stack.pop();
    //                _Current = parent.firstChild;
    //            }
    //            if (_Current == null)
    //                return false;
    //            Stack.push(_Current);
    //            return true;
    //        }
    //    }

    //    JsArray<Node> Stack;

    //    public void Reset()
    //    {
    //        if (IncludeDescendents)
    //        {
    //            Stack = new JsArray<Node>();
    //            Stack.push(Root);
    //        }
    //        _Current = null;
    //    }

    //    #endregion

    //    #region IEnumerable<Node> Members

    //    public IEnumerator<Node> GetEnumerator()
    //    {
    //        return this;
    //    }

    //    #endregion

    //    #region IEnumerable Members

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    #endregion
    //}


}
