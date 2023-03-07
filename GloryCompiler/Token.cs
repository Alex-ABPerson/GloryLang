﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloryCompiler
{
    internal class Token
    {
        public TokenType Type;
        public Token(TokenType type) => Type = type;
    }

    internal class NumberLiteralToken : Token
    {
        public int Val;
        public NumberLiteralToken(int val) : base(TokenType.NumberLiteral) => Val = val;
    }

    internal class StringLiteralToken : Token
    {
        public string Val;
        public StringLiteralToken(string val) : base(TokenType.StringLiteral) => Val = val;
    }

    internal class IdentifierLiteralToken : Token
    {
        public string Val;
        public IdentifierLiteralToken(string val) : base(TokenType.Identifier) => Val = val;
    }

    internal class BoolLiteralToken : Token
    {
        public bool Val;
        public BoolLiteralToken(bool val) : base(TokenType.BoolLiteral) => Val = val;
    }

    public enum TokenType
    {
        // Operators:
        Plus, //tick
        Minus, //tick
        Times, //tick
        Divide, //tick
        LessThan, //tick
        LessThanEquals, //tick
        Equals, //tick
        DoubleEquals, //tick
        GreaterThan, //tick
        GreaterThanEquals, //tick
        Index, //tick
        Mod, //tick
        Div, //tick


        Comma,

        // Types:
        IntType, //tick
        StringType, //tick
        FloatType, //tick
        BoolType, //tick
        Blank, //tick

        // General Structure:
        Semicolon, //tick
        OpenBracket,//tick
        CloseBracket, //tick
        OpenCurly, //tick
        CloseCurly, //tick
        OpenSquare,
        CloseSquare,

        // Literals:
        StringLiteral, //tick
        NumberLiteral, //tick
        Identifier, //tick

        BoolLiteral,

        // Keywords:
        If, //tick
        ElseIf, //tick
        Else, //tick
        While, //tick
        Return, //tick

        // Null:
        Null
    }
}
