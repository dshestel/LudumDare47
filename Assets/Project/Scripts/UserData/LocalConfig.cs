using UnityEngine;

namespace PotionOfLoop
{
    public class LocalConfig
    {
        private class Keys
        {
            public static string CoinCurrency = "CoinCurrency";
            public static string LevelProgress = "LevelProgress";
            public static string ProgressByMaterialType = "ProgressBy{0}Block";
        }

        public static int LevelProgress
        {
            get => PlayerPrefs.GetInt(Keys.LevelProgress, 0);
            set => PlayerPrefs.SetInt(Keys.LevelProgress, value);
        }

        public static int CoinCurrency
        {
            get => PlayerPrefs.GetInt(Keys.CoinCurrency, 0);
            set => PlayerPrefs.SetInt(Keys.CoinCurrency, value);
        }

        //public static void SetMaterialTypeProgress(MaterialType type, int value)
        //{
        //    PlayerPrefs.SetInt(string.Format(Keys.ProgressByMaterialType, type.ToString()), value);
        //}

        //public static int GetMaterialTypeProgress(MaterialType type)
        //{
        //    return PlayerPrefs.GetInt(string.Format(Keys.ProgressByMaterialType, type.ToString()), 0);
        //}

        public static void Reset()
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }

        private static void SetBoolValue(string key, bool value)
        {
            PlayerPrefs.SetInt(key, value ? 1 : 0);
        }

        private static bool GetBoolValue(string key, bool defaultBoolValue = false)
        {
            int defaultValue = defaultBoolValue ? 1 : 0;

            return PlayerPrefs.GetInt(key, defaultValue) == 1;
        }
    }
}