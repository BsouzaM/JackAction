using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Linq;
using UnityEngine.SceneManagement;

/// <summary>
/// A wrapper class for all necessary information about a scene to load it properly
/// </summary>
[Serializable]
public class SceneInformation
{
    [Tooltip("The name of the scene that should be loaded")]
    public string sceneName = "SceneName";
    public LoadSceneMode loadingMode = LoadSceneMode.Additive;
    [Tooltip("If false the level will be loaded asynchronous")]
    public bool synchronous = false;
}

/// <summary>
/// This script handles which and how scenes are loaded at the start.
/// It mirrors the behavior of multiscene editing results, but works in builds
/// </summary>
public class MultiSceneLoader : MonoBehaviour
{
    [Tooltip("Name of the scene in which this script lies so the scene won't be unloaded")]
    [SerializeField] private string ownScene = "Game";
    [Tooltip("Scenes that should be loaded in the normal game")]
    [SerializeField] private SceneInformation[] scenesToLoadNormalMode = null;
    [Tooltip("Scenes that should be loaded in debug mode")]
    [SerializeField] private SceneInformation[] scenesToLoadDebugMode = null;
    [Tooltip("Game objects that will be set active if in debug mode")]
    [SerializeField] private GameObject[] debugObjectsToActivate = null;
    [Tooltip("Toggle to define which setup should be loaded")]
    [SerializeField] private bool debug = false;

    void Start()
    {
        LoadLevels();
    }

    /// <summary>
    /// Loading all defined levels if they haven't been loaded already
    /// </summary>
    void LoadLevels()
    {
        Debug.Log("----------- Scene loader START -----------");
        if (debug)
        {
            // Deactivate all scenes
            Scene[] scenes = SceneManager.GetAllScenes();
            foreach (Scene scene in scenes)
            {
                bool isInLoadingArray = scenesToLoadDebugMode.Select(o => o.sceneName).Contains(scene.name);
                if (scene.isLoaded && scene.name != ownScene && !isInLoadingArray)
                {
                    Debug.LogFormat("Unloading scene {0}", scene.name);
                    SceneManager.UnloadSceneAsync(scene.buildIndex);
                }
            }

            // Load scenes
            foreach (var scene in scenesToLoadDebugMode)
            {
                LoadScene(scene);
            }

            // Activate game objects
            foreach (GameObject go in debugObjectsToActivate)
            {
                go.SetActive(true);
            }
        }
        else
        {
            foreach (var scene in scenesToLoadNormalMode)
            {
                LoadScene(scene);
            }
        }
        Debug.Log("----------- Scene loader END -------------");
    }

    /// <summary>
    /// Loads a scene with the given information.
    /// The scene won't get loaded if it already exists
    /// </summary>
    /// <param name="sceneInformation">The necessary information to define how to load which level</param>
    /// <returns>Whether or not the scene got loaded. If the scene already is loaded the method will return false.</returns>
    private bool LoadScene(SceneInformation sceneInformation)
    {
        if (!SceneManager.GetSceneByName(sceneInformation.sceneName).isLoaded)
        {
            Debug.LogFormat("Loading scene {0}", sceneInformation.sceneName);
            if (sceneInformation.synchronous)
            {
                SceneManager.LoadScene(sceneInformation.sceneName, sceneInformation.loadingMode);
            }
            else
            {
                SceneManager.LoadSceneAsync(sceneInformation.sceneName, sceneInformation.loadingMode);
            }

            return true;
        }
        Debug.LogFormat("Scene {0} already loaded or not existent", sceneInformation.sceneName);
        return false;
    }
}
