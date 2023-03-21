using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloryCompiler.Generation
{
    /// <summary>
    /// Class responsible for tracking and generating all stack operations
    /// </summary>
    internal class StackManager
    {
        int _currentStackSize;
        CodeOutput _codeOutput;
        public StackManager(CodeOutput codeOutput) => _codeOutput = codeOutput;

        public StackItem PushReg(Operand value)
        {
            _currentStackSize += 4; // Or 8?
            _codeOutput.EmitPush(value);
            return new StackItem(this, _currentStackSize);
        }

        public Operand PopReg(StackItem item, Operand destination)
        {
            // Verify this is valid
            if (_currentStackSize < item.Offset)
                throw new Exception("Attempted to either generate a pop twice or over-popped somewhere.");
            if (_currentStackSize > item.Offset)
                throw new Exception("Attempted to generate a pop for value that's not currently at the bottom of the stack!");

            // Emit the pop!
        }

        // Marks an item as no longer in use
        public StackItem Reserve(int size)
        {

        }

        public void Free(int size)
        {
            
        }
    }

    /// <summary>
    /// Represents an item on the stack.
    /// </summary>
    internal class StackItem
    {
        StackManager _manager;
        public int Offset;

        public StackItem(StackManager manager, int stackSizeWhenCreated)
        {
            _manager = manager;
            Offset = stackSizeWhenCreated;
        }

        public Operand Access()
        {
            // Access at the relevant offset
            
        }
    }

    /// <summary>
    /// Represents an entire reserved block of data on the stack.
    /// </summary>
    internal class StackBlock
    {
        public int Size;
        public int StartOffset;

        public StackBlock(StackManager manager, int stackSizeWhenCreated)
        {
            _manager = manager;
            StartOffset = stackSizeWhenCreated;
        }

        public Operand Access()
        {
            // Access at the currently relevant offset

        }
    }
}
