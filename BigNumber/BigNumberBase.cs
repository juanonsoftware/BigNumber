using System;
using System.Numerics;

namespace BigNumber
{
    /// <summary>
    /// Base class for big number
    /// </summary>
    public abstract class BigNumber
    {
        public BigInteger IntValue { get; protected set; }

        /// <summary>
        /// Create new instance from string value
        /// </summary>
        /// <param name="valueAsString"></param>
        protected BigNumber(string valueAsString)
        {
            Initialize(valueAsString);
        }

        /// <summary>
        /// Create new instance from byte array
        /// </summary>
        /// <param name="bytes"></param>
        protected BigNumber(Byte[] bytes)
        {
            IntValue = new BigInteger(bytes);
        }

        protected abstract void Initialize(string valueAsString);

        #region Public Override Methods

        public override abstract string ToString();

        public override int GetHashCode()
        {
            return IntValue.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return IntValue.Equals(obj);
        }

        #endregion
    }
}
