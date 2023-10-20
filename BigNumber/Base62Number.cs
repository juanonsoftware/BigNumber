using System;
using System.Numerics;

namespace BigNumber
{
    /// <summary>
    /// Initialize a new big number, without limit on min or max value.
    /// The output on ToString method is a string in base-62 representation.
    /// This helps to create a shorter id from a Guid or to get string from an array of bytes.
    /// </summary>
    public sealed class Base62Number : BigNumber
    {
        #region Constructors

        /// <summary>
        /// Create new instance from string value
        /// </summary>
        /// <param name="valueAsString"></param>
        public Base62Number(string valueAsString) : base(valueAsString)
        {
        }

        /// <summary>
        /// Create new instance from byte array
        /// </summary>
        /// <param name="bytes"></param>
        public Base62Number(Byte[] bytes) : base(bytes)
        {
        }

        #endregion

        #region Override methods

        protected override void Initialize(string valueAsString)
        {
            IntValue = new BigInteger(XConverter.FromBase62Hash(valueAsString));
        }

        public override string ToString()
        {
            return XConverter.ToBase62(IntValue.ToByteArray());
        }

        #endregion
    }
}
