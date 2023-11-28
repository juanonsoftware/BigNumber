using System;
using System.IO;
using System.Text;

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
        /// New Base36Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base36Number ToBase36Number(this decimal base10Number)
        {
            var bytes = Encoding.ASCII.GetBytes(base10Number.ToString());
            return new Base36Number(bytes);
        }

        /// <summary>
        /// Get back a base-10 decimal number from Base36Number
        /// </summary>
        /// <param name="base36"></param>
        /// <returns></returns>
        public static decimal AsDecimal(this Base36Number base36)
        {
            var str = Encoding.ASCII.GetString(base36.IntValue.ToByteArray());
            return decimal.Parse(str);
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

        /// <summary>
        /// New Base62Number from base-10 number
        /// </summary>
        /// <param name="base10Number"></param>
        /// <returns></returns>
        public static Base62Number ToBase62Number(this decimal base10Number)
        {
            var bytes = Encoding.ASCII.GetBytes(base10Number.ToString());
            return new Base62Number(bytes);
        }

        /// <summary>
        /// Get back a base-10 decimal number from Base62Number
        /// </summary>
        /// <param name="base62"></param>
        /// <returns></returns>
        public static decimal AsDecimal(this Base62Number base62)
        {
            var str = Encoding.ASCII.GetString(base62.IntValue.ToByteArray());
            return decimal.Parse(str);
        }
    }
}
