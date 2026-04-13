using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private TMP_Dropdown _dropdown;

    private int _sceneIndx = 1;

    public void ChangeDifficulty()
    {

        _sceneIndx = _dropdown.value + 1;

    }

    public void PlayScene()
    {

        SceneManager.LoadScene(_sceneIndx);

    }

}
