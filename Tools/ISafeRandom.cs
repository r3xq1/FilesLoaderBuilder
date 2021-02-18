namespace GameOverLoaderBuilder.Tools
{
    public interface ISafeRandom
    {
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        void NextBytes(byte[] buffer);
        double NextDouble();
    }
}