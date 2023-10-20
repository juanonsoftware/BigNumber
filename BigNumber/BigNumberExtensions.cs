using System;

namespace BigNumber
{
    public static class BigNumberExtensions
    {
        /// <summary>
        /// New Base36Number from Guid instance
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static Base36Number ToBase36Number(this Guid guid)
        {
            return new Base36Number(guid.ToByteArray());
        }

        /// <summary>
        /// New Base36Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base36Number ToBase36Number(this long base10Number)
        {
            return new Base36Number(BitConverter.GetBytes(base10Number));
        }

        /// <summary>
        /// New Base36Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base36Number ToBase36Number(this int base10Number)
        {
            return new Base36Number(BitConverter.GetBytes(base10Number));
        }

        /// <summary>
        /// New Base62Number from Guid instance
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static Base62Number ToBase62Number(this Guid guid)
        {
            return new Base62Number(guid.ToByteArray());
        }

        /// <summary>
        /// New Base62Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base62Number ToBase62Number(this long base10Number)
        {
            return new Base62Number(BitConverter.GetBytes(base10Number));
        }

        /// <summary>
        /// New Base62Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base62Number ToBase62Number(this int base10Number)
        {
            return new Base62Number(BitConverter.GetBytes(base10Number));
        }
    }
}
