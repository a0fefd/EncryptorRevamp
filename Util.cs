﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace EncryptorRevamp
{
    public class Util
    {
        private static Byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }
        public static string XOR(string str, string key)
        {
            int strLen = str.Length;
            int keyLen = key.Length;
            char[] output = new char[strLen];

            for (int i = 0; i < strLen; ++i)
            {
                output[i] = (char)(str[i] ^ key[i % keyLen]);
            }

            return new string(output);
        }
        public static String Base64Encode(string str)
        {
            return Convert.ToBase64String(
                Encoding.ASCII.GetBytes(str)
            );
        }
        public static String Base64Decode(string str)
        {
            byte[] retval;
            try
            {
                retval = Convert.FromBase64String(str);
            }
            catch (System.Exception)
            {
                Console.Write("Incorrect Formatting.");
                return "";
                // throw;
            }
            return Encoding.ASCII.GetString(
                retval
            );
        }
        public static String StringToBinary(string str)
        {
            Byte[] data = ConvertToByteArray(str, Encoding.ASCII);

            return string.Join("", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
        public static String StringToHex(string str)
        {
            Byte[] data = ConvertToByteArray(str, Encoding.ASCII);

            return string.Join("", data.Select(byt => Convert.ToString(byt, 16).PadLeft(2, '0')));
        }
        public static String BinaryToString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i += 8)
            {
                string subStr = str.Substring(i, 8);
                sb.Append(Convert.ToChar(Convert.ToUInt32(subStr, 2)));
            }
            return sb.ToString();
        }
        public static String HexToString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i += 2)
            {
                string subStr = str.Substring(i, 2);
                sb.Append(Convert.ToChar(Convert.ToUInt32(subStr, 16)));
            }
            return sb.ToString();
        }
        public static void Pause()
        {
            Console.Write("\nPress Enter to continue...");
            Console.Read();
        }
        public static void Copy(string output, bool inform = false)
        {
            if (inform)
            {
                Console.WriteLine(output + "\n\nCopied to Clipboard");
            }

            Clipboard.SetText(output);
        }
    }
}
