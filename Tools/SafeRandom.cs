namespace GameOverLoaderBuilder.Tools
{
    using System;
    using System.Security.Cryptography;

    /*
        Created by r3xq1
        https://github.com/r3xq1/
        Telegram: https://t.me/r3xq1
    */

    public sealed class SafeRandom : Random, ISafeRandom
    {
        private const int POOLSIZE = 2048;

        private static readonly Lazy<RandomNumberGenerator> Rng =
            new Lazy<RandomNumberGenerator>(() => new RNGCryptoServiceProvider());
        private static readonly Lazy<object> PositionLock =
            new Lazy<object>(() => new object());
        private static readonly Lazy<byte[]> Pool =
            new Lazy<byte[]>(() => GeneratePool(new byte[POOLSIZE]));

        private static int bufferPosition;

        public SafeRandom() { }
        public SafeRandom(int Seed) : base(Seed) { }

        public static int GetNext()
        {
            while (true)
            {
                int result = (int)(GetRandomUInt32() & int.MaxValue);

                if (result != int.MaxValue)
                {
                    return result;
                }
            }
        }
        public static int GetNext(int maxValue)
        {
            if (maxValue >= 1)
            {
                return GetNext(0, maxValue);
            }
            throw new ArgumentException("Must be greater than zero.", nameof(maxValue));
        }
        public static int GetNext(int minValue, int maxValue)
        {
            if (minValue >= maxValue) throw new ArgumentException("minValue is greater than or equal to maxValue");

            long diff = maxValue - minValue;
            const long MAX = 1 + (long)uint.MaxValue;
            long limit = MAX - (MAX % diff);

            while (true)
            {
                uint rand = GetRandomUInt32();
                if (rand < limit) return (int)(minValue + (rand % diff));
            }
        }
        public static void GetNextBytes(byte[] buffer)
        {
            if (buffer == null) throw new ArgumentNullException(nameof(buffer));

            if (buffer.Length < POOLSIZE)
            {
                lock (PositionLock.Value)
                {
                    if ((POOLSIZE - bufferPosition) < buffer.Length)
                    {
                        GeneratePool(Pool.Value);
                    }
                    Buffer.BlockCopy(Pool.Value, bufferPosition, buffer, 0, buffer.Length);
                    bufferPosition += buffer.Length;
                }
            }
            else
            {
                Rng.Value.GetBytes(buffer);
            }
        }

        public static double GetNextDouble() => GetRandomUInt32() / (1.0 + uint.MaxValue);
        public override int Next() => GetNext();
        public override int Next(int maxValue) => GetNext(0, maxValue);
        public override int Next(int minValue, int maxValue) => GetNext(minValue, maxValue);
        public override void NextBytes(byte[] buffer) => GetNextBytes(buffer);
        public override double NextDouble() => GetNextDouble();
        private static byte[] GeneratePool(byte[] buffer)
        {
            bufferPosition = 0;
            Rng.Value.GetBytes(buffer);
            return buffer;
        }
        private static uint GetRandomUInt32()
        {
            uint result;
            lock (PositionLock.Value)
            {
                if ((POOLSIZE - bufferPosition) < sizeof(uint))
                {
                    GeneratePool(Pool.Value);
                }

                result = BitConverter.ToUInt32(Pool.Value, bufferPosition); bufferPosition += sizeof(uint);
            }
            return result;
        }
    }
}