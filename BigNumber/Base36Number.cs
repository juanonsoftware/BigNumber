using System.Numerics;

namespace BigNumber
{
    /// <summary>
    /// Initialize a new big number, without limit on min or max value.
    /// The output on ToString method is a string in base-36 representation.
    /// This helps to create a shorter id from a Guid or to get string from an array of bytes.
    /// </summary>
    public class Base36Number : BigNumber
    {
        #region Constructors

        /// <summary>
        /// Create new Base36 instance from it's representation in string
        /// </summary>
        /// <param name="valueAsString">Base36 string</param>
        public Base36Number(string valueAsString) : base(valueAsString)
        {
        }

        /// <summary>
        /// Create a Base36 instance from byte array
        /// </summary>
        /// <param name="bytes"></param>
        public Base36Number(byte[] bytes) : base(bytes)
        {
        }

        #endregion

        #region Override methods

        protected override void Initialize(string valueAsString)
        {
            IntValue = new BigInteger(XConverter.FromBase36Hash(valueAsString));
        }

        public override string ToString()
        {
            return XConverter.ToBase36(IntValue.ToByteArray());
        }

        #endregion
    }
}
