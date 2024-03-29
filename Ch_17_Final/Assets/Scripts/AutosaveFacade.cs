using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutosaveFacade : MonoBehaviour
{
    private DataConverter _dataConverter;
    private SaveSystem _saveSystem;
    private SceneController _sceneController;

    void Start()
    {
        _dataConverter = new DataConverter();
        _saveSystem = new SaveSystem();
        _sceneController = this.GetComponent<SceneController>();
    }

    public IEnumerator Save(double score)
    {
        _sceneController.PauseScene();

        float convertedScore = _dataConverter.FormatScore(score);
        _saveSystem.Save(convertedScore);

        yield return new WaitForSecondsRealtime(1.5f);
        _sceneController.UnpauseScene();
        Debug.Log("Subsystem work complete!");
    }

    public void ConvertAndSave(double score)
    {
        float convertedScore = _dataConverter.FormatScore(score);
        _saveSystem.Save(convertedScore);
    }
}