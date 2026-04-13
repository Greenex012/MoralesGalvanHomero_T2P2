using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    private int _score = 0;

    public int Score {
        get { return _score; }
        set {
            _score = Mathf.Clamp(value, 0, 99999);
        }
    }

    [SerializeField] private TMP_Text scoreVal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreVal.text = Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {

        scoreVal.text = Score.ToString();

    }

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Lata"))
        {

            Score += other.transform.parent.GetComponent<Lata>().Points;

            other.transform.parent.gameObject.SetActive(false);

            scoreVal.text = Score.ToString();

        }

    }
}
