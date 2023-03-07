﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloryCompiler
{
    internal class Node
    {
        public NodeType NodeType;
        
        public Node(NodeType nodeType)
        {
            NodeType = nodeType;
        }
    }

    internal class NonLeafNode : Node
    {
        public Node LeftPtr;
        public Node RightPtr;

        public NonLeafNode(NodeType type, Node leftPtr, Node rightPtr) : base(type)
        {
            LeftPtr = leftPtr;
            RightPtr = rightPtr;
        }
    }

    internal class VariableNode : Node
    {
        public Variable Variable;

        public VariableNode(Variable variable) : base(NodeType.Variable) => Variable = variable;
    }

    internal class StringNode : Node
    {
        public string String;

        public StringNode(string str) : base(NodeType.StringLiteral) => String = str;
    }

    internal class IntNode : Node
    {
        public int _int;

        public IntNode(int Int) : base(NodeType.NumberLiteral) => _int = Int;
    }

    internal class BoolNode : Node
    {
        public bool _bool;

        public BoolNode(bool Bool) : base(NodeType.BoolLiteral) => _bool = Bool;
    }

    internal class CallNode : Node
    {
        public Function _function;
        public List<Node> _args;
        public CallNode(Function function, List<Node> args) : base(NodeType.Call)
        {
            _function = function;
            _args = args;
        }
    }

    internal class IndexNode : Node
    {
        public Node _target;
        public Node _index;

        public IndexNode(Node target, Node index) : base(NodeType.Indexer)
        {
            _target = target;
            _index = index;
        }
    }


    public enum NodeType
    {
        OuterStatement,
        Statement,
        Variable,
        Assignment,
        If,
        While,
        Function,
        Expression,
        Compare,
        Plus,
        Minus,
        Divide,
        Div,
        Mod,
        Multiply,
        Index,
        Negate,
        Call,
        Indexer,
        Unary,
        StringLiteral,
        NumberLiteral,
        BoolLiteral,

        DoubleEquals,
        GreaterThan,
        GreaterThanEquals,
        LessThan,
        LessThanEquals,

        Null
    }
}