﻿using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PotionOfLoop
{
    public class StartupManager : MonoBehaviour
    {
        public const string StartupScene = "Startup";
        public const string TutorialLevel = "TutorialLevel";
        public const string MainUI = "UICommon";

        IEnumerator Start()
        {
            DontDestroyOnLoad(gameObject);

            Init();

            yield return StartCoroutine(LoadScene());

            UI.UISystem.ShowWindow<UI.GameWindow>();

            Destroy(gameObject);
        }

        private void Init()
        {
            //AssetsManager.GetInstance();
            //UserManager.GetInstance();
        }

        IEnumerator LoadScene()
        {
            yield return SceneManager.LoadSceneAsync(MainUI);

            yield return SceneManager.LoadSceneAsync(TutorialLevel);
        }
    }
}