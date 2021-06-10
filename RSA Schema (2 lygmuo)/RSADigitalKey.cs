using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSA_Schema__2_lygmuo_
{
    public class RSADigitalKey
    {
        byte[] D = { 223, 92, 55, 152, 207, 56, 247, 45, 172, 51, 30, 216, 213, 40, 245, 80, 129, 240, 99, 223, 119, 188, 218, 186, 165, 65, 118, 193, 173, 22, 240, 130, 16, 168, 161, 19, 117, 38, 195, 197, 212, 62, 186, 61, 69, 254, 70, 157, 142, 32, 83, 91, 127, 174, 23, 224, 165, 139, 187, 212, 153, 134, 97, 7, 123, 128, 10, 2, 160, 52, 160, 64, 68, 174, 39, 7, 33, 177, 146, 189, 190, 66, 6, 241, 8, 13, 136, 212, 248, 23, 202, 48, 28, 242, 140, 167, 160, 123, 202, 33, 173, 107, 0, 59, 170, 72, 66, 42, 14, 123, 118, 144, 100, 68, 245, 144, 127, 63, 63, 190, 239, 183, 140, 55, 79, 129, 49, 97 };
        byte[] DP = { 119, 177, 187, 175, 103, 25, 16, 196, 141, 132, 216, 104, 3, 235, 236, 121, 107, 78, 233, 242, 75, 63, 120, 128, 11, 56, 229, 220, 29, 207, 54, 129, 75, 52, 78, 106, 148, 131, 137, 31, 145, 170, 236, 158, 182, 96, 82, 175, 118, 58, 206, 246, 125, 75, 138, 96, 84, 106, 137, 68, 5, 106, 247, 235 };
        byte[] DQ = { 241, 60, 112, 97, 243, 147, 23, 100, 210, 147, 191, 55, 209, 215, 181, 141, 161, 192, 92, 236, 57, 40, 110, 28, 37, 119, 25, 68, 180, 144, 226, 8, 198, 89, 6, 234, 74, 116, 214, 231, 239, 146, 252, 42, 138, 22, 135, 82, 255, 238, 166, 11, 233, 162, 43, 82, 141, 164, 105, 85, 53, 19, 253, 101 };
        byte[] Exponent = { 1, 0, 1 };
        byte[] InverseQ = { 216, 133, 143, 220, 150, 131, 165, 13, 68, 160, 80, 9, 246, 189, 205, 36, 223, 107, 75, 103, 94, 93, 232, 217, 76, 131, 244, 104, 209, 33, 183, 217, 244, 125, 45, 135, 216, 34, 97, 175, 119, 158, 65, 8, 74, 3, 105, 208, 178, 2, 254, 16, 24, 22, 108, 197, 88, 34, 252, 10, 150, 130, 117, 52 };
        byte[] Modulus = { 238, 184, 133, 208, 205, 138, 204, 57, 254, 119, 139, 210, 169, 86, 148, 84, 66, 239, 57, 139, 141, 229, 40, 105, 1, 73, 75, 15, 71, 121, 186, 77, 39, 210, 132, 181, 165, 187, 163, 18, 43, 60, 156, 176, 122, 158, 246, 135, 226, 153, 180, 213, 246, 193, 87, 170, 125, 41, 167, 92, 145, 221, 45, 13, 163, 211, 161, 244, 214, 158, 184, 207, 52, 211, 198, 139, 37, 227, 128, 128, 8, 69, 245, 99, 112, 98, 157, 252, 242, 29, 237, 220, 200, 50, 109, 150, 97, 103, 210, 181, 190, 51, 217, 218, 63, 103, 85, 137, 40, 93, 90, 222, 233, 192, 239, 141, 24, 157, 249, 28, 195, 152, 118, 201, 156, 189, 198, 21 };
        byte[] P = { 243, 136, 37, 52, 42, 146, 47, 223, 143, 104, 218, 30, 227, 15, 244, 55, 104, 174, 48, 129, 125, 225, 77, 236, 28, 231, 170, 68, 247, 115, 117, 12, 91, 48, 2, 39, 36, 47, 178, 214, 110, 178, 178, 46, 164, 247, 241, 14, 139, 29, 234, 145, 84, 239, 170, 66, 163, 145, 130, 143, 64, 189, 180, 47 };
        byte[] Q = { 250, 241, 82, 83, 72, 82, 239, 234, 183, 74, 224, 250, 128, 164, 231, 178, 203, 20, 40, 50, 121, 181, 96, 158, 249, 41, 144, 36, 152, 14, 184, 77, 252, 81, 90, 137, 126, 87, 185, 180, 251, 240, 188, 168, 246, 187, 83, 167, 148, 4, 205, 132, 224, 248, 245, 64, 83, 179, 121, 126, 53, 176, 164, 251 };
        public byte[] DataMain(string message)
        {
            try
            {
                
                ASCIIEncoding ByteConverter = new ASCIIEncoding();

                string dataString = message;

                
                byte[] originalData = ByteConverter.GetBytes(dataString);
                byte[] signedData;

                
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                
                RSAParameters Key = RSAalg.ExportParameters(true);
                Key.D = D;
                Key.DP = DP;
                Key.DQ = DQ;
                Key.Exponent = Exponent;
                Key.InverseQ = InverseQ;
                Key.Modulus = Modulus;
                Key.P = P;
                Key.Q = Q;
               



                
                signedData = HashAndSignBytes(originalData, Key);
                
                
                if (VerifySignedHash(originalData, signedData, Key))
                {
                    Console.WriteLine("The data was verified.");
                }
                else
                {
                    Console.WriteLine("The data does not match the signature.");
                }
                return signedData;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The data was not signed or verified");
                return null;
            }
        }
        public static byte[] HashAndSignBytes(byte[] DataToSign, RSAParameters Key)
        {
            try
            {
                
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                RSAalg.ImportParameters(Key);

               
                return RSAalg.SignData(DataToSign, SHA256.Create());
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }
        public static bool VerifySignedHash(byte[] DataToVerify, byte[] SignedData, RSAParameters Key)
        {
            try
            {
               
                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider();

                RSAalg.ImportParameters(Key);

                
                return RSAalg.VerifyData(DataToVerify, SHA256.Create(), SignedData);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
        }
    }
}
