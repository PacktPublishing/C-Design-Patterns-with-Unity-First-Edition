using UnityEngine;
using UnityEngine.EventSystems;
using UnityEditor;
using System.IO;
using System.Linq;
using UnityEngine.UI;

using static System.IO.Directory;
using static System.IO.Path;
using static UnityEditor.AssetDatabase;
using static UnityEngine.Application;

namespace HFToolKit
{
    public static class ToolsMenu
    {
        private static MasterConfiguration _config;
        internal static MasterConfiguration Config
        {
            get
            {
                if(_config is null)
                {
                    var guid = FindAssets("t:masterconfiguration");
                    if (guid.Length == 0)
                        return null;

                    var path = GUIDToAssetPath(guid[0]);
                    _config = LoadAssetAtPath<MasterConfiguration>(path);
                }

                return _config;
            }
        }

        private static string _folderPath;
        internal static string FolderPath 
        {
            get
            {
                if(_folderPath is null)
                {
                    var scriptName = nameof(ToolsMenu);
                    var assets = FindAssets($"t:Script {scriptName}");
                    var fullPath = GUIDToAssetPath(assets[0]);
                    var pathComponent = fullPath.Split("Assets/")[1][0..^(scriptName.Length + 3)];

                    _folderPath = $"Assets/{pathComponent}";
                }

                return _folderPath;
            }
        }

        [MenuItem("Tools/Setup/New project")]
        public static void Bootstrap()
        {
            if (Config == null)
            {
                Debug.Log("Missing configuration ScriptableObject");
                return;
            }

            if(!Config.Folders.Any() || !Config.Hierarchy.Any())
            {
                Debug.Log("Your configuration is missing information");
                return;
            }

            if(GameObject.Find(Config.Hierarchy[0]))
            {
                Debug.Log("Looks like you already started a project...");
                return;
            }

            CreateDirectories("_Project", Config.Folders);
            CreateProjectHierarchy(Config.Hierarchy);
            Refresh();
        }

        [MenuItem("Tools/Setup/New configuration")]
        public static void CreateNewConfiguration()
        {
            if(Config == null)
            {
                var newConfig = ScriptableObject.CreateInstance<MasterConfiguration>();
                newConfig.name = "Configuration";

                var uniquePath = GenerateUniqueAssetPath($"{FolderPath}/{newConfig.name}.asset");
                CreateAsset(newConfig, uniquePath);
                SaveAssets();

                EditorUtility.FocusProjectWindow();
                Selection.activeObject = newConfig;
            }
            else
            {
                Debug.Log("Configuration SO already exists...");
            }
        }

        private static void CreateDirectories(string rootFolder, params string[] folders)
        {
            var rootPath = Combine(dataPath, rootFolder);
            foreach(string folder in folders)
            {
                var directoryPath = Combine(rootPath, folder);
                CreateDirectory(directoryPath);
            }
        }

        private static void CreateProjectHierarchy(params string[] headers)
        {
            foreach(string header in headers)
            {
                var go = new GameObject(header);

                switch(header)
                {
                    case "Setup":
                        AddSetupChildren(go.transform);
                        break;
                    case "Canvases":
                        AddCanvases(go.transform);
                        break;
                    default:
                        break;
                }

                var spacer = new GameObject("--------------------");
            }
        }

        private static void AddSetupChildren(Transform parent)
        {
            GameObject[] children = {
                GameObject.Find("Main Camera"),
                GameObject.Find("Directional Light"),
                new GameObject("EventSystem",
                    typeof(EventSystem),
                    typeof(StandaloneInputModule))
            };

            foreach(var child in children)
            {
                child.transform.SetParent(parent);
            }
        }

        private static void AddCanvases(Transform parent)
        {
            var go = new GameObject("Main Canvas",
                typeof(Canvas),
                typeof(CanvasScaler),
                typeof(GraphicRaycaster));

            var canvas = go.GetComponent<Canvas>();
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            go.transform.SetParent(parent);
        }
    }
}