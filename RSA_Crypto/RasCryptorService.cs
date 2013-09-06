using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RasCryptor
{
    public class RasCryptorService
    {
        private Encoding _encode = Encoding.UTF8;

        public Encoding Encode
        {
            get { return _encode; }
            set { _encode = value; }
        }

        private string _privateKey;

        public string PrivateKey
        {
            get { return _privateKey; }
            set { _privateKey = value; }
        }

        private string _publicKey;

        public string PublicKey
        {
            get { return _publicKey; }
            set { _publicKey = value; }
        }

        private string _KeyContainerName;

        public string KeyContainerName
        {
            get { return _KeyContainerName; }
            set { _KeyContainerName = value; }
        }

        private RSACryptoServiceProvider _rsaCrypto;

        public RasCryptorService()
            : this("RsaCspParameters_Key")
        {
        }

        public RasCryptorService(string KeyContainerName)
        {
            this.KeyContainerName = KeyContainerName;
            this.GenerateKey();
        }

        public void GenerateKey()
        {
            if (this._rsaCrypto != null)
            {
                this._rsaCrypto.PersistKeyInCsp = false;
                this._rsaCrypto.Clear();
            }

            this._rsaCrypto = new RSACryptoServiceProvider();
            this.PrivateKey = this._rsaCrypto.ToXmlString(true);
            this.PublicKey = this._rsaCrypto.ToXmlString(false);
        }

        public string EncryptString(string OriginalString)
        {
            if (string.IsNullOrEmpty(OriginalString))
            {
                throw new NotSupportedException();
            }
            var originalData = this.Encode.GetBytes(OriginalString);
            var encryptData = this.encryptor(originalData);
            var base64 = Convert.ToBase64String(encryptData);
            return base64;
        }

        private byte[] encryptor(byte[] OriginalData)
        {
            if (OriginalData == null || OriginalData.Length <= 0)
            {
                throw new NotSupportedException();
            }
            if (this._rsaCrypto == null)
            {
                throw new ArgumentNullException();
            }
            this._rsaCrypto.FromXmlString(this.PublicKey);

            var encryptData = this._rsaCrypto.Encrypt(OriginalData, false);
            return encryptData;
        }

        public string DecryptString(string EncryptString)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw new NotSupportedException();
            }
            var encryptData = Convert.FromBase64String(EncryptString);
            var decryptData = this.decryptor(encryptData);
            var decryptString = this.Encode.GetString(decryptData);
            return decryptString;
        }

        private byte[] decryptor(byte[] EncryptDada)
        {
            if (EncryptDada == null || EncryptDada.Length <= 0)
            {
                throw new NotSupportedException();
            }

            this._rsaCrypto.FromXmlString(this.PrivateKey);
            var decrtpyData = this._rsaCrypto.Decrypt(EncryptDada, false);
            return decrtpyData;
        }
    }
}