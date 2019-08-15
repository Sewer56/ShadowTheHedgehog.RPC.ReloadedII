using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using Reloaded.Memory;
using Reloaded.Memory.Sources;

namespace Dolphin.ShadowTheHedgehog.RPC.Dolphin
{
    public unsafe class DolphinPointer<TPrimitive> where TPrimitive : unmanaged
    {
        /// <summary>
        /// Gets the pointer in emulated memory this class was instantiated with.
        /// </summary>
        public void* Address { get; set; }

        /// <summary>
        /// The source where memory will be read/written to/from.
        /// </summary>
        public IMemory Source { get; set; }

        private Memory.Access.Dolphin _dolphin;

        /// <summary>
        /// Tries to obtain the real address of the variable.
        /// This operation fails if no game is running.
        /// </summary>
        /// <returns></returns>
        public bool TryGetRealAddress(out IntPtr address)
        {
            return _dolphin.TryGetAddress((long) Address, out address);
        }

        /// <summary>
        /// Gets the value at the address where the current pointer points to.
        /// </summary>
        public TPrimitive? GetValue()
        {
            if (TryGetRealAddress(out var address))
            {
                Source.Read((IntPtr)address, out TPrimitive bareValue);
                Endian.Reverse(ref bareValue);
                return bareValue;
            }

            return null;
        }

        /// <summary>
        /// Gets the value at the address where the current pointer points to.
        /// </summary>
        /// <param name="value"></param>
        public bool TryGetValue(out TPrimitive value)
        {
            if (TryGetRealAddress(out var address))
            {
                Source.Read((IntPtr)address, out value);
                Endian.Reverse(ref value);
                return true;
            }

            value = default;
            return false;
        }

        /// <summary>
        /// Sets the value where the current pointer is pointing to.
        /// </summary>
        /// <param name="value"></param>
        public bool TrySetValue(ref TPrimitive value)
        {
            if (TryGetRealAddress(out var address))
            {
                Endian.Reverse(ref value);
                Source.Write((IntPtr)address, ref value);
                return true;
            }

            return false;
        }

        /*
            ------------
            Constructors
            ------------
        */

        /// <summary>
        /// Constructs a new instance of <see cref="Pointer{T}"/> given the address (pointer)
        /// in emulated memory at which the value of type <typeparamref name="TPrimitive"/> is stored.
        /// </summary>
        /// <param name="address">The address of the pointer pointing to generic type {T}</param>
        /// <param name="dolphin">Instance of Dolphin Memory Access library.</param>
        /// <param name="memorySource">Specifies the source from which the pointer should be read/written.</param>
        public DolphinPointer(ulong address, Memory.Access.Dolphin dolphin, IMemory memorySource = null)
        {
            Address = (void*)address;
            _dolphin = dolphin;

            if (memorySource != null)
                Source = memorySource;
            else
                Source = new Reloaded.Memory.Sources.Memory();
        }



    }
}
