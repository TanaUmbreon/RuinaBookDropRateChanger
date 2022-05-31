using System;
using System.IO;
using System.Reflection;
using HarmonyLib;
using Newtonsoft.Json;
using UnityEngine;
using Resources = BookDropRateChanger.Properties.Resources;

namespace BookDropRateChanger
{
    [Harmony]
    public class BookDropRateChangerInitializer : ModInitializer
    {
        /// <summary>設定ファイルのパス</summary>
        private static readonly string SettingsFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\ModSettings.json");

        public override void OnInitializeMod()
        {
            try
            {
                var harmony = new Harmony("BookDropRateChanger");
                harmony.PatchAll();

                CreateSettingsFile();
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorOnExceptionThrown(ex);
            }
        }

        /// <summary>
        /// 既定の設定ファイルを作成します。設定ファイルが既に存在する場合は何もしません。
        /// </summary>
        private void CreateSettingsFile()
        {
            if (File.Exists(SettingsFilePath)) { return; }

            File.AppendAllText(SettingsFilePath, Resources.ModSettings);
        }

        #region 本のドロップ数の変更

        /// <summary>変更倍率の最小値</summary>
        private const float MinRate = 0.0f;
        /// <summary>変更倍率の最大値</summary>
        private const float MaxRate = 10.0f;
        /// <summary>設定ファイルから読み込みできなかった時に使用する規定の変更倍率</summary>
        private const float DefaultRate = 2.0f;
        /// <summary>倍率変更後に適応する最低ドロップ数</summary>
        private const float MinResult = 1.0f;

        /// <summary>
        /// <see cref="DropTable.CalculateDropProb(float, int)"/> メソッドが呼び出された後に実行されます。
        /// ドロップする本の数を設定ファイルの変更倍率に従って変更します。
        /// </summary>
        /// <param name="__result">メソッドの戻り値。ドロップする本の数。</param>
        [HarmonyPatch(typeof(DropTable), "CalculateDropProb")]
        [HarmonyPostfix]
        public static void DropTable_CalculateDropProb_Postfix(ref float __result)
        {
            try
            {
                float rate = LoadDropRate();

                __result *= rate;
                __result = Mathf.Max(__result, MinResult);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorOnExceptionThrown(ex);
            }
        }

        /// <summary>
        /// ドロップ数の変更倍率を設定ファイルから読み込みます。
        /// </summary>
        /// <returns></returns>
        private static float LoadDropRate()
        {
            try
            {
                string json = File.ReadAllText(SettingsFilePath);
                var settings = JsonConvert.DeserializeObject<BookDropRateChangerSettings>(json);

                return Mathf.Clamp(settings.DropRate, MinRate, MaxRate);
            }
            catch (Exception ex)
            {
                Log.Instance.ErrorOnExceptionThrown(ex);
                return DefaultRate;
            }
        }

        #endregion
    }
}
