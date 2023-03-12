﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloryCompiler
{
    internal class Operand
    {
        public bool IsDereferenced;
        public OperandBase OpBase;
        public int Offset;
        public int LiteralValue;

        private Operand(OperandBase opBase, bool isDereferenced, int offset, int literalValue)
        {
            OpBase = opBase;
            IsDereferenced = isDereferenced;
            Offset = offset;
            LiteralValue = literalValue;
        }

        public static Operand ForReg(OperandBase opBase) => new Operand(opBase, false, 0, 0);
        public static Operand ForDerefReg(OperandBase opBase, int offset = 0) => new Operand(opBase, true, offset, 0);
        public static Operand ForLiteral(int value) => new Operand(OperandBase.Literal, false, 0, value);
        public static Operand ForDerefLiteral(int value) => new Operand(OperandBase.Literal, true, 0, value);

        public static readonly Operand Rax = ForReg(OperandBase.Rax);
        public static readonly Operand Rbx = ForReg(OperandBase.Rbx);
        public static readonly Operand Rcx = ForReg(OperandBase.Rcx);
        public static readonly Operand Rdx = ForReg(OperandBase.Rdx);
        public static readonly Operand Rsi = ForReg(OperandBase.Rsi);
        public static readonly Operand Rdi = ForReg(OperandBase.Rdi);
        public static readonly Operand Rsp = ForReg(OperandBase.Rsp);
        public static readonly Operand Rbp = ForReg(OperandBase.Rbp);
        public static readonly Operand R8 =  ForReg(OperandBase.R8);
        public static readonly Operand R9 =  ForReg(OperandBase.R9);
        public static readonly Operand R10 = ForReg(OperandBase.R10);
        public static readonly Operand R11 = ForReg(OperandBase.R11);
        public static readonly Operand R12 = ForReg(OperandBase.R12);
        public static readonly Operand R13 = ForReg(OperandBase.R13);
        public static readonly Operand E14 = ForReg(OperandBase.E14);
        public static readonly Operand E15 = ForReg(OperandBase.E15);
        public static readonly Operand Eax = ForReg(OperandBase.Eax);
        public static readonly Operand Ebx = ForReg(OperandBase.Ebx);
        public static readonly Operand Ecx = ForReg(OperandBase.Ecx);
        public static readonly Operand Edx = ForReg(OperandBase.Edx);
        public static readonly Operand Esi = ForReg(OperandBase.Esi);
        public static readonly Operand Edi = ForReg(OperandBase.Edi);
        public static readonly Operand Esp = ForReg(OperandBase.Esp);
        public static readonly Operand Ebp = ForReg(OperandBase.Ebp);
    }

    public enum OperandBase
    {
        Rax,
        Rcx,
        Rdx,
        Rbx,
        Rsi,
        Rdi,
        Rsp,
        Rbp,
        R8,
        R9,
        R10,
        R11,
        R12,
        R13,
        E14,
        E15,
        Eax,
        Ecx,
        Edx,
        Ebx,
        Esi,
        Edi,
        Esp,
        Ebp,
        Literal
    }
}
