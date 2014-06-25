
/*******************************************************************************************************

  Copyright (C) 2012 Sebastian Loncar, Web: http://loncar.de

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace WebIDLParser
{
    public class TCodeTokenFile
    {

        public string name;
        public TStringList source;
        public TCodeToken[] tokens;
        public TCodeToken[] includeTokens;
        public TStringList includeSource;
        public bool hasError = false;
        public object state;

    }

    public class TCodeToken
    {

        private ECodeToken _token;
        public ECodeToken token
        {
            get
            {
                return _token;
            }
        }

        private string _value;
        public string value
        {
            get
            {
                return _value;
            }
        }

        public bool matchOffset(int offset)
        {
            return this.offset <= offset && offset < this.offset + this.length;
        }

        public int length
        {
            get
            {
                return value.Length;
            }
        }

        public string valueUnquoted
        {
            get
            {
                if (token == ECodeToken.ltQuotedString)
                {
                    char QuotChar = _value[0];
                    return _value.Substring(1, value.Length - 2).Replace(QuotChar.ToString() + QuotChar.ToString(), QuotChar.ToString());
                }
                else
                {
                    return _value;
                }
            }
        }

        public void setValue(string value)
        {
            _value = value;
        }

        private int _line;
        public int line
        {
            get
            {
                return _line;
            }
        }

        private int _column;
        public int column
        {
            get
            {
                return _column;
            }
        }

        private int _index;
        public int index
        {
            get
            {
                return _index;
            }
        }

        private int _offset;
        public int offset
        {
            get
            {
                return _offset;
            }
        }

        public TCodeToken(string value, ECodeToken Token, int Index, int Line, int Column, int Offset, TCodeTokenFile File)
        {
            _value = value;
            _token = Token;
            _line = Line;
            _column = Column;
            _index = Index;
            //_Script = Script
            _file = File;
            _offset = Offset;
        }

        private TCodeTokenFile _file;
        public TCodeTokenFile file
        {
            get
            {
                return _file;
            }
        }

        public bool isLiteral
        {
            get
            {
                return _token >= ECodeToken.ltString && _token <= ECodeToken.ltQuotedString;
            }
        }

        public bool isOperator
        {
            get
            {
                return _token >= ECodeToken.blEquals && _token <= ECodeToken.mtAddString;
            }
        }

        public bool isConst
        {
            get
            {
                return _token >= ECodeToken.ctTrue && _token <= ECodeToken.ctNull;
            }
        }

        public bool isKeyWord
        {
            get
            {
                return _token >= ECodeToken.kwInterface && _token <= ECodeToken.kwAttribute;
            }
        }

        public bool isBrace
        {
            get
            {
                return _token >= ECodeToken.brBraceBegin && _token <= ECodeToken.brSmallBraceEnd;
            }
        }

        private TCodeToken _NextToken;
        public TCodeToken nextToken
        {
            get
            {
                return _NextToken;
            }
            set
            {
                _NextToken = value;
            }
        }

        public bool nextTokenIs(ECodeToken tok)
        {
            if (_NextToken == null)
            {
                return false;
            }
            else
            {
                return _NextToken.token == tok;
            }
        }



        public bool nextTokenIsOperator()
        {
            if (_NextToken == null)
            {
                return false;
            }
            else
            {
                return _NextToken.isOperator;
            }
        }

        private TCodeToken _LastToken;
        public TCodeToken lastToken
        {
            get
            {
                return _LastToken;
            }
            set
            {
                _LastToken = value;
            }
        }

        public bool getNextToken(ref TCodeToken RefToken)
        {
            if (_NextToken == null)
            {
                return false;
            }
            else
            {
                RefToken = _NextToken;
                return true;
            }
        }

        public bool getLastToken(ref TCodeToken refToken)
        {
            if (_LastToken == null)
            {
                return false;
            }
            else
            {
                refToken = _LastToken;
                return true;
            }
        }

    }

    public enum ECodeToken : int
    {
        Unkown,

        //Literals
        ltString,
        ltNumber,
        ltQuotedString,

        //Compare Operators
        blEquals, //=
        blLessThan, //<
        blLessThanOrEquals, //<=
        blGreaterThan, //>
        blGreaterThanOrEquals, //>=
        blUnEquals, //<>
        blIs, //is

        //Math Operators
        mtAdd,
        mtSub,
        mtMul,
        mtDiv,
        mtAddString,

        //KeyWords
        kwInterface,
        kwIn,
        kwStatic,
        kwConst,
        kwRaises,
        kwGetter,
        kwSetter,
        kwReadonly,
        kwAttribute,

        //Syntax
        brBraceBegin, //(
        brBraceEnd, //)
        brBigBraceBegin, //{
        brBigBraceEnd, //}
        brSmallBraceBegin, //[
        brSmallBraceEnd, //]

        syPoint, //.
        syComma, //,
        syEndOfCommand, //;
        syDoublePoint, //:
        SyEndOfLine, //vbNewLine
        syWhiteSpace,
        syQuestionmark,
        syAddAdd,
        sySubSub,
        syRoute, //#
        syComment,

        //Konstanten
        ctTrue,
        ctFalse,
        ctNull
    }

    public delegate TCodeToken[] DScriptTokenizerGetIncludeSource(string Name, TCodeTokenFile TokenFile);

    public class TScriptTokenizer
    {

        //Public HasError As Boolean = False
        private ArrayList Tokens = new ArrayList();
        public DScriptTokenizerGetIncludeSource IncludeDelegate;
        public string FileName = "";

        public bool HasError
        {
            get
            {
                return TokenFile.hasError;
            }
        }

        public TScriptTokenizer(string Source, object State = null, DScriptTokenizerGetIncludeSource IncludeDelegate = null)
        {
            TokenFile = new TCodeTokenFile();
            TokenFile.name = FileName;
            TokenFile.state = State;
            ParseString = Source;
            if (ParseString == null)
            {
                ParseString = "";
            }
            this.IncludeDelegate = IncludeDelegate;
        }

        public TCodeTokenFile GetTokenFile()
        {
            ReadTokens();
            TokenFile.tokens = (TCodeToken[])Tokens.ToArray(typeof(TCodeToken));
            TokenFile.source = TokensToStringList();
            Include();
            TokenFile.includeTokens = (TCodeToken[])Tokens.ToArray(typeof(TCodeToken));
            TokenFile.includeSource = TokensToStringList();
            TokenFile.hasError = HasError;
            return TokenFile;
        }

        private void Include()
        {
            if (IncludeDelegate != null)
            {
                for (int i = Tokens.Count - 1; i >= 0; i--)
                {
                    TCodeToken tok = (TCodeToken)(Tokens[i]);
                    if (tok.token == ECodeToken.syRoute && i != Tokens.Count - 1)
                    {
                        TCodeToken LabelToken = (TCodeToken)(Tokens[i + 1]);
                        if (LabelToken.token == ECodeToken.ltString && LabelToken.value == "Include")
                        {
                            for (int i2 = i + 2; i2 < Tokens.Count; i2++)
                            {
                                TCodeToken NameToken = (TCodeToken)(Tokens[i2]);
                                if (NameToken.token == ECodeToken.syEndOfCommand)
                                {
                                    //Dim Name As String = NameToken.Value
                                    string Name = "";
                                    for (int i3 = i + 2; i3 < i2; i3++)
                                    {
                                        Name += ((TCodeToken)(Tokens[i3])).value;
                                    }
                                    TCodeToken[] SubTokens = null;
                                    SubTokens = IncludeDelegate(Name, TokenFile);
                                    if (SubTokens != null)
                                    {
                                        Tokens.InsertRange(i, SubTokens);
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool IsEndOfLine()
        {
            return IsEndOfLine(ParsePos);
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool IsEndOfDocument()
        {
            return IsEndOfDocument(ParsePos);
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool IsEndOfDocument(int pos)
        {
            return pos > ParseString.Length - 1;
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool IsEndOfLine(int pos)
        {
            if (IsEndOfDocument(pos))
            {
                return true;
            }
            char c = ParseString[pos];
            return c == vbLf || c == vbCr;
        }

        //------------------------------------------------------------------------------------------------------------------
        private TCodeTokenFile TokenFile;
        private void ReadTokens()
        {
            Tokens = new ArrayList();

            TCodeToken tok = null;
            while (true)
            {
                tok = ReadNextToken();
                if (tok == null)
                {
                    break;
                }
            }
            //Script._Tokens = CType(Tokens.ToArray(GetType(TCodeToken)), TCodeToken())
        }

        private TStringList TokensToStringList()
        {
            TStringList st = new TStringList();
            System.Text.StringBuilder CurrentLine = new System.Text.StringBuilder();
            foreach (TCodeToken tok in Tokens)
            {
                if (tok.token == ECodeToken.SyEndOfLine)
                {
                    st.Add(CurrentLine.ToString());
                    CurrentLine.Length = 0;
                }
                else
                {
                    CurrentLine.Append(tok.value);
                }
            }
            return st;
        }

        private int CurrentLine = 0;
        private int CurrentColumn = 0;
        private string ParseString;
        private int ParsePos;

        private char CurrentChar
        {
            get
            {
                return ParseString[ParsePos];
            }
        }

        private char vbTab = Convert.ToChar("\t");
        private char vbCr = Convert.ToChar("\r");
        private char vbLf = Convert.ToChar("\n");

        private TCodeToken ReadNextToken()
        {
            if (IsEndOfDocument())
            {
                return null;
            }
            //MoveToNextNoneWhitespace()
            if (IsEndOfDocument())
            {
                return null;
            }

            int cIndex = ParsePos;
            int cLine = CurrentLine;
            int cColumn = CurrentColumn;
            string Value = "";
            ECodeToken tok = ECodeToken.Unkown;
            char c = CurrentChar;
            Value = c.ToString();

            if (char.IsLetter(c) || c == '_')
            {
                Value = ReadString();
                tok = GetTokenConst(Value);
                if ((LastCharIs('.') || NextCharIs('.'))) //Schlüsselwörter mit angrenzenden Punkten als Literal behandeln
                {
                    tok = ECodeToken.ltString;
                }
                else
                {
                    if (tok == ECodeToken.Unkown)
                    {
                        tok = ECodeToken.ltString;
                    }
                }
            }
            else if (char.IsDigit(c))
            {
                Value = ReadNumber();
                tok = ECodeToken.ltNumber;
            }
            else
            {
                if (c == '=')
                {
                    tok = ECodeToken.blEquals;
                }
                else if (c == '<')
                {
                    if (NextCharIs('='))
                    {
                        MoveNextChar();
                        Value = "<=";
                        tok = ECodeToken.blLessThanOrEquals;
                    }
                    else if (NextCharIs('>'))
                    {
                        MoveNextChar();
                        Value = "<>";
                        tok = ECodeToken.blUnEquals;
                    }
                    else
                    {
                        tok = ECodeToken.blLessThan;
                    }
                }
                else if (c == '>')
                {
                    if (NextCharIs('='))
                    {
                        MoveNextChar();
                        Value = ">=";
                        tok = ECodeToken.blGreaterThanOrEquals;
                    }
                    else
                    {
                        tok = ECodeToken.blGreaterThan;
                    }
                }
                else if (c == vbCr)
                {
                    tok = ECodeToken.SyEndOfLine;
                    if (NextCharIs(vbLf))
                    {
                        MoveNextChar();
                        Value = Environment.NewLine;
                        cLine -= 1;
                    }
                }
                else if (c == '+')
                {
                    if (NextCharIs('+'))
                    {
                        MoveNextChar();
                        Value = "++";
                        tok = ECodeToken.syAddAdd;
                    }
                    else
                    {
                        tok = ECodeToken.mtAdd;
                    }
                }
                else if (c == '-')
                {
                    if (NextCharIs('-'))
                    {
                        MoveNextChar();
                        Value = "--";
                        tok = ECodeToken.sySubSub;
                        //ElseIf Char.IsDigit(ParseString.Chars(ParsePos + 1)) Then
                        //	MoveNextChar()
                        //	Value = "-" & ReadNumber()
                        //	tok = ECodeToken.ltNumber
                    }
                    else
                    {
                        tok = ECodeToken.mtSub;
                    }
                }
                else if (c == '\"')
                {
                    Value = ReadQuotedString();
                    tok = ECodeToken.ltQuotedString;
                }
                else if (c == '\'')
                {
                    Value = ReadQuotedString();
                    tok = ECodeToken.ltQuotedString;
                }
                else if (c == ' ')
                {
                    Value = ReadWhiteSpace();
                    tok = ECodeToken.syWhiteSpace;
                }
                else if (c == vbTab)
                {
                    Value = ReadWhiteSpace();
                    tok = ECodeToken.syWhiteSpace;
                    //Case "#"
                    //	tok = ECodeToken.syRoute
                    //	Value = ReadString()
                }
                else
                {
                    if (c == '/' && NextCharIs('/'))
                    {
                        Value = ReadCommentLine();
                        tok = ECodeToken.syComment;
                    }
                    else if (c == '/' && NextCharIs('*'))
                    {
                        Value = ReadCommentBlock();
                        tok = ECodeToken.syComment;
                    }
                    else
                    {
                        tok = GetTokenConst(c.ToString());
                    }
                }
            }

            MoveNextChar();
            TCodeToken ResultToken = new TCodeToken(Value, tok, cIndex, cLine, cColumn, ParsePos - Value.Length, TokenFile);
            if (Tokens.Count > 0)
            {
                TCodeToken LastToken = GetToken(Tokens.Count - 1);
                LastToken.nextToken = ResultToken;
                ResultToken.lastToken = LastToken;
            }
            Tokens.Add(ResultToken);
            return ResultToken;
        }

        //------------------------------------------------------------------------------------------------------------------
        private TCodeToken GetToken(int idx)
        {
            if (idx > Tokens.Count - 1)
            {
                return null;
            }
            return (TCodeToken)(Tokens[idx]);
        }

        //------------------------------------------------------------------------------------------------------------------
        private void MoveNextChar()
        {
            ParsePos += 1;
            UpdatePosition();
        }

        //------------------------------------------------------------------------------------------------------------------
        private void UpdatePosition()
        {
            if (IsEndOfDocument())
            {
                return;
            }
            if (CurrentChar == vbCr)
            {
                CurrentLine += 1;
                CurrentColumn = 0;
            }
            else
            {
                CurrentColumn += 1;
            }
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool NextCharIs(char c)
        {
            return !(IsEndOfDocument(ParsePos + 1)) && ParseString[ParsePos + 1] == c;
        }

        //------------------------------------------------------------------------------------------------------------------
        private bool LastCharIs(char c)
        {
            return ParsePos - 1 >= 0 && ParseString[ParsePos - 1] == c;
        }

        //------------------------------------------------------------------------------------------------------------------
        //Private Sub MoveToNextNoneWhitespace()
        //	While True
        //		If IsEndOfDocument Then Return
        //		Dim c As Char = CurrentChar
        //		'If Char.IsWhiteSpace(CurrentChar) Then
        //		If c = " "c OrElse c = vbTab Then
        //			MoveNextChar()
        //		Else
        //			Exit While
        //		End If
        //	End While
        //End Sub

        //------------------------------------------------------------------------------------------------------------------
        private string ReadWhiteSpace()
        {
            int PosStart = ParsePos;
            while (true)
            {
                if (IsEndOfLine(ParsePos + 1))
                {
                    break;
                }
                else if (!(ParseString[ParsePos + 1] == ' ' || ParseString[ParsePos + 1] == vbTab))
                {
                    break;
                }
                MoveNextChar();
            }
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        //------------------------------------------------------------------------------------------------------------------
        private string ReadString()
        {
            int PosStart = ParsePos;
            while (true)
            {
                if (IsEndOfLine(ParsePos + 1))
                {
                    break;
                }
                else if (!(char.IsLetterOrDigit(ParseString[ParsePos + 1]) || ParseString[ParsePos + 1] == '_'))
                {
                    break;
                }
                MoveNextChar();
            }
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        //------------------------------------------------------------------------------------------------------------------
        private string ReadQuotedString()
        {
            int PosStart = ParsePos;
            char QuotChar = CurrentChar;
            while (true)
            {
                MoveNextChar();
                if (IsEndOfDocument())
                {
                    break;
                }
                else
                {
                    if (CurrentChar == QuotChar)
                    {
                        if (NextCharIs(QuotChar))
                        {
                            MoveNextChar();
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                    }
                }
            }
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        //------------------------------------------------------------------------------------------------------------------
        private string ReadCommentBlock()
        {
            int PosStart = ParsePos;
            while (true)
            {
                MoveNextChar();
                if (IsEndOfDocument())
                {
                    break;
                }
                else
                {
                    if (CurrentChar == '*')
                    {
                        if (NextCharIs('/'))
                        {
                            break;
                        }
                    }
                    else
                    {
                    }
                }
            }
            MoveNextChar();
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        //------------------------------------------------------------------------------------------------------------------
        private string ReadCommentLine()
        {
            int PosStart = ParsePos;
            while (true)
            {
                MoveNextChar();
                if (IsEndOfDocument(ParsePos + 1) || IsEndOfLine(ParsePos + 1))
                {
                    break;
                }
            }
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        //------------------------------------------------------------------------------------------------------------------
        private string ReadNumber()
        {
            int PosStart = ParsePos;
            while (true)
            {
                if (IsEndOfLine(ParsePos + 1))
                {
                    break;
                }
                else if (!(char.IsDigit(ParseString[ParsePos + 1])))
                {
                    if (ParseString[ParsePos + 1] != '.' || !(char.IsDigit(ParseString[ParsePos + 2])))
                    {
                        break;
                    }
                }
                MoveNextChar();
            }
            if (IsEndOfDocument())
            {
                return ParseString.Substring(PosStart);
            }
            return ParseString.Substring(PosStart, ParsePos - PosStart + 1);
        }

        public static void SharedInit()
        {
            InitTokenCost();
        }

        public static Hashtable TokenConstHash;
        public static ECodeToken GetTokenConst(string str)
        {
            str = str.ToUpper();
            if (TokenConstHash.Contains(str))
            {
                return (ECodeToken)(TokenConstHash[str]);
            }
            else
            {
                return ECodeToken.Unkown;
            }
        }

        private static void InitTokenCost()
        {
            TokenConstHash = new Hashtable();
            AddTokenConst("STATIC", ECodeToken.kwStatic);
            AddTokenConst("INTERFACE", ECodeToken.kwInterface);
            AddTokenConst("READONLY", ECodeToken.kwReadonly);
            AddTokenConst("CONST", ECodeToken.kwConst);
            AddTokenConst("RAISES", ECodeToken.kwRaises);
            AddTokenConst("GETTER", ECodeToken.kwGetter);
            AddTokenConst("SETTER", ECodeToken.kwSetter);
            AddTokenConst("IN", ECodeToken.kwIn);
            AddTokenConst("ATTRIBUTE", ECodeToken.kwAttribute);
            AddTokenConst("&", ECodeToken.mtAddString);
            AddTokenConst("<", ECodeToken.blLessThan);
            AddTokenConst("<=", ECodeToken.blLessThanOrEquals);
            AddTokenConst(">", ECodeToken.blGreaterThan);
            AddTokenConst(">=", ECodeToken.blGreaterThanOrEquals);
            AddTokenConst("+", ECodeToken.mtAdd);
            AddTokenConst("-", ECodeToken.mtSub);
            AddTokenConst("*", ECodeToken.mtMul);
            AddTokenConst("/", ECodeToken.mtDiv);
            AddTokenConst(",", ECodeToken.syComma);
            AddTokenConst("(", ECodeToken.brBraceBegin);
            AddTokenConst(")", ECodeToken.brBraceEnd);
            AddTokenConst("{", ECodeToken.brBigBraceBegin);
            AddTokenConst("}", ECodeToken.brBigBraceEnd);
            AddTokenConst("[", ECodeToken.brSmallBraceBegin);
            AddTokenConst("]", ECodeToken.brSmallBraceEnd);
            AddTokenConst(".", ECodeToken.syPoint);
            AddTokenConst(";", ECodeToken.syEndOfCommand);
            AddTokenConst(":", ECodeToken.syDoublePoint);
            AddTokenConst("#", ECodeToken.syRoute);
            AddTokenConst("?", ECodeToken.syQuestionmark);
            AddTokenConst("TRUE", ECodeToken.ctTrue);
            AddTokenConst("FALSE", ECodeToken.ctFalse);
            AddTokenConst("NULL", ECodeToken.ctNull);
        }

        private static void AddTokenConst(string str, ECodeToken tok)
        {
            TokenConstHash.Add(str.ToUpper(), tok);
        }

    }

}